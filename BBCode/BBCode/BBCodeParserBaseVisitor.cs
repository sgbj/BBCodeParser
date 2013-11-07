// Generated from BBCodeParser.g4 by ANTLR 4.0.1-SNAPSHOT
namespace BBCode.Grammar {
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

public partial class BBCodeParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IBBCodeParserVisitor<Result> {
	public virtual Result VisitContent(BBCodeParser.ContentContext context) { return VisitChildren(context); }

	public virtual Result VisitElement(BBCodeParser.ElementContext context) { return VisitChildren(context); }

	public virtual Result VisitDocument(BBCodeParser.DocumentContext context) { return VisitChildren(context); }

	public virtual Result VisitName(BBCodeParser.NameContext context) { return VisitChildren(context); }

	public virtual Result VisitValue(BBCodeParser.ValueContext context) { return VisitChildren(context); }

	public virtual Result VisitAttribute(BBCodeParser.AttributeContext context) { return VisitChildren(context); }

	public virtual Result VisitChardata(BBCodeParser.ChardataContext context) { return VisitChildren(context); }
}
} // namespace BBCode.Grammar
