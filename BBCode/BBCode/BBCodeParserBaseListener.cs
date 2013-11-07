// Generated from BBCodeParser.g4 by ANTLR 4.0.1-SNAPSHOT
namespace BBCode.Grammar {

using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

public partial class BBCodeParserBaseListener : IBBCodeParserListener {
	public virtual void EnterContent(BBCodeParser.ContentContext context) { }
	public virtual void ExitContent(BBCodeParser.ContentContext context) { }

	public virtual void EnterElement(BBCodeParser.ElementContext context) { }
	public virtual void ExitElement(BBCodeParser.ElementContext context) { }

	public virtual void EnterDocument(BBCodeParser.DocumentContext context) { }
	public virtual void ExitDocument(BBCodeParser.DocumentContext context) { }

	public virtual void EnterName(BBCodeParser.NameContext context) { }
	public virtual void ExitName(BBCodeParser.NameContext context) { }

	public virtual void EnterValue(BBCodeParser.ValueContext context) { }
	public virtual void ExitValue(BBCodeParser.ValueContext context) { }

	public virtual void EnterAttribute(BBCodeParser.AttributeContext context) { }
	public virtual void ExitAttribute(BBCodeParser.AttributeContext context) { }

	public virtual void EnterChardata(BBCodeParser.ChardataContext context) { }
	public virtual void ExitChardata(BBCodeParser.ChardataContext context) { }

	public virtual void EnterEveryRule(ParserRuleContext context) { }
	public virtual void ExitEveryRule(ParserRuleContext context) { }
	public virtual void VisitTerminal(ITerminalNode node) { }
	public virtual void VisitErrorNode(IErrorNode node) { }
}
} // namespace BBCode.Grammar
