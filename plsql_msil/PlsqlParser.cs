// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-19 19:12:50

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "Program", "EntryPoint", "DeclareBlock", "VarList", "VarItem", "ClassDecl", "ClassDef", "ClassItems", "PackageDecl", "PackageDef", "CommandBlock", "TypeName", "VarDef", "MethodDecl", "MethodDef", "ObjectMethodDecl", "ObjectMethodDef", "ObjectItems", "Index", "CodeBlock", "MemberCall", "MethodCall", "Expression", "ExpressionList", "StringLiteral", "Table", "Record", "CreateInstance", "Void", "INT", "CHAR", "BOOL", "DOUBLE", "STRING", "VOID", "TYPE", "IF", "THEN", "ELSE", "DO", "WHILE", "LOOP", "EXIT", "WHEN", "FOR", "CREATE", "BODY", "PROCEDURE", "FUNCTION", "IS", "AS", "TABLE", "OF", "INDEX", "BY", "RECORD", "OBJECT", "MEMBER", "STATIC", "BEGIN", "END", "PACKAGE", "DECLARE", "SELF", "NULL", "IN", "TRUE", "FALSE", "RETURN", "PLUS", "MINUS", "MULT", "DIVIDE", "MOD", "AND", "OR", "EQUAL", "NEQUAL", "MORE", "LESS", "MOREEQ", "LESSEQ", "NOT", "ASSIGN", "PLUSASSIGN", "MINUSASSIGN", "MULTASSIGN", "DIVASSIGN", "ID", "INTEGER", "REAL", "QUOTED_STRING", "QUOTED_CHAR", "'f'", "'.'", "','", "'('", "')'", "';'", "'['", "']'"
	};
	public const int EOF=-1;
	public const int T__97=97;
	public const int T__98=98;
	public const int T__99=99;
	public const int T__100=100;
	public const int T__101=101;
	public const int T__102=102;
	public const int T__103=103;
	public const int T__104=104;
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
	public const int Expression=26;
	public const int ExpressionList=27;
	public const int StringLiteral=28;
	public const int Table=29;
	public const int Record=30;
	public const int CreateInstance=31;
	public const int Void=32;
	public const int INT=33;
	public const int CHAR=34;
	public const int BOOL=35;
	public const int DOUBLE=36;
	public const int STRING=37;
	public const int VOID=38;
	public const int TYPE=39;
	public const int IF=40;
	public const int THEN=41;
	public const int ELSE=42;
	public const int DO=43;
	public const int WHILE=44;
	public const int LOOP=45;
	public const int EXIT=46;
	public const int WHEN=47;
	public const int FOR=48;
	public const int CREATE=49;
	public const int BODY=50;
	public const int PROCEDURE=51;
	public const int FUNCTION=52;
	public const int IS=53;
	public const int AS=54;
	public const int TABLE=55;
	public const int OF=56;
	public const int INDEX=57;
	public const int BY=58;
	public const int RECORD=59;
	public const int OBJECT=60;
	public const int MEMBER=61;
	public const int STATIC=62;
	public const int BEGIN=63;
	public const int END=64;
	public const int PACKAGE=65;
	public const int DECLARE=66;
	public const int SELF=67;
	public const int NULL=68;
	public const int IN=69;
	public const int TRUE=70;
	public const int FALSE=71;
	public const int RETURN=72;
	public const int PLUS=73;
	public const int MINUS=74;
	public const int MULT=75;
	public const int DIVIDE=76;
	public const int MOD=77;
	public const int AND=78;
	public const int OR=79;
	public const int EQUAL=80;
	public const int NEQUAL=81;
	public const int MORE=82;
	public const int LESS=83;
	public const int MOREEQ=84;
	public const int LESSEQ=85;
	public const int NOT=86;
	public const int ASSIGN=87;
	public const int PLUSASSIGN=88;
	public const int MINUSASSIGN=89;
	public const int MULTASSIGN=90;
	public const int DIVASSIGN=91;
	public const int ID=92;
	public const int INTEGER=93;
	public const int REAL=94;
	public const int QUOTED_STRING=95;
	public const int QUOTED_CHAR=96;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, true, false, false, false, false, 
				false, false, false, false, false, false, true, false, false, false, 
				true, false, true, , 
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
	// Plsql.g:143:1: float_ : REAL 'f' -> REAL ;
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
		RewriteRuleITokenStream stream_97=new RewriteRuleITokenStream(adaptor,"token 97");
		RewriteRuleITokenStream stream_REAL=new RewriteRuleITokenStream(adaptor,"token REAL");

		try { DebugEnterRule(GrammarFileName, "float_");
		DebugLocation(143, 1);
		try
		{
			// Plsql.g:144:2: ( REAL 'f' -> REAL )
			DebugEnterAlt(1);
			// Plsql.g:144:4: REAL 'f'
			{
			DebugLocation(144, 4);
			REAL1=(IToken)Match(input,REAL,Follow._REAL_in_float_745); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_REAL.Add(REAL1);

			DebugLocation(144, 9);
			char_literal2=(IToken)Match(input,97,Follow._97_in_float_747); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_97.Add(char_literal2);



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
			// 145:2: -> REAL
			{
				DebugLocation(145, 5);
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
		DebugLocation(146, 1);
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
	// Plsql.g:148:1: bool_ : ( TRUE -> TRUE | FALSE -> FALSE );
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
		DebugLocation(148, 1);
		try
		{
			// Plsql.g:149:2: ( TRUE -> TRUE | FALSE -> FALSE )
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
				// Plsql.g:149:4: TRUE
				{
				DebugLocation(149, 4);
				TRUE3=(IToken)Match(input,TRUE,Follow._TRUE_in_bool_766); if (state.failed) return retval; 
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
				// 149:9: -> TRUE
				{
					DebugLocation(149, 12);
					adaptor.AddChild(root_0, new BoolNode(stream_TRUE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:150:4: FALSE
				{
				DebugLocation(150, 4);
				FALSE4=(IToken)Match(input,FALSE,Follow._FALSE_in_bool_778); if (state.failed) return retval; 
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
				// 150:10: -> FALSE
				{
					DebugLocation(150, 13);
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
		DebugLocation(151, 1);
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
	// Plsql.g:161:1: string_ : QUOTED_STRING ;
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
		DebugLocation(161, 1);
		try
		{
			// Plsql.g:162:2: ( QUOTED_STRING )
			DebugEnterAlt(1);
			// Plsql.g:162:4: QUOTED_STRING
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(162, 4);
			QUOTED_STRING5=(IToken)Match(input,QUOTED_STRING,Follow._QUOTED_STRING_in_string_855); if (state.failed) return retval;
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
		DebugLocation(163, 1);
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
	// Plsql.g:165:1: char_ : QUOTED_CHAR ;
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
		DebugLocation(165, 1);
		try
		{
			// Plsql.g:166:2: ( QUOTED_CHAR )
			DebugEnterAlt(1);
			// Plsql.g:166:4: QUOTED_CHAR
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(166, 4);
			QUOTED_CHAR6=(IToken)Match(input,QUOTED_CHAR,Follow._QUOTED_CHAR_in_char_869); if (state.failed) return retval;
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
		DebugLocation(167, 1);
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
	// Plsql.g:169:1: number : ( INTEGER -> INTEGER | REAL -> REAL | float_ );
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
		DebugLocation(169, 1);
		try
		{
			// Plsql.g:170:2: ( INTEGER -> INTEGER | REAL -> REAL | float_ )
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

				if ((LA2_2==97))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||LA2_2==THEN||LA2_2==LOOP||LA2_2==END||LA2_2==SELF||(LA2_2>=TRUE && LA2_2<=FALSE)||(LA2_2>=PLUS && LA2_2<=ASSIGN)||(LA2_2>=ID && LA2_2<=QUOTED_CHAR)||(LA2_2>=98 && LA2_2<=104)))
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
				// Plsql.g:170:4: INTEGER
				{
				DebugLocation(170, 4);
				INTEGER7=(IToken)Match(input,INTEGER,Follow._INTEGER_in_number883); if (state.failed) return retval; 
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
				// 170:12: -> INTEGER
				{
					DebugLocation(170, 15);
					adaptor.AddChild(root_0, new IntegerNode(stream_INTEGER.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:171:4: REAL
				{
				DebugLocation(171, 4);
				REAL8=(IToken)Match(input,REAL,Follow._REAL_in_number895); if (state.failed) return retval; 
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
				// 171:9: -> REAL
				{
					DebugLocation(171, 12);
					adaptor.AddChild(root_0, new RealNode(stream_REAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:172:4: float_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(172, 4);
				PushFollow(Follow._float__in_number907);
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
		DebugLocation(173, 1);
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
	// Plsql.g:175:1: type : ( INT -> INT | CHAR -> CHAR | DOUBLE -> DOUBLE | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | ID -> ID );
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
		IToken CHAR11=null;
		IToken DOUBLE12=null;
		IToken BOOL13=null;
		IToken ID14=null;
		IToken char_literal15=null;
		IToken ID16=null;
		IToken ID17=null;

		object INT10_tree=null;
		object CHAR11_tree=null;
		object DOUBLE12_tree=null;
		object BOOL13_tree=null;
		object ID14_tree=null;
		object char_literal15_tree=null;
		object ID16_tree=null;
		object ID17_tree=null;
		RewriteRuleITokenStream stream_98=new RewriteRuleITokenStream(adaptor,"token 98");
		RewriteRuleITokenStream stream_CHAR=new RewriteRuleITokenStream(adaptor,"token CHAR");
		RewriteRuleITokenStream stream_DOUBLE=new RewriteRuleITokenStream(adaptor,"token DOUBLE");
		RewriteRuleITokenStream stream_INT=new RewriteRuleITokenStream(adaptor,"token INT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_BOOL=new RewriteRuleITokenStream(adaptor,"token BOOL");

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(175, 1);
		try
		{
			// Plsql.g:176:2: ( INT -> INT | CHAR -> CHAR | DOUBLE -> DOUBLE | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | ID -> ID )
			int alt3=6;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			switch (input.LA(1))
			{
			case INT:
				{
				alt3=1;
				}
				break;
			case CHAR:
				{
				alt3=2;
				}
				break;
			case DOUBLE:
				{
				alt3=3;
				}
				break;
			case BOOL:
				{
				alt3=4;
				}
				break;
			case ID:
				{
				int LA3_5 = input.LA(2);

				if ((LA3_5==98))
				{
					alt3=5;
				}
				else if ((LA3_5==EOF||LA3_5==IS||LA3_5==99||(LA3_5>=101 && LA3_5<=102)))
				{
					alt3=6;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 5, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:176:4: INT
				{
				DebugLocation(176, 4);
				INT10=(IToken)Match(input,INT,Follow._INT_in_type918); if (state.failed) return retval; 
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
				// 176:8: -> INT
				{
					DebugLocation(176, 11);
					adaptor.AddChild(root_0, new TypeNode(stream_INT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:177:4: CHAR
				{
				DebugLocation(177, 4);
				CHAR11=(IToken)Match(input,CHAR,Follow._CHAR_in_type930); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_CHAR.Add(CHAR11);



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
				// 177:9: -> CHAR
				{
					DebugLocation(177, 12);
					adaptor.AddChild(root_0, new TypeNode(stream_CHAR.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:178:4: DOUBLE
				{
				DebugLocation(178, 4);
				DOUBLE12=(IToken)Match(input,DOUBLE,Follow._DOUBLE_in_type942); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DOUBLE.Add(DOUBLE12);



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
				// 178:11: -> DOUBLE
				{
					DebugLocation(178, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_DOUBLE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:179:6: BOOL
				{
				DebugLocation(179, 6);
				BOOL13=(IToken)Match(input,BOOL,Follow._BOOL_in_type956); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BOOL.Add(BOOL13);



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
				// 179:11: -> BOOL
				{
					DebugLocation(179, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_BOOL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:180:6: ID '.' ID
				{
				DebugLocation(180, 6);
				ID14=(IToken)Match(input,ID,Follow._ID_in_type970); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID14);

				DebugLocation(180, 9);
				char_literal15=(IToken)Match(input,98,Follow._98_in_type972); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_98.Add(char_literal15);

				DebugLocation(180, 13);
				ID16=(IToken)Match(input,ID,Follow._ID_in_type974); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID16);



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
				// 181:2: -> ^( TypeName ID ID )
				{
					DebugLocation(181, 6);
					// Plsql.g:181:6: ^( TypeName ID ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(181, 8);
					root_1 = (object)adaptor.BecomeRoot(new TypeNode(TypeName), root_1);

					DebugLocation(181, 27);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(181, 30);
					adaptor.AddChild(root_1, stream_ID.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:182:6: ID
				{
				DebugLocation(182, 6);
				ID17=(IToken)Match(input,ID,Follow._ID_in_type996); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID17);



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
				// 182:9: -> ID
				{
					DebugLocation(182, 12);
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
		DebugLocation(183, 1);
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
	// Plsql.g:185:8: public program : ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) ;
	[GrammarRule("program")]
	public PlsqlParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 7);
		TraceIn("program", 7);
		PlsqlParser.program_return retval = new PlsqlParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objOrPack_return objOrPack18 = default(PlsqlParser.objOrPack_return);
		PlsqlParser.entryPoint_return entryPoint19 = default(PlsqlParser.entryPoint_return);

		RewriteRuleSubtreeStream stream_objOrPack=new RewriteRuleSubtreeStream(adaptor,"rule objOrPack");
		RewriteRuleSubtreeStream stream_entryPoint=new RewriteRuleSubtreeStream(adaptor,"rule entryPoint");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(185, 1);
		try
		{
			// Plsql.g:186:2: ( ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) )
			DebugEnterAlt(1);
			// Plsql.g:186:4: ( objOrPack )* entryPoint
			{
			DebugLocation(186, 4);
			// Plsql.g:186:4: ( objOrPack )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==CREATE))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: objOrPack
					{
					DebugLocation(186, 4);
					PushFollow(Follow._objOrPack_in_program1016);
					objOrPack18=objOrPack();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objOrPack.Add(objOrPack18.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(186, 15);
			PushFollow(Follow._entryPoint_in_program1019);
			entryPoint19=entryPoint();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_entryPoint.Add(entryPoint19.Tree);


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
			// 187:2: -> ^( Program ( objOrPack )* entryPoint )
			{
				DebugLocation(187, 5);
				// Plsql.g:187:5: ^( Program ( objOrPack )* entryPoint )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(187, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(Program, "Program"), root_1);

				DebugLocation(187, 15);
				// Plsql.g:187:15: ( objOrPack )*
				while ( stream_objOrPack.HasNext )
				{
					DebugLocation(187, 15);
					adaptor.AddChild(root_1, stream_objOrPack.NextTree());

				}
				stream_objOrPack.Reset();
				DebugLocation(187, 26);
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
		DebugLocation(188, 1);
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
	// Plsql.g:190:1: objOrPack : ( object_ | package_ );
	[GrammarRule("objOrPack")]
	private PlsqlParser.objOrPack_return objOrPack()
	{
		Enter_objOrPack();
		EnterRule("objOrPack", 8);
		TraceIn("objOrPack", 8);
		PlsqlParser.objOrPack_return retval = new PlsqlParser.objOrPack_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.object__return object_20 = default(PlsqlParser.object__return);
		PlsqlParser.package__return package_21 = default(PlsqlParser.package__return);


		try { DebugEnterRule(GrammarFileName, "objOrPack");
		DebugLocation(190, 1);
		try
		{
			// Plsql.g:191:2: ( object_ | package_ )
			int alt5=2;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if ((LA5_0==CREATE))
			{
				int LA5_1 = input.LA(2);

				if ((LA5_1==TYPE))
				{
					alt5=1;
				}
				else if ((LA5_1==PACKAGE))
				{
					alt5=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 5, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:191:4: object_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(191, 4);
				PushFollow(Follow._object__in_objOrPack1042);
				object_20=object_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_20.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:192:4: package_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(192, 4);
				PushFollow(Follow._package__in_objOrPack1048);
				package_21=package_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, package_21.Tree);

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
		DebugLocation(193, 1);
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
	// Plsql.g:195:1: isOrAs : ( IS | AS );
	[GrammarRule("isOrAs")]
	private PlsqlParser.isOrAs_return isOrAs()
	{
		Enter_isOrAs();
		EnterRule("isOrAs", 9);
		TraceIn("isOrAs", 9);
		PlsqlParser.isOrAs_return retval = new PlsqlParser.isOrAs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set22=null;

		object set22_tree=null;

		try { DebugEnterRule(GrammarFileName, "isOrAs");
		DebugLocation(195, 1);
		try
		{
			// Plsql.g:196:2: ( IS | AS )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(196, 2);
			set22=(IToken)input.LT(1);
			if ((input.LA(1)>=IS && input.LA(1)<=AS))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set22));
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
		DebugLocation(198, 1);
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
	// Plsql.g:202:1: equalityOperator : ( EQUAL -> EQUAL | NEQUAL -> NEQUAL );
	[GrammarRule("equalityOperator")]
	private PlsqlParser.equalityOperator_return equalityOperator()
	{
		Enter_equalityOperator();
		EnterRule("equalityOperator", 10);
		TraceIn("equalityOperator", 10);
		PlsqlParser.equalityOperator_return retval = new PlsqlParser.equalityOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EQUAL23=null;
		IToken NEQUAL24=null;

		object EQUAL23_tree=null;
		object NEQUAL24_tree=null;
		RewriteRuleITokenStream stream_NEQUAL=new RewriteRuleITokenStream(adaptor,"token NEQUAL");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");

		try { DebugEnterRule(GrammarFileName, "equalityOperator");
		DebugLocation(202, 1);
		try
		{
			// Plsql.g:203:2: ( EQUAL -> EQUAL | NEQUAL -> NEQUAL )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==EQUAL))
			{
				alt6=1;
			}
			else if ((LA6_0==NEQUAL))
			{
				alt6=2;
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
				// Plsql.g:203:4: EQUAL
				{
				DebugLocation(203, 4);
				EQUAL23=(IToken)Match(input,EQUAL,Follow._EQUAL_in_equalityOperator1078); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL23);



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
				// 203:10: -> EQUAL
				{
					DebugLocation(203, 13);
					adaptor.AddChild(root_0, new EqualNode(stream_EQUAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:204:4: NEQUAL
				{
				DebugLocation(204, 4);
				NEQUAL24=(IToken)Match(input,NEQUAL,Follow._NEQUAL_in_equalityOperator1090); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NEQUAL.Add(NEQUAL24);



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
				// 204:11: -> NEQUAL
				{
					DebugLocation(204, 14);
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
		DebugLocation(205, 1);
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
	// Plsql.g:207:1: ineqOperator : ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ );
	[GrammarRule("ineqOperator")]
	private PlsqlParser.ineqOperator_return ineqOperator()
	{
		Enter_ineqOperator();
		EnterRule("ineqOperator", 11);
		TraceIn("ineqOperator", 11);
		PlsqlParser.ineqOperator_return retval = new PlsqlParser.ineqOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MORE25=null;
		IToken LESS26=null;
		IToken MOREEQ27=null;
		IToken LESSEQ28=null;

		object MORE25_tree=null;
		object LESS26_tree=null;
		object MOREEQ27_tree=null;
		object LESSEQ28_tree=null;
		RewriteRuleITokenStream stream_MOREEQ=new RewriteRuleITokenStream(adaptor,"token MOREEQ");
		RewriteRuleITokenStream stream_LESSEQ=new RewriteRuleITokenStream(adaptor,"token LESSEQ");
		RewriteRuleITokenStream stream_MORE=new RewriteRuleITokenStream(adaptor,"token MORE");
		RewriteRuleITokenStream stream_LESS=new RewriteRuleITokenStream(adaptor,"token LESS");

		try { DebugEnterRule(GrammarFileName, "ineqOperator");
		DebugLocation(207, 1);
		try
		{
			// Plsql.g:208:2: ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ )
			int alt7=4;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			switch (input.LA(1))
			{
			case MORE:
				{
				alt7=1;
				}
				break;
			case LESS:
				{
				alt7=2;
				}
				break;
			case MOREEQ:
				{
				alt7=3;
				}
				break;
			case LESSEQ:
				{
				alt7=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:208:4: MORE
				{
				DebugLocation(208, 4);
				MORE25=(IToken)Match(input,MORE,Follow._MORE_in_ineqOperator1108); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MORE.Add(MORE25);



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
				// 208:9: -> MORE
				{
					DebugLocation(208, 12);
					adaptor.AddChild(root_0, new GreaterNode(stream_MORE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:209:4: LESS
				{
				DebugLocation(209, 4);
				LESS26=(IToken)Match(input,LESS,Follow._LESS_in_ineqOperator1120); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESS.Add(LESS26);



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
				// 209:9: -> LESS
				{
					DebugLocation(209, 12);
					adaptor.AddChild(root_0, new LessNode(stream_LESS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:210:4: MOREEQ
				{
				DebugLocation(210, 4);
				MOREEQ27=(IToken)Match(input,MOREEQ,Follow._MOREEQ_in_ineqOperator1132); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOREEQ.Add(MOREEQ27);



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
				// 210:11: -> MOREEQ
				{
					DebugLocation(210, 14);
					adaptor.AddChild(root_0, new GreaterOrEqualNode(stream_MOREEQ.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:211:4: LESSEQ
				{
				DebugLocation(211, 4);
				LESSEQ28=(IToken)Match(input,LESSEQ,Follow._LESSEQ_in_ineqOperator1144); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESSEQ.Add(LESSEQ28);



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
				// 211:11: -> LESSEQ
				{
					DebugLocation(211, 14);
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
		DebugLocation(212, 1);
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
	// Plsql.g:214:1: addOperator : ( PLUS -> PLUS | MINUS -> MINUS );
	[GrammarRule("addOperator")]
	private PlsqlParser.addOperator_return addOperator()
	{
		Enter_addOperator();
		EnterRule("addOperator", 12);
		TraceIn("addOperator", 12);
		PlsqlParser.addOperator_return retval = new PlsqlParser.addOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PLUS29=null;
		IToken MINUS30=null;

		object PLUS29_tree=null;
		object MINUS30_tree=null;
		RewriteRuleITokenStream stream_PLUS=new RewriteRuleITokenStream(adaptor,"token PLUS");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "addOperator");
		DebugLocation(214, 1);
		try
		{
			// Plsql.g:215:2: ( PLUS -> PLUS | MINUS -> MINUS )
			int alt8=2;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==PLUS))
			{
				alt8=1;
			}
			else if ((LA8_0==MINUS))
			{
				alt8=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:215:4: PLUS
				{
				DebugLocation(215, 4);
				PLUS29=(IToken)Match(input,PLUS,Follow._PLUS_in_addOperator1162); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_PLUS.Add(PLUS29);



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
				// 215:9: -> PLUS
				{
					DebugLocation(215, 12);
					adaptor.AddChild(root_0, new PlusNode(stream_PLUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:216:4: MINUS
				{
				DebugLocation(216, 4);
				MINUS30=(IToken)Match(input,MINUS,Follow._MINUS_in_addOperator1174); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS30);



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
				// 216:10: -> MINUS
				{
					DebugLocation(216, 13);
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
		DebugLocation(217, 1);
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
	// Plsql.g:219:1: multOperator : ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD );
	[GrammarRule("multOperator")]
	private PlsqlParser.multOperator_return multOperator()
	{
		Enter_multOperator();
		EnterRule("multOperator", 13);
		TraceIn("multOperator", 13);
		PlsqlParser.multOperator_return retval = new PlsqlParser.multOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MULT31=null;
		IToken DIVIDE32=null;
		IToken MOD33=null;

		object MULT31_tree=null;
		object DIVIDE32_tree=null;
		object MOD33_tree=null;
		RewriteRuleITokenStream stream_MULT=new RewriteRuleITokenStream(adaptor,"token MULT");
		RewriteRuleITokenStream stream_MOD=new RewriteRuleITokenStream(adaptor,"token MOD");
		RewriteRuleITokenStream stream_DIVIDE=new RewriteRuleITokenStream(adaptor,"token DIVIDE");

		try { DebugEnterRule(GrammarFileName, "multOperator");
		DebugLocation(219, 1);
		try
		{
			// Plsql.g:220:2: ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD )
			int alt9=3;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			switch (input.LA(1))
			{
			case MULT:
				{
				alt9=1;
				}
				break;
			case DIVIDE:
				{
				alt9=2;
				}
				break;
			case MOD:
				{
				alt9=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:220:4: MULT
				{
				DebugLocation(220, 4);
				MULT31=(IToken)Match(input,MULT,Follow._MULT_in_multOperator1192); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MULT.Add(MULT31);



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
				// 220:9: -> MULT
				{
					DebugLocation(220, 12);
					adaptor.AddChild(root_0, new MultNode(stream_MULT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:221:4: DIVIDE
				{
				DebugLocation(221, 4);
				DIVIDE32=(IToken)Match(input,DIVIDE,Follow._DIVIDE_in_multOperator1204); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DIVIDE.Add(DIVIDE32);



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
				// 221:11: -> DIVIDE
				{
					DebugLocation(221, 14);
					adaptor.AddChild(root_0, new DivNode(stream_DIVIDE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:222:4: MOD
				{
				DebugLocation(222, 4);
				MOD33=(IToken)Match(input,MOD,Follow._MOD_in_multOperator1216); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOD.Add(MOD33);



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
				// 222:8: -> MOD
				{
					DebugLocation(222, 11);
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
		DebugLocation(223, 1);
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
	// Plsql.g:225:1: assignOperator : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN );
	[GrammarRule("assignOperator")]
	private PlsqlParser.assignOperator_return assignOperator()
	{
		Enter_assignOperator();
		EnterRule("assignOperator", 14);
		TraceIn("assignOperator", 14);
		PlsqlParser.assignOperator_return retval = new PlsqlParser.assignOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set34=null;

		object set34_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignOperator");
		DebugLocation(225, 1);
		try
		{
			// Plsql.g:226:2: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(226, 2);
			set34=(IToken)input.LT(1);
			if ((input.LA(1)>=ASSIGN && input.LA(1)<=DIVASSIGN))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set34));
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
		DebugLocation(231, 1);
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
	// Plsql.g:233:1: unaryOperator : ( MINUS -> MINUS | NOT -> NOT );
	[GrammarRule("unaryOperator")]
	private PlsqlParser.unaryOperator_return unaryOperator()
	{
		Enter_unaryOperator();
		EnterRule("unaryOperator", 15);
		TraceIn("unaryOperator", 15);
		PlsqlParser.unaryOperator_return retval = new PlsqlParser.unaryOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS35=null;
		IToken NOT36=null;

		object MINUS35_tree=null;
		object NOT36_tree=null;
		RewriteRuleITokenStream stream_NOT=new RewriteRuleITokenStream(adaptor,"token NOT");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "unaryOperator");
		DebugLocation(233, 1);
		try
		{
			// Plsql.g:234:2: ( MINUS -> MINUS | NOT -> NOT )
			int alt10=2;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==MINUS))
			{
				alt10=1;
			}
			else if ((LA10_0==NOT))
			{
				alt10=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:234:4: MINUS
				{
				DebugLocation(234, 4);
				MINUS35=(IToken)Match(input,MINUS,Follow._MINUS_in_unaryOperator1265); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS35);



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
				// 234:10: -> MINUS
				{
					DebugLocation(234, 13);
					adaptor.AddChild(root_0, new MinusNode(stream_MINUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:235:4: NOT
				{
				DebugLocation(235, 4);
				NOT36=(IToken)Match(input,NOT,Follow._NOT_in_unaryOperator1277); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NOT.Add(NOT36);



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
				// 235:8: -> NOT
				{
					DebugLocation(235, 11);
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
		DebugLocation(236, 1);
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
	// Plsql.g:241:1: varDef : ID type -> ^( VarDef ID type ) ;
	[GrammarRule("varDef")]
	private PlsqlParser.varDef_return varDef()
	{
		Enter_varDef();
		EnterRule("varDef", 16);
		TraceIn("varDef", 16);
		PlsqlParser.varDef_return retval = new PlsqlParser.varDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID37=null;
		PlsqlParser.type_return type38 = default(PlsqlParser.type_return);

		object ID37_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varDef");
		DebugLocation(241, 1);
		try
		{
			// Plsql.g:242:2: ( ID type -> ^( VarDef ID type ) )
			DebugEnterAlt(1);
			// Plsql.g:242:4: ID type
			{
			DebugLocation(242, 4);
			ID37=(IToken)Match(input,ID,Follow._ID_in_varDef1298); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID37);

			DebugLocation(242, 7);
			PushFollow(Follow._type_in_varDef1300);
			type38=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type38.Tree);


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
			// 243:2: -> ^( VarDef ID type )
			{
				DebugLocation(243, 5);
				// Plsql.g:243:5: ^( VarDef ID type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(243, 7);
				root_1 = (object)adaptor.BecomeRoot(new VarDefNode(VarDef), root_1);

				DebugLocation(243, 26);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(243, 29);
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
		DebugLocation(244, 1);
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
	// Plsql.g:246:1: varList : ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) ;
	[GrammarRule("varList")]
	private PlsqlParser.varList_return varList()
	{
		Enter_varList();
		EnterRule("varList", 17);
		TraceIn("varList", 17);
		PlsqlParser.varList_return retval = new PlsqlParser.varList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal40=null;
		PlsqlParser.varDef_return varDef39 = default(PlsqlParser.varDef_return);
		PlsqlParser.varDef_return varDef41 = default(PlsqlParser.varDef_return);

		object char_literal40_tree=null;
		RewriteRuleITokenStream stream_99=new RewriteRuleITokenStream(adaptor,"token 99");
		RewriteRuleSubtreeStream stream_varDef=new RewriteRuleSubtreeStream(adaptor,"rule varDef");
		try { DebugEnterRule(GrammarFileName, "varList");
		DebugLocation(246, 1);
		try
		{
			// Plsql.g:247:2: ( ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) )
			DebugEnterAlt(1);
			// Plsql.g:247:4: ( varDef ( ',' varDef )* )?
			{
			DebugLocation(247, 4);
			// Plsql.g:247:4: ( varDef ( ',' varDef )* )?
			int alt12=2;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==ID))
			{
				alt12=1;
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:247:6: varDef ( ',' varDef )*
				{
				DebugLocation(247, 6);
				PushFollow(Follow._varDef_in_varList1328);
				varDef39=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varDef.Add(varDef39.Tree);
				DebugLocation(247, 13);
				// Plsql.g:247:13: ( ',' varDef )*
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==99))
					{
						alt11=1;
					}


					} finally { DebugExitDecision(11); }
					switch ( alt11 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:247:15: ',' varDef
						{
						DebugLocation(247, 15);
						char_literal40=(IToken)Match(input,99,Follow._99_in_varList1332); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_99.Add(char_literal40);

						DebugLocation(247, 19);
						PushFollow(Follow._varDef_in_varList1334);
						varDef41=varDef();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_varDef.Add(varDef41.Tree);

						}
						break;

					default:
						goto loop11;
					}
				}

				loop11:
					;

				} finally { DebugExitSubRule(11); }


				}
				break;

			}
			} finally { DebugExitSubRule(12); }



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
			// 248:2: -> ^( VarList ( varDef )* )
			{
				DebugLocation(248, 5);
				// Plsql.g:248:5: ^( VarList ( varDef )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(248, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VarList, "VarList"), root_1);

				DebugLocation(248, 15);
				// Plsql.g:248:15: ( varDef )*
				while ( stream_varDef.HasNext )
				{
					DebugLocation(248, 15);
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
		DebugLocation(249, 1);
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
	// Plsql.g:251:1: methodDecl : ( procDecl | funcDecl );
	[GrammarRule("methodDecl")]
	private PlsqlParser.methodDecl_return methodDecl()
	{
		Enter_methodDecl();
		EnterRule("methodDecl", 18);
		TraceIn("methodDecl", 18);
		PlsqlParser.methodDecl_return retval = new PlsqlParser.methodDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.procDecl_return procDecl42 = default(PlsqlParser.procDecl_return);
		PlsqlParser.funcDecl_return funcDecl43 = default(PlsqlParser.funcDecl_return);


		try { DebugEnterRule(GrammarFileName, "methodDecl");
		DebugLocation(251, 1);
		try
		{
			// Plsql.g:252:2: ( procDecl | funcDecl )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			switch (input.LA(1))
			{
			case MEMBER:
				{
				int LA13_1 = input.LA(2);

				if ((LA13_1==PROCEDURE))
				{
					alt13=1;
				}
				else if ((LA13_1==FUNCTION))
				{
					alt13=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case STATIC:
				{
				int LA13_2 = input.LA(2);

				if ((LA13_2==PROCEDURE))
				{
					alt13=1;
				}
				else if ((LA13_2==FUNCTION))
				{
					alt13=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case PROCEDURE:
				{
				alt13=1;
				}
				break;
			case FUNCTION:
				{
				alt13=2;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:252:4: procDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(252, 4);
				PushFollow(Follow._procDecl_in_methodDecl1360);
				procDecl42=procDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, procDecl42.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:253:4: funcDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(253, 4);
				PushFollow(Follow._funcDecl_in_methodDecl1365);
				funcDecl43=funcDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcDecl43.Tree);

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
		DebugLocation(254, 1);
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
	// Plsql.g:256:1: methodModifier : ( MEMBER | STATIC | -> STATIC );
	[GrammarRule("methodModifier")]
	private PlsqlParser.methodModifier_return methodModifier()
	{
		Enter_methodModifier();
		EnterRule("methodModifier", 19);
		TraceIn("methodModifier", 19);
		PlsqlParser.methodModifier_return retval = new PlsqlParser.methodModifier_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MEMBER44=null;
		IToken STATIC45=null;

		object MEMBER44_tree=null;
		object STATIC45_tree=null;

		try { DebugEnterRule(GrammarFileName, "methodModifier");
		DebugLocation(256, 1);
		try
		{
			// Plsql.g:257:2: ( MEMBER | STATIC | -> STATIC )
			int alt14=3;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			switch (input.LA(1))
			{
			case MEMBER:
				{
				alt14=1;
				}
				break;
			case STATIC:
				{
				alt14=2;
				}
				break;
			case PROCEDURE:
			case FUNCTION:
				{
				alt14=3;
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
				// Plsql.g:257:4: MEMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(257, 4);
				MEMBER44=(IToken)Match(input,MEMBER,Follow._MEMBER_in_methodModifier1376); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				MEMBER44_tree = (object)adaptor.Create(MEMBER44);
				adaptor.AddChild(root_0, MEMBER44_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:258:4: STATIC
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(258, 4);
				STATIC45=(IToken)Match(input,STATIC,Follow._STATIC_in_methodModifier1381); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				STATIC45_tree = (object)adaptor.Create(STATIC45);
				adaptor.AddChild(root_0, STATIC45_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:259:4: 
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
				// 259:4: -> STATIC
				{
					DebugLocation(259, 7);
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
		DebugLocation(260, 1);
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
	// Plsql.g:262:1: procDecl : methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) ;
	[GrammarRule("procDecl")]
	private PlsqlParser.procDecl_return procDecl()
	{
		Enter_procDecl();
		EnterRule("procDecl", 20);
		TraceIn("procDecl", 20);
		PlsqlParser.procDecl_return retval = new PlsqlParser.procDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROCEDURE47=null;
		IToken ID48=null;
		IToken char_literal49=null;
		IToken char_literal51=null;
		PlsqlParser.methodModifier_return methodModifier46 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList50 = default(PlsqlParser.varList_return);

		object PROCEDURE47_tree=null;
		object ID48_tree=null;
		object char_literal49_tree=null;
		object char_literal51_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "procDecl");
		DebugLocation(262, 1);
		try
		{
			// Plsql.g:263:2: ( methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:263:4: methodModifier PROCEDURE ID '(' varList ')'
			{
			DebugLocation(263, 4);
			PushFollow(Follow._methodModifier_in_procDecl1399);
			methodModifier46=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier46.Tree);
			DebugLocation(263, 19);
			PROCEDURE47=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procDecl1401); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROCEDURE.Add(PROCEDURE47);

			DebugLocation(263, 29);
			ID48=(IToken)Match(input,ID,Follow._ID_in_procDecl1403); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID48);

			DebugLocation(263, 32);
			char_literal49=(IToken)Match(input,100,Follow._100_in_procDecl1405); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal49);

			DebugLocation(263, 36);
			PushFollow(Follow._varList_in_procDecl1407);
			varList50=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList50.Tree);
			DebugLocation(263, 44);
			char_literal51=(IToken)Match(input,101,Follow._101_in_procDecl1409); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal51);



			{
			// AST REWRITE
			// elements: varList, methodModifier, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 264:2: -> ^( MethodDecl ID varList Void methodModifier )
			{
				DebugLocation(264, 5);
				// Plsql.g:264:5: ^( MethodDecl ID varList Void methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(264, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(264, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(264, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(264, 45);
				adaptor.AddChild(root_1, new VoidNode(Void));
				DebugLocation(264, 60);
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
		DebugLocation(265, 1);
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
	// Plsql.g:267:1: funcDecl : methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) ;
	[GrammarRule("funcDecl")]
	private PlsqlParser.funcDecl_return funcDecl()
	{
		Enter_funcDecl();
		EnterRule("funcDecl", 21);
		TraceIn("funcDecl", 21);
		PlsqlParser.funcDecl_return retval = new PlsqlParser.funcDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNCTION53=null;
		IToken ID54=null;
		IToken char_literal55=null;
		IToken char_literal57=null;
		IToken RETURN58=null;
		PlsqlParser.methodModifier_return methodModifier52 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList56 = default(PlsqlParser.varList_return);
		PlsqlParser.type_return type59 = default(PlsqlParser.type_return);

		object FUNCTION53_tree=null;
		object ID54_tree=null;
		object char_literal55_tree=null;
		object char_literal57_tree=null;
		object RETURN58_tree=null;
		RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleITokenStream stream_RETURN=new RewriteRuleITokenStream(adaptor,"token RETURN");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "funcDecl");
		DebugLocation(267, 1);
		try
		{
			// Plsql.g:268:2: ( methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:268:4: methodModifier FUNCTION ID '(' varList ')' RETURN type
			{
			DebugLocation(268, 4);
			PushFollow(Follow._methodModifier_in_funcDecl1441);
			methodModifier52=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier52.Tree);
			DebugLocation(268, 19);
			FUNCTION53=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDecl1443); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNCTION.Add(FUNCTION53);

			DebugLocation(268, 28);
			ID54=(IToken)Match(input,ID,Follow._ID_in_funcDecl1445); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID54);

			DebugLocation(268, 31);
			char_literal55=(IToken)Match(input,100,Follow._100_in_funcDecl1447); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal55);

			DebugLocation(268, 35);
			PushFollow(Follow._varList_in_funcDecl1449);
			varList56=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList56.Tree);
			DebugLocation(268, 43);
			char_literal57=(IToken)Match(input,101,Follow._101_in_funcDecl1451); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal57);

			DebugLocation(268, 47);
			RETURN58=(IToken)Match(input,RETURN,Follow._RETURN_in_funcDecl1453); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RETURN.Add(RETURN58);

			DebugLocation(268, 54);
			PushFollow(Follow._type_in_funcDecl1455);
			type59=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type59.Tree);


			{
			// AST REWRITE
			// elements: methodModifier, type, ID, varList
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 269:2: -> ^( MethodDecl ID varList type methodModifier )
			{
				DebugLocation(269, 5);
				// Plsql.g:269:5: ^( MethodDecl ID varList type methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(269, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(269, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(269, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(269, 45);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(269, 50);
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
		DebugLocation(270, 1);
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
	// Plsql.g:272:1: methodDef : methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) ;
	[GrammarRule("methodDef")]
	private PlsqlParser.methodDef_return methodDef()
	{
		Enter_methodDef();
		EnterRule("methodDef", 22);
		TraceIn("methodDef", 22);
		PlsqlParser.methodDef_return retval = new PlsqlParser.methodDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IS61=null;
		IToken BEGIN63=null;
		IToken END65=null;
		PlsqlParser.methodDecl_return methodDecl60 = default(PlsqlParser.methodDecl_return);
		PlsqlParser.declareBlock_return declareBlock62 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock64 = default(PlsqlParser.codeBlock_return);

		object IS61_tree=null;
		object BEGIN63_tree=null;
		object END65_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_methodDecl=new RewriteRuleSubtreeStream(adaptor,"rule methodDecl");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "methodDef");
		DebugLocation(272, 1);
		try
		{
			// Plsql.g:273:2: ( methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:273:4: methodDecl IS declareBlock BEGIN codeBlock END
			{
			DebugLocation(273, 4);
			PushFollow(Follow._methodDecl_in_methodDef1484);
			methodDecl60=methodDecl();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodDecl.Add(methodDecl60.Tree);
			DebugLocation(273, 15);
			IS61=(IToken)Match(input,IS,Follow._IS_in_methodDef1486); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IS.Add(IS61);

			DebugLocation(273, 18);
			PushFollow(Follow._declareBlock_in_methodDef1488);
			declareBlock62=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock62.Tree);
			DebugLocation(273, 31);
			BEGIN63=(IToken)Match(input,BEGIN,Follow._BEGIN_in_methodDef1490); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN63);

			DebugLocation(273, 37);
			PushFollow(Follow._codeBlock_in_methodDef1492);
			codeBlock64=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock64.Tree);
			DebugLocation(273, 47);
			END65=(IToken)Match(input,END,Follow._END_in_methodDef1494); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END65);



			{
			// AST REWRITE
			// elements: codeBlock, methodDecl, declareBlock
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 274:2: -> ^( MethodDef declareBlock methodDecl codeBlock )
			{
				DebugLocation(274, 5);
				// Plsql.g:274:5: ^( MethodDef declareBlock methodDecl codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(274, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(MethodDef), root_1);

				DebugLocation(274, 32);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(274, 45);
				adaptor.AddChild(root_1, stream_methodDecl.NextTree());
				DebugLocation(274, 56);
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
		DebugLocation(275, 1);
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
	// Plsql.g:277:1: typeDecl : ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) );
	[GrammarRule("typeDecl")]
	private PlsqlParser.typeDecl_return typeDecl()
	{
		Enter_typeDecl();
		EnterRule("typeDecl", 23);
		TraceIn("typeDecl", 23);
		PlsqlParser.typeDecl_return retval = new PlsqlParser.typeDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken TYPE66=null;
		IToken ID67=null;
		IToken IS68=null;
		IToken TABLE69=null;
		IToken OF70=null;
		IToken TYPE72=null;
		IToken ID73=null;
		IToken IS74=null;
		IToken RECORD75=null;
		IToken char_literal76=null;
		IToken char_literal78=null;
		PlsqlParser.type_return type71 = default(PlsqlParser.type_return);
		PlsqlParser.varList_return varList77 = default(PlsqlParser.varList_return);

		object TYPE66_tree=null;
		object ID67_tree=null;
		object IS68_tree=null;
		object TABLE69_tree=null;
		object OF70_tree=null;
		object TYPE72_tree=null;
		object ID73_tree=null;
		object IS74_tree=null;
		object RECORD75_tree=null;
		object char_literal76_tree=null;
		object char_literal78_tree=null;
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
		RewriteRuleITokenStream stream_RECORD=new RewriteRuleITokenStream(adaptor,"token RECORD");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "typeDecl");
		DebugLocation(277, 1);
		try
		{
			// Plsql.g:278:2: ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) )
			int alt15=2;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==TYPE))
			{
				int LA15_1 = input.LA(2);

				if ((LA15_1==ID))
				{
					int LA15_2 = input.LA(3);

					if ((LA15_2==IS))
					{
						int LA15_3 = input.LA(4);

						if ((LA15_3==TABLE))
						{
							alt15=1;
						}
						else if ((LA15_3==RECORD))
						{
							alt15=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 15, 3, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 15, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 15, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:278:4: TYPE ID IS TABLE OF type
				{
				DebugLocation(278, 4);
				TYPE66=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1521); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE66);

				DebugLocation(278, 9);
				ID67=(IToken)Match(input,ID,Follow._ID_in_typeDecl1523); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID67);

				DebugLocation(278, 12);
				IS68=(IToken)Match(input,IS,Follow._IS_in_typeDecl1525); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS68);

				DebugLocation(278, 15);
				TABLE69=(IToken)Match(input,TABLE,Follow._TABLE_in_typeDecl1527); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE69);

				DebugLocation(278, 21);
				OF70=(IToken)Match(input,OF,Follow._OF_in_typeDecl1529); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF70);

				DebugLocation(278, 24);
				PushFollow(Follow._type_in_typeDecl1531);
				type71=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type71.Tree);


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
				// 279:2: -> ^( Table ID type )
				{
					DebugLocation(279, 5);
					// Plsql.g:279:5: ^( Table ID type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(279, 7);
					root_1 = (object)adaptor.BecomeRoot(new TableNode(Table), root_1);

					DebugLocation(279, 24);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(279, 27);
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
				// Plsql.g:280:4: TYPE ID IS RECORD '(' varList ')'
				{
				DebugLocation(280, 4);
				TYPE72=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1550); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE72);

				DebugLocation(280, 9);
				ID73=(IToken)Match(input,ID,Follow._ID_in_typeDecl1552); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID73);

				DebugLocation(280, 12);
				IS74=(IToken)Match(input,IS,Follow._IS_in_typeDecl1554); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS74);

				DebugLocation(280, 15);
				RECORD75=(IToken)Match(input,RECORD,Follow._RECORD_in_typeDecl1556); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_RECORD.Add(RECORD75);

				DebugLocation(280, 22);
				char_literal76=(IToken)Match(input,100,Follow._100_in_typeDecl1558); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_100.Add(char_literal76);

				DebugLocation(280, 26);
				PushFollow(Follow._varList_in_typeDecl1560);
				varList77=varList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varList.Add(varList77.Tree);
				DebugLocation(280, 34);
				char_literal78=(IToken)Match(input,101,Follow._101_in_typeDecl1562); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal78);



				{
				// AST REWRITE
				// elements: ID, varList
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 281:2: -> ^( Record ID varList )
				{
					DebugLocation(281, 5);
					// Plsql.g:281:5: ^( Record ID varList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(281, 7);
					root_1 = (object)adaptor.BecomeRoot(new RecordNode(Record), root_1);

					DebugLocation(281, 26);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(281, 29);
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
		DebugLocation(282, 1);
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
	// Plsql.g:286:1: object_ : ( objectDecl | objectBody );
	[GrammarRule("object_")]
	private PlsqlParser.object__return object_()
	{
		Enter_object_();
		EnterRule("object_", 24);
		TraceIn("object_", 24);
		PlsqlParser.object__return retval = new PlsqlParser.object__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objectDecl_return objectDecl79 = default(PlsqlParser.objectDecl_return);
		PlsqlParser.objectBody_return objectBody80 = default(PlsqlParser.objectBody_return);


		try { DebugEnterRule(GrammarFileName, "object_");
		DebugLocation(286, 1);
		try
		{
			// Plsql.g:287:2: ( objectDecl | objectBody )
			int alt16=2;
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			int LA16_0 = input.LA(1);

			if ((LA16_0==CREATE))
			{
				int LA16_1 = input.LA(2);

				if ((LA16_1==TYPE))
				{
					int LA16_2 = input.LA(3);

					if ((LA16_2==ID))
					{
						alt16=1;
					}
					else if ((LA16_2==BODY))
					{
						alt16=2;
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
				// Plsql.g:287:4: objectDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(287, 4);
				PushFollow(Follow._objectDecl_in_object_1589);
				objectDecl79=objectDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectDecl79.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:288:4: objectBody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(288, 4);
				PushFollow(Follow._objectBody_in_object_1594);
				objectBody80=objectBody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectBody80.Tree);

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
		DebugLocation(289, 1);
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
	// Plsql.g:291:1: objectDecl : CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) ;
	[GrammarRule("objectDecl")]
	private PlsqlParser.objectDecl_return objectDecl()
	{
		Enter_objectDecl();
		EnterRule("objectDecl", 25);
		TraceIn("objectDecl", 25);
		PlsqlParser.objectDecl_return retval = new PlsqlParser.objectDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE81=null;
		IToken TYPE82=null;
		IToken ID83=null;
		IToken OBJECT85=null;
		IToken char_literal86=null;
		IToken char_literal88=null;
		IToken char_literal89=null;
		PlsqlParser.isOrAs_return isOrAs84 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.objectDeclItem_return objectDeclItem87 = default(PlsqlParser.objectDeclItem_return);

		object CREATE81_tree=null;
		object TYPE82_tree=null;
		object ID83_tree=null;
		object OBJECT85_tree=null;
		object char_literal86_tree=null;
		object char_literal88_tree=null;
		object char_literal89_tree=null;
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OBJECT=new RewriteRuleITokenStream(adaptor,"token OBJECT");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleSubtreeStream stream_objectDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule objectDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "objectDecl");
		DebugLocation(291, 1);
		try
		{
			// Plsql.g:292:2: ( CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:292:4: CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';'
			{
			DebugLocation(292, 4);
			CREATE81=(IToken)Match(input,CREATE,Follow._CREATE_in_objectDecl1605); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE81);

			DebugLocation(292, 11);
			TYPE82=(IToken)Match(input,TYPE,Follow._TYPE_in_objectDecl1607); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE82);

			DebugLocation(292, 16);
			ID83=(IToken)Match(input,ID,Follow._ID_in_objectDecl1609); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID83);

			DebugLocation(292, 19);
			PushFollow(Follow._isOrAs_in_objectDecl1611);
			isOrAs84=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs84.Tree);
			DebugLocation(292, 26);
			OBJECT85=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectDecl1613); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT85);

			DebugLocation(292, 33);
			char_literal86=(IToken)Match(input,100,Follow._100_in_objectDecl1615); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal86);

			DebugLocation(292, 37);
			// Plsql.g:292:37: ( objectDeclItem )+
			int cnt17=0;
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if (((LA17_0>=PROCEDURE && LA17_0<=FUNCTION)||(LA17_0>=MEMBER && LA17_0<=STATIC)||LA17_0==ID))
				{
					alt17=1;
				}


				} finally { DebugExitDecision(17); }
				switch (alt17)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: objectDeclItem
					{
					DebugLocation(292, 37);
					PushFollow(Follow._objectDeclItem_in_objectDecl1617);
					objectDeclItem87=objectDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objectDeclItem.Add(objectDeclItem87.Tree);

					}
					break;

				default:
					if (cnt17 >= 1)
						goto loop17;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee17 = new EarlyExitException( 17, input );
					DebugRecognitionException(eee17);
					throw eee17;
				}
				cnt17++;
			}
			loop17:
				;

			} finally { DebugExitSubRule(17); }

			DebugLocation(292, 53);
			char_literal88=(IToken)Match(input,101,Follow._101_in_objectDecl1620); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal88);

			DebugLocation(292, 57);
			char_literal89=(IToken)Match(input,102,Follow._102_in_objectDecl1622); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal89);



			{
			// AST REWRITE
			// elements: ID, objectDeclItem
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 293:2: -> ^( ClassDecl ID ( objectDeclItem )+ )
			{
				DebugLocation(293, 5);
				// Plsql.g:293:5: ^( ClassDecl ID ( objectDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(293, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDeclNode(ClassDecl), root_1);

				DebugLocation(293, 32);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(293, 35);
				if ( !(stream_objectDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_objectDeclItem.HasNext )
				{
					DebugLocation(293, 35);
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
		DebugLocation(294, 1);
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
	// Plsql.g:296:1: objectBody : CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) ;
	[GrammarRule("objectBody")]
	private PlsqlParser.objectBody_return objectBody()
	{
		Enter_objectBody();
		EnterRule("objectBody", 26);
		TraceIn("objectBody", 26);
		PlsqlParser.objectBody_return retval = new PlsqlParser.objectBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE90=null;
		IToken TYPE91=null;
		IToken BODY92=null;
		IToken ID93=null;
		IToken OBJECT95=null;
		IToken char_literal97=null;
		IToken END98=null;
		IToken char_literal99=null;
		PlsqlParser.isOrAs_return isOrAs94 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.methodDef_return methodDef96 = default(PlsqlParser.methodDef_return);

		object CREATE90_tree=null;
		object TYPE91_tree=null;
		object BODY92_tree=null;
		object ID93_tree=null;
		object OBJECT95_tree=null;
		object char_literal97_tree=null;
		object END98_tree=null;
		object char_literal99_tree=null;
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OBJECT=new RewriteRuleITokenStream(adaptor,"token OBJECT");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_methodDef=new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "objectBody");
		DebugLocation(296, 1);
		try
		{
			// Plsql.g:297:2: ( CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:297:4: CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';'
			{
			DebugLocation(297, 4);
			CREATE90=(IToken)Match(input,CREATE,Follow._CREATE_in_objectBody1648); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE90);

			DebugLocation(297, 11);
			TYPE91=(IToken)Match(input,TYPE,Follow._TYPE_in_objectBody1650); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE91);

			DebugLocation(297, 16);
			BODY92=(IToken)Match(input,BODY,Follow._BODY_in_objectBody1652); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY92);

			DebugLocation(297, 21);
			ID93=(IToken)Match(input,ID,Follow._ID_in_objectBody1654); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID93);

			DebugLocation(297, 24);
			PushFollow(Follow._isOrAs_in_objectBody1656);
			isOrAs94=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs94.Tree);
			DebugLocation(297, 31);
			OBJECT95=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectBody1658); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT95);

			DebugLocation(297, 38);
			// Plsql.g:297:38: ( methodDef ';' )+
			int cnt18=0;
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if (((LA18_0>=PROCEDURE && LA18_0<=FUNCTION)||(LA18_0>=MEMBER && LA18_0<=STATIC)))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch (alt18)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:297:40: methodDef ';'
					{
					DebugLocation(297, 40);
					PushFollow(Follow._methodDef_in_objectBody1662);
					methodDef96=methodDef();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_methodDef.Add(methodDef96.Tree);
					DebugLocation(297, 50);
					char_literal97=(IToken)Match(input,102,Follow._102_in_objectBody1664); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_102.Add(char_literal97);


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

			DebugLocation(297, 57);
			END98=(IToken)Match(input,END,Follow._END_in_objectBody1669); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END98);

			DebugLocation(297, 61);
			char_literal99=(IToken)Match(input,102,Follow._102_in_objectBody1671); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal99);



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
			// 298:2: -> ^( ClassDef ID ( methodDef )+ )
			{
				DebugLocation(298, 5);
				// Plsql.g:298:5: ^( ClassDef ID ( methodDef )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(298, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDefNode(ClassDef), root_1);

				DebugLocation(298, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(298, 33);
				if ( !(stream_methodDef.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_methodDef.HasNext )
				{
					DebugLocation(298, 33);
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
		DebugLocation(299, 1);
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
	// Plsql.g:301:1: objectDeclItem : ( varDef ';' | methodDecl ';' );
	[GrammarRule("objectDeclItem")]
	private PlsqlParser.objectDeclItem_return objectDeclItem()
	{
		Enter_objectDeclItem();
		EnterRule("objectDeclItem", 27);
		TraceIn("objectDeclItem", 27);
		PlsqlParser.objectDeclItem_return retval = new PlsqlParser.objectDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal101=null;
		IToken char_literal103=null;
		PlsqlParser.varDef_return varDef100 = default(PlsqlParser.varDef_return);
		PlsqlParser.methodDecl_return methodDecl102 = default(PlsqlParser.methodDecl_return);

		object char_literal101_tree=null;
		object char_literal103_tree=null;

		try { DebugEnterRule(GrammarFileName, "objectDeclItem");
		DebugLocation(301, 1);
		try
		{
			// Plsql.g:302:2: ( varDef ';' | methodDecl ';' )
			int alt19=2;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if ((LA19_0==ID))
			{
				alt19=1;
			}
			else if (((LA19_0>=PROCEDURE && LA19_0<=FUNCTION)||(LA19_0>=MEMBER && LA19_0<=STATIC)))
			{
				alt19=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:302:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(302, 4);
				PushFollow(Follow._varDef_in_objectDeclItem1697);
				varDef100=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef100.Tree);
				DebugLocation(302, 14);
				char_literal101=(IToken)Match(input,102,Follow._102_in_objectDeclItem1699); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:303:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(303, 4);
				PushFollow(Follow._methodDecl_in_objectDeclItem1705);
				methodDecl102=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl102.Tree);
				DebugLocation(303, 18);
				char_literal103=(IToken)Match(input,102,Follow._102_in_objectDeclItem1707); if (state.failed) return retval;

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
		DebugLocation(304, 1);
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
	// Plsql.g:309:1: package_ : ( packageDecl | packageDef );
	[GrammarRule("package_")]
	private PlsqlParser.package__return package_()
	{
		Enter_package_();
		EnterRule("package_", 28);
		TraceIn("package_", 28);
		PlsqlParser.package__return retval = new PlsqlParser.package__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.packageDecl_return packageDecl104 = default(PlsqlParser.packageDecl_return);
		PlsqlParser.packageDef_return packageDef105 = default(PlsqlParser.packageDef_return);


		try { DebugEnterRule(GrammarFileName, "package_");
		DebugLocation(309, 1);
		try
		{
			// Plsql.g:310:2: ( packageDecl | packageDef )
			int alt20=2;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			int LA20_0 = input.LA(1);

			if ((LA20_0==CREATE))
			{
				int LA20_1 = input.LA(2);

				if ((LA20_1==PACKAGE))
				{
					int LA20_2 = input.LA(3);

					if ((LA20_2==ID))
					{
						alt20=1;
					}
					else if ((LA20_2==BODY))
					{
						alt20=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 20, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 20, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// Plsql.g:310:4: packageDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(310, 4);
				PushFollow(Follow._packageDecl_in_package_1722);
				packageDecl104=packageDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDecl104.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:311:4: packageDef
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(311, 4);
				PushFollow(Follow._packageDef_in_package_1727);
				packageDef105=packageDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDef105.Tree);

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
		DebugLocation(312, 1);
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
	// Plsql.g:314:1: packageDecl : CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) ;
	[GrammarRule("packageDecl")]
	private PlsqlParser.packageDecl_return packageDecl()
	{
		Enter_packageDecl();
		EnterRule("packageDecl", 29);
		TraceIn("packageDecl", 29);
		PlsqlParser.packageDecl_return retval = new PlsqlParser.packageDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE106=null;
		IToken PACKAGE107=null;
		IToken ID108=null;
		IToken END111=null;
		IToken char_literal112=null;
		PlsqlParser.isOrAs_return isOrAs109 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageDeclItem_return packageDeclItem110 = default(PlsqlParser.packageDeclItem_return);

		object CREATE106_tree=null;
		object PACKAGE107_tree=null;
		object ID108_tree=null;
		object END111_tree=null;
		object char_literal112_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_packageDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule packageDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDecl");
		DebugLocation(314, 1);
		try
		{
			// Plsql.g:315:2: ( CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:315:4: CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';'
			{
			DebugLocation(315, 4);
			CREATE106=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDecl1738); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE106);

			DebugLocation(315, 11);
			PACKAGE107=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDecl1740); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE107);

			DebugLocation(315, 19);
			ID108=(IToken)Match(input,ID,Follow._ID_in_packageDecl1742); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID108);

			DebugLocation(315, 22);
			PushFollow(Follow._isOrAs_in_packageDecl1744);
			isOrAs109=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs109.Tree);
			DebugLocation(315, 29);
			// Plsql.g:315:29: ( packageDeclItem )+
			int cnt21=0;
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==TYPE||(LA21_0>=PROCEDURE && LA21_0<=FUNCTION)||(LA21_0>=MEMBER && LA21_0<=STATIC)||LA21_0==ID))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch (alt21)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: packageDeclItem
					{
					DebugLocation(315, 29);
					PushFollow(Follow._packageDeclItem_in_packageDecl1746);
					packageDeclItem110=packageDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageDeclItem.Add(packageDeclItem110.Tree);

					}
					break;

				default:
					if (cnt21 >= 1)
						goto loop21;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee21 = new EarlyExitException( 21, input );
					DebugRecognitionException(eee21);
					throw eee21;
				}
				cnt21++;
			}
			loop21:
				;

			} finally { DebugExitSubRule(21); }

			DebugLocation(315, 46);
			END111=(IToken)Match(input,END,Follow._END_in_packageDecl1749); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END111);

			DebugLocation(315, 50);
			char_literal112=(IToken)Match(input,102,Follow._102_in_packageDecl1751); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal112);



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
			// 316:2: -> ^( PackageDecl ID ( packageDeclItem )+ )
			{
				DebugLocation(316, 5);
				// Plsql.g:316:5: ^( PackageDecl ID ( packageDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(316, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDeclNode(PackageDecl), root_1);

				DebugLocation(316, 36);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(316, 39);
				if ( !(stream_packageDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageDeclItem.HasNext )
				{
					DebugLocation(316, 39);
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
		DebugLocation(317, 1);
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
	// Plsql.g:319:1: packageDef : CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) ;
	[GrammarRule("packageDef")]
	private PlsqlParser.packageDef_return packageDef()
	{
		Enter_packageDef();
		EnterRule("packageDef", 30);
		TraceIn("packageDef", 30);
		PlsqlParser.packageDef_return retval = new PlsqlParser.packageDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE113=null;
		IToken PACKAGE114=null;
		IToken BODY115=null;
		IToken ID116=null;
		IToken END119=null;
		IToken char_literal120=null;
		PlsqlParser.isOrAs_return isOrAs117 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageBodyItem_return packageBodyItem118 = default(PlsqlParser.packageBodyItem_return);

		object CREATE113_tree=null;
		object PACKAGE114_tree=null;
		object BODY115_tree=null;
		object ID116_tree=null;
		object END119_tree=null;
		object char_literal120_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_packageBodyItem=new RewriteRuleSubtreeStream(adaptor,"rule packageBodyItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDef");
		DebugLocation(319, 1);
		try
		{
			// Plsql.g:320:2: ( CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:320:4: CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';'
			{
			DebugLocation(320, 4);
			CREATE113=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDef1778); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE113);

			DebugLocation(320, 11);
			PACKAGE114=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDef1780); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE114);

			DebugLocation(320, 19);
			BODY115=(IToken)Match(input,BODY,Follow._BODY_in_packageDef1782); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY115);

			DebugLocation(320, 24);
			ID116=(IToken)Match(input,ID,Follow._ID_in_packageDef1784); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID116);

			DebugLocation(320, 27);
			PushFollow(Follow._isOrAs_in_packageDef1786);
			isOrAs117=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs117.Tree);
			DebugLocation(320, 34);
			// Plsql.g:320:34: ( packageBodyItem )+
			int cnt22=0;
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if (((LA22_0>=PROCEDURE && LA22_0<=FUNCTION)||(LA22_0>=MEMBER && LA22_0<=STATIC)))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch (alt22)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: packageBodyItem
					{
					DebugLocation(320, 34);
					PushFollow(Follow._packageBodyItem_in_packageDef1788);
					packageBodyItem118=packageBodyItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageBodyItem.Add(packageBodyItem118.Tree);

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

			DebugLocation(320, 51);
			END119=(IToken)Match(input,END,Follow._END_in_packageDef1791); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END119);

			DebugLocation(320, 55);
			char_literal120=(IToken)Match(input,102,Follow._102_in_packageDef1793); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal120);



			{
			// AST REWRITE
			// elements: packageBodyItem, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 321:2: -> ^( PackageDef ID ( packageBodyItem )+ )
			{
				DebugLocation(321, 5);
				// Plsql.g:321:5: ^( PackageDef ID ( packageBodyItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(321, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDefNode(PackageDef), root_1);

				DebugLocation(321, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(321, 37);
				if ( !(stream_packageBodyItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageBodyItem.HasNext )
				{
					DebugLocation(321, 37);
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
		DebugLocation(322, 1);
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
	// Plsql.g:324:1: packageDeclItem : ( varDef ';' | typeDecl ';' | methodDecl ';' );
	[GrammarRule("packageDeclItem")]
	private PlsqlParser.packageDeclItem_return packageDeclItem()
	{
		Enter_packageDeclItem();
		EnterRule("packageDeclItem", 31);
		TraceIn("packageDeclItem", 31);
		PlsqlParser.packageDeclItem_return retval = new PlsqlParser.packageDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal122=null;
		IToken char_literal124=null;
		IToken char_literal126=null;
		PlsqlParser.varDef_return varDef121 = default(PlsqlParser.varDef_return);
		PlsqlParser.typeDecl_return typeDecl123 = default(PlsqlParser.typeDecl_return);
		PlsqlParser.methodDecl_return methodDecl125 = default(PlsqlParser.methodDecl_return);

		object char_literal122_tree=null;
		object char_literal124_tree=null;
		object char_literal126_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageDeclItem");
		DebugLocation(324, 1);
		try
		{
			// Plsql.g:325:2: ( varDef ';' | typeDecl ';' | methodDecl ';' )
			int alt23=3;
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt23=1;
				}
				break;
			case TYPE:
				{
				alt23=2;
				}
				break;
			case PROCEDURE:
			case FUNCTION:
			case MEMBER:
			case STATIC:
				{
				alt23=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:325:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(325, 4);
				PushFollow(Follow._varDef_in_packageDeclItem1819);
				varDef121=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef121.Tree);
				DebugLocation(325, 14);
				char_literal122=(IToken)Match(input,102,Follow._102_in_packageDeclItem1821); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:326:4: typeDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(326, 4);
				PushFollow(Follow._typeDecl_in_packageDeclItem1827);
				typeDecl123=typeDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeDecl123.Tree);
				DebugLocation(326, 16);
				char_literal124=(IToken)Match(input,102,Follow._102_in_packageDeclItem1829); if (state.failed) return retval;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:327:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(327, 4);
				PushFollow(Follow._methodDecl_in_packageDeclItem1835);
				methodDecl125=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl125.Tree);
				DebugLocation(327, 18);
				char_literal126=(IToken)Match(input,102,Follow._102_in_packageDeclItem1837); if (state.failed) return retval;

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
		DebugLocation(328, 1);
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
	// Plsql.g:330:1: packageBodyItem : methodDef ';' ;
	[GrammarRule("packageBodyItem")]
	private PlsqlParser.packageBodyItem_return packageBodyItem()
	{
		Enter_packageBodyItem();
		EnterRule("packageBodyItem", 32);
		TraceIn("packageBodyItem", 32);
		PlsqlParser.packageBodyItem_return retval = new PlsqlParser.packageBodyItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal128=null;
		PlsqlParser.methodDef_return methodDef127 = default(PlsqlParser.methodDef_return);

		object char_literal128_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageBodyItem");
		DebugLocation(330, 1);
		try
		{
			// Plsql.g:331:2: ( methodDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:331:4: methodDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(331, 4);
			PushFollow(Follow._methodDef_in_packageBodyItem1849);
			methodDef127=methodDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef127.Tree);
			DebugLocation(331, 17);
			char_literal128=(IToken)Match(input,102,Follow._102_in_packageBodyItem1851); if (state.failed) return retval;

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
		DebugLocation(332, 1);
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
	// Plsql.g:337:1: entryPoint : DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) ;
	[GrammarRule("entryPoint")]
	private PlsqlParser.entryPoint_return entryPoint()
	{
		Enter_entryPoint();
		EnterRule("entryPoint", 33);
		TraceIn("entryPoint", 33);
		PlsqlParser.entryPoint_return retval = new PlsqlParser.entryPoint_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DECLARE129=null;
		IToken BEGIN131=null;
		IToken END133=null;
		IToken char_literal134=null;
		PlsqlParser.declareBlock_return declareBlock130 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock132 = default(PlsqlParser.codeBlock_return);

		object DECLARE129_tree=null;
		object BEGIN131_tree=null;
		object END133_tree=null;
		object char_literal134_tree=null;
		RewriteRuleITokenStream stream_DECLARE=new RewriteRuleITokenStream(adaptor,"token DECLARE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "entryPoint");
		DebugLocation(337, 1);
		try
		{
			// Plsql.g:338:2: ( DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:338:4: DECLARE declareBlock BEGIN codeBlock END ';'
			{
			DebugLocation(338, 4);
			DECLARE129=(IToken)Match(input,DECLARE,Follow._DECLARE_in_entryPoint1866); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DECLARE.Add(DECLARE129);

			DebugLocation(338, 12);
			PushFollow(Follow._declareBlock_in_entryPoint1868);
			declareBlock130=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock130.Tree);
			DebugLocation(338, 25);
			BEGIN131=(IToken)Match(input,BEGIN,Follow._BEGIN_in_entryPoint1870); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN131);

			DebugLocation(338, 31);
			PushFollow(Follow._codeBlock_in_entryPoint1872);
			codeBlock132=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock132.Tree);
			DebugLocation(338, 41);
			END133=(IToken)Match(input,END,Follow._END_in_entryPoint1874); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END133);

			DebugLocation(338, 45);
			char_literal134=(IToken)Match(input,102,Follow._102_in_entryPoint1876); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal134);



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
			// 339:2: -> ^( EntryPoint declareBlock codeBlock )
			{
				DebugLocation(339, 5);
				// Plsql.g:339:5: ^( EntryPoint declareBlock codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(339, 7);
				root_1 = (object)adaptor.BecomeRoot(new EntryPointNode(EntryPoint), root_1);

				DebugLocation(339, 34);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(339, 47);
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
		DebugLocation(340, 1);
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
	// Plsql.g:343:1: declareBlock : ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) ;
	[GrammarRule("declareBlock")]
	private PlsqlParser.declareBlock_return declareBlock()
	{
		Enter_declareBlock();
		EnterRule("declareBlock", 34);
		TraceIn("declareBlock", 34);
		PlsqlParser.declareBlock_return retval = new PlsqlParser.declareBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.declareItem_return declareItem135 = default(PlsqlParser.declareItem_return);

		RewriteRuleSubtreeStream stream_declareItem=new RewriteRuleSubtreeStream(adaptor,"rule declareItem");
		try { DebugEnterRule(GrammarFileName, "declareBlock");
		DebugLocation(343, 1);
		try
		{
			// Plsql.g:344:2: ( ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) )
			DebugEnterAlt(1);
			// Plsql.g:344:4: ( declareItem )*
			{
			DebugLocation(344, 4);
			// Plsql.g:344:4: ( declareItem )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==ID))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: declareItem
					{
					DebugLocation(344, 4);
					PushFollow(Follow._declareItem_in_declareBlock1902);
					declareItem135=declareItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declareItem.Add(declareItem135.Tree);

					}
					break;

				default:
					goto loop24;
				}
			}

			loop24:
				;

			} finally { DebugExitSubRule(24); }



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
			// 345:2: -> ^( DeclareBlock ( declareItem )* )
			{
				DebugLocation(345, 5);
				// Plsql.g:345:5: ^( DeclareBlock ( declareItem )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(345, 7);
				root_1 = (object)adaptor.BecomeRoot(new DeclareBlockNode(DeclareBlock), root_1);

				DebugLocation(345, 38);
				// Plsql.g:345:38: ( declareItem )*
				while ( stream_declareItem.HasNext )
				{
					DebugLocation(345, 38);
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
		DebugLocation(346, 1);
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
	// Plsql.g:348:1: declareItem : varDef ';' ;
	[GrammarRule("declareItem")]
	private PlsqlParser.declareItem_return declareItem()
	{
		Enter_declareItem();
		EnterRule("declareItem", 35);
		TraceIn("declareItem", 35);
		PlsqlParser.declareItem_return retval = new PlsqlParser.declareItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal137=null;
		PlsqlParser.varDef_return varDef136 = default(PlsqlParser.varDef_return);

		object char_literal137_tree=null;

		try { DebugEnterRule(GrammarFileName, "declareItem");
		DebugLocation(348, 1);
		try
		{
			// Plsql.g:349:2: ( varDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:349:4: varDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(349, 4);
			PushFollow(Follow._varDef_in_declareItem1927);
			varDef136=varDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef136.Tree);
			DebugLocation(349, 14);
			char_literal137=(IToken)Match(input,102,Follow._102_in_declareItem1929); if (state.failed) return retval;

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
		DebugLocation(350, 1);
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
	// Plsql.g:352:1: codeBlock : ( command ';' )* -> ^( CodeBlock ( command )* ) ;
	[GrammarRule("codeBlock")]
	private PlsqlParser.codeBlock_return codeBlock()
	{
		Enter_codeBlock();
		EnterRule("codeBlock", 36);
		TraceIn("codeBlock", 36);
		PlsqlParser.codeBlock_return retval = new PlsqlParser.codeBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal139=null;
		PlsqlParser.command_return command138 = default(PlsqlParser.command_return);

		object char_literal139_tree=null;
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_command=new RewriteRuleSubtreeStream(adaptor,"rule command");
		try { DebugEnterRule(GrammarFileName, "codeBlock");
		DebugLocation(352, 1);
		try
		{
			// Plsql.g:353:2: ( ( command ';' )* -> ^( CodeBlock ( command )* ) )
			DebugEnterAlt(1);
			// Plsql.g:353:4: ( command ';' )*
			{
			DebugLocation(353, 4);
			// Plsql.g:353:4: ( command ';' )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==IF||(LA25_0>=WHILE && LA25_0<=LOOP)||LA25_0==SELF||(LA25_0>=TRUE && LA25_0<=RETURN)||LA25_0==MINUS||LA25_0==NOT||(LA25_0>=ID && LA25_0<=QUOTED_CHAR)||LA25_0==100))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:353:6: command ';'
					{
					DebugLocation(353, 6);
					PushFollow(Follow._command_in_codeBlock1943);
					command138=command();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_command.Add(command138.Tree);
					DebugLocation(353, 14);
					char_literal139=(IToken)Match(input,102,Follow._102_in_codeBlock1945); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_102.Add(char_literal139);


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
			// 354:2: -> ^( CodeBlock ( command )* )
			{
				DebugLocation(354, 5);
				// Plsql.g:354:5: ^( CodeBlock ( command )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(354, 7);
				root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(CodeBlock), root_1);

				DebugLocation(354, 32);
				// Plsql.g:354:32: ( command )*
				while ( stream_command.HasNext )
				{
					DebugLocation(354, 32);
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
		DebugLocation(355, 1);
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
	// Plsql.g:357:1: command : ( assign | if_ | cycle | expression | RETURN expression );
	[GrammarRule("command")]
	private PlsqlParser.command_return command()
	{
		Enter_command();
		EnterRule("command", 37);
		TraceIn("command", 37);
		PlsqlParser.command_return retval = new PlsqlParser.command_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken RETURN144=null;
		PlsqlParser.assign_return assign140 = default(PlsqlParser.assign_return);
		PlsqlParser.if__return if_141 = default(PlsqlParser.if__return);
		PlsqlParser.cycle_return cycle142 = default(PlsqlParser.cycle_return);
		PlsqlParser.expression_return expression143 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression145 = default(PlsqlParser.expression_return);

		object RETURN144_tree=null;

		try { DebugEnterRule(GrammarFileName, "command");
		DebugLocation(357, 1);
		try
		{
			// Plsql.g:358:2: ( assign | if_ | cycle | expression | RETURN expression )
			int alt26=5;
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			try
			{
				alt26 = dfa26.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:358:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(358, 4);
				PushFollow(Follow._assign_in_command1971);
				assign140=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign140.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:359:4: if_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(359, 4);
				PushFollow(Follow._if__in_command1976);
				if_141=if_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_141.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:360:4: cycle
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(360, 4);
				PushFollow(Follow._cycle_in_command1981);
				cycle142=cycle();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle142.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:361:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(361, 4);
				PushFollow(Follow._expression_in_command1986);
				expression143=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression143.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:362:4: RETURN expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(362, 22);
				RETURN144=(IToken)Match(input,RETURN,Follow._RETURN_in_command1991); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				RETURN144_tree = new ReturnNode(RETURN144) ;
				root_0 = (object)adaptor.BecomeRoot(RETURN144_tree, root_0);
				}
				DebugLocation(362, 24);
				PushFollow(Follow._expression_in_command1997);
				expression145=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression145.Tree);

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
		DebugLocation(363, 1);
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
	// Plsql.g:365:1: assign : expression ASSIGN ( NULL | expression ) ;
	[GrammarRule("assign")]
	private PlsqlParser.assign_return assign()
	{
		Enter_assign();
		EnterRule("assign", 38);
		TraceIn("assign", 38);
		PlsqlParser.assign_return retval = new PlsqlParser.assign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGN147=null;
		IToken NULL148=null;
		PlsqlParser.expression_return expression146 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression149 = default(PlsqlParser.expression_return);

		object ASSIGN147_tree=null;
		object NULL148_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign");
		DebugLocation(365, 1);
		try
		{
			// Plsql.g:366:2: ( expression ASSIGN ( NULL | expression ) )
			DebugEnterAlt(1);
			// Plsql.g:366:4: expression ASSIGN ( NULL | expression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(366, 4);
			PushFollow(Follow._expression_in_assign2008);
			expression146=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression146.Tree);
			DebugLocation(366, 33);
			ASSIGN147=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign2010); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN147_tree = new AssignNode(ASSIGN147) ;
			root_0 = (object)adaptor.BecomeRoot(ASSIGN147_tree, root_0);
			}
			DebugLocation(366, 35);
			// Plsql.g:366:35: ( NULL | expression )
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==NULL))
			{
				alt27=1;
			}
			else if ((LA27_0==SELF||(LA27_0>=TRUE && LA27_0<=FALSE)||LA27_0==MINUS||LA27_0==NOT||(LA27_0>=ID && LA27_0<=QUOTED_CHAR)||LA27_0==100))
			{
				alt27=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:366:37: NULL
				{
				DebugLocation(366, 37);
				NULL148=(IToken)Match(input,NULL,Follow._NULL_in_assign2018); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NULL148_tree = new TypeNode(NULL148) ;
				adaptor.AddChild(root_0, NULL148_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:366:54: expression
				{
				DebugLocation(366, 54);
				PushFollow(Follow._expression_in_assign2025);
				expression149=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression149.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(27); }


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
		DebugLocation(367, 1);
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
	// Plsql.g:369:1: if_ : IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) ;
	[GrammarRule("if_")]
	private PlsqlParser.if__return if_()
	{
		Enter_if_();
		EnterRule("if_", 39);
		TraceIn("if_", 39);
		PlsqlParser.if__return retval = new PlsqlParser.if__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF150=null;
		IToken THEN152=null;
		IToken ELSE154=null;
		IToken END156=null;
		IToken IF157=null;
		PlsqlParser.expression_return expression151 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock153 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock155 = default(PlsqlParser.codeBlock_return);

		object IF150_tree=null;
		object THEN152_tree=null;
		object ELSE154_tree=null;
		object END156_tree=null;
		object IF157_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "if_");
		DebugLocation(369, 1);
		try
		{
			// Plsql.g:369:5: ( IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) )
			DebugEnterAlt(1);
			// Plsql.g:369:7: IF expression THEN codeBlock ( ELSE codeBlock )? END IF
			{
			DebugLocation(369, 7);
			IF150=(IToken)Match(input,IF,Follow._IF_in_if_2036); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF150);

			DebugLocation(369, 10);
			PushFollow(Follow._expression_in_if_2038);
			expression151=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression151.Tree);
			DebugLocation(369, 21);
			THEN152=(IToken)Match(input,THEN,Follow._THEN_in_if_2040); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_THEN.Add(THEN152);

			DebugLocation(369, 26);
			PushFollow(Follow._codeBlock_in_if_2042);
			codeBlock153=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock153.Tree);
			DebugLocation(369, 36);
			// Plsql.g:369:36: ( ELSE codeBlock )?
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==ELSE))
			{
				alt28=1;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:369:37: ELSE codeBlock
				{
				DebugLocation(369, 37);
				ELSE154=(IToken)Match(input,ELSE,Follow._ELSE_in_if_2045); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE154);

				DebugLocation(369, 42);
				PushFollow(Follow._codeBlock_in_if_2047);
				codeBlock155=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock155.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(369, 54);
			END156=(IToken)Match(input,END,Follow._END_in_if_2051); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END156);

			DebugLocation(369, 58);
			IF157=(IToken)Match(input,IF,Follow._IF_in_if_2053); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF157);



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
			// 370:2: -> ^( IF expression codeBlock ( codeBlock )? )
			{
				DebugLocation(370, 5);
				// Plsql.g:370:5: ^( IF expression codeBlock ( codeBlock )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(370, 7);
				root_1 = (object)adaptor.BecomeRoot(new IfNode(stream_IF.NextToken()), root_1);

				DebugLocation(370, 18);
				adaptor.AddChild(root_1, stream_expression.NextTree());
				DebugLocation(370, 29);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());
				DebugLocation(370, 39);
				// Plsql.g:370:39: ( codeBlock )?
				if ( stream_codeBlock.HasNext )
				{
					DebugLocation(370, 39);
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
		DebugLocation(371, 1);
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
	// Plsql.g:373:1: cycle : ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) );
	[GrammarRule("cycle")]
	private PlsqlParser.cycle_return cycle()
	{
		Enter_cycle();
		EnterRule("cycle", 40);
		TraceIn("cycle", 40);
		PlsqlParser.cycle_return retval = new PlsqlParser.cycle_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE158=null;
		IToken LOOP160=null;
		IToken END162=null;
		IToken LOOP163=null;
		IToken LOOP164=null;
		IToken EXIT166=null;
		IToken WHEN167=null;
		IToken END169=null;
		IToken LOOP170=null;
		PlsqlParser.expression_return expression159 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock161 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock165 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.expression_return expression168 = default(PlsqlParser.expression_return);

		object WHILE158_tree=null;
		object LOOP160_tree=null;
		object END162_tree=null;
		object LOOP163_tree=null;
		object LOOP164_tree=null;
		object EXIT166_tree=null;
		object WHEN167_tree=null;
		object END169_tree=null;
		object LOOP170_tree=null;
		RewriteRuleITokenStream stream_EXIT=new RewriteRuleITokenStream(adaptor,"token EXIT");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_WHEN=new RewriteRuleITokenStream(adaptor,"token WHEN");
		RewriteRuleITokenStream stream_LOOP=new RewriteRuleITokenStream(adaptor,"token LOOP");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "cycle");
		DebugLocation(373, 1);
		try
		{
			// Plsql.g:374:2: ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) )
			int alt29=2;
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==WHILE))
			{
				alt29=1;
			}
			else if ((LA29_0==LOOP))
			{
				alt29=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:374:4: WHILE expression LOOP codeBlock END LOOP
				{
				DebugLocation(374, 4);
				WHILE158=(IToken)Match(input,WHILE,Follow._WHILE_in_cycle2084); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE158);

				DebugLocation(374, 10);
				PushFollow(Follow._expression_in_cycle2086);
				expression159=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression159.Tree);
				DebugLocation(374, 21);
				LOOP160=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2088); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP160);

				DebugLocation(374, 26);
				PushFollow(Follow._codeBlock_in_cycle2090);
				codeBlock161=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock161.Tree);
				DebugLocation(374, 36);
				END162=(IToken)Match(input,END,Follow._END_in_cycle2092); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END162);

				DebugLocation(374, 40);
				LOOP163=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2094); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP163);



				{
				// AST REWRITE
				// elements: codeBlock, WHILE, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 375:2: -> ^( WHILE expression codeBlock )
				{
					DebugLocation(375, 5);
					// Plsql.g:375:5: ^( WHILE expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(375, 7);
					root_1 = (object)adaptor.BecomeRoot(new WhileNode(stream_WHILE.NextToken()), root_1);

					DebugLocation(375, 24);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(375, 35);
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
				// Plsql.g:376:4: LOOP codeBlock EXIT WHEN expression END LOOP
				{
				DebugLocation(376, 4);
				LOOP164=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2113); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP164);

				DebugLocation(376, 9);
				PushFollow(Follow._codeBlock_in_cycle2115);
				codeBlock165=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock165.Tree);
				DebugLocation(376, 19);
				EXIT166=(IToken)Match(input,EXIT,Follow._EXIT_in_cycle2117); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EXIT.Add(EXIT166);

				DebugLocation(376, 24);
				WHEN167=(IToken)Match(input,WHEN,Follow._WHEN_in_cycle2119); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHEN.Add(WHEN167);

				DebugLocation(376, 29);
				PushFollow(Follow._expression_in_cycle2121);
				expression168=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression168.Tree);
				DebugLocation(376, 40);
				END169=(IToken)Match(input,END,Follow._END_in_cycle2123); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END169);

				DebugLocation(376, 44);
				LOOP170=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2125); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP170);



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
				// 377:2: -> ^( DO expression codeBlock )
				{
					DebugLocation(377, 5);
					// Plsql.g:377:5: ^( DO expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(377, 7);
					root_1 = (object)adaptor.BecomeRoot(new DoWhileNode(DO), root_1);

					DebugLocation(377, 23);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(377, 34);
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
		DebugLocation(378, 1);
		} finally { DebugExitRule(GrammarFileName, "cycle"); }
		return retval;

	}
	// $ANTLR end "cycle"

	public class expressionList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressionList();
	partial void Leave_expressionList();

	// $ANTLR start "expressionList"
	// Plsql.g:381:1: expressionList : ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) ;
	[GrammarRule("expressionList")]
	private PlsqlParser.expressionList_return expressionList()
	{
		Enter_expressionList();
		EnterRule("expressionList", 41);
		TraceIn("expressionList", 41);
		PlsqlParser.expressionList_return retval = new PlsqlParser.expressionList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal172=null;
		PlsqlParser.expr__return expr_171 = default(PlsqlParser.expr__return);
		PlsqlParser.expr__return expr_173 = default(PlsqlParser.expr__return);

		object char_literal172_tree=null;
		RewriteRuleITokenStream stream_99=new RewriteRuleITokenStream(adaptor,"token 99");
		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(381, 1);
		try
		{
			// Plsql.g:382:2: ( ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) )
			DebugEnterAlt(1);
			// Plsql.g:382:4: ( expr_ ( ',' expr_ )* )?
			{
			DebugLocation(382, 4);
			// Plsql.g:382:4: ( expr_ ( ',' expr_ )* )?
			int alt31=2;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if ((LA31_0==SELF||(LA31_0>=TRUE && LA31_0<=FALSE)||LA31_0==MINUS||LA31_0==NOT||(LA31_0>=ID && LA31_0<=QUOTED_CHAR)||LA31_0==100))
			{
				alt31=1;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:382:6: expr_ ( ',' expr_ )*
				{
				DebugLocation(382, 6);
				PushFollow(Follow._expr__in_expressionList2153);
				expr_171=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_.Add(expr_171.Tree);
				DebugLocation(382, 12);
				// Plsql.g:382:12: ( ',' expr_ )*
				try { DebugEnterSubRule(30);
				while (true)
				{
					int alt30=2;
					try { DebugEnterDecision(30, decisionCanBacktrack[30]);
					int LA30_0 = input.LA(1);

					if ((LA30_0==99))
					{
						alt30=1;
					}


					} finally { DebugExitDecision(30); }
					switch ( alt30 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:382:14: ',' expr_
						{
						DebugLocation(382, 14);
						char_literal172=(IToken)Match(input,99,Follow._99_in_expressionList2157); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_99.Add(char_literal172);

						DebugLocation(382, 18);
						PushFollow(Follow._expr__in_expressionList2159);
						expr_173=expr_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_expr_.Add(expr_173.Tree);

						}
						break;

					default:
						goto loop30;
					}
				}

				loop30:
					;

				} finally { DebugExitSubRule(30); }


				}
				break;

			}
			} finally { DebugExitSubRule(31); }



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
			// 383:2: -> ^( ExpressionList ( expr_ )* )
			{
				DebugLocation(383, 5);
				// Plsql.g:383:5: ^( ExpressionList ( expr_ )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(383, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ExpressionList, "ExpressionList"), root_1);

				DebugLocation(383, 22);
				// Plsql.g:383:22: ( expr_ )*
				while ( stream_expr_.HasNext )
				{
					DebugLocation(383, 22);
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
			TraceOut("expressionList", 41);
			LeaveRule("expressionList", 41);
			Leave_expressionList();
		}
		DebugLocation(384, 1);
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
	// Plsql.g:389:1: expression : expr_ -> ^( Expression expr_ ) ;
	[GrammarRule("expression")]
	private PlsqlParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 42);
		TraceIn("expression", 42);
		PlsqlParser.expression_return retval = new PlsqlParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expr__return expr_174 = default(PlsqlParser.expr__return);

		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(389, 1);
		try
		{
			// Plsql.g:390:2: ( expr_ -> ^( Expression expr_ ) )
			DebugEnterAlt(1);
			// Plsql.g:390:4: expr_
			{
			DebugLocation(390, 4);
			PushFollow(Follow._expr__in_expression2188);
			expr_174=expr_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr_.Add(expr_174.Tree);


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
			// 391:2: -> ^( Expression expr_ )
			{
				DebugLocation(391, 5);
				// Plsql.g:391:5: ^( Expression expr_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(391, 7);
				root_1 = (object)adaptor.BecomeRoot(new ExpressionNode(Expression), root_1);

				DebugLocation(391, 34);
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
			TraceOut("expression", 42);
			LeaveRule("expression", 42);
			Leave_expression();
		}
		DebugLocation(392, 1);
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
	// Plsql.g:394:1: expr_ : ( logicOr )+ ;
	[GrammarRule("expr_")]
	private PlsqlParser.expr__return expr_()
	{
		Enter_expr_();
		EnterRule("expr_", 43);
		TraceIn("expr_", 43);
		PlsqlParser.expr__return retval = new PlsqlParser.expr__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.logicOr_return logicOr175 = default(PlsqlParser.logicOr_return);


		try { DebugEnterRule(GrammarFileName, "expr_");
		DebugLocation(394, 1);
		try
		{
			// Plsql.g:395:2: ( ( logicOr )+ )
			DebugEnterAlt(1);
			// Plsql.g:395:4: ( logicOr )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(395, 4);
			// Plsql.g:395:4: ( logicOr )+
			int cnt32=0;
			try { DebugEnterSubRule(32);
			while (true)
			{
				int alt32=2;
				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
				int LA32_0 = input.LA(1);

				if ((LA32_0==SELF||(LA32_0>=TRUE && LA32_0<=FALSE)||LA32_0==MINUS||LA32_0==NOT||(LA32_0>=ID && LA32_0<=QUOTED_CHAR)||LA32_0==100))
				{
					alt32=1;
				}


				} finally { DebugExitDecision(32); }
				switch (alt32)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: logicOr
					{
					DebugLocation(395, 4);
					PushFollow(Follow._logicOr_in_expr_2211);
					logicOr175=logicOr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicOr175.Tree);

					}
					break;

				default:
					if (cnt32 >= 1)
						goto loop32;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee32 = new EarlyExitException( 32, input );
					DebugRecognitionException(eee32);
					throw eee32;
				}
				cnt32++;
			}
			loop32:
				;

			} finally { DebugExitSubRule(32); }


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
			TraceOut("expr_", 43);
			LeaveRule("expr_", 43);
			Leave_expr_();
		}
		DebugLocation(396, 1);
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
	// Plsql.g:398:1: logicOr : logicAnd ( OR logicAnd )* ;
	[GrammarRule("logicOr")]
	private PlsqlParser.logicOr_return logicOr()
	{
		Enter_logicOr();
		EnterRule("logicOr", 44);
		TraceIn("logicOr", 44);
		PlsqlParser.logicOr_return retval = new PlsqlParser.logicOr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR177=null;
		PlsqlParser.logicAnd_return logicAnd176 = default(PlsqlParser.logicAnd_return);
		PlsqlParser.logicAnd_return logicAnd178 = default(PlsqlParser.logicAnd_return);

		object OR177_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicOr");
		DebugLocation(398, 1);
		try
		{
			// Plsql.g:399:2: ( logicAnd ( OR logicAnd )* )
			DebugEnterAlt(1);
			// Plsql.g:399:4: logicAnd ( OR logicAnd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(399, 4);
			PushFollow(Follow._logicAnd_in_logicOr2223);
			logicAnd176=logicAnd();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd176.Tree);
			DebugLocation(399, 13);
			// Plsql.g:399:13: ( OR logicAnd )*
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==OR))
				{
					alt33=1;
				}


				} finally { DebugExitDecision(33); }
				switch ( alt33 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:399:15: OR logicAnd
					{
					DebugLocation(399, 25);
					OR177=(IToken)Match(input,OR,Follow._OR_in_logicOr2227); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR177_tree = new OrNode(OR177) ;
					root_0 = (object)adaptor.BecomeRoot(OR177_tree, root_0);
					}
					DebugLocation(399, 27);
					PushFollow(Follow._logicAnd_in_logicOr2233);
					logicAnd178=logicAnd();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd178.Tree);

					}
					break;

				default:
					goto loop33;
				}
			}

			loop33:
				;

			} finally { DebugExitSubRule(33); }


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
			TraceOut("logicOr", 44);
			LeaveRule("logicOr", 44);
			Leave_logicOr();
		}
		DebugLocation(400, 1);
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
	// Plsql.g:402:1: logicAnd : equality ( AND equality )* ;
	[GrammarRule("logicAnd")]
	private PlsqlParser.logicAnd_return logicAnd()
	{
		Enter_logicAnd();
		EnterRule("logicAnd", 45);
		TraceIn("logicAnd", 45);
		PlsqlParser.logicAnd_return retval = new PlsqlParser.logicAnd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND180=null;
		PlsqlParser.equality_return equality179 = default(PlsqlParser.equality_return);
		PlsqlParser.equality_return equality181 = default(PlsqlParser.equality_return);

		object AND180_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicAnd");
		DebugLocation(402, 1);
		try
		{
			// Plsql.g:403:2: ( equality ( AND equality )* )
			DebugEnterAlt(1);
			// Plsql.g:403:4: equality ( AND equality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(403, 4);
			PushFollow(Follow._equality_in_logicAnd2246);
			equality179=equality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality179.Tree);
			DebugLocation(403, 13);
			// Plsql.g:403:13: ( AND equality )*
			try { DebugEnterSubRule(34);
			while (true)
			{
				int alt34=2;
				try { DebugEnterDecision(34, decisionCanBacktrack[34]);
				int LA34_0 = input.LA(1);

				if ((LA34_0==AND))
				{
					alt34=1;
				}


				} finally { DebugExitDecision(34); }
				switch ( alt34 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:403:15: AND equality
					{
					DebugLocation(403, 27);
					AND180=(IToken)Match(input,AND,Follow._AND_in_logicAnd2250); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND180_tree = new AndNode(AND180) ;
					root_0 = (object)adaptor.BecomeRoot(AND180_tree, root_0);
					}
					DebugLocation(403, 29);
					PushFollow(Follow._equality_in_logicAnd2256);
					equality181=equality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality181.Tree);

					}
					break;

				default:
					goto loop34;
				}
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
			TraceOut("logicAnd", 45);
			LeaveRule("logicAnd", 45);
			Leave_logicAnd();
		}
		DebugLocation(404, 1);
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
	// Plsql.g:406:1: equality : inequality ( equalityOperator inequality )* ;
	[GrammarRule("equality")]
	private PlsqlParser.equality_return equality()
	{
		Enter_equality();
		EnterRule("equality", 46);
		TraceIn("equality", 46);
		PlsqlParser.equality_return retval = new PlsqlParser.equality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.inequality_return inequality182 = default(PlsqlParser.inequality_return);
		PlsqlParser.equalityOperator_return equalityOperator183 = default(PlsqlParser.equalityOperator_return);
		PlsqlParser.inequality_return inequality184 = default(PlsqlParser.inequality_return);


		try { DebugEnterRule(GrammarFileName, "equality");
		DebugLocation(406, 1);
		try
		{
			// Plsql.g:407:2: ( inequality ( equalityOperator inequality )* )
			DebugEnterAlt(1);
			// Plsql.g:407:4: inequality ( equalityOperator inequality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(407, 4);
			PushFollow(Follow._inequality_in_equality2269);
			inequality182=inequality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality182.Tree);
			DebugLocation(407, 15);
			// Plsql.g:407:15: ( equalityOperator inequality )*
			try { DebugEnterSubRule(35);
			while (true)
			{
				int alt35=2;
				try { DebugEnterDecision(35, decisionCanBacktrack[35]);
				int LA35_0 = input.LA(1);

				if (((LA35_0>=EQUAL && LA35_0<=NEQUAL)))
				{
					alt35=1;
				}


				} finally { DebugExitDecision(35); }
				switch ( alt35 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:407:17: equalityOperator inequality
					{
					DebugLocation(407, 33);
					PushFollow(Follow._equalityOperator_in_equality2273);
					equalityOperator183=equalityOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(equalityOperator183.Tree, root_0);
					DebugLocation(407, 35);
					PushFollow(Follow._inequality_in_equality2276);
					inequality184=inequality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality184.Tree);

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
			TraceOut("equality", 46);
			LeaveRule("equality", 46);
			Leave_equality();
		}
		DebugLocation(408, 1);
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
	// Plsql.g:410:1: inequality : add ( ineqOperator add )* ;
	[GrammarRule("inequality")]
	private PlsqlParser.inequality_return inequality()
	{
		Enter_inequality();
		EnterRule("inequality", 47);
		TraceIn("inequality", 47);
		PlsqlParser.inequality_return retval = new PlsqlParser.inequality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.add_return add185 = default(PlsqlParser.add_return);
		PlsqlParser.ineqOperator_return ineqOperator186 = default(PlsqlParser.ineqOperator_return);
		PlsqlParser.add_return add187 = default(PlsqlParser.add_return);


		try { DebugEnterRule(GrammarFileName, "inequality");
		DebugLocation(410, 1);
		try
		{
			// Plsql.g:411:2: ( add ( ineqOperator add )* )
			DebugEnterAlt(1);
			// Plsql.g:411:4: add ( ineqOperator add )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(411, 4);
			PushFollow(Follow._add_in_inequality2289);
			add185=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add185.Tree);
			DebugLocation(411, 8);
			// Plsql.g:411:8: ( ineqOperator add )*
			try { DebugEnterSubRule(36);
			while (true)
			{
				int alt36=2;
				try { DebugEnterDecision(36, decisionCanBacktrack[36]);
				int LA36_0 = input.LA(1);

				if (((LA36_0>=MORE && LA36_0<=LESSEQ)))
				{
					alt36=1;
				}


				} finally { DebugExitDecision(36); }
				switch ( alt36 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:411:10: ineqOperator add
					{
					DebugLocation(411, 22);
					PushFollow(Follow._ineqOperator_in_inequality2293);
					ineqOperator186=ineqOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(ineqOperator186.Tree, root_0);
					DebugLocation(411, 24);
					PushFollow(Follow._add_in_inequality2296);
					add187=add();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add187.Tree);

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
			TraceOut("inequality", 47);
			LeaveRule("inequality", 47);
			Leave_inequality();
		}
		DebugLocation(412, 1);
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
	// Plsql.g:414:1: add : mult ( addOperator mult )* ;
	[GrammarRule("add")]
	private PlsqlParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 48);
		TraceIn("add", 48);
		PlsqlParser.add_return retval = new PlsqlParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.mult_return mult188 = default(PlsqlParser.mult_return);
		PlsqlParser.addOperator_return addOperator189 = default(PlsqlParser.addOperator_return);
		PlsqlParser.mult_return mult190 = default(PlsqlParser.mult_return);


		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(414, 4);
		try
		{
			// Plsql.g:414:5: ( mult ( addOperator mult )* )
			DebugEnterAlt(1);
			// Plsql.g:414:9: mult ( addOperator mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(414, 9);
			PushFollow(Follow._mult_in_add2310);
			mult188=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult188.Tree);
			DebugLocation(414, 14);
			// Plsql.g:414:14: ( addOperator mult )*
			try { DebugEnterSubRule(37);
			while (true)
			{
				int alt37=2;
				try { DebugEnterDecision(37, decisionCanBacktrack[37]);
				try
				{
					alt37 = dfa37.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(37); }
				switch ( alt37 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:414:16: addOperator mult
					{
					DebugLocation(414, 27);
					PushFollow(Follow._addOperator_in_add2314);
					addOperator189=addOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperator189.Tree, root_0);
					DebugLocation(414, 29);
					PushFollow(Follow._mult_in_add2317);
					mult190=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult190.Tree);

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
			TraceOut("add", 48);
			LeaveRule("add", 48);
			Leave_add();
		}
		DebugLocation(415, 4);
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
	// Plsql.g:417:1: mult : unary ( multOperator unary )* ;
	[GrammarRule("mult")]
	private PlsqlParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 49);
		TraceIn("mult", 49);
		PlsqlParser.mult_return retval = new PlsqlParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.unary_return unary191 = default(PlsqlParser.unary_return);
		PlsqlParser.multOperator_return multOperator192 = default(PlsqlParser.multOperator_return);
		PlsqlParser.unary_return unary193 = default(PlsqlParser.unary_return);


		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(417, 1);
		try
		{
			// Plsql.g:417:5: ( unary ( multOperator unary )* )
			DebugEnterAlt(1);
			// Plsql.g:417:9: unary ( multOperator unary )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(417, 9);
			PushFollow(Follow._unary_in_mult2333);
			unary191=unary();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary191.Tree);
			DebugLocation(417, 15);
			// Plsql.g:417:15: ( multOperator unary )*
			try { DebugEnterSubRule(38);
			while (true)
			{
				int alt38=2;
				try { DebugEnterDecision(38, decisionCanBacktrack[38]);
				int LA38_0 = input.LA(1);

				if (((LA38_0>=MULT && LA38_0<=MOD)))
				{
					alt38=1;
				}


				} finally { DebugExitDecision(38); }
				switch ( alt38 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:417:17: multOperator unary
					{
					DebugLocation(417, 29);
					PushFollow(Follow._multOperator_in_mult2337);
					multOperator192=multOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperator192.Tree, root_0);
					DebugLocation(417, 31);
					PushFollow(Follow._unary_in_mult2340);
					unary193=unary();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary193.Tree);

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
			TraceOut("mult", 49);
			LeaveRule("mult", 49);
			Leave_mult();
		}
		DebugLocation(418, 1);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class unary_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_unary();
	partial void Leave_unary();

	// $ANTLR start "unary"
	// Plsql.g:420:1: unary : ( ( unaryOperator unary ) | postfix );
	[GrammarRule("unary")]
	private PlsqlParser.unary_return unary()
	{
		Enter_unary();
		EnterRule("unary", 50);
		TraceIn("unary", 50);
		PlsqlParser.unary_return retval = new PlsqlParser.unary_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.unaryOperator_return unaryOperator194 = default(PlsqlParser.unaryOperator_return);
		PlsqlParser.unary_return unary195 = default(PlsqlParser.unary_return);
		PlsqlParser.postfix_return postfix196 = default(PlsqlParser.postfix_return);


		try { DebugEnterRule(GrammarFileName, "unary");
		DebugLocation(420, 1);
		try
		{
			// Plsql.g:421:2: ( ( unaryOperator unary ) | postfix )
			int alt39=2;
			try { DebugEnterDecision(39, decisionCanBacktrack[39]);
			int LA39_0 = input.LA(1);

			if ((LA39_0==MINUS||LA39_0==NOT))
			{
				alt39=1;
			}
			else if ((LA39_0==SELF||(LA39_0>=TRUE && LA39_0<=FALSE)||(LA39_0>=ID && LA39_0<=QUOTED_CHAR)||LA39_0==100))
			{
				alt39=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 39, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(39); }
			switch (alt39)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:421:4: ( unaryOperator unary )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(421, 4);
				// Plsql.g:421:4: ( unaryOperator unary )
				DebugEnterAlt(1);
				// Plsql.g:421:5: unaryOperator unary
				{
				DebugLocation(421, 18);
				PushFollow(Follow._unaryOperator_in_unary2354);
				unaryOperator194=unaryOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(unaryOperator194.Tree, root_0);
				DebugLocation(421, 20);
				PushFollow(Follow._unary_in_unary2357);
				unary195=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary195.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:422:4: postfix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(422, 4);
				PushFollow(Follow._postfix_in_unary2364);
				postfix196=postfix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfix196.Tree);

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
			TraceOut("unary", 50);
			LeaveRule("unary", 50);
			Leave_unary();
		}
		DebugLocation(423, 1);
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
	// Plsql.g:425:1: postfix : quant ( tmp )* ;
	[GrammarRule("postfix")]
	private PlsqlParser.postfix_return postfix()
	{
		Enter_postfix();
		EnterRule("postfix", 51);
		TraceIn("postfix", 51);
		PlsqlParser.postfix_return retval = new PlsqlParser.postfix_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.quant_return quant197 = default(PlsqlParser.quant_return);
		PlsqlParser.tmp_return tmp198 = default(PlsqlParser.tmp_return);


		try { DebugEnterRule(GrammarFileName, "postfix");
		DebugLocation(425, 1);
		try
		{
			// Plsql.g:426:2: ( quant ( tmp )* )
			DebugEnterAlt(1);
			// Plsql.g:426:4: quant ( tmp )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(426, 4);
			PushFollow(Follow._quant_in_postfix2375);
			quant197=quant();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quant197.Tree);
			DebugLocation(426, 13);
			// Plsql.g:426:13: ( tmp )*
			try { DebugEnterSubRule(40);
			while (true)
			{
				int alt40=2;
				try { DebugEnterDecision(40, decisionCanBacktrack[40]);
				int LA40_0 = input.LA(1);

				if ((LA40_0==98||LA40_0==103))
				{
					alt40=1;
				}


				} finally { DebugExitDecision(40); }
				switch ( alt40 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: tmp
					{
					DebugLocation(426, 13);
					PushFollow(Follow._tmp_in_postfix2377);
					tmp198=tmp();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(tmp198.Tree, root_0);

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
			TraceOut("postfix", 51);
			LeaveRule("postfix", 51);
			Leave_postfix();
		}
		DebugLocation(427, 1);
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
	// Plsql.g:429:1: tmp : ( index | methodCall | memberCall );
	[GrammarRule("tmp")]
	private PlsqlParser.tmp_return tmp()
	{
		Enter_tmp();
		EnterRule("tmp", 52);
		TraceIn("tmp", 52);
		PlsqlParser.tmp_return retval = new PlsqlParser.tmp_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.index_return index199 = default(PlsqlParser.index_return);
		PlsqlParser.methodCall_return methodCall200 = default(PlsqlParser.methodCall_return);
		PlsqlParser.memberCall_return memberCall201 = default(PlsqlParser.memberCall_return);


		try { DebugEnterRule(GrammarFileName, "tmp");
		DebugLocation(429, 1);
		try
		{
			// Plsql.g:429:5: ( index | methodCall | memberCall )
			int alt41=3;
			try { DebugEnterDecision(41, decisionCanBacktrack[41]);
			int LA41_0 = input.LA(1);

			if ((LA41_0==103))
			{
				alt41=1;
			}
			else if ((LA41_0==98))
			{
				int LA41_2 = input.LA(2);

				if ((EvaluatePredicate(synpred60_Plsql_fragment)))
				{
					alt41=2;
				}
				else if ((true))
				{
					alt41=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 41, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 41, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(41); }
			switch (alt41)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:429:7: index
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(429, 7);
				PushFollow(Follow._index_in_tmp2389);
				index199=index();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, index199.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:430:4: methodCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(430, 4);
				PushFollow(Follow._methodCall_in_tmp2394);
				methodCall200=methodCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall200.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:431:4: memberCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(431, 4);
				PushFollow(Follow._memberCall_in_tmp2399);
				memberCall201=memberCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberCall201.Tree);

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
			TraceOut("tmp", 52);
			LeaveRule("tmp", 52);
			Leave_tmp();
		}
		DebugLocation(432, 1);
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
	// Plsql.g:434:1: index : '[' expression ']' -> ^( Index expression ) ;
	[GrammarRule("index")]
	private PlsqlParser.index_return index()
	{
		Enter_index();
		EnterRule("index", 53);
		TraceIn("index", 53);
		PlsqlParser.index_return retval = new PlsqlParser.index_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal202=null;
		IToken char_literal204=null;
		PlsqlParser.expression_return expression203 = default(PlsqlParser.expression_return);

		object char_literal202_tree=null;
		object char_literal204_tree=null;
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "index");
		DebugLocation(434, 1);
		try
		{
			// Plsql.g:435:2: ( '[' expression ']' -> ^( Index expression ) )
			DebugEnterAlt(1);
			// Plsql.g:435:4: '[' expression ']'
			{
			DebugLocation(435, 4);
			char_literal202=(IToken)Match(input,103,Follow._103_in_index2410); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal202);

			DebugLocation(435, 8);
			PushFollow(Follow._expression_in_index2412);
			expression203=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression203.Tree);
			DebugLocation(435, 19);
			char_literal204=(IToken)Match(input,104,Follow._104_in_index2414); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal204);



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
			// 436:2: -> ^( Index expression )
			{
				DebugLocation(436, 5);
				// Plsql.g:436:5: ^( Index expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(436, 7);
				root_1 = (object)adaptor.BecomeRoot(new IndexNode(Index), root_1);

				DebugLocation(436, 24);
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
			TraceOut("index", 53);
			LeaveRule("index", 53);
			Leave_index();
		}
		DebugLocation(437, 1);
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
	// Plsql.g:439:1: memberCall : '.' ID -> ^( MemberCall ID ) ;
	[GrammarRule("memberCall")]
	private PlsqlParser.memberCall_return memberCall()
	{
		Enter_memberCall();
		EnterRule("memberCall", 54);
		TraceIn("memberCall", 54);
		PlsqlParser.memberCall_return retval = new PlsqlParser.memberCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal205=null;
		IToken ID206=null;

		object char_literal205_tree=null;
		object ID206_tree=null;
		RewriteRuleITokenStream stream_98=new RewriteRuleITokenStream(adaptor,"token 98");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "memberCall");
		DebugLocation(439, 1);
		try
		{
			// Plsql.g:440:2: ( '.' ID -> ^( MemberCall ID ) )
			DebugEnterAlt(1);
			// Plsql.g:440:4: '.' ID
			{
			DebugLocation(440, 4);
			char_literal205=(IToken)Match(input,98,Follow._98_in_memberCall2437); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_98.Add(char_literal205);

			DebugLocation(440, 8);
			ID206=(IToken)Match(input,ID,Follow._ID_in_memberCall2439); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID206);



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
			// 441:2: -> ^( MemberCall ID )
			{
				DebugLocation(441, 5);
				// Plsql.g:441:5: ^( MemberCall ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(441, 7);
				root_1 = (object)adaptor.BecomeRoot(new MemberCallNode(MemberCall), root_1);

				DebugLocation(441, 34);
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
			TraceOut("memberCall", 54);
			LeaveRule("memberCall", 54);
			Leave_memberCall();
		}
		DebugLocation(442, 1);
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
	// Plsql.g:444:1: expressionOrEmpty : ( expression | -> Expression );
	[GrammarRule("expressionOrEmpty")]
	private PlsqlParser.expressionOrEmpty_return expressionOrEmpty()
	{
		Enter_expressionOrEmpty();
		EnterRule("expressionOrEmpty", 55);
		TraceIn("expressionOrEmpty", 55);
		PlsqlParser.expressionOrEmpty_return retval = new PlsqlParser.expressionOrEmpty_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expression_return expression207 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "expressionOrEmpty");
		DebugLocation(444, 1);
		try
		{
			// Plsql.g:445:2: ( expression | -> Expression )
			int alt42=2;
			try { DebugEnterDecision(42, decisionCanBacktrack[42]);
			int LA42_0 = input.LA(1);

			if ((LA42_0==SELF||(LA42_0>=TRUE && LA42_0<=FALSE)||LA42_0==MINUS||LA42_0==NOT||(LA42_0>=ID && LA42_0<=QUOTED_CHAR)||LA42_0==100))
			{
				alt42=1;
			}
			else if ((LA42_0==EOF))
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
				// Plsql.g:445:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(445, 4);
				PushFollow(Follow._expression_in_expressionOrEmpty2462);
				expression207=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression207.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:446:4: 
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
				// 446:4: -> Expression
				{
					DebugLocation(446, 7);
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
			TraceOut("expressionOrEmpty", 55);
			LeaveRule("expressionOrEmpty", 55);
			Leave_expressionOrEmpty();
		}
		DebugLocation(447, 1);
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
	// Plsql.g:449:1: methodCall : '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) ;
	[GrammarRule("methodCall")]
	private PlsqlParser.methodCall_return methodCall()
	{
		Enter_methodCall();
		EnterRule("methodCall", 56);
		TraceIn("methodCall", 56);
		PlsqlParser.methodCall_return retval = new PlsqlParser.methodCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal208=null;
		IToken ID209=null;
		IToken char_literal210=null;
		IToken char_literal212=null;
		PlsqlParser.expressionList_return expressionList211 = default(PlsqlParser.expressionList_return);

		object char_literal208_tree=null;
		object ID209_tree=null;
		object char_literal210_tree=null;
		object char_literal212_tree=null;
		RewriteRuleITokenStream stream_98=new RewriteRuleITokenStream(adaptor,"token 98");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "methodCall");
		DebugLocation(449, 1);
		try
		{
			// Plsql.g:450:2: ( '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:450:4: '.' ID '(' expressionList ')'
			{
			DebugLocation(450, 4);
			char_literal208=(IToken)Match(input,98,Follow._98_in_methodCall2480); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_98.Add(char_literal208);

			DebugLocation(450, 8);
			ID209=(IToken)Match(input,ID,Follow._ID_in_methodCall2482); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID209);

			DebugLocation(450, 11);
			char_literal210=(IToken)Match(input,100,Follow._100_in_methodCall2484); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal210);

			DebugLocation(450, 15);
			PushFollow(Follow._expressionList_in_methodCall2486);
			expressionList211=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList211.Tree);
			DebugLocation(450, 30);
			char_literal212=(IToken)Match(input,101,Follow._101_in_methodCall2488); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal212);



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
			// 451:2: -> ^( MethodCall ID expressionList )
			{
				DebugLocation(451, 5);
				// Plsql.g:451:5: ^( MethodCall ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(451, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodCallNode(MethodCall), root_1);

				DebugLocation(451, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(451, 37);
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
			TraceOut("methodCall", 56);
			LeaveRule("methodCall", 56);
			Leave_methodCall();
		}
		DebugLocation(452, 1);
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
	// Plsql.g:454:1: createInstance : ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) ;
	[GrammarRule("createInstance")]
	private PlsqlParser.createInstance_return createInstance()
	{
		Enter_createInstance();
		EnterRule("createInstance", 57);
		TraceIn("createInstance", 57);
		PlsqlParser.createInstance_return retval = new PlsqlParser.createInstance_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID213=null;
		IToken char_literal214=null;
		IToken char_literal216=null;
		PlsqlParser.expressionList_return expressionList215 = default(PlsqlParser.expressionList_return);

		object ID213_tree=null;
		object char_literal214_tree=null;
		object char_literal216_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "createInstance");
		DebugLocation(454, 1);
		try
		{
			// Plsql.g:455:2: ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:455:4: ID '(' expressionList ')'
			{
			DebugLocation(455, 4);
			ID213=(IToken)Match(input,ID,Follow._ID_in_createInstance2513); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID213);

			DebugLocation(455, 7);
			char_literal214=(IToken)Match(input,100,Follow._100_in_createInstance2515); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal214);

			DebugLocation(455, 11);
			PushFollow(Follow._expressionList_in_createInstance2517);
			expressionList215=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList215.Tree);
			DebugLocation(455, 26);
			char_literal216=(IToken)Match(input,101,Follow._101_in_createInstance2519); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal216);



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
			// 456:2: -> ^( CreateInstance ID expressionList )
			{
				DebugLocation(456, 5);
				// Plsql.g:456:5: ^( CreateInstance ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(456, 7);
				root_1 = (object)adaptor.BecomeRoot(new CreateInstanceNode(CreateInstance), root_1);

				DebugLocation(456, 42);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(456, 45);
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
			TraceOut("createInstance", 57);
			LeaveRule("createInstance", 57);
			Leave_createInstance();
		}
		DebugLocation(457, 1);
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
	// Plsql.g:459:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );
	[GrammarRule("quant")]
	private PlsqlParser.quant_return quant()
	{
		Enter_quant();
		EnterRule("quant", 58);
		TraceIn("quant", 58);
		PlsqlParser.quant_return retval = new PlsqlParser.quant_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal222=null;
		IToken char_literal224=null;
		IToken SELF226=null;
		PlsqlParser.number_return number217 = default(PlsqlParser.number_return);
		PlsqlParser.bool__return bool_218 = default(PlsqlParser.bool__return);
		PlsqlParser.string__return string_219 = default(PlsqlParser.string__return);
		PlsqlParser.char__return char_220 = default(PlsqlParser.char__return);
		PlsqlParser.createInstance_return createInstance221 = default(PlsqlParser.createInstance_return);
		PlsqlParser.expr__return expr_223 = default(PlsqlParser.expr__return);
		PlsqlParser.var_return var225 = default(PlsqlParser.var_return);

		object char_literal222_tree=null;
		object char_literal224_tree=null;
		object SELF226_tree=null;

		try { DebugEnterRule(GrammarFileName, "quant");
		DebugLocation(459, 1);
		try
		{
			// Plsql.g:460:2: ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF )
			int alt43=8;
			try { DebugEnterDecision(43, decisionCanBacktrack[43]);
			try
			{
				alt43 = dfa43.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(43); }
			switch (alt43)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:460:4: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(460, 4);
				PushFollow(Follow._number_in_quant2544);
				number217=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number217.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:461:6: bool_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(461, 6);
				PushFollow(Follow._bool__in_quant2551);
				bool_218=bool_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bool_218.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:462:6: string_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(462, 6);
				PushFollow(Follow._string__in_quant2558);
				string_219=string_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_219.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:463:4: char_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(463, 4);
				PushFollow(Follow._char__in_quant2563);
				char_220=char_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_220.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:464:6: createInstance
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(464, 6);
				PushFollow(Follow._createInstance_in_quant2570);
				createInstance221=createInstance();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, createInstance221.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:465:6: '(' expr_ ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(465, 9);
				char_literal222=(IToken)Match(input,100,Follow._100_in_quant2577); if (state.failed) return retval;
				DebugLocation(465, 11);
				PushFollow(Follow._expr__in_quant2580);
				expr_223=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_223.Tree);
				DebugLocation(465, 20);
				char_literal224=(IToken)Match(input,101,Follow._101_in_quant2582); if (state.failed) return retval;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:466:6: var
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(466, 6);
				PushFollow(Follow._var_in_quant2590);
				var225=var();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var225.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Plsql.g:467:6: SELF
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(467, 6);
				SELF226=(IToken)Match(input,SELF,Follow._SELF_in_quant2597); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				SELF226_tree = new SelfNode(SELF226) ;
				adaptor.AddChild(root_0, SELF226_tree);
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
			TraceOut("quant", 58);
			LeaveRule("quant", 58);
			Leave_quant();
		}
		DebugLocation(468, 1);
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
	// Plsql.g:470:1: var : ID -> ^( ID ) ;
	[GrammarRule("var")]
	private PlsqlParser.var_return var()
	{
		Enter_var();
		EnterRule("var", 59);
		TraceIn("var", 59);
		PlsqlParser.var_return retval = new PlsqlParser.var_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID227=null;

		object ID227_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "var");
		DebugLocation(470, 1);
		try
		{
			// Plsql.g:470:5: ( ID -> ^( ID ) )
			DebugEnterAlt(1);
			// Plsql.g:470:7: ID
			{
			DebugLocation(470, 7);
			ID227=(IToken)Match(input,ID,Follow._ID_in_var2610); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID227);



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
			// 471:2: -> ^( ID )
			{
				DebugLocation(471, 5);
				// Plsql.g:471:5: ^( ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(471, 7);
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
			TraceOut("var", 59);
			LeaveRule("var", 59);
			Leave_var();
		}
		DebugLocation(472, 1);
		} finally { DebugExitRule(GrammarFileName, "var"); }
		return retval;

	}
	// $ANTLR end "var"

	partial void Enter_synpred41_Plsql_fragment();
	partial void Leave_synpred41_Plsql_fragment();

	// $ANTLR start synpred41_Plsql
	public void synpred41_Plsql_fragment()
	{
		Enter_synpred41_Plsql_fragment();
		EnterRule("synpred41_Plsql_fragment", 100);
		TraceIn("synpred41_Plsql_fragment", 100);
		try
		{
			// Plsql.g:358:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:358:4: assign
			{
			DebugLocation(358, 4);
			PushFollow(Follow._assign_in_synpred41_Plsql1971);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred41_Plsql_fragment", 100);
			LeaveRule("synpred41_Plsql_fragment", 100);
			Leave_synpred41_Plsql_fragment();
		}
	}
	// $ANTLR end synpred41_Plsql

	partial void Enter_synpred44_Plsql_fragment();
	partial void Leave_synpred44_Plsql_fragment();

	// $ANTLR start synpred44_Plsql
	public void synpred44_Plsql_fragment()
	{
		Enter_synpred44_Plsql_fragment();
		EnterRule("synpred44_Plsql_fragment", 103);
		TraceIn("synpred44_Plsql_fragment", 103);
		try
		{
			// Plsql.g:361:4: ( expression )
			DebugEnterAlt(1);
			// Plsql.g:361:4: expression
			{
			DebugLocation(361, 4);
			PushFollow(Follow._expression_in_synpred44_Plsql1986);
			expression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred44_Plsql_fragment", 103);
			LeaveRule("synpred44_Plsql_fragment", 103);
			Leave_synpred44_Plsql_fragment();
		}
	}
	// $ANTLR end synpred44_Plsql

	partial void Enter_synpred55_Plsql_fragment();
	partial void Leave_synpred55_Plsql_fragment();

	// $ANTLR start synpred55_Plsql
	public void synpred55_Plsql_fragment()
	{
		Enter_synpred55_Plsql_fragment();
		EnterRule("synpred55_Plsql_fragment", 114);
		TraceIn("synpred55_Plsql_fragment", 114);
		try
		{
			// Plsql.g:414:16: ( addOperator mult )
			DebugEnterAlt(1);
			// Plsql.g:414:16: addOperator mult
			{
			DebugLocation(414, 16);
			PushFollow(Follow._addOperator_in_synpred55_Plsql2314);
			addOperator();
			PopFollow();
			if (state.failed) return;
			DebugLocation(414, 29);
			PushFollow(Follow._mult_in_synpred55_Plsql2317);
			mult();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred55_Plsql_fragment", 114);
			LeaveRule("synpred55_Plsql_fragment", 114);
			Leave_synpred55_Plsql_fragment();
		}
	}
	// $ANTLR end synpred55_Plsql

	partial void Enter_synpred60_Plsql_fragment();
	partial void Leave_synpred60_Plsql_fragment();

	// $ANTLR start synpred60_Plsql
	public void synpred60_Plsql_fragment()
	{
		Enter_synpred60_Plsql_fragment();
		EnterRule("synpred60_Plsql_fragment", 119);
		TraceIn("synpred60_Plsql_fragment", 119);
		try
		{
			// Plsql.g:430:4: ( methodCall )
			DebugEnterAlt(1);
			// Plsql.g:430:4: methodCall
			{
			DebugLocation(430, 4);
			PushFollow(Follow._methodCall_in_synpred60_Plsql2394);
			methodCall();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred60_Plsql_fragment", 119);
			LeaveRule("synpred60_Plsql_fragment", 119);
			Leave_synpred60_Plsql_fragment();
		}
	}
	// $ANTLR end synpred60_Plsql

	partial void Enter_synpred66_Plsql_fragment();
	partial void Leave_synpred66_Plsql_fragment();

	// $ANTLR start synpred66_Plsql
	public void synpred66_Plsql_fragment()
	{
		Enter_synpred66_Plsql_fragment();
		EnterRule("synpred66_Plsql_fragment", 125);
		TraceIn("synpred66_Plsql_fragment", 125);
		try
		{
			// Plsql.g:464:6: ( createInstance )
			DebugEnterAlt(1);
			// Plsql.g:464:6: createInstance
			{
			DebugLocation(464, 6);
			PushFollow(Follow._createInstance_in_synpred66_Plsql2570);
			createInstance();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred66_Plsql_fragment", 125);
			LeaveRule("synpred66_Plsql_fragment", 125);
			Leave_synpred66_Plsql_fragment();
		}
	}
	// $ANTLR end synpred66_Plsql

	partial void Enter_synpred68_Plsql_fragment();
	partial void Leave_synpred68_Plsql_fragment();

	// $ANTLR start synpred68_Plsql
	public void synpred68_Plsql_fragment()
	{
		Enter_synpred68_Plsql_fragment();
		EnterRule("synpred68_Plsql_fragment", 127);
		TraceIn("synpred68_Plsql_fragment", 127);
		try
		{
			// Plsql.g:466:6: ( var )
			DebugEnterAlt(1);
			// Plsql.g:466:6: var
			{
			DebugLocation(466, 6);
			PushFollow(Follow._var_in_synpred68_Plsql2590);
			var();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred68_Plsql_fragment", 127);
			LeaveRule("synpred68_Plsql_fragment", 127);
			Leave_synpred68_Plsql_fragment();
		}
	}
	// $ANTLR end synpred68_Plsql
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
	DFA26 dfa26;
	DFA37 dfa37;
	DFA43 dfa43;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa26 = new DFA26( this, SpecialStateTransition26 );
		dfa37 = new DFA37( this, SpecialStateTransition37 );
		dfa43 = new DFA43( this, SpecialStateTransition43 );
	}

	private class DFA26 : DFA
	{
		private const string DFA26_eotS =
			"\x12\xFFFF";
		private const string DFA26_eofS =
			"\x12\xFFFF";
		private const string DFA26_minS =
			"\x1\x28\xB\x0\x6\xFFFF";
		private const string DFA26_maxS =
			"\x1\x64\xB\x0\x6\xFFFF";
		private const string DFA26_acceptS =
			"\xC\xFFFF\x1\x2\x1\x3\x1\xFFFF\x1\x5\x1\x1\x1\x4";
		private const string DFA26_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x6\xFFFF}>";
		private static readonly string[] DFA26_transitionS =
			{
				"\x1\xC\x3\xFFFF\x2\xD\x15\xFFFF\x1\xB\x2\xFFFF\x1\x5\x1\x6\x1\xF\x1"+
				"\xFFFF\x1\x1\xB\xFFFF\x1\x2\x5\xFFFF\x1\x9\x1\x3\x1\x4\x1\x7\x1\x8\x3"+
				"\xFFFF\x1\xA",
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
				""
			};

		private static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
		private static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
		private static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
		private static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
		private static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
		private static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
		private static readonly short[][] DFA26_transition;

		static DFA26()
		{
			int numStates = DFA26_transitionS.Length;
			DFA26_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA26_transition[i] = DFA.UnpackEncodedString(DFA26_transitionS[i]);
			}
		}

		public DFA26( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 26;
			this.eot = DFA26_eot;
			this.eof = DFA26_eof;
			this.min = DFA26_min;
			this.max = DFA26_max;
			this.accept = DFA26_accept;
			this.special = DFA26_special;
			this.transition = DFA26_transition;
		}

		public override string Description { get { return "357:1: command : ( assign | if_ | cycle | expression | RETURN expression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition26(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA26_1 = input.LA(1);


				int index26_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA26_2 = input.LA(1);


				int index26_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA26_3 = input.LA(1);


				int index26_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA26_4 = input.LA(1);


				int index26_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA26_5 = input.LA(1);


				int index26_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA26_6 = input.LA(1);


				int index26_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA26_7 = input.LA(1);


				int index26_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA26_8 = input.LA(1);


				int index26_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA26_9 = input.LA(1);


				int index26_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA26_10 = input.LA(1);


				int index26_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA26_11 = input.LA(1);


				int index26_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred41_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_11);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 26, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA37 : DFA
	{
		private const string DFA37_eotS =
			"\x1E\xFFFF";
		private const string DFA37_eofS =
			"\x1\x1\x1D\xFFFF";
		private const string DFA37_minS =
			"\x1\x29\x11\xFFFF\x1\x0\xB\xFFFF";
		private const string DFA37_maxS =
			"\x1\x68\x11\xFFFF\x1\x0\xB\xFFFF";
		private const string DFA37_acceptS =
			"\x1\xFFFF\x1\x2\x1B\xFFFF\x1\x1";
		private const string DFA37_specialS =
			"\x12\xFFFF\x1\x0\xB\xFFFF}>";
		private static readonly string[] DFA37_transitionS =
			{
				"\x1\x1\x3\xFFFF\x1\x1\x12\xFFFF\x1\x1\x2\xFFFF\x1\x1\x2\xFFFF\x2\x1"+
				"\x1\xFFFF\x1\x1D\x1\x12\x3\xFFFF\xA\x1\x4\xFFFF\x5\x1\x2\xFFFF\x4\x1"+
				"\x1\xFFFF\x1\x1",
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
				""
			};

		private static readonly short[] DFA37_eot = DFA.UnpackEncodedString(DFA37_eotS);
		private static readonly short[] DFA37_eof = DFA.UnpackEncodedString(DFA37_eofS);
		private static readonly char[] DFA37_min = DFA.UnpackEncodedStringToUnsignedChars(DFA37_minS);
		private static readonly char[] DFA37_max = DFA.UnpackEncodedStringToUnsignedChars(DFA37_maxS);
		private static readonly short[] DFA37_accept = DFA.UnpackEncodedString(DFA37_acceptS);
		private static readonly short[] DFA37_special = DFA.UnpackEncodedString(DFA37_specialS);
		private static readonly short[][] DFA37_transition;

		static DFA37()
		{
			int numStates = DFA37_transitionS.Length;
			DFA37_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA37_transition[i] = DFA.UnpackEncodedString(DFA37_transitionS[i]);
			}
		}

		public DFA37( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 37;
			this.eot = DFA37_eot;
			this.eof = DFA37_eof;
			this.min = DFA37_min;
			this.max = DFA37_max;
			this.accept = DFA37_accept;
			this.special = DFA37_special;
			this.transition = DFA37_transition;
		}

		public override string Description { get { return "()* loopback of 414:14: ( addOperator mult )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition37(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA37_18 = input.LA(1);


				int index37_18 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred55_Plsql_fragment)) ) {s = 29;}

				else if ( (true) ) {s = 1;}


				input.Seek(index37_18);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 37, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA43 : DFA
	{
		private const string DFA43_eotS =
			"\xC\xFFFF";
		private const string DFA43_eofS =
			"\xC\xFFFF";
		private const string DFA43_minS =
			"\x1\x43\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA43_maxS =
			"\x1\x64\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA43_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x2\x1\xFFFF\x1\x3\x1\x4\x1\xFFFF\x1\x6\x1"+
			"\x8\x1\x5\x1\x7";
		private const string DFA43_specialS =
			"\x7\xFFFF\x1\x0\x4\xFFFF}>";
		private static readonly string[] DFA43_transitionS =
			{
				"\x1\x9\x2\xFFFF\x2\x3\x14\xFFFF\x1\x7\x2\x1\x1\x5\x1\x6\x3\xFFFF\x1"+
				"\x8",
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
				""
			};

		private static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
		private static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
		private static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
		private static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
		private static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
		private static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
		private static readonly short[][] DFA43_transition;

		static DFA43()
		{
			int numStates = DFA43_transitionS.Length;
			DFA43_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA43_transition[i] = DFA.UnpackEncodedString(DFA43_transitionS[i]);
			}
		}

		public DFA43( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 43;
			this.eot = DFA43_eot;
			this.eof = DFA43_eof;
			this.min = DFA43_min;
			this.max = DFA43_max;
			this.accept = DFA43_accept;
			this.special = DFA43_special;
			this.transition = DFA43_transition;
		}

		public override string Description { get { return "459:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition43(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA43_7 = input.LA(1);


				int index43_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred66_Plsql_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred68_Plsql_fragment)) ) {s = 11;}


				input.Seek(index43_7);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 43, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _REAL_in_float_745 = new BitSet(new ulong[]{0x0UL,0x200000000UL});
		public static readonly BitSet _97_in_float_747 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_bool_766 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_bool_778 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTED_STRING_in_string_855 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTED_CHAR_in_char_869 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INTEGER_in_number883 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REAL_in_number895 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _float__in_number907 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_type918 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_type930 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DOUBLE_in_type942 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BOOL_in_type956 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type970 = new BitSet(new ulong[]{0x0UL,0x400000000UL});
		public static readonly BitSet _98_in_type972 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_type974 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type996 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objOrPack_in_program1016 = new BitSet(new ulong[]{0x2000000000000UL,0x4UL});
		public static readonly BitSet _entryPoint_in_program1019 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _object__in_objOrPack1042 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _package__in_objOrPack1048 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_isOrAs0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_in_equalityOperator1078 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEQUAL_in_equalityOperator1090 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MORE_in_ineqOperator1108 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_in_ineqOperator1120 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOREEQ_in_ineqOperator1132 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESSEQ_in_ineqOperator1144 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PLUS_in_addOperator1162 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_addOperator1174 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MULT_in_multOperator1192 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DIVIDE_in_multOperator1204 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOD_in_multOperator1216 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_assignOperator0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_unaryOperator1265 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_unaryOperator1277 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varDef1298 = new BitSet(new ulong[]{0x1E00000000UL,0x10000000UL});
		public static readonly BitSet _type_in_varDef1300 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_varList1328 = new BitSet(new ulong[]{0x2UL,0x800000000UL});
		public static readonly BitSet _99_in_varList1332 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _varDef_in_varList1334 = new BitSet(new ulong[]{0x2UL,0x800000000UL});
		public static readonly BitSet _procDecl_in_methodDecl1360 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcDecl_in_methodDecl1365 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MEMBER_in_methodModifier1376 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STATIC_in_methodModifier1381 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_procDecl1399 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _PROCEDURE_in_procDecl1401 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_procDecl1403 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_procDecl1405 = new BitSet(new ulong[]{0x0UL,0x2010000000UL});
		public static readonly BitSet _varList_in_procDecl1407 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_procDecl1409 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_funcDecl1441 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _FUNCTION_in_funcDecl1443 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_funcDecl1445 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_funcDecl1447 = new BitSet(new ulong[]{0x0UL,0x2010000000UL});
		public static readonly BitSet _varList_in_funcDecl1449 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_funcDecl1451 = new BitSet(new ulong[]{0x0UL,0x100UL});
		public static readonly BitSet _RETURN_in_funcDecl1453 = new BitSet(new ulong[]{0x1E00000000UL,0x10000000UL});
		public static readonly BitSet _type_in_funcDecl1455 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_methodDef1484 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IS_in_methodDef1486 = new BitSet(new ulong[]{0x8000000000000000UL,0x10000000UL});
		public static readonly BitSet _declareBlock_in_methodDef1488 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _BEGIN_in_methodDef1490 = new BitSet(new ulong[]{0x310000000000UL,0x11F04005C9UL});
		public static readonly BitSet _codeBlock_in_methodDef1492 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _END_in_methodDef1494 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1521 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_typeDecl1523 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1525 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _TABLE_in_typeDecl1527 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _OF_in_typeDecl1529 = new BitSet(new ulong[]{0x1E00000000UL,0x10000000UL});
		public static readonly BitSet _type_in_typeDecl1531 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1550 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_typeDecl1552 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1554 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _RECORD_in_typeDecl1556 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_typeDecl1558 = new BitSet(new ulong[]{0x0UL,0x2010000000UL});
		public static readonly BitSet _varList_in_typeDecl1560 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_typeDecl1562 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectDecl_in_object_1589 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectBody_in_object_1594 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectDecl1605 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _TYPE_in_objectDecl1607 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_objectDecl1609 = new BitSet(new ulong[]{0x60000000000000UL});
		public static readonly BitSet _isOrAs_in_objectDecl1611 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectDecl1613 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_objectDecl1615 = new BitSet(new ulong[]{0x6018000000000000UL,0x10000000UL});
		public static readonly BitSet _objectDeclItem_in_objectDecl1617 = new BitSet(new ulong[]{0x6018000000000000UL,0x2010000000UL});
		public static readonly BitSet _101_in_objectDecl1620 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectDecl1622 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectBody1648 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _TYPE_in_objectBody1650 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _BODY_in_objectBody1652 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_objectBody1654 = new BitSet(new ulong[]{0x60000000000000UL});
		public static readonly BitSet _isOrAs_in_objectBody1656 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectBody1658 = new BitSet(new ulong[]{0x6018000000000000UL,0x10000000UL});
		public static readonly BitSet _methodDef_in_objectBody1662 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectBody1664 = new BitSet(new ulong[]{0x6018000000000000UL,0x10000001UL});
		public static readonly BitSet _END_in_objectBody1669 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectBody1671 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_objectDeclItem1697 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectDeclItem1699 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_objectDeclItem1705 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectDeclItem1707 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDecl_in_package_1722 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDef_in_package_1727 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDecl1738 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _PACKAGE_in_packageDecl1740 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_packageDecl1742 = new BitSet(new ulong[]{0x60000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDecl1744 = new BitSet(new ulong[]{0x6018008000000000UL,0x10000000UL});
		public static readonly BitSet _packageDeclItem_in_packageDecl1746 = new BitSet(new ulong[]{0x6018008000000000UL,0x10000001UL});
		public static readonly BitSet _END_in_packageDecl1749 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_packageDecl1751 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDef1778 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _PACKAGE_in_packageDef1780 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _BODY_in_packageDef1782 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_packageDef1784 = new BitSet(new ulong[]{0x60000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDef1786 = new BitSet(new ulong[]{0x6018000000000000UL,0x10000000UL});
		public static readonly BitSet _packageBodyItem_in_packageDef1788 = new BitSet(new ulong[]{0x6018000000000000UL,0x10000001UL});
		public static readonly BitSet _END_in_packageDef1791 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_packageDef1793 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_packageDeclItem1819 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_packageDeclItem1821 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_packageDeclItem1827 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_packageDeclItem1829 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_packageDeclItem1835 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_packageDeclItem1837 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDef_in_packageBodyItem1849 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_packageBodyItem1851 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DECLARE_in_entryPoint1866 = new BitSet(new ulong[]{0x8000000000000000UL,0x10000000UL});
		public static readonly BitSet _declareBlock_in_entryPoint1868 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _BEGIN_in_entryPoint1870 = new BitSet(new ulong[]{0x310000000000UL,0x11F04005C9UL});
		public static readonly BitSet _codeBlock_in_entryPoint1872 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _END_in_entryPoint1874 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_entryPoint1876 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declareItem_in_declareBlock1902 = new BitSet(new ulong[]{0x2UL,0x10000000UL});
		public static readonly BitSet _varDef_in_declareItem1927 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_declareItem1929 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _command_in_codeBlock1943 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_codeBlock1945 = new BitSet(new ulong[]{0x310000000002UL,0x11F04005C8UL});
		public static readonly BitSet _assign_in_command1971 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if__in_command1976 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cycle_in_command1981 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_command1986 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_command1991 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _expression_in_command1997 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2008 = new BitSet(new ulong[]{0x0UL,0x800000UL});
		public static readonly BitSet _ASSIGN_in_assign2010 = new BitSet(new ulong[]{0x0UL,0x11F04004D8UL});
		public static readonly BitSet _NULL_in_assign2018 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2025 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_if_2036 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _expression_in_if_2038 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _THEN_in_if_2040 = new BitSet(new ulong[]{0x350000000000UL,0x11F04005C9UL});
		public static readonly BitSet _codeBlock_in_if_2042 = new BitSet(new ulong[]{0x40000000000UL,0x1UL});
		public static readonly BitSet _ELSE_in_if_2045 = new BitSet(new ulong[]{0x310000000000UL,0x11F04005C9UL});
		public static readonly BitSet _codeBlock_in_if_2047 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _END_in_if_2051 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _IF_in_if_2053 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_cycle2084 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _expression_in_cycle2086 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _LOOP_in_cycle2088 = new BitSet(new ulong[]{0x310000000000UL,0x11F04005C9UL});
		public static readonly BitSet _codeBlock_in_cycle2090 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _END_in_cycle2092 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _LOOP_in_cycle2094 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LOOP_in_cycle2113 = new BitSet(new ulong[]{0x710000000000UL,0x11F04005C8UL});
		public static readonly BitSet _codeBlock_in_cycle2115 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _EXIT_in_cycle2117 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _WHEN_in_cycle2119 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _expression_in_cycle2121 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _END_in_cycle2123 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _LOOP_in_cycle2125 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr__in_expressionList2153 = new BitSet(new ulong[]{0x2UL,0x800000000UL});
		public static readonly BitSet _99_in_expressionList2157 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _expr__in_expressionList2159 = new BitSet(new ulong[]{0x2UL,0x800000000UL});
		public static readonly BitSet _expr__in_expression2188 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicOr_in_expr_2211 = new BitSet(new ulong[]{0x2UL,0x11F04004C8UL});
		public static readonly BitSet _logicAnd_in_logicOr2223 = new BitSet(new ulong[]{0x2UL,0x8000UL});
		public static readonly BitSet _OR_in_logicOr2227 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _logicAnd_in_logicOr2233 = new BitSet(new ulong[]{0x2UL,0x8000UL});
		public static readonly BitSet _equality_in_logicAnd2246 = new BitSet(new ulong[]{0x2UL,0x4000UL});
		public static readonly BitSet _AND_in_logicAnd2250 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _equality_in_logicAnd2256 = new BitSet(new ulong[]{0x2UL,0x4000UL});
		public static readonly BitSet _inequality_in_equality2269 = new BitSet(new ulong[]{0x2UL,0x30000UL});
		public static readonly BitSet _equalityOperator_in_equality2273 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _inequality_in_equality2276 = new BitSet(new ulong[]{0x2UL,0x30000UL});
		public static readonly BitSet _add_in_inequality2289 = new BitSet(new ulong[]{0x2UL,0x3C0000UL});
		public static readonly BitSet _ineqOperator_in_inequality2293 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _add_in_inequality2296 = new BitSet(new ulong[]{0x2UL,0x3C0000UL});
		public static readonly BitSet _mult_in_add2310 = new BitSet(new ulong[]{0x2UL,0x600UL});
		public static readonly BitSet _addOperator_in_add2314 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _mult_in_add2317 = new BitSet(new ulong[]{0x2UL,0x600UL});
		public static readonly BitSet _unary_in_mult2333 = new BitSet(new ulong[]{0x2UL,0x3800UL});
		public static readonly BitSet _multOperator_in_mult2337 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _unary_in_mult2340 = new BitSet(new ulong[]{0x2UL,0x3800UL});
		public static readonly BitSet _unaryOperator_in_unary2354 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _unary_in_unary2357 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _postfix_in_unary2364 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quant_in_postfix2375 = new BitSet(new ulong[]{0x2UL,0x8400000000UL});
		public static readonly BitSet _tmp_in_postfix2377 = new BitSet(new ulong[]{0x2UL,0x8400000000UL});
		public static readonly BitSet _index_in_tmp2389 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_tmp2394 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberCall_in_tmp2399 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _103_in_index2410 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _expression_in_index2412 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_index2414 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _98_in_memberCall2437 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_memberCall2439 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressionOrEmpty2462 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _98_in_methodCall2480 = new BitSet(new ulong[]{0x0UL,0x10000000UL});
		public static readonly BitSet _ID_in_methodCall2482 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_methodCall2484 = new BitSet(new ulong[]{0x0UL,0x31F04004C8UL});
		public static readonly BitSet _expressionList_in_methodCall2486 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_methodCall2488 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_createInstance2513 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_createInstance2515 = new BitSet(new ulong[]{0x0UL,0x31F04004C8UL});
		public static readonly BitSet _expressionList_in_createInstance2517 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_createInstance2519 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_quant2544 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bool__in_quant2551 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _string__in_quant2558 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _char__in_quant2563 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_quant2570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _100_in_quant2577 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _expr__in_quant2580 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_quant2582 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_quant2590 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SELF_in_quant2597 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_var2610 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred41_Plsql1971 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_synpred44_Plsql1986 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _addOperator_in_synpred55_Plsql2314 = new BitSet(new ulong[]{0x0UL,0x11F04004C8UL});
		public static readonly BitSet _mult_in_synpred55_Plsql2317 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_synpred60_Plsql2394 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_synpred66_Plsql2570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_synpred68_Plsql2590 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  plsql_msil 
