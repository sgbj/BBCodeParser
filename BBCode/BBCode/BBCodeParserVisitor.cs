// Generated from BBCodeParser.g4 by ANTLR 4.0.1-SNAPSHOT
namespace BBCode.Grammar {
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

public interface IBBCodeParserVisitor<Result> : IParseTreeVisitor<Result> {
	Result VisitContent(BBCodeParser.ContentContext context);

	Result VisitElement(BBCodeParser.ElementContext context);

	Result VisitDocument(BBCodeParser.DocumentContext context);

	Result VisitName(BBCodeParser.NameContext context);

	Result VisitValue(BBCodeParser.ValueContext context);

	Result VisitAttribute(BBCodeParser.AttributeContext context);

	Result VisitChardata(BBCodeParser.ChardataContext context);
}
} // namespace BBCode.Grammar
