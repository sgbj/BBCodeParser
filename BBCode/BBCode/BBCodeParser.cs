// Generated from BBCodeParser.g4 by ANTLR 4.0.1-SNAPSHOT
namespace BBCode.Grammar {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

public partial class BBCodeParser : Parser {
	public const int
		Name=9, OPEN=2, Value=10, EQUALS=7, SLASH=6, SEA_WS=1, S=8, SLASH_CLOSE=5, 
		CLOSE=4, TEXT=3;
	public static readonly string[] tokenNames = {
		"<INVALID>", "SEA_WS", "'['", "TEXT", "']'", "'/]'", "'/'", "'='", "S", 
		"Name", "Value"
	};
	public const int
		RULE_document = 0, RULE_content = 1, RULE_element = 2, RULE_attribute = 3, 
		RULE_chardata = 4, RULE_name = 5, RULE_value = 6;
	public static readonly string[] ruleNames = {
		"document", "content", "element", "attribute", "chardata", "name", "value"
	};

	public override string GrammarFileName { get { return "BBCodeParser.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public BBCodeParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class DocumentContext : ParserRuleContext {
		public ContentContext content() {
			return GetRuleContext<ContentContext>(0);
		}
		public DocumentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_document; }
		public override void EnterRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.EnterDocument(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.ExitDocument(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBBCodeParserVisitor<TResult> typedVisitor = visitor as IBBCodeParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDocument(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DocumentContext document() {
		DocumentContext _localctx = new DocumentContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_document);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; content();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ContentContext : ParserRuleContext {
		public ElementContext[] element() {
			return GetRuleContexts<ElementContext>();
		}
		public ChardataContext chardata(int i) {
			return GetRuleContext<ChardataContext>(i);
		}
		public ElementContext element(int i) {
			return GetRuleContext<ElementContext>(i);
		}
		public ChardataContext[] chardata() {
			return GetRuleContexts<ChardataContext>();
		}
		public ContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_content; }
		public override void EnterRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.EnterContent(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.ExitContent(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBBCodeParserVisitor<TResult> typedVisitor = visitor as IBBCodeParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitContent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ContentContext content() {
		ContentContext _localctx = new ContentContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_content);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 17;
			_la = _input.La(1);
			if (_la==SEA_WS || _la==TEXT) {
				{
				State = 16; chardata();
				}
			}

			State = 25;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=-1 ) {
				if ( _alt==1 ) {
					{
					{
					State = 19; element();
					State = 21;
					_la = _input.La(1);
					if (_la==SEA_WS || _la==TEXT) {
						{
						State = 20; chardata();
						}
					}

					}
					} 
				}
				State = 27;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElementContext : ParserRuleContext {
		public ContentContext content() {
			return GetRuleContext<ContentContext>(0);
		}
		public NameContext[] name() {
			return GetRuleContexts<NameContext>();
		}
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public NameContext name(int i) {
			return GetRuleContext<NameContext>(i);
		}
		public AttributeContext[] attribute() {
			return GetRuleContexts<AttributeContext>();
		}
		public AttributeContext attribute(int i) {
			return GetRuleContext<AttributeContext>(i);
		}
		public ElementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_element; }
		public override void EnterRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.EnterElement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.ExitElement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBBCodeParserVisitor<TResult> typedVisitor = visitor as IBBCodeParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElementContext element() {
		ElementContext _localctx = new ElementContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_element);
		int _la;
		try {
			State = 70;
			switch ( Interpreter.AdaptivePredict(_input,5,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 28; Match(OPEN);
				State = 29; name();
				State = 33;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==Name) {
					{
					{
					State = 30; attribute();
					}
					}
					State = 35;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 36; Match(CLOSE);
				State = 37; content();
				State = 38; Match(OPEN);
				State = 39; Match(SLASH);
				State = 40; name();
				State = 41; Match(CLOSE);
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 43; Match(OPEN);
				State = 44; name();
				State = 48;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==Name) {
					{
					{
					State = 45; attribute();
					}
					}
					State = 50;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 51; Match(SLASH_CLOSE);
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 53; Match(OPEN);
				State = 54; name();
				State = 55; Match(EQUALS);
				State = 56; value();
				State = 57; Match(CLOSE);
				State = 58; content();
				State = 59; Match(OPEN);
				State = 60; Match(SLASH);
				State = 61; name();
				State = 62; Match(CLOSE);
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 64; Match(OPEN);
				State = 65; name();
				State = 66; Match(EQUALS);
				State = 67; value();
				State = 68; Match(SLASH_CLOSE);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AttributeContext : ParserRuleContext {
		public NameContext name() {
			return GetRuleContext<NameContext>(0);
		}
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public AttributeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_attribute; }
		public override void EnterRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.EnterAttribute(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.ExitAttribute(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBBCodeParserVisitor<TResult> typedVisitor = visitor as IBBCodeParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAttribute(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AttributeContext attribute() {
		AttributeContext _localctx = new AttributeContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_attribute);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 72; name();
			State = 73; Match(EQUALS);
			State = 74; value();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChardataContext : ParserRuleContext {
		public ITerminalNode SEA_WS() { return GetToken(BBCodeParser.SEA_WS, 0); }
		public ITerminalNode TEXT() { return GetToken(BBCodeParser.TEXT, 0); }
		public ChardataContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_chardata; }
		public override void EnterRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.EnterChardata(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.ExitChardata(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBBCodeParserVisitor<TResult> typedVisitor = visitor as IBBCodeParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChardata(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChardataContext chardata() {
		ChardataContext _localctx = new ChardataContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_chardata);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 76;
			_la = _input.La(1);
			if ( !(_la==SEA_WS || _la==TEXT) ) {
			_errHandler.RecoverInline(this);
			}
			Consume();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NameContext : ParserRuleContext {
		public ITerminalNode Name() { return GetToken(BBCodeParser.Name, 0); }
		public NameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_name; }
		public override void EnterRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.EnterName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.ExitName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBBCodeParserVisitor<TResult> typedVisitor = visitor as IBBCodeParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NameContext name() {
		NameContext _localctx = new NameContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_name);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78; Match(Name);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public ITerminalNode Value() { return GetToken(BBCodeParser.Value, 0); }
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_value; }
		public override void EnterRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.EnterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBBCodeParserListener typedListener = listener as IBBCodeParserListener;
			if (typedListener != null) typedListener.ExitValue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBBCodeParserVisitor<TResult> typedVisitor = visitor as IBBCodeParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_value);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 80; Match(Value);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x5\x3\fU\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a"+
		"\t\a\x4\b\t\b\x3\x2\x3\x2\x3\x3\x5\x3\x14\n\x3\x3\x3\x3\x3\x5\x3\x18\n"+
		"\x3\a\x3\x1A\n\x3\f\x3\xE\x3\x1D\v\x3\x3\x4\x3\x4\x3\x4\a\x4\"\n\x4\f"+
		"\x4\xE\x4%\v\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\a\x4\x31\n\x4\f\x4\xE\x4\x34\v\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\x5\x4I\n\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3"+
		"\a\x3\b\x3\b\x3\b\x2\x2\x2\t\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x2"+
		"\x3\x4\x3\x3\x5\x5U\x2\x10\x3\x2\x2\x2\x4\x13\x3\x2\x2\x2\x6H\x3\x2\x2"+
		"\x2\bJ\x3\x2\x2\x2\nN\x3\x2\x2\x2\fP\x3\x2\x2\x2\xER\x3\x2\x2\x2\x10\x11"+
		"\x5\x4\x3\x2\x11\x3\x3\x2\x2\x2\x12\x14\x5\n\x6\x2\x13\x12\x3\x2\x2\x2"+
		"\x13\x14\x3\x2\x2\x2\x14\x1B\x3\x2\x2\x2\x15\x17\x5\x6\x4\x2\x16\x18\x5"+
		"\n\x6\x2\x17\x16\x3\x2\x2\x2\x17\x18\x3\x2\x2\x2\x18\x1A\x3\x2\x2\x2\x19"+
		"\x15\x3\x2\x2\x2\x1A\x1D\x3\x2\x2\x2\x1B\x19\x3\x2\x2\x2\x1B\x1C\x3\x2"+
		"\x2\x2\x1C\x5\x3\x2\x2\x2\x1D\x1B\x3\x2\x2\x2\x1E\x1F\a\x4\x2\x2\x1F#"+
		"\x5\f\a\x2 \"\x5\b\x5\x2! \x3\x2\x2\x2\"%\x3\x2\x2\x2#!\x3\x2\x2\x2#$"+
		"\x3\x2\x2\x2$&\x3\x2\x2\x2%#\x3\x2\x2\x2&\'\a\x6\x2\x2\'(\x5\x4\x3\x2"+
		"()\a\x4\x2\x2)*\a\b\x2\x2*+\x5\f\a\x2+,\a\x6\x2\x2,I\x3\x2\x2\x2-.\a\x4"+
		"\x2\x2.\x32\x5\f\a\x2/\x31\x5\b\x5\x2\x30/\x3\x2\x2\x2\x31\x34\x3\x2\x2"+
		"\x2\x32\x30\x3\x2\x2\x2\x32\x33\x3\x2\x2\x2\x33\x35\x3\x2\x2\x2\x34\x32"+
		"\x3\x2\x2\x2\x35\x36\a\a\x2\x2\x36I\x3\x2\x2\x2\x37\x38\a\x4\x2\x2\x38"+
		"\x39\x5\f\a\x2\x39:\a\t\x2\x2:;\x5\xE\b\x2;<\a\x6\x2\x2<=\x5\x4\x3\x2"+
		"=>\a\x4\x2\x2>?\a\b\x2\x2?@\x5\f\a\x2@\x41\a\x6\x2\x2\x41I\x3\x2\x2\x2"+
		"\x42\x43\a\x4\x2\x2\x43\x44\x5\f\a\x2\x44\x45\a\t\x2\x2\x45\x46\x5\xE"+
		"\b\x2\x46G\a\a\x2\x2GI\x3\x2\x2\x2H\x1E\x3\x2\x2\x2H-\x3\x2\x2\x2H\x37"+
		"\x3\x2\x2\x2H\x42\x3\x2\x2\x2I\a\x3\x2\x2\x2JK\x5\f\a\x2KL\a\t\x2\x2L"+
		"M\x5\xE\b\x2M\t\x3\x2\x2\x2NO\t\x2\x2\x2O\v\x3\x2\x2\x2PQ\a\v\x2\x2Q\r"+
		"\x3\x2\x2\x2RS\a\f\x2\x2S\xF\x3\x2\x2\x2\b\x13\x17\x1B#\x32H";
	public static readonly ATN _ATN =
		ATNSimulator.Deserialize(_serializedATN.ToCharArray());
}
} // namespace BBCode.Grammar
