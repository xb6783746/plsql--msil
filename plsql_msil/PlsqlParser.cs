// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-29 16:10:22

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
				false, false, false, false, false, false, false, false, false, false, 
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
				// elements: type, expression
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
			// elements: ID, varList, methodModifier
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
			// elements: varList, methodModifier, type, ID
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
			// elements: declareBlock, methodDecl, codeBlock
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
	// Plsql.g:292:1: typeDecl : ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) );
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
		IToken RECORD94=null;
		IToken char_literal95=null;
		IToken char_literal97=null;
		PlsqlParser.type_return type90 = default(PlsqlParser.type_return);
		PlsqlParser.varList_return varList96 = default(PlsqlParser.varList_return);

		object TYPE85_tree=null;
		object ID86_tree=null;
		object IS87_tree=null;
		object TABLE88_tree=null;
		object OF89_tree=null;
		object TYPE91_tree=null;
		object ID92_tree=null;
		object IS93_tree=null;
		object RECORD94_tree=null;
		object char_literal95_tree=null;
		object char_literal97_tree=null;
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
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
			// Plsql.g:293:2: ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) )
			int alt16=2;
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==TYPE))
			{
				int LA16_1 = input.LA(2);

				if ((LA16_1==ID))
				{
					int LA16_2 = input.LA(3);

					if ((LA16_2==IS))
					{
						int LA16_3 = input.LA(4);

						if ((LA16_3==TABLE))
						{
							alt16=1;
						}
						else if ((LA16_3==RECORD))
						{
							alt16=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 16, 3, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 16, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
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
				// Plsql.g:295:4: TYPE ID IS RECORD '(' varList ')'
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
				RECORD94=(IToken)Match(input,RECORD,Follow._RECORD_in_typeDecl1710); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_RECORD.Add(RECORD94);

				DebugLocation(295, 22);
				char_literal95=(IToken)Match(input,102,Follow._102_in_typeDecl1712); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal95);

				DebugLocation(295, 26);
				PushFollow(Follow._varList_in_typeDecl1714);
				varList96=varList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varList.Add(varList96.Tree);
				DebugLocation(295, 34);
				char_literal97=(IToken)Match(input,103,Follow._103_in_typeDecl1716); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal97);



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
				// 296:2: -> ^( Record ID varList )
				{
					DebugLocation(296, 5);
					// Plsql.g:296:5: ^( Record ID varList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(296, 7);
					root_1 = (object)adaptor.BecomeRoot(new RecordNode(Record), root_1);

					DebugLocation(296, 26);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(296, 29);
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
		DebugLocation(297, 1);
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
	// Plsql.g:301:1: object_ : ( objectDecl | objectBody );
	[GrammarRule("object_")]
	private PlsqlParser.object__return object_()
	{
		Enter_object_();
		EnterRule("object_", 24);
		TraceIn("object_", 24);
		PlsqlParser.object__return retval = new PlsqlParser.object__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objectDecl_return objectDecl98 = default(PlsqlParser.objectDecl_return);
		PlsqlParser.objectBody_return objectBody99 = default(PlsqlParser.objectBody_return);


		try { DebugEnterRule(GrammarFileName, "object_");
		DebugLocation(301, 1);
		try
		{
			// Plsql.g:302:2: ( objectDecl | objectBody )
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
				// Plsql.g:302:4: objectDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(302, 4);
				PushFollow(Follow._objectDecl_in_object_1743);
				objectDecl98=objectDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectDecl98.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:303:4: objectBody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(303, 4);
				PushFollow(Follow._objectBody_in_object_1748);
				objectBody99=objectBody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectBody99.Tree);

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
		DebugLocation(304, 1);
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
	// Plsql.g:306:1: objectDecl : CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) ;
	[GrammarRule("objectDecl")]
	private PlsqlParser.objectDecl_return objectDecl()
	{
		Enter_objectDecl();
		EnterRule("objectDecl", 25);
		TraceIn("objectDecl", 25);
		PlsqlParser.objectDecl_return retval = new PlsqlParser.objectDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE100=null;
		IToken TYPE101=null;
		IToken ID102=null;
		IToken OBJECT104=null;
		IToken char_literal105=null;
		IToken char_literal107=null;
		IToken char_literal108=null;
		PlsqlParser.isOrAs_return isOrAs103 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.objectDeclItem_return objectDeclItem106 = default(PlsqlParser.objectDeclItem_return);

		object CREATE100_tree=null;
		object TYPE101_tree=null;
		object ID102_tree=null;
		object OBJECT104_tree=null;
		object char_literal105_tree=null;
		object char_literal107_tree=null;
		object char_literal108_tree=null;
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
		DebugLocation(306, 1);
		try
		{
			// Plsql.g:307:2: ( CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:307:4: CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';'
			{
			DebugLocation(307, 4);
			CREATE100=(IToken)Match(input,CREATE,Follow._CREATE_in_objectDecl1759); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE100);

			DebugLocation(307, 11);
			TYPE101=(IToken)Match(input,TYPE,Follow._TYPE_in_objectDecl1761); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE101);

			DebugLocation(307, 16);
			ID102=(IToken)Match(input,ID,Follow._ID_in_objectDecl1763); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID102);

			DebugLocation(307, 19);
			PushFollow(Follow._isOrAs_in_objectDecl1765);
			isOrAs103=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs103.Tree);
			DebugLocation(307, 26);
			OBJECT104=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectDecl1767); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT104);

			DebugLocation(307, 33);
			char_literal105=(IToken)Match(input,102,Follow._102_in_objectDecl1769); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal105);

			DebugLocation(307, 37);
			// Plsql.g:307:37: ( objectDeclItem )+
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
					DebugLocation(307, 37);
					PushFollow(Follow._objectDeclItem_in_objectDecl1771);
					objectDeclItem106=objectDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objectDeclItem.Add(objectDeclItem106.Tree);

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

			DebugLocation(307, 53);
			char_literal107=(IToken)Match(input,103,Follow._103_in_objectDecl1774); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal107);

			DebugLocation(307, 57);
			char_literal108=(IToken)Match(input,105,Follow._105_in_objectDecl1776); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal108);



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
			// 308:2: -> ^( ClassDecl ID ( objectDeclItem )+ )
			{
				DebugLocation(308, 5);
				// Plsql.g:308:5: ^( ClassDecl ID ( objectDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(308, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDeclNode(ClassDecl), root_1);

				DebugLocation(308, 32);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(308, 35);
				if ( !(stream_objectDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_objectDeclItem.HasNext )
				{
					DebugLocation(308, 35);
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
		DebugLocation(309, 1);
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
	// Plsql.g:311:1: objectBody : CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) ;
	[GrammarRule("objectBody")]
	private PlsqlParser.objectBody_return objectBody()
	{
		Enter_objectBody();
		EnterRule("objectBody", 26);
		TraceIn("objectBody", 26);
		PlsqlParser.objectBody_return retval = new PlsqlParser.objectBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE109=null;
		IToken TYPE110=null;
		IToken BODY111=null;
		IToken ID112=null;
		IToken OBJECT114=null;
		IToken char_literal116=null;
		IToken END117=null;
		IToken char_literal118=null;
		PlsqlParser.isOrAs_return isOrAs113 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.methodDef_return methodDef115 = default(PlsqlParser.methodDef_return);

		object CREATE109_tree=null;
		object TYPE110_tree=null;
		object BODY111_tree=null;
		object ID112_tree=null;
		object OBJECT114_tree=null;
		object char_literal116_tree=null;
		object END117_tree=null;
		object char_literal118_tree=null;
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
		DebugLocation(311, 1);
		try
		{
			// Plsql.g:312:2: ( CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:312:4: CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';'
			{
			DebugLocation(312, 4);
			CREATE109=(IToken)Match(input,CREATE,Follow._CREATE_in_objectBody1802); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE109);

			DebugLocation(312, 11);
			TYPE110=(IToken)Match(input,TYPE,Follow._TYPE_in_objectBody1804); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE110);

			DebugLocation(312, 16);
			BODY111=(IToken)Match(input,BODY,Follow._BODY_in_objectBody1806); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY111);

			DebugLocation(312, 21);
			ID112=(IToken)Match(input,ID,Follow._ID_in_objectBody1808); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID112);

			DebugLocation(312, 24);
			PushFollow(Follow._isOrAs_in_objectBody1810);
			isOrAs113=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs113.Tree);
			DebugLocation(312, 31);
			OBJECT114=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectBody1812); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT114);

			DebugLocation(312, 38);
			// Plsql.g:312:38: ( methodDef ';' )+
			int cnt19=0;
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
				switch (alt19)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:312:40: methodDef ';'
					{
					DebugLocation(312, 40);
					PushFollow(Follow._methodDef_in_objectBody1816);
					methodDef115=methodDef();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_methodDef.Add(methodDef115.Tree);
					DebugLocation(312, 50);
					char_literal116=(IToken)Match(input,105,Follow._105_in_objectBody1818); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_105.Add(char_literal116);


					}
					break;

				default:
					if (cnt19 >= 1)
						goto loop19;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee19 = new EarlyExitException( 19, input );
					DebugRecognitionException(eee19);
					throw eee19;
				}
				cnt19++;
			}
			loop19:
				;

			} finally { DebugExitSubRule(19); }

			DebugLocation(312, 57);
			END117=(IToken)Match(input,END,Follow._END_in_objectBody1823); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END117);

			DebugLocation(312, 61);
			char_literal118=(IToken)Match(input,105,Follow._105_in_objectBody1825); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal118);



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
			// 313:2: -> ^( ClassDef ID ( methodDef )+ )
			{
				DebugLocation(313, 5);
				// Plsql.g:313:5: ^( ClassDef ID ( methodDef )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(313, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDefNode(ClassDef), root_1);

				DebugLocation(313, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(313, 33);
				if ( !(stream_methodDef.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_methodDef.HasNext )
				{
					DebugLocation(313, 33);
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
		DebugLocation(314, 1);
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
	// Plsql.g:316:1: objectDeclItem : ( varDef ';' | methodDecl ';' );
	[GrammarRule("objectDeclItem")]
	private PlsqlParser.objectDeclItem_return objectDeclItem()
	{
		Enter_objectDeclItem();
		EnterRule("objectDeclItem", 27);
		TraceIn("objectDeclItem", 27);
		PlsqlParser.objectDeclItem_return retval = new PlsqlParser.objectDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal120=null;
		IToken char_literal122=null;
		PlsqlParser.varDef_return varDef119 = default(PlsqlParser.varDef_return);
		PlsqlParser.methodDecl_return methodDecl121 = default(PlsqlParser.methodDecl_return);

		object char_literal120_tree=null;
		object char_literal122_tree=null;

		try { DebugEnterRule(GrammarFileName, "objectDeclItem");
		DebugLocation(316, 1);
		try
		{
			// Plsql.g:317:2: ( varDef ';' | methodDecl ';' )
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
				// Plsql.g:317:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(317, 4);
				PushFollow(Follow._varDef_in_objectDeclItem1851);
				varDef119=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef119.Tree);
				DebugLocation(317, 14);
				char_literal120=(IToken)Match(input,105,Follow._105_in_objectDeclItem1853); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:318:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(318, 4);
				PushFollow(Follow._methodDecl_in_objectDeclItem1859);
				methodDecl121=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl121.Tree);
				DebugLocation(318, 18);
				char_literal122=(IToken)Match(input,105,Follow._105_in_objectDeclItem1861); if (state.failed) return retval;

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
		DebugLocation(319, 1);
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
	// Plsql.g:324:1: package_ : ( packageDecl | packageDef );
	[GrammarRule("package_")]
	private PlsqlParser.package__return package_()
	{
		Enter_package_();
		EnterRule("package_", 28);
		TraceIn("package_", 28);
		PlsqlParser.package__return retval = new PlsqlParser.package__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.packageDecl_return packageDecl123 = default(PlsqlParser.packageDecl_return);
		PlsqlParser.packageDef_return packageDef124 = default(PlsqlParser.packageDef_return);


		try { DebugEnterRule(GrammarFileName, "package_");
		DebugLocation(324, 1);
		try
		{
			// Plsql.g:325:2: ( packageDecl | packageDef )
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
				// Plsql.g:325:4: packageDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(325, 4);
				PushFollow(Follow._packageDecl_in_package_1876);
				packageDecl123=packageDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDecl123.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:326:4: packageDef
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(326, 4);
				PushFollow(Follow._packageDef_in_package_1881);
				packageDef124=packageDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDef124.Tree);

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
		DebugLocation(327, 1);
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
	// Plsql.g:329:1: packageDecl : CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) ;
	[GrammarRule("packageDecl")]
	private PlsqlParser.packageDecl_return packageDecl()
	{
		Enter_packageDecl();
		EnterRule("packageDecl", 29);
		TraceIn("packageDecl", 29);
		PlsqlParser.packageDecl_return retval = new PlsqlParser.packageDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE125=null;
		IToken PACKAGE126=null;
		IToken ID127=null;
		IToken END130=null;
		IToken char_literal131=null;
		PlsqlParser.isOrAs_return isOrAs128 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageDeclItem_return packageDeclItem129 = default(PlsqlParser.packageDeclItem_return);

		object CREATE125_tree=null;
		object PACKAGE126_tree=null;
		object ID127_tree=null;
		object END130_tree=null;
		object char_literal131_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_packageDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule packageDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDecl");
		DebugLocation(329, 1);
		try
		{
			// Plsql.g:330:2: ( CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:330:4: CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';'
			{
			DebugLocation(330, 4);
			CREATE125=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDecl1892); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE125);

			DebugLocation(330, 11);
			PACKAGE126=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDecl1894); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE126);

			DebugLocation(330, 19);
			ID127=(IToken)Match(input,ID,Follow._ID_in_packageDecl1896); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID127);

			DebugLocation(330, 22);
			PushFollow(Follow._isOrAs_in_packageDecl1898);
			isOrAs128=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs128.Tree);
			DebugLocation(330, 29);
			// Plsql.g:330:29: ( packageDeclItem )+
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
					DebugLocation(330, 29);
					PushFollow(Follow._packageDeclItem_in_packageDecl1900);
					packageDeclItem129=packageDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageDeclItem.Add(packageDeclItem129.Tree);

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

			DebugLocation(330, 46);
			END130=(IToken)Match(input,END,Follow._END_in_packageDecl1903); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END130);

			DebugLocation(330, 50);
			char_literal131=(IToken)Match(input,105,Follow._105_in_packageDecl1905); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal131);



			{
			// AST REWRITE
			// elements: packageDeclItem, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 331:2: -> ^( PackageDecl ID ( packageDeclItem )+ )
			{
				DebugLocation(331, 5);
				// Plsql.g:331:5: ^( PackageDecl ID ( packageDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(331, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDeclNode(PackageDecl), root_1);

				DebugLocation(331, 36);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(331, 39);
				if ( !(stream_packageDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageDeclItem.HasNext )
				{
					DebugLocation(331, 39);
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
		DebugLocation(332, 1);
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
	// Plsql.g:334:1: packageDef : CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) ;
	[GrammarRule("packageDef")]
	private PlsqlParser.packageDef_return packageDef()
	{
		Enter_packageDef();
		EnterRule("packageDef", 30);
		TraceIn("packageDef", 30);
		PlsqlParser.packageDef_return retval = new PlsqlParser.packageDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE132=null;
		IToken PACKAGE133=null;
		IToken BODY134=null;
		IToken ID135=null;
		IToken END138=null;
		IToken char_literal139=null;
		PlsqlParser.isOrAs_return isOrAs136 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageBodyItem_return packageBodyItem137 = default(PlsqlParser.packageBodyItem_return);

		object CREATE132_tree=null;
		object PACKAGE133_tree=null;
		object BODY134_tree=null;
		object ID135_tree=null;
		object END138_tree=null;
		object char_literal139_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_packageBodyItem=new RewriteRuleSubtreeStream(adaptor,"rule packageBodyItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDef");
		DebugLocation(334, 1);
		try
		{
			// Plsql.g:335:2: ( CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:335:4: CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';'
			{
			DebugLocation(335, 4);
			CREATE132=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDef1932); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE132);

			DebugLocation(335, 11);
			PACKAGE133=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDef1934); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE133);

			DebugLocation(335, 19);
			BODY134=(IToken)Match(input,BODY,Follow._BODY_in_packageDef1936); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY134);

			DebugLocation(335, 24);
			ID135=(IToken)Match(input,ID,Follow._ID_in_packageDef1938); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID135);

			DebugLocation(335, 27);
			PushFollow(Follow._isOrAs_in_packageDef1940);
			isOrAs136=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs136.Tree);
			DebugLocation(335, 34);
			// Plsql.g:335:34: ( packageBodyItem )+
			int cnt23=0;
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
				switch (alt23)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: packageBodyItem
					{
					DebugLocation(335, 34);
					PushFollow(Follow._packageBodyItem_in_packageDef1942);
					packageBodyItem137=packageBodyItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageBodyItem.Add(packageBodyItem137.Tree);

					}
					break;

				default:
					if (cnt23 >= 1)
						goto loop23;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee23 = new EarlyExitException( 23, input );
					DebugRecognitionException(eee23);
					throw eee23;
				}
				cnt23++;
			}
			loop23:
				;

			} finally { DebugExitSubRule(23); }

			DebugLocation(335, 51);
			END138=(IToken)Match(input,END,Follow._END_in_packageDef1945); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END138);

			DebugLocation(335, 55);
			char_literal139=(IToken)Match(input,105,Follow._105_in_packageDef1947); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal139);



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
			// 336:2: -> ^( PackageDef ID ( packageBodyItem )+ )
			{
				DebugLocation(336, 5);
				// Plsql.g:336:5: ^( PackageDef ID ( packageBodyItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(336, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDefNode(PackageDef), root_1);

				DebugLocation(336, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(336, 37);
				if ( !(stream_packageBodyItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageBodyItem.HasNext )
				{
					DebugLocation(336, 37);
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
		DebugLocation(337, 1);
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
	// Plsql.g:339:1: packageDeclItem : ( varDef ';' | typeDecl ';' | methodDecl ';' );
	[GrammarRule("packageDeclItem")]
	private PlsqlParser.packageDeclItem_return packageDeclItem()
	{
		Enter_packageDeclItem();
		EnterRule("packageDeclItem", 31);
		TraceIn("packageDeclItem", 31);
		PlsqlParser.packageDeclItem_return retval = new PlsqlParser.packageDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal141=null;
		IToken char_literal143=null;
		IToken char_literal145=null;
		PlsqlParser.varDef_return varDef140 = default(PlsqlParser.varDef_return);
		PlsqlParser.typeDecl_return typeDecl142 = default(PlsqlParser.typeDecl_return);
		PlsqlParser.methodDecl_return methodDecl144 = default(PlsqlParser.methodDecl_return);

		object char_literal141_tree=null;
		object char_literal143_tree=null;
		object char_literal145_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageDeclItem");
		DebugLocation(339, 1);
		try
		{
			// Plsql.g:340:2: ( varDef ';' | typeDecl ';' | methodDecl ';' )
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
				// Plsql.g:340:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(340, 4);
				PushFollow(Follow._varDef_in_packageDeclItem1973);
				varDef140=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef140.Tree);
				DebugLocation(340, 14);
				char_literal141=(IToken)Match(input,105,Follow._105_in_packageDeclItem1975); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:341:4: typeDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(341, 4);
				PushFollow(Follow._typeDecl_in_packageDeclItem1981);
				typeDecl142=typeDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeDecl142.Tree);
				DebugLocation(341, 16);
				char_literal143=(IToken)Match(input,105,Follow._105_in_packageDeclItem1983); if (state.failed) return retval;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:342:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(342, 4);
				PushFollow(Follow._methodDecl_in_packageDeclItem1989);
				methodDecl144=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl144.Tree);
				DebugLocation(342, 18);
				char_literal145=(IToken)Match(input,105,Follow._105_in_packageDeclItem1991); if (state.failed) return retval;

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
		DebugLocation(343, 1);
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
	// Plsql.g:345:1: packageBodyItem : methodDef ';' ;
	[GrammarRule("packageBodyItem")]
	private PlsqlParser.packageBodyItem_return packageBodyItem()
	{
		Enter_packageBodyItem();
		EnterRule("packageBodyItem", 32);
		TraceIn("packageBodyItem", 32);
		PlsqlParser.packageBodyItem_return retval = new PlsqlParser.packageBodyItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal147=null;
		PlsqlParser.methodDef_return methodDef146 = default(PlsqlParser.methodDef_return);

		object char_literal147_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageBodyItem");
		DebugLocation(345, 1);
		try
		{
			// Plsql.g:346:2: ( methodDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:346:4: methodDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(346, 4);
			PushFollow(Follow._methodDef_in_packageBodyItem2003);
			methodDef146=methodDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef146.Tree);
			DebugLocation(346, 17);
			char_literal147=(IToken)Match(input,105,Follow._105_in_packageBodyItem2005); if (state.failed) return retval;

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
		DebugLocation(347, 1);
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
	// Plsql.g:352:1: entryPoint : DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) ;
	[GrammarRule("entryPoint")]
	private PlsqlParser.entryPoint_return entryPoint()
	{
		Enter_entryPoint();
		EnterRule("entryPoint", 33);
		TraceIn("entryPoint", 33);
		PlsqlParser.entryPoint_return retval = new PlsqlParser.entryPoint_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DECLARE148=null;
		IToken BEGIN150=null;
		IToken END152=null;
		IToken char_literal153=null;
		PlsqlParser.declareBlock_return declareBlock149 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock151 = default(PlsqlParser.codeBlock_return);

		object DECLARE148_tree=null;
		object BEGIN150_tree=null;
		object END152_tree=null;
		object char_literal153_tree=null;
		RewriteRuleITokenStream stream_DECLARE=new RewriteRuleITokenStream(adaptor,"token DECLARE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "entryPoint");
		DebugLocation(352, 1);
		try
		{
			// Plsql.g:353:2: ( DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:353:4: DECLARE declareBlock BEGIN codeBlock END ';'
			{
			DebugLocation(353, 4);
			DECLARE148=(IToken)Match(input,DECLARE,Follow._DECLARE_in_entryPoint2020); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DECLARE.Add(DECLARE148);

			DebugLocation(353, 12);
			PushFollow(Follow._declareBlock_in_entryPoint2022);
			declareBlock149=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock149.Tree);
			DebugLocation(353, 25);
			BEGIN150=(IToken)Match(input,BEGIN,Follow._BEGIN_in_entryPoint2024); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN150);

			DebugLocation(353, 31);
			PushFollow(Follow._codeBlock_in_entryPoint2026);
			codeBlock151=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock151.Tree);
			DebugLocation(353, 41);
			END152=(IToken)Match(input,END,Follow._END_in_entryPoint2028); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END152);

			DebugLocation(353, 45);
			char_literal153=(IToken)Match(input,105,Follow._105_in_entryPoint2030); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal153);



			{
			// AST REWRITE
			// elements: declareBlock, codeBlock
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 354:2: -> ^( EntryPoint declareBlock codeBlock )
			{
				DebugLocation(354, 5);
				// Plsql.g:354:5: ^( EntryPoint declareBlock codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(354, 7);
				root_1 = (object)adaptor.BecomeRoot(new EntryPointNode(EntryPoint), root_1);

				DebugLocation(354, 34);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(354, 47);
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
		DebugLocation(355, 1);
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
	// Plsql.g:358:1: declareBlock : ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) ;
	[GrammarRule("declareBlock")]
	private PlsqlParser.declareBlock_return declareBlock()
	{
		Enter_declareBlock();
		EnterRule("declareBlock", 34);
		TraceIn("declareBlock", 34);
		PlsqlParser.declareBlock_return retval = new PlsqlParser.declareBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.declareItem_return declareItem154 = default(PlsqlParser.declareItem_return);

		RewriteRuleSubtreeStream stream_declareItem=new RewriteRuleSubtreeStream(adaptor,"rule declareItem");
		try { DebugEnterRule(GrammarFileName, "declareBlock");
		DebugLocation(358, 1);
		try
		{
			// Plsql.g:359:2: ( ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) )
			DebugEnterAlt(1);
			// Plsql.g:359:4: ( declareItem )*
			{
			DebugLocation(359, 4);
			// Plsql.g:359:4: ( declareItem )*
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
					DebugLocation(359, 4);
					PushFollow(Follow._declareItem_in_declareBlock2056);
					declareItem154=declareItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declareItem.Add(declareItem154.Tree);

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
			// 360:2: -> ^( DeclareBlock ( declareItem )* )
			{
				DebugLocation(360, 5);
				// Plsql.g:360:5: ^( DeclareBlock ( declareItem )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(360, 7);
				root_1 = (object)adaptor.BecomeRoot(new DeclareBlockNode(DeclareBlock), root_1);

				DebugLocation(360, 38);
				// Plsql.g:360:38: ( declareItem )*
				while ( stream_declareItem.HasNext )
				{
					DebugLocation(360, 38);
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
		DebugLocation(361, 1);
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
	// Plsql.g:363:1: declareItem : varDef ';' ;
	[GrammarRule("declareItem")]
	private PlsqlParser.declareItem_return declareItem()
	{
		Enter_declareItem();
		EnterRule("declareItem", 35);
		TraceIn("declareItem", 35);
		PlsqlParser.declareItem_return retval = new PlsqlParser.declareItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal156=null;
		PlsqlParser.varDef_return varDef155 = default(PlsqlParser.varDef_return);

		object char_literal156_tree=null;

		try { DebugEnterRule(GrammarFileName, "declareItem");
		DebugLocation(363, 1);
		try
		{
			// Plsql.g:364:2: ( varDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:364:4: varDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(364, 4);
			PushFollow(Follow._varDef_in_declareItem2081);
			varDef155=varDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef155.Tree);
			DebugLocation(364, 14);
			char_literal156=(IToken)Match(input,105,Follow._105_in_declareItem2083); if (state.failed) return retval;

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
		DebugLocation(365, 1);
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
	// Plsql.g:367:1: codeBlock : ( command ';' )* -> ^( CodeBlock ( command )* ) ;
	[GrammarRule("codeBlock")]
	private PlsqlParser.codeBlock_return codeBlock()
	{
		Enter_codeBlock();
		EnterRule("codeBlock", 36);
		TraceIn("codeBlock", 36);
		PlsqlParser.codeBlock_return retval = new PlsqlParser.codeBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal158=null;
		PlsqlParser.command_return command157 = default(PlsqlParser.command_return);

		object char_literal158_tree=null;
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_command=new RewriteRuleSubtreeStream(adaptor,"rule command");
		try { DebugEnterRule(GrammarFileName, "codeBlock");
		DebugLocation(367, 1);
		try
		{
			// Plsql.g:368:2: ( ( command ';' )* -> ^( CodeBlock ( command )* ) )
			DebugEnterAlt(1);
			// Plsql.g:368:4: ( command ';' )*
			{
			DebugLocation(368, 4);
			// Plsql.g:368:4: ( command ';' )*
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
					// Plsql.g:368:6: command ';'
					{
					DebugLocation(368, 6);
					PushFollow(Follow._command_in_codeBlock2097);
					command157=command();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_command.Add(command157.Tree);
					DebugLocation(368, 14);
					char_literal158=(IToken)Match(input,105,Follow._105_in_codeBlock2099); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_105.Add(char_literal158);


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
			// 369:2: -> ^( CodeBlock ( command )* )
			{
				DebugLocation(369, 5);
				// Plsql.g:369:5: ^( CodeBlock ( command )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(369, 7);
				root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(CodeBlock), root_1);

				DebugLocation(369, 32);
				// Plsql.g:369:32: ( command )*
				while ( stream_command.HasNext )
				{
					DebugLocation(369, 32);
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
		DebugLocation(370, 1);
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
	// Plsql.g:372:1: command : ( assign | if_ | cycle | expression | RETURN expression );
	[GrammarRule("command")]
	private PlsqlParser.command_return command()
	{
		Enter_command();
		EnterRule("command", 37);
		TraceIn("command", 37);
		PlsqlParser.command_return retval = new PlsqlParser.command_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken RETURN163=null;
		PlsqlParser.assign_return assign159 = default(PlsqlParser.assign_return);
		PlsqlParser.if__return if_160 = default(PlsqlParser.if__return);
		PlsqlParser.cycle_return cycle161 = default(PlsqlParser.cycle_return);
		PlsqlParser.expression_return expression162 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression164 = default(PlsqlParser.expression_return);

		object RETURN163_tree=null;

		try { DebugEnterRule(GrammarFileName, "command");
		DebugLocation(372, 1);
		try
		{
			// Plsql.g:373:2: ( assign | if_ | cycle | expression | RETURN expression )
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
				// Plsql.g:373:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(373, 4);
				PushFollow(Follow._assign_in_command2125);
				assign159=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign159.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:374:4: if_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(374, 4);
				PushFollow(Follow._if__in_command2130);
				if_160=if_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_160.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:375:4: cycle
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(375, 4);
				PushFollow(Follow._cycle_in_command2135);
				cycle161=cycle();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle161.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:376:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(376, 4);
				PushFollow(Follow._expression_in_command2140);
				expression162=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression162.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:377:4: RETURN expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(377, 22);
				RETURN163=(IToken)Match(input,RETURN,Follow._RETURN_in_command2145); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				RETURN163_tree = new ReturnNode(RETURN163) ;
				root_0 = (object)adaptor.BecomeRoot(RETURN163_tree, root_0);
				}
				DebugLocation(377, 24);
				PushFollow(Follow._expression_in_command2151);
				expression164=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression164.Tree);

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
		DebugLocation(378, 1);
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
	// Plsql.g:380:1: assign : expression ASSIGN ( NULL | expression ) ;
	[GrammarRule("assign")]
	private PlsqlParser.assign_return assign()
	{
		Enter_assign();
		EnterRule("assign", 38);
		TraceIn("assign", 38);
		PlsqlParser.assign_return retval = new PlsqlParser.assign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGN166=null;
		IToken NULL167=null;
		PlsqlParser.expression_return expression165 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression168 = default(PlsqlParser.expression_return);

		object ASSIGN166_tree=null;
		object NULL167_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign");
		DebugLocation(380, 1);
		try
		{
			// Plsql.g:381:2: ( expression ASSIGN ( NULL | expression ) )
			DebugEnterAlt(1);
			// Plsql.g:381:4: expression ASSIGN ( NULL | expression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(381, 4);
			PushFollow(Follow._expression_in_assign2162);
			expression165=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression165.Tree);
			DebugLocation(381, 33);
			ASSIGN166=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign2164); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN166_tree = new AssignNode(ASSIGN166) ;
			root_0 = (object)adaptor.BecomeRoot(ASSIGN166_tree, root_0);
			}
			DebugLocation(381, 35);
			// Plsql.g:381:35: ( NULL | expression )
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
				// Plsql.g:381:37: NULL
				{
				DebugLocation(381, 37);
				NULL167=(IToken)Match(input,NULL,Follow._NULL_in_assign2172); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NULL167_tree = new TypeNode(NULL167) ;
				adaptor.AddChild(root_0, NULL167_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:381:54: expression
				{
				DebugLocation(381, 54);
				PushFollow(Follow._expression_in_assign2179);
				expression168=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression168.Tree);

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
		DebugLocation(382, 1);
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
	// Plsql.g:384:1: if_ : IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) ;
	[GrammarRule("if_")]
	private PlsqlParser.if__return if_()
	{
		Enter_if_();
		EnterRule("if_", 39);
		TraceIn("if_", 39);
		PlsqlParser.if__return retval = new PlsqlParser.if__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF169=null;
		IToken THEN171=null;
		IToken ELSE173=null;
		IToken END175=null;
		IToken IF176=null;
		PlsqlParser.expression_return expression170 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock172 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock174 = default(PlsqlParser.codeBlock_return);

		object IF169_tree=null;
		object THEN171_tree=null;
		object ELSE173_tree=null;
		object END175_tree=null;
		object IF176_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "if_");
		DebugLocation(384, 1);
		try
		{
			// Plsql.g:384:5: ( IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) )
			DebugEnterAlt(1);
			// Plsql.g:384:7: IF expression THEN codeBlock ( ELSE codeBlock )? END IF
			{
			DebugLocation(384, 7);
			IF169=(IToken)Match(input,IF,Follow._IF_in_if_2190); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF169);

			DebugLocation(384, 10);
			PushFollow(Follow._expression_in_if_2192);
			expression170=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression170.Tree);
			DebugLocation(384, 21);
			THEN171=(IToken)Match(input,THEN,Follow._THEN_in_if_2194); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_THEN.Add(THEN171);

			DebugLocation(384, 26);
			PushFollow(Follow._codeBlock_in_if_2196);
			codeBlock172=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock172.Tree);
			DebugLocation(384, 36);
			// Plsql.g:384:36: ( ELSE codeBlock )?
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
				// Plsql.g:384:37: ELSE codeBlock
				{
				DebugLocation(384, 37);
				ELSE173=(IToken)Match(input,ELSE,Follow._ELSE_in_if_2199); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE173);

				DebugLocation(384, 42);
				PushFollow(Follow._codeBlock_in_if_2201);
				codeBlock174=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock174.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(29); }

			DebugLocation(384, 54);
			END175=(IToken)Match(input,END,Follow._END_in_if_2205); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END175);

			DebugLocation(384, 58);
			IF176=(IToken)Match(input,IF,Follow._IF_in_if_2207); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF176);



			{
			// AST REWRITE
			// elements: IF, expression, codeBlock, codeBlock
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 385:2: -> ^( IF expression codeBlock ( codeBlock )? )
			{
				DebugLocation(385, 5);
				// Plsql.g:385:5: ^( IF expression codeBlock ( codeBlock )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(385, 7);
				root_1 = (object)adaptor.BecomeRoot(new IfNode(stream_IF.NextToken()), root_1);

				DebugLocation(385, 18);
				adaptor.AddChild(root_1, stream_expression.NextTree());
				DebugLocation(385, 29);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());
				DebugLocation(385, 39);
				// Plsql.g:385:39: ( codeBlock )?
				if ( stream_codeBlock.HasNext )
				{
					DebugLocation(385, 39);
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
		DebugLocation(386, 1);
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
	// Plsql.g:388:1: cycle : ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) );
	[GrammarRule("cycle")]
	private PlsqlParser.cycle_return cycle()
	{
		Enter_cycle();
		EnterRule("cycle", 40);
		TraceIn("cycle", 40);
		PlsqlParser.cycle_return retval = new PlsqlParser.cycle_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE177=null;
		IToken LOOP179=null;
		IToken END181=null;
		IToken LOOP182=null;
		IToken LOOP183=null;
		IToken EXIT185=null;
		IToken WHEN186=null;
		IToken END188=null;
		IToken LOOP189=null;
		IToken FOR190=null;
		IToken char_literal191=null;
		IToken char_literal193=null;
		IToken char_literal195=null;
		IToken char_literal197=null;
		IToken END199=null;
		IToken FOR200=null;
		PlsqlParser.expression_return expression178 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock180 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock184 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.expression_return expression187 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression192 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.expression_return expression194 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression196 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.codeBlock_return codeBlock198 = default(PlsqlParser.codeBlock_return);

		object WHILE177_tree=null;
		object LOOP179_tree=null;
		object END181_tree=null;
		object LOOP182_tree=null;
		object LOOP183_tree=null;
		object EXIT185_tree=null;
		object WHEN186_tree=null;
		object END188_tree=null;
		object LOOP189_tree=null;
		object FOR190_tree=null;
		object char_literal191_tree=null;
		object char_literal193_tree=null;
		object char_literal195_tree=null;
		object char_literal197_tree=null;
		object END199_tree=null;
		object FOR200_tree=null;
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
		DebugLocation(388, 1);
		try
		{
			// Plsql.g:389:2: ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) )
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
				// Plsql.g:389:4: WHILE expression LOOP codeBlock END LOOP
				{
				DebugLocation(389, 4);
				WHILE177=(IToken)Match(input,WHILE,Follow._WHILE_in_cycle2238); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE177);

				DebugLocation(389, 10);
				PushFollow(Follow._expression_in_cycle2240);
				expression178=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression178.Tree);
				DebugLocation(389, 21);
				LOOP179=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2242); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP179);

				DebugLocation(389, 26);
				PushFollow(Follow._codeBlock_in_cycle2244);
				codeBlock180=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock180.Tree);
				DebugLocation(389, 36);
				END181=(IToken)Match(input,END,Follow._END_in_cycle2246); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END181);

				DebugLocation(389, 40);
				LOOP182=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2248); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP182);



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
				// 390:2: -> ^( WHILE expression codeBlock )
				{
					DebugLocation(390, 5);
					// Plsql.g:390:5: ^( WHILE expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(390, 7);
					root_1 = (object)adaptor.BecomeRoot(new WhileNode(stream_WHILE.NextToken()), root_1);

					DebugLocation(390, 24);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(390, 35);
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
				// Plsql.g:391:4: LOOP codeBlock EXIT WHEN expression END LOOP
				{
				DebugLocation(391, 4);
				LOOP183=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2267); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP183);

				DebugLocation(391, 9);
				PushFollow(Follow._codeBlock_in_cycle2269);
				codeBlock184=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock184.Tree);
				DebugLocation(391, 19);
				EXIT185=(IToken)Match(input,EXIT,Follow._EXIT_in_cycle2271); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EXIT.Add(EXIT185);

				DebugLocation(391, 24);
				WHEN186=(IToken)Match(input,WHEN,Follow._WHEN_in_cycle2273); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHEN.Add(WHEN186);

				DebugLocation(391, 29);
				PushFollow(Follow._expression_in_cycle2275);
				expression187=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression187.Tree);
				DebugLocation(391, 40);
				END188=(IToken)Match(input,END,Follow._END_in_cycle2277); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END188);

				DebugLocation(391, 44);
				LOOP189=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2279); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP189);



				{
				// AST REWRITE
				// elements: expression, codeBlock
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 392:2: -> ^( DO expression codeBlock )
				{
					DebugLocation(392, 5);
					// Plsql.g:392:5: ^( DO expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(392, 7);
					root_1 = (object)adaptor.BecomeRoot(new DoWhileNode(DO), root_1);

					DebugLocation(392, 23);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(392, 34);
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
				// Plsql.g:393:4: FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR
				{
				DebugLocation(393, 4);
				FOR190=(IToken)Match(input,FOR,Follow._FOR_in_cycle2298); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR190);

				DebugLocation(393, 8);
				char_literal191=(IToken)Match(input,102,Follow._102_in_cycle2300); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal191);

				DebugLocation(393, 12);
				PushFollow(Follow._assignOrExpression_in_cycle2302);
				assignOrExpression192=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression192.Tree);
				DebugLocation(393, 31);
				char_literal193=(IToken)Match(input,105,Follow._105_in_cycle2304); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_105.Add(char_literal193);

				DebugLocation(393, 35);
				PushFollow(Follow._expression_in_cycle2306);
				expression194=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression194.Tree);
				DebugLocation(393, 46);
				char_literal195=(IToken)Match(input,105,Follow._105_in_cycle2308); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_105.Add(char_literal195);

				DebugLocation(393, 50);
				PushFollow(Follow._assignOrExpression_in_cycle2310);
				assignOrExpression196=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression196.Tree);
				DebugLocation(393, 69);
				char_literal197=(IToken)Match(input,103,Follow._103_in_cycle2312); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal197);

				DebugLocation(393, 73);
				PushFollow(Follow._codeBlock_in_cycle2314);
				codeBlock198=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock198.Tree);
				DebugLocation(393, 83);
				END199=(IToken)Match(input,END,Follow._END_in_cycle2316); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END199);

				DebugLocation(393, 87);
				FOR200=(IToken)Match(input,FOR,Follow._FOR_in_cycle2318); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR200);



				{
				// AST REWRITE
				// elements: assignOrExpression, assignOrExpression, expression, FOR, codeBlock
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 394:2: -> ^( FOR assignOrExpression expression assignOrExpression codeBlock )
				{
					DebugLocation(394, 5);
					// Plsql.g:394:5: ^( FOR assignOrExpression expression assignOrExpression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(394, 7);
					root_1 = (object)adaptor.BecomeRoot(new ForNode(stream_FOR.NextToken()), root_1);

					DebugLocation(394, 20);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(394, 39);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(394, 50);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(394, 69);
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
		DebugLocation(395, 1);
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
	// Plsql.g:397:1: assignOrExpression : ( assign | expression );
	[GrammarRule("assignOrExpression")]
	private PlsqlParser.assignOrExpression_return assignOrExpression()
	{
		Enter_assignOrExpression();
		EnterRule("assignOrExpression", 41);
		TraceIn("assignOrExpression", 41);
		PlsqlParser.assignOrExpression_return retval = new PlsqlParser.assignOrExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.assign_return assign201 = default(PlsqlParser.assign_return);
		PlsqlParser.expression_return expression202 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "assignOrExpression");
		DebugLocation(397, 1);
		try
		{
			// Plsql.g:398:2: ( assign | expression )
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
				// Plsql.g:398:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(398, 4);
				PushFollow(Follow._assign_in_assignOrExpression2347);
				assign201=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign201.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:399:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(399, 4);
				PushFollow(Follow._expression_in_assignOrExpression2352);
				expression202=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression202.Tree);

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
		DebugLocation(400, 1);
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
	// Plsql.g:402:1: expressionList : ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) ;
	[GrammarRule("expressionList")]
	private PlsqlParser.expressionList_return expressionList()
	{
		Enter_expressionList();
		EnterRule("expressionList", 42);
		TraceIn("expressionList", 42);
		PlsqlParser.expressionList_return retval = new PlsqlParser.expressionList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal204=null;
		PlsqlParser.expr__return expr_203 = default(PlsqlParser.expr__return);
		PlsqlParser.expr__return expr_205 = default(PlsqlParser.expr__return);

		object char_literal204_tree=null;
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(402, 1);
		try
		{
			// Plsql.g:403:2: ( ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) )
			DebugEnterAlt(1);
			// Plsql.g:403:4: ( expr_ ( ',' expr_ )* )?
			{
			DebugLocation(403, 4);
			// Plsql.g:403:4: ( expr_ ( ',' expr_ )* )?
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
				// Plsql.g:403:6: expr_ ( ',' expr_ )*
				{
				DebugLocation(403, 6);
				PushFollow(Follow._expr__in_expressionList2365);
				expr_203=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_.Add(expr_203.Tree);
				DebugLocation(403, 12);
				// Plsql.g:403:12: ( ',' expr_ )*
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
						// Plsql.g:403:14: ',' expr_
						{
						DebugLocation(403, 14);
						char_literal204=(IToken)Match(input,104,Follow._104_in_expressionList2369); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_104.Add(char_literal204);

						DebugLocation(403, 18);
						PushFollow(Follow._expr__in_expressionList2371);
						expr_205=expr_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_expr_.Add(expr_205.Tree);

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
			// 404:2: -> ^( ExpressionList ( expr_ )* )
			{
				DebugLocation(404, 5);
				// Plsql.g:404:5: ^( ExpressionList ( expr_ )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(404, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ExpressionList, "ExpressionList"), root_1);

				DebugLocation(404, 22);
				// Plsql.g:404:22: ( expr_ )*
				while ( stream_expr_.HasNext )
				{
					DebugLocation(404, 22);
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
		DebugLocation(405, 1);
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
	// Plsql.g:410:1: expression : expr_ -> ^( Expression expr_ ) ;
	[GrammarRule("expression")]
	private PlsqlParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 43);
		TraceIn("expression", 43);
		PlsqlParser.expression_return retval = new PlsqlParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expr__return expr_206 = default(PlsqlParser.expr__return);

		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(410, 1);
		try
		{
			// Plsql.g:411:2: ( expr_ -> ^( Expression expr_ ) )
			DebugEnterAlt(1);
			// Plsql.g:411:4: expr_
			{
			DebugLocation(411, 4);
			PushFollow(Follow._expr__in_expression2400);
			expr_206=expr_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr_.Add(expr_206.Tree);


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
			// 412:2: -> ^( Expression expr_ )
			{
				DebugLocation(412, 5);
				// Plsql.g:412:5: ^( Expression expr_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(412, 7);
				root_1 = (object)adaptor.BecomeRoot(new ExpressionNode(Expression), root_1);

				DebugLocation(412, 34);
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
		DebugLocation(413, 1);
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
	// Plsql.g:415:1: expr_ : ( logicOr )+ ;
	[GrammarRule("expr_")]
	private PlsqlParser.expr__return expr_()
	{
		Enter_expr_();
		EnterRule("expr_", 44);
		TraceIn("expr_", 44);
		PlsqlParser.expr__return retval = new PlsqlParser.expr__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.logicOr_return logicOr207 = default(PlsqlParser.logicOr_return);


		try { DebugEnterRule(GrammarFileName, "expr_");
		DebugLocation(415, 1);
		try
		{
			// Plsql.g:416:2: ( ( logicOr )+ )
			DebugEnterAlt(1);
			// Plsql.g:416:4: ( logicOr )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(416, 4);
			// Plsql.g:416:4: ( logicOr )+
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
					DebugLocation(416, 4);
					PushFollow(Follow._logicOr_in_expr_2423);
					logicOr207=logicOr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicOr207.Tree);

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
		DebugLocation(417, 1);
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
	// Plsql.g:419:1: logicOr : logicAnd ( OR logicAnd )* ;
	[GrammarRule("logicOr")]
	private PlsqlParser.logicOr_return logicOr()
	{
		Enter_logicOr();
		EnterRule("logicOr", 45);
		TraceIn("logicOr", 45);
		PlsqlParser.logicOr_return retval = new PlsqlParser.logicOr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR209=null;
		PlsqlParser.logicAnd_return logicAnd208 = default(PlsqlParser.logicAnd_return);
		PlsqlParser.logicAnd_return logicAnd210 = default(PlsqlParser.logicAnd_return);

		object OR209_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicOr");
		DebugLocation(419, 1);
		try
		{
			// Plsql.g:420:2: ( logicAnd ( OR logicAnd )* )
			DebugEnterAlt(1);
			// Plsql.g:420:4: logicAnd ( OR logicAnd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(420, 4);
			PushFollow(Follow._logicAnd_in_logicOr2435);
			logicAnd208=logicAnd();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd208.Tree);
			DebugLocation(420, 13);
			// Plsql.g:420:13: ( OR logicAnd )*
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
					// Plsql.g:420:15: OR logicAnd
					{
					DebugLocation(420, 25);
					OR209=(IToken)Match(input,OR,Follow._OR_in_logicOr2439); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR209_tree = new OrNode(OR209) ;
					root_0 = (object)adaptor.BecomeRoot(OR209_tree, root_0);
					}
					DebugLocation(420, 27);
					PushFollow(Follow._logicAnd_in_logicOr2445);
					logicAnd210=logicAnd();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd210.Tree);

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
		DebugLocation(421, 1);
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
	// Plsql.g:423:1: logicAnd : equality ( AND equality )* ;
	[GrammarRule("logicAnd")]
	private PlsqlParser.logicAnd_return logicAnd()
	{
		Enter_logicAnd();
		EnterRule("logicAnd", 46);
		TraceIn("logicAnd", 46);
		PlsqlParser.logicAnd_return retval = new PlsqlParser.logicAnd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND212=null;
		PlsqlParser.equality_return equality211 = default(PlsqlParser.equality_return);
		PlsqlParser.equality_return equality213 = default(PlsqlParser.equality_return);

		object AND212_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicAnd");
		DebugLocation(423, 1);
		try
		{
			// Plsql.g:424:2: ( equality ( AND equality )* )
			DebugEnterAlt(1);
			// Plsql.g:424:4: equality ( AND equality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(424, 4);
			PushFollow(Follow._equality_in_logicAnd2458);
			equality211=equality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality211.Tree);
			DebugLocation(424, 13);
			// Plsql.g:424:13: ( AND equality )*
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
					// Plsql.g:424:15: AND equality
					{
					DebugLocation(424, 27);
					AND212=(IToken)Match(input,AND,Follow._AND_in_logicAnd2462); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND212_tree = new AndNode(AND212) ;
					root_0 = (object)adaptor.BecomeRoot(AND212_tree, root_0);
					}
					DebugLocation(424, 29);
					PushFollow(Follow._equality_in_logicAnd2468);
					equality213=equality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality213.Tree);

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
		DebugLocation(425, 1);
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
	// Plsql.g:427:1: equality : inequality ( equalityOperator inequality )* ;
	[GrammarRule("equality")]
	private PlsqlParser.equality_return equality()
	{
		Enter_equality();
		EnterRule("equality", 47);
		TraceIn("equality", 47);
		PlsqlParser.equality_return retval = new PlsqlParser.equality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.inequality_return inequality214 = default(PlsqlParser.inequality_return);
		PlsqlParser.equalityOperator_return equalityOperator215 = default(PlsqlParser.equalityOperator_return);
		PlsqlParser.inequality_return inequality216 = default(PlsqlParser.inequality_return);


		try { DebugEnterRule(GrammarFileName, "equality");
		DebugLocation(427, 1);
		try
		{
			// Plsql.g:428:2: ( inequality ( equalityOperator inequality )* )
			DebugEnterAlt(1);
			// Plsql.g:428:4: inequality ( equalityOperator inequality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(428, 4);
			PushFollow(Follow._inequality_in_equality2481);
			inequality214=inequality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality214.Tree);
			DebugLocation(428, 15);
			// Plsql.g:428:15: ( equalityOperator inequality )*
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
					// Plsql.g:428:17: equalityOperator inequality
					{
					DebugLocation(428, 33);
					PushFollow(Follow._equalityOperator_in_equality2485);
					equalityOperator215=equalityOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(equalityOperator215.Tree, root_0);
					DebugLocation(428, 35);
					PushFollow(Follow._inequality_in_equality2488);
					inequality216=inequality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality216.Tree);

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
		DebugLocation(429, 1);
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
	// Plsql.g:431:1: inequality : add ( ineqOperator add )* ;
	[GrammarRule("inequality")]
	private PlsqlParser.inequality_return inequality()
	{
		Enter_inequality();
		EnterRule("inequality", 48);
		TraceIn("inequality", 48);
		PlsqlParser.inequality_return retval = new PlsqlParser.inequality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.add_return add217 = default(PlsqlParser.add_return);
		PlsqlParser.ineqOperator_return ineqOperator218 = default(PlsqlParser.ineqOperator_return);
		PlsqlParser.add_return add219 = default(PlsqlParser.add_return);


		try { DebugEnterRule(GrammarFileName, "inequality");
		DebugLocation(431, 1);
		try
		{
			// Plsql.g:432:2: ( add ( ineqOperator add )* )
			DebugEnterAlt(1);
			// Plsql.g:432:4: add ( ineqOperator add )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(432, 4);
			PushFollow(Follow._add_in_inequality2501);
			add217=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add217.Tree);
			DebugLocation(432, 8);
			// Plsql.g:432:8: ( ineqOperator add )*
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
					// Plsql.g:432:10: ineqOperator add
					{
					DebugLocation(432, 22);
					PushFollow(Follow._ineqOperator_in_inequality2505);
					ineqOperator218=ineqOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(ineqOperator218.Tree, root_0);
					DebugLocation(432, 24);
					PushFollow(Follow._add_in_inequality2508);
					add219=add();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add219.Tree);

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
		DebugLocation(433, 1);
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
	// Plsql.g:435:1: add : mult ( addOperator mult )* ;
	[GrammarRule("add")]
	private PlsqlParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 49);
		TraceIn("add", 49);
		PlsqlParser.add_return retval = new PlsqlParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.mult_return mult220 = default(PlsqlParser.mult_return);
		PlsqlParser.addOperator_return addOperator221 = default(PlsqlParser.addOperator_return);
		PlsqlParser.mult_return mult222 = default(PlsqlParser.mult_return);


		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(435, 4);
		try
		{
			// Plsql.g:435:5: ( mult ( addOperator mult )* )
			DebugEnterAlt(1);
			// Plsql.g:435:9: mult ( addOperator mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(435, 9);
			PushFollow(Follow._mult_in_add2522);
			mult220=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult220.Tree);
			DebugLocation(435, 14);
			// Plsql.g:435:14: ( addOperator mult )*
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
					// Plsql.g:435:16: addOperator mult
					{
					DebugLocation(435, 27);
					PushFollow(Follow._addOperator_in_add2526);
					addOperator221=addOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperator221.Tree, root_0);
					DebugLocation(435, 29);
					PushFollow(Follow._mult_in_add2529);
					mult222=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult222.Tree);

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
		DebugLocation(436, 4);
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
	// Plsql.g:438:1: mult : cast ( multOperator cast )* ;
	[GrammarRule("mult")]
	private PlsqlParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 50);
		TraceIn("mult", 50);
		PlsqlParser.mult_return retval = new PlsqlParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.cast_return cast223 = default(PlsqlParser.cast_return);
		PlsqlParser.multOperator_return multOperator224 = default(PlsqlParser.multOperator_return);
		PlsqlParser.cast_return cast225 = default(PlsqlParser.cast_return);


		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(438, 1);
		try
		{
			// Plsql.g:438:5: ( cast ( multOperator cast )* )
			DebugEnterAlt(1);
			// Plsql.g:438:9: cast ( multOperator cast )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(438, 9);
			PushFollow(Follow._cast_in_mult2545);
			cast223=cast();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast223.Tree);
			DebugLocation(438, 14);
			// Plsql.g:438:14: ( multOperator cast )*
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
					// Plsql.g:438:16: multOperator cast
					{
					DebugLocation(438, 28);
					PushFollow(Follow._multOperator_in_mult2549);
					multOperator224=multOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperator224.Tree, root_0);
					DebugLocation(438, 30);
					PushFollow(Follow._cast_in_mult2552);
					cast225=cast();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast225.Tree);

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
		DebugLocation(439, 1);
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
	// Plsql.g:441:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );
	[GrammarRule("cast")]
	private PlsqlParser.cast_return cast()
	{
		Enter_cast();
		EnterRule("cast", 51);
		TraceIn("cast", 51);
		PlsqlParser.cast_return retval = new PlsqlParser.cast_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal226=null;
		IToken char_literal228=null;
		PlsqlParser.type_return type227 = default(PlsqlParser.type_return);
		PlsqlParser.unary_return unary229 = default(PlsqlParser.unary_return);
		PlsqlParser.unary_return unary230 = default(PlsqlParser.unary_return);

		object char_literal226_tree=null;
		object char_literal228_tree=null;
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_unary=new RewriteRuleSubtreeStream(adaptor,"rule unary");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "cast");
		DebugLocation(441, 1);
		try
		{
			// Plsql.g:441:5: ( '(' type ')' unary -> ^( Cast unary type ) | unary )
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
				// Plsql.g:441:7: '(' type ')' unary
				{
				DebugLocation(441, 7);
				char_literal226=(IToken)Match(input,102,Follow._102_in_cast2564); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal226);

				DebugLocation(441, 11);
				PushFollow(Follow._type_in_cast2566);
				type227=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type227.Tree);
				DebugLocation(441, 16);
				char_literal228=(IToken)Match(input,103,Follow._103_in_cast2568); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal228);

				DebugLocation(441, 20);
				PushFollow(Follow._unary_in_cast2570);
				unary229=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_unary.Add(unary229.Tree);


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
				// 442:2: -> ^( Cast unary type )
				{
					DebugLocation(442, 5);
					// Plsql.g:442:5: ^( Cast unary type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(442, 7);
					root_1 = (object)adaptor.BecomeRoot(new CastNode(Cast), root_1);

					DebugLocation(442, 22);
					adaptor.AddChild(root_1, stream_unary.NextTree());
					DebugLocation(442, 28);
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
				// Plsql.g:443:4: unary
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(443, 4);
				PushFollow(Follow._unary_in_cast2589);
				unary230=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary230.Tree);

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
		DebugLocation(444, 1);
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
	// Plsql.g:446:1: unary : ( ( unaryOperator unary ) | postfix );
	[GrammarRule("unary")]
	private PlsqlParser.unary_return unary()
	{
		Enter_unary();
		EnterRule("unary", 52);
		TraceIn("unary", 52);
		PlsqlParser.unary_return retval = new PlsqlParser.unary_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.unaryOperator_return unaryOperator231 = default(PlsqlParser.unaryOperator_return);
		PlsqlParser.unary_return unary232 = default(PlsqlParser.unary_return);
		PlsqlParser.postfix_return postfix233 = default(PlsqlParser.postfix_return);


		try { DebugEnterRule(GrammarFileName, "unary");
		DebugLocation(446, 1);
		try
		{
			// Plsql.g:447:2: ( ( unaryOperator unary ) | postfix )
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
				// Plsql.g:447:4: ( unaryOperator unary )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(447, 4);
				// Plsql.g:447:4: ( unaryOperator unary )
				DebugEnterAlt(1);
				// Plsql.g:447:5: unaryOperator unary
				{
				DebugLocation(447, 18);
				PushFollow(Follow._unaryOperator_in_unary2601);
				unaryOperator231=unaryOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(unaryOperator231.Tree, root_0);
				DebugLocation(447, 20);
				PushFollow(Follow._unary_in_unary2604);
				unary232=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary232.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:448:4: postfix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(448, 4);
				PushFollow(Follow._postfix_in_unary2611);
				postfix233=postfix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfix233.Tree);

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
		DebugLocation(449, 1);
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
	// Plsql.g:453:1: postfix : quant ( tmp )* ;
	[GrammarRule("postfix")]
	private PlsqlParser.postfix_return postfix()
	{
		Enter_postfix();
		EnterRule("postfix", 53);
		TraceIn("postfix", 53);
		PlsqlParser.postfix_return retval = new PlsqlParser.postfix_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.quant_return quant234 = default(PlsqlParser.quant_return);
		PlsqlParser.tmp_return tmp235 = default(PlsqlParser.tmp_return);


		try { DebugEnterRule(GrammarFileName, "postfix");
		DebugLocation(453, 1);
		try
		{
			// Plsql.g:454:2: ( quant ( tmp )* )
			DebugEnterAlt(1);
			// Plsql.g:454:4: quant ( tmp )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(454, 4);
			PushFollow(Follow._quant_in_postfix2626);
			quant234=quant();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quant234.Tree);
			DebugLocation(454, 13);
			// Plsql.g:454:13: ( tmp )*
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
					DebugLocation(454, 13);
					PushFollow(Follow._tmp_in_postfix2628);
					tmp235=tmp();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(tmp235.Tree, root_0);

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
		DebugLocation(455, 1);
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
	// Plsql.g:457:1: tmp : ( index | methodCall | memberCall );
	[GrammarRule("tmp")]
	private PlsqlParser.tmp_return tmp()
	{
		Enter_tmp();
		EnterRule("tmp", 54);
		TraceIn("tmp", 54);
		PlsqlParser.tmp_return retval = new PlsqlParser.tmp_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.index_return index236 = default(PlsqlParser.index_return);
		PlsqlParser.methodCall_return methodCall237 = default(PlsqlParser.methodCall_return);
		PlsqlParser.memberCall_return memberCall238 = default(PlsqlParser.memberCall_return);


		try { DebugEnterRule(GrammarFileName, "tmp");
		DebugLocation(457, 1);
		try
		{
			// Plsql.g:457:5: ( index | methodCall | memberCall )
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

				if ((EvaluatePredicate(synpred69_Plsql_fragment)))
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
				// Plsql.g:457:7: index
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(457, 7);
				PushFollow(Follow._index_in_tmp2640);
				index236=index();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, index236.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:458:4: methodCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(458, 4);
				PushFollow(Follow._methodCall_in_tmp2645);
				methodCall237=methodCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall237.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:459:4: memberCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(459, 4);
				PushFollow(Follow._memberCall_in_tmp2650);
				memberCall238=memberCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberCall238.Tree);

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
		DebugLocation(460, 1);
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
	// Plsql.g:462:1: index : '[' expression ']' -> ^( Index expression ) ;
	[GrammarRule("index")]
	private PlsqlParser.index_return index()
	{
		Enter_index();
		EnterRule("index", 55);
		TraceIn("index", 55);
		PlsqlParser.index_return retval = new PlsqlParser.index_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal239=null;
		IToken char_literal241=null;
		PlsqlParser.expression_return expression240 = default(PlsqlParser.expression_return);

		object char_literal239_tree=null;
		object char_literal241_tree=null;
		RewriteRuleITokenStream stream_107=new RewriteRuleITokenStream(adaptor,"token 107");
		RewriteRuleITokenStream stream_106=new RewriteRuleITokenStream(adaptor,"token 106");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "index");
		DebugLocation(462, 1);
		try
		{
			// Plsql.g:463:2: ( '[' expression ']' -> ^( Index expression ) )
			DebugEnterAlt(1);
			// Plsql.g:463:4: '[' expression ']'
			{
			DebugLocation(463, 4);
			char_literal239=(IToken)Match(input,106,Follow._106_in_index2661); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_106.Add(char_literal239);

			DebugLocation(463, 8);
			PushFollow(Follow._expression_in_index2663);
			expression240=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression240.Tree);
			DebugLocation(463, 19);
			char_literal241=(IToken)Match(input,107,Follow._107_in_index2665); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_107.Add(char_literal241);



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
			// 464:2: -> ^( Index expression )
			{
				DebugLocation(464, 5);
				// Plsql.g:464:5: ^( Index expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(464, 7);
				root_1 = (object)adaptor.BecomeRoot(new IndexNode(Index), root_1);

				DebugLocation(464, 24);
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
		DebugLocation(465, 1);
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
	// Plsql.g:467:1: memberCall : '.' ID -> ^( MemberCall ID ) ;
	[GrammarRule("memberCall")]
	private PlsqlParser.memberCall_return memberCall()
	{
		Enter_memberCall();
		EnterRule("memberCall", 56);
		TraceIn("memberCall", 56);
		PlsqlParser.memberCall_return retval = new PlsqlParser.memberCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal242=null;
		IToken ID243=null;

		object char_literal242_tree=null;
		object ID243_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");

		try { DebugEnterRule(GrammarFileName, "memberCall");
		DebugLocation(467, 1);
		try
		{
			// Plsql.g:468:2: ( '.' ID -> ^( MemberCall ID ) )
			DebugEnterAlt(1);
			// Plsql.g:468:4: '.' ID
			{
			DebugLocation(468, 4);
			char_literal242=(IToken)Match(input,101,Follow._101_in_memberCall2688); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal242);

			DebugLocation(468, 8);
			ID243=(IToken)Match(input,ID,Follow._ID_in_memberCall2690); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID243);



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
			// 469:2: -> ^( MemberCall ID )
			{
				DebugLocation(469, 5);
				// Plsql.g:469:5: ^( MemberCall ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(469, 7);
				root_1 = (object)adaptor.BecomeRoot(new MemberCallNode(MemberCall), root_1);

				DebugLocation(469, 34);
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
		DebugLocation(470, 1);
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
	// Plsql.g:472:1: expressionOrEmpty : ( expression | -> Expression );
	[GrammarRule("expressionOrEmpty")]
	private PlsqlParser.expressionOrEmpty_return expressionOrEmpty()
	{
		Enter_expressionOrEmpty();
		EnterRule("expressionOrEmpty", 57);
		TraceIn("expressionOrEmpty", 57);
		PlsqlParser.expressionOrEmpty_return retval = new PlsqlParser.expressionOrEmpty_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expression_return expression244 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "expressionOrEmpty");
		DebugLocation(472, 1);
		try
		{
			// Plsql.g:473:2: ( expression | -> Expression )
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
				// Plsql.g:473:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(473, 4);
				PushFollow(Follow._expression_in_expressionOrEmpty2713);
				expression244=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression244.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:474:4: 
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
				// 474:4: -> Expression
				{
					DebugLocation(474, 7);
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
		DebugLocation(475, 1);
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
	// Plsql.g:477:1: methodCall : '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) ;
	[GrammarRule("methodCall")]
	private PlsqlParser.methodCall_return methodCall()
	{
		Enter_methodCall();
		EnterRule("methodCall", 58);
		TraceIn("methodCall", 58);
		PlsqlParser.methodCall_return retval = new PlsqlParser.methodCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal245=null;
		IToken ID246=null;
		IToken char_literal247=null;
		IToken char_literal249=null;
		PlsqlParser.expressionList_return expressionList248 = default(PlsqlParser.expressionList_return);

		object char_literal245_tree=null;
		object ID246_tree=null;
		object char_literal247_tree=null;
		object char_literal249_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "methodCall");
		DebugLocation(477, 1);
		try
		{
			// Plsql.g:478:2: ( '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:478:4: '.' ID '(' expressionList ')'
			{
			DebugLocation(478, 4);
			char_literal245=(IToken)Match(input,101,Follow._101_in_methodCall2731); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal245);

			DebugLocation(478, 8);
			ID246=(IToken)Match(input,ID,Follow._ID_in_methodCall2733); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID246);

			DebugLocation(478, 11);
			char_literal247=(IToken)Match(input,102,Follow._102_in_methodCall2735); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal247);

			DebugLocation(478, 15);
			PushFollow(Follow._expressionList_in_methodCall2737);
			expressionList248=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList248.Tree);
			DebugLocation(478, 30);
			char_literal249=(IToken)Match(input,103,Follow._103_in_methodCall2739); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal249);



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
			// 479:2: -> ^( MethodCall ID expressionList )
			{
				DebugLocation(479, 5);
				// Plsql.g:479:5: ^( MethodCall ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(479, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodCallNode(MethodCall), root_1);

				DebugLocation(479, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(479, 37);
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
		DebugLocation(480, 1);
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
	// Plsql.g:482:1: createInstance : ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) | TABLE '(' type ( ',' type )? ')' -> ^( CreateInstance type ( type )? ) | ARRAY '(' type ',' expression ')' -> ^( CreateInstance type expression ) );
	[GrammarRule("createInstance")]
	private PlsqlParser.createInstance_return createInstance()
	{
		Enter_createInstance();
		EnterRule("createInstance", 59);
		TraceIn("createInstance", 59);
		PlsqlParser.createInstance_return retval = new PlsqlParser.createInstance_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID250=null;
		IToken char_literal251=null;
		IToken char_literal253=null;
		IToken TABLE254=null;
		IToken char_literal255=null;
		IToken char_literal257=null;
		IToken char_literal259=null;
		IToken ARRAY260=null;
		IToken char_literal261=null;
		IToken char_literal263=null;
		IToken char_literal265=null;
		PlsqlParser.expressionList_return expressionList252 = default(PlsqlParser.expressionList_return);
		PlsqlParser.type_return type256 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type258 = default(PlsqlParser.type_return);
		PlsqlParser.type_return type262 = default(PlsqlParser.type_return);
		PlsqlParser.expression_return expression264 = default(PlsqlParser.expression_return);

		object ID250_tree=null;
		object char_literal251_tree=null;
		object char_literal253_tree=null;
		object TABLE254_tree=null;
		object char_literal255_tree=null;
		object char_literal257_tree=null;
		object char_literal259_tree=null;
		object ARRAY260_tree=null;
		object char_literal261_tree=null;
		object char_literal263_tree=null;
		object char_literal265_tree=null;
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
		DebugLocation(482, 1);
		try
		{
			// Plsql.g:483:2: ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) | TABLE '(' type ( ',' type )? ')' -> ^( CreateInstance type ( type )? ) | ARRAY '(' type ',' expression ')' -> ^( CreateInstance type expression ) )
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
				// Plsql.g:483:4: ID '(' expressionList ')'
				{
				DebugLocation(483, 4);
				ID250=(IToken)Match(input,ID,Follow._ID_in_createInstance2764); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID250);

				DebugLocation(483, 7);
				char_literal251=(IToken)Match(input,102,Follow._102_in_createInstance2766); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal251);

				DebugLocation(483, 11);
				PushFollow(Follow._expressionList_in_createInstance2768);
				expressionList252=expressionList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList252.Tree);
				DebugLocation(483, 26);
				char_literal253=(IToken)Match(input,103,Follow._103_in_createInstance2770); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal253);



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
				// 484:2: -> ^( CreateInstance ID expressionList )
				{
					DebugLocation(484, 5);
					// Plsql.g:484:5: ^( CreateInstance ID expressionList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(484, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateInstanceNode(CreateInstance), root_1);

					DebugLocation(484, 42);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(484, 45);
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
				// Plsql.g:485:4: TABLE '(' type ( ',' type )? ')'
				{
				DebugLocation(485, 4);
				TABLE254=(IToken)Match(input,TABLE,Follow._TABLE_in_createInstance2789); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE254);

				DebugLocation(485, 10);
				char_literal255=(IToken)Match(input,102,Follow._102_in_createInstance2791); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal255);

				DebugLocation(485, 14);
				PushFollow(Follow._type_in_createInstance2793);
				type256=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type256.Tree);
				DebugLocation(485, 19);
				// Plsql.g:485:19: ( ',' type )?
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
					// Plsql.g:485:20: ',' type
					{
					DebugLocation(485, 20);
					char_literal257=(IToken)Match(input,104,Follow._104_in_createInstance2796); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal257);

					DebugLocation(485, 24);
					PushFollow(Follow._type_in_createInstance2798);
					type258=type();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type.Add(type258.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(46); }

				DebugLocation(485, 31);
				char_literal259=(IToken)Match(input,103,Follow._103_in_createInstance2802); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal259);



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
				// 486:2: -> ^( CreateInstance type ( type )? )
				{
					DebugLocation(486, 5);
					// Plsql.g:486:5: ^( CreateInstance type ( type )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(486, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateTableNode(CreateInstance), root_1);

					DebugLocation(486, 39);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(486, 44);
					// Plsql.g:486:44: ( type )?
					if ( stream_type.HasNext )
					{
						DebugLocation(486, 44);
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
				// Plsql.g:487:4: ARRAY '(' type ',' expression ')'
				{
				DebugLocation(487, 4);
				ARRAY260=(IToken)Match(input,ARRAY,Follow._ARRAY_in_createInstance2822); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY260);

				DebugLocation(487, 10);
				char_literal261=(IToken)Match(input,102,Follow._102_in_createInstance2824); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal261);

				DebugLocation(487, 14);
				PushFollow(Follow._type_in_createInstance2826);
				type262=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type262.Tree);
				DebugLocation(487, 19);
				char_literal263=(IToken)Match(input,104,Follow._104_in_createInstance2828); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_104.Add(char_literal263);

				DebugLocation(487, 23);
				PushFollow(Follow._expression_in_createInstance2830);
				expression264=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression264.Tree);
				DebugLocation(487, 33);
				char_literal265=(IToken)Match(input,103,Follow._103_in_createInstance2831); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal265);



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
				// 488:2: -> ^( CreateInstance type expression )
				{
					DebugLocation(488, 5);
					// Plsql.g:488:5: ^( CreateInstance type expression )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(488, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateArrayNode(CreateInstance), root_1);

					DebugLocation(488, 39);
					adaptor.AddChild(root_1, stream_type.NextTree());
					DebugLocation(488, 44);
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
		DebugLocation(489, 1);
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
	// Plsql.g:491:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );
	[GrammarRule("quant")]
	private PlsqlParser.quant_return quant()
	{
		Enter_quant();
		EnterRule("quant", 60);
		TraceIn("quant", 60);
		PlsqlParser.quant_return retval = new PlsqlParser.quant_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal271=null;
		IToken char_literal273=null;
		IToken SELF275=null;
		PlsqlParser.number_return number266 = default(PlsqlParser.number_return);
		PlsqlParser.bool__return bool_267 = default(PlsqlParser.bool__return);
		PlsqlParser.string__return string_268 = default(PlsqlParser.string__return);
		PlsqlParser.char__return char_269 = default(PlsqlParser.char__return);
		PlsqlParser.createInstance_return createInstance270 = default(PlsqlParser.createInstance_return);
		PlsqlParser.expr__return expr_272 = default(PlsqlParser.expr__return);
		PlsqlParser.var_return var274 = default(PlsqlParser.var_return);

		object char_literal271_tree=null;
		object char_literal273_tree=null;
		object SELF275_tree=null;

		try { DebugEnterRule(GrammarFileName, "quant");
		DebugLocation(491, 1);
		try
		{
			// Plsql.g:492:2: ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF )
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
				// Plsql.g:492:4: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(492, 4);
				PushFollow(Follow._number_in_quant2856);
				number266=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number266.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:493:6: bool_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(493, 6);
				PushFollow(Follow._bool__in_quant2863);
				bool_267=bool_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bool_267.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:494:6: string_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(494, 6);
				PushFollow(Follow._string__in_quant2870);
				string_268=string_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_268.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:495:4: char_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(495, 4);
				PushFollow(Follow._char__in_quant2875);
				char_269=char_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_269.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:496:6: createInstance
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(496, 6);
				PushFollow(Follow._createInstance_in_quant2882);
				createInstance270=createInstance();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, createInstance270.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:497:6: '(' expr_ ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(497, 9);
				char_literal271=(IToken)Match(input,102,Follow._102_in_quant2889); if (state.failed) return retval;
				DebugLocation(497, 11);
				PushFollow(Follow._expr__in_quant2892);
				expr_272=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_272.Tree);
				DebugLocation(497, 20);
				char_literal273=(IToken)Match(input,103,Follow._103_in_quant2894); if (state.failed) return retval;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:498:6: var
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(498, 6);
				PushFollow(Follow._var_in_quant2902);
				var274=var();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var274.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Plsql.g:499:6: SELF
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(499, 6);
				SELF275=(IToken)Match(input,SELF,Follow._SELF_in_quant2909); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				SELF275_tree = new SelfNode(SELF275) ;
				adaptor.AddChild(root_0, SELF275_tree);
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
		DebugLocation(500, 1);
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
	// Plsql.g:502:1: var : ID -> ^( ID ) ;
	[GrammarRule("var")]
	private PlsqlParser.var_return var()
	{
		Enter_var();
		EnterRule("var", 61);
		TraceIn("var", 61);
		PlsqlParser.var_return retval = new PlsqlParser.var_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID276=null;

		object ID276_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "var");
		DebugLocation(502, 1);
		try
		{
			// Plsql.g:502:5: ( ID -> ^( ID ) )
			DebugEnterAlt(1);
			// Plsql.g:502:7: ID
			{
			DebugLocation(502, 7);
			ID276=(IToken)Match(input,ID,Follow._ID_in_var2922); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID276);



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
			// 503:2: -> ^( ID )
			{
				DebugLocation(503, 5);
				// Plsql.g:503:5: ^( ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(503, 7);
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
		DebugLocation(504, 1);
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

	partial void Enter_synpred47_Plsql_fragment();
	partial void Leave_synpred47_Plsql_fragment();

	// $ANTLR start synpred47_Plsql
	public void synpred47_Plsql_fragment()
	{
		Enter_synpred47_Plsql_fragment();
		EnterRule("synpred47_Plsql_fragment", 108);
		TraceIn("synpred47_Plsql_fragment", 108);
		try
		{
			// Plsql.g:373:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:373:4: assign
			{
			DebugLocation(373, 4);
			PushFollow(Follow._assign_in_synpred47_Plsql2125);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred47_Plsql_fragment", 108);
			LeaveRule("synpred47_Plsql_fragment", 108);
			Leave_synpred47_Plsql_fragment();
		}
	}
	// $ANTLR end synpred47_Plsql

	partial void Enter_synpred50_Plsql_fragment();
	partial void Leave_synpred50_Plsql_fragment();

	// $ANTLR start synpred50_Plsql
	public void synpred50_Plsql_fragment()
	{
		Enter_synpred50_Plsql_fragment();
		EnterRule("synpred50_Plsql_fragment", 111);
		TraceIn("synpred50_Plsql_fragment", 111);
		try
		{
			// Plsql.g:376:4: ( expression )
			DebugEnterAlt(1);
			// Plsql.g:376:4: expression
			{
			DebugLocation(376, 4);
			PushFollow(Follow._expression_in_synpred50_Plsql2140);
			expression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred50_Plsql_fragment", 111);
			LeaveRule("synpred50_Plsql_fragment", 111);
			Leave_synpred50_Plsql_fragment();
		}
	}
	// $ANTLR end synpred50_Plsql

	partial void Enter_synpred55_Plsql_fragment();
	partial void Leave_synpred55_Plsql_fragment();

	// $ANTLR start synpred55_Plsql
	public void synpred55_Plsql_fragment()
	{
		Enter_synpred55_Plsql_fragment();
		EnterRule("synpred55_Plsql_fragment", 116);
		TraceIn("synpred55_Plsql_fragment", 116);
		try
		{
			// Plsql.g:398:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:398:4: assign
			{
			DebugLocation(398, 4);
			PushFollow(Follow._assign_in_synpred55_Plsql2347);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred55_Plsql_fragment", 116);
			LeaveRule("synpred55_Plsql_fragment", 116);
			Leave_synpred55_Plsql_fragment();
		}
	}
	// $ANTLR end synpred55_Plsql

	partial void Enter_synpred63_Plsql_fragment();
	partial void Leave_synpred63_Plsql_fragment();

	// $ANTLR start synpred63_Plsql
	public void synpred63_Plsql_fragment()
	{
		Enter_synpred63_Plsql_fragment();
		EnterRule("synpred63_Plsql_fragment", 124);
		TraceIn("synpred63_Plsql_fragment", 124);
		try
		{
			// Plsql.g:435:16: ( addOperator mult )
			DebugEnterAlt(1);
			// Plsql.g:435:16: addOperator mult
			{
			DebugLocation(435, 16);
			PushFollow(Follow._addOperator_in_synpred63_Plsql2526);
			addOperator();
			PopFollow();
			if (state.failed) return;
			DebugLocation(435, 29);
			PushFollow(Follow._mult_in_synpred63_Plsql2529);
			mult();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred63_Plsql_fragment", 124);
			LeaveRule("synpred63_Plsql_fragment", 124);
			Leave_synpred63_Plsql_fragment();
		}
	}
	// $ANTLR end synpred63_Plsql

	partial void Enter_synpred65_Plsql_fragment();
	partial void Leave_synpred65_Plsql_fragment();

	// $ANTLR start synpred65_Plsql
	public void synpred65_Plsql_fragment()
	{
		Enter_synpred65_Plsql_fragment();
		EnterRule("synpred65_Plsql_fragment", 126);
		TraceIn("synpred65_Plsql_fragment", 126);
		try
		{
			// Plsql.g:441:7: ( '(' type ')' unary )
			DebugEnterAlt(1);
			// Plsql.g:441:7: '(' type ')' unary
			{
			DebugLocation(441, 7);
			Match(input,102,Follow._102_in_synpred65_Plsql2564); if (state.failed) return;
			DebugLocation(441, 11);
			PushFollow(Follow._type_in_synpred65_Plsql2566);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(441, 16);
			Match(input,103,Follow._103_in_synpred65_Plsql2568); if (state.failed) return;
			DebugLocation(441, 20);
			PushFollow(Follow._unary_in_synpred65_Plsql2570);
			unary();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred65_Plsql_fragment", 126);
			LeaveRule("synpred65_Plsql_fragment", 126);
			Leave_synpred65_Plsql_fragment();
		}
	}
	// $ANTLR end synpred65_Plsql

	partial void Enter_synpred69_Plsql_fragment();
	partial void Leave_synpred69_Plsql_fragment();

	// $ANTLR start synpred69_Plsql
	public void synpred69_Plsql_fragment()
	{
		Enter_synpred69_Plsql_fragment();
		EnterRule("synpred69_Plsql_fragment", 130);
		TraceIn("synpred69_Plsql_fragment", 130);
		try
		{
			// Plsql.g:458:4: ( methodCall )
			DebugEnterAlt(1);
			// Plsql.g:458:4: methodCall
			{
			DebugLocation(458, 4);
			PushFollow(Follow._methodCall_in_synpred69_Plsql2645);
			methodCall();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred69_Plsql_fragment", 130);
			LeaveRule("synpred69_Plsql_fragment", 130);
			Leave_synpred69_Plsql_fragment();
		}
	}
	// $ANTLR end synpred69_Plsql

	partial void Enter_synpred78_Plsql_fragment();
	partial void Leave_synpred78_Plsql_fragment();

	// $ANTLR start synpred78_Plsql
	public void synpred78_Plsql_fragment()
	{
		Enter_synpred78_Plsql_fragment();
		EnterRule("synpred78_Plsql_fragment", 139);
		TraceIn("synpred78_Plsql_fragment", 139);
		try
		{
			// Plsql.g:496:6: ( createInstance )
			DebugEnterAlt(1);
			// Plsql.g:496:6: createInstance
			{
			DebugLocation(496, 6);
			PushFollow(Follow._createInstance_in_synpred78_Plsql2882);
			createInstance();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred78_Plsql_fragment", 139);
			LeaveRule("synpred78_Plsql_fragment", 139);
			Leave_synpred78_Plsql_fragment();
		}
	}
	// $ANTLR end synpred78_Plsql

	partial void Enter_synpred80_Plsql_fragment();
	partial void Leave_synpred80_Plsql_fragment();

	// $ANTLR start synpred80_Plsql
	public void synpred80_Plsql_fragment()
	{
		Enter_synpred80_Plsql_fragment();
		EnterRule("synpred80_Plsql_fragment", 141);
		TraceIn("synpred80_Plsql_fragment", 141);
		try
		{
			// Plsql.g:498:6: ( var )
			DebugEnterAlt(1);
			// Plsql.g:498:6: var
			{
			DebugLocation(498, 6);
			PushFollow(Follow._var_in_synpred80_Plsql2902);
			var();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred80_Plsql_fragment", 141);
			LeaveRule("synpred80_Plsql_fragment", 141);
			Leave_synpred80_Plsql_fragment();
		}
	}
	// $ANTLR end synpred80_Plsql
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

		public override string Description { get { return "372:1: command : ( assign | if_ | cycle | expression | RETURN expression );"; } }

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
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA27_2 = input.LA(1);


				int index27_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA27_3 = input.LA(1);


				int index27_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA27_4 = input.LA(1);


				int index27_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA27_5 = input.LA(1);


				int index27_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA27_6 = input.LA(1);


				int index27_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA27_7 = input.LA(1);


				int index27_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA27_8 = input.LA(1);


				int index27_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA27_9 = input.LA(1);


				int index27_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA27_10 = input.LA(1);


				int index27_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA27_11 = input.LA(1);


				int index27_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA27_12 = input.LA(1);


				int index27_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


				input.Seek(index27_12);
				if ( s>=0 ) return s;
				break;
			case 12:
				int LA27_13 = input.LA(1);


				int index27_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred50_Plsql_fragment)) ) {s = 20;}


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

		public override string Description { get { return "397:1: assignOrExpression : ( assign | expression );"; } }

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
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA31_2 = input.LA(1);


				int index31_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA31_3 = input.LA(1);


				int index31_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA31_4 = input.LA(1);


				int index31_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA31_5 = input.LA(1);


				int index31_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA31_6 = input.LA(1);


				int index31_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA31_7 = input.LA(1);


				int index31_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA31_8 = input.LA(1);


				int index31_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA31_9 = input.LA(1);


				int index31_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA31_10 = input.LA(1);


				int index31_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA31_11 = input.LA(1);


				int index31_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA31_12 = input.LA(1);


				int index31_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 15;}


				input.Seek(index31_12);
				if ( s>=0 ) return s;
				break;
			case 12:
				int LA31_13 = input.LA(1);


				int index31_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 14;}

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

		public override string Description { get { return "()* loopback of 435:14: ( addOperator mult )*"; } }

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
				if ( (EvaluatePredicate(synpred63_Plsql_fragment)) ) {s = 31;}

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

		public override string Description { get { return "441:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );"; } }

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
				if ( (EvaluatePredicate(synpred65_Plsql_fragment)) ) {s = 14;}

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

		public override string Description { get { return "491:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );"; } }

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
				if ( (EvaluatePredicate(synpred78_Plsql_fragment)) ) {s = 8;}

				else if ( (EvaluatePredicate(synpred80_Plsql_fragment)) ) {s = 12;}


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
		public static readonly BitSet _IS_in_typeDecl1708 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _RECORD_in_typeDecl1710 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_typeDecl1712 = new BitSet(new ulong[]{0x0UL,0x8080000000UL});
		public static readonly BitSet _varList_in_typeDecl1714 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_typeDecl1716 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectDecl_in_object_1743 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectBody_in_object_1748 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectDecl1759 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectDecl1761 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_objectDecl1763 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectDecl1765 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectDecl1767 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectDecl1769 = new BitSet(new ulong[]{0x60000000000000UL,0x80000003UL});
		public static readonly BitSet _objectDeclItem_in_objectDecl1771 = new BitSet(new ulong[]{0x60000000000000UL,0x8080000003UL});
		public static readonly BitSet _103_in_objectDecl1774 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectDecl1776 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectBody1802 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectBody1804 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_objectBody1806 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_objectBody1808 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectBody1810 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectBody1812 = new BitSet(new ulong[]{0x60000000000000UL,0x80000003UL});
		public static readonly BitSet _methodDef_in_objectBody1816 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectBody1818 = new BitSet(new ulong[]{0x60000000000000UL,0x8000000BUL});
		public static readonly BitSet _END_in_objectBody1823 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectBody1825 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_objectDeclItem1851 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectDeclItem1853 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_objectDeclItem1859 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_objectDeclItem1861 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDecl_in_package_1876 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDef_in_package_1881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDecl1892 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _PACKAGE_in_packageDecl1894 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_packageDecl1896 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDecl1898 = new BitSet(new ulong[]{0x60020000000000UL,0x80000003UL});
		public static readonly BitSet _packageDeclItem_in_packageDecl1900 = new BitSet(new ulong[]{0x60020000000000UL,0x8000000BUL});
		public static readonly BitSet _END_in_packageDecl1903 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDecl1905 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDef1932 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _PACKAGE_in_packageDef1934 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_packageDef1936 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_packageDef1938 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDef1940 = new BitSet(new ulong[]{0x60000000000000UL,0x80000003UL});
		public static readonly BitSet _packageBodyItem_in_packageDef1942 = new BitSet(new ulong[]{0x60000000000000UL,0x8000000BUL});
		public static readonly BitSet _END_in_packageDef1945 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDef1947 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_packageDeclItem1973 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDeclItem1975 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_packageDeclItem1981 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDeclItem1983 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_packageDeclItem1989 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageDeclItem1991 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDef_in_packageBodyItem2003 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_packageBodyItem2005 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DECLARE_in_entryPoint2020 = new BitSet(new ulong[]{0x0UL,0x80000004UL});
		public static readonly BitSet _declareBlock_in_entryPoint2022 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _BEGIN_in_entryPoint2024 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_entryPoint2026 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_entryPoint2028 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_entryPoint2030 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declareItem_in_declareBlock2056 = new BitSet(new ulong[]{0x2UL,0x80000000UL});
		public static readonly BitSet _varDef_in_declareItem2081 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_declareItem2083 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _command_in_codeBlock2097 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_codeBlock2099 = new BitSet(new ulong[]{0x604C40000000002UL,0x4F82002E40UL});
		public static readonly BitSet _assign_in_command2125 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if__in_command2130 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cycle_in_command2135 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_command2140 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_command2145 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_command2151 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2162 = new BitSet(new ulong[]{0x0UL,0x4000000UL});
		public static readonly BitSet _ASSIGN_in_assign2164 = new BitSet(new ulong[]{0x600000000000000UL,0x4F820026C0UL});
		public static readonly BitSet _NULL_in_assign2172 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2179 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_if_2190 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_if_2192 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _THEN_in_if_2194 = new BitSet(new ulong[]{0x604D40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_if_2196 = new BitSet(new ulong[]{0x100000000000UL,0x8UL});
		public static readonly BitSet _ELSE_in_if_2199 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_if_2201 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_if_2205 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _IF_in_if_2207 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_cycle2238 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_cycle2240 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2242 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_cycle2244 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_cycle2246 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2248 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LOOP_in_cycle2267 = new BitSet(new ulong[]{0x605C40000000000UL,0x4F82002E40UL});
		public static readonly BitSet _codeBlock_in_cycle2269 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _EXIT_in_cycle2271 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _WHEN_in_cycle2273 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_cycle2275 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_cycle2277 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2279 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_cycle2298 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_cycle2300 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _assignOrExpression_in_cycle2302 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_cycle2304 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_cycle2306 = new BitSet(new ulong[]{0x0UL,0x20000000000UL});
		public static readonly BitSet _105_in_cycle2308 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _assignOrExpression_in_cycle2310 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_cycle2312 = new BitSet(new ulong[]{0x604C40000000000UL,0x4F82002E48UL});
		public static readonly BitSet _codeBlock_in_cycle2314 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _END_in_cycle2316 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _FOR_in_cycle2318 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_assignOrExpression2347 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assignOrExpression2352 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr__in_expressionList2365 = new BitSet(new ulong[]{0x2UL,0x10000000000UL});
		public static readonly BitSet _104_in_expressionList2369 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expr__in_expressionList2371 = new BitSet(new ulong[]{0x2UL,0x10000000000UL});
		public static readonly BitSet _expr__in_expression2400 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicOr_in_expr_2423 = new BitSet(new ulong[]{0x600000000000002UL,0x4F82002640UL});
		public static readonly BitSet _logicAnd_in_logicOr2435 = new BitSet(new ulong[]{0x2UL,0x40000UL});
		public static readonly BitSet _OR_in_logicOr2439 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _logicAnd_in_logicOr2445 = new BitSet(new ulong[]{0x2UL,0x40000UL});
		public static readonly BitSet _equality_in_logicAnd2458 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _AND_in_logicAnd2462 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _equality_in_logicAnd2468 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _inequality_in_equality2481 = new BitSet(new ulong[]{0x2UL,0x180000UL});
		public static readonly BitSet _equalityOperator_in_equality2485 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _inequality_in_equality2488 = new BitSet(new ulong[]{0x2UL,0x180000UL});
		public static readonly BitSet _add_in_inequality2501 = new BitSet(new ulong[]{0x2UL,0x1E00000UL});
		public static readonly BitSet _ineqOperator_in_inequality2505 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _add_in_inequality2508 = new BitSet(new ulong[]{0x2UL,0x1E00000UL});
		public static readonly BitSet _mult_in_add2522 = new BitSet(new ulong[]{0x2UL,0x3000UL});
		public static readonly BitSet _addOperator_in_add2526 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _mult_in_add2529 = new BitSet(new ulong[]{0x2UL,0x3000UL});
		public static readonly BitSet _cast_in_mult2545 = new BitSet(new ulong[]{0x2UL,0x1C000UL});
		public static readonly BitSet _multOperator_in_mult2549 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _cast_in_mult2552 = new BitSet(new ulong[]{0x2UL,0x1C000UL});
		public static readonly BitSet _102_in_cast2564 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_cast2566 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_cast2568 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _unary_in_cast2570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unary_in_cast2589 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryOperator_in_unary2601 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _unary_in_unary2604 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _postfix_in_unary2611 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quant_in_postfix2626 = new BitSet(new ulong[]{0x2UL,0x42000000000UL});
		public static readonly BitSet _tmp_in_postfix2628 = new BitSet(new ulong[]{0x2UL,0x42000000000UL});
		public static readonly BitSet _index_in_tmp2640 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_tmp2645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberCall_in_tmp2650 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _106_in_index2661 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_index2663 = new BitSet(new ulong[]{0x0UL,0x80000000000UL});
		public static readonly BitSet _107_in_index2665 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _101_in_memberCall2688 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_memberCall2690 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressionOrEmpty2713 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _101_in_methodCall2731 = new BitSet(new ulong[]{0x0UL,0x80000000UL});
		public static readonly BitSet _ID_in_methodCall2733 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_methodCall2735 = new BitSet(new ulong[]{0x600000000000000UL,0xCF82002640UL});
		public static readonly BitSet _expressionList_in_methodCall2737 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_methodCall2739 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_createInstance2764 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2766 = new BitSet(new ulong[]{0x600000000000000UL,0xCF82002640UL});
		public static readonly BitSet _expressionList_in_createInstance2768 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2770 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TABLE_in_createInstance2789 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2791 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_createInstance2793 = new BitSet(new ulong[]{0x0UL,0x18000000000UL});
		public static readonly BitSet _104_in_createInstance2796 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_createInstance2798 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2802 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ARRAY_in_createInstance2822 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2824 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_createInstance2826 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_createInstance2828 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expression_in_createInstance2830 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2831 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_quant2856 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bool__in_quant2863 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _string__in_quant2870 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _char__in_quant2875 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_quant2882 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_quant2889 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _expr__in_quant2892 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_quant2894 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_quant2902 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SELF_in_quant2909 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_var2922 = new BitSet(new ulong[]{0x2UL});
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
		public static readonly BitSet _assign_in_synpred47_Plsql2125 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_synpred50_Plsql2140 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred55_Plsql2347 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _addOperator_in_synpred63_Plsql2526 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _mult_in_synpred63_Plsql2529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_synpred65_Plsql2564 = new BitSet(new ulong[]{0x60000FC00000000UL,0x80000000UL});
		public static readonly BitSet _type_in_synpred65_Plsql2566 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_synpred65_Plsql2568 = new BitSet(new ulong[]{0x600000000000000UL,0x4F82002640UL});
		public static readonly BitSet _unary_in_synpred65_Plsql2570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_synpred69_Plsql2645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_synpred78_Plsql2882 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_synpred80_Plsql2902 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  plsql_msil 
