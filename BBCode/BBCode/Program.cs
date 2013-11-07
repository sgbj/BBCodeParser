namespace BBCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime;
    using System.Text.RegularExpressions;
    using System.Dynamic;
    using BBCode.Grammar;

    public class BBC
    {
        private Dictionary<string, Func<dynamic, string>> TehCodez = new Dictionary<string, Func<dynamic, string>>();

        static void Main(string[] args)
        {
            var bbc = BBC.Basic();
            Console.WriteLine(bbc.Transform("[date/] [b]this is bold[/b] and [code]this is [b]code[/b][/code]\nand this is [b]bold [i]italic[/i][/b]\n[url='http://google.com']test[/url]"));
        }

        public string Transform(string document)
        {
            var parser = new BBCodeParser(new CommonTokenStream(new BBCodeLexer(new AntlrInputStream(document))));
            return ParseDocument(parser.document());
        }

        private string ParseDocument(BBCodeParser.DocumentContext document)
        {
            var sb = new StringBuilder();
            if (document.ChildCount > 0)
            {
                foreach (var child in document.children)
                {
                    if (child is BBCodeParser.ChardataContext)
                        sb.Append(ParseChardata((BBCodeParser.ChardataContext)child));
                    if (child is BBCodeParser.ContentContext)
                        sb.Append(ParseContent((BBCodeParser.ContentContext)child));
                    if (child is BBCodeParser.ElementContext)
                        sb.Append(ParseElement((BBCodeParser.ElementContext)child));
                }
            }
            return sb.ToString();
        }

        private string ParseContent(BBCodeParser.ContentContext content)
        {
            var sb = new StringBuilder();
            if (content.ChildCount > 0)
            {
                foreach (var child in content.children)
                {
                    if (child is BBCodeParser.ChardataContext)
                        sb.Append(ParseChardata((BBCodeParser.ChardataContext)child));
                    if (child is BBCodeParser.ElementContext)
                        sb.Append(ParseElement((BBCodeParser.ElementContext)child));
                }
            }
            return sb.ToString();
        }

        private string ParseElement(BBCodeParser.ElementContext element)
        {
            var tagName = element.name(0).Name().GetText();

            var obj = new ExpandoObject() as IDictionary<string, object>;

            element.attribute().ToList().ForEach(a => obj[a.name().Name().GetText()] = a.value().Value().GetText().Substring(1, a.value().Value().GetText().Length - 2));

            foreach (var code in TehCodez.Keys)
            {
                var tagMatch = Regex.Match(code, @"\[(?<tag>[^\s{\]/=]+)");
                var tag = tagMatch.Groups["tag"].Value;

                if (tag != tagName) continue;
                
                var attributeMatches = Regex.Matches(code, @"{(?<attribute>[^}]+)}*");
                var attributes = from a in attributeMatches.OfType<Match>()
                                 let split = a.Value.Split(new[] { '=' }, 2)
                                 select new
                                 {
                                     Name = split[0],
                                     Value = split.Length > 1 ? split[1] : null
                                 };
                
                foreach (var a in attributes)
                    if (!obj.ContainsKey(a.Name)) 
                        obj[a.Name] = a.Value;

                var contentMatch = Regex.Match(code, @".*?\]{(?<content>.*?)}");
                var content = contentMatch.Groups["content"].Value;
                if (!string.IsNullOrWhiteSpace(content))
                {
                    var split = content.Split(new[] { '=' }, 2);
                    obj[split[0]] = element.content() != null ? element.content().GetText() : split[1];
                }

                if (element.value() != null)
                    obj[tag] = element.value().Value().GetText().Substring(1, element.value().Value().GetText().Length - 2);

                return TehCodez[code](obj);
            }

            var attributeString = string.Join(" ", element.attribute().Select(a => a.name().Name().GetText() + "=" + a.value().Value().GetText()));
            var sb = new StringBuilder();
            sb.Append("[")
              .Append(element.name(0).Name().GetText())
              .Append(!string.IsNullOrWhiteSpace(attributeString) ? " " + attributeString : "")
              .Append("]")
              .Append(ParseContent(element.content()))
              .Append("[/")
              .Append(element.name(1).Name().GetText())
              .Append("]");
            return sb.ToString();
        }

        private string ParseChardata(BBCodeParser.ChardataContext document)
        {
            return document.GetText();
        }

        public Func<dynamic, string> this[string code]
        {
            set
            {
                TehCodez[code] = value;
            }
        }

        public static BBC Basic()
        {
            var bbc = new BBC();

            bbc["[code]{text}[/code]"] =
                _ => "<pre>" + _.text + "</pre>";

            bbc["[b]{text}[/b]"] =
                _ => "<strong>" + bbc.Transform(_.text) + "</strong>";

            bbc["[i]{text}[/i]"] =
                _ => "<em>" + bbc.Transform(_.text) + "</em>";

            bbc["[date/]"] =
                _ => DateTime.Now.ToShortDateString();

            bbc["[url={url}]{text}[/url]"] =
                _ => "<a href='" + _.url + "'>" + _.text + "</a>";

            return bbc;
        }
    }
}
