// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-29 22:46:32

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.ClassNodes;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  plsql_msil 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class PlsqlParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "Program", "EntryPoint", "DeclareBlock", "VarList", "VarItem", "ClassDecl", "ClassDef", "ClassItems", "PackageDecl", "PackageDef", "CommandBlock", "TypeName", "VarDef", "MethodDecl", "MethodDef", "ObjectMethodDecl", "ObjectMethodDef", "ObjectItems", "Index", "CodeBlock", "MemberCall", "MethodCall", "Cast", "Expression", "ExpressionList", "StringLiteral", "Table", "Record", "CreateInstance", "Void", "BYTE", "INT", "CHAR", "BOOL", "DOUBLE", "STRING", "VOID", "TYPE", "IF", "THEN", "ELSE", "DO", "WHILE", "LOOP", "EXIT", "WHEN", "FOR", "CREATE", "BODY", "PROCEDURE", "FUNCTION", "IS", "AS", "TABLE", "ARRAY", "INDEX", "BY", "OF", "RECORD", "OBJECT", "MEMBER", "STATIC", "BEGIN", "END", "PACKAGE", "DECLARE", "SELF", "NULL", "IN", "TRUE", "FALSE", "RETURN", "PLUS", "MINUS", "MULT", "DIVIDE", "MOD", "AND", "OR", "EQUAL", "NEQUAL", "MORE", "LESS", "MOREEQ", "LESSEQ", "NOT", "ASSIGN", "PLUSASSIGN", "MINUSASSIGN", "MULTASSIGN", "DIVASSIGN", "ID", "INTEGER", "REAL", "QUOTED_STRING", "QUOTED_CHAR", "'f'", "'.'", "'('", "')'", "','", "';'", "'['", "']'"
	};
	public const int EOF=-1;
	public const int T__100=100;
	public const int T__101=101;
	public const int T__102=102;
	public const int T__103=103;
	public const int T__104=104;
	public const int T__105=105;
	public const int T__106=106;
	public const int T__107=107;
	public const int Program=4;
	public const int EntryPoint=5;
	public const int DeclareBlock=6;
	public const int VarList=7;
	public const int VarItem=8;
	public const int ClassDecl=9;
	public const int ClassDef=10;
	public const int ClassItems=11;
	public const int PackageDecl=12;
	public const int PackageDef=13;
	public const int CommandBlock=14;
	public const int TypeName=15;
	public const int VarDef=16;
	public const int MethodDecl=17;
	public const int MethodDef=18;
	public const int ObjectMethodDecl=19;
	public const int ObjectMethodDef=20;
	public const int ObjectItems=21;
	public const int Index=22;
	public const int CodeBlock=23;
	public const int MemberCall=24;
	public const int MethodCall=25;
	public const int Cast=26;
	public const int Expression=27;
	public const int ExpressionList=28;
	public const int StringLiteral=29;
	public const int Table=30;
	public const int Record=31;
	public const int CreateInstance=32;
	public const int Void=33;
	public const int BYTE=34;
	public const int INT=35;
	public const int CHAR=36;
	public const int BOOL=37;
	public const int DOUBLE=38;
	public const int STRING=39;
	public const int VOID=40;
	public const int TYPE=41;
	public const int IF=42;
	public const int THEN=43;
	public const int ELSE=44;
	public const int DO=45;
	public const int WHILE=46;
	public const int LOOP=47;
	public const int EXIT=48;
	public const int WHEN=49;
	public const int FOR=50;
	public const int CREATE=51;
	public const int BODY=52;
	public const int PROCEDURE=53;
	public const int FUNCTION=54;
	public const int IS=55;
	public const int AS=56;
	public const int TABLE=57;
	public const int ARRAY=58;
	public const int INDEX=59;
	public const int BY=60;
	public const int OF=61;
	public const int RECORD=62;
	public const int OBJECT=63;
	public const int MEMBER=64;
	public const int STATIC=65;
	public const int BEGIN=66;
	public const int END=67;
	public const int PACKAGE=68;
	public const int DECLARE=69;
	public const int SELF=70;
	public const int NULL=71;
	public const int IN=72;
	public const int TRUE=73;
	public const int FALSE=74;
	public const int RETURN=75;
	public const int PLUS=76;
	public const int MINUS=77;
	public const int MULT=78;
	public const int DIVIDE=79;
	public const int MOD=80;
	public const int AND=81;
	public const int OR=82;
	public const int EQUAL=83;
	public const int NEQUAL=84;
	public const int MORE=85;
	public const int LESS=86;
	public const int MOREEQ=87;
	public const int LESSEQ=88;
	public const int NOT=89;
	public const int ASSIGN=90;
	public const int PLUSASSIGN=91;
	public const int MINUSASSIGN=92;
	public const int MULTASSIGN=93;
	public const int DIVASSIGN=94;
	public const int ID=95;
	public const int INTEGER=96;
	public const int REAL=97;
	public const int QUOTED_STRING=98;
	public const int QUOTED_CHAR=99;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, true, false, false, false, false, false, false, 
				false, false, false, false, false, true, false, false, false, false, 
				false, false, false, false, false, false, true, false, false, false, 
				true, false, false, false, false, false, false, false, true, false, 
				true, false, false, true, false, false, false, true, , , , 
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public PlsqlParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public PlsqlParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return PlsqlParser.tokenNames; } }
	public override string GrammarFileName { get { return "Plsql.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class float__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_float_();
	partial void Leave_float_();

	// $ANTLR start "float_"
	// Plsql.g:148:1: float_ : REAL 'f' -> REAL ;
	[GrammarRule("float_")]
	private PlsqlParser.float__return float_()
	{
		Enter_float_();
		EnterRule("float_", 1);
		TraceIn("float_", 1);
		PlsqlParser.float__return retval = new PlsqlParser.float__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken REAL1=null;
		IToken char_literal2=null;

		object REAL1_tree=null;
		object char_literal2_tree=null;
		RewriteRuleITokenStream stream_REAL=new RewriteRuleITokenStream(adaptor,"token REAL");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");

		try { DebugEnterRule(GrammarFileName, "float_");
		DebugLocation(148, 1);
		try
		{
			// Plsql.g:149:2: ( REAL 'f' -> REAL )
			DebugEnterAlt(1);
			// Plsql.g:149:4: REAL 'f'
			{
			DebugLocation(149, 4);
			REAL1=(IToken)Match(input,REAL,Follow._REAL_in_float_781); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_REAL.Add(REAL1);

			DebugLocation(149, 9);
			char_literal2=(IToken)Match(input,100,Follow._100_in_float_783); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal2);



			{
			// AST REWRITE
			// elements: REAL
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 150:2: -> REAL
			{
				DebugLocation(150, 5);
				adaptor.AddChild(root_0, new FloatNode(stream_REAL.NextToken()));

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("float_", 1);
			LeaveRule("float_", 1);
			Leave_float_();
		}
		DebugLocation(151, 1);
		} finally { DebugExitRule(GrammarFileName, "float_"); }
		return retval;

	}
	// $ANTLR end "float_"

	public class bool__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bool_();
	partial void Leave_bool_();

	// $ANTLR start "bool_"
	// Plsql.g:153:1: bool_ : ( TRUE -> TRUE | FALSE -> FALSE );
	[GrammarRule("bool_")]
	private PlsqlParser.bool__return bool_()
	{
		Enter_bool_();
		EnterRule("bool_", 2);
		TraceIn("bool_", 2);
		PlsqlParser.bool__return retval = new PlsqlParser.bool__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken TRUE3=null;
		IToken FALSE4=null;

		object TRUE3_tree=null;
		object FALSE4_tree=null;
		RewriteRuleITokenStream stream_FALSE=new RewriteRuleITokenStream(adaptor,"token FALSE");
		RewriteRuleITokenStream stream_TRUE=new RewriteRuleITokenStream(adaptor,"token TRUE");

		try { DebugEnterRule(GrammarFileName, "bool_");
		DebugLocation(153, 1);
		try
		{
			// Plsql.g:154:2: ( TRUE -> TRUE | FALSE -> FALSE )
			int alt1=2;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			int LA1_0 = input.LA(1);

			if ((LA1_0==TRUE))
			{
				alt1=1;
			}
			else if ((LA1_0==FALSE))
			{
				alt1=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:154:4: TRUE
				{
				DebugLocation(154, 4);
				TRUE3=(IToken)Match(input,TRUE,Follow._TRUE_in_bool_802); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TRUE.Add(TRUE3);



				{
				// AST REWRITE
				// elements: TRUE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 154:9: -> TRUE
				{
					DebugLocation(154, 12);
					adaptor.AddChild(root_0, new BoolNode(stream_TRUE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:155:4: FALSE
				{
				DebugLocation(155, 4);
				FALSE4=(IToken)Match(input,FALSE,Follow._FALSE_in_bool_814); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FALSE.Add(FALSE4);



				{
				// AST REWRITE
				// elements: FALSE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 155:10: -> FALSE
				{
					DebugLocation(155, 13);
					adaptor.AddChild(root_0, new BoolNode(stream_FALSE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bool_", 2);
			LeaveRule("bool_", 2);
			Leave_bool_();
		}
		DebugLocation(156, 1);
		} finally { DebugExitRule(GrammarFileName, "bool_"); }
		return retval;

	}
	// $ANTLR end "bool_"

	public class string__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_string_();
	partial void Leave_string_();

	// $ANTLR start "string_"
	// Plsql.g:166:1: string_ : QUOTED_STRING ;
	[GrammarRule("string_")]
	private PlsqlParser.string__return string_()
	{
		Enter_string_();
		EnterRule("string_", 3);
		TraceIn("string_", 3);
		PlsqlParser.string__return retval = new PlsqlParser.string__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken QUOTED_STRING5=null;

		object QUOTED_STRING5_tree=null;

		try { DebugEnterRule(GrammarFileName, "string_");
		DebugLocation(166, 1);
		try
		{
			// Plsql.g:167:2: ( QUOTED_STRING )
			DebugEnterAlt(1);
			// Plsql.g:167:4: QUOTED_STRING
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(167, 4);
			QUOTED_STRING5=(IToken)Match(input,QUOTED_STRING,Follow._QUOTED_STRING_in_string_891); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			QUOTED_STRING5_tree = new StringNode(QUOTED_STRING5) ;
			adaptor.AddChild(root_0, QUOTED_STRING5_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("string_", 3);
			LeaveRule("string_", 3);
			Leave_string_();
		}
		DebugLocation(168, 1);
		} finally { DebugExitRule(GrammarFileName, "string_"); }
		return retval;

	}
	// $ANTLR end "string_"

	public class char__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_char_();
	partial void Leave_char_();

	// $ANTLR start "char_"
	// Plsql.g:170:1: char_ : QUOTED_CHAR ;
	[GrammarRule("char_")]
	private PlsqlParser.char__return char_()
	{
		Enter_char_();
		EnterRule("char_", 4);
		TraceIn("char_", 4);
		PlsqlParser.char__return retval = new PlsqlParser.char__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken QUOTED_CHAR6=null;

		object QUOTED_CHAR6_tree=null;

		try { DebugEnterRule(GrammarFileName, "char_");
		DebugLocation(170, 1);
		try
		{
			// Plsql.g:171:2: ( QUOTED_CHAR )
			DebugEnterAlt(1);
			// Plsql.g:171:4: QUOTED_CHAR
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(171, 4);
			QUOTED_CHAR6=(IToken)Match(input,QUOTED_CHAR,Follow._QUOTED_CHAR_in_char_905); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			QUOTED_CHAR6_tree = new CharNode(QUOTED_CHAR6) ;
			adaptor.AddChild(root_0, QUOTED_CHAR6_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("char_", 4);
			LeaveRule("char_", 4);
			Leave_char_();
		}
		DebugLocation(172, 1);
		} finally { DebugExitRule(GrammarFileName, "char_"); }
		return retval;

	}
	// $ANTLR end "char_"

	public class number_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_number();
	partial void Leave_number();

	// $ANTLR start "number"
	// Plsql.g:174:1: number : ( INTEGER -> INTEGER | REAL -> REAL | float_ );
	[GrammarRule("number")]
	private PlsqlParser.number_return number()
	{
		Enter_number();
		EnterRule("number", 5);
		TraceIn("number", 5);
		PlsqlParser.number_return retval = new PlsqlParser.number_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken INTEGER7=null;
		IToken REAL8=null;
		PlsqlParser.float__return float_9 = default(PlsqlParser.float__return);

		object INTEGER7_tree=null;
		object REAL8_tree=null;
		RewriteRuleITokenStream stream_INTEGER=new RewriteRuleITokenStream(adaptor,"token INTEGER");
		RewriteRuleITokenStream stream_REAL=new RewriteRuleITokenStream(adaptor,"token REAL");

		try { DebugEnterRule(GrammarFileName, "number");
		DebugLocation(174, 1);
		try
		{
			// Plsql.g:175:2: ( INTEGER -> INTEGER | REAL -> REAL | float_ )
			int alt2=3;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==INTEGER))
			{
				alt2=1;
			}
			else if ((LA2_0==REAL))
			{
				int LA2_2 = input.LA(2);

				if ((LA2_2==100))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||LA2_2==THEN||LA2_2==LOOP||(LA2_2>=TABLE && LA2_2<=ARRAY)||LA2_2==END||LA2_2==SELF||(LA2_2>=TRUE && LA2_2<=FALSE)||(LA2_2>=PLUS && LA2_2<=ASSIGN)||(LA2_2>=ID && LA2_2<=QUOTED_CHAR)||(LA2_2>=101 && LA2_2<=107)))
				{
					alt2=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:175:4: INTEGER
				{
				DebugLocation(175, 4);
				INTEGER7=(IToken)Match(input,INTEGER,Follow._INTEGER_in_number919); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_INTEGER.Add(INTEGER7);



				{
				// AST REWRITE
				// elements: INTEGER
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 175:12: -> INTEGER
				{
					DebugLocation(175, 15);
					adaptor.AddChild(root_0, new IntegerNode(stream_INTEGER.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:176:4: REAL
				{
				DebugLocation(176, 4);
				REAL8=(IToken)Match(input,REAL,Follow._REAL_in_number931); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_REAL.Add(REAL8);



				{
				// AST REWRITE
				// elements: REAL
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 176:9: -> REAL
				{
					DebugLocation(176, 12);
					adaptor.AddChild(root_0, new RealNode(stream_REAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:177:4: float_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(177, 4);
				PushFollow(Follow._float__in_number943);
				float_9=float_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, float_9.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("number", 5);
			LeaveRule("number", 5);
			Leave_number();
		}
		DebugLocation(178, 1);
		} finally { DebugExitRule(GrammarFileName, "number"); }
		return retval;

	}
	// $ANTLR end "number"

	public class type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// Plsql.g:180:1: type : ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | TABLE '(' type ')' INDEX BY type -> ^( TypeName type type ) | TABLE '(' type ')' -> ^( TypeName type ) | ARRAY '(' type ( ',' expression )? ')' -> ^( TypeName type ( expression )? ) | ID -> ID );
	[GrammarRule("type")]
	private PlsqlParser.type_return type()
	{
		Enter_type();
		EnterRule("type", 6);
		TraceIn("type", 6);
		PlsqlParser.type_return retval = new PlsqlParser.type_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken INT10=null;
		IToken BYTE11=null;
		IToken CHAR12=null;
		IToken DOUBLE13=null;
		IToken STRING14=null;
		IToken BOOL15=null;
		IToken ID16=null;
		IToken char_literal17=null;
		IToken ID18=null;
		IToken TABLE19=null;
		IToken char_literal20=null;
		IToken char_literal22=null;
		IToken INDEX23=null;
		IToken BY24=null;
		IToken TABLE26=null;
		IToken char_literal27=null;
		IToken char_literal29=null;
		IToken ARRAY30=null;
		IToken char_literal31=null;
		IToken char_literal33=null;
		IToken char_literal35=null;
		IToken ID36=null;
		PlsqlParser.type_return type21 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type25 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type28 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type32 = default(PlsqlParser.type_return);
		PlsqlParser.expression_return expression34 = default(PlsqlParser.expression_return);

		object INT10_tree=null;
		object BYTE11_tree=null;
		object CHAR12_tree=null;
		object DOUBLE13_tree=null;
		object STRING14_tree=null;
		object BOOL15_tree=null;
		object ID16_tree=null;
		object char_literal17_tree=null;
		object ID18_tree=null;
		object TABLE19_tree=null;
		object char_literal20_tree=null;
		object char_literal22_tree=null;
		object INDEX23_tree=null;
		object BY24_tree=null;
		object TABLE26_tree=null;
		object char_literal27_tree=null;
		object char_literal29_tree=null;
		object ARRAY30_tree=null;
		object char_literal31_tree=null;
		object char_literal33_tree=null;
		object char_literal35_tree=null;
		object ID36_tree=null;
		RewriteRuleITokenStream stream_INDEX=new RewriteRuleITokenStream(adaptor,"token INDEX");
		RewriteRuleITokenStream stream_BYTE=new RewriteRuleITokenStream(adaptor,"token BYTE");
		RewriteRuleITokenStream stream_BY=new RewriteRuleITokenStream(adaptor,"token BY");
		RewriteRuleITokenStream stream_BOOL=new RewriteRuleITokenStream(adaptor,"token BOOL");
		RewriteRuleITokenStream stream_CHAR=new RewriteRuleITokenStream(adaptor,"token CHAR");
		RewriteRuleITokenStream stream_DOUBLE=new RewriteRuleITokenStream(adaptor,"token DOUBLE");
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
		RewriteRuleITokenStream stream_INT=new RewriteRuleITokenStream(adaptor,"token INT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_STRING=new RewriteRuleITokenStream(adaptor,"token STRING");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(180, 1);
		try
		{
			// Plsql.g:181:2: ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | TABLE '(' type ')' INDEX BY type -> ^( TypeName type type ) | TABLE '(' type ')' -> ^( TypeName type ) | ARRAY '(' type ( ',' expression )? ')' -> ^( TypeName type ( expression )? ) | ID -> ID )
			int alt4=11;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			try
			{
				alt4 = dfa4.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:181:4: INT
				{
				DebugLocation(181, 4);
				INT10=(IToken)Match(input,INT,Follow._INT_in_type954); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_INT.Add(INT10);



				{
				// AST REWRITE
				// elements: INT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 181:8: -> INT
				{
					DebugLocation(181, 11);
					adaptor.AddChild(root_0, new TypeNode(stream_INT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:182:4: BYTE
				{
				DebugLocation(182, 4);
				BYTE11=(IToken)Match(input,BYTE,Follow._BYTE_in_type966); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BYTE.Add(BYTE11);



				{
				// AST REWRITE
				// elements: BYTE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 182:9: -> BYTE
				{
					DebugLocation(182, 12);
					adaptor.AddChild(root_0, new TypeNode(stream_BYTE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:183:4: CHAR
				{
				DebugLocation(183, 4);
				CHAR12=(IToken)Match(input,CHAR,Follow._CHAR_in_type978); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_CHAR.Add(CHAR12);



				{
				// AST REWRITE
				// elements: CHAR
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 183:9: -> CHAR
				{
					DebugLocation(183, 12);
					adaptor.AddChild(root_0, new TypeNode(stream_CHAR.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:184:4: DOUBLE
				{
				DebugLocation(184, 4);
				DOUBLE13=(IToken)Match(input,DOUBLE,Follow._DOUBLE_in_type990); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DOUBLE.Add(DOUBLE13);



				{
				// AST REWRITE
				// elements: DOUBLE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 184:11: -> DOUBLE
				{
					DebugLocation(184, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_DOUBLE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:185:4: STRING
				{
				DebugLocation(185, 4);
				STRING14=(IToken)Match(input,STRING,Follow._STRING_in_type1002); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_STRING.Add(STRING14);



				{
				// AST REWRITE
				// elements: STRING
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 185:11: -> STRING
				{
					DebugLocation(185, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_STRING.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:186:6: BOOL
				{
				DebugLocation(186, 6);
				BOOL15=(IToken)Match(input,BOOL,Follow._BOOL_in_type1016); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BOOL.Add(BOOL15);



				{
				// AST REWRITE
				// elements: BOOL
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 186:11: -> BOOL
				{
					DebugLocation(186, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_BOOL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:187:6: ID '.' ID
				{
				DebugLocation(187, 6);
				ID16=(IToken)Match(input,ID,Follow._ID_in_type1030); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID16);

				DebugLocation(187, 9);
				char_literal17=(IToken)Match(input,101,Follow._101_in_type1032); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal17);

				DebugLocation(187, 13);
				ID18=(IToken)Match(input,ID,Follow._ID_in_type1034); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID18);



				{
				// AST REWRITE
				// elements: ID, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 188:2: -> ^( TypeName ID ID )
				{
					DebugLocation(188, 6);
					// Plsql.g:188:6: ^( TypeName ID ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(188, 8);
					root_1 = (object)adaptor.BecomeRoot(new TypeNode(TypeName), root_1);

					DebugLocation(188, 27);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(188, 30);
					adaptor.AddChild(root_1, stream_ID.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Plsql.g:189:4: TABLE '(' type ')' INDEX BY type
				{
				DebugLocation(189, 4);
				TABLE19=(IToken)Match(input,TABLE,Follow._TABLE_in_type1054); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE19);

				DebugLocation(189, 10);
				char_literal20=(IToken)Match(input,102,Follow._102_in_type1056); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal20);

				DebugLocation(189, 14);
				PushFollow(Follow._type_in_type1058);
				type21=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type21.Tree);
				DebugLocation(189, 19);
				char_literal22=(IToken)Match(input,103,Follow._103_in_type1060); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal22);

				DebugLocation(189, 23);
				INDEX23=(IToken)Match(input,INDEX,Follow._INDEX_in_type1062); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_INDEX.Add(INDEX23);

				DebugLocation(189, 29);
				BY24=(IToken)Match(input,BY,Follow._BY_in_type1064); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BY.Add(BY24);

				DebugLocation(189, 32);
				PushFollow(Follow._type_in_type1066);
				type25=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type25.Tree);


				{
				// AST REWRITE
				// elements: type, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 190:2: -> ^( TypeName type type )
				{
					DebugLocation(190, 6);
					// Plsql.g:190:6: ^( TypeName type type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(190, 8);
					root_1 = (object)adaptor.BecomeRoot(new DictionaryTypeNode(TypeName), root_1);

					DebugLocation(190, 37);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(190, 42);
					adaptor.AddChild(root_1, stream_type.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// Plsql.g:191:4: TABLE '(' type ')'
				{
				DebugLocation(191, 4);
				TABLE26=(IToken)Match(input,TABLE,Follow._TABLE_in_type1086); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE26);

				DebugLocation(191, 10);
				char_literal27=(IToken)Match(input,102,Follow._102_in_type1088); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal27);

				DebugLocation(191, 14);
				PushFollow(Follow._type_in_type1090);
				type28=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type28.Tree);
				DebugLocation(191, 19);
				char_literal29=(IToken)Match(input,103,Follow._103_in_type1092); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal29);



				{
				// AST REWRITE
				// elements: type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 192:2: -> ^( TypeName type )
				{
					DebugLocation(192, 6);
					// Plsql.g:192:6: ^( TypeName type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(192, 8);
					root_1 = (object)adaptor.BecomeRoot(new TableTypeNode(TypeName), root_1);

					DebugLocation(192, 32);
					adaptor.AddChild(root_1, stream_type.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// Plsql.g:193:4: ARRAY '(' type ( ',' expression )? ')'
				{
				DebugLocation(193, 4);
				ARRAY30=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type1110); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY30);

				DebugLocation(193, 10);
				char_literal31=(IToken)Match(input,102,Follow._102_in_type1112); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal31);

				DebugLocation(193, 14);
				PushFollow(Follow._type_in_type1114);
				type32=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type32.Tree);
				DebugLocation(193, 19);
				// Plsql.g:193:19: ( ',' expression )?
				int alt3=2;
				try { DebugEnterSubRule(3);
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0==104))
				{
					alt3=1;
				}
				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:193:20: ',' expression
					{
					DebugLocation(193, 20);
					char_literal33=(IToken)Match(input,104,Follow._104_in_type1117); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal33);

					DebugLocation(193, 24);
					PushFollow(Follow._expression_in_type1119);
					expression34=expression();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expression.Add(expression34.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(3); }

				DebugLocation(193, 38);
				char_literal35=(IToken)Match(input,103,Follow._103_in_type1124); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal35);



				{
				// AST REWRITE
				// elements: expression, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 194:2: -> ^( TypeName type ( expression )? )
				{
					DebugLocation(194, 6);
					// Plsql.g:194:6: ^( TypeName type ( expression )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(194, 8);
					root_1 = (object)adaptor.BecomeRoot(new ArrayTypeNode(TypeName), root_1);

					DebugLocation(194, 32);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(194, 37);
					// Plsql.g:194:37: ( expression )?
					if ( stream_expression.HasNext )
					{
						DebugLocation(194, 37);
						adaptor.AddChild(root_1, stream_expression.NextTree());

					}
					stream_expression.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// Plsql.g:195:6: ID
				{
				DebugLocation(195, 6);
				ID36=(IToken)Match(input,ID,Follow._ID_in_type1147); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID36);



				{
				// AST REWRITE
				// elements: ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 195:9: -> ID
				{
					DebugLocation(195, 12);
					adaptor.AddChild(root_0, new TypeNode(stream_ID.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type", 6);
			LeaveRule("type", 6);
			Leave_type();
		}
		DebugLocation(196, 1);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return retval;

	}
	// $ANTLR end "type"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// Plsql.g:200:8: public program : ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) ;
	[GrammarRule("program")]
	public PlsqlParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 7);
		TraceIn("program", 7);
		PlsqlParser.program_return retval = new PlsqlParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objOrPack_return objOrPack37 = default(PlsqlParser.objOrPack_return);
		PlsqlParser.entryPoint_return entryPoint38 = default(PlsqlParser.entryPoint_return);

		RewriteRuleSubtreeStream stream_objOrPack=new RewriteRuleSubtreeStream(adaptor,"rule objOrPack");
		RewriteRuleSubtreeStream stream_entryPoint=new RewriteRuleSubtreeStream(adaptor,"rule entryPoint");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(200, 1);
		try
		{
			// Plsql.g:201:2: ( ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) )
			DebugEnterAlt(1);
			// Plsql.g:201:4: ( objOrPack )* entryPoint
			{
			DebugLocation(201, 4);
			// Plsql.g:201:4: ( objOrPack )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0==CREATE))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: objOrPack
					{
					DebugLocation(201, 4);
					PushFollow(Follow._objOrPack_in_program1170);
					objOrPack37=objOrPack();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objOrPack.Add(objOrPack37.Tree);

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(201, 15);
			PushFollow(Follow._entryPoint_in_program1173);
			entryPoint38=entryPoint();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_entryPoint.Add(entryPoint38.Tree);


			{
			// AST REWRITE
			// elements: entryPoint, objOrPack
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 202:2: -> ^( Program ( objOrPack )* entryPoint )
			{
				DebugLocation(202, 5);
				// Plsql.g:202:5: ^( Program ( objOrPack )* entryPoint )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(202, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(Program, "Program"), root_1);

				DebugLocation(202, 15);
				// Plsql.g:202:15: ( objOrPack )*
				while ( stream_objOrPack.HasNext )
				{
					DebugLocation(202, 15);
					adaptor.AddChild(root_1, stream_objOrPack.NextTree());

				}
				stream_objOrPack.Reset();
				DebugLocation(202, 26);
				adaptor.AddChild(root_1, stream_entryPoint.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 7);
			LeaveRule("program", 7);
			Leave_program();
		}
		DebugLocation(203, 1);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class objOrPack_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_objOrPack();
	partial void Leave_objOrPack();

	// $ANTLR start "objOrPack"
	// Plsql.g:205:1: objOrPack : ( object_ | package_ );
	[GrammarRule("objOrPack")]
	private PlsqlParser.objOrPack_return objOrPack()
	{
		Enter_objOrPack();
		EnterRule("objOrPack", 8);
		TraceIn("objOrPack", 8);
		PlsqlParser.objOrPack_return retval = new PlsqlParser.objOrPack_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.object__return object_39 = default(PlsqlParser.object__return);
		PlsqlParser.package__return package_40 = default(PlsqlParser.package__return);


		try { DebugEnterRule(GrammarFileName, "objOrPack");
		DebugLocation(205, 1);
		try
		{
			// Plsql.g:206:2: ( object_ | package_ )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==CREATE))
			{
				int LA6_1 = input.LA(2);

				if ((LA6_1==TYPE))
				{
					alt6=1;
				}
				else if ((LA6_1==PACKAGE))
				{
					alt6=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 6, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:206:4: object_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(206, 4);
				PushFollow(Follow._object__in_objOrPack1196);
				object_39=object_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_39.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:207:4: package_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(207, 4);
				PushFollow(Follow._package__in_objOrPack1202);
				package_40=package_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, package_40.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("objOrPack", 8);
			LeaveRule("objOrPack", 8);
			Leave_objOrPack();
		}
		DebugLocation(208, 1);
		} finally { DebugExitRule(GrammarFileName, "objOrPack"); }
		return retval;

	}
	// $ANTLR end "objOrPack"

	public class isOrAs_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_isOrAs();
	partial void Leave_isOrAs();

	// $ANTLR start "isOrAs"
	// Plsql.g:210:1: isOrAs : ( IS | AS );
	[GrammarRule("isOrAs")]
	private PlsqlParser.isOrAs_return isOrAs()
	{
		Enter_isOrAs();
		EnterRule("isOrAs", 9);
		TraceIn("isOrAs", 9);
		PlsqlParser.isOrAs_return retval = new PlsqlParser.isOrAs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set41=null;

		object set41_tree=null;

		try { DebugEnterRule(GrammarFileName, "isOrAs");
		DebugLocation(210, 1);
		try
		{
			// Plsql.g:211:2: ( IS | AS )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(211, 2);
			set41=(IToken)input.LT(1);
			if ((input.LA(1)>=IS && input.LA(1)<=AS))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set41));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("isOrAs", 9);
			LeaveRule("isOrAs", 9);
			Leave_isOrAs();
		}
		DebugLocation(213, 1);
		} finally { DebugExitRule(GrammarFileName, "isOrAs"); }
		return retval;

	}
	// $ANTLR end "isOrAs"

	public class equalityOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_equalityOperator();
	partial void Leave_equalityOperator();

	// $ANTLR start "equalityOperator"
	// Plsql.g:217:1: equalityOperator : ( EQUAL -> EQUAL | NEQUAL -> NEQUAL );
	[GrammarRule("equalityOperator")]
	private PlsqlParser.equalityOperator_return equalityOperator()
	{
		Enter_equalityOperator();
		EnterRule("equalityOperator", 10);
		TraceIn("equalityOperator", 10);
		PlsqlParser.equalityOperator_return retval = new PlsqlParser.equalityOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EQUAL42=null;
		IToken NEQUAL43=null;

		object EQUAL42_tree=null;
		object NEQUAL43_tree=null;
		RewriteRuleITokenStream stream_NEQUAL=new RewriteRuleITokenStream(adaptor,"token NEQUAL");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");

		try { DebugEnterRule(GrammarFileName, "equalityOperator");
		DebugLocation(217, 1);
		try
		{
			// Plsql.g:218:2: ( EQUAL -> EQUAL | NEQUAL -> NEQUAL )
			int alt7=2;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0==EQUAL))
			{
				alt7=1;
			}
			else if ((LA7_0==NEQUAL))
			{
				alt7=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:218:4: EQUAL
				{
				DebugLocation(218, 4);
				EQUAL42=(IToken)Match(input,EQUAL,Follow._EQUAL_in_equalityOperator1232); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL42);



				{
				// AST REWRITE
				// elements: EQUAL
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 218:10: -> EQUAL
				{
					DebugLocation(218, 13);
					adaptor.AddChild(root_0, new EqualNode(stream_EQUAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:219:4: NEQUAL
				{
				DebugLocation(219, 4);
				NEQUAL43=(IToken)Match(input,NEQUAL,Follow._NEQUAL_in_equalityOperator1244); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NEQUAL.Add(NEQUAL43);



				{
				// AST REWRITE
				// elements: NEQUAL
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 219:11: -> NEQUAL
				{
					DebugLocation(219, 14);
					adaptor.AddChild(root_0, new NotEqualNode(stream_NEQUAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("equalityOperator", 10);
			LeaveRule("equalityOperator", 10);
			Leave_equalityOperator();
		}
		DebugLocation(220, 1);
		} finally { DebugExitRule(GrammarFileName, "equalityOperator"); }
		return retval;

	}
	// $ANTLR end "equalityOperator"

	public class ineqOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_ineqOperator();
	partial void Leave_ineqOperator();

	// $ANTLR start "ineqOperator"
	// Plsql.g:222:1: ineqOperator : ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ );
	[GrammarRule("ineqOperator")]
	private PlsqlParser.ineqOperator_return ineqOperator()
	{
		Enter_ineqOperator();
		EnterRule("ineqOperator", 11);
		TraceIn("ineqOperator", 11);
		PlsqlParser.ineqOperator_return retval = new PlsqlParser.ineqOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MORE44=null;
		IToken LESS45=null;
		IToken MOREEQ46=null;
		IToken LESSEQ47=null;

		object MORE44_tree=null;
		object LESS45_tree=null;
		object MOREEQ46_tree=null;
		object LESSEQ47_tree=null;
		RewriteRuleITokenStream stream_MOREEQ=new RewriteRuleITokenStream(adaptor,"token MOREEQ");
		RewriteRuleITokenStream stream_LESSEQ=new RewriteRuleITokenStream(adaptor,"token LESSEQ");
		RewriteRuleITokenStream stream_MORE=new RewriteRuleITokenStream(adaptor,"token MORE");
		RewriteRuleITokenStream stream_LESS=new RewriteRuleITokenStream(adaptor,"token LESS");

		try { DebugEnterRule(GrammarFileName, "ineqOperator");
		DebugLocation(222, 1);
		try
		{
			// Plsql.g:223:2: ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ )
			int alt8=4;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			switch (input.LA(1))
			{
			case MORE:
				{
				alt8=1;
				}
				break;
			case LESS:
				{
				alt8=2;
				}
				break;
			case MOREEQ:
				{
				alt8=3;
				}
				break;
			case LESSEQ:
				{
				alt8=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:223:4: MORE
				{
				DebugLocation(223, 4);
				MORE44=(IToken)Match(input,MORE,Follow._MORE_in_ineqOperator1262); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MORE.Add(MORE44);



				{
				// AST REWRITE
				// elements: MORE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 223:9: -> MORE
				{
					DebugLocation(223, 12);
					adaptor.AddChild(root_0, new GreaterNode(stream_MORE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:224:4: LESS
				{
				DebugLocation(224, 4);
				LESS45=(IToken)Match(input,LESS,Follow._LESS_in_ineqOperator1274); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESS.Add(LESS45);



				{
				// AST REWRITE
				// elements: LESS
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 224:9: -> LESS
				{
					DebugLocation(224, 12);
					adaptor.AddChild(root_0, new LessNode(stream_LESS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:225:4: MOREEQ
				{
				DebugLocation(225, 4);
				MOREEQ46=(IToken)Match(input,MOREEQ,Follow._MOREEQ_in_ineqOperator1286); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOREEQ.Add(MOREEQ46);



				{
				// AST REWRITE
				// elements: MOREEQ
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 225:11: -> MOREEQ
				{
					DebugLocation(225, 14);
					adaptor.AddChild(root_0, new GreaterOrEqualNode(stream_MOREEQ.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:226:4: LESSEQ
				{
				DebugLocation(226, 4);
				LESSEQ47=(IToken)Match(input,LESSEQ,Follow._LESSEQ_in_ineqOperator1298); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESSEQ.Add(LESSEQ47);



				{
				// AST REWRITE
				// elements: LESSEQ
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 226:11: -> LESSEQ
				{
					DebugLocation(226, 14);
					adaptor.AddChild(root_0, new LessOrEqualNode(stream_LESSEQ.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ineqOperator", 11);
			LeaveRule("ineqOperator", 11);
			Leave_ineqOperator();
		}
		DebugLocation(227, 1);
		} finally { DebugExitRule(GrammarFileName, "ineqOperator"); }
		return retval;

	}
	// $ANTLR end "ineqOperator"

	public class addOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_addOperator();
	partial void Leave_addOperator();

	// $ANTLR start "addOperator"
	// Plsql.g:229:1: addOperator : ( PLUS -> PLUS | MINUS -> MINUS );
	[GrammarRule("addOperator")]
	private PlsqlParser.addOperator_return addOperator()
	{
		Enter_addOperator();
		EnterRule("addOperator", 12);
		TraceIn("addOperator", 12);
		PlsqlParser.addOperator_return retval = new PlsqlParser.addOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PLUS48=null;
		IToken MINUS49=null;

		object PLUS48_tree=null;
		object MINUS49_tree=null;
		RewriteRuleITokenStream stream_PLUS=new RewriteRuleITokenStream(adaptor,"token PLUS");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "addOperator");
		DebugLocation(229, 1);
		try
		{
			// Plsql.g:230:2: ( PLUS -> PLUS | MINUS -> MINUS )
			int alt9=2;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==PLUS))
			{
				alt9=1;
			}
			else if ((LA9_0==MINUS))
			{
				alt9=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:230:4: PLUS
				{
				DebugLocation(230, 4);
				PLUS48=(IToken)Match(input,PLUS,Follow._PLUS_in_addOperator1316); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_PLUS.Add(PLUS48);



				{
				// AST REWRITE
				// elements: PLUS
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 230:9: -> PLUS
				{
					DebugLocation(230, 12);
					adaptor.AddChild(root_0, new PlusNode(stream_PLUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:231:4: MINUS
				{
				DebugLocation(231, 4);
				MINUS49=(IToken)Match(input,MINUS,Follow._MINUS_in_addOperator1328); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS49);



				{
				// AST REWRITE
				// elements: MINUS
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 231:10: -> MINUS
				{
					DebugLocation(231, 13);
					adaptor.AddChild(root_0, new MinusNode(stream_MINUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("addOperator", 12);
			LeaveRule("addOperator", 12);
			Leave_addOperator();
		}
		DebugLocation(232, 1);
		} finally { DebugExitRule(GrammarFileName, "addOperator"); }
		return retval;

	}
	// $ANTLR end "addOperator"

	public class multOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_multOperator();
	partial void Leave_multOperator();

	// $ANTLR start "multOperator"
	// Plsql.g:234:1: multOperator : ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD );
	[GrammarRule("multOperator")]
	private PlsqlParser.multOperator_return multOperator()
	{
		Enter_multOperator();
		EnterRule("multOperator", 13);
		TraceIn("multOperator", 13);
		PlsqlParser.multOperator_return retval = new PlsqlParser.multOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MULT50=null;
		IToken DIVIDE51=null;
		IToken MOD52=null;

		object MULT50_tree=null;
		object DIVIDE51_tree=null;
		object MOD52_tree=null;
		RewriteRuleITokenStream stream_MULT=new RewriteRuleITokenStream(adaptor,"token MULT");
		RewriteRuleITokenStream stream_MOD=new RewriteRuleITokenStream(adaptor,"token MOD");
		RewriteRuleITokenStream stream_DIVIDE=new RewriteRuleITokenStream(adaptor,"token DIVIDE");

		try { DebugEnterRule(GrammarFileName, "multOperator");
		DebugLocation(234, 1);
		try
		{
			// Plsql.g:235:2: ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD )
			int alt10=3;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			switch (input.LA(1))
			{
			case MULT:
				{
				alt10=1;
				}
				break;
			case DIVIDE:
				{
				alt10=2;
				}
				break;
			case MOD:
				{
				alt10=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:235:4: MULT
				{
				DebugLocation(235, 4);
				MULT50=(IToken)Match(input,MULT,Follow._MULT_in_multOperator1346); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MULT.Add(MULT50);



				{
				// AST REWRITE
				// elements: MULT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 235:9: -> MULT
				{
					DebugLocation(235, 12);
					adaptor.AddChild(root_0, new MultNode(stream_MULT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:236:4: DIVIDE
				{
				DebugLocation(236, 4);
				DIVIDE51=(IToken)Match(input,DIVIDE,Follow._DIVIDE_in_multOperator1358); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DIVIDE.Add(DIVIDE51);



				{
				// AST REWRITE
				// elements: DIVIDE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 236:11: -> DIVIDE
				{
					DebugLocation(236, 14);
					adaptor.AddChild(root_0, new DivNode(stream_DIVIDE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:237:4: MOD
				{
				DebugLocation(237, 4);
				MOD52=(IToken)Match(input,MOD,Follow._MOD_in_multOperator1370); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOD.Add(MOD52);



				{
				// AST REWRITE
				// elements: MOD
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 237:8: -> MOD
				{
					DebugLocation(237, 11);
					adaptor.AddChild(root_0, new ModNode(stream_MOD.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("multOperator", 13);
			LeaveRule("multOperator", 13);
			Leave_multOperator();
		}
		DebugLocation(238, 1);
		} finally { DebugExitRule(GrammarFileName, "multOperator"); }
		return retval;

	}
	// $ANTLR end "multOperator"

	public class assignOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignOperator();
	partial void Leave_assignOperator();

	// $ANTLR start "assignOperator"
	// Plsql.g:240:1: assignOperator : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN );
	[GrammarRule("assignOperator")]
	private PlsqlParser.assignOperator_return assignOperator()
	{
		Enter_assignOperator();
		EnterRule("assignOperator", 14);
		TraceIn("assignOperator", 14);
		PlsqlParser.assignOperator_return retval = new PlsqlParser.assignOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set53=null;

		object set53_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignOperator");
		DebugLocation(240, 1);
		try
		{
			// Plsql.g:241:2: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(241, 2);
			set53=(IToken)input.LT(1);
			if ((input.LA(1)>=ASSIGN && input.LA(1)<=DIVASSIGN))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set53));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignOperator", 14);
			LeaveRule("assignOperator", 14);
			Leave_assignOperator();
		}
		DebugLocation(246, 1);
		} finally { DebugExitRule(GrammarFileName, "assignOperator"); }
		return retval;

	}
	// $ANTLR end "assignOperator"

	public class unaryOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_unaryOperator();
	partial void Leave_unaryOperator();

	// $ANTLR start "unaryOperator"
	// Plsql.g:248:1: unaryOperator : ( MINUS -> MINUS | NOT -> NOT );
	[GrammarRule("unaryOperator")]
	private PlsqlParser.unaryOperator_return unaryOperator()
	{
		Enter_unaryOperator();
		EnterRule("unaryOperator", 15);
		TraceIn("unaryOperator", 15);
		PlsqlParser.unaryOperator_return retval = new PlsqlParser.unaryOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS54=null;
		IToken NOT55=null;

		object MINUS54_tree=null;
		object NOT55_tree=null;
		RewriteRuleITokenStream stream_NOT=new RewriteRuleITokenStream(adaptor,"token NOT");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "unaryOperator");
		DebugLocation(248, 1);
		try
		{
			// Plsql.g:249:2: ( MINUS -> MINUS | NOT -> NOT )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==MINUS))
			{
				alt11=1;
			}
			else if ((LA11_0==NOT))
			{
				alt11=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:249:4: MINUS
				{
				DebugLocation(249, 4);
				MINUS54=(IToken)Match(input,MINUS,Follow._MINUS_in_unaryOperator1419); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS54);



				{
				// AST REWRITE
				// elements: MINUS
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 249:10: -> MINUS
				{
					DebugLocation(249, 13);
					adaptor.AddChild(root_0, new MinusNode(stream_MINUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:250:4: NOT
				{
				DebugLocation(250, 4);
				NOT55=(IToken)Match(input,NOT,Follow._NOT_in_unaryOperator1431); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NOT.Add(NOT55);



				{
				// AST REWRITE
				// elements: NOT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 250:8: -> NOT
				{
					DebugLocation(250, 11);
					adaptor.AddChild(root_0, new NotNode(stream_NOT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unaryOperator", 15);
			LeaveRule("unaryOperator", 15);
			Leave_unaryOperator();
		}
		DebugLocation(251, 1);
		} finally { DebugExitRule(GrammarFileName, "unaryOperator"); }
		return retval;

	}
	// $ANTLR end "unaryOperator"

	public class varDef_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varDef();
	partial void Leave_varDef();

	// $ANTLR start "varDef"
	// Plsql.g:256:1: varDef : ID type -> ^( VarDef ID type ) ;
	[GrammarRule("varDef")]
	private PlsqlParser.varDef_return varDef()
	{
		Enter_varDef();
		EnterRule("varDef", 16);
		TraceIn("varDef", 16);
		PlsqlParser.varDef_return retval = new PlsqlParser.varDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID56=null;
		PlsqlParser.type_return type57 = default(PlsqlParser.type_return);

		object ID56_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varDef");
		DebugLocation(256, 1);
		try
		{
			// Plsql.g:257:2: ( ID type -> ^( VarDef ID type ) )
			DebugEnterAlt(1);
			// Plsql.g:257:4: ID type
			{
			DebugLocation(257, 4);
			ID56=(IToken)Match(input,ID,Follow._ID_in_varDef1452); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID56);

			DebugLocation(257, 7);
			PushFollow(Follow._type_in_varDef1454);
			type57=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type57.Tree);


			{
			// AST REWRITE
			// elements: type, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 258:2: -> ^( VarDef ID type )
			{
				DebugLocation(258, 5);
				// Plsql.g:258:5: ^( VarDef ID type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(258, 7);
				root_1 = (object)adaptor.BecomeRoot(new VarDefNode(VarDef), root_1);

				DebugLocation(258, 26);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(258, 29);
				adaptor.AddChild(root_1, stream_type.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varDef", 16);
			LeaveRule("varDef", 16);
			Leave_varDef();
		}
		DebugLocation(259, 1);
		} finally { DebugExitRule(GrammarFileName, "varDef"); }
		return retval;

	}
	// $ANTLR end "varDef"

	public class varList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varList();
	partial void Leave_varList();

	// $ANTLR start "varList"
	// Plsql.g:261:1: varList : ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) ;
	[GrammarRule("varList")]
	private PlsqlParser.varList_return varList()
	{
		Enter_varList();
		EnterRule("varList", 17);
		TraceIn("varList", 17);
		PlsqlParser.varList_return retval = new PlsqlParser.varList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal59=null;
		PlsqlParser.varDef_return varDef58 = default(PlsqlParser.varDef_return);
		PlsqlParser.varDef_return varDef60 = default(PlsqlParser.varDef_return);

		object char_literal59_tree=null;
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_varDef=new RewriteRuleSubtreeStream(adaptor,"rule varDef");
		try { DebugEnterRule(GrammarFileName, "varList");
		DebugLocation(261, 1);
		try
		{
			// Plsql.g:262:2: ( ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) )
			DebugEnterAlt(1);
			// Plsql.g:262:4: ( varDef ( ',' varDef )* )?
			{
			DebugLocation(262, 4);
			// Plsql.g:262:4: ( varDef ( ',' varDef )* )?
			int alt13=2;
			try { DebugEnterSubRule(13);
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==ID))
			{
				alt13=1;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:262:6: varDef ( ',' varDef )*
				{
				DebugLocation(262, 6);
				PushFollow(Follow._varDef_in_varList1482);
				varDef58=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varDef.Add(varDef58.Tree);
				DebugLocation(262, 13);
				// Plsql.g:262:13: ( ',' varDef )*
				try { DebugEnterSubRule(12);
				while (true)
				{
					int alt12=2;
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0==104))
					{
						alt12=1;
					}


					} finally { DebugExitDecision(12); }
					switch ( alt12 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:262:15: ',' varDef
						{
						DebugLocation(262, 15);
						char_literal59=(IToken)Match(input,104,Follow._104_in_varList1486); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_104.Add(char_literal59);

						DebugLocation(262, 19);
						PushFollow(Follow._varDef_in_varList1488);
						varDef60=varDef();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_varDef.Add(varDef60.Tree);

						}
						break;

					default:
						goto loop12;
					}
				}

				loop12:
					;

				} finally { DebugExitSubRule(12); }


				}
				break;

			}
			} finally { DebugExitSubRule(13); }



			{
			// AST REWRITE
			// elements: varDef
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 263:2: -> ^( VarList ( varDef )* )
			{
				DebugLocation(263, 5);
				// Plsql.g:263:5: ^( VarList ( varDef )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(263, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VarList, "VarList"), root_1);

				DebugLocation(263, 15);
				// Plsql.g:263:15: ( varDef )*
				while ( stream_varDef.HasNext )
				{
					DebugLocation(263, 15);
					adaptor.AddChild(root_1, stream_varDef.NextTree());

				}
				stream_varDef.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varList", 17);
			LeaveRule("varList", 17);
			Leave_varList();
		}
		DebugLocation(264, 1);
		} finally { DebugExitRule(GrammarFileName, "varList"); }
		return retval;

	}
	// $ANTLR end "varList"

	public class methodDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methodDecl();
	partial void Leave_methodDecl();

	// $ANTLR start "methodDecl"
	// Plsql.g:266:1: methodDecl : ( procDecl | funcDecl );
	[GrammarRule("methodDecl")]
	private PlsqlParser.methodDecl_return methodDecl()
	{
		Enter_methodDecl();
		EnterRule("methodDecl", 18);
		TraceIn("methodDecl", 18);
		PlsqlParser.methodDecl_return retval = new PlsqlParser.methodDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.procDecl_return procDecl61 = default(PlsqlParser.procDecl_return);
		PlsqlParser.funcDecl_return funcDecl62 = default(PlsqlParser.funcDecl_return);


		try { DebugEnterRule(GrammarFileName, "methodDecl");
		DebugLocation(266, 1);
		try
		{
			// Plsql.g:267:2: ( procDecl | funcDecl )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			switch (input.LA(1))
			{
			case MEMBER:
				{
				int LA14_1 = input.LA(2);

				if ((LA14_1==PROCEDURE))
				{
					alt14=1;
				}
				else if ((LA14_1==FUNCTION))
				{
					alt14=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case STATIC:
				{
				int LA14_2 = input.LA(2);

				if ((LA14_2==PROCEDURE))
				{
					alt14=1;
				}
				else if ((LA14_2==FUNCTION))
				{
					alt14=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case PROCEDURE:
				{
				alt14=1;
				}
				break;
			case FUNCTION:
				{
				alt14=2;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:267:4: procDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(267, 4);
				PushFollow(Follow._procDecl_in_methodDecl1514);
				procDecl61=procDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, procDecl61.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:268:4: funcDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(268, 4);
				PushFollow(Follow._funcDecl_in_methodDecl1519);
				funcDecl62=funcDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcDecl62.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methodDecl", 18);
			LeaveRule("methodDecl", 18);
			Leave_methodDecl();
		}
		DebugLocation(269, 1);
		} finally { DebugExitRule(GrammarFileName, "methodDecl"); }
		return retval;

	}
	// $ANTLR end "methodDecl"

	public class methodModifier_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methodModifier();
	partial void Leave_methodModifier();

	// $ANTLR start "methodModifier"
	// Plsql.g:271:1: methodModifier : ( MEMBER | STATIC | -> STATIC );
	[GrammarRule("methodModifier")]
	private PlsqlParser.methodModifier_return methodModifier()
	{
		Enter_methodModifier();
		EnterRule("methodModifier", 19);
		TraceIn("methodModifier", 19);
		PlsqlParser.methodModifier_return retval = new PlsqlParser.methodModifier_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MEMBER63=null;
		IToken STATIC64=null;

		object MEMBER63_tree=null;
		object STATIC64_tree=null;

		try { DebugEnterRule(GrammarFileName, "methodModifier");
		DebugLocation(271, 1);
		try
		{
			// Plsql.g:272:2: ( MEMBER | STATIC | -> STATIC )
			int alt15=3;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			switch (input.LA(1))
			{
			case MEMBER:
				{
				alt15=1;
				}
				break;
			case STATIC:
				{
				alt15=2;
				}
				break;
			case PROCEDURE:
			case FUNCTION:
				{
				alt15=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:272:4: MEMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(272, 4);
				MEMBER63=(IToken)Match(input,MEMBER,Follow._MEMBER_in_methodModifier1530); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				MEMBER63_tree = (object)adaptor.Create(MEMBER63);
				adaptor.AddChild(root_0, MEMBER63_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:273:4: STATIC
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(273, 4);
				STATIC64=(IToken)Match(input,STATIC,Follow._STATIC_in_methodModifier1535); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				STATIC64_tree = (object)adaptor.Create(STATIC64);
				adaptor.AddChild(root_0, STATIC64_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:274:4: 
				{

				{
				// AST REWRITE
				// elements: 
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 274:4: -> STATIC
				{
					DebugLocation(274, 7);
					adaptor.AddChild(root_0, (object)adaptor.Create(STATIC, "STATIC"));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methodModifier", 19);
			LeaveRule("methodModifier", 19);
			Leave_methodModifier();
		}
		DebugLocation(275, 1);
		} finally { DebugExitRule(GrammarFileName, "methodModifier"); }
		return retval;

	}
	// $ANTLR end "methodModifier"

	public class procDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_procDecl();
	partial void Leave_procDecl();

	// $ANTLR start "procDecl"
	// Plsql.g:277:1: procDecl : methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) ;
	[GrammarRule("procDecl")]
	private PlsqlParser.procDecl_return procDecl()
	{
		Enter_procDecl();
		EnterRule("procDecl", 20);
		TraceIn("procDecl", 20);
		PlsqlParser.procDecl_return retval = new PlsqlParser.procDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROCEDURE66=null;
		IToken ID67=null;
		IToken char_literal68=null;
		IToken char_literal70=null;
		PlsqlParser.methodModifier_return methodModifier65 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList69 = default(PlsqlParser.varList_return);

		object PROCEDURE66_tree=null;
		object ID67_tree=null;
		object char_literal68_tree=null;
		object char_literal70_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "procDecl");
		DebugLocation(277, 1);
		try
		{
			// Plsql.g:278:2: ( methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:278:4: methodModifier PROCEDURE ID '(' varList ')'
			{
			DebugLocation(278, 4);
			PushFollow(Follow._methodModifier_in_procDecl1553);
			methodModifier65=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier65.Tree);
			DebugLocation(278, 19);
			PROCEDURE66=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procDecl1555); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROCEDURE.Add(PROCEDURE66);

			DebugLocation(278, 29);
			ID67=(IToken)Match(input,ID,Follow._ID_in_procDecl1557); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID67);

			DebugLocation(278, 32);
			char_literal68=(IToken)Match(input,102,Follow._102_in_procDecl1559); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal68);

			DebugLocation(278, 36);
			PushFollow(Follow._varList_in_procDecl1561);
			varList69=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList69.Tree);
			DebugLocation(278, 44);
			char_literal70=(IToken)Match(input,103,Follow._103_in_procDecl1563); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal70);



			{
			// AST REWRITE
			// elements: methodModifier, ID, varList
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 279:2: -> ^( MethodDecl ID varList Void methodModifier )
			{
				DebugLocation(279, 5);
				// Plsql.g:279:5: ^( MethodDecl ID varList Void methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(279, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(279, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(279, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(279, 45);
				adaptor.AddChild(root_1, new VoidNode(Void));
				DebugLocation(279, 60);
				adaptor.AddChild(root_1, stream_methodModifier.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("procDecl", 20);
			LeaveRule("procDecl", 20);
			Leave_procDecl();
		}
		DebugLocation(280, 1);
		} finally { DebugExitRule(GrammarFileName, "procDecl"); }
		return retval;

	}
	// $ANTLR end "procDecl"

	public class funcDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcDecl();
	partial void Leave_funcDecl();

	// $ANTLR start "funcDecl"
	// Plsql.g:282:1: funcDecl : methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) ;
	[GrammarRule("funcDecl")]
	private PlsqlParser.funcDecl_return funcDecl()
	{
		Enter_funcDecl();
		EnterRule("funcDecl", 21);
		TraceIn("funcDecl", 21);
		PlsqlParser.funcDecl_return retval = new PlsqlParser.funcDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNCTION72=null;
		IToken ID73=null;
		IToken char_literal74=null;
		IToken char_literal76=null;
		IToken RETURN77=null;
		PlsqlParser.methodModifier_return methodModifier71 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList75 = default(PlsqlParser.varList_return);
		PlsqlParser.type_return type78 = default(PlsqlParser.type_return);

		object FUNCTION72_tree=null;
		object ID73_tree=null;
		object char_literal74_tree=null;
		object char_literal76_tree=null;
		object RETURN77_tree=null;
		RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_RETURN=new RewriteRuleITokenStream(adaptor,"token RETURN");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "funcDecl");
		DebugLocation(282, 1);
		try
		{
			// Plsql.g:283:2: ( methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:283:4: methodModifier FUNCTION ID '(' varList ')' RETURN type
			{
			DebugLocation(283, 4);
			PushFollow(Follow._methodModifier_in_funcDecl1595);
			methodModifier71=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier71.Tree);
			DebugLocation(283, 19);
			FUNCTION72=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDecl1597); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNCTION.Add(FUNCTION72);

			DebugLocation(283, 28);
			ID73=(IToken)Match(input,ID,Follow._ID_in_funcDecl1599); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID73);

			DebugLocation(283, 31);
			char_literal74=(IToken)Match(input,102,Follow._102_in_funcDecl1601); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal74);

			DebugLocation(283, 35);
			PushFollow(Follow._varList_in_funcDecl1603);
			varList75=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList75.Tree);
			DebugLocation(283, 43);
			char_literal76=(IToken)Match(input,103,Follow._103_in_funcDecl1605); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal76);

			DebugLocation(283, 47);
			RETURN77=(IToken)Match(input,RETURN,Follow._RETURN_in_funcDecl1607); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RETURN.Add(RETURN77);

			DebugLocation(283, 54);
			PushFollow(Follow._type_in_funcDecl1609);
			type78=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type78.Tree);


			{
			// AST REWRITE
			// elements: ID, type, varList, methodModifier
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 284:2: -> ^( MethodDecl ID varList type methodModifier )
			{
				DebugLocation(284, 5);
				// Plsql.g:284:5: ^( MethodDecl ID varList type methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(284, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(284, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(284, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(284, 45);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(284, 50);
				adaptor.AddChild(root_1, stream_methodModifier.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcDecl", 21);
			LeaveRule("funcDecl", 21);
			Leave_funcDecl();
		}
		DebugLocation(285, 1);
		} finally { DebugExitRule(GrammarFileName, "funcDecl"); }
		return retval;

	}
	// $ANTLR end "funcDecl"

	public class methodDef_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methodDef();
	partial void Leave_methodDef();

	// $ANTLR start "methodDef"
	// Plsql.g:287:1: methodDef : methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) ;
	[GrammarRule("methodDef")]
	private PlsqlParser.methodDef_return methodDef()
	{
		Enter_methodDef();
		EnterRule("methodDef", 22);
		TraceIn("methodDef", 22);
		PlsqlParser.methodDef_return retval = new PlsqlParser.methodDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IS80=null;
		IToken BEGIN82=null;
		IToken END84=null;
		PlsqlParser.methodDecl_return methodDecl79 = default(PlsqlParser.methodDecl_return);
		PlsqlParser.declareBlock_return declareBlock81 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock83 = default(PlsqlParser.codeBlock_return);

		object IS80_tree=null;
		object BEGIN82_tree=null;
		object END84_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_methodDecl=new RewriteRuleSubtreeStream(adaptor,"rule methodDecl");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "methodDef");
		DebugLocation(287, 1);
		try
		{
			// Plsql.g:288:2: ( methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:288:4: methodDecl IS declareBlock BEGIN codeBlock END
			{
			DebugLocation(288, 4);
			PushFollow(Follow._methodDecl_in_methodDef1638);
			methodDecl79=methodDecl();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodDecl.Add(methodDecl79.Tree);
			DebugLocation(288, 15);
			IS80=(IToken)Match(input,IS,Follow._IS_in_methodDef1640); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IS.Add(IS80);

			DebugLocation(288, 18);
			PushFollow(Follow._declareBlock_in_methodDef1642);
			declareBlock81=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock81.Tree);
			DebugLocation(288, 31);
			BEGIN82=(IToken)Match(input,BEGIN,Follow._BEGIN_in_methodDef1644); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN82);

			DebugLocation(288, 37);
			PushFollow(Follow._codeBlock_in_methodDef1646);
			codeBlock83=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock83.Tree);
			DebugLocation(288, 47);
			END84=(IToken)Match(input,END,Follow._END_in_methodDef1648); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END84);



			{
			// AST REWRITE
			// elements: codeBlock, declareBlock, methodDecl
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 289:2: -> ^( MethodDef declareBlock methodDecl codeBlock )
			{
				DebugLocation(289, 5);
				// Plsql.g:289:5: ^( MethodDef declareBlock methodDecl codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(289, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(MethodDef), root_1);

				DebugLocation(289, 32);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(289, 45);
				adaptor.AddChild(root_1, stream_methodDecl.NextTree());
				DebugLocation(289, 56);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methodDef", 22);
			LeaveRule("methodDef", 22);
			Leave_methodDef();
		}
		DebugLocation(290, 1);
		} finally { DebugExitRule(GrammarFileName, "methodDef"); }
		return retval;

	}
	// $ANTLR end "methodDef"

	public class typeDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_typeDecl();
	partial void Leave_typeDecl();

	// $ANTLR start "typeDecl"
	// Plsql.g:292:1: typeDecl : ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS TABLE OF type INDEX BY type -> ^( Table ID type type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) );
	[GrammarRule("typeDecl")]
	private PlsqlParser.typeDecl_return typeDecl()
	{
		Enter_typeDecl();
		EnterRule("typeDecl", 23);
		TraceIn("typeDecl", 23);
		PlsqlParser.typeDecl_return retval = new PlsqlParser.typeDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken TYPE85=null;
		IToken ID86=null;
		IToken IS87=null;
		IToken TABLE88=null;
		IToken OF89=null;
		IToken TYPE91=null;
		IToken ID92=null;
		IToken IS93=null;
		IToken TABLE94=null;
		IToken OF95=null;
		IToken INDEX97=null;
		IToken BY98=null;
		IToken TYPE100=null;
		IToken ID101=null;
		IToken IS102=null;
		IToken RECORD103=null;
		IToken char_literal104=null;
		IToken char_literal106=null;
		PlsqlParser.type_return type90 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type96 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type99 = default(PlsqlParser.type_return);
		PlsqlParser.varList_return varList105 = default(PlsqlParser.varList_return);

		object TYPE85_tree=null;
		object ID86_tree=null;
		object IS87_tree=null;
		object TABLE88_tree=null;
		object OF89_tree=null;
		object TYPE91_tree=null;
		object ID92_tree=null;
		object IS93_tree=null;
		object TABLE94_tree=null;
		object OF95_tree=null;
		object INDEX97_tree=null;
		object BY98_tree=null;
		object TYPE100_tree=null;
		object ID101_tree=null;
		object IS102_tree=null;
		object RECORD103_tree=null;
		object char_literal104_tree=null;
		object char_literal106_tree=null;
		RewriteRuleITokenStream stream_INDEX=new RewriteRuleITokenStream(adaptor,"token INDEX");
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
		RewriteRuleITokenStream stream_BY=new RewriteRuleITokenStream(adaptor,"token BY");
		RewriteRuleITokenStream stream_RECORD=new RewriteRuleITokenStream(adaptor,"token RECORD");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "typeDecl");
		DebugLocation(292, 1);
		try
		{
			// Plsql.g:293:2: ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS TABLE OF type INDEX BY type -> ^( Table ID type type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) )
			int alt16=3;
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==TYPE))
			{
				int LA16_1 = input.LA(2);

				if ((EvaluatePredicate(synpred35_Plsql_fragment)))
				{
					alt16=1;
				}
				else if ((EvaluatePredicate(synpred36_Plsql_fragment)))
				{
					alt16=2;
				}
				else if ((true))
				{
					alt16=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 16, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 16, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:293:4: TYPE ID IS TABLE OF type
				{
				DebugLocation(293, 4);
				TYPE85=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1675); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE85);

				DebugLocation(293, 9);
				ID86=(IToken)Match(input,ID,Follow._ID_in_typeDecl1677); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID86);

				DebugLocation(293, 12);
				IS87=(IToken)Match(input,IS,Follow._IS_in_typeDecl1679); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS87);

				DebugLocation(293, 15);
				TABLE88=(IToken)Match(input,TABLE,Follow._TABLE_in_typeDecl1681); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE88);

				DebugLocation(293, 21);
				OF89=(IToken)Match(input,OF,Follow._OF_in_typeDecl1683); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF89);

				DebugLocation(293, 24);
				PushFollow(Follow._type_in_typeDecl1685);
				type90=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type90.Tree);


				{
				// AST REWRITE
				// elements: ID, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 294:2: -> ^( Table ID type )
				{
					DebugLocation(294, 5);
					// Plsql.g:294:5: ^( Table ID type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(294, 7);
					root_1 = (object)adaptor.BecomeRoot(new TableNode(Table), root_1);

					DebugLocation(294, 24);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(294, 27);
					adaptor.AddChild(root_1, stream_type.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:295:4: TYPE ID IS TABLE OF type INDEX BY type
				{
				DebugLocation(295, 4);
				TYPE91=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1704); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE91);

				DebugLocation(295, 9);
				ID92=(IToken)Match(input,ID,Follow._ID_in_typeDecl1706); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID92);

				DebugLocation(295, 12);
				IS93=(IToken)Match(input,IS,Follow._IS_in_typeDecl1708); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS93);

				DebugLocation(295, 15);
				TABLE94=(IToken)Match(input,TABLE,Follow._TABLE_in_typeDecl1710); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE94);

				DebugLocation(295, 21);
				OF95=(IToken)Match(input,OF,Follow._OF_in_typeDecl1712); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF95);

				DebugLocation(295, 24);
				PushFollow(Follow._type_in_typeDecl1714);
				type96=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type96.Tree);
				DebugLocation(295, 29);
				INDEX97=(IToken)Match(input,INDEX,Follow._INDEX_in_typeDecl1716); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_INDEX.Add(INDEX97);

				DebugLocation(295, 35);
				BY98=(IToken)Match(input,BY,Follow._BY_in_typeDecl1718); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BY.Add(BY98);

				DebugLocation(295, 38);
				PushFollow(Follow._type_in_typeDecl1720);
				type99=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type99.Tree);


				{
				// AST REWRITE
				// elements: type, ID, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 296:2: -> ^( Table ID type type )
				{
					DebugLocation(296, 5);
					// Plsql.g:296:5: ^( Table ID type type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(296, 7);
					root_1 = (object)adaptor.BecomeRoot(new DictionaryNode(Table), root_1);

					DebugLocation(296, 29);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(296, 32);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(296, 37);
					adaptor.AddChild(root_1, stream_type.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:297:4: TYPE ID IS RECORD '(' varList ')'
				{
				DebugLocation(297, 4);
				TYPE100=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1741); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE100);

				DebugLocation(297, 9);
				ID101=(IToken)Match(input,ID,Follow._ID_in_typeDecl1743); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID101);

				DebugLocation(297, 12);
				IS102=(IToken)Match(input,IS,Follow._IS_in_typeDecl1745); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS102);

				DebugLocation(297, 15);
				RECORD103=(IToken)Match(input,RECORD,Follow._RECORD_in_typeDecl1747); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_RECORD.Add(RECORD103);

				DebugLocation(297, 22);
				char_literal104=(IToken)Match(input,102,Follow._102_in_typeDecl1749); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal104);

				DebugLocation(297, 26);
				PushFollow(Follow._varList_in_typeDecl1751);
				varList105=varList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varList.Add(varList105.Tree);
				DebugLocation(297, 34);
				char_literal106=(IToken)Match(input,103,Follow._103_in_typeDecl1753); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal106);



				{
				// AST REWRITE
				// elements: varList, ID
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 298:2: -> ^( Record ID varList )
				{
					DebugLocation(298, 5);
					// Plsql.g:298:5: ^( Record ID varList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(298, 7);
					root_1 = (object)adaptor.BecomeRoot(new RecordNode(Record), root_1);

					DebugLocation(298, 26);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(298, 29);
					adaptor.AddChild(root_1, stream_varList.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("typeDecl", 23);
			LeaveRule("typeDecl", 23);
			Leave_typeDecl();
		}
		DebugLocation(299, 1);
		} finally { DebugExitRule(GrammarFileName, "typeDecl"); }
		return retval;

	}
	// $ANTLR end "typeDecl"

	public class object__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_object_();
	partial void Leave_object_();

	// $ANTLR start "object_"
	// Plsql.g:303:1: object_ : ( objectDecl | objectBody );
	[GrammarRule("object_")]
	private PlsqlParser.object__return object_()
	{
		Enter_object_();
		EnterRule("object_", 24);
		TraceIn("object_", 24);
		PlsqlParser.object__return retval = new PlsqlParser.object__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objectDecl_return objectDecl107 = default(PlsqlParser.objectDecl_return);
		PlsqlParser.objectBody_return objectBody108 = default(PlsqlParser.objectBody_return);


		try { DebugEnterRule(GrammarFileName, "object_");
		DebugLocation(303, 1);
		try
		{
			// Plsql.g:304:2: ( objectDecl | objectBody )
			int alt17=2;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			int LA17_0 = input.LA(1);

			if ((LA17_0==CREATE))
			{
				int LA17_1 = input.LA(2);

				if ((LA17_1==TYPE))
				{
					int LA17_2 = input.LA(3);

					if ((LA17_2==ID))
					{
						alt17=1;
					}
					else if ((LA17_2==BODY))
					{
						alt17=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 17, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 17, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:304:4: objectDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(304, 4);
				PushFollow(Follow._objectDecl_in_object_1780);
				objectDecl107=objectDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectDecl107.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:305:4: objectBody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(305, 4);
				PushFollow(Follow._objectBody_in_object_1785);
				objectBody108=objectBody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectBody108.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("object_", 24);
			LeaveRule("object_", 24);
			Leave_object_();
		}
		DebugLocation(306, 1);
		} finally { DebugExitRule(GrammarFileName, "object_"); }
		return retval;

	}
	// $ANTLR end "object_"

	public class objectDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_objectDecl();
	partial void Leave_objectDecl();

	// $ANTLR start "objectDecl"
	// Plsql.g:308:1: objectDecl : CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) ;
	[GrammarRule("objectDecl")]
	private PlsqlParser.objectDecl_return objectDecl()
	{
		Enter_objectDecl();
		EnterRule("objectDecl", 25);
		TraceIn("objectDecl", 25);
		PlsqlParser.objectDecl_return retval = new PlsqlParser.objectDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE109=null;
		IToken TYPE110=null;
		IToken ID111=null;
		IToken OBJECT113=null;
		IToken char_literal114=null;
		IToken char_literal116=null;
		IToken char_literal117=null;
		PlsqlParser.isOrAs_return isOrAs112 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.objectDeclItem_return objectDeclItem115 = default(PlsqlParser.objectDeclItem_return);

		object CREATE109_tree=null;
		object TYPE110_tree=null;
		object ID111_tree=null;
		object OBJECT113_tree=null;
		object char_literal114_tree=null;
		object char_literal116_tree=null;
		object char_literal117_tree=null;
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OBJECT=new RewriteRuleITokenStream(adaptor,"token OBJECT");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_objectDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule objectDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "objectDecl");
		DebugLocation(308, 1);
		try
		{
			// Plsql.g:309:2: ( CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:309:4: CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';'
			{
			DebugLocation(309, 4);
			CREATE109=(IToken)Match(input,CREATE,Follow._CREATE_in_objectDecl1796); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE109);

			DebugLocation(309, 11);
			TYPE110=(IToken)Match(input,TYPE,Follow._TYPE_in_objectDecl1798); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE110);

			DebugLocation(309, 16);
			ID111=(IToken)Match(input,ID,Follow._ID_in_objectDecl1800); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID111);

			DebugLocation(309, 19);
			PushFollow(Follow._isOrAs_in_objectDecl1802);
			isOrAs112=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs112.Tree);
			DebugLocation(309, 26);
			OBJECT113=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectDecl1804); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT113);

			DebugLocation(309, 33);
			char_literal114=(IToken)Match(input,102,Follow._102_in_objectDecl1806); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal114);

			DebugLocation(309, 37);
			// Plsql.g:309:37: ( objectDeclItem )+
			int cnt18=0;
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if (((LA18_0>=PROCEDURE && LA18_0<=FUNCTION)||(LA18_0>=MEMBER && LA18_0<=STATIC)||LA18_0==ID))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch (alt18)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: objectDeclItem
					{
					DebugLocation(309, 37);
					PushFollow(Follow._objectDeclItem_in_objectDecl1808);
					objectDeclItem115=objectDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objectDeclItem.Add(objectDeclItem115.Tree);

					}
					break;

				default:
					if (cnt18 >= 1)
						goto loop18;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee18 = new EarlyExitException( 18, input );
					DebugRecognitionException(eee18);
					throw eee18;
				}
				cnt18++;
			}
			loop18:
				;

			} finally { DebugExitSubRule(18); }

			DebugLocation(309, 53);
			char_literal116=(IToken)Match(input,103,Follow._103_in_objectDecl1811); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal116);

			DebugLocation(309, 57);
			char_literal117=(IToken)Match(input,105,Follow._105_in_objectDecl1813); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal117);



			{
			// AST REWRITE
			// elements: objectDeclItem, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 310:2: -> ^( ClassDecl ID ( objectDeclItem )+ )
			{
				DebugLocation(310, 5);
				// Plsql.g:310:5: ^( ClassDecl ID ( objectDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(310, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDeclNode(ClassDecl), root_1);

				DebugLocation(310, 32);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(310, 35);
				if ( !(stream_objectDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_objectDeclItem.HasNext )
				{
					DebugLocation(310, 35);
					adaptor.AddChild(root_1, stream_objectDeclItem.NextTree());

				}
				stream_objectDeclItem.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("objectDecl", 25);
			LeaveRule("objectDecl", 25);
			Leave_objectDecl();
		}
		DebugLocation(311, 1);
		} finally { DebugExitRule(GrammarFileName, "objectDecl"); }
		return retval;

	}
	// $ANTLR end "objectDecl"

	public class objectBody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_objectBody();
	partial void Leave_objectBody();

	// $ANTLR start "objectBody"
	// Plsql.g:313:1: objectBody : CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )* END ';' -> ^( ClassDef ID ( methodDef )* ) ;
	[GrammarRule("objectBody")]
	private PlsqlParser.objectBody_return objectBody()
	{
		Enter_objectBody();
		EnterRule("objectBody", 26);
		TraceIn("objectBody", 26);
		PlsqlParser.objectBody_return retval = new PlsqlParser.objectBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE118=null;
		IToken TYPE119=null;
		IToken BODY120=null;
		IToken ID121=null;
		IToken OBJECT123=null;
		IToken char_literal125=null;
		IToken END126=null;
		IToken char_literal127=null;
		PlsqlParser.isOrAs_return isOrAs122 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.methodDef_return methodDef124 = default(PlsqlParser.methodDef_return);

		object CREATE118_tree=null;
		object TYPE119_tree=null;
		object BODY120_tree=null;
		object ID121_tree=null;
		object OBJECT123_tree=null;
		object char_literal125_tree=null;
		object END126_tree=null;
		object char_literal127_tree=null;
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OBJECT=new RewriteRuleITokenStream(adaptor,"token OBJECT");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_methodDef=new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "objectBody");
		DebugLocation(313, 1);
		try
		{
			// Plsql.g:314:2: ( CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )* END ';' -> ^( ClassDef ID ( methodDef )* ) )
			DebugEnterAlt(1);
			// Plsql.g:314:4: CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )* END ';'
			{
			DebugLocation(314, 4);
			CREATE118=(IToken)Match(input,CREATE,Follow._CREATE_in_objectBody1839); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE118);

			DebugLocation(314, 11);
			TYPE119=(IToken)Match(input,TYPE,Follow._TYPE_in_objectBody1841); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE119);

			DebugLocation(314, 16);
			BODY120=(IToken)Match(input,BODY,Follow._BODY_in_objectBody1843); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY120);

			DebugLocation(314, 21);
			ID121=(IToken)Match(input,ID,Follow._ID_in_objectBody1845); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID121);

			DebugLocation(314, 24);
			PushFollow(Follow._isOrAs_in_objectBody1847);
			isOrAs122=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs122.Tree);
			DebugLocation(314, 31);
			OBJECT123=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectBody1849); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT123);

			DebugLocation(314, 38);
			// Plsql.g:314:38: ( methodDef ';' )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if (((LA19_0>=PROCEDURE && LA19_0<=FUNCTION)||(LA19_0>=MEMBER && LA19_0<=STATIC)))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:314:40: methodDef ';'
					{
					DebugLocation(314, 40);
					PushFollow(Follow._methodDef_in_objectBody1853);
					methodDef124=methodDef();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_methodDef.Add(methodDef124.Tree);
					DebugLocation(314, 50);
					char_literal125=(IToken)Match(input,105,Follow._105_in_objectBody1855); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_105.Add(char_literal125);


					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }

			DebugLocation(314, 57);
			END126=(IToken)Match(input,END,Follow._END_in_objectBody1860); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END126);

			DebugLocation(314, 61);
			char_literal127=(IToken)Match(input,105,Follow._105_in_objectBody1862); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal127);



			{
			// AST REWRITE
			// elements: ID, methodDef
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 315:2: -> ^( ClassDef ID ( methodDef )* )
			{
				DebugLocation(315, 5);
				// Plsql.g:315:5: ^( ClassDef ID ( methodDef )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(315, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDefNode(ClassDef), root_1);

				DebugLocation(315, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(315, 33);
				// Plsql.g:315:33: ( methodDef )*
				while ( stream_methodDef.HasNext )
				{
					DebugLocation(315, 33);
					adaptor.AddChild(root_1, stream_methodDef.NextTree());

				}
				stream_methodDef.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("objectBody", 26);
			LeaveRule("objectBody", 26);
			Leave_objectBody();
		}
		DebugLocation(316, 1);
		} finally { DebugExitRule(GrammarFileName, "objectBody"); }
		return retval;

	}
	// $ANTLR end "objectBody"

	public class objectDeclItem_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_objectDeclItem();
	partial void Leave_objectDeclItem();

	// $ANTLR start "objectDeclItem"
	// Plsql.g:318:1: objectDeclItem : ( varDef ';' | methodDecl ';' );
	[GrammarRule("objectDeclItem")]
	private PlsqlParser.objectDeclItem_return objectDeclItem()
	{
		Enter_objectDeclItem();
		EnterRule("objectDeclItem", 27);
		TraceIn("objectDeclItem", 27);
		PlsqlParser.objectDeclItem_return retval = new PlsqlParser.objectDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal129=null;
		IToken char_literal131=null;
		PlsqlParser.varDef_return varDef128 = default(PlsqlParser.varDef_return);
		PlsqlParser.methodDecl_return methodDecl130 = default(PlsqlParser.methodDecl_return);

		object char_literal129_tree=null;
		object char_literal131_tree=null;

		try { DebugEnterRule(GrammarFileName, "objectDeclItem");
		DebugLocation(318, 1);
		try
		{
			// Plsql.g:319:2: ( varDef ';' | methodDecl ';' )
			int alt20=2;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==ID))
			{
				alt20=1;
			}
			else if (((LA20_0>=PROCEDURE && LA20_0<=FUNCTION)||(LA20_0>=MEMBER && LA20_0<=STATIC)))
			{
				alt20=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:319:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(319, 4);
				PushFollow(Follow._varDef_in_objectDeclItem1888);
				varDef128=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef128.Tree);
				DebugLocation(319, 14);
				char_literal129=(IToken)Match(input,105,Follow._105_in_objectDeclItem1890); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:320:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(320, 4);
				PushFollow(Follow._methodDecl_in_objectDeclItem1896);
				methodDecl130=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl130.Tree);
				DebugLocation(320, 18);
				char_literal131=(IToken)Match(input,105,Follow._105_in_objectDeclItem1898); if (state.failed) return retval;

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("objectDeclItem", 27);
			LeaveRule("objectDeclItem", 27);
			Leave_objectDeclItem();
		}
		DebugLocation(321, 1);
		} finally { DebugExitRule(GrammarFileName, "objectDeclItem"); }
		return retval;

	}
	// $ANTLR end "objectDeclItem"

	public class package__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_package_();
	partial void Leave_package_();

	// $ANTLR start "package_"
	// Plsql.g:326:1: package_ : ( packageDecl | packageDef );
	[GrammarRule("package_")]
	private PlsqlParser.package__return package_()
	{
		Enter_package_();
		EnterRule("package_", 28);
		TraceIn("package_", 28);
		PlsqlParser.package__return retval = new PlsqlParser.package__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.packageDecl_return packageDecl132 = default(PlsqlParser.packageDecl_return);
		PlsqlParser.packageDef_return packageDef133 = default(PlsqlParser.packageDef_return);


		try { DebugEnterRule(GrammarFileName, "package_");
		DebugLocation(326, 1);
		try
		{
			// Plsql.g:327:2: ( packageDecl | packageDef )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==CREATE))
			{
				int LA21_1 = input.LA(2);

				if ((LA21_1==PACKAGE))
				{
					int LA21_2 = input.LA(3);

					if ((LA21_2==ID))
					{
						alt21=1;
					}
					else if ((LA21_2==BODY))
					{
						alt21=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 21, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 21, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:327:4: packageDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(327, 4);
				PushFollow(Follow._packageDecl_in_package_1913);
				packageDecl132=packageDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDecl132.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:328:4: packageDef
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(328, 4);
				PushFollow(Follow._packageDef_in_package_1918);
				packageDef133=packageDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDef133.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("package_", 28);
			LeaveRule("package_", 28);
			Leave_package_();
		}
		DebugLocation(329, 1);
		} finally { DebugExitRule(GrammarFileName, "package_"); }
		return retval;

	}
	// $ANTLR end "package_"

	public class packageDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_packageDecl();
	partial void Leave_packageDecl();

	// $ANTLR start "packageDecl"
	// Plsql.g:331:1: packageDecl : CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) ;
	[GrammarRule("packageDecl")]
	private PlsqlParser.packageDecl_return packageDecl()
	{
		Enter_packageDecl();
		EnterRule("packageDecl", 29);
		TraceIn("packageDecl", 29);
		PlsqlParser.packageDecl_return retval = new PlsqlParser.packageDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE134=null;
		IToken PACKAGE135=null;
		IToken ID136=null;
		IToken END139=null;
		IToken char_literal140=null;
		PlsqlParser.isOrAs_return isOrAs137 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageDeclItem_return packageDeclItem138 = default(PlsqlParser.packageDeclItem_return);

		object CREATE134_tree=null;
		object PACKAGE135_tree=null;
		object ID136_tree=null;
		object END139_tree=null;
		object char_literal140_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_packageDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule packageDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDecl");
		DebugLocation(331, 1);
		try
		{
			// Plsql.g:332:2: ( CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:332:4: CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';'
			{
			DebugLocation(332, 4);
			CREATE134=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDecl1929); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE134);

			DebugLocation(332, 11);
			PACKAGE135=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDecl1931); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE135);

			DebugLocation(332, 19);
			ID136=(IToken)Match(input,ID,Follow._ID_in_packageDecl1933); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID136);

			DebugLocation(332, 22);
			PushFollow(Follow._isOrAs_in_packageDecl1935);
			isOrAs137=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs137.Tree);
			DebugLocation(332, 29);
			// Plsql.g:332:29: ( packageDeclItem )+
			int cnt22=0;
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==TYPE||(LA22_0>=PROCEDURE && LA22_0<=FUNCTION)||(LA22_0>=MEMBER && LA22_0<=STATIC)||LA22_0==ID))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch (alt22)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: packageDeclItem
					{
					DebugLocation(332, 29);
					PushFollow(Follow._packageDeclItem_in_packageDecl1937);
					packageDeclItem138=packageDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageDeclItem.Add(packageDeclItem138.Tree);

					}
					break;

				default:
					if (cnt22 >= 1)
						goto loop22;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee22 = new EarlyExitException( 22, input );
					DebugRecognitionException(eee22);
					throw eee22;
				}
				cnt22++;
			}
			loop22:
				;

			} finally { DebugExitSubRule(22); }

			DebugLocation(332, 46);
			END139=(IToken)Match(input,END,Follow._END_in_packageDecl1940); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END139);

			DebugLocation(332, 50);
			char_literal140=(IToken)Match(input,105,Follow._105_in_packageDecl1942); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal140);



			{
			// AST REWRITE
			// elements: ID, packageDeclItem
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 333:2: -> ^( PackageDecl ID ( packageDeclItem )+ )
			{
				DebugLocation(333, 5);
				// Plsql.g:333:5: ^( PackageDecl ID ( packageDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(333, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDeclNode(PackageDecl), root_1);

				DebugLocation(333, 36);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(333, 39);
				if ( !(stream_packageDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageDeclItem.HasNext )
				{
					DebugLocation(333, 39);
					adaptor.AddChild(root_1, stream_packageDeclItem.NextTree());

				}
				stream_packageDeclItem.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("packageDecl", 29);
			LeaveRule("packageDecl", 29);
			Leave_packageDecl();
		}
		DebugLocation(334, 1);
		} finally { DebugExitRule(GrammarFileName, "packageDecl"); }
		return retval;

	}
	// $ANTLR end "packageDecl"

	public class packageDef_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_packageDef();
	partial void Leave_packageDef();

	// $ANTLR start "packageDef"
	// Plsql.g:336:1: packageDef : CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )* END ';' -> ^( PackageDef ID ( packageBodyItem )* ) ;
	[GrammarRule("packageDef")]
	private PlsqlParser.packageDef_return packageDef()
	{
		Enter_packageDef();
		EnterRule("packageDef", 30);
		TraceIn("packageDef", 30);
		PlsqlParser.packageDef_return retval = new PlsqlParser.packageDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE141=null;
		IToken PACKAGE142=null;
		IToken BODY143=null;
		IToken ID144=null;
		IToken END147=null;
		IToken char_literal148=null;
		PlsqlParser.isOrAs_return isOrAs145 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageBodyItem_return packageBodyItem146 = default(PlsqlParser.packageBodyItem_return);

		object CREATE141_tree=null;
		object PACKAGE142_tree=null;
		object BODY143_tree=null;
		object ID144_tree=null;
		object END147_tree=null;
		object char_literal148_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_packageBodyItem=new RewriteRuleSubtreeStream(adaptor,"rule packageBodyItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDef");
		DebugLocation(336, 1);
		try
		{
			// Plsql.g:337:2: ( CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )* END ';' -> ^( PackageDef ID ( packageBodyItem )* ) )
			DebugEnterAlt(1);
			// Plsql.g:337:4: CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )* END ';'
			{
			DebugLocation(337, 4);
			CREATE141=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDef1969); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE141);

			DebugLocation(337, 11);
			PACKAGE142=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDef1971); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE142);

			DebugLocation(337, 19);
			BODY143=(IToken)Match(input,BODY,Follow._BODY_in_packageDef1973); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY143);

			DebugLocation(337, 24);
			ID144=(IToken)Match(input,ID,Follow._ID_in_packageDef1975); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID144);

			DebugLocation(337, 27);
			PushFollow(Follow._isOrAs_in_packageDef1977);
			isOrAs145=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs145.Tree);
			DebugLocation(337, 34);
			// Plsql.g:337:34: ( packageBodyItem )*
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if (((LA23_0>=PROCEDURE && LA23_0<=FUNCTION)||(LA23_0>=MEMBER && LA23_0<=STATIC)))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch ( alt23 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: packageBodyItem
					{
					DebugLocation(337, 34);
					PushFollow(Follow._packageBodyItem_in_packageDef1979);
					packageBodyItem146=packageBodyItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageBodyItem.Add(packageBodyItem146.Tree);

					}
					break;

				default:
					goto loop23;
				}
			}

			loop23:
				;

			} finally { DebugExitSubRule(23); }

			DebugLocation(337, 51);
			END147=(IToken)Match(input,END,Follow._END_in_packageDef1982); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END147);

			DebugLocation(337, 55);
			char_literal148=(IToken)Match(input,105,Follow._105_in_packageDef1984); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal148);



			{
			// AST REWRITE
			// elements: ID, packageBodyItem
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 338:2: -> ^( PackageDef ID ( packageBodyItem )* )
			{
				DebugLocation(338, 5);
				// Plsql.g:338:5: ^( PackageDef ID ( packageBodyItem )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(338, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDefNode(PackageDef), root_1);

				DebugLocation(338, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(338, 37);
				// Plsql.g:338:37: ( packageBodyItem )*
				while ( stream_packageBodyItem.HasNext )
				{
					DebugLocation(338, 37);
					adaptor.AddChild(root_1, stream_packageBodyItem.NextTree());

				}
				stream_packageBodyItem.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("packageDef", 30);
			LeaveRule("packageDef", 30);
			Leave_packageDef();
		}
		DebugLocation(339, 1);
		} finally { DebugExitRule(GrammarFileName, "packageDef"); }
		return retval;

	}
	// $ANTLR end "packageDef"

	public class packageDeclItem_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_packageDeclItem();
	partial void Leave_packageDeclItem();

	// $ANTLR start "packageDeclItem"
	// Plsql.g:341:1: packageDeclItem : ( varDef ';' | typeDecl ';' | methodDecl ';' );
	[GrammarRule("packageDeclItem")]
	private PlsqlParser.packageDeclItem_return packageDeclItem()
	{
		Enter_packageDeclItem();
		EnterRule("packageDeclItem", 31);
		TraceIn("packageDeclItem", 31);
		PlsqlParser.packageDeclItem_return retval = new PlsqlParser.packageDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal150=null;
		IToken char_literal152=null;
		IToken char_literal154=null;
		PlsqlParser.varDef_return varDef149 = default(PlsqlParser.varDef_return);
		PlsqlParser.typeDecl_return typeDecl151 = default(PlsqlParser.typeDecl_return);
		PlsqlParser.methodDecl_return methodDecl153 = default(PlsqlParser.methodDecl_return);

		object char_literal150_tree=null;
		object char_literal152_tree=null;
		object char_literal154_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageDeclItem");
		DebugLocation(341, 1);
		try
		{
			// Plsql.g:342:2: ( varDef ';' | typeDecl ';' | methodDecl ';' )
			int alt24=3;
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt24=1;
				}
				break;
			case TYPE:
				{
				alt24=2;
				}
				break;
			case PROCEDURE:
			case FUNCTION:
			case MEMBER:
			case STATIC:
				{
				alt24=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:342:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(342, 4);
				PushFollow(Follow._varDef_in_packageDeclItem2010);
				varDef149=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef149.Tree);
				DebugLocation(342, 14);
				char_literal150=(IToken)Match(input,105,Follow._105_in_packageDeclItem2012); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:343:4: typeDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(343, 4);
				PushFollow(Follow._typeDecl_in_packageDeclItem2018);
				typeDecl151=typeDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeDecl151.Tree);
				DebugLocation(343, 16);
				char_literal152=(IToken)Match(input,105,Follow._105_in_packageDeclItem2020); if (state.failed) return retval;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:344:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(344, 4);
				PushFollow(Follow._methodDecl_in_packageDeclItem2026);
				methodDecl153=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl153.Tree);
				DebugLocation(344, 18);
				char_literal154=(IToken)Match(input,105,Follow._105_in_packageDeclItem2028); if (state.failed) return retval;

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("packageDeclItem", 31);
			LeaveRule("packageDeclItem", 31);
			Leave_packageDeclItem();
		}
		DebugLocation(345, 1);
		} finally { DebugExitRule(GrammarFileName, "packageDeclItem"); }
		return retval;

	}
	// $ANTLR end "packageDeclItem"

	public class packageBodyItem_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_packageBodyItem();
	partial void Leave_packageBodyItem();

	// $ANTLR start "packageBodyItem"
	// Plsql.g:347:1: packageBodyItem : methodDef ';' ;
	[GrammarRule("packageBodyItem")]
	private PlsqlParser.packageBodyItem_return packageBodyItem()
	{
		Enter_packageBodyItem();
		EnterRule("packageBodyItem", 32);
		TraceIn("packageBodyItem", 32);
		PlsqlParser.packageBodyItem_return retval = new PlsqlParser.packageBodyItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal156=null;
		PlsqlParser.methodDef_return methodDef155 = default(PlsqlParser.methodDef_return);

		object char_literal156_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageBodyItem");
		DebugLocation(347, 1);
		try
		{
			// Plsql.g:348:2: ( methodDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:348:4: methodDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(348, 4);
			PushFollow(Follow._methodDef_in_packageBodyItem2040);
			methodDef155=methodDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef155.Tree);
			DebugLocation(348, 17);
			char_literal156=(IToken)Match(input,105,Follow._105_in_packageBodyItem2042); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("packageBodyItem", 32);
			LeaveRule("packageBodyItem", 32);
			Leave_packageBodyItem();
		}
		DebugLocation(349, 1);
		} finally { DebugExitRule(GrammarFileName, "packageBodyItem"); }
		return retval;

	}
	// $ANTLR end "packageBodyItem"

	public class entryPoint_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_entryPoint();
	partial void Leave_entryPoint();

	// $ANTLR start "entryPoint"
	// Plsql.g:354:1: entryPoint : DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) ;
	[GrammarRule("entryPoint")]
	private PlsqlParser.entryPoint_return entryPoint()
	{
		Enter_entryPoint();
		EnterRule("entryPoint", 33);
		TraceIn("entryPoint", 33);
		PlsqlParser.entryPoint_return retval = new PlsqlParser.entryPoint_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DECLARE157=null;
		IToken BEGIN159=null;
		IToken END161=null;
		IToken char_literal162=null;
		PlsqlParser.declareBlock_return declareBlock158 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock160 = default(PlsqlParser.codeBlock_return);

		object DECLARE157_tree=null;
		object BEGIN159_tree=null;
		object END161_tree=null;
		object char_literal162_tree=null;
		RewriteRuleITokenStream stream_DECLARE=new RewriteRuleITokenStream(adaptor,"token DECLARE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "entryPoint");
		DebugLocation(354, 1);
		try
		{
			// Plsql.g:355:2: ( DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:355:4: DECLARE declareBlock BEGIN codeBlock END ';'
			{
			DebugLocation(355, 4);
			DECLARE157=(IToken)Match(input,DECLARE,Follow._DECLARE_in_entryPoint2057); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DECLARE.Add(DECLARE157);

			DebugLocation(355, 12);
			PushFollow(Follow._declareBlock_in_entryPoint2059);
			declareBlock158=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock158.Tree);
			DebugLocation(355, 25);
			BEGIN159=(IToken)Match(input,BEGIN,Follow._BEGIN_in_entryPoint2061); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN159);

			DebugLocation(355, 31);
			PushFollow(Follow._codeBlock_in_entryPoint2063);
			codeBlock160=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock160.Tree);
			DebugLocation(355, 41);
			END161=(IToken)Match(input,END,Follow._END_in_entryPoint2065); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END161);

			DebugLocation(355, 45);
			char_literal162=(IToken)Match(input,105,Follow._105_in_entryPoint2067); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal162);



			{
			// AST REWRITE
			// elements: codeBlock, declareBlock
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 356:2: -> ^( EntryPoint declareBlock codeBlock )
			{
				DebugLocation(356, 5);
				// Plsql.g:356:5: ^( EntryPoint declareBlock codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(356, 7);
				root_1 = (object)adaptor.BecomeRoot(new EntryPointNode(EntryPoint), root_1);

				DebugLocation(356, 34);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(356, 47);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("entryPoint", 33);
			LeaveRule("entryPoint", 33);
			Leave_entryPoint();
		}
		DebugLocation(357, 1);
		} finally { DebugExitRule(GrammarFileName, "entryPoint"); }
		return retval;

	}
	// $ANTLR end "entryPoint"

	public class declareBlock_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declareBlock();
	partial void Leave_declareBlock();

	// $ANTLR start "declareBlock"
	// Plsql.g:360:1: declareBlock : ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) ;
	[GrammarRule("declareBlock")]
	private PlsqlParser.declareBlock_return declareBlock()
	{
		Enter_declareBlock();
		EnterRule("declareBlock", 34);
		TraceIn("declareBlock", 34);
		PlsqlParser.declareBlock_return retval = new PlsqlParser.declareBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.declareItem_return declareItem163 = default(PlsqlParser.declareItem_return);

		RewriteRuleSubtreeStream stream_declareItem=new RewriteRuleSubtreeStream(adaptor,"rule declareItem");
		try { DebugEnterRule(GrammarFileName, "declareBlock");
		DebugLocation(360, 1);
		try
		{
			// Plsql.g:361:2: ( ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) )
			DebugEnterAlt(1);
			// Plsql.g:361:4: ( declareItem )*
			{
			DebugLocation(361, 4);
			// Plsql.g:361:4: ( declareItem )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==ID))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: declareItem
					{
					DebugLocation(361, 4);
					PushFollow(Follow._declareItem_in_declareBlock2093);
					declareItem163=declareItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declareItem.Add(declareItem163.Tree);

					}
					break;

				default:
					goto loop25;
				}
			}

			loop25:
				;

			} finally { DebugExitSubRule(25); }



			{
			// AST REWRITE
			// elements: declareItem
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 362:2: -> ^( DeclareBlock ( declareItem )* )
			{
				DebugLocation(362, 5);
				// Plsql.g:362:5: ^( DeclareBlock ( declareItem )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(362, 7);
				root_1 = (object)adaptor.BecomeRoot(new DeclareBlockNode(DeclareBlock), root_1);

				DebugLocation(362, 38);
				// Plsql.g:362:38: ( declareItem )*
				while ( stream_declareItem.HasNext )
				{
					DebugLocation(362, 38);
					adaptor.AddChild(root_1, stream_declareItem.NextTree());

				}
				stream_declareItem.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declareBlock", 34);
			LeaveRule("declareBlock", 34);
			Leave_declareBlock();
		}
		DebugLocation(363, 1);
		} finally { DebugExitRule(GrammarFileName, "declareBlock"); }
		return retval;

	}
	// $ANTLR end "declareBlock"

	public class declareItem_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declareItem();
	partial void Leave_declareItem();

	// $ANTLR start "declareItem"
	// Plsql.g:365:1: declareItem : varDef ';' ;
	[GrammarRule("declareItem")]
	private PlsqlParser.declareItem_return declareItem()
	{
		Enter_declareItem();
		EnterRule("declareItem", 35);
		TraceIn("declareItem", 35);
		PlsqlParser.declareItem_return retval = new PlsqlParser.declareItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal165=null;
		PlsqlParser.varDef_return varDef164 = default(PlsqlParser.varDef_return);

		object char_literal165_tree=null;

		try { DebugEnterRule(GrammarFileName, "declareItem");
		DebugLocation(365, 1);
		try
		{
			// Plsql.g:366:2: ( varDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:366:4: varDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(366, 4);
			PushFollow(Follow._varDef_in_declareItem2118);
			varDef164=varDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef164.Tree);
			DebugLocation(366, 14);
			char_literal165=(IToken)Match(input,105,Follow._105_in_declareItem2120); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declareItem", 35);
			LeaveRule("declareItem", 35);
			Leave_declareItem();
		}
		DebugLocation(367, 1);
		} finally { DebugExitRule(GrammarFileName, "declareItem"); }
		return retval;

	}
	// $ANTLR end "declareItem"

	public class codeBlock_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_codeBlock();
	partial void Leave_codeBlock();

	// $ANTLR start "codeBlock"
	// Plsql.g:369:1: codeBlock : ( command ';' )* -> ^( CodeBlock ( command )* ) ;
	[GrammarRule("codeBlock")]
	private PlsqlParser.codeBlock_return codeBlock()
	{
		Enter_codeBlock();
		EnterRule("codeBlock", 36);
		TraceIn("codeBlock", 36);
		PlsqlParser.codeBlock_return retval = new PlsqlParser.codeBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal167=null;
		PlsqlParser.command_return command166 = default(PlsqlParser.command_return);

		object char_literal167_tree=null;
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_command=new RewriteRuleSubtreeStream(adaptor,"rule command");
		try { DebugEnterRule(GrammarFileName, "codeBlock");
		DebugLocation(369, 1);
		try
		{
			// Plsql.g:370:2: ( ( command ';' )* -> ^( CodeBlock ( command )* ) )
			DebugEnterAlt(1);
			// Plsql.g:370:4: ( command ';' )*
			{
			DebugLocation(370, 4);
			// Plsql.g:370:4: ( command ';' )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==IF||(LA26_0>=WHILE && LA26_0<=LOOP)||LA26_0==FOR||(LA26_0>=TABLE && LA26_0<=ARRAY)||LA26_0==SELF||(LA26_0>=TRUE && LA26_0<=RETURN)||LA26_0==MINUS||LA26_0==NOT||(LA26_0>=ID && LA26_0<=QUOTED_CHAR)||LA26_0==102))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:370:6: command ';'
					{
					DebugLocation(370, 6);
					PushFollow(Follow._command_in_codeBlock2134);
					command166=command();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_command.Add(command166.Tree);
					DebugLocation(370, 14);
					char_literal167=(IToken)Match(input,105,Follow._105_in_codeBlock2136); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_105.Add(char_literal167);


					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }



			{
			// AST REWRITE
			// elements: command
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 371:2: -> ^( CodeBlock ( command )* )
			{
				DebugLocation(371, 5);
				// Plsql.g:371:5: ^( CodeBlock ( command )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(371, 7);
				root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(CodeBlock), root_1);

				DebugLocation(371, 32);
				// Plsql.g:371:32: ( command )*
				while ( stream_command.HasNext )
				{
					DebugLocation(371, 32);
					adaptor.AddChild(root_1, stream_command.NextTree());

				}
				stream_command.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("codeBlock", 36);
			LeaveRule("codeBlock", 36);
			Leave_codeBlock();
		}
		DebugLocation(372, 1);
		} finally { DebugExitRule(GrammarFileName, "codeBlock"); }
		return retval;

	}
	// $ANTLR end "codeBlock"

	public class command_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_command();
	partial void Leave_command();

	// $ANTLR start "command"
	// Plsql.g:374:1: command : ( assign | if_ | cycle | expression | RETURN expression );
	[GrammarRule("command")]
	private PlsqlParser.command_return command()
	{
		Enter_command();
		EnterRule("command", 37);
		TraceIn("command", 37);
		PlsqlParser.command_return retval = new PlsqlParser.command_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken RETURN172=null;
		PlsqlParser.assign_return assign168 = default(PlsqlParser.assign_return);
		PlsqlParser.if__return if_169 = default(PlsqlParser.if__return);
		PlsqlParser.cycle_return cycle170 = default(PlsqlParser.cycle_return);
		PlsqlParser.expression_return expression171 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression173 = default(PlsqlParser.expression_return);

		object RETURN172_tree=null;

		try { DebugEnterRule(GrammarFileName, "command");
		DebugLocation(374, 1);
		try
		{
			// Plsql.g:375:2: ( assign | if_ | cycle | expression | RETURN expression )
			int alt27=5;
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			try
			{
				alt27 = dfa27.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:375:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(375, 4);
				PushFollow(Follow._assign_in_command2162);
				assign168=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign168.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:376:4: if_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(376, 4);
				PushFollow(Follow._if__in_command2167);
				if_169=if_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_169.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:377:4: cycle
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(377, 4);
				PushFollow(Follow._cycle_in_command2172);
				cycle170=cycle();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle170.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:378:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(378, 4);
				PushFollow(Follow._expression_in_command2177);
				expression171=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression171.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:379:4: RETURN expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(379, 22);
				RETURN172=(IToken)Match(input,RETURN,Follow._RETURN_in_command2182); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				RETURN172_tree = new ReturnNode(RETURN172) ;
				root_0 = (object)adaptor.BecomeRoot(RETURN172_tree, root_0);
				}
				DebugLocation(379, 24);
				PushFollow(Follow._expression_in_command2188);
				expression173=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression173.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("command", 37);
			LeaveRule("command", 37);
			Leave_command();
		}
		DebugLocation(380, 1);
		} finally { DebugExitRule(GrammarFileName, "command"); }
		return retval;

	}
	// $ANTLR end "command"

	public class assign_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assign();
	partial void Leave_assign();

	// $ANTLR start "assign"
	// Plsql.g:382:1: assign : expression ASSIGN ( NULL | expression ) ;
	[GrammarRule("assign")]
	private PlsqlParser.assign_return assign()
	{
		Enter_assign();
		EnterRule("assign", 38);
		TraceIn("assign", 38);
		PlsqlParser.assign_return retval = new PlsqlParser.assign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGN175=null;
		IToken NULL176=null;
		PlsqlParser.expression_return expression174 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression177 = default(PlsqlParser.expression_return);

		object ASSIGN175_tree=null;
		object NULL176_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign");
		DebugLocation(382, 1);
		try
		{
			// Plsql.g:383:2: ( expression ASSIGN ( NULL | expression ) )
			DebugEnterAlt(1);
			// Plsql.g:383:4: expression ASSIGN ( NULL | expression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(383, 4);
			PushFollow(Follow._expression_in_assign2199);
			expression174=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression174.Tree);
			DebugLocation(383, 33);
			ASSIGN175=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign2201); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN175_tree = new AssignNode(ASSIGN175) ;
			root_0 = (object)adaptor.BecomeRoot(ASSIGN175_tree, root_0);
			}
			DebugLocation(383, 35);
			// Plsql.g:383:35: ( NULL | expression )
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==NULL))
			{
				alt28=1;
			}
			else if (((LA28_0>=TABLE && LA28_0<=ARRAY)||LA28_0==SELF||(LA28_0>=TRUE && LA28_0<=FALSE)||LA28_0==MINUS||LA28_0==NOT||(LA28_0>=ID && LA28_0<=QUOTED_CHAR)||LA28_0==102))
			{
				alt28=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:383:37: NULL
				{
				DebugLocation(383, 37);
				NULL176=(IToken)Match(input,NULL,Follow._NULL_in_assign2209); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NULL176_tree = new TypeNode(NULL176) ;
				adaptor.AddChild(root_0, NULL176_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:383:54: expression
				{
				DebugLocation(383, 54);
				PushFollow(Follow._expression_in_assign2216);
				expression177=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression177.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assign", 38);
			LeaveRule("assign", 38);
			Leave_assign();
		}
		DebugLocation(384, 1);
		} finally { DebugExitRule(GrammarFileName, "assign"); }
		return retval;

	}
	// $ANTLR end "assign"

	public class if__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_if_();
	partial void Leave_if_();

	// $ANTLR start "if_"
	// Plsql.g:386:1: if_ : IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) ;
	[GrammarRule("if_")]
	private PlsqlParser.if__return if_()
	{
		Enter_if_();
		EnterRule("if_", 39);
		TraceIn("if_", 39);
		PlsqlParser.if__return retval = new PlsqlParser.if__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF178=null;
		IToken THEN180=null;
		IToken ELSE182=null;
		IToken END184=null;
		IToken IF185=null;
		PlsqlParser.expression_return expression179 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock181 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock183 = default(PlsqlParser.codeBlock_return);

		object IF178_tree=null;
		object THEN180_tree=null;
		object ELSE182_tree=null;
		object END184_tree=null;
		object IF185_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "if_");
		DebugLocation(386, 1);
		try
		{
			// Plsql.g:386:5: ( IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) )
			DebugEnterAlt(1);
			// Plsql.g:386:7: IF expression THEN codeBlock ( ELSE codeBlock )? END IF
			{
			DebugLocation(386, 7);
			IF178=(IToken)Match(input,IF,Follow._IF_in_if_2227); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF178);

			DebugLocation(386, 10);
			PushFollow(Follow._expression_in_if_2229);
			expression179=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression179.Tree);
			DebugLocation(386, 21);
			THEN180=(IToken)Match(input,THEN,Follow._THEN_in_if_2231); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_THEN.Add(THEN180);

			DebugLocation(386, 26);
			PushFollow(Follow._codeBlock_in_if_2233);
			codeBlock181=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock181.Tree);
			DebugLocation(386, 36);
			// Plsql.g:386:36: ( ELSE codeBlock )?
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==ELSE))
			{
				alt29=1;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:386:37: ELSE codeBlock
				{
				DebugLocation(386, 37);
				ELSE182=(IToken)Match(input,ELSE,Follow._ELSE_in_if_2236); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE182);

				DebugLocation(386, 42);
				PushFollow(Follow._codeBlock_in_if_2238);
				codeBlock183=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock183.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(29); }

			DebugLocation(386, 54);
			END184=(IToken)Match(input,END,Follow._END_in_if_2242); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END184);

			DebugLocation(386, 58);
			IF185=(IToken)Match(input,IF,Follow._IF_in_if_2244); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF185);



			{
			// AST REWRITE
			// elements: expression, IF, codeBlock, codeBlock
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 387:2: -> ^( IF expression codeBlock ( codeBlock )? )
			{
				DebugLocation(387, 5);
				// Plsql.g:387:5: ^( IF expression codeBlock ( codeBlock )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(387, 7);
				root_1 = (object)adaptor.BecomeRoot(new IfNode(stream_IF.NextToken()), root_1);

				DebugLocation(387, 18);
				adaptor.AddChild(root_1, stream_expression.NextTree());
				DebugLocation(387, 29);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());
				DebugLocation(387, 39);
				// Plsql.g:387:39: ( codeBlock )?
				if ( stream_codeBlock.HasNext )
				{
					DebugLocation(387, 39);
					adaptor.AddChild(root_1, stream_codeBlock.NextTree());

				}
				stream_codeBlock.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("if_", 39);
			LeaveRule("if_", 39);
			Leave_if_();
		}
		DebugLocation(388, 1);
		} finally { DebugExitRule(GrammarFileName, "if_"); }
		return retval;

	}
	// $ANTLR end "if_"

	public class cycle_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_cycle();
	partial void Leave_cycle();

	// $ANTLR start "cycle"
	// Plsql.g:390:1: cycle : ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) );
	[GrammarRule("cycle")]
	private PlsqlParser.cycle_return cycle()
	{
		Enter_cycle();
		EnterRule("cycle", 40);
		TraceIn("cycle", 40);
		PlsqlParser.cycle_return retval = new PlsqlParser.cycle_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE186=null;
		IToken LOOP188=null;
		IToken END190=null;
		IToken LOOP191=null;
		IToken LOOP192=null;
		IToken EXIT194=null;
		IToken WHEN195=null;
		IToken END197=null;
		IToken LOOP198=null;
		IToken FOR199=null;
		IToken char_literal200=null;
		IToken char_literal202=null;
		IToken char_literal204=null;
		IToken char_literal206=null;
		IToken END208=null;
		IToken FOR209=null;
		PlsqlParser.expression_return expression187 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock189 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock193 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.expression_return expression196 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression201 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.expression_return expression203 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression205 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.codeBlock_return codeBlock207 = default(PlsqlParser.codeBlock_return);

		object WHILE186_tree=null;
		object LOOP188_tree=null;
		object END190_tree=null;
		object LOOP191_tree=null;
		object LOOP192_tree=null;
		object EXIT194_tree=null;
		object WHEN195_tree=null;
		object END197_tree=null;
		object LOOP198_tree=null;
		object FOR199_tree=null;
		object char_literal200_tree=null;
		object char_literal202_tree=null;
		object char_literal204_tree=null;
		object char_literal206_tree=null;
		object END208_tree=null;
		object FOR209_tree=null;
		RewriteRuleITokenStream stream_EXIT=new RewriteRuleITokenStream(adaptor,"token EXIT");
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleITokenStream stream_WHEN=new RewriteRuleITokenStream(adaptor,"token WHEN");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_LOOP=new RewriteRuleITokenStream(adaptor,"token LOOP");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_assignOrExpression=new RewriteRuleSubtreeStream(adaptor,"rule assignOrExpression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "cycle");
		DebugLocation(390, 1);
		try
		{
			// Plsql.g:391:2: ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) )
			int alt30=3;
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			switch (input.LA(1))
			{
			case WHILE:
				{
				alt30=1;
				}
				break;
			case LOOP:
				{
				alt30=2;
				}
				break;
			case FOR:
				{
				alt30=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 30, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:391:4: WHILE expression LOOP codeBlock END LOOP
				{
				DebugLocation(391, 4);
				WHILE186=(IToken)Match(input,WHILE,Follow._WHILE_in_cycle2275); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE186);

				DebugLocation(391, 10);
				PushFollow(Follow._expression_in_cycle2277);
				expression187=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression187.Tree);
				DebugLocation(391, 21);
				LOOP188=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2279); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP188);

				DebugLocation(391, 26);
				PushFollow(Follow._codeBlock_in_cycle2281);
				codeBlock189=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock189.Tree);
				DebugLocation(391, 36);
				END190=(IToken)Match(input,END,Follow._END_in_cycle2283); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END190);

				DebugLocation(391, 40);
				LOOP191=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2285); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP191);



				{
				// AST REWRITE
				// elements: expression, codeBlock, WHILE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 392:2: -> ^( WHILE expression codeBlock )
				{
					DebugLocation(392, 5);
					// Plsql.g:392:5: ^( WHILE expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(392, 7);
					root_1 = (object)adaptor.BecomeRoot(new WhileNode(stream_WHILE.NextToken()), root_1);

					DebugLocation(392, 24);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(392, 35);
					adaptor.AddChild(root_1, stream_codeBlock.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:393:4: LOOP codeBlock EXIT WHEN expression END LOOP
				{
				DebugLocation(393, 4);
				LOOP192=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2304); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP192);

				DebugLocation(393, 9);
				PushFollow(Follow._codeBlock_in_cycle2306);
				codeBlock193=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock193.Tree);
				DebugLocation(393, 19);
				EXIT194=(IToken)Match(input,EXIT,Follow._EXIT_in_cycle2308); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EXIT.Add(EXIT194);

				DebugLocation(393, 24);
				WHEN195=(IToken)Match(input,WHEN,Follow._WHEN_in_cycle2310); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHEN.Add(WHEN195);

				DebugLocation(393, 29);
				PushFollow(Follow._expression_in_cycle2312);
				expression196=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression196.Tree);
				DebugLocation(393, 40);
				END197=(IToken)Match(input,END,Follow._END_in_cycle2314); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END197);

				DebugLocation(393, 44);
				LOOP198=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2316); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP198);



				{
				// AST REWRITE
				// elements: codeBlock, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 394:2: -> ^( DO expression codeBlock )
				{
					DebugLocation(394, 5);
					// Plsql.g:394:5: ^( DO expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(394, 7);
					root_1 = (object)adaptor.BecomeRoot(new DoWhileNode(DO), root_1);

					DebugLocation(394, 23);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(394, 34);
					adaptor.AddChild(root_1, stream_codeBlock.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:395:4: FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR
				{
				DebugLocation(395, 4);
				FOR199=(IToken)Match(input,FOR,Follow._FOR_in_cycle2335); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR199);

				DebugLocation(395, 8);
				char_literal200=(IToken)Match(input,102,Follow._102_in_cycle2337); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal200);

				DebugLocation(395, 12);
				PushFollow(Follow._assignOrExpression_in_cycle2339);
				assignOrExpression201=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression201.Tree);
				DebugLocation(395, 31);
				char_literal202=(IToken)Match(input,105,Follow._105_in_cycle2341); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_105.Add(char_literal202);

				DebugLocation(395, 35);
				PushFollow(Follow._expression_in_cycle2343);
				expression203=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression203.Tree);
				DebugLocation(395, 46);
				char_literal204=(IToken)Match(input,105,Follow._105_in_cycle2345); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_105.Add(char_literal204);

				DebugLocation(395, 50);
				PushFollow(Follow._assignOrExpression_in_cycle2347);
				assignOrExpression205=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression205.Tree);
				DebugLocation(395, 69);
				char_literal206=(IToken)Match(input,103,Follow._103_in_cycle2349); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal206);

				DebugLocation(395, 73);
				PushFollow(Follow._codeBlock_in_cycle2351);
				codeBlock207=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock207.Tree);
				DebugLocation(395, 83);
				END208=(IToken)Match(input,END,Follow._END_in_cycle2353); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END208);

				DebugLocation(395, 87);
				FOR209=(IToken)Match(input,FOR,Follow._FOR_in_cycle2355); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR209);



				{
				// AST REWRITE
				// elements: assignOrExpression, codeBlock, assignOrExpression, FOR, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 396:2: -> ^( FOR assignOrExpression expression assignOrExpression codeBlock )
				{
					DebugLocation(396, 5);
					// Plsql.g:396:5: ^( FOR assignOrExpression expression assignOrExpression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(396, 7);
					root_1 = (object)adaptor.BecomeRoot(new ForNode(stream_FOR.NextToken()), root_1);

					DebugLocation(396, 20);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(396, 39);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(396, 50);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(396, 69);
					adaptor.AddChild(root_1, stream_codeBlock.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("cycle", 40);
			LeaveRule("cycle", 40);
			Leave_cycle();
		}
		DebugLocation(397, 1);
		} finally { DebugExitRule(GrammarFileName, "cycle"); }
		return retval;

	}
	// $ANTLR end "cycle"

	public class assignOrExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignOrExpression();
	partial void Leave_assignOrExpression();

	// $ANTLR start "assignOrExpression"
	// Plsql.g:399:1: assignOrExpression : ( assign | expression );
	[GrammarRule("assignOrExpression")]
	private PlsqlParser.assignOrExpression_return assignOrExpression()
	{
		Enter_assignOrExpression();
		EnterRule("assignOrExpression", 41);
		TraceIn("assignOrExpression", 41);
		PlsqlParser.assignOrExpression_return retval = new PlsqlParser.assignOrExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.assign_return assign210 = default(PlsqlParser.assign_return);
		PlsqlParser.expression_return expression211 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "assignOrExpression");
		DebugLocation(399, 1);
		try
		{
			// Plsql.g:400:2: ( assign | expression )
			int alt31=2;
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			try
			{
				alt31 = dfa31.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:400:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(400, 4);
				PushFollow(Follow._assign_in_assignOrExpression2384);
				assign210=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign210.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:401:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(401, 4);
				PushFollow(Follow._expression_in_assignOrExpression2389);
				expression211=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression211.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignOrExpression", 41);
			LeaveRule("assignOrExpression", 41);
			Leave_assignOrExpression();
		}
		DebugLocation(402, 1);
		} finally { DebugExitRule(GrammarFileName, "assignOrExpression"); }
		return retval;

	}
	// $ANTLR end "assignOrExpression"

	public class expressionList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressionList();
	partial void Leave_expressionList();

	// $ANTLR start "expressionList"
	// Plsql.g:404:1: expressionList : ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) ;
	[GrammarRule("expressionList")]
	private PlsqlParser.expressionList_return expressionList()
	{
		Enter_expressionList();
		EnterRule("expressionList", 42);
		TraceIn("expressionList", 42);
		PlsqlParser.expressionList_return retval = new PlsqlParser.expressionList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal213=null;
		PlsqlParser.expr__return expr_212 = default(PlsqlParser.expr__return);
		PlsqlParser.expr__return expr_214 = default(PlsqlParser.expr__return);

		object char_literal213_tree=null;
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(404, 1);
		try
		{
			// Plsql.g:405:2: ( ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) )
			DebugEnterAlt(1);
			// Plsql.g:405:4: ( expr_ ( ',' expr_ )* )?
			{
			DebugLocation(405, 4);
			// Plsql.g:405:4: ( expr_ ( ',' expr_ )* )?
			int alt33=2;
			try { DebugEnterSubRule(33);
			try { DebugEnterDecision(33, decisionCanBacktrack[33]);
			int LA33_0 = input.LA(1);

			if (((LA33_0>=TABLE && LA33_0<=ARRAY)||LA33_0==SELF||(LA33_0>=TRUE && LA33_0<=FALSE)||LA33_0==MINUS||LA33_0==NOT||(LA33_0>=ID && LA33_0<=QUOTED_CHAR)||LA33_0==102))
			{
				alt33=1;
			}
			} finally { DebugExitDecision(33); }
			switch (alt33)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:405:6: expr_ ( ',' expr_ )*
				{
				DebugLocation(405, 6);
				PushFollow(Follow._expr__in_expressionList2402);
				expr_212=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_.Add(expr_212.Tree);
				DebugLocation(405, 12);
				// Plsql.g:405:12: ( ',' expr_ )*
				try { DebugEnterSubRule(32);
				while (true)
				{
					int alt32=2;
					try { DebugEnterDecision(32, decisionCanBacktrack[32]);
					int LA32_0 = input.LA(1);

					if ((LA32_0==104))
					{
						alt32=1;
					}


					} finally { DebugExitDecision(32); }
					switch ( alt32 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:405:14: ',' expr_
						{
						DebugLocation(405, 14);
						char_literal213=(IToken)Match(input,104,Follow._104_in_expressionList2406); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_104.Add(char_literal213);

						DebugLocation(405, 18);
						PushFollow(Follow._expr__in_expressionList2408);
						expr_214=expr_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_expr_.Add(expr_214.Tree);

						}
						break;

					default:
						goto loop32;
					}
				}

				loop32:
					;

				} finally { DebugExitSubRule(32); }


				}
				break;

			}
			} finally { DebugExitSubRule(33); }



			{
			// AST REWRITE
			// elements: expr_
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 406:2: -> ^( ExpressionList ( expr_ )* )
			{
				DebugLocation(406, 5);
				// Plsql.g:406:5: ^( ExpressionList ( expr_ )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(406, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ExpressionList, "ExpressionList"), root_1);

				DebugLocation(406, 22);
				// Plsql.g:406:22: ( expr_ )*
				while ( stream_expr_.HasNext )
				{
					DebugLocation(406, 22);
					adaptor.AddChild(root_1, stream_expr_.NextTree());

				}
				stream_expr_.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressionList", 42);
			LeaveRule("expressionList", 42);
			Leave_expressionList();
		}
		DebugLocation(407, 1);
		} finally { DebugExitRule(GrammarFileName, "expressionList"); }
		return retval;

	}
	// $ANTLR end "expressionList"

	public class expression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expression();
	partial void Leave_expression();

	// $ANTLR start "expression"
	// Plsql.g:412:1: expression : expr_ -> ^( Expression expr_ ) ;
	[GrammarRule("expression")]
	private PlsqlParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 43);
		TraceIn("expression", 43);
		PlsqlParser.expression_return retval = new PlsqlParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expr__return expr_215 = default(PlsqlParser.expr__return);

		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(412, 1);
		try
		{
			// Plsql.g:413:2: ( expr_ -> ^( Expression expr_ ) )
			DebugEnterAlt(1);
			// Plsql.g:413:4: expr_
			{
			DebugLocation(413, 4);
			PushFollow(Follow._expr__in_expression2437);
			expr_215=expr_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr_.Add(expr_215.Tree);


			{
			// AST REWRITE
			// elements: expr_
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 414:2: -> ^( Expression expr_ )
			{
				DebugLocation(414, 5);
				// Plsql.g:414:5: ^( Expression expr_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(414, 7);
				root_1 = (object)adaptor.BecomeRoot(new ExpressionNode(Expression), root_1);

				DebugLocation(414, 34);
				adaptor.AddChild(root_1, stream_expr_.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression", 43);
			LeaveRule("expression", 43);
			Leave_expression();
		}
		DebugLocation(415, 1);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	public class expr__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr_();
	partial void Leave_expr_();

	// $ANTLR start "expr_"
	// Plsql.g:417:1: expr_ : ( logicOr )+ ;
	[GrammarRule("expr_")]
	private PlsqlParser.expr__return expr_()
	{
		Enter_expr_();
		EnterRule("expr_", 44);
		TraceIn("expr_", 44);
		PlsqlParser.expr__return retval = new PlsqlParser.expr__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.logicOr_return logicOr216 = default(PlsqlParser.logicOr_return);


		try { DebugEnterRule(GrammarFileName, "expr_");
		DebugLocation(417, 1);
		try
		{
			// Plsql.g:418:2: ( ( logicOr )+ )
			DebugEnterAlt(1);
			// Plsql.g:418:4: ( logicOr )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(418, 4);
			// Plsql.g:418:4: ( logicOr )+
			int cnt34=0;
			try { DebugEnterSubRule(34);
			while (true)
			{
				int alt34=2;
				try { DebugEnterDecision(34, decisionCanBacktrack[34]);
				int LA34_0 = input.LA(1);

				if (((LA34_0>=TABLE && LA34_0<=ARRAY)||LA34_0==SELF||(LA34_0>=TRUE && LA34_0<=FALSE)||LA34_0==MINUS||LA34_0==NOT||(LA34_0>=ID && LA34_0<=QUOTED_CHAR)||LA34_0==102))
				{
					alt34=1;
				}


				} finally { DebugExitDecision(34); }
				switch (alt34)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: logicOr
					{
					DebugLocation(418, 4);
					PushFollow(Follow._logicOr_in_expr_2460);
					logicOr216=logicOr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicOr216.Tree);

					}
					break;

				default:
					if (cnt34 >= 1)
						goto loop34;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee34 = new EarlyExitException( 34, input );
					DebugRecognitionException(eee34);
					throw eee34;
				}
				cnt34++;
			}
			loop34:
				;

			} finally { DebugExitSubRule(34); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr_", 44);
			LeaveRule("expr_", 44);
			Leave_expr_();
		}
		DebugLocation(419, 1);
		} finally { DebugExitRule(GrammarFileName, "expr_"); }
		return retval;

	}
	// $ANTLR end "expr_"

	public class logicOr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logicOr();
	partial void Leave_logicOr();

	// $ANTLR start "logicOr"
	// Plsql.g:421:1: logicOr : logicAnd ( OR logicAnd )* ;
	[GrammarRule("logicOr")]
	private PlsqlParser.logicOr_return logicOr()
	{
		Enter_logicOr();
		EnterRule("logicOr", 45);
		TraceIn("logicOr", 45);
		PlsqlParser.logicOr_return retval = new PlsqlParser.logicOr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR218=null;
		PlsqlParser.logicAnd_return logicAnd217 = default(PlsqlParser.logicAnd_return);
		PlsqlParser.logicAnd_return logicAnd219 = default(PlsqlParser.logicAnd_return);

		object OR218_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicOr");
		DebugLocation(421, 1);
		try
		{
			// Plsql.g:422:2: ( logicAnd ( OR logicAnd )* )
			DebugEnterAlt(1);
			// Plsql.g:422:4: logicAnd ( OR logicAnd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(422, 4);
			PushFollow(Follow._logicAnd_in_logicOr2472);
			logicAnd217=logicAnd();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd217.Tree);
			DebugLocation(422, 13);
			// Plsql.g:422:13: ( OR logicAnd )*
			try { DebugEnterSubRule(35);
			while (true)
			{
				int alt35=2;
				try { DebugEnterDecision(35, decisionCanBacktrack[35]);
				int LA35_0 = input.LA(1);

				if ((LA35_0==OR))
				{
					alt35=1;
				}


				} finally { DebugExitDecision(35); }
				switch ( alt35 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:422:15: OR logicAnd
					{
					DebugLocation(422, 25);
					OR218=(IToken)Match(input,OR,Follow._OR_in_logicOr2476); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR218_tree = new OrNode(OR218) ;
					root_0 = (object)adaptor.BecomeRoot(OR218_tree, root_0);
					}
					DebugLocation(422, 27);
					PushFollow(Follow._logicAnd_in_logicOr2482);
					logicAnd219=logicAnd();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd219.Tree);

					}
					break;

				default:
					goto loop35;
				}
			}

			loop35:
				;

			} finally { DebugExitSubRule(35); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicOr", 45);
			LeaveRule("logicOr", 45);
			Leave_logicOr();
		}
		DebugLocation(423, 1);
		} finally { DebugExitRule(GrammarFileName, "logicOr"); }
		return retval;

	}
	// $ANTLR end "logicOr"

	public class logicAnd_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logicAnd();
	partial void Leave_logicAnd();

	// $ANTLR start "logicAnd"
	// Plsql.g:425:1: logicAnd : equality ( AND equality )* ;
	[GrammarRule("logicAnd")]
	private PlsqlParser.logicAnd_return logicAnd()
	{
		Enter_logicAnd();
		EnterRule("logicAnd", 46);
		TraceIn("logicAnd", 46);
		PlsqlParser.logicAnd_return retval = new PlsqlParser.logicAnd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND221=null;
		PlsqlParser.equality_return equality220 = default(PlsqlParser.equality_return);
		PlsqlParser.equality_return equality222 = default(PlsqlParser.equality_return);

		object AND221_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicAnd");
		DebugLocation(425, 1);
		try
		{
			// Plsql.g:426:2: ( equality ( AND equality )* )
			DebugEnterAlt(1);
			// Plsql.g:426:4: equality ( AND equality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(426, 4);
			PushFollow(Follow._equality_in_logicAnd2495);
			equality220=equality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality220.Tree);
			DebugLocation(426, 13);
			// Plsql.g:426:13: ( AND equality )*
			try { DebugEnterSubRule(36);
			while (true)
			{
				int alt36=2;
				try { DebugEnterDecision(36, decisionCanBacktrack[36]);
				int LA36_0 = input.LA(1);

				if ((LA36_0==AND))
				{
					alt36=1;
				}


				} finally { DebugExitDecision(36); }
				switch ( alt36 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:426:15: AND equality
					{
					DebugLocation(426, 27);
					AND221=(IToken)Match(input,AND,Follow._AND_in_logicAnd2499); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND221_tree = new AndNode(AND221) ;
					root_0 = (object)adaptor.BecomeRoot(AND221_tree, root_0);
					}
					DebugLocation(426, 29);
					PushFollow(Follow._equality_in_logicAnd2505);
					equality222=equality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality222.Tree);

					}
					break;

				default:
					goto loop36;
				}
			}

			loop36:
				;

			} finally { DebugExitSubRule(36); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicAnd", 46);
			LeaveRule("logicAnd", 46);
			Leave_logicAnd();
		}
		DebugLocation(427, 1);
		} finally { DebugExitRule(GrammarFileName, "logicAnd"); }
		return retval;

	}
	// $ANTLR end "logicAnd"

	public class equality_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_equality();
	partial void Leave_equality();

	// $ANTLR start "equality"
	// Plsql.g:429:1: equality : inequality ( equalityOperator inequality )* ;
	[GrammarRule("equality")]
	private PlsqlParser.equality_return equality()
	{
		Enter_equality();
		EnterRule("equality", 47);
		TraceIn("equality", 47);
		PlsqlParser.equality_return retval = new PlsqlParser.equality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.inequality_return inequality223 = default(PlsqlParser.inequality_return);
		PlsqlParser.equalityOperator_return equalityOperator224 = default(PlsqlParser.equalityOperator_return);
		PlsqlParser.inequality_return inequality225 = default(PlsqlParser.inequality_return);


		try { DebugEnterRule(GrammarFileName, "equality");
		DebugLocation(429, 1);
		try
		{
			// Plsql.g:430:2: ( inequality ( equalityOperator inequality )* )
			DebugEnterAlt(1);
			// Plsql.g:430:4: inequality ( equalityOperator inequality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(430, 4);
			PushFollow(Follow._inequality_in_equality2518);
			inequality223=inequality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality223.Tree);
			DebugLocation(430, 15);
			// Plsql.g:430:15: ( equalityOperator inequality )*
			try { DebugEnterSubRule(37);
			while (true)
			{
				int alt37=2;
				try { DebugEnterDecision(37, decisionCanBacktrack[37]);
				int LA37_0 = input.LA(1);

				if (((LA37_0>=EQUAL && LA37_0<=NEQUAL)))
				{
					alt37=1;
				}


				} finally { DebugExitDecision(37); }
				switch ( alt37 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:430:17: equalityOperator inequality
					{
					DebugLocation(430, 33);
					PushFollow(Follow._equalityOperator_in_equality2522);
					equalityOperator224=equalityOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(equalityOperator224.Tree, root_0);
					DebugLocation(430, 35);
					PushFollow(Follow._inequality_in_equality2525);
					inequality225=inequality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality225.Tree);

					}
					break;

				default:
					goto loop37;
				}
			}

			loop37:
				;

			} finally { DebugExitSubRule(37); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("equality", 47);
			LeaveRule("equality", 47);
			Leave_equality();
		}
		DebugLocation(431, 1);
		} finally { DebugExitRule(GrammarFileName, "equality"); }
		return retval;

	}
	// $ANTLR end "equality"

	public class inequality_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_inequality();
	partial void Leave_inequality();

	// $ANTLR start "inequality"
	// Plsql.g:433:1: inequality : add ( ineqOperator add )* ;
	[GrammarRule("inequality")]
	private PlsqlParser.inequality_return inequality()
	{
		Enter_inequality();
		EnterRule("inequality", 48);
		TraceIn("inequality", 48);
		PlsqlParser.inequality_return retval = new PlsqlParser.inequality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.add_return add226 = default(PlsqlParser.add_return);
		PlsqlParser.ineqOperator_return ineqOperator227 = default(PlsqlParser.ineqOperator_return);
		PlsqlParser.add_return add228 = default(PlsqlParser.add_return);


		try { DebugEnterRule(GrammarFileName, "inequality");
		DebugLocation(433, 1);
		try
		{
			// Plsql.g:434:2: ( add ( ineqOperator add )* )
			DebugEnterAlt(1);
			// Plsql.g:434:4: add ( ineqOperator add )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(434, 4);
			PushFollow(Follow._add_in_inequality2538);
			add226=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add226.Tree);
			DebugLocation(434, 8);
			// Plsql.g:434:8: ( ineqOperator add )*
			try { DebugEnterSubRule(38);
			while (true)
			{
				int alt38=2;
				try { DebugEnterDecision(38, decisionCanBacktrack[38]);
				int LA38_0 = input.LA(1);

				if (((LA38_0>=MORE && LA38_0<=LESSEQ)))
				{
					alt38=1;
				}


				} finally { DebugExitDecision(38); }
				switch ( alt38 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:434:10: ineqOperator add
					{
					DebugLocation(434, 22);
					PushFollow(Follow._ineqOperator_in_inequality2542);
					ineqOperator227=ineqOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(ineqOperator227.Tree, root_0);
					DebugLocation(434, 24);
					PushFollow(Follow._add_in_inequality2545);
					add228=add();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add228.Tree);

					}
					break;

				default:
					goto loop38;
				}
			}

			loop38:
				;

			} finally { DebugExitSubRule(38); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("inequality", 48);
			LeaveRule("inequality", 48);
			Leave_inequality();
		}
		DebugLocation(435, 1);
		} finally { DebugExitRule(GrammarFileName, "inequality"); }
		return retval;

	}
	// $ANTLR end "inequality"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// Plsql.g:437:1: add : mult ( addOperator mult )* ;
	[GrammarRule("add")]
	private PlsqlParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 49);
		TraceIn("add", 49);
		PlsqlParser.add_return retval = new PlsqlParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.mult_return mult229 = default(PlsqlParser.mult_return);
		PlsqlParser.addOperator_return addOperator230 = default(PlsqlParser.addOperator_return);
		PlsqlParser.mult_return mult231 = default(PlsqlParser.mult_return);


		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(437, 4);
		try
		{
			// Plsql.g:437:5: ( mult ( addOperator mult )* )
			DebugEnterAlt(1);
			// Plsql.g:437:9: mult ( addOperator mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(437, 9);
			PushFollow(Follow._mult_in_add2559);
			mult229=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult229.Tree);
			DebugLocation(437, 14);
			// Plsql.g:437:14: ( addOperator mult )*
			try { DebugEnterSubRule(39);
			while (true)
			{
				int alt39=2;
				try { DebugEnterDecision(39, decisionCanBacktrack[39]);
				try
				{
					alt39 = dfa39.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(39); }
				switch ( alt39 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:437:16: addOperator mult
					{
					DebugLocation(437, 27);
					PushFollow(Follow._addOperator_in_add2563);
					addOperator230=addOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperator230.Tree, root_0);
					DebugLocation(437, 29);
					PushFollow(Follow._mult_in_add2566);
					mult231=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult231.Tree);

					}
					break;

				default:
					goto loop39;
				}
			}

			loop39:
				;

			} finally { DebugExitSubRule(39); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 49);
			LeaveRule("add", 49);
			Leave_add();
		}
		DebugLocation(438, 4);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// Plsql.g:440:1: mult : cast ( multOperator cast )* ;
	[GrammarRule("mult")]
	private PlsqlParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 50);
		TraceIn("mult", 50);
		PlsqlParser.mult_return retval = new PlsqlParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.cast_return cast232 = default(PlsqlParser.cast_return);
		PlsqlParser.multOperator_return multOperator233 = default(PlsqlParser.multOperator_return);
		PlsqlParser.cast_return cast234 = default(PlsqlParser.cast_return);


		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(440, 1);
		try
		{
			// Plsql.g:440:5: ( cast ( multOperator cast )* )
			DebugEnterAlt(1);
			// Plsql.g:440:9: cast ( multOperator cast )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(440, 9);
			PushFollow(Follow._cast_in_mult2582);
			cast232=cast();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast232.Tree);
			DebugLocation(440, 14);
			// Plsql.g:440:14: ( multOperator cast )*
			try { DebugEnterSubRule(40);
			while (true)
			{
				int alt40=2;
				try { DebugEnterDecision(40, decisionCanBacktrack[40]);
				int LA40_0 = input.LA(1);

				if (((LA40_0>=MULT && LA40_0<=MOD)))
				{
					alt40=1;
				}


				} finally { DebugExitDecision(40); }
				switch ( alt40 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:440:16: multOperator cast
					{
					DebugLocation(440, 28);
					PushFollow(Follow._multOperator_in_mult2586);
					multOperator233=multOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperator233.Tree, root_0);
					DebugLocation(440, 30);
					PushFollow(Follow._cast_in_mult2589);
					cast234=cast();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast234.Tree);

					}
					break;

				default:
					goto loop40;
				}
			}

			loop40:
				;

			} finally { DebugExitSubRule(40); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 50);
			LeaveRule("mult", 50);
			Leave_mult();
		}
		DebugLocation(441, 1);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class cast_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_cast();
	partial void Leave_cast();

	// $ANTLR start "cast"
	// Plsql.g:443:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );
	[GrammarRule("cast")]
	private PlsqlParser.cast_return cast()
	{
		Enter_cast();
		EnterRule("cast", 51);
		TraceIn("cast", 51);
		PlsqlParser.cast_return retval = new PlsqlParser.cast_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal235=null;
		IToken char_literal237=null;
		PlsqlParser.type_return type236 = default(PlsqlParser.type_return);
		PlsqlParser.unary_return unary238 = default(PlsqlParser.unary_return);
		PlsqlParser.unary_return unary239 = default(PlsqlParser.unary_return);

		object char_literal235_tree=null;
		object char_literal237_tree=null;
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_unary=new RewriteRuleSubtreeStream(adaptor,"rule unary");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "cast");
		DebugLocation(443, 1);
		try
		{
			// Plsql.g:443:5: ( '(' type ')' unary -> ^( Cast unary type ) | unary )
			int alt41=2;
			try { DebugEnterDecision(41, decisionCanBacktrack[41]);
			try
			{
				alt41 = dfa41.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(41); }
			switch (alt41)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:443:7: '(' type ')' unary
				{
				DebugLocation(443, 7);
				char_literal235=(IToken)Match(input,102,Follow._102_in_cast2601); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal235);

				DebugLocation(443, 11);
				PushFollow(Follow._type_in_cast2603);
				type236=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type236.Tree);
				DebugLocation(443, 16);
				char_literal237=(IToken)Match(input,103,Follow._103_in_cast2605); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal237);

				DebugLocation(443, 20);
				PushFollow(Follow._unary_in_cast2607);
				unary238=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_unary.Add(unary238.Tree);


				{
				// AST REWRITE
				// elements: type, unary
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 444:2: -> ^( Cast unary type )
				{
					DebugLocation(444, 5);
					// Plsql.g:444:5: ^( Cast unary type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(444, 7);
					root_1 = (object)adaptor.BecomeRoot(new CastNode(Cast), root_1);

					DebugLocation(444, 22);
					adaptor.AddChild(root_1, stream_unary.NextTree());
					DebugLocation(444, 28);
					adaptor.AddChild(root_1, stream_type.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:445:4: unary
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(445, 4);
				PushFollow(Follow._unary_in_cast2626);
				unary239=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary239.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("cast", 51);
			LeaveRule("cast", 51);
			Leave_cast();
		}
		DebugLocation(446, 1);
		} finally { DebugExitRule(GrammarFileName, "cast"); }
		return retval;

	}
	// $ANTLR end "cast"

	public class unary_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_unary();
	partial void Leave_unary();

	// $ANTLR start "unary"
	// Plsql.g:448:1: unary : ( ( unaryOperator unary ) | postfix );
	[GrammarRule("unary")]
	private PlsqlParser.unary_return unary()
	{
		Enter_unary();
		EnterRule("unary", 52);
		TraceIn("unary", 52);
		PlsqlParser.unary_return retval = new PlsqlParser.unary_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.unaryOperator_return unaryOperator240 = default(PlsqlParser.unaryOperator_return);
		PlsqlParser.unary_return unary241 = default(PlsqlParser.unary_return);
		PlsqlParser.postfix_return postfix242 = default(PlsqlParser.postfix_return);


		try { DebugEnterRule(GrammarFileName, "unary");
		DebugLocation(448, 1);
		try
		{
			// Plsql.g:449:2: ( ( unaryOperator unary ) | postfix )
			int alt42=2;
			try { DebugEnterDecision(42, decisionCanBacktrack[42]);
			int LA42_0 = input.LA(1);

			if ((LA42_0==MINUS||LA42_0==NOT))
			{
				alt42=1;
			}
			else if (((LA42_0>=TABLE && LA42_0<=ARRAY)||LA42_0==SELF||(LA42_0>=TRUE && LA42_0<=FALSE)||(LA42_0>=ID && LA42_0<=QUOTED_CHAR)||LA42_0==102))
			{
				alt42=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 42, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(42); }
			switch (alt42)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:449:4: ( unaryOperator unary )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(449, 4);
				// Plsql.g:449:4: ( unaryOperator unary )
				DebugEnterAlt(1);
				// Plsql.g:449:5: unaryOperator unary
				{
				DebugLocation(449, 18);
				PushFollow(Follow._unaryOperator_in_unary2638);
				unaryOperator240=unaryOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(unaryOperator240.Tree, root_0);
				DebugLocation(449, 20);
				PushFollow(Follow._unary_in_unary2641);
				unary241=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary241.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:450:4: postfix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(450, 4);
				PushFollow(Follow._postfix_in_unary2648);
				postfix242=postfix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfix242.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unary", 52);
			LeaveRule("unary", 52);
			Leave_unary();
		}
		DebugLocation(451, 1);
		} finally { DebugExitRule(GrammarFileName, "unary"); }
		return retval;

	}
	// $ANTLR end "unary"

	public class postfix_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_postfix();
	partial void Leave_postfix();

	// $ANTLR start "postfix"
	// Plsql.g:455:1: postfix : quant ( tmp )* ;
	[GrammarRule("postfix")]
	private PlsqlParser.postfix_return postfix()
	{
		Enter_postfix();
		EnterRule("postfix", 53);
		TraceIn("postfix", 53);
		PlsqlParser.postfix_return retval = new PlsqlParser.postfix_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.quant_return quant243 = default(PlsqlParser.quant_return);
		PlsqlParser.tmp_return tmp244 = default(PlsqlParser.tmp_return);


		try { DebugEnterRule(GrammarFileName, "postfix");
		DebugLocation(455, 1);
		try
		{
			// Plsql.g:456:2: ( quant ( tmp )* )
			DebugEnterAlt(1);
			// Plsql.g:456:4: quant ( tmp )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(456, 4);
			PushFollow(Follow._quant_in_postfix2663);
			quant243=quant();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quant243.Tree);
			DebugLocation(456, 13);
			// Plsql.g:456:13: ( tmp )*
			try { DebugEnterSubRule(43);
			while (true)
			{
				int alt43=2;
				try { DebugEnterDecision(43, decisionCanBacktrack[43]);
				int LA43_0 = input.LA(1);

				if ((LA43_0==101||LA43_0==106))
				{
					alt43=1;
				}


				} finally { DebugExitDecision(43); }
				switch ( alt43 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: tmp
					{
					DebugLocation(456, 13);
					PushFollow(Follow._tmp_in_postfix2665);
					tmp244=tmp();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(tmp244.Tree, root_0);

					}
					break;

				default:
					goto loop43;
				}
			}

			loop43:
				;

			} finally { DebugExitSubRule(43); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("postfix", 53);
			LeaveRule("postfix", 53);
			Leave_postfix();
		}
		DebugLocation(457, 1);
		} finally { DebugExitRule(GrammarFileName, "postfix"); }
		return retval;

	}
	// $ANTLR end "postfix"

	public class tmp_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_tmp();
	partial void Leave_tmp();

	// $ANTLR start "tmp"
	// Plsql.g:459:1: tmp : ( index | methodCall | memberCall );
	[GrammarRule("tmp")]
	private PlsqlParser.tmp_return tmp()
	{
		Enter_tmp();
		EnterRule("tmp", 54);
		TraceIn("tmp", 54);
		PlsqlParser.tmp_return retval = new PlsqlParser.tmp_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.index_return index245 = default(PlsqlParser.index_return);
		PlsqlParser.methodCall_return methodCall246 = default(PlsqlParser.methodCall_return);
		PlsqlParser.memberCall_return memberCall247 = default(PlsqlParser.memberCall_return);


		try { DebugEnterRule(GrammarFileName, "tmp");
		DebugLocation(459, 1);
		try
		{
			// Plsql.g:459:5: ( index | methodCall | memberCall )
			int alt44=3;
			try { DebugEnterDecision(44, decisionCanBacktrack[44]);
			int LA44_0 = input.LA(1);

			if ((LA44_0==106))
			{
				alt44=1;
			}
			else if ((LA44_0==101))
			{
				int LA44_2 = input.LA(2);

				if ((EvaluatePredicate(synpred70_Plsql_fragment)))
				{
					alt44=2;
				}
				else if ((true))
				{
					alt44=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 44, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 44, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(44); }
			switch (alt44)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:459:7: index
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(459, 7);
				PushFollow(Follow._index_in_tmp2677);
				index245=index();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, index245.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:460:4: methodCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(460, 4);
				PushFollow(Follow._methodCall_in_tmp2682);
				methodCall246=methodCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall246.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:461:4: memberCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(461, 4);
				PushFollow(Follow._memberCall_in_tmp2687);
				memberCall247=memberCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberCall247.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("tmp", 54);
			LeaveRule("tmp", 54);
			Leave_tmp();
		}
		DebugLocation(462, 1);
		} finally { DebugExitRule(GrammarFileName, "tmp"); }
		return retval;

	}
	// $ANTLR end "tmp"

	public class index_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_index();
	partial void Leave_index();

	// $ANTLR start "index"
	// Plsql.g:464:1: index : '[' expression ']' -> ^( Index expression ) ;
	[GrammarRule("index")]
	private PlsqlParser.index_return index()
	{
		Enter_index();
		EnterRule("index", 55);
		TraceIn("index", 55);
		PlsqlParser.index_return retval = new PlsqlParser.index_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal248=null;
		IToken char_literal250=null;
		PlsqlParser.expression_return expression249 = default(PlsqlParser.expression_return);

		object char_literal248_tree=null;
		object char_literal250_tree=null;
		RewriteRuleITokenStream stream_107=new RewriteRuleITokenStream(adaptor,"token 107");
		RewriteRuleITokenStream stream_106=new RewriteRuleITokenStream(adaptor,"token 106");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "index");
		DebugLocation(464, 1);
		try
		{
			// Plsql.g:465:2: ( '[' expression ']' -> ^( Index expression ) )
			DebugEnterAlt(1);
			// Plsql.g:465:4: '[' expression ']'
			{
			DebugLocation(465, 4);
			char_literal248=(IToken)Match(input,106,Follow._106_in_index2698); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_106.Add(char_literal248);

			DebugLocation(465, 8);
			PushFollow(Follow._expression_in_index2700);
			expression249=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression249.Tree);
			DebugLocation(465, 19);
			char_literal250=(IToken)Match(input,107,Follow._107_in_index2702); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_107.Add(char_literal250);



			{
			// AST REWRITE
			// elements: expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 466:2: -> ^( Index expression )
			{
				DebugLocation(466, 5);
				// Plsql.g:466:5: ^( Index expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(466, 7);
				root_1 = (object)adaptor.BecomeRoot(new IndexNode(Index), root_1);

				DebugLocation(466, 24);
				adaptor.AddChild(root_1, stream_expression.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("index", 55);
			LeaveRule("index", 55);
			Leave_index();
		}
		DebugLocation(467, 1);
		} finally { DebugExitRule(GrammarFileName, "index"); }
		return retval;

	}
	// $ANTLR end "index"

	public class memberCall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_memberCall();
	partial void Leave_memberCall();

	// $ANTLR start "memberCall"
	// Plsql.g:469:1: memberCall : '.' ID -> ^( MemberCall ID ) ;
	[GrammarRule("memberCall")]
	private PlsqlParser.memberCall_return memberCall()
	{
		Enter_memberCall();
		EnterRule("memberCall", 56);
		TraceIn("memberCall", 56);
		PlsqlParser.memberCall_return retval = new PlsqlParser.memberCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal251=null;
		IToken ID252=null;

		object char_literal251_tree=null;
		object ID252_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");

		try { DebugEnterRule(GrammarFileName, "memberCall");
		DebugLocation(469, 1);
		try
		{
			// Plsql.g:470:2: ( '.' ID -> ^( MemberCall ID ) )
			DebugEnterAlt(1);
			// Plsql.g:470:4: '.' ID
			{
			DebugLocation(470, 4);
			char_literal251=(IToken)Match(input,101,Follow._101_in_memberCall2725); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal251);

			DebugLocation(470, 8);
			ID252=(IToken)Match(input,ID,Follow._ID_in_memberCall2727); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID252);



			{
			// AST REWRITE
			// elements: ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 471:2: -> ^( MemberCall ID )
			{
				DebugLocation(471, 5);
				// Plsql.g:471:5: ^( MemberCall ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(471, 7);
				root_1 = (object)adaptor.BecomeRoot(new MemberCallNode(MemberCall), root_1);

				DebugLocation(471, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("memberCall", 56);
			LeaveRule("memberCall", 56);
			Leave_memberCall();
		}
		DebugLocation(472, 1);
		} finally { DebugExitRule(GrammarFileName, "memberCall"); }
		return retval;

	}
	// $ANTLR end "memberCall"

	public class expressionOrEmpty_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressionOrEmpty();
	partial void Leave_expressionOrEmpty();

	// $ANTLR start "expressionOrEmpty"
	// Plsql.g:474:1: expressionOrEmpty : ( expression | -> Expression );
	[GrammarRule("expressionOrEmpty")]
	private PlsqlParser.expressionOrEmpty_return expressionOrEmpty()
	{
		Enter_expressionOrEmpty();
		EnterRule("expressionOrEmpty", 57);
		TraceIn("expressionOrEmpty", 57);
		PlsqlParser.expressionOrEmpty_return retval = new PlsqlParser.expressionOrEmpty_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expression_return expression253 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "expressionOrEmpty");
		DebugLocation(474, 1);
		try
		{
			// Plsql.g:475:2: ( expression | -> Expression )
			int alt45=2;
			try { DebugEnterDecision(45, decisionCanBacktrack[45]);
			int LA45_0 = input.LA(1);

			if (((LA45_0>=TABLE && LA45_0<=ARRAY)||LA45_0==SELF||(LA45_0>=TRUE && LA45_0<=FALSE)||LA45_0==MINUS||LA45_0==NOT||(LA45_0>=ID && LA45_0<=QUOTED_CHAR)||LA45_0==102))
			{
				alt45=1;
			}
			else if ((LA45_0==EOF))
			{
				alt45=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 45, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(45); }
			switch (alt45)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:475:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(475, 4);
				PushFollow(Follow._expression_in_expressionOrEmpty2750);
				expression253=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression253.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:476:4: 
				{

				{
				// AST REWRITE
				// elements: 
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 476:4: -> Expression
				{
					DebugLocation(476, 7);
					adaptor.AddChild(root_0, (object)adaptor.Create(Expression, "Expression"));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressionOrEmpty", 57);
			LeaveRule("expressionOrEmpty", 57);
			Leave_expressionOrEmpty();
		}
		DebugLocation(477, 1);
		} finally { DebugExitRule(GrammarFileName, "expressionOrEmpty"); }
		return retval;

	}
	// $ANTLR end "expressionOrEmpty"

	public class methodCall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methodCall();
	partial void Leave_methodCall();

	// $ANTLR start "methodCall"
	// Plsql.g:479:1: methodCall : '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) ;
	[GrammarRule("methodCall")]
	private PlsqlParser.methodCall_return methodCall()
	{
		Enter_methodCall();
		EnterRule("methodCall", 58);
		TraceIn("methodCall", 58);
		PlsqlParser.methodCall_return retval = new PlsqlParser.methodCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal254=null;
		IToken ID255=null;
		IToken char_literal256=null;
		IToken char_literal258=null;
		PlsqlParser.expressionList_return expressionList257 = default(PlsqlParser.expressionList_return);

		object char_literal254_tree=null;
		object ID255_tree=null;
		object char_literal256_tree=null;
		object char_literal258_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "methodCall");
		DebugLocation(479, 1);
		try
		{
			// Plsql.g:480:2: ( '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:480:4: '.' ID '(' expressionList ')'
			{
			DebugLocation(480, 4);
			char_literal254=(IToken)Match(input,101,Follow._101_in_methodCall2768); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal254);

			DebugLocation(480, 8);
			ID255=(IToken)Match(input,ID,Follow._ID_in_methodCall2770); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID255);

			DebugLocation(480, 11);
			char_literal256=(IToken)Match(input,102,Follow._102_in_methodCall2772); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal256);

			DebugLocation(480, 15);
			PushFollow(Follow._expressionList_in_methodCall2774);
			expressionList257=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList257.Tree);
			DebugLocation(480, 30);
			char_literal258=(IToken)Match(input,103,Follow._103_in_methodCall2776); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal258);



			{
			// AST REWRITE
			// elements: expressionList, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 481:2: -> ^( MethodCall ID expressionList )
			{
				DebugLocation(481, 5);
				// Plsql.g:481:5: ^( MethodCall ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(481, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodCallNode(MethodCall), root_1);

				DebugLocation(481, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(481, 37);
				adaptor.AddChild(root_1, stream_expressionList.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methodCall", 58);
			LeaveRule("methodCall", 58);
			Leave_methodCall();
		}
		DebugLocation(482, 1);
		} finally { DebugExitRule(GrammarFileName, "methodCall"); }
		return retval;

	}
	// $ANTLR end "methodCall"

	public class createInstance_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_createInstance();
	partial void Leave_createInstance();

	// $ANTLR start "createInstance"
	// Plsql.g:484:1: createInstance : ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) | TABLE '(' type ( ',' type )? ')' -> ^( CreateInstance type ( type )? ) | ARRAY '(' type ',' expression ')' -> ^( CreateInstance type expression ) );
	[GrammarRule("createInstance")]
	private PlsqlParser.createInstance_return createInstance()
	{
		Enter_createInstance();
		EnterRule("createInstance", 59);
		TraceIn("createInstance", 59);
		PlsqlParser.createInstance_return retval = new PlsqlParser.createInstance_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID259=null;
		IToken char_literal260=null;
		IToken char_literal262=null;
		IToken TABLE263=null;
		IToken char_literal264=null;
		IToken char_literal266=null;
		IToken char_literal268=null;
		IToken ARRAY269=null;
		IToken char_literal270=null;
		IToken char_literal272=null;
		IToken char_literal274=null;
		PlsqlParser.expressionList_return expressionList261 = default(PlsqlParser.expressionList_return);
		PlsqlParser.type_return type265 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type267 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type271 = default(PlsqlParser.type_return);
		PlsqlParser.expression_return expression273 = default(PlsqlParser.expression_return);

		object ID259_tree=null;
		object char_literal260_tree=null;
		object char_literal262_tree=null;
		object TABLE263_tree=null;
		object char_literal264_tree=null;
		object char_literal266_tree=null;
		object char_literal268_tree=null;
		object ARRAY269_tree=null;
		object char_literal270_tree=null;
		object char_literal272_tree=null;
		object char_literal274_tree=null;
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "createInstance");
		DebugLocation(484, 1);
		try
		{
			// Plsql.g:485:2: ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) | TABLE '(' type ( ',' type )? ')' -> ^( CreateInstance type ( type )? ) | ARRAY '(' type ',' expression ')' -> ^( CreateInstance type expression ) )
			int alt47=3;
			try { DebugEnterDecision(47, decisionCanBacktrack[47]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt47=1;
				}
				break;
			case TABLE:
				{
				alt47=2;
				}
				break;
			case ARRAY:
				{
				alt47=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 47, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(47); }
			switch (alt47)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:485:4: ID '(' expressionList ')'
				{
				DebugLocation(485, 4);
				ID259=(IToken)Match(input,ID,Follow._ID_in_createInstance2801); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID259);

				DebugLocation(485, 7);
				char_literal260=(IToken)Match(input,102,Follow._102_in_createInstance2803); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal260);

				DebugLocation(485, 11);
				PushFollow(Follow._expressionList_in_createInstance2805);
				expressionList261=expressionList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList261.Tree);
				DebugLocation(485, 26);
				char_literal262=(IToken)Match(input,103,Follow._103_in_createInstance2807); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal262);



				{
				// AST REWRITE
				// elements: ID, expressionList
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 486:2: -> ^( CreateInstance ID expressionList )
				{
					DebugLocation(486, 5);
					// Plsql.g:486:5: ^( CreateInstance ID expressionList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(486, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateInstanceNode(CreateInstance), root_1);

					DebugLocation(486, 42);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(486, 45);
					adaptor.AddChild(root_1, stream_expressionList.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:487:4: TABLE '(' type ( ',' type )? ')'
				{
				DebugLocation(487, 4);
				TABLE263=(IToken)Match(input,TABLE,Follow._TABLE_in_createInstance2826); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE263);

				DebugLocation(487, 10);
				char_literal264=(IToken)Match(input,102,Follow._102_in_createInstance2828); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal264);

				DebugLocation(487, 14);
				PushFollow(Follow._type_in_createInstance2830);
				type265=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type265.Tree);
				DebugLocation(487, 19);
				// Plsql.g:487:19: ( ',' type )?
				int alt46=2;
				try { DebugEnterSubRule(46);
				try { DebugEnterDecision(46, decisionCanBacktrack[46]);
				int LA46_0 = input.LA(1);

				if ((LA46_0==104))
				{
					alt46=1;
				}
				} finally { DebugExitDecision(46); }
				switch (alt46)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:487:20: ',' type
					{
					DebugLocation(487, 20);
					char_literal266=(IToken)Match(input,104,Follow._104_in_createInstance2833); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal266);

					DebugLocation(487, 24);
					PushFollow(Follow._type_in_createInstance2835);
					type267=type();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type.Add(type267.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(46); }

				DebugLocation(487, 31);
				char_literal268=(IToken)Match(input,103,Follow._103_in_createInstance2839); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal268);



				{
				// AST REWRITE
				// elements: type, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 488:2: -> ^( CreateInstance type ( type )? )
				{
					DebugLocation(488, 5);
					// Plsql.g:488:5: ^( CreateInstance type ( type )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(488, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateTableNode(CreateInstance), root_1);

					DebugLocation(488, 39);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(488, 44);
					// Plsql.g:488:44: ( type )?
					if ( stream_type.HasNext )
					{
						DebugLocation(488, 44);
						adaptor.AddChild(root_1, stream_type.NextTree());

					}
					stream_type.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:489:4: ARRAY '(' type ',' expression ')'
				{
				DebugLocation(489, 4);
				ARRAY269=(IToken)Match(input,ARRAY,Follow._ARRAY_in_createInstance2859); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY269);

				DebugLocation(489, 10);
				char_literal270=(IToken)Match(input,102,Follow._102_in_createInstance2861); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal270);

				DebugLocation(489, 14);
				PushFollow(Follow._type_in_createInstance2863);
				type271=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type271.Tree);
				DebugLocation(489, 19);
				char_literal272=(IToken)Match(input,104,Follow._104_in_createInstance2865); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_104.Add(char_literal272);

				DebugLocation(489, 23);
				PushFollow(Follow._expression_in_createInstance2867);
				expression273=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression273.Tree);
				DebugLocation(489, 33);
				char_literal274=(IToken)Match(input,103,Follow._103_in_createInstance2868); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal274);



				{
				// AST REWRITE
				// elements: expression, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 490:2: -> ^( CreateInstance type expression )
				{
					DebugLocation(490, 5);
					// Plsql.g:490:5: ^( CreateInstance type expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(490, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateArrayNode(CreateInstance), root_1);

					DebugLocation(490, 39);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(490, 44);
					adaptor.AddChild(root_1, stream_expression.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("createInstance", 59);
			LeaveRule("createInstance", 59);
			Leave_createInstance();
		}
		DebugLocation(491, 1);
		} finally { DebugExitRule(GrammarFileName, "createInstance"); }
		return retval;

	}
	// $ANTLR end "createInstance"

	public class quant_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_quant();
	partial void Leave_quant();

	// $ANTLR start "quant"
	// Plsql.g:493:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );
	[GrammarRule("quant")]
	private PlsqlParser.quant_return quant()
	{
		Enter_quant();
		EnterRule("quant", 60);
		TraceIn("quant", 60);
		PlsqlParser.quant_return retval = new PlsqlParser.quant_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal280=null;
		IToken char_literal282=null;
		IToken SELF284=null;
		PlsqlParser.number_return number275 = default(PlsqlParser.number_return);
		PlsqlParser.bool__return bool_276 = default(PlsqlParser.bool__return);
		PlsqlParser.string__return string_277 = default(PlsqlParser.string__return);
		PlsqlParser.char__return char_278 = default(PlsqlParser.char__return);
		PlsqlParser.createInstance_return createInstance279 = default(PlsqlParser.createInstance_return);
		PlsqlParser.expr__return expr_281 = default(PlsqlParser.expr__return);
		PlsqlParser.var_return var283 = default(PlsqlParser.var_return);

		object char_literal280_tree=null;
		object char_literal282_tree=null;
		object SELF284_tree=null;

		try { DebugEnterRule(GrammarFileName, "quant");
		DebugLocation(493, 1);
		try
		{
			// Plsql.g:494:2: ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF )
			int alt48=8;
			try { DebugEnterDecision(48, decisionCanBacktrack[48]);
			try
			{
				alt48 = dfa48.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(48); }
			switch (alt48)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:494:4: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(494, 4);
				PushFollow(Follow._number_in_quant2893);
				number275=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number275.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:495:6: bool_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(495, 6);
				PushFollow(Follow._bool__in_quant2900);
				bool_276=bool_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bool_276.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:496:6: string_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(496, 6);
				PushFollow(Follow._string__in_quant2907);
				string_277=string_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_277.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:497:4: char_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(497, 4);
				PushFollow(Follow._char__in_quant2912);
				char_278=char_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_278.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:498:6: createInstance
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(498, 6);
				PushFollow(Follow._createInstance_in_quant2919);
				createInstance279=createInstance();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, createInstance279.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:499:6: '(' expr_ ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(499, 9);
				char_literal280=(IToken)Match(input,102,Follow._102_in_quant2926); if (state.failed) return retval;
				DebugLocation(499, 11);
				PushFollow(Follow._expr__in_quant2929);
				expr_281=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_281.Tree);
				DebugLocation(499, 20);
				char_literal282=(IToken)Match(input,103,Follow._103_in_quant2931); if (state.failed) return retval;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:500:6: var
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(500, 6);
				PushFollow(Follow._var_in_quant2939);
				var283=var();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var283.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Plsql.g:501:6: SELF
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(501, 6);
				SELF284=(IToken)Match(input,SELF,Follow._SELF_in_quant2946); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				SELF284_tree = new SelfNode(SELF284) ;
				adaptor.AddChild(root_0, SELF284_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("quant", 60);
			LeaveRule("quant", 60);
			Leave_quant();
		}
		DebugLocation(502, 1);
		} finally { DebugExitRule(GrammarFileName, "quant"); }
		return retval;

	}
	// $ANTLR end "quant"

	public class var_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_var();
	partial void Leave_var();

	// $ANTLR start "var"
	// Plsql.g:504:1: var : ID -> ^( ID ) ;
	[GrammarRule("var")]
	private PlsqlParser.var_return var()
	{
		Enter_var();
		EnterRule("var", 61);
		TraceIn("var", 61);
		PlsqlParser.var_return retval = new PlsqlParser.var_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID285=null;

		object ID285_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "var");
		DebugLocation(504, 1);
		try
		{
			// Plsql.g:504:5: ( ID -> ^( ID ) )
			DebugEnterAlt(1);
			// Plsql.g:504:7: ID
			{
			DebugLocation(504, 7);
			ID285=(IToken)Match(input,ID,Follow._ID_in_var2959); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID285);



			{
			// AST REWRITE
			// elements: ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 505:2: -> ^( ID )
			{
				DebugLocation(505, 5);
				// Plsql.g:505:5: ^( ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(505, 7);
				root_1 = (object)adaptor.BecomeRoot(new VarNode(stream_ID.NextToken()), root_1);

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("var", 61);
			LeaveRule("var", 61);
			Leave_var();
		}
		DebugLocation(506, 1);
		} finally { DebugExitRule(GrammarFileName, "var"); }
		return retval;

	}
	// $ANTLR end "var"

	partial void Enter_synpred10_Plsql_fragment();
	partial void Leave_synpred10_Plsql_fragment();

	// $ANTLR start synpred10_Plsql
	public void synpred10_Plsql_fragment()
	{
		Enter_synpred10_Plsql_fragment();
		EnterRule("synpred10_Plsql_fragment", 71);
		TraceIn("synpred10_Plsql_fragment", 71);
		try
		{
			// Plsql.g:187:6: ( ID '.' ID )
			DebugEnterAlt(1);
			// Plsql.g:187:6: ID '.' ID
			{
			DebugLocation(187, 6);
			Match(input,ID,Follow._ID_in_synpred10_Plsql1030); if (state.failed) return;
			DebugLocation(187, 9);
			Match(input,101,Follow._101_in_synpred10_Plsql1032); if (state.failed) return;
			DebugLocation(187, 13);
			Match(input,ID,Follow._ID_in_synpred10_Plsql1034); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred10_Plsql_fragment", 71);
			LeaveRule("synpred10_Plsql_fragment", 71);
			Leave_synpred10_Plsql_fragment();
		}
	}
	// $ANTLR end synpred10_Plsql

	partial void Enter_synpred11_Plsql_fragment();
	partial void Leave_synpred11_Plsql_fragment();

	// $ANTLR start synpred11_Plsql
	public void synpred11_Plsql_fragment()
	{
		Enter_synpred11_Plsql_fragment();
		EnterRule("synpred11_Plsql_fragment", 72);
		TraceIn("synpred11_Plsql_fragment", 72);
		try
		{
			// Plsql.g:189:4: ( TABLE '(' type ')' INDEX BY type )
			DebugEnterAlt(1);
			// Plsql.g:189:4: TABLE '(' type ')' INDEX BY type
			{
			DebugLocation(189, 4);
			Match(input,TABLE,Follow._TABLE_in_synpred11_Plsql1054); if (state.failed) return;
			DebugLocation(189, 10);
			Match(input,102,Follow._102_in_synpred11_Plsql1056); if (state.failed) return;
			DebugLocation(189, 14);
			PushFollow(Follow._type_in_synpred11_Plsql1058);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(189, 19);
			Match(input,103,Follow._103_in_synpred11_Plsql1060); if (state.failed) return;
			DebugLocation(189, 23);
			Match(input,INDEX,Follow._INDEX_in_synpred11_Plsql1062); if (state.failed) return;
			DebugLocation(189, 29);
			Match(input,BY,Follow._BY_in_synpred11_Plsql1064); if (state.failed) return;
			DebugLocation(189, 32);
			PushFollow(Follow._type_in_synpred11_Plsql1066);
			type();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred11_Plsql_fragment", 72);
			LeaveRule("synpred11_Plsql_fragment", 72);
			Leave_synpred11_Plsql_fragment();
		}
	}
	// $ANTLR end synpred11_Plsql

	partial void Enter_synpred12_Plsql_fragment();
	partial void Leave_synpred12_Plsql_fragment();

	// $ANTLR start synpred12_Plsql
	public void synpred12_Plsql_fragment()
	{
		Enter_synpred12_Plsql_fragment();
		EnterRule("synpred12_Plsql_fragment", 73);
		TraceIn("synpred12_Plsql_fragment", 73);
		try
		{
			// Plsql.g:191:4: ( TABLE '(' type ')' )
			DebugEnterAlt(1);
			// Plsql.g:191:4: TABLE '(' type ')'
			{
			DebugLocation(191, 4);
			Match(input,TABLE,Follow._TABLE_in_synpred12_Plsql1086); if (state.failed) return;
			DebugLocation(191, 10);
			Match(input,102,Follow._102_in_synpred12_Plsql1088); if (state.failed) return;
			DebugLocation(191, 14);
			PushFollow(Follow._type_in_synpred12_Plsql1090);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(191, 19);
			Match(input,103,Follow._103_in_synpred12_Plsql1092); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred12_Plsql_fragment", 73);
			LeaveRule("synpred12_Plsql_fragment", 73);
			Leave_synpred12_Plsql_fragment();
		}
	}
	// $ANTLR end synpred12_Plsql

	partial void Enter_synpred35_Plsql_fragment();
	partial void Leave_synpred35_Plsql_fragment();

	// $ANTLR start synpred35_Plsql
	public void synpred35_Plsql_fragment()
	{
		Enter_synpred35_Plsql_fragment();
		EnterRule("synpred35_Plsql_fragment", 96);
		TraceIn("synpred35_Plsql_fragment", 96);
		try
		{
			// Plsql.g:293:4: ( TYPE ID IS TABLE OF type )
			DebugEnterAlt(1);
			// Plsql.g:293:4: TYPE ID IS TABLE OF type
			{
			DebugLocation(293, 4);
			Match(input,TYPE,Follow._TYPE_in_synpred35_Plsql1675); if (state.failed) return;
			DebugLocation(293, 9);
			Match(input,ID,Follow._ID_in_synpred35_Plsql1677); if (state.failed) return;
			DebugLocation(293, 12);
			Match(input,IS,Follow._IS_in_synpred35_Plsql1679); if (state.failed) return;
			DebugLocation(293, 15);
			Match(input,TABLE,Follow._TABLE_in_synpred35_Plsql1681); if (state.failed) return;
			DebugLocation(293, 21);
			Match(input,OF,Follow._OF_in_synpred35_Plsql1683); if (state.failed) return;
			DebugLocation(293, 24);
			PushFollow(Follow._type_in_synpred35_Plsql1685);
			type();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred35_Plsql_fragment", 96);
			LeaveRule("synpred35_Plsql_fragment", 96);
			Leave_synpred35_Plsql_fragment();
		}
	}
	// $ANTLR end synpred35_Plsql

	partial void Enter_synpred36_Plsql_fragment();
	partial void Leave_synpred36_Plsql_fragment();

	// $ANTLR start synpred36_Plsql
	public void synpred36_Plsql_fragment()
	{
		Enter_synpred36_Plsql_fragment();
		EnterRule("synpred36_Plsql_fragment", 97);
		TraceIn("synpred36_Plsql_fragment", 97);
		try
		{
			// Plsql.g:295:4: ( TYPE ID IS TABLE OF type INDEX BY type )
			DebugEnterAlt(1);
			// Plsql.g:295:4: TYPE ID IS TABLE OF type INDEX BY type
			{
			DebugLocation(295, 4);
			Match(input,TYPE,Follow._TYPE_in_synpred36_Plsql1704); if (state.failed) return;
			DebugLocation(295, 9);
			Match(input,ID,Follow._ID_in_synpred36_Plsql1706); if (state.failed) return;
			DebugLocation(295, 12);
			Match(input,IS,Follow._IS_in_synpred36_Plsql1708); if (state.failed) return;
			DebugLocation(295, 15);
			Match(input,TABLE,Follow._TABLE_in_synpred36_Plsql1710); if (state.failed) return;
			DebugLocation(295, 21);
			Match(input,OF,Follow._OF_in_synpred36_Plsql1712); if (state.failed) return;
			DebugLocation(295, 24);
			PushFollow(Follow._type_in_synpred36_Plsql1714);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(295, 29);
			Match(input,INDEX,Follow._INDEX_in_synpred36_Plsql1716); if (state.failed) return;
			DebugLocation(295, 35);
			Match(input,BY,Follow._BY_in_synpred36_Plsql1718); if (state.failed) return;
			DebugLocation(295, 38);
			PushFollow(Follow._type_in_synpred36_Plsql1720);
			type();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred36_Plsql_fragment", 97);
			LeaveRule("synpred36_Plsql_fragment", 97);
			Leave_synpred36_Plsql_fragment();
		}
	}
	// $ANTLR end synpred36_Plsql

	partial void Enter_synpred48_Plsql_fragment();
	partial void Leave_synpred48_Plsql_fragment();

	// $ANTLR start synpred48_Plsql
	public void synpred48_Plsql_fragment()
	{
		Enter_synpred48_Plsql_fragment();
		EnterRule("synpred48_Plsql_fragment", 109);
		TraceIn("synpred48_Plsql_fragment", 109);
		try
		{
			// Plsql.g:375:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:375:4: assign
			{
			DebugLocation(375, 4);
			PushFollow(Follow._assign_in_synpred48_Plsql2162);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred48_Plsql_fragment", 109);
			LeaveRule("synpred48_Plsql_fragment", 109);
			Leave_synpred48_Plsql_fragment();
		}
	}
	// $ANTLR end synpred48_Plsql

	partial void Enter_synpred51_Plsql_fragment();
	partial void Leave_synpred51_Plsql_fragment();

	// $ANTLR start synpred51_Plsql
	public void synpred51_Plsql_fragment()
	{
		Enter_synpred51_Plsql_fragment();
		EnterRule("synpred51_Plsql_fragment", 112);
		TraceIn("synpred51_Plsql_fragment", 112);
		try
		{
			// Plsql.g:378:4: ( expression )
			DebugEnterAlt(1);
			// Plsql.g:378:4: expression
			{
			DebugLocation(378, 4);
			PushFollow(Follow._expression_in_synpred51_Plsql2177);
			expression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred51_Plsql_fragment", 112);
			LeaveRule("synpred51_Plsql_fragment", 112);
			Leave_synpred51_Plsql_fragment();
		}
	}
	// $ANTLR end synpred51_Plsql

	partial void Enter_synpred56_Plsql_fragment();
	partial void Leave_synpred56_Plsql_fragment();

	// $ANTLR start synpred56_Plsql
	public void synpred56_Plsql_fragment()
	{
		Enter_synpred56_Plsql_fragment();
		EnterRule("synpred56_Plsql_fragment", 117);
		TraceIn("synpred56_Plsql_fragment", 117);
		try
		{
			// Plsql.g:400:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:400:4: assign
			{
			DebugLocation(400, 4);
			PushFollow(Follow._assign_in_synpred56_Plsql2384);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred56_Plsql_fragment", 117);
			LeaveRule("synpred56_Plsql_fragment", 117);
			Leave_synpred56_Plsql_fragment();
		}
	}
	// $ANTLR end synpred56_Plsql

	partial void Enter_synpred64_Plsql_fragment();
	partial void Leave_synpred64_Plsql_fragment();

	// $ANTLR start synpred64_Plsql
	public void synpred64_Plsql_fragment()
	{
		Enter_synpred64_Plsql_fragment();
		EnterRule("synpred64_Plsql_fragment", 125);
		TraceIn("synpred64_Plsql_fragment", 125);
		try
		{
			// Plsql.g:437:16: ( addOperator mult )
			DebugEnterAlt(1);
			// Plsql.g:437:16: addOperator mult
			{
			DebugLocation(437, 16);
			PushFollow(Follow._addOperator_in_synpred64_Plsql2563);
			addOperator();
			PopFollow();
			if (state.failed) return;
			DebugLocation(437, 29);
			PushFollow(Follow._mult_in_synpred64_Plsql2566);
			mult();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred64_Plsql_fragment", 125);
			LeaveRule("synpred64_Plsql_fragment", 125);
			Leave_synpred64_Plsql_fragment();
		}
	}
	// $ANTLR end synpred64_Plsql

	partial void Enter_synpred66_Plsql_fragment();
	partial void Leave_synpred66_Plsql_fragment();

	// $ANTLR start synpred66_Plsql
	public void synpred66_Plsql_fragment()
	{
		Enter_synpred66_Plsql_fragment();
		EnterRule("synpred66_Plsql_fragment", 127);
		TraceIn("synpred66_Plsql_fragment", 127);
		try
		{
			// Plsql.g:443:7: ( '(' type ')' unary )
			DebugEnterAlt(1);
			// Plsql.g:443:7: '(' type ')' unary
			{
			DebugLocation(443, 7);
			Match(input,102,Follow._102_in_synpred66_Plsql2601); if (state.failed) return;
			DebugLocation(443, 11);
			PushFollow(Follow._type_in_synpred66_Plsql2603);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(443, 16);
			Match(input,103,Follow._103_in_synpred66_Plsql2605); if (state.failed) return;
			DebugLocation(443, 20);
			PushFollow(Follow._unary_in_synpred66_Plsql2607);
			unary();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred66_Plsql_fragment", 127);
			LeaveRule("synpred66_Plsql_fragment", 127);
			Leave_synpred66_Plsql_fragment();
		}
	}
	// $ANTLR end synpred66_Plsql

	partial void Enter_synpred70_Plsql_fragment();
	partial void Leave_synpred70_Plsql_fragment();

	// $ANTLR start synpred70_Plsql
	public void synpred70_Plsql_fragment()
	{
		Enter_synpred70_Plsql_fragment();
		EnterRule("synpred70_Plsql_fragment", 131);
		TraceIn("synpred70_Plsql_fragment", 131);
		try
		{
			// Plsql.g:460:4: ( methodCall )
			DebugEnterAlt(1);
			// Plsql.g:460:4: methodCall
			{
			DebugLocation(460, 4);
			PushFollow(Follow._methodCall_in_synpred70_Plsql2682);
			methodCall();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred70_Plsql_fragment", 131);
			LeaveRule("synpred70_Plsql_fragment", 131);
			Leave_synpred70_Plsql_fragment();
		}
	}
	// $ANTLR end synpred70_Plsql

	partial void Enter_synpred79_Plsql_fragment();
	partial void Leave_synpred79_Plsql_fragment();

	// $ANTLR start synpred79_Plsql
	public void synpred79_Plsql_fragment()
	{
		Enter_synpred79_Plsql_fragment();
		EnterRule("synpred79_Plsql_fragment", 140);
		TraceIn("synpred79_Plsql_fragment", 140);
		try
		{
			// Plsql.g:498:6: ( createInstance )
			DebugEnterAlt(1);
			// Plsql.g:498:6: createInstance
			{
			DebugLocation(498, 6);
			PushFollow(Follow._createInstance_in_synpred79_Plsql2919);
			createInstance();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred79_Plsql_fragment", 140);
			LeaveRule("synpred79_Plsql_fragment", 140);
			Leave_synpred79_Plsql_fragment();
		}
	}
	// $ANTLR end synpred79_Plsql

	partial void Enter_synpred81_Plsql_fragment();
	partial void Leave_synpred81_Plsql_fragment();

	// $ANTLR start synpred81_Plsql
	public void synpred81_Plsql_fragment()
	{
		Enter_synpred81_Plsql_fragment();
		EnterRule("synpred81_Plsql_fragment", 142);
		TraceIn("synpred81_Plsql_fragment", 142);
		try
		{
			// Plsql.g:500:6: ( var )
			DebugEnterAlt(1);
			// Plsql.g:500:6: var
			{
			DebugLocation(500, 6);
			PushFollow(Follow._var_in_synpred81_Plsql2939);
			var();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred81_Plsql_fragment", 142);
			LeaveRule("synpred81_Plsql_fragment", 142);
			Leave_synpred81_Plsql_fragment();
		}
	}
	// $ANTLR end synpred81_Plsql
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA4 dfa4;
	DFA27 dfa27;
	DFA31 dfa31;
	DFA39 dfa39;
	DFA41 dfa41;
	DFA48 dfa48;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa4 = new DFA4( this, SpecialStateTransition4 );
		dfa27 = new DFA27( this, SpecialStateTransition27 );
		dfa31 = new DFA31( this, SpecialStateTransition31 );
		dfa39 = new DFA39( this, SpecialStateTransition39 );
		dfa41 = new DFA41( this, SpecialStateTransition41 );
		dfa48 = new DFA48( this, SpecialStateTransition48 );
	}

	private class DFA4 : DFA
	{
		private const string DFA4_eotS =
			"\xE\xFFFF";
		private const string DFA4_eofS =
			"\xE\xFFFF";
		private const string DFA4_minS =
			"\x1\x22\x6\xFFFF\x2\x0\x5\xFFFF";
		private const string DFA4_maxS =
			"\x1\x5F\x6\xFFFF\x2\x0\x5\xFFFF";
		private const string DFA4_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x2\xFFFF\x1\xA\x1\x7\x1"+
			"\xB\x1\x8\x1\x9";
		private const string DFA4_specialS =
			"\x7\xFFFF\x1\x0\x1\x1\x5\xFFFF}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x1\x2\x1\x1\x1\x3\x1\x6\x1\x4\x1\x5\x11\xFFFF\x1\x8\x1\x9\x24\xFFFF"+
				"\x1\x7",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
		private static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
		private static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
		private static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
		private static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
		private static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
		private static readonly short[][] DFA4_transition;

		static DFA4()
		{
			int numStates = DFA4_transitionS.Length;
			DFA4_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA4_transition[i] = DFA.UnpackEncodedString(DFA4_transitionS[i]);
			}
		}

		public DFA4( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 4;
			this.eot = DFA4_eot;
			this.eof = DFA4_eof;
			this.min = DFA4_min;
			this.max = DFA4_max;
			this.accept = DFA4_accept;
			this.special = DFA4_special;
			this.transition = DFA4_transition;
		}

		public override string Description { get { return "180:1: type : ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | TABLE '(' type ')' INDEX BY type -> ^( TypeName type type ) | TABLE '(' type ')' -> ^( TypeName type ) | ARRAY '(' type ( ',' expression )? ')' -> ^( TypeName type ( expression )? ) | ID -> ID );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition4(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA4_7 = input.LA(1);


				int index4_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred10_Plsql_fragment)) ) {s = 10;}

				else if ( (true) ) {s = 11;}


				input.Seek(index4_7);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA4_8 = input.LA(1);


				int index4_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred11_Plsql_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred12_Plsql_fragment)) ) {s = 13;}


				input.Seek(index4_8);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 4, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA27 : DFA
	{
		private const string DFA27_eotS =
			"\x15\xFFFF";
		private const string DFA27_eofS =
			"\x15\xFFFF";
		private const string DFA27_minS =
			"\x1\x2A\xD\x0\x7\xFFFF";
		private const string DFA27_maxS =
			"\x1\x66\xD\x0\x7\xFFFF";
		private const string DFA27_acceptS =
			"\xE\xFFFF\x1\x2\x1\x3\x2\xFFFF\x1\x5\x1\x1\x1\x4";
		private const string DFA27_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x1\xC\x7\xFFFF}>";
		private static readonly string[] DFA27_transitionS =
			{
				"\x1\xE\x3\xFFFF\x2\xF\x2\xFFFF\x1\xF\x6\xFFFF\x1\xB\x1\xC\xB\xFFFF"+
				"\x1\xD\x2\xFFFF\x1\x6\x1\x7\x1\x12\x1\xFFFF\x1\x2\xB\xFFFF\x1\x3\x5"+
				"\xFFFF\x1\xA\x1\x4\x1\x5\x1\x8\x1\x9\x2\xFFFF\x1\x1",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA27_eot = DFA.UnpackEncodedString(DFA27_eotS);
		private static readonly short[] DFA27_eof = DFA.UnpackEncodedString(DFA27_eofS);
		private static readonly char[] DFA27_min = DFA.UnpackEncodedStringToUnsignedChars(DFA27_minS);
		private static readonly char[] DFA27_max = DFA.UnpackEncodedStringToUnsignedChars(DFA27_maxS);
		private static readonly short[] DFA27_accept = DFA.UnpackEncodedString(DFA27_acceptS);
		private static readonly short[] DFA27_special = DFA.UnpackEncodedString(DFA27_specialS);
		private static readonly short[][] DFA27_transition;

		static DFA27()
		{
			int numStates = DFA27_transitionS.Length;
			DFA27_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA27_transition[i] = DFA.UnpackEncodedString(DFA27_transitionS[i]);
			}
		}

		public DFA27( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 27;
			this.eot = DFA27_eot;
			this.eof = DFA27_eof;
			this.min = DFA27_min;
			this.max = DFA27_max;
			this.accept = DFA27_accept;
			this.special = DFA27_special;
			this.transition = DFA27_transition;
		}

		public override string Description { get { return "374:1: command : ( assign | if_ | cycle | expression | RETURN expression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition27(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA27_1 = input.LA(1);


				int index27_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA27_2 = input.LA(1);


				int index27_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA27_3 = input.LA(1);


				int index27_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA27_4 = input.LA(1);


				int index27_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA27_5 = input.LA(1);


				int index27_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA27_6 = input.LA(1);


				int index27_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA27_7 = input.LA(1);


				int index27_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA27_8 = input.LA(1);


				int index27_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA27_9 = input.LA(1);


				int index27_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA27_10 = input.LA(1);


				int index27_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA27_11 = input.LA(1);


				int index27_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA27_12 = input.LA(1);


				int index27_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_12);
				if ( s>=0 ) return s;
				break;
			case 12:
				int LA27_13 = input.LA(1);


				int index27_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_13);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 27, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA31 : DFA
	{
		private const string DFA31_eotS =
			"\x10\xFFFF";
		private const string DFA31_eofS =
			"\x10\xFFFF";
		private const string DFA31_minS =
			"\x1\x39\xD\x0\x2\xFFFF";
		private const string DFA31_maxS =
			"\x1\x66\xD\x0\x2\xFFFF";
		private const string DFA31_acceptS =
			"\xE\xFFFF\x1\x1\x1\x2";
		private const string DFA31_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x1\xC\x2\xFFFF}>";
		private static readonly string[] DFA31_transitionS =
			{
				"\x1\xB\x1\xC\xB\xFFFF\x1\xD\x2\xFFFF\x1\x6\x1\x7\x2\xFFFF\x1\x2\xB"+
				"\xFFFF\x1\x3\x5\xFFFF\x1\xA\x1\x4\x1\x5\x1\x8\x1\x9\x2\xFFFF\x1\x1",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA31_eot = DFA.UnpackEncodedString(DFA31_eotS);
		private static readonly short[] DFA31_eof = DFA.UnpackEncodedString(DFA31_eofS);
		private static readonly char[] DFA31_min = DFA.UnpackEncodedStringToUnsignedChars(DFA31_minS);
		private static readonly char[] DFA31_max = DFA.UnpackEncodedStringToUnsignedChars(DFA31_maxS);
		private static readonly short[] DFA31_accept = DFA.UnpackEncodedString(DFA31_acceptS);
		private static readonly short[] DFA31_special = DFA.UnpackEncodedString(DFA31_specialS);
		private static readonly short[][] DFA31_transition;

		static DFA31()
		{
			int numStates = DFA31_transitionS.Length;
			DFA31_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA31_transition[i] = DFA.UnpackEncodedString(DFA31_transitionS[i]);
			}
		}

		public DFA31( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 31;
			this.eot = DFA31_eot;
			this.eof = DFA31_eof;
			this.min = DFA31_min;
			this.max = DFA31_max;
			this.accept = DFA31_accept;
			this.special = DFA31_special;
			this.transition = DFA31_transition;
		}

		public override string Description { get { return "399:1: assignOrExpression : ( assign | expression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition31(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA31_1 = input.LA(1);


				int index31_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA31_2 = input.LA(1);


				int index31_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA31_3 = input.LA(1);


				int index31_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA31_4 = input.LA(1);


				int index31_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA31_5 = input.LA(1);


				int index31_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA31_6 = input.LA(1);


				int index31_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA31_7 = input.LA(1);


				int index31_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA31_8 = input.LA(1);


				int index31_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA31_9 = input.LA(1);


				int index31_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA31_10 = input.LA(1);


				int index31_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA31_11 = input.LA(1);


				int index31_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA31_12 = input.LA(1);


				int index31_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_12);
				if ( s>=0 ) return s;
				break;
			case 12:
				int LA31_13 = input.LA(1);


				int index31_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_13);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 31, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA39 : DFA
	{
		private const string DFA39_eotS =
			"\x20\xFFFF";
		private const string DFA39_eofS =
			"\x1\x1\x1F\xFFFF";
		private const string DFA39_minS =
			"\x1\x2B\x12\xFFFF\x1\x0\xC\xFFFF";
		private const string DFA39_maxS =
			"\x1\x6B\x12\xFFFF\x1\x0\xC\xFFFF";
		private const string DFA39_acceptS =
			"\x1\xFFFF\x1\x2\x1D\xFFFF\x1\x1";
		private const string DFA39_specialS =
			"\x13\xFFFF\x1\x0\xC\xFFFF}>";
		private static readonly string[] DFA39_transitionS =
			{
				"\x1\x1\x3\xFFFF\x1\x1\x9\xFFFF\x2\x1\x8\xFFFF\x1\x1\x2\xFFFF\x1\x1"+
				"\x2\xFFFF\x2\x1\x1\xFFFF\x1\x1F\x1\x13\x3\xFFFF\xA\x1\x4\xFFFF\x5\x1"+
				"\x2\xFFFF\x4\x1\x1\xFFFF\x1\x1",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
		private static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
		private static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
		private static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
		private static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
		private static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
		private static readonly short[][] DFA39_transition;

		static DFA39()
		{
			int numStates = DFA39_transitionS.Length;
			DFA39_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA39_transition[i] = DFA.UnpackEncodedString(DFA39_transitionS[i]);
			}
		}

		public DFA39( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 39;
			this.eot = DFA39_eot;
			this.eof = DFA39_eof;
			this.min = DFA39_min;
			this.max = DFA39_max;
			this.accept = DFA39_accept;
			this.special = DFA39_special;
			this.transition = DFA39_transition;
		}

		public override string Description { get { return "()* loopback of 437:14: ( addOperator mult )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition39(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA39_19 = input.LA(1);


				int index39_19 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred64_Plsql_fragment)) ) {s = 31;}

				else if ( (true) ) {s = 1;}


				input.Seek(index39_19);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 39, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA41 : DFA
	{
		private const string DFA41_eotS =
			"\xF\xFFFF";
		private const string DFA41_eofS =
			"\xF\xFFFF";
		private const string DFA41_minS =
			"\x1\x39\x1\x0\xD\xFFFF";
		private const string DFA41_maxS =
			"\x1\x66\x1\x0\xD\xFFFF";
		private const string DFA41_acceptS =
			"\x2\xFFFF\x1\x2\xB\xFFFF\x1\x1";
		private const string DFA41_specialS =
			"\x1\xFFFF\x1\x0\xD\xFFFF}>";
		private static readonly string[] DFA41_transitionS =
			{
				"\x2\x2\xB\xFFFF\x1\x2\x2\xFFFF\x2\x2\x2\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
				"\x5\xFFFF\x5\x2\x2\xFFFF\x1\x1",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA41_eot = DFA.UnpackEncodedString(DFA41_eotS);
		private static readonly short[] DFA41_eof = DFA.UnpackEncodedString(DFA41_eofS);
		private static readonly char[] DFA41_min = DFA.UnpackEncodedStringToUnsignedChars(DFA41_minS);
		private static readonly char[] DFA41_max = DFA.UnpackEncodedStringToUnsignedChars(DFA41_maxS);
		private static readonly short[] DFA41_accept = DFA.UnpackEncodedString(DFA41_acceptS);
		private static readonly short[] DFA41_special = DFA.UnpackEncodedString(DFA41_specialS);
		private static readonly short[][] DFA41_transition;

		static DFA41()
		{
			int numStates = DFA41_transitionS.Length;
			DFA41_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA41_transition[i] = DFA.UnpackEncodedString(DFA41_transitionS[i]);
			}
		}

		public DFA41( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 41;
			this.eot = DFA41_eot;
			this.eof = DFA41_eof;
			this.min = DFA41_min;
			this.max = DFA41_max;
			this.accept = DFA41_accept;
			this.special = DFA41_special;
			this.transition = DFA41_transition;
		}

		public override string Description { get { return "443:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition41(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA41_1 = input.LA(1);


				int index41_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred66_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 2;}


				input.Seek(index41_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 41, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA48 : DFA
	{
		private const string DFA48_eotS =
			"\xD\xFFFF";
		private const string DFA48_eofS =
			"\xD\xFFFF";
		private const string DFA48_minS =
			"\x1\x39\x6\xFFFF\x1\x0\x5\xFFFF";
		private const string DFA48_maxS =
			"\x1\x66\x6\xFFFF\x1\x0\x5\xFFFF";
		private const string DFA48_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x2\x1\xFFFF\x1\x3\x1\x4\x1\xFFFF\x1\x5\x1"+
			"\xFFFF\x1\x6\x1\x8\x1\x7";
		private const string DFA48_specialS =
			"\x7\xFFFF\x1\x0\x5\xFFFF}>";
		private static readonly string[] DFA48_transitionS =
			{
				"\x2\x8\xB\xFFFF\x1\xB\x2\xFFFF\x2\x3\x14\xFFFF\x1\x7\x2\x1\x1\x5\x1"+
				"\x6\x2\xFFFF\x1\xA",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
		private static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
		private static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
		private static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
		private static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
		private static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
		private static readonly short[][] DFA48_transition;

		static DFA48()
		{
			int numStates = DFA48_transitionS.Length;
			DFA48_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA48_transition[i] = DFA.UnpackEncodedString(DFA48_transitionS[i]);
			}
		}

		public DFA48( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 48;
			this.eot = DFA48_eot;
			this.eof = DFA48_eof;
			this.min = DFA48_min;
			this.max = DFA48_max;
			this.accept = DFA48_accept;
			this.special = DFA48_special;
			this.transition = DFA48_transition;
		}

		public override string Description { get { return "493:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition48(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA48_7 = input.LA(1);


				int index48_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred79_Plsql_fragment)) ) {s = 8;}

				else if ( (EvaluatePredicate(synpred81_Plsql_fragment)) ) {s = 12;}


				input.Seek(index48_7);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 48, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _REAL_in_float_781 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_float_783 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_bool_802 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_bool_814 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTED_STRING_in_string_891 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTED_CHAR_in_char_905 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INTEGER_in_number919 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REAL_in_number931 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _float__in_number943 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_type954 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BYTE_in_type966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_type978 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DOUBLE_in_type990 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_in_type1002 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BOOL_in_type1016 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1030 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_type1032 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_type1034 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TABLE_in_type1054 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_type1056 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_type1058 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_type1060 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _INDEX_in_type1062 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _BY_in_type1064 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_type1066 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TABLE_in_type1086 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_type1088 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_type1090 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_type1092 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ARRAY_in_type1110 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_type1112 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_type1114 = new BitSet(new ulong[]{0x0UL,0x18000000000UL});
		public static readonly BitSet _104_in_type1117 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_type1119 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_type1124 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1147 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objOrPack_in_program1170 = new BitSet(new ulong[]{0x8000000000000UL,0x20UL});
		public static readonly BitSet _entryPoint_in_program1173 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _object__in_objOrPack1196 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _package__in_objOrPack1202 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_isOrAs0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_in_equalityOperator1232 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEQUAL_in_equalityOperator1244 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MORE_in_ineqOperator1262 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_in_ineqOperator1274 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOREEQ_in_ineqOperator1286 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESSEQ_in_ineqOperator1298 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PLUS_in_addOperator1316 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_addOperator1328 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MULT_in_multOperator1346 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DIVIDE_in_multOperator1358 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOD_in_multOperator1370 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_assignOperator0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_unaryOperator1419 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_unaryOperator1431 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varDef1452 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_varDef1454 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_varList1482 = new BitSet(new ulong[]{0x2UL,0x10000000000UL});
		public static readonly BitSet _104_in_varList1486 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _varDef_in_varList1488 = new BitSet(new ulong[]{0x2UL,0x10000000000UL});
		public static readonly BitSet _procDecl_in_methodDecl1514 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcDecl_in_methodDecl1519 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MEMBER_in_methodModifier1530 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STATIC_in_methodModifier1535 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_procDecl1553 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _PROCEDURE_in_procDecl1555 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_procDecl1557 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_procDecl1559 = new BitSet(new ulong[]{0x0UL,0x8080000000UL});
		public static readonly BitSet _varList_in_procDecl1561 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_procDecl1563 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_funcDecl1595 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _FUNCTION_in_funcDecl1597 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_funcDecl1599 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_funcDecl1601 = new BitSet(new ulong[]{0x0UL,0x8080000000UL});
		public static readonly BitSet _varList_in_funcDecl1603 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_funcDecl1605 = new BitSet(new ulong[]{0x0UL,0x800UL});
		public static readonly BitSet _RETURN_in_funcDecl1607 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_funcDecl1609 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_methodDef1638 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_methodDef1640 = new BitSet(new ulong[]{0x0UL,0x80000004UL});
		public static readonly BitSet _declareBlock_in_methodDef1642 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _BEGIN_in_methodDef1644 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_methodDef1646 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_methodDef1648 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1675 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_typeDecl1677 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1679 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _TABLE_in_typeDecl1681 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _OF_in_typeDecl1683 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_typeDecl1685 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1704 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_typeDecl1706 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1708 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _TABLE_in_typeDecl1710 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _OF_in_typeDecl1712 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_typeDecl1714 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _INDEX_in_typeDecl1716 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _BY_in_typeDecl1718 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_typeDecl1720 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1741 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_typeDecl1743 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1745 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _RECORD_in_typeDecl1747 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_typeDecl1749 = new BitSet(new ulong[]{0x0UL,0x8080000000UL});
		public static readonly BitSet _varList_in_typeDecl1751 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_typeDecl1753 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectDecl_in_object_1780 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectBody_in_object_1785 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectDecl1796 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectDecl1798 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_objectDecl1800 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectDecl1802 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectDecl1804 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectDecl1806 = new BitSet(new ulong[]{0x60000000000000UL,0x80000003UL});
		public static readonly BitSet _objectDeclItem_in_objectDecl1808 = new BitSet(new ulong[]{0x60000000000000UL,0x8080000003UL});
		public static readonly BitSet _103_in_objectDecl1811 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectDecl1813 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectBody1839 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectBody1841 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_objectBody1843 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_objectBody1845 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectBody1847 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectBody1849 = new BitSet(new ulong[]{0x60000000000000UL,0x8000000BUL});
		public static readonly BitSet _methodDef_in_objectBody1853 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectBody1855 = new BitSet(new ulong[]{0x60000000000000UL,0x8000000BUL});
		public static readonly BitSet _END_in_objectBody1860 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectBody1862 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_objectDeclItem1888 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectDeclItem1890 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_objectDeclItem1896 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectDeclItem1898 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDecl_in_package_1913 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDef_in_package_1918 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDecl1929 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _PACKAGE_in_packageDecl1931 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_packageDecl1933 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDecl1935 = new BitSet(new ulong[]{0x60020000000000UL,0x80000003UL});
		public static readonly BitSet _packageDeclItem_in_packageDecl1937 = new BitSet(new ulong[]{0x60020000000000UL,0x8000000BUL});
		public static readonly BitSet _END_in_packageDecl1940 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDecl1942 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDef1969 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _PACKAGE_in_packageDef1971 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_packageDef1973 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_packageDef1975 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDef1977 = new BitSet(new ulong[]{0x60000000000000UL,0x8000000BUL});
		public static readonly BitSet _packageBodyItem_in_packageDef1979 = new BitSet(new ulong[]{0x60000000000000UL,0x8000000BUL});
		public static readonly BitSet _END_in_packageDef1982 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDef1984 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_packageDeclItem2010 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDeclItem2012 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_packageDeclItem2018 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDeclItem2020 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_packageDeclItem2026 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDeclItem2028 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDef_in_packageBodyItem2040 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageBodyItem2042 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DECLARE_in_entryPoint2057 = new BitSet(new ulong[]{0x0UL,0x80000004UL});
		public static readonly BitSet _declareBlock_in_entryPoint2059 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _BEGIN_in_entryPoint2061 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_entryPoint2063 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_entryPoint2065 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_entryPoint2067 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declareItem_in_declareBlock2093 = new BitSet(new ulong[]{0x2UL,0x80000000UL});
		public static readonly BitSet _varDef_in_declareItem2118 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_declareItem2120 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _command_in_codeBlock2134 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_codeBlock2136 = new BitSet(new ulong[]{0x604C40000000002UL,0x4F82002E40UL});
		public static readonly BitSet _assign_in_command2162 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if__in_command2167 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cycle_in_command2172 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_command2177 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_command2182 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_command2188 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2199 = new BitSet(new ulong[]{0x0UL,0x4000000UL});
		public static readonly BitSet _ASSIGN_in_assign2201 = new BitSet(new ulong[]{0x600000000000000UL,0x4F820026C0UL});
		public static readonly BitSet _NULL_in_assign2209 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2216 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_if_2227 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_if_2229 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _THEN_in_if_2231 = new BitSet(new ulong[]{0x604D40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_if_2233 = new BitSet(new ulong[]{0x100000000000UL,0x8UL});
		public static readonly BitSet _ELSE_in_if_2236 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_if_2238 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_if_2242 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _IF_in_if_2244 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_cycle2275 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_cycle2277 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2279 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_cycle2281 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_cycle2283 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2285 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LOOP_in_cycle2304 = new BitSet(new ulong[]{0x605C40000000000UL,0x4F82002E40UL});
		public static readonly BitSet _codeBlock_in_cycle2306 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _EXIT_in_cycle2308 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _WHEN_in_cycle2310 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_cycle2312 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_cycle2314 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2316 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_cycle2335 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_cycle2337 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _assignOrExpression_in_cycle2339 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_cycle2341 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_cycle2343 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_cycle2345 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _assignOrExpression_in_cycle2347 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_cycle2349 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_cycle2351 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_cycle2353 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _FOR_in_cycle2355 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_assignOrExpression2384 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assignOrExpression2389 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr__in_expressionList2402 = new BitSet(new ulong[]{0x2UL,0x10000000000UL});
		public static readonly BitSet _104_in_expressionList2406 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expr__in_expressionList2408 = new BitSet(new ulong[]{0x2UL,0x10000000000UL});
		public static readonly BitSet _expr__in_expression2437 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicOr_in_expr_2460 = new BitSet(new ulong[]{0x600000000000002UL,0x4F82002640UL});
		public static readonly BitSet _logicAnd_in_logicOr2472 = new BitSet(new ulong[]{0x2UL,0x40000UL});
		public static readonly BitSet _OR_in_logicOr2476 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _logicAnd_in_logicOr2482 = new BitSet(new ulong[]{0x2UL,0x40000UL});
		public static readonly BitSet _equality_in_logicAnd2495 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _AND_in_logicAnd2499 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _equality_in_logicAnd2505 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _inequality_in_equality2518 = new BitSet(new ulong[]{0x2UL,0x180000UL});
		public static readonly BitSet _equalityOperator_in_equality2522 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _inequality_in_equality2525 = new BitSet(new ulong[]{0x2UL,0x180000UL});
		public static readonly BitSet _add_in_inequality2538 = new BitSet(new ulong[]{0x2UL,0x1E00000UL});
		public static readonly BitSet _ineqOperator_in_inequality2542 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _add_in_inequality2545 = new BitSet(new ulong[]{0x2UL,0x1E00000UL});
		public static readonly BitSet _mult_in_add2559 = new BitSet(new ulong[]{0x2UL,0x3000UL});
		public static readonly BitSet _addOperator_in_add2563 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _mult_in_add2566 = new BitSet(new ulong[]{0x2UL,0x3000UL});
		public static readonly BitSet _cast_in_mult2582 = new BitSet(new ulong[]{0x2UL,0x1C000UL});
		public static readonly BitSet _multOperator_in_mult2586 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _cast_in_mult2589 = new BitSet(new ulong[]{0x2UL,0x1C000UL});
		public static readonly BitSet _102_in_cast2601 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_cast2603 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_cast2605 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _unary_in_cast2607 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unary_in_cast2626 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryOperator_in_unary2638 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _unary_in_unary2641 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _postfix_in_unary2648 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quant_in_postfix2663 = new BitSet(new ulong[]{0x2UL,0x42000000000UL});
		public static readonly BitSet _tmp_in_postfix2665 = new BitSet(new ulong[]{0x2UL,0x42000000000UL});
		public static readonly BitSet _index_in_tmp2677 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_tmp2682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberCall_in_tmp2687 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _106_in_index2698 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_index2700 = new BitSet(new ulong[]{0x0UL,0x80000000000UL});
		public static readonly BitSet _107_in_index2702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _101_in_memberCall2725 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_memberCall2727 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressionOrEmpty2750 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _101_in_methodCall2768 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_methodCall2770 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_methodCall2772 = new BitSet(new ulong[]{0x600000000000000UL,0xCF82002640UL});
		public static readonly BitSet _expressionList_in_methodCall2774 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_methodCall2776 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_createInstance2801 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2803 = new BitSet(new ulong[]{0x600000000000000UL,0xCF82002640UL});
		public static readonly BitSet _expressionList_in_createInstance2805 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2807 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TABLE_in_createInstance2826 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2828 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_createInstance2830 = new BitSet(new ulong[]{0x0UL,0x18000000000UL});
		public static readonly BitSet _104_in_createInstance2833 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_createInstance2835 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2839 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ARRAY_in_createInstance2859 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2861 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_createInstance2863 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_createInstance2865 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_createInstance2867 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2868 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_quant2893 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bool__in_quant2900 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _string__in_quant2907 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _char__in_quant2912 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_quant2919 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_quant2926 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expr__in_quant2929 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_quant2931 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_quant2939 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SELF_in_quant2946 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_var2959 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_synpred10_Plsql1030 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_synpred10_Plsql1032 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_synpred10_Plsql1034 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TABLE_in_synpred11_Plsql1054 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_synpred11_Plsql1056 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred11_Plsql1058 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_synpred11_Plsql1060 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _INDEX_in_synpred11_Plsql1062 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _BY_in_synpred11_Plsql1064 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred11_Plsql1066 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TABLE_in_synpred12_Plsql1086 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_synpred12_Plsql1088 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred12_Plsql1090 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_synpred12_Plsql1092 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_synpred35_Plsql1675 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_synpred35_Plsql1677 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_synpred35_Plsql1679 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _TABLE_in_synpred35_Plsql1681 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _OF_in_synpred35_Plsql1683 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred35_Plsql1685 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_synpred36_Plsql1704 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_synpred36_Plsql1706 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_synpred36_Plsql1708 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _TABLE_in_synpred36_Plsql1710 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _OF_in_synpred36_Plsql1712 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred36_Plsql1714 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _INDEX_in_synpred36_Plsql1716 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _BY_in_synpred36_Plsql1718 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred36_Plsql1720 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred48_Plsql2162 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_synpred51_Plsql2177 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred56_Plsql2384 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _addOperator_in_synpred64_Plsql2563 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _mult_in_synpred64_Plsql2566 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_synpred66_Plsql2601 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred66_Plsql2603 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_synpred66_Plsql2605 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _unary_in_synpred66_Plsql2607 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_synpred70_Plsql2682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_synpred79_Plsql2919 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_synpred81_Plsql2939 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  plsql_msil 
