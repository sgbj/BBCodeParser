// Generated from BBCodeParser.g4 by ANTLR 4.0.1-SNAPSHOT
namespace BBCode.Grammar {
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

public interface IBBCodeParserListener : IParseTreeListener {
	void EnterContent(BBCodeParser.ContentContext context);
	void ExitContent(BBCodeParser.ContentContext context);

	void EnterElement(BBCodeParser.ElementContext context);
	void ExitElement(BBCodeParser.ElementContext context);

	void EnterDocument(BBCodeParser.DocumentContext context);
	void ExitDocument(BBCodeParser.DocumentContext context);

	void EnterName(BBCodeParser.NameContext context);
	void ExitName(BBCodeParser.NameContext context);

	void EnterValue(BBCodeParser.ValueContext context);
	void ExitValue(BBCodeParser.ValueContext context);

	void EnterAttribute(BBCodeParser.AttributeContext context);
	void ExitAttribute(BBCodeParser.AttributeContext context);

	void EnterChardata(BBCodeParser.ChardataContext context);
	void ExitChardata(BBCodeParser.ChardataContext context);
}
} // namespace BBCode.Grammar
