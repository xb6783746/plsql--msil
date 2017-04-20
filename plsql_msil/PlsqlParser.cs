// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-20 14:53:25

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "Program", "EntryPoint", "DeclareBlock", "VarList", "VarItem", "ClassDecl", "ClassDef", "ClassItems", "PackageDecl", "PackageDef", "CommandBlock", "TypeName", "VarDef", "MethodDecl", "MethodDef", "ObjectMethodDecl", "ObjectMethodDef", "ObjectItems", "Index", "CodeBlock", "MemberCall", "MethodCall", "Cast", "Expression", "ExpressionList", "StringLiteral", "Table", "Record", "CreateInstance", "Void", "BYTE", "INT", "CHAR", "BOOL", "DOUBLE", "STRING", "VOID", "TYPE", "IF", "THEN", "ELSE", "DO", "WHILE", "LOOP", "EXIT", "WHEN", "FOR", "CREATE", "BODY", "PROCEDURE", "FUNCTION", "IS", "AS", "TABLE", "OF", "INDEX", "BY", "RECORD", "OBJECT", "MEMBER", "STATIC", "BEGIN", "END", "PACKAGE", "DECLARE", "SELF", "NULL", "IN", "TRUE", "FALSE", "RETURN", "PLUS", "MINUS", "MULT", "DIVIDE", "MOD", "AND", "OR", "EQUAL", "NEQUAL", "MORE", "LESS", "MOREEQ", "LESSEQ", "NOT", "ASSIGN", "PLUSASSIGN", "MINUSASSIGN", "MULTASSIGN", "DIVASSIGN", "ID", "INTEGER", "REAL", "QUOTED_STRING", "QUOTED_CHAR", "'f'", "'.'", "','", "'('", "')'", "';'", "'['", "']'"
	};
	public const int EOF=-1;
	public const int T__99=99;
	public const int T__100=100;
	public const int T__101=101;
	public const int T__102=102;
	public const int T__103=103;
	public const int T__104=104;
	public const int T__105=105;
	public const int T__106=106;
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
	public const int OF=58;
	public const int INDEX=59;
	public const int BY=60;
	public const int RECORD=61;
	public const int OBJECT=62;
	public const int MEMBER=63;
	public const int STATIC=64;
	public const int BEGIN=65;
	public const int END=66;
	public const int PACKAGE=67;
	public const int DECLARE=68;
	public const int SELF=69;
	public const int NULL=70;
	public const int IN=71;
	public const int TRUE=72;
	public const int FALSE=73;
	public const int RETURN=74;
	public const int PLUS=75;
	public const int MINUS=76;
	public const int MULT=77;
	public const int DIVIDE=78;
	public const int MOD=79;
	public const int AND=80;
	public const int OR=81;
	public const int EQUAL=82;
	public const int NEQUAL=83;
	public const int MORE=84;
	public const int LESS=85;
	public const int MOREEQ=86;
	public const int LESSEQ=87;
	public const int NOT=88;
	public const int ASSIGN=89;
	public const int PLUSASSIGN=90;
	public const int MINUSASSIGN=91;
	public const int MULTASSIGN=92;
	public const int DIVASSIGN=93;
	public const int ID=94;
	public const int INTEGER=95;
	public const int REAL=96;
	public const int QUOTED_STRING=97;
	public const int QUOTED_CHAR=98;

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
				false, false, false, false, false, false, true, false, true, false, 
				false, true, false, true, , 
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
	// Plsql.g:145:1: float_ : REAL 'f' -> REAL ;
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
		RewriteRuleITokenStream stream_99=new RewriteRuleITokenStream(adaptor,"token 99");

		try { DebugEnterRule(GrammarFileName, "float_");
		DebugLocation(145, 1);
		try
		{
			// Plsql.g:146:2: ( REAL 'f' -> REAL )
			DebugEnterAlt(1);
			// Plsql.g:146:4: REAL 'f'
			{
			DebugLocation(146, 4);
			REAL1=(IToken)Match(input,REAL,Follow._REAL_in_float_757); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_REAL.Add(REAL1);

			DebugLocation(146, 9);
			char_literal2=(IToken)Match(input,99,Follow._99_in_float_759); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_99.Add(char_literal2);



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
			// 147:2: -> REAL
			{
				DebugLocation(147, 5);
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
		DebugLocation(148, 1);
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
	// Plsql.g:150:1: bool_ : ( TRUE -> TRUE | FALSE -> FALSE );
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
		DebugLocation(150, 1);
		try
		{
			// Plsql.g:151:2: ( TRUE -> TRUE | FALSE -> FALSE )
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
				// Plsql.g:151:4: TRUE
				{
				DebugLocation(151, 4);
				TRUE3=(IToken)Match(input,TRUE,Follow._TRUE_in_bool_778); if (state.failed) return retval; 
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
				// 151:9: -> TRUE
				{
					DebugLocation(151, 12);
					adaptor.AddChild(root_0, new BoolNode(stream_TRUE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:152:4: FALSE
				{
				DebugLocation(152, 4);
				FALSE4=(IToken)Match(input,FALSE,Follow._FALSE_in_bool_790); if (state.failed) return retval; 
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
				// 152:10: -> FALSE
				{
					DebugLocation(152, 13);
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
		DebugLocation(153, 1);
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
	// Plsql.g:163:1: string_ : QUOTED_STRING ;
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
		DebugLocation(163, 1);
		try
		{
			// Plsql.g:164:2: ( QUOTED_STRING )
			DebugEnterAlt(1);
			// Plsql.g:164:4: QUOTED_STRING
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(164, 4);
			QUOTED_STRING5=(IToken)Match(input,QUOTED_STRING,Follow._QUOTED_STRING_in_string_867); if (state.failed) return retval;
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
		DebugLocation(165, 1);
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
	// Plsql.g:167:1: char_ : QUOTED_CHAR ;
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
		DebugLocation(167, 1);
		try
		{
			// Plsql.g:168:2: ( QUOTED_CHAR )
			DebugEnterAlt(1);
			// Plsql.g:168:4: QUOTED_CHAR
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(168, 4);
			QUOTED_CHAR6=(IToken)Match(input,QUOTED_CHAR,Follow._QUOTED_CHAR_in_char_881); if (state.failed) return retval;
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
		DebugLocation(169, 1);
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
	// Plsql.g:171:1: number : ( INTEGER -> INTEGER | REAL -> REAL | float_ );
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
		DebugLocation(171, 1);
		try
		{
			// Plsql.g:172:2: ( INTEGER -> INTEGER | REAL -> REAL | float_ )
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

				if ((LA2_2==99))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||LA2_2==THEN||LA2_2==LOOP||LA2_2==END||LA2_2==SELF||(LA2_2>=TRUE && LA2_2<=FALSE)||(LA2_2>=PLUS && LA2_2<=ASSIGN)||(LA2_2>=ID && LA2_2<=QUOTED_CHAR)||(LA2_2>=100 && LA2_2<=106)))
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
				// Plsql.g:172:4: INTEGER
				{
				DebugLocation(172, 4);
				INTEGER7=(IToken)Match(input,INTEGER,Follow._INTEGER_in_number895); if (state.failed) return retval; 
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
				// 172:12: -> INTEGER
				{
					DebugLocation(172, 15);
					adaptor.AddChild(root_0, new IntegerNode(stream_INTEGER.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:173:4: REAL
				{
				DebugLocation(173, 4);
				REAL8=(IToken)Match(input,REAL,Follow._REAL_in_number907); if (state.failed) return retval; 
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
				// 173:9: -> REAL
				{
					DebugLocation(173, 12);
					adaptor.AddChild(root_0, new RealNode(stream_REAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:174:4: float_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(174, 4);
				PushFollow(Follow._float__in_number919);
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
		DebugLocation(175, 1);
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
	// Plsql.g:177:1: type : ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | ID -> ID );
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
		IToken BOOL14=null;
		IToken ID15=null;
		IToken char_literal16=null;
		IToken ID17=null;
		IToken ID18=null;

		object INT10_tree=null;
		object BYTE11_tree=null;
		object CHAR12_tree=null;
		object DOUBLE13_tree=null;
		object BOOL14_tree=null;
		object ID15_tree=null;
		object char_literal16_tree=null;
		object ID17_tree=null;
		object ID18_tree=null;
		RewriteRuleITokenStream stream_CHAR=new RewriteRuleITokenStream(adaptor,"token CHAR");
		RewriteRuleITokenStream stream_DOUBLE=new RewriteRuleITokenStream(adaptor,"token DOUBLE");
		RewriteRuleITokenStream stream_BYTE=new RewriteRuleITokenStream(adaptor,"token BYTE");
		RewriteRuleITokenStream stream_INT=new RewriteRuleITokenStream(adaptor,"token INT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleITokenStream stream_BOOL=new RewriteRuleITokenStream(adaptor,"token BOOL");

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(177, 1);
		try
		{
			// Plsql.g:178:2: ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | ID -> ID )
			int alt3=7;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			switch (input.LA(1))
			{
			case INT:
				{
				alt3=1;
				}
				break;
			case BYTE:
				{
				alt3=2;
				}
				break;
			case CHAR:
				{
				alt3=3;
				}
				break;
			case DOUBLE:
				{
				alt3=4;
				}
				break;
			case BOOL:
				{
				alt3=5;
				}
				break;
			case ID:
				{
				int LA3_6 = input.LA(2);

				if ((LA3_6==100))
				{
					alt3=6;
				}
				else if ((LA3_6==EOF||LA3_6==IS||LA3_6==101||(LA3_6>=103 && LA3_6<=104)))
				{
					alt3=7;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 3, 6, input);

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
				// Plsql.g:178:4: INT
				{
				DebugLocation(178, 4);
				INT10=(IToken)Match(input,INT,Follow._INT_in_type930); if (state.failed) return retval; 
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
				// 178:8: -> INT
				{
					DebugLocation(178, 11);
					adaptor.AddChild(root_0, new TypeNode(stream_INT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:179:4: BYTE
				{
				DebugLocation(179, 4);
				BYTE11=(IToken)Match(input,BYTE,Follow._BYTE_in_type942); if (state.failed) return retval; 
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
				// 179:9: -> BYTE
				{
					DebugLocation(179, 12);
					adaptor.AddChild(root_0, new TypeNode(stream_BYTE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:180:4: CHAR
				{
				DebugLocation(180, 4);
				CHAR12=(IToken)Match(input,CHAR,Follow._CHAR_in_type954); if (state.failed) return retval; 
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
				// 180:9: -> CHAR
				{
					DebugLocation(180, 12);
					adaptor.AddChild(root_0, new TypeNode(stream_CHAR.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:181:4: DOUBLE
				{
				DebugLocation(181, 4);
				DOUBLE13=(IToken)Match(input,DOUBLE,Follow._DOUBLE_in_type966); if (state.failed) return retval; 
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
				// 181:11: -> DOUBLE
				{
					DebugLocation(181, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_DOUBLE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:182:6: BOOL
				{
				DebugLocation(182, 6);
				BOOL14=(IToken)Match(input,BOOL,Follow._BOOL_in_type980); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BOOL.Add(BOOL14);



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
				// 182:11: -> BOOL
				{
					DebugLocation(182, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_BOOL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:183:6: ID '.' ID
				{
				DebugLocation(183, 6);
				ID15=(IToken)Match(input,ID,Follow._ID_in_type994); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID15);

				DebugLocation(183, 9);
				char_literal16=(IToken)Match(input,100,Follow._100_in_type996); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_100.Add(char_literal16);

				DebugLocation(183, 13);
				ID17=(IToken)Match(input,ID,Follow._ID_in_type998); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID17);



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
				// 184:2: -> ^( TypeName ID ID )
				{
					DebugLocation(184, 6);
					// Plsql.g:184:6: ^( TypeName ID ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(184, 8);
					root_1 = (object)adaptor.BecomeRoot(new TypeNode(TypeName), root_1);

					DebugLocation(184, 27);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(184, 30);
					adaptor.AddChild(root_1, stream_ID.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:185:6: ID
				{
				DebugLocation(185, 6);
				ID18=(IToken)Match(input,ID,Follow._ID_in_type1020); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID18);



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
				// 185:9: -> ID
				{
					DebugLocation(185, 12);
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
		DebugLocation(186, 1);
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
	// Plsql.g:188:8: public program : ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) ;
	[GrammarRule("program")]
	public PlsqlParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 7);
		TraceIn("program", 7);
		PlsqlParser.program_return retval = new PlsqlParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objOrPack_return objOrPack19 = default(PlsqlParser.objOrPack_return);
		PlsqlParser.entryPoint_return entryPoint20 = default(PlsqlParser.entryPoint_return);

		RewriteRuleSubtreeStream stream_objOrPack=new RewriteRuleSubtreeStream(adaptor,"rule objOrPack");
		RewriteRuleSubtreeStream stream_entryPoint=new RewriteRuleSubtreeStream(adaptor,"rule entryPoint");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(188, 1);
		try
		{
			// Plsql.g:189:2: ( ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) )
			DebugEnterAlt(1);
			// Plsql.g:189:4: ( objOrPack )* entryPoint
			{
			DebugLocation(189, 4);
			// Plsql.g:189:4: ( objOrPack )*
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
					DebugLocation(189, 4);
					PushFollow(Follow._objOrPack_in_program1040);
					objOrPack19=objOrPack();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objOrPack.Add(objOrPack19.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(189, 15);
			PushFollow(Follow._entryPoint_in_program1043);
			entryPoint20=entryPoint();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_entryPoint.Add(entryPoint20.Tree);


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
			// 190:2: -> ^( Program ( objOrPack )* entryPoint )
			{
				DebugLocation(190, 5);
				// Plsql.g:190:5: ^( Program ( objOrPack )* entryPoint )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(190, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(Program, "Program"), root_1);

				DebugLocation(190, 15);
				// Plsql.g:190:15: ( objOrPack )*
				while ( stream_objOrPack.HasNext )
				{
					DebugLocation(190, 15);
					adaptor.AddChild(root_1, stream_objOrPack.NextTree());

				}
				stream_objOrPack.Reset();
				DebugLocation(190, 26);
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
		DebugLocation(191, 1);
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
	// Plsql.g:193:1: objOrPack : ( object_ | package_ );
	[GrammarRule("objOrPack")]
	private PlsqlParser.objOrPack_return objOrPack()
	{
		Enter_objOrPack();
		EnterRule("objOrPack", 8);
		TraceIn("objOrPack", 8);
		PlsqlParser.objOrPack_return retval = new PlsqlParser.objOrPack_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.object__return object_21 = default(PlsqlParser.object__return);
		PlsqlParser.package__return package_22 = default(PlsqlParser.package__return);


		try { DebugEnterRule(GrammarFileName, "objOrPack");
		DebugLocation(193, 1);
		try
		{
			// Plsql.g:194:2: ( object_ | package_ )
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
				// Plsql.g:194:4: object_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(194, 4);
				PushFollow(Follow._object__in_objOrPack1066);
				object_21=object_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_21.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:195:4: package_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(195, 4);
				PushFollow(Follow._package__in_objOrPack1072);
				package_22=package_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, package_22.Tree);

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
		DebugLocation(196, 1);
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
	// Plsql.g:198:1: isOrAs : ( IS | AS );
	[GrammarRule("isOrAs")]
	private PlsqlParser.isOrAs_return isOrAs()
	{
		Enter_isOrAs();
		EnterRule("isOrAs", 9);
		TraceIn("isOrAs", 9);
		PlsqlParser.isOrAs_return retval = new PlsqlParser.isOrAs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set23=null;

		object set23_tree=null;

		try { DebugEnterRule(GrammarFileName, "isOrAs");
		DebugLocation(198, 1);
		try
		{
			// Plsql.g:199:2: ( IS | AS )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(199, 2);
			set23=(IToken)input.LT(1);
			if ((input.LA(1)>=IS && input.LA(1)<=AS))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set23));
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
		DebugLocation(201, 1);
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
	// Plsql.g:205:1: equalityOperator : ( EQUAL -> EQUAL | NEQUAL -> NEQUAL );
	[GrammarRule("equalityOperator")]
	private PlsqlParser.equalityOperator_return equalityOperator()
	{
		Enter_equalityOperator();
		EnterRule("equalityOperator", 10);
		TraceIn("equalityOperator", 10);
		PlsqlParser.equalityOperator_return retval = new PlsqlParser.equalityOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EQUAL24=null;
		IToken NEQUAL25=null;

		object EQUAL24_tree=null;
		object NEQUAL25_tree=null;
		RewriteRuleITokenStream stream_NEQUAL=new RewriteRuleITokenStream(adaptor,"token NEQUAL");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");

		try { DebugEnterRule(GrammarFileName, "equalityOperator");
		DebugLocation(205, 1);
		try
		{
			// Plsql.g:206:2: ( EQUAL -> EQUAL | NEQUAL -> NEQUAL )
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
				// Plsql.g:206:4: EQUAL
				{
				DebugLocation(206, 4);
				EQUAL24=(IToken)Match(input,EQUAL,Follow._EQUAL_in_equalityOperator1102); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL24);



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
				// 206:10: -> EQUAL
				{
					DebugLocation(206, 13);
					adaptor.AddChild(root_0, new EqualNode(stream_EQUAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:207:4: NEQUAL
				{
				DebugLocation(207, 4);
				NEQUAL25=(IToken)Match(input,NEQUAL,Follow._NEQUAL_in_equalityOperator1114); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NEQUAL.Add(NEQUAL25);



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
				// 207:11: -> NEQUAL
				{
					DebugLocation(207, 14);
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
		DebugLocation(208, 1);
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
	// Plsql.g:210:1: ineqOperator : ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ );
	[GrammarRule("ineqOperator")]
	private PlsqlParser.ineqOperator_return ineqOperator()
	{
		Enter_ineqOperator();
		EnterRule("ineqOperator", 11);
		TraceIn("ineqOperator", 11);
		PlsqlParser.ineqOperator_return retval = new PlsqlParser.ineqOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MORE26=null;
		IToken LESS27=null;
		IToken MOREEQ28=null;
		IToken LESSEQ29=null;

		object MORE26_tree=null;
		object LESS27_tree=null;
		object MOREEQ28_tree=null;
		object LESSEQ29_tree=null;
		RewriteRuleITokenStream stream_MOREEQ=new RewriteRuleITokenStream(adaptor,"token MOREEQ");
		RewriteRuleITokenStream stream_LESSEQ=new RewriteRuleITokenStream(adaptor,"token LESSEQ");
		RewriteRuleITokenStream stream_MORE=new RewriteRuleITokenStream(adaptor,"token MORE");
		RewriteRuleITokenStream stream_LESS=new RewriteRuleITokenStream(adaptor,"token LESS");

		try { DebugEnterRule(GrammarFileName, "ineqOperator");
		DebugLocation(210, 1);
		try
		{
			// Plsql.g:211:2: ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ )
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
				// Plsql.g:211:4: MORE
				{
				DebugLocation(211, 4);
				MORE26=(IToken)Match(input,MORE,Follow._MORE_in_ineqOperator1132); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MORE.Add(MORE26);



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
				// 211:9: -> MORE
				{
					DebugLocation(211, 12);
					adaptor.AddChild(root_0, new GreaterNode(stream_MORE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:212:4: LESS
				{
				DebugLocation(212, 4);
				LESS27=(IToken)Match(input,LESS,Follow._LESS_in_ineqOperator1144); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESS.Add(LESS27);



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
				// 212:9: -> LESS
				{
					DebugLocation(212, 12);
					adaptor.AddChild(root_0, new LessNode(stream_LESS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:213:4: MOREEQ
				{
				DebugLocation(213, 4);
				MOREEQ28=(IToken)Match(input,MOREEQ,Follow._MOREEQ_in_ineqOperator1156); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOREEQ.Add(MOREEQ28);



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
				// 213:11: -> MOREEQ
				{
					DebugLocation(213, 14);
					adaptor.AddChild(root_0, new GreaterOrEqualNode(stream_MOREEQ.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:214:4: LESSEQ
				{
				DebugLocation(214, 4);
				LESSEQ29=(IToken)Match(input,LESSEQ,Follow._LESSEQ_in_ineqOperator1168); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESSEQ.Add(LESSEQ29);



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
				// 214:11: -> LESSEQ
				{
					DebugLocation(214, 14);
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
		DebugLocation(215, 1);
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
	// Plsql.g:217:1: addOperator : ( PLUS -> PLUS | MINUS -> MINUS );
	[GrammarRule("addOperator")]
	private PlsqlParser.addOperator_return addOperator()
	{
		Enter_addOperator();
		EnterRule("addOperator", 12);
		TraceIn("addOperator", 12);
		PlsqlParser.addOperator_return retval = new PlsqlParser.addOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PLUS30=null;
		IToken MINUS31=null;

		object PLUS30_tree=null;
		object MINUS31_tree=null;
		RewriteRuleITokenStream stream_PLUS=new RewriteRuleITokenStream(adaptor,"token PLUS");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "addOperator");
		DebugLocation(217, 1);
		try
		{
			// Plsql.g:218:2: ( PLUS -> PLUS | MINUS -> MINUS )
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
				// Plsql.g:218:4: PLUS
				{
				DebugLocation(218, 4);
				PLUS30=(IToken)Match(input,PLUS,Follow._PLUS_in_addOperator1186); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_PLUS.Add(PLUS30);



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
				// 218:9: -> PLUS
				{
					DebugLocation(218, 12);
					adaptor.AddChild(root_0, new PlusNode(stream_PLUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:219:4: MINUS
				{
				DebugLocation(219, 4);
				MINUS31=(IToken)Match(input,MINUS,Follow._MINUS_in_addOperator1198); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS31);



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
				// 219:10: -> MINUS
				{
					DebugLocation(219, 13);
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
		DebugLocation(220, 1);
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
	// Plsql.g:222:1: multOperator : ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD );
	[GrammarRule("multOperator")]
	private PlsqlParser.multOperator_return multOperator()
	{
		Enter_multOperator();
		EnterRule("multOperator", 13);
		TraceIn("multOperator", 13);
		PlsqlParser.multOperator_return retval = new PlsqlParser.multOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MULT32=null;
		IToken DIVIDE33=null;
		IToken MOD34=null;

		object MULT32_tree=null;
		object DIVIDE33_tree=null;
		object MOD34_tree=null;
		RewriteRuleITokenStream stream_MULT=new RewriteRuleITokenStream(adaptor,"token MULT");
		RewriteRuleITokenStream stream_MOD=new RewriteRuleITokenStream(adaptor,"token MOD");
		RewriteRuleITokenStream stream_DIVIDE=new RewriteRuleITokenStream(adaptor,"token DIVIDE");

		try { DebugEnterRule(GrammarFileName, "multOperator");
		DebugLocation(222, 1);
		try
		{
			// Plsql.g:223:2: ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD )
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
				// Plsql.g:223:4: MULT
				{
				DebugLocation(223, 4);
				MULT32=(IToken)Match(input,MULT,Follow._MULT_in_multOperator1216); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MULT.Add(MULT32);



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
				// 223:9: -> MULT
				{
					DebugLocation(223, 12);
					adaptor.AddChild(root_0, new MultNode(stream_MULT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:224:4: DIVIDE
				{
				DebugLocation(224, 4);
				DIVIDE33=(IToken)Match(input,DIVIDE,Follow._DIVIDE_in_multOperator1228); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DIVIDE.Add(DIVIDE33);



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
				// 224:11: -> DIVIDE
				{
					DebugLocation(224, 14);
					adaptor.AddChild(root_0, new DivNode(stream_DIVIDE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:225:4: MOD
				{
				DebugLocation(225, 4);
				MOD34=(IToken)Match(input,MOD,Follow._MOD_in_multOperator1240); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOD.Add(MOD34);



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
				// 225:8: -> MOD
				{
					DebugLocation(225, 11);
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
		DebugLocation(226, 1);
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
	// Plsql.g:228:1: assignOperator : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN );
	[GrammarRule("assignOperator")]
	private PlsqlParser.assignOperator_return assignOperator()
	{
		Enter_assignOperator();
		EnterRule("assignOperator", 14);
		TraceIn("assignOperator", 14);
		PlsqlParser.assignOperator_return retval = new PlsqlParser.assignOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set35=null;

		object set35_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignOperator");
		DebugLocation(228, 1);
		try
		{
			// Plsql.g:229:2: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(229, 2);
			set35=(IToken)input.LT(1);
			if ((input.LA(1)>=ASSIGN && input.LA(1)<=DIVASSIGN))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set35));
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
		DebugLocation(234, 1);
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
	// Plsql.g:236:1: unaryOperator : ( MINUS -> MINUS | NOT -> NOT );
	[GrammarRule("unaryOperator")]
	private PlsqlParser.unaryOperator_return unaryOperator()
	{
		Enter_unaryOperator();
		EnterRule("unaryOperator", 15);
		TraceIn("unaryOperator", 15);
		PlsqlParser.unaryOperator_return retval = new PlsqlParser.unaryOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS36=null;
		IToken NOT37=null;

		object MINUS36_tree=null;
		object NOT37_tree=null;
		RewriteRuleITokenStream stream_NOT=new RewriteRuleITokenStream(adaptor,"token NOT");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "unaryOperator");
		DebugLocation(236, 1);
		try
		{
			// Plsql.g:237:2: ( MINUS -> MINUS | NOT -> NOT )
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
				// Plsql.g:237:4: MINUS
				{
				DebugLocation(237, 4);
				MINUS36=(IToken)Match(input,MINUS,Follow._MINUS_in_unaryOperator1289); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS36);



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
				// 237:10: -> MINUS
				{
					DebugLocation(237, 13);
					adaptor.AddChild(root_0, new MinusNode(stream_MINUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:238:4: NOT
				{
				DebugLocation(238, 4);
				NOT37=(IToken)Match(input,NOT,Follow._NOT_in_unaryOperator1301); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NOT.Add(NOT37);



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
				// 238:8: -> NOT
				{
					DebugLocation(238, 11);
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
		DebugLocation(239, 1);
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
	// Plsql.g:244:1: varDef : ID type -> ^( VarDef ID type ) ;
	[GrammarRule("varDef")]
	private PlsqlParser.varDef_return varDef()
	{
		Enter_varDef();
		EnterRule("varDef", 16);
		TraceIn("varDef", 16);
		PlsqlParser.varDef_return retval = new PlsqlParser.varDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID38=null;
		PlsqlParser.type_return type39 = default(PlsqlParser.type_return);

		object ID38_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varDef");
		DebugLocation(244, 1);
		try
		{
			// Plsql.g:245:2: ( ID type -> ^( VarDef ID type ) )
			DebugEnterAlt(1);
			// Plsql.g:245:4: ID type
			{
			DebugLocation(245, 4);
			ID38=(IToken)Match(input,ID,Follow._ID_in_varDef1322); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID38);

			DebugLocation(245, 7);
			PushFollow(Follow._type_in_varDef1324);
			type39=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type39.Tree);


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
			// 246:2: -> ^( VarDef ID type )
			{
				DebugLocation(246, 5);
				// Plsql.g:246:5: ^( VarDef ID type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(246, 7);
				root_1 = (object)adaptor.BecomeRoot(new VarDefNode(VarDef), root_1);

				DebugLocation(246, 26);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(246, 29);
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
		DebugLocation(247, 1);
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
	// Plsql.g:249:1: varList : ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) ;
	[GrammarRule("varList")]
	private PlsqlParser.varList_return varList()
	{
		Enter_varList();
		EnterRule("varList", 17);
		TraceIn("varList", 17);
		PlsqlParser.varList_return retval = new PlsqlParser.varList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal41=null;
		PlsqlParser.varDef_return varDef40 = default(PlsqlParser.varDef_return);
		PlsqlParser.varDef_return varDef42 = default(PlsqlParser.varDef_return);

		object char_literal41_tree=null;
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_varDef=new RewriteRuleSubtreeStream(adaptor,"rule varDef");
		try { DebugEnterRule(GrammarFileName, "varList");
		DebugLocation(249, 1);
		try
		{
			// Plsql.g:250:2: ( ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) )
			DebugEnterAlt(1);
			// Plsql.g:250:4: ( varDef ( ',' varDef )* )?
			{
			DebugLocation(250, 4);
			// Plsql.g:250:4: ( varDef ( ',' varDef )* )?
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
				// Plsql.g:250:6: varDef ( ',' varDef )*
				{
				DebugLocation(250, 6);
				PushFollow(Follow._varDef_in_varList1352);
				varDef40=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varDef.Add(varDef40.Tree);
				DebugLocation(250, 13);
				// Plsql.g:250:13: ( ',' varDef )*
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==101))
					{
						alt11=1;
					}


					} finally { DebugExitDecision(11); }
					switch ( alt11 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:250:15: ',' varDef
						{
						DebugLocation(250, 15);
						char_literal41=(IToken)Match(input,101,Follow._101_in_varList1356); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_101.Add(char_literal41);

						DebugLocation(250, 19);
						PushFollow(Follow._varDef_in_varList1358);
						varDef42=varDef();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_varDef.Add(varDef42.Tree);

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
			// 251:2: -> ^( VarList ( varDef )* )
			{
				DebugLocation(251, 5);
				// Plsql.g:251:5: ^( VarList ( varDef )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(251, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VarList, "VarList"), root_1);

				DebugLocation(251, 15);
				// Plsql.g:251:15: ( varDef )*
				while ( stream_varDef.HasNext )
				{
					DebugLocation(251, 15);
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
		DebugLocation(252, 1);
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
	// Plsql.g:254:1: methodDecl : ( procDecl | funcDecl );
	[GrammarRule("methodDecl")]
	private PlsqlParser.methodDecl_return methodDecl()
	{
		Enter_methodDecl();
		EnterRule("methodDecl", 18);
		TraceIn("methodDecl", 18);
		PlsqlParser.methodDecl_return retval = new PlsqlParser.methodDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.procDecl_return procDecl43 = default(PlsqlParser.procDecl_return);
		PlsqlParser.funcDecl_return funcDecl44 = default(PlsqlParser.funcDecl_return);


		try { DebugEnterRule(GrammarFileName, "methodDecl");
		DebugLocation(254, 1);
		try
		{
			// Plsql.g:255:2: ( procDecl | funcDecl )
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
				// Plsql.g:255:4: procDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(255, 4);
				PushFollow(Follow._procDecl_in_methodDecl1384);
				procDecl43=procDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, procDecl43.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:256:4: funcDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(256, 4);
				PushFollow(Follow._funcDecl_in_methodDecl1389);
				funcDecl44=funcDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcDecl44.Tree);

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
		DebugLocation(257, 1);
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
	// Plsql.g:259:1: methodModifier : ( MEMBER | STATIC | -> STATIC );
	[GrammarRule("methodModifier")]
	private PlsqlParser.methodModifier_return methodModifier()
	{
		Enter_methodModifier();
		EnterRule("methodModifier", 19);
		TraceIn("methodModifier", 19);
		PlsqlParser.methodModifier_return retval = new PlsqlParser.methodModifier_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MEMBER45=null;
		IToken STATIC46=null;

		object MEMBER45_tree=null;
		object STATIC46_tree=null;

		try { DebugEnterRule(GrammarFileName, "methodModifier");
		DebugLocation(259, 1);
		try
		{
			// Plsql.g:260:2: ( MEMBER | STATIC | -> STATIC )
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
				// Plsql.g:260:4: MEMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(260, 4);
				MEMBER45=(IToken)Match(input,MEMBER,Follow._MEMBER_in_methodModifier1400); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				MEMBER45_tree = (object)adaptor.Create(MEMBER45);
				adaptor.AddChild(root_0, MEMBER45_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:261:4: STATIC
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(261, 4);
				STATIC46=(IToken)Match(input,STATIC,Follow._STATIC_in_methodModifier1405); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				STATIC46_tree = (object)adaptor.Create(STATIC46);
				adaptor.AddChild(root_0, STATIC46_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:262:4: 
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
				// 262:4: -> STATIC
				{
					DebugLocation(262, 7);
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
		DebugLocation(263, 1);
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
	// Plsql.g:265:1: procDecl : methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) ;
	[GrammarRule("procDecl")]
	private PlsqlParser.procDecl_return procDecl()
	{
		Enter_procDecl();
		EnterRule("procDecl", 20);
		TraceIn("procDecl", 20);
		PlsqlParser.procDecl_return retval = new PlsqlParser.procDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROCEDURE48=null;
		IToken ID49=null;
		IToken char_literal50=null;
		IToken char_literal52=null;
		PlsqlParser.methodModifier_return methodModifier47 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList51 = default(PlsqlParser.varList_return);

		object PROCEDURE48_tree=null;
		object ID49_tree=null;
		object char_literal50_tree=null;
		object char_literal52_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "procDecl");
		DebugLocation(265, 1);
		try
		{
			// Plsql.g:266:2: ( methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:266:4: methodModifier PROCEDURE ID '(' varList ')'
			{
			DebugLocation(266, 4);
			PushFollow(Follow._methodModifier_in_procDecl1423);
			methodModifier47=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier47.Tree);
			DebugLocation(266, 19);
			PROCEDURE48=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procDecl1425); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROCEDURE.Add(PROCEDURE48);

			DebugLocation(266, 29);
			ID49=(IToken)Match(input,ID,Follow._ID_in_procDecl1427); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID49);

			DebugLocation(266, 32);
			char_literal50=(IToken)Match(input,102,Follow._102_in_procDecl1429); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal50);

			DebugLocation(266, 36);
			PushFollow(Follow._varList_in_procDecl1431);
			varList51=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList51.Tree);
			DebugLocation(266, 44);
			char_literal52=(IToken)Match(input,103,Follow._103_in_procDecl1433); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal52);



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
			// 267:2: -> ^( MethodDecl ID varList Void methodModifier )
			{
				DebugLocation(267, 5);
				// Plsql.g:267:5: ^( MethodDecl ID varList Void methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(267, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(267, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(267, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(267, 45);
				adaptor.AddChild(root_1, new VoidNode(Void));
				DebugLocation(267, 60);
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
		DebugLocation(268, 1);
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
	// Plsql.g:270:1: funcDecl : methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) ;
	[GrammarRule("funcDecl")]
	private PlsqlParser.funcDecl_return funcDecl()
	{
		Enter_funcDecl();
		EnterRule("funcDecl", 21);
		TraceIn("funcDecl", 21);
		PlsqlParser.funcDecl_return retval = new PlsqlParser.funcDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNCTION54=null;
		IToken ID55=null;
		IToken char_literal56=null;
		IToken char_literal58=null;
		IToken RETURN59=null;
		PlsqlParser.methodModifier_return methodModifier53 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList57 = default(PlsqlParser.varList_return);
		PlsqlParser.type_return type60 = default(PlsqlParser.type_return);

		object FUNCTION54_tree=null;
		object ID55_tree=null;
		object char_literal56_tree=null;
		object char_literal58_tree=null;
		object RETURN59_tree=null;
		RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_RETURN=new RewriteRuleITokenStream(adaptor,"token RETURN");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "funcDecl");
		DebugLocation(270, 1);
		try
		{
			// Plsql.g:271:2: ( methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:271:4: methodModifier FUNCTION ID '(' varList ')' RETURN type
			{
			DebugLocation(271, 4);
			PushFollow(Follow._methodModifier_in_funcDecl1465);
			methodModifier53=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier53.Tree);
			DebugLocation(271, 19);
			FUNCTION54=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDecl1467); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNCTION.Add(FUNCTION54);

			DebugLocation(271, 28);
			ID55=(IToken)Match(input,ID,Follow._ID_in_funcDecl1469); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID55);

			DebugLocation(271, 31);
			char_literal56=(IToken)Match(input,102,Follow._102_in_funcDecl1471); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal56);

			DebugLocation(271, 35);
			PushFollow(Follow._varList_in_funcDecl1473);
			varList57=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList57.Tree);
			DebugLocation(271, 43);
			char_literal58=(IToken)Match(input,103,Follow._103_in_funcDecl1475); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal58);

			DebugLocation(271, 47);
			RETURN59=(IToken)Match(input,RETURN,Follow._RETURN_in_funcDecl1477); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RETURN.Add(RETURN59);

			DebugLocation(271, 54);
			PushFollow(Follow._type_in_funcDecl1479);
			type60=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type60.Tree);


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
			// 272:2: -> ^( MethodDecl ID varList type methodModifier )
			{
				DebugLocation(272, 5);
				// Plsql.g:272:5: ^( MethodDecl ID varList type methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(272, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(272, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(272, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(272, 45);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(272, 50);
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
		DebugLocation(273, 1);
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
	// Plsql.g:275:1: methodDef : methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) ;
	[GrammarRule("methodDef")]
	private PlsqlParser.methodDef_return methodDef()
	{
		Enter_methodDef();
		EnterRule("methodDef", 22);
		TraceIn("methodDef", 22);
		PlsqlParser.methodDef_return retval = new PlsqlParser.methodDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IS62=null;
		IToken BEGIN64=null;
		IToken END66=null;
		PlsqlParser.methodDecl_return methodDecl61 = default(PlsqlParser.methodDecl_return);
		PlsqlParser.declareBlock_return declareBlock63 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock65 = default(PlsqlParser.codeBlock_return);

		object IS62_tree=null;
		object BEGIN64_tree=null;
		object END66_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_methodDecl=new RewriteRuleSubtreeStream(adaptor,"rule methodDecl");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "methodDef");
		DebugLocation(275, 1);
		try
		{
			// Plsql.g:276:2: ( methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:276:4: methodDecl IS declareBlock BEGIN codeBlock END
			{
			DebugLocation(276, 4);
			PushFollow(Follow._methodDecl_in_methodDef1508);
			methodDecl61=methodDecl();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodDecl.Add(methodDecl61.Tree);
			DebugLocation(276, 15);
			IS62=(IToken)Match(input,IS,Follow._IS_in_methodDef1510); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IS.Add(IS62);

			DebugLocation(276, 18);
			PushFollow(Follow._declareBlock_in_methodDef1512);
			declareBlock63=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock63.Tree);
			DebugLocation(276, 31);
			BEGIN64=(IToken)Match(input,BEGIN,Follow._BEGIN_in_methodDef1514); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN64);

			DebugLocation(276, 37);
			PushFollow(Follow._codeBlock_in_methodDef1516);
			codeBlock65=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock65.Tree);
			DebugLocation(276, 47);
			END66=(IToken)Match(input,END,Follow._END_in_methodDef1518); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END66);



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
			// 277:2: -> ^( MethodDef declareBlock methodDecl codeBlock )
			{
				DebugLocation(277, 5);
				// Plsql.g:277:5: ^( MethodDef declareBlock methodDecl codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(277, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(MethodDef), root_1);

				DebugLocation(277, 32);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(277, 45);
				adaptor.AddChild(root_1, stream_methodDecl.NextTree());
				DebugLocation(277, 56);
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
		DebugLocation(278, 1);
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
	// Plsql.g:280:1: typeDecl : ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) );
	[GrammarRule("typeDecl")]
	private PlsqlParser.typeDecl_return typeDecl()
	{
		Enter_typeDecl();
		EnterRule("typeDecl", 23);
		TraceIn("typeDecl", 23);
		PlsqlParser.typeDecl_return retval = new PlsqlParser.typeDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken TYPE67=null;
		IToken ID68=null;
		IToken IS69=null;
		IToken TABLE70=null;
		IToken OF71=null;
		IToken TYPE73=null;
		IToken ID74=null;
		IToken IS75=null;
		IToken RECORD76=null;
		IToken char_literal77=null;
		IToken char_literal79=null;
		PlsqlParser.type_return type72 = default(PlsqlParser.type_return);
		PlsqlParser.varList_return varList78 = default(PlsqlParser.varList_return);

		object TYPE67_tree=null;
		object ID68_tree=null;
		object IS69_tree=null;
		object TABLE70_tree=null;
		object OF71_tree=null;
		object TYPE73_tree=null;
		object ID74_tree=null;
		object IS75_tree=null;
		object RECORD76_tree=null;
		object char_literal77_tree=null;
		object char_literal79_tree=null;
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
		DebugLocation(280, 1);
		try
		{
			// Plsql.g:281:2: ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) )
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
				// Plsql.g:281:4: TYPE ID IS TABLE OF type
				{
				DebugLocation(281, 4);
				TYPE67=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1545); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE67);

				DebugLocation(281, 9);
				ID68=(IToken)Match(input,ID,Follow._ID_in_typeDecl1547); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID68);

				DebugLocation(281, 12);
				IS69=(IToken)Match(input,IS,Follow._IS_in_typeDecl1549); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS69);

				DebugLocation(281, 15);
				TABLE70=(IToken)Match(input,TABLE,Follow._TABLE_in_typeDecl1551); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE70);

				DebugLocation(281, 21);
				OF71=(IToken)Match(input,OF,Follow._OF_in_typeDecl1553); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF71);

				DebugLocation(281, 24);
				PushFollow(Follow._type_in_typeDecl1555);
				type72=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type72.Tree);


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
				// 282:2: -> ^( Table ID type )
				{
					DebugLocation(282, 5);
					// Plsql.g:282:5: ^( Table ID type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(282, 7);
					root_1 = (object)adaptor.BecomeRoot(new TableNode(Table), root_1);

					DebugLocation(282, 24);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(282, 27);
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
				// Plsql.g:283:4: TYPE ID IS RECORD '(' varList ')'
				{
				DebugLocation(283, 4);
				TYPE73=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1574); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE73);

				DebugLocation(283, 9);
				ID74=(IToken)Match(input,ID,Follow._ID_in_typeDecl1576); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID74);

				DebugLocation(283, 12);
				IS75=(IToken)Match(input,IS,Follow._IS_in_typeDecl1578); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS75);

				DebugLocation(283, 15);
				RECORD76=(IToken)Match(input,RECORD,Follow._RECORD_in_typeDecl1580); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_RECORD.Add(RECORD76);

				DebugLocation(283, 22);
				char_literal77=(IToken)Match(input,102,Follow._102_in_typeDecl1582); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal77);

				DebugLocation(283, 26);
				PushFollow(Follow._varList_in_typeDecl1584);
				varList78=varList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varList.Add(varList78.Tree);
				DebugLocation(283, 34);
				char_literal79=(IToken)Match(input,103,Follow._103_in_typeDecl1586); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal79);



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
				// 284:2: -> ^( Record ID varList )
				{
					DebugLocation(284, 5);
					// Plsql.g:284:5: ^( Record ID varList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(284, 7);
					root_1 = (object)adaptor.BecomeRoot(new RecordNode(Record), root_1);

					DebugLocation(284, 26);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(284, 29);
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
		DebugLocation(285, 1);
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
	// Plsql.g:289:1: object_ : ( objectDecl | objectBody );
	[GrammarRule("object_")]
	private PlsqlParser.object__return object_()
	{
		Enter_object_();
		EnterRule("object_", 24);
		TraceIn("object_", 24);
		PlsqlParser.object__return retval = new PlsqlParser.object__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objectDecl_return objectDecl80 = default(PlsqlParser.objectDecl_return);
		PlsqlParser.objectBody_return objectBody81 = default(PlsqlParser.objectBody_return);


		try { DebugEnterRule(GrammarFileName, "object_");
		DebugLocation(289, 1);
		try
		{
			// Plsql.g:290:2: ( objectDecl | objectBody )
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
				// Plsql.g:290:4: objectDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(290, 4);
				PushFollow(Follow._objectDecl_in_object_1613);
				objectDecl80=objectDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectDecl80.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:291:4: objectBody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(291, 4);
				PushFollow(Follow._objectBody_in_object_1618);
				objectBody81=objectBody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectBody81.Tree);

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
		DebugLocation(292, 1);
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
	// Plsql.g:294:1: objectDecl : CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) ;
	[GrammarRule("objectDecl")]
	private PlsqlParser.objectDecl_return objectDecl()
	{
		Enter_objectDecl();
		EnterRule("objectDecl", 25);
		TraceIn("objectDecl", 25);
		PlsqlParser.objectDecl_return retval = new PlsqlParser.objectDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE82=null;
		IToken TYPE83=null;
		IToken ID84=null;
		IToken OBJECT86=null;
		IToken char_literal87=null;
		IToken char_literal89=null;
		IToken char_literal90=null;
		PlsqlParser.isOrAs_return isOrAs85 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.objectDeclItem_return objectDeclItem88 = default(PlsqlParser.objectDeclItem_return);

		object CREATE82_tree=null;
		object TYPE83_tree=null;
		object ID84_tree=null;
		object OBJECT86_tree=null;
		object char_literal87_tree=null;
		object char_literal89_tree=null;
		object char_literal90_tree=null;
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OBJECT=new RewriteRuleITokenStream(adaptor,"token OBJECT");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_objectDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule objectDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "objectDecl");
		DebugLocation(294, 1);
		try
		{
			// Plsql.g:295:2: ( CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:295:4: CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';'
			{
			DebugLocation(295, 4);
			CREATE82=(IToken)Match(input,CREATE,Follow._CREATE_in_objectDecl1629); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE82);

			DebugLocation(295, 11);
			TYPE83=(IToken)Match(input,TYPE,Follow._TYPE_in_objectDecl1631); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE83);

			DebugLocation(295, 16);
			ID84=(IToken)Match(input,ID,Follow._ID_in_objectDecl1633); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID84);

			DebugLocation(295, 19);
			PushFollow(Follow._isOrAs_in_objectDecl1635);
			isOrAs85=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs85.Tree);
			DebugLocation(295, 26);
			OBJECT86=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectDecl1637); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT86);

			DebugLocation(295, 33);
			char_literal87=(IToken)Match(input,102,Follow._102_in_objectDecl1639); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal87);

			DebugLocation(295, 37);
			// Plsql.g:295:37: ( objectDeclItem )+
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
					DebugLocation(295, 37);
					PushFollow(Follow._objectDeclItem_in_objectDecl1641);
					objectDeclItem88=objectDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objectDeclItem.Add(objectDeclItem88.Tree);

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

			DebugLocation(295, 53);
			char_literal89=(IToken)Match(input,103,Follow._103_in_objectDecl1644); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal89);

			DebugLocation(295, 57);
			char_literal90=(IToken)Match(input,104,Follow._104_in_objectDecl1646); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal90);



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
			// 296:2: -> ^( ClassDecl ID ( objectDeclItem )+ )
			{
				DebugLocation(296, 5);
				// Plsql.g:296:5: ^( ClassDecl ID ( objectDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(296, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDeclNode(ClassDecl), root_1);

				DebugLocation(296, 32);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(296, 35);
				if ( !(stream_objectDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_objectDeclItem.HasNext )
				{
					DebugLocation(296, 35);
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
		DebugLocation(297, 1);
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
	// Plsql.g:299:1: objectBody : CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) ;
	[GrammarRule("objectBody")]
	private PlsqlParser.objectBody_return objectBody()
	{
		Enter_objectBody();
		EnterRule("objectBody", 26);
		TraceIn("objectBody", 26);
		PlsqlParser.objectBody_return retval = new PlsqlParser.objectBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE91=null;
		IToken TYPE92=null;
		IToken BODY93=null;
		IToken ID94=null;
		IToken OBJECT96=null;
		IToken char_literal98=null;
		IToken END99=null;
		IToken char_literal100=null;
		PlsqlParser.isOrAs_return isOrAs95 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.methodDef_return methodDef97 = default(PlsqlParser.methodDef_return);

		object CREATE91_tree=null;
		object TYPE92_tree=null;
		object BODY93_tree=null;
		object ID94_tree=null;
		object OBJECT96_tree=null;
		object char_literal98_tree=null;
		object END99_tree=null;
		object char_literal100_tree=null;
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OBJECT=new RewriteRuleITokenStream(adaptor,"token OBJECT");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_methodDef=new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "objectBody");
		DebugLocation(299, 1);
		try
		{
			// Plsql.g:300:2: ( CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:300:4: CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';'
			{
			DebugLocation(300, 4);
			CREATE91=(IToken)Match(input,CREATE,Follow._CREATE_in_objectBody1672); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE91);

			DebugLocation(300, 11);
			TYPE92=(IToken)Match(input,TYPE,Follow._TYPE_in_objectBody1674); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE92);

			DebugLocation(300, 16);
			BODY93=(IToken)Match(input,BODY,Follow._BODY_in_objectBody1676); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY93);

			DebugLocation(300, 21);
			ID94=(IToken)Match(input,ID,Follow._ID_in_objectBody1678); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID94);

			DebugLocation(300, 24);
			PushFollow(Follow._isOrAs_in_objectBody1680);
			isOrAs95=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs95.Tree);
			DebugLocation(300, 31);
			OBJECT96=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectBody1682); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT96);

			DebugLocation(300, 38);
			// Plsql.g:300:38: ( methodDef ';' )+
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
					// Plsql.g:300:40: methodDef ';'
					{
					DebugLocation(300, 40);
					PushFollow(Follow._methodDef_in_objectBody1686);
					methodDef97=methodDef();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_methodDef.Add(methodDef97.Tree);
					DebugLocation(300, 50);
					char_literal98=(IToken)Match(input,104,Follow._104_in_objectBody1688); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal98);


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

			DebugLocation(300, 57);
			END99=(IToken)Match(input,END,Follow._END_in_objectBody1693); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END99);

			DebugLocation(300, 61);
			char_literal100=(IToken)Match(input,104,Follow._104_in_objectBody1695); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal100);



			{
			// AST REWRITE
			// elements: methodDef, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 301:2: -> ^( ClassDef ID ( methodDef )+ )
			{
				DebugLocation(301, 5);
				// Plsql.g:301:5: ^( ClassDef ID ( methodDef )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(301, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDefNode(ClassDef), root_1);

				DebugLocation(301, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(301, 33);
				if ( !(stream_methodDef.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_methodDef.HasNext )
				{
					DebugLocation(301, 33);
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
		DebugLocation(302, 1);
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
	// Plsql.g:304:1: objectDeclItem : ( varDef ';' | methodDecl ';' );
	[GrammarRule("objectDeclItem")]
	private PlsqlParser.objectDeclItem_return objectDeclItem()
	{
		Enter_objectDeclItem();
		EnterRule("objectDeclItem", 27);
		TraceIn("objectDeclItem", 27);
		PlsqlParser.objectDeclItem_return retval = new PlsqlParser.objectDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal102=null;
		IToken char_literal104=null;
		PlsqlParser.varDef_return varDef101 = default(PlsqlParser.varDef_return);
		PlsqlParser.methodDecl_return methodDecl103 = default(PlsqlParser.methodDecl_return);

		object char_literal102_tree=null;
		object char_literal104_tree=null;

		try { DebugEnterRule(GrammarFileName, "objectDeclItem");
		DebugLocation(304, 1);
		try
		{
			// Plsql.g:305:2: ( varDef ';' | methodDecl ';' )
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
				// Plsql.g:305:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(305, 4);
				PushFollow(Follow._varDef_in_objectDeclItem1721);
				varDef101=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef101.Tree);
				DebugLocation(305, 14);
				char_literal102=(IToken)Match(input,104,Follow._104_in_objectDeclItem1723); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:306:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(306, 4);
				PushFollow(Follow._methodDecl_in_objectDeclItem1729);
				methodDecl103=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl103.Tree);
				DebugLocation(306, 18);
				char_literal104=(IToken)Match(input,104,Follow._104_in_objectDeclItem1731); if (state.failed) return retval;

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
		DebugLocation(307, 1);
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
	// Plsql.g:312:1: package_ : ( packageDecl | packageDef );
	[GrammarRule("package_")]
	private PlsqlParser.package__return package_()
	{
		Enter_package_();
		EnterRule("package_", 28);
		TraceIn("package_", 28);
		PlsqlParser.package__return retval = new PlsqlParser.package__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.packageDecl_return packageDecl105 = default(PlsqlParser.packageDecl_return);
		PlsqlParser.packageDef_return packageDef106 = default(PlsqlParser.packageDef_return);


		try { DebugEnterRule(GrammarFileName, "package_");
		DebugLocation(312, 1);
		try
		{
			// Plsql.g:313:2: ( packageDecl | packageDef )
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
				// Plsql.g:313:4: packageDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(313, 4);
				PushFollow(Follow._packageDecl_in_package_1746);
				packageDecl105=packageDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDecl105.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:314:4: packageDef
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(314, 4);
				PushFollow(Follow._packageDef_in_package_1751);
				packageDef106=packageDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDef106.Tree);

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
		DebugLocation(315, 1);
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
	// Plsql.g:317:1: packageDecl : CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) ;
	[GrammarRule("packageDecl")]
	private PlsqlParser.packageDecl_return packageDecl()
	{
		Enter_packageDecl();
		EnterRule("packageDecl", 29);
		TraceIn("packageDecl", 29);
		PlsqlParser.packageDecl_return retval = new PlsqlParser.packageDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE107=null;
		IToken PACKAGE108=null;
		IToken ID109=null;
		IToken END112=null;
		IToken char_literal113=null;
		PlsqlParser.isOrAs_return isOrAs110 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageDeclItem_return packageDeclItem111 = default(PlsqlParser.packageDeclItem_return);

		object CREATE107_tree=null;
		object PACKAGE108_tree=null;
		object ID109_tree=null;
		object END112_tree=null;
		object char_literal113_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_packageDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule packageDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDecl");
		DebugLocation(317, 1);
		try
		{
			// Plsql.g:318:2: ( CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:318:4: CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';'
			{
			DebugLocation(318, 4);
			CREATE107=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDecl1762); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE107);

			DebugLocation(318, 11);
			PACKAGE108=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDecl1764); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE108);

			DebugLocation(318, 19);
			ID109=(IToken)Match(input,ID,Follow._ID_in_packageDecl1766); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID109);

			DebugLocation(318, 22);
			PushFollow(Follow._isOrAs_in_packageDecl1768);
			isOrAs110=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs110.Tree);
			DebugLocation(318, 29);
			// Plsql.g:318:29: ( packageDeclItem )+
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
					DebugLocation(318, 29);
					PushFollow(Follow._packageDeclItem_in_packageDecl1770);
					packageDeclItem111=packageDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageDeclItem.Add(packageDeclItem111.Tree);

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

			DebugLocation(318, 46);
			END112=(IToken)Match(input,END,Follow._END_in_packageDecl1773); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END112);

			DebugLocation(318, 50);
			char_literal113=(IToken)Match(input,104,Follow._104_in_packageDecl1775); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal113);



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
			// 319:2: -> ^( PackageDecl ID ( packageDeclItem )+ )
			{
				DebugLocation(319, 5);
				// Plsql.g:319:5: ^( PackageDecl ID ( packageDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(319, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDeclNode(PackageDecl), root_1);

				DebugLocation(319, 36);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(319, 39);
				if ( !(stream_packageDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageDeclItem.HasNext )
				{
					DebugLocation(319, 39);
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
		DebugLocation(320, 1);
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
	// Plsql.g:322:1: packageDef : CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) ;
	[GrammarRule("packageDef")]
	private PlsqlParser.packageDef_return packageDef()
	{
		Enter_packageDef();
		EnterRule("packageDef", 30);
		TraceIn("packageDef", 30);
		PlsqlParser.packageDef_return retval = new PlsqlParser.packageDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE114=null;
		IToken PACKAGE115=null;
		IToken BODY116=null;
		IToken ID117=null;
		IToken END120=null;
		IToken char_literal121=null;
		PlsqlParser.isOrAs_return isOrAs118 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageBodyItem_return packageBodyItem119 = default(PlsqlParser.packageBodyItem_return);

		object CREATE114_tree=null;
		object PACKAGE115_tree=null;
		object BODY116_tree=null;
		object ID117_tree=null;
		object END120_tree=null;
		object char_literal121_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_packageBodyItem=new RewriteRuleSubtreeStream(adaptor,"rule packageBodyItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDef");
		DebugLocation(322, 1);
		try
		{
			// Plsql.g:323:2: ( CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:323:4: CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';'
			{
			DebugLocation(323, 4);
			CREATE114=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDef1802); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE114);

			DebugLocation(323, 11);
			PACKAGE115=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDef1804); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE115);

			DebugLocation(323, 19);
			BODY116=(IToken)Match(input,BODY,Follow._BODY_in_packageDef1806); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY116);

			DebugLocation(323, 24);
			ID117=(IToken)Match(input,ID,Follow._ID_in_packageDef1808); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID117);

			DebugLocation(323, 27);
			PushFollow(Follow._isOrAs_in_packageDef1810);
			isOrAs118=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs118.Tree);
			DebugLocation(323, 34);
			// Plsql.g:323:34: ( packageBodyItem )+
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
					DebugLocation(323, 34);
					PushFollow(Follow._packageBodyItem_in_packageDef1812);
					packageBodyItem119=packageBodyItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageBodyItem.Add(packageBodyItem119.Tree);

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

			DebugLocation(323, 51);
			END120=(IToken)Match(input,END,Follow._END_in_packageDef1815); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END120);

			DebugLocation(323, 55);
			char_literal121=(IToken)Match(input,104,Follow._104_in_packageDef1817); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal121);



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
			// 324:2: -> ^( PackageDef ID ( packageBodyItem )+ )
			{
				DebugLocation(324, 5);
				// Plsql.g:324:5: ^( PackageDef ID ( packageBodyItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(324, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDefNode(PackageDef), root_1);

				DebugLocation(324, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(324, 37);
				if ( !(stream_packageBodyItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageBodyItem.HasNext )
				{
					DebugLocation(324, 37);
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
		DebugLocation(325, 1);
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
	// Plsql.g:327:1: packageDeclItem : ( varDef ';' | typeDecl ';' | methodDecl ';' );
	[GrammarRule("packageDeclItem")]
	private PlsqlParser.packageDeclItem_return packageDeclItem()
	{
		Enter_packageDeclItem();
		EnterRule("packageDeclItem", 31);
		TraceIn("packageDeclItem", 31);
		PlsqlParser.packageDeclItem_return retval = new PlsqlParser.packageDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal123=null;
		IToken char_literal125=null;
		IToken char_literal127=null;
		PlsqlParser.varDef_return varDef122 = default(PlsqlParser.varDef_return);
		PlsqlParser.typeDecl_return typeDecl124 = default(PlsqlParser.typeDecl_return);
		PlsqlParser.methodDecl_return methodDecl126 = default(PlsqlParser.methodDecl_return);

		object char_literal123_tree=null;
		object char_literal125_tree=null;
		object char_literal127_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageDeclItem");
		DebugLocation(327, 1);
		try
		{
			// Plsql.g:328:2: ( varDef ';' | typeDecl ';' | methodDecl ';' )
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
				// Plsql.g:328:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(328, 4);
				PushFollow(Follow._varDef_in_packageDeclItem1843);
				varDef122=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef122.Tree);
				DebugLocation(328, 14);
				char_literal123=(IToken)Match(input,104,Follow._104_in_packageDeclItem1845); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:329:4: typeDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(329, 4);
				PushFollow(Follow._typeDecl_in_packageDeclItem1851);
				typeDecl124=typeDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeDecl124.Tree);
				DebugLocation(329, 16);
				char_literal125=(IToken)Match(input,104,Follow._104_in_packageDeclItem1853); if (state.failed) return retval;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:330:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(330, 4);
				PushFollow(Follow._methodDecl_in_packageDeclItem1859);
				methodDecl126=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl126.Tree);
				DebugLocation(330, 18);
				char_literal127=(IToken)Match(input,104,Follow._104_in_packageDeclItem1861); if (state.failed) return retval;

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
		DebugLocation(331, 1);
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
	// Plsql.g:333:1: packageBodyItem : methodDef ';' ;
	[GrammarRule("packageBodyItem")]
	private PlsqlParser.packageBodyItem_return packageBodyItem()
	{
		Enter_packageBodyItem();
		EnterRule("packageBodyItem", 32);
		TraceIn("packageBodyItem", 32);
		PlsqlParser.packageBodyItem_return retval = new PlsqlParser.packageBodyItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal129=null;
		PlsqlParser.methodDef_return methodDef128 = default(PlsqlParser.methodDef_return);

		object char_literal129_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageBodyItem");
		DebugLocation(333, 1);
		try
		{
			// Plsql.g:334:2: ( methodDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:334:4: methodDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(334, 4);
			PushFollow(Follow._methodDef_in_packageBodyItem1873);
			methodDef128=methodDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef128.Tree);
			DebugLocation(334, 17);
			char_literal129=(IToken)Match(input,104,Follow._104_in_packageBodyItem1875); if (state.failed) return retval;

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
		DebugLocation(335, 1);
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
	// Plsql.g:340:1: entryPoint : DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) ;
	[GrammarRule("entryPoint")]
	private PlsqlParser.entryPoint_return entryPoint()
	{
		Enter_entryPoint();
		EnterRule("entryPoint", 33);
		TraceIn("entryPoint", 33);
		PlsqlParser.entryPoint_return retval = new PlsqlParser.entryPoint_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DECLARE130=null;
		IToken BEGIN132=null;
		IToken END134=null;
		IToken char_literal135=null;
		PlsqlParser.declareBlock_return declareBlock131 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock133 = default(PlsqlParser.codeBlock_return);

		object DECLARE130_tree=null;
		object BEGIN132_tree=null;
		object END134_tree=null;
		object char_literal135_tree=null;
		RewriteRuleITokenStream stream_DECLARE=new RewriteRuleITokenStream(adaptor,"token DECLARE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "entryPoint");
		DebugLocation(340, 1);
		try
		{
			// Plsql.g:341:2: ( DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:341:4: DECLARE declareBlock BEGIN codeBlock END ';'
			{
			DebugLocation(341, 4);
			DECLARE130=(IToken)Match(input,DECLARE,Follow._DECLARE_in_entryPoint1890); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DECLARE.Add(DECLARE130);

			DebugLocation(341, 12);
			PushFollow(Follow._declareBlock_in_entryPoint1892);
			declareBlock131=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock131.Tree);
			DebugLocation(341, 25);
			BEGIN132=(IToken)Match(input,BEGIN,Follow._BEGIN_in_entryPoint1894); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN132);

			DebugLocation(341, 31);
			PushFollow(Follow._codeBlock_in_entryPoint1896);
			codeBlock133=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock133.Tree);
			DebugLocation(341, 41);
			END134=(IToken)Match(input,END,Follow._END_in_entryPoint1898); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END134);

			DebugLocation(341, 45);
			char_literal135=(IToken)Match(input,104,Follow._104_in_entryPoint1900); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal135);



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
			// 342:2: -> ^( EntryPoint declareBlock codeBlock )
			{
				DebugLocation(342, 5);
				// Plsql.g:342:5: ^( EntryPoint declareBlock codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(342, 7);
				root_1 = (object)adaptor.BecomeRoot(new EntryPointNode(EntryPoint), root_1);

				DebugLocation(342, 34);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(342, 47);
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
		DebugLocation(343, 1);
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
	// Plsql.g:346:1: declareBlock : ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) ;
	[GrammarRule("declareBlock")]
	private PlsqlParser.declareBlock_return declareBlock()
	{
		Enter_declareBlock();
		EnterRule("declareBlock", 34);
		TraceIn("declareBlock", 34);
		PlsqlParser.declareBlock_return retval = new PlsqlParser.declareBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.declareItem_return declareItem136 = default(PlsqlParser.declareItem_return);

		RewriteRuleSubtreeStream stream_declareItem=new RewriteRuleSubtreeStream(adaptor,"rule declareItem");
		try { DebugEnterRule(GrammarFileName, "declareBlock");
		DebugLocation(346, 1);
		try
		{
			// Plsql.g:347:2: ( ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) )
			DebugEnterAlt(1);
			// Plsql.g:347:4: ( declareItem )*
			{
			DebugLocation(347, 4);
			// Plsql.g:347:4: ( declareItem )*
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
					DebugLocation(347, 4);
					PushFollow(Follow._declareItem_in_declareBlock1926);
					declareItem136=declareItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declareItem.Add(declareItem136.Tree);

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
			// 348:2: -> ^( DeclareBlock ( declareItem )* )
			{
				DebugLocation(348, 5);
				// Plsql.g:348:5: ^( DeclareBlock ( declareItem )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(348, 7);
				root_1 = (object)adaptor.BecomeRoot(new DeclareBlockNode(DeclareBlock), root_1);

				DebugLocation(348, 38);
				// Plsql.g:348:38: ( declareItem )*
				while ( stream_declareItem.HasNext )
				{
					DebugLocation(348, 38);
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
		DebugLocation(349, 1);
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
	// Plsql.g:351:1: declareItem : varDef ';' ;
	[GrammarRule("declareItem")]
	private PlsqlParser.declareItem_return declareItem()
	{
		Enter_declareItem();
		EnterRule("declareItem", 35);
		TraceIn("declareItem", 35);
		PlsqlParser.declareItem_return retval = new PlsqlParser.declareItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal138=null;
		PlsqlParser.varDef_return varDef137 = default(PlsqlParser.varDef_return);

		object char_literal138_tree=null;

		try { DebugEnterRule(GrammarFileName, "declareItem");
		DebugLocation(351, 1);
		try
		{
			// Plsql.g:352:2: ( varDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:352:4: varDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(352, 4);
			PushFollow(Follow._varDef_in_declareItem1951);
			varDef137=varDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef137.Tree);
			DebugLocation(352, 14);
			char_literal138=(IToken)Match(input,104,Follow._104_in_declareItem1953); if (state.failed) return retval;

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
		DebugLocation(353, 1);
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
	// Plsql.g:355:1: codeBlock : ( command ';' )* -> ^( CodeBlock ( command )* ) ;
	[GrammarRule("codeBlock")]
	private PlsqlParser.codeBlock_return codeBlock()
	{
		Enter_codeBlock();
		EnterRule("codeBlock", 36);
		TraceIn("codeBlock", 36);
		PlsqlParser.codeBlock_return retval = new PlsqlParser.codeBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal140=null;
		PlsqlParser.command_return command139 = default(PlsqlParser.command_return);

		object char_literal140_tree=null;
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_command=new RewriteRuleSubtreeStream(adaptor,"rule command");
		try { DebugEnterRule(GrammarFileName, "codeBlock");
		DebugLocation(355, 1);
		try
		{
			// Plsql.g:356:2: ( ( command ';' )* -> ^( CodeBlock ( command )* ) )
			DebugEnterAlt(1);
			// Plsql.g:356:4: ( command ';' )*
			{
			DebugLocation(356, 4);
			// Plsql.g:356:4: ( command ';' )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==IF||(LA25_0>=WHILE && LA25_0<=LOOP)||LA25_0==SELF||(LA25_0>=TRUE && LA25_0<=RETURN)||LA25_0==MINUS||LA25_0==NOT||(LA25_0>=ID && LA25_0<=QUOTED_CHAR)||LA25_0==102))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:356:6: command ';'
					{
					DebugLocation(356, 6);
					PushFollow(Follow._command_in_codeBlock1967);
					command139=command();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_command.Add(command139.Tree);
					DebugLocation(356, 14);
					char_literal140=(IToken)Match(input,104,Follow._104_in_codeBlock1969); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal140);


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
			// 357:2: -> ^( CodeBlock ( command )* )
			{
				DebugLocation(357, 5);
				// Plsql.g:357:5: ^( CodeBlock ( command )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(357, 7);
				root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(CodeBlock), root_1);

				DebugLocation(357, 32);
				// Plsql.g:357:32: ( command )*
				while ( stream_command.HasNext )
				{
					DebugLocation(357, 32);
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
		DebugLocation(358, 1);
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
	// Plsql.g:360:1: command : ( assign | if_ | cycle | expression | RETURN expression );
	[GrammarRule("command")]
	private PlsqlParser.command_return command()
	{
		Enter_command();
		EnterRule("command", 37);
		TraceIn("command", 37);
		PlsqlParser.command_return retval = new PlsqlParser.command_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken RETURN145=null;
		PlsqlParser.assign_return assign141 = default(PlsqlParser.assign_return);
		PlsqlParser.if__return if_142 = default(PlsqlParser.if__return);
		PlsqlParser.cycle_return cycle143 = default(PlsqlParser.cycle_return);
		PlsqlParser.expression_return expression144 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression146 = default(PlsqlParser.expression_return);

		object RETURN145_tree=null;

		try { DebugEnterRule(GrammarFileName, "command");
		DebugLocation(360, 1);
		try
		{
			// Plsql.g:361:2: ( assign | if_ | cycle | expression | RETURN expression )
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
				// Plsql.g:361:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(361, 4);
				PushFollow(Follow._assign_in_command1995);
				assign141=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign141.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:362:4: if_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(362, 4);
				PushFollow(Follow._if__in_command2000);
				if_142=if_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_142.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:363:4: cycle
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(363, 4);
				PushFollow(Follow._cycle_in_command2005);
				cycle143=cycle();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle143.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:364:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(364, 4);
				PushFollow(Follow._expression_in_command2010);
				expression144=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression144.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:365:4: RETURN expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(365, 22);
				RETURN145=(IToken)Match(input,RETURN,Follow._RETURN_in_command2015); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				RETURN145_tree = new ReturnNode(RETURN145) ;
				root_0 = (object)adaptor.BecomeRoot(RETURN145_tree, root_0);
				}
				DebugLocation(365, 24);
				PushFollow(Follow._expression_in_command2021);
				expression146=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression146.Tree);

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
		DebugLocation(366, 1);
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
	// Plsql.g:368:1: assign : expression ASSIGN ( NULL | expression ) ;
	[GrammarRule("assign")]
	private PlsqlParser.assign_return assign()
	{
		Enter_assign();
		EnterRule("assign", 38);
		TraceIn("assign", 38);
		PlsqlParser.assign_return retval = new PlsqlParser.assign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGN148=null;
		IToken NULL149=null;
		PlsqlParser.expression_return expression147 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression150 = default(PlsqlParser.expression_return);

		object ASSIGN148_tree=null;
		object NULL149_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign");
		DebugLocation(368, 1);
		try
		{
			// Plsql.g:369:2: ( expression ASSIGN ( NULL | expression ) )
			DebugEnterAlt(1);
			// Plsql.g:369:4: expression ASSIGN ( NULL | expression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(369, 4);
			PushFollow(Follow._expression_in_assign2032);
			expression147=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression147.Tree);
			DebugLocation(369, 33);
			ASSIGN148=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign2034); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN148_tree = new AssignNode(ASSIGN148) ;
			root_0 = (object)adaptor.BecomeRoot(ASSIGN148_tree, root_0);
			}
			DebugLocation(369, 35);
			// Plsql.g:369:35: ( NULL | expression )
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==NULL))
			{
				alt27=1;
			}
			else if ((LA27_0==SELF||(LA27_0>=TRUE && LA27_0<=FALSE)||LA27_0==MINUS||LA27_0==NOT||(LA27_0>=ID && LA27_0<=QUOTED_CHAR)||LA27_0==102))
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
				// Plsql.g:369:37: NULL
				{
				DebugLocation(369, 37);
				NULL149=(IToken)Match(input,NULL,Follow._NULL_in_assign2042); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NULL149_tree = new TypeNode(NULL149) ;
				adaptor.AddChild(root_0, NULL149_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:369:54: expression
				{
				DebugLocation(369, 54);
				PushFollow(Follow._expression_in_assign2049);
				expression150=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression150.Tree);

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
		DebugLocation(370, 1);
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
	// Plsql.g:372:1: if_ : IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) ;
	[GrammarRule("if_")]
	private PlsqlParser.if__return if_()
	{
		Enter_if_();
		EnterRule("if_", 39);
		TraceIn("if_", 39);
		PlsqlParser.if__return retval = new PlsqlParser.if__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF151=null;
		IToken THEN153=null;
		IToken ELSE155=null;
		IToken END157=null;
		IToken IF158=null;
		PlsqlParser.expression_return expression152 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock154 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock156 = default(PlsqlParser.codeBlock_return);

		object IF151_tree=null;
		object THEN153_tree=null;
		object ELSE155_tree=null;
		object END157_tree=null;
		object IF158_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "if_");
		DebugLocation(372, 1);
		try
		{
			// Plsql.g:372:5: ( IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) )
			DebugEnterAlt(1);
			// Plsql.g:372:7: IF expression THEN codeBlock ( ELSE codeBlock )? END IF
			{
			DebugLocation(372, 7);
			IF151=(IToken)Match(input,IF,Follow._IF_in_if_2060); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF151);

			DebugLocation(372, 10);
			PushFollow(Follow._expression_in_if_2062);
			expression152=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression152.Tree);
			DebugLocation(372, 21);
			THEN153=(IToken)Match(input,THEN,Follow._THEN_in_if_2064); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_THEN.Add(THEN153);

			DebugLocation(372, 26);
			PushFollow(Follow._codeBlock_in_if_2066);
			codeBlock154=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock154.Tree);
			DebugLocation(372, 36);
			// Plsql.g:372:36: ( ELSE codeBlock )?
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
				// Plsql.g:372:37: ELSE codeBlock
				{
				DebugLocation(372, 37);
				ELSE155=(IToken)Match(input,ELSE,Follow._ELSE_in_if_2069); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE155);

				DebugLocation(372, 42);
				PushFollow(Follow._codeBlock_in_if_2071);
				codeBlock156=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock156.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(372, 54);
			END157=(IToken)Match(input,END,Follow._END_in_if_2075); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END157);

			DebugLocation(372, 58);
			IF158=(IToken)Match(input,IF,Follow._IF_in_if_2077); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF158);



			{
			// AST REWRITE
			// elements: expression, codeBlock, IF, codeBlock
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 373:2: -> ^( IF expression codeBlock ( codeBlock )? )
			{
				DebugLocation(373, 5);
				// Plsql.g:373:5: ^( IF expression codeBlock ( codeBlock )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(373, 7);
				root_1 = (object)adaptor.BecomeRoot(new IfNode(stream_IF.NextToken()), root_1);

				DebugLocation(373, 18);
				adaptor.AddChild(root_1, stream_expression.NextTree());
				DebugLocation(373, 29);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());
				DebugLocation(373, 39);
				// Plsql.g:373:39: ( codeBlock )?
				if ( stream_codeBlock.HasNext )
				{
					DebugLocation(373, 39);
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
		DebugLocation(374, 1);
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
	// Plsql.g:376:1: cycle : ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) );
	[GrammarRule("cycle")]
	private PlsqlParser.cycle_return cycle()
	{
		Enter_cycle();
		EnterRule("cycle", 40);
		TraceIn("cycle", 40);
		PlsqlParser.cycle_return retval = new PlsqlParser.cycle_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE159=null;
		IToken LOOP161=null;
		IToken END163=null;
		IToken LOOP164=null;
		IToken LOOP165=null;
		IToken EXIT167=null;
		IToken WHEN168=null;
		IToken END170=null;
		IToken LOOP171=null;
		PlsqlParser.expression_return expression160 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock162 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock166 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.expression_return expression169 = default(PlsqlParser.expression_return);

		object WHILE159_tree=null;
		object LOOP161_tree=null;
		object END163_tree=null;
		object LOOP164_tree=null;
		object LOOP165_tree=null;
		object EXIT167_tree=null;
		object WHEN168_tree=null;
		object END170_tree=null;
		object LOOP171_tree=null;
		RewriteRuleITokenStream stream_EXIT=new RewriteRuleITokenStream(adaptor,"token EXIT");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_WHEN=new RewriteRuleITokenStream(adaptor,"token WHEN");
		RewriteRuleITokenStream stream_LOOP=new RewriteRuleITokenStream(adaptor,"token LOOP");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "cycle");
		DebugLocation(376, 1);
		try
		{
			// Plsql.g:377:2: ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) )
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
				// Plsql.g:377:4: WHILE expression LOOP codeBlock END LOOP
				{
				DebugLocation(377, 4);
				WHILE159=(IToken)Match(input,WHILE,Follow._WHILE_in_cycle2108); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE159);

				DebugLocation(377, 10);
				PushFollow(Follow._expression_in_cycle2110);
				expression160=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression160.Tree);
				DebugLocation(377, 21);
				LOOP161=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2112); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP161);

				DebugLocation(377, 26);
				PushFollow(Follow._codeBlock_in_cycle2114);
				codeBlock162=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock162.Tree);
				DebugLocation(377, 36);
				END163=(IToken)Match(input,END,Follow._END_in_cycle2116); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END163);

				DebugLocation(377, 40);
				LOOP164=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2118); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP164);



				{
				// AST REWRITE
				// elements: codeBlock, expression, WHILE
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 378:2: -> ^( WHILE expression codeBlock )
				{
					DebugLocation(378, 5);
					// Plsql.g:378:5: ^( WHILE expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(378, 7);
					root_1 = (object)adaptor.BecomeRoot(new WhileNode(stream_WHILE.NextToken()), root_1);

					DebugLocation(378, 24);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(378, 35);
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
				// Plsql.g:379:4: LOOP codeBlock EXIT WHEN expression END LOOP
				{
				DebugLocation(379, 4);
				LOOP165=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2137); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP165);

				DebugLocation(379, 9);
				PushFollow(Follow._codeBlock_in_cycle2139);
				codeBlock166=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock166.Tree);
				DebugLocation(379, 19);
				EXIT167=(IToken)Match(input,EXIT,Follow._EXIT_in_cycle2141); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EXIT.Add(EXIT167);

				DebugLocation(379, 24);
				WHEN168=(IToken)Match(input,WHEN,Follow._WHEN_in_cycle2143); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHEN.Add(WHEN168);

				DebugLocation(379, 29);
				PushFollow(Follow._expression_in_cycle2145);
				expression169=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression169.Tree);
				DebugLocation(379, 40);
				END170=(IToken)Match(input,END,Follow._END_in_cycle2147); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END170);

				DebugLocation(379, 44);
				LOOP171=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2149); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP171);



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
				// 380:2: -> ^( DO expression codeBlock )
				{
					DebugLocation(380, 5);
					// Plsql.g:380:5: ^( DO expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(380, 7);
					root_1 = (object)adaptor.BecomeRoot(new DoWhileNode(DO), root_1);

					DebugLocation(380, 23);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(380, 34);
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
		DebugLocation(381, 1);
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
	// Plsql.g:384:1: expressionList : ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) ;
	[GrammarRule("expressionList")]
	private PlsqlParser.expressionList_return expressionList()
	{
		Enter_expressionList();
		EnterRule("expressionList", 41);
		TraceIn("expressionList", 41);
		PlsqlParser.expressionList_return retval = new PlsqlParser.expressionList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal173=null;
		PlsqlParser.expr__return expr_172 = default(PlsqlParser.expr__return);
		PlsqlParser.expr__return expr_174 = default(PlsqlParser.expr__return);

		object char_literal173_tree=null;
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(384, 1);
		try
		{
			// Plsql.g:385:2: ( ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) )
			DebugEnterAlt(1);
			// Plsql.g:385:4: ( expr_ ( ',' expr_ )* )?
			{
			DebugLocation(385, 4);
			// Plsql.g:385:4: ( expr_ ( ',' expr_ )* )?
			int alt31=2;
			try { DebugEnterSubRule(31);
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if ((LA31_0==SELF||(LA31_0>=TRUE && LA31_0<=FALSE)||LA31_0==MINUS||LA31_0==NOT||(LA31_0>=ID && LA31_0<=QUOTED_CHAR)||LA31_0==102))
			{
				alt31=1;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:385:6: expr_ ( ',' expr_ )*
				{
				DebugLocation(385, 6);
				PushFollow(Follow._expr__in_expressionList2177);
				expr_172=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_.Add(expr_172.Tree);
				DebugLocation(385, 12);
				// Plsql.g:385:12: ( ',' expr_ )*
				try { DebugEnterSubRule(30);
				while (true)
				{
					int alt30=2;
					try { DebugEnterDecision(30, decisionCanBacktrack[30]);
					int LA30_0 = input.LA(1);

					if ((LA30_0==101))
					{
						alt30=1;
					}


					} finally { DebugExitDecision(30); }
					switch ( alt30 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:385:14: ',' expr_
						{
						DebugLocation(385, 14);
						char_literal173=(IToken)Match(input,101,Follow._101_in_expressionList2181); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_101.Add(char_literal173);

						DebugLocation(385, 18);
						PushFollow(Follow._expr__in_expressionList2183);
						expr_174=expr_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_expr_.Add(expr_174.Tree);

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
			// 386:2: -> ^( ExpressionList ( expr_ )* )
			{
				DebugLocation(386, 5);
				// Plsql.g:386:5: ^( ExpressionList ( expr_ )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(386, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ExpressionList, "ExpressionList"), root_1);

				DebugLocation(386, 22);
				// Plsql.g:386:22: ( expr_ )*
				while ( stream_expr_.HasNext )
				{
					DebugLocation(386, 22);
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
		DebugLocation(387, 1);
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
	// Plsql.g:392:1: expression : expr_ -> ^( Expression expr_ ) ;
	[GrammarRule("expression")]
	private PlsqlParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 42);
		TraceIn("expression", 42);
		PlsqlParser.expression_return retval = new PlsqlParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expr__return expr_175 = default(PlsqlParser.expr__return);

		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(392, 1);
		try
		{
			// Plsql.g:393:2: ( expr_ -> ^( Expression expr_ ) )
			DebugEnterAlt(1);
			// Plsql.g:393:4: expr_
			{
			DebugLocation(393, 4);
			PushFollow(Follow._expr__in_expression2212);
			expr_175=expr_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr_.Add(expr_175.Tree);


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
			// 394:2: -> ^( Expression expr_ )
			{
				DebugLocation(394, 5);
				// Plsql.g:394:5: ^( Expression expr_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(394, 7);
				root_1 = (object)adaptor.BecomeRoot(new ExpressionNode(Expression), root_1);

				DebugLocation(394, 34);
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
		DebugLocation(395, 1);
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
	// Plsql.g:397:1: expr_ : ( logicOr )+ ;
	[GrammarRule("expr_")]
	private PlsqlParser.expr__return expr_()
	{
		Enter_expr_();
		EnterRule("expr_", 43);
		TraceIn("expr_", 43);
		PlsqlParser.expr__return retval = new PlsqlParser.expr__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.logicOr_return logicOr176 = default(PlsqlParser.logicOr_return);


		try { DebugEnterRule(GrammarFileName, "expr_");
		DebugLocation(397, 1);
		try
		{
			// Plsql.g:398:2: ( ( logicOr )+ )
			DebugEnterAlt(1);
			// Plsql.g:398:4: ( logicOr )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(398, 4);
			// Plsql.g:398:4: ( logicOr )+
			int cnt32=0;
			try { DebugEnterSubRule(32);
			while (true)
			{
				int alt32=2;
				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
				int LA32_0 = input.LA(1);

				if ((LA32_0==SELF||(LA32_0>=TRUE && LA32_0<=FALSE)||LA32_0==MINUS||LA32_0==NOT||(LA32_0>=ID && LA32_0<=QUOTED_CHAR)||LA32_0==102))
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
					DebugLocation(398, 4);
					PushFollow(Follow._logicOr_in_expr_2235);
					logicOr176=logicOr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicOr176.Tree);

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
		DebugLocation(399, 1);
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
	// Plsql.g:401:1: logicOr : logicAnd ( OR logicAnd )* ;
	[GrammarRule("logicOr")]
	private PlsqlParser.logicOr_return logicOr()
	{
		Enter_logicOr();
		EnterRule("logicOr", 44);
		TraceIn("logicOr", 44);
		PlsqlParser.logicOr_return retval = new PlsqlParser.logicOr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR178=null;
		PlsqlParser.logicAnd_return logicAnd177 = default(PlsqlParser.logicAnd_return);
		PlsqlParser.logicAnd_return logicAnd179 = default(PlsqlParser.logicAnd_return);

		object OR178_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicOr");
		DebugLocation(401, 1);
		try
		{
			// Plsql.g:402:2: ( logicAnd ( OR logicAnd )* )
			DebugEnterAlt(1);
			// Plsql.g:402:4: logicAnd ( OR logicAnd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(402, 4);
			PushFollow(Follow._logicAnd_in_logicOr2247);
			logicAnd177=logicAnd();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd177.Tree);
			DebugLocation(402, 13);
			// Plsql.g:402:13: ( OR logicAnd )*
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
					// Plsql.g:402:15: OR logicAnd
					{
					DebugLocation(402, 25);
					OR178=(IToken)Match(input,OR,Follow._OR_in_logicOr2251); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR178_tree = new OrNode(OR178) ;
					root_0 = (object)adaptor.BecomeRoot(OR178_tree, root_0);
					}
					DebugLocation(402, 27);
					PushFollow(Follow._logicAnd_in_logicOr2257);
					logicAnd179=logicAnd();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd179.Tree);

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
		DebugLocation(403, 1);
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
	// Plsql.g:405:1: logicAnd : equality ( AND equality )* ;
	[GrammarRule("logicAnd")]
	private PlsqlParser.logicAnd_return logicAnd()
	{
		Enter_logicAnd();
		EnterRule("logicAnd", 45);
		TraceIn("logicAnd", 45);
		PlsqlParser.logicAnd_return retval = new PlsqlParser.logicAnd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND181=null;
		PlsqlParser.equality_return equality180 = default(PlsqlParser.equality_return);
		PlsqlParser.equality_return equality182 = default(PlsqlParser.equality_return);

		object AND181_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicAnd");
		DebugLocation(405, 1);
		try
		{
			// Plsql.g:406:2: ( equality ( AND equality )* )
			DebugEnterAlt(1);
			// Plsql.g:406:4: equality ( AND equality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(406, 4);
			PushFollow(Follow._equality_in_logicAnd2270);
			equality180=equality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality180.Tree);
			DebugLocation(406, 13);
			// Plsql.g:406:13: ( AND equality )*
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
					// Plsql.g:406:15: AND equality
					{
					DebugLocation(406, 27);
					AND181=(IToken)Match(input,AND,Follow._AND_in_logicAnd2274); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND181_tree = new AndNode(AND181) ;
					root_0 = (object)adaptor.BecomeRoot(AND181_tree, root_0);
					}
					DebugLocation(406, 29);
					PushFollow(Follow._equality_in_logicAnd2280);
					equality182=equality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality182.Tree);

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
		DebugLocation(407, 1);
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
	// Plsql.g:409:1: equality : inequality ( equalityOperator inequality )* ;
	[GrammarRule("equality")]
	private PlsqlParser.equality_return equality()
	{
		Enter_equality();
		EnterRule("equality", 46);
		TraceIn("equality", 46);
		PlsqlParser.equality_return retval = new PlsqlParser.equality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.inequality_return inequality183 = default(PlsqlParser.inequality_return);
		PlsqlParser.equalityOperator_return equalityOperator184 = default(PlsqlParser.equalityOperator_return);
		PlsqlParser.inequality_return inequality185 = default(PlsqlParser.inequality_return);


		try { DebugEnterRule(GrammarFileName, "equality");
		DebugLocation(409, 1);
		try
		{
			// Plsql.g:410:2: ( inequality ( equalityOperator inequality )* )
			DebugEnterAlt(1);
			// Plsql.g:410:4: inequality ( equalityOperator inequality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(410, 4);
			PushFollow(Follow._inequality_in_equality2293);
			inequality183=inequality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality183.Tree);
			DebugLocation(410, 15);
			// Plsql.g:410:15: ( equalityOperator inequality )*
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
					// Plsql.g:410:17: equalityOperator inequality
					{
					DebugLocation(410, 33);
					PushFollow(Follow._equalityOperator_in_equality2297);
					equalityOperator184=equalityOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(equalityOperator184.Tree, root_0);
					DebugLocation(410, 35);
					PushFollow(Follow._inequality_in_equality2300);
					inequality185=inequality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality185.Tree);

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
		DebugLocation(411, 1);
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
	// Plsql.g:413:1: inequality : add ( ineqOperator add )* ;
	[GrammarRule("inequality")]
	private PlsqlParser.inequality_return inequality()
	{
		Enter_inequality();
		EnterRule("inequality", 47);
		TraceIn("inequality", 47);
		PlsqlParser.inequality_return retval = new PlsqlParser.inequality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.add_return add186 = default(PlsqlParser.add_return);
		PlsqlParser.ineqOperator_return ineqOperator187 = default(PlsqlParser.ineqOperator_return);
		PlsqlParser.add_return add188 = default(PlsqlParser.add_return);


		try { DebugEnterRule(GrammarFileName, "inequality");
		DebugLocation(413, 1);
		try
		{
			// Plsql.g:414:2: ( add ( ineqOperator add )* )
			DebugEnterAlt(1);
			// Plsql.g:414:4: add ( ineqOperator add )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(414, 4);
			PushFollow(Follow._add_in_inequality2313);
			add186=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add186.Tree);
			DebugLocation(414, 8);
			// Plsql.g:414:8: ( ineqOperator add )*
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
					// Plsql.g:414:10: ineqOperator add
					{
					DebugLocation(414, 22);
					PushFollow(Follow._ineqOperator_in_inequality2317);
					ineqOperator187=ineqOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(ineqOperator187.Tree, root_0);
					DebugLocation(414, 24);
					PushFollow(Follow._add_in_inequality2320);
					add188=add();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add188.Tree);

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
		DebugLocation(415, 1);
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
	// Plsql.g:417:1: add : mult ( addOperator mult )* ;
	[GrammarRule("add")]
	private PlsqlParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 48);
		TraceIn("add", 48);
		PlsqlParser.add_return retval = new PlsqlParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.mult_return mult189 = default(PlsqlParser.mult_return);
		PlsqlParser.addOperator_return addOperator190 = default(PlsqlParser.addOperator_return);
		PlsqlParser.mult_return mult191 = default(PlsqlParser.mult_return);


		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(417, 4);
		try
		{
			// Plsql.g:417:5: ( mult ( addOperator mult )* )
			DebugEnterAlt(1);
			// Plsql.g:417:9: mult ( addOperator mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(417, 9);
			PushFollow(Follow._mult_in_add2334);
			mult189=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult189.Tree);
			DebugLocation(417, 14);
			// Plsql.g:417:14: ( addOperator mult )*
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
					// Plsql.g:417:16: addOperator mult
					{
					DebugLocation(417, 27);
					PushFollow(Follow._addOperator_in_add2338);
					addOperator190=addOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperator190.Tree, root_0);
					DebugLocation(417, 29);
					PushFollow(Follow._mult_in_add2341);
					mult191=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult191.Tree);

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
		DebugLocation(418, 4);
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
	// Plsql.g:420:1: mult : cast ( multOperator cast )* ;
	[GrammarRule("mult")]
	private PlsqlParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 49);
		TraceIn("mult", 49);
		PlsqlParser.mult_return retval = new PlsqlParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.cast_return cast192 = default(PlsqlParser.cast_return);
		PlsqlParser.multOperator_return multOperator193 = default(PlsqlParser.multOperator_return);
		PlsqlParser.cast_return cast194 = default(PlsqlParser.cast_return);


		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(420, 1);
		try
		{
			// Plsql.g:420:5: ( cast ( multOperator cast )* )
			DebugEnterAlt(1);
			// Plsql.g:420:9: cast ( multOperator cast )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(420, 9);
			PushFollow(Follow._cast_in_mult2357);
			cast192=cast();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast192.Tree);
			DebugLocation(420, 14);
			// Plsql.g:420:14: ( multOperator cast )*
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
					// Plsql.g:420:16: multOperator cast
					{
					DebugLocation(420, 28);
					PushFollow(Follow._multOperator_in_mult2361);
					multOperator193=multOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperator193.Tree, root_0);
					DebugLocation(420, 30);
					PushFollow(Follow._cast_in_mult2364);
					cast194=cast();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast194.Tree);

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
		DebugLocation(421, 1);
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
	// Plsql.g:423:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );
	[GrammarRule("cast")]
	private PlsqlParser.cast_return cast()
	{
		Enter_cast();
		EnterRule("cast", 50);
		TraceIn("cast", 50);
		PlsqlParser.cast_return retval = new PlsqlParser.cast_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal195=null;
		IToken char_literal197=null;
		PlsqlParser.type_return type196 = default(PlsqlParser.type_return);
		PlsqlParser.unary_return unary198 = default(PlsqlParser.unary_return);
		PlsqlParser.unary_return unary199 = default(PlsqlParser.unary_return);

		object char_literal195_tree=null;
		object char_literal197_tree=null;
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_unary=new RewriteRuleSubtreeStream(adaptor,"rule unary");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "cast");
		DebugLocation(423, 1);
		try
		{
			// Plsql.g:423:5: ( '(' type ')' unary -> ^( Cast unary type ) | unary )
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
			switch (alt39)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:423:7: '(' type ')' unary
				{
				DebugLocation(423, 7);
				char_literal195=(IToken)Match(input,102,Follow._102_in_cast2376); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal195);

				DebugLocation(423, 11);
				PushFollow(Follow._type_in_cast2378);
				type196=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type196.Tree);
				DebugLocation(423, 16);
				char_literal197=(IToken)Match(input,103,Follow._103_in_cast2380); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal197);

				DebugLocation(423, 20);
				PushFollow(Follow._unary_in_cast2382);
				unary198=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_unary.Add(unary198.Tree);


				{
				// AST REWRITE
				// elements: unary, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 424:2: -> ^( Cast unary type )
				{
					DebugLocation(424, 5);
					// Plsql.g:424:5: ^( Cast unary type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(424, 7);
					root_1 = (object)adaptor.BecomeRoot(new CastNode(Cast), root_1);

					DebugLocation(424, 22);
					adaptor.AddChild(root_1, stream_unary.NextTree());
					DebugLocation(424, 28);
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
				// Plsql.g:425:4: unary
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(425, 4);
				PushFollow(Follow._unary_in_cast2401);
				unary199=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary199.Tree);

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
			TraceOut("cast", 50);
			LeaveRule("cast", 50);
			Leave_cast();
		}
		DebugLocation(426, 1);
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
	// Plsql.g:428:1: unary : ( ( unaryOperator unary ) | postfix );
	[GrammarRule("unary")]
	private PlsqlParser.unary_return unary()
	{
		Enter_unary();
		EnterRule("unary", 51);
		TraceIn("unary", 51);
		PlsqlParser.unary_return retval = new PlsqlParser.unary_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.unaryOperator_return unaryOperator200 = default(PlsqlParser.unaryOperator_return);
		PlsqlParser.unary_return unary201 = default(PlsqlParser.unary_return);
		PlsqlParser.postfix_return postfix202 = default(PlsqlParser.postfix_return);


		try { DebugEnterRule(GrammarFileName, "unary");
		DebugLocation(428, 1);
		try
		{
			// Plsql.g:429:2: ( ( unaryOperator unary ) | postfix )
			int alt40=2;
			try { DebugEnterDecision(40, decisionCanBacktrack[40]);
			int LA40_0 = input.LA(1);

			if ((LA40_0==MINUS||LA40_0==NOT))
			{
				alt40=1;
			}
			else if ((LA40_0==SELF||(LA40_0>=TRUE && LA40_0<=FALSE)||(LA40_0>=ID && LA40_0<=QUOTED_CHAR)||LA40_0==102))
			{
				alt40=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 40, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(40); }
			switch (alt40)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:429:4: ( unaryOperator unary )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(429, 4);
				// Plsql.g:429:4: ( unaryOperator unary )
				DebugEnterAlt(1);
				// Plsql.g:429:5: unaryOperator unary
				{
				DebugLocation(429, 18);
				PushFollow(Follow._unaryOperator_in_unary2413);
				unaryOperator200=unaryOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(unaryOperator200.Tree, root_0);
				DebugLocation(429, 20);
				PushFollow(Follow._unary_in_unary2416);
				unary201=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary201.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:430:4: postfix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(430, 4);
				PushFollow(Follow._postfix_in_unary2423);
				postfix202=postfix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfix202.Tree);

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
			TraceOut("unary", 51);
			LeaveRule("unary", 51);
			Leave_unary();
		}
		DebugLocation(431, 1);
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
	// Plsql.g:435:1: postfix : quant ( tmp )* ;
	[GrammarRule("postfix")]
	private PlsqlParser.postfix_return postfix()
	{
		Enter_postfix();
		EnterRule("postfix", 52);
		TraceIn("postfix", 52);
		PlsqlParser.postfix_return retval = new PlsqlParser.postfix_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.quant_return quant203 = default(PlsqlParser.quant_return);
		PlsqlParser.tmp_return tmp204 = default(PlsqlParser.tmp_return);


		try { DebugEnterRule(GrammarFileName, "postfix");
		DebugLocation(435, 1);
		try
		{
			// Plsql.g:436:2: ( quant ( tmp )* )
			DebugEnterAlt(1);
			// Plsql.g:436:4: quant ( tmp )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(436, 4);
			PushFollow(Follow._quant_in_postfix2438);
			quant203=quant();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quant203.Tree);
			DebugLocation(436, 13);
			// Plsql.g:436:13: ( tmp )*
			try { DebugEnterSubRule(41);
			while (true)
			{
				int alt41=2;
				try { DebugEnterDecision(41, decisionCanBacktrack[41]);
				int LA41_0 = input.LA(1);

				if ((LA41_0==100||LA41_0==105))
				{
					alt41=1;
				}


				} finally { DebugExitDecision(41); }
				switch ( alt41 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: tmp
					{
					DebugLocation(436, 13);
					PushFollow(Follow._tmp_in_postfix2440);
					tmp204=tmp();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(tmp204.Tree, root_0);

					}
					break;

				default:
					goto loop41;
				}
			}

			loop41:
				;

			} finally { DebugExitSubRule(41); }


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
			TraceOut("postfix", 52);
			LeaveRule("postfix", 52);
			Leave_postfix();
		}
		DebugLocation(437, 1);
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
	// Plsql.g:439:1: tmp : ( index | methodCall | memberCall );
	[GrammarRule("tmp")]
	private PlsqlParser.tmp_return tmp()
	{
		Enter_tmp();
		EnterRule("tmp", 53);
		TraceIn("tmp", 53);
		PlsqlParser.tmp_return retval = new PlsqlParser.tmp_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.index_return index205 = default(PlsqlParser.index_return);
		PlsqlParser.methodCall_return methodCall206 = default(PlsqlParser.methodCall_return);
		PlsqlParser.memberCall_return memberCall207 = default(PlsqlParser.memberCall_return);


		try { DebugEnterRule(GrammarFileName, "tmp");
		DebugLocation(439, 1);
		try
		{
			// Plsql.g:439:5: ( index | methodCall | memberCall )
			int alt42=3;
			try { DebugEnterDecision(42, decisionCanBacktrack[42]);
			int LA42_0 = input.LA(1);

			if ((LA42_0==105))
			{
				alt42=1;
			}
			else if ((LA42_0==100))
			{
				int LA42_2 = input.LA(2);

				if ((EvaluatePredicate(synpred62_Plsql_fragment)))
				{
					alt42=2;
				}
				else if ((true))
				{
					alt42=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 42, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// Plsql.g:439:7: index
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(439, 7);
				PushFollow(Follow._index_in_tmp2452);
				index205=index();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, index205.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:440:4: methodCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(440, 4);
				PushFollow(Follow._methodCall_in_tmp2457);
				methodCall206=methodCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall206.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:441:4: memberCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(441, 4);
				PushFollow(Follow._memberCall_in_tmp2462);
				memberCall207=memberCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberCall207.Tree);

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
			TraceOut("tmp", 53);
			LeaveRule("tmp", 53);
			Leave_tmp();
		}
		DebugLocation(442, 1);
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
	// Plsql.g:444:1: index : '[' expression ']' -> ^( Index expression ) ;
	[GrammarRule("index")]
	private PlsqlParser.index_return index()
	{
		Enter_index();
		EnterRule("index", 54);
		TraceIn("index", 54);
		PlsqlParser.index_return retval = new PlsqlParser.index_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal208=null;
		IToken char_literal210=null;
		PlsqlParser.expression_return expression209 = default(PlsqlParser.expression_return);

		object char_literal208_tree=null;
		object char_literal210_tree=null;
		RewriteRuleITokenStream stream_106=new RewriteRuleITokenStream(adaptor,"token 106");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "index");
		DebugLocation(444, 1);
		try
		{
			// Plsql.g:445:2: ( '[' expression ']' -> ^( Index expression ) )
			DebugEnterAlt(1);
			// Plsql.g:445:4: '[' expression ']'
			{
			DebugLocation(445, 4);
			char_literal208=(IToken)Match(input,105,Follow._105_in_index2473); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal208);

			DebugLocation(445, 8);
			PushFollow(Follow._expression_in_index2475);
			expression209=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression209.Tree);
			DebugLocation(445, 19);
			char_literal210=(IToken)Match(input,106,Follow._106_in_index2477); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_106.Add(char_literal210);



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
			// 446:2: -> ^( Index expression )
			{
				DebugLocation(446, 5);
				// Plsql.g:446:5: ^( Index expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(446, 7);
				root_1 = (object)adaptor.BecomeRoot(new IndexNode(Index), root_1);

				DebugLocation(446, 24);
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
			TraceOut("index", 54);
			LeaveRule("index", 54);
			Leave_index();
		}
		DebugLocation(447, 1);
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
	// Plsql.g:449:1: memberCall : '.' ID -> ^( MemberCall ID ) ;
	[GrammarRule("memberCall")]
	private PlsqlParser.memberCall_return memberCall()
	{
		Enter_memberCall();
		EnterRule("memberCall", 55);
		TraceIn("memberCall", 55);
		PlsqlParser.memberCall_return retval = new PlsqlParser.memberCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal211=null;
		IToken ID212=null;

		object char_literal211_tree=null;
		object ID212_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");

		try { DebugEnterRule(GrammarFileName, "memberCall");
		DebugLocation(449, 1);
		try
		{
			// Plsql.g:450:2: ( '.' ID -> ^( MemberCall ID ) )
			DebugEnterAlt(1);
			// Plsql.g:450:4: '.' ID
			{
			DebugLocation(450, 4);
			char_literal211=(IToken)Match(input,100,Follow._100_in_memberCall2500); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal211);

			DebugLocation(450, 8);
			ID212=(IToken)Match(input,ID,Follow._ID_in_memberCall2502); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID212);



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
			// 451:2: -> ^( MemberCall ID )
			{
				DebugLocation(451, 5);
				// Plsql.g:451:5: ^( MemberCall ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(451, 7);
				root_1 = (object)adaptor.BecomeRoot(new MemberCallNode(MemberCall), root_1);

				DebugLocation(451, 34);
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
			TraceOut("memberCall", 55);
			LeaveRule("memberCall", 55);
			Leave_memberCall();
		}
		DebugLocation(452, 1);
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
	// Plsql.g:454:1: expressionOrEmpty : ( expression | -> Expression );
	[GrammarRule("expressionOrEmpty")]
	private PlsqlParser.expressionOrEmpty_return expressionOrEmpty()
	{
		Enter_expressionOrEmpty();
		EnterRule("expressionOrEmpty", 56);
		TraceIn("expressionOrEmpty", 56);
		PlsqlParser.expressionOrEmpty_return retval = new PlsqlParser.expressionOrEmpty_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expression_return expression213 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "expressionOrEmpty");
		DebugLocation(454, 1);
		try
		{
			// Plsql.g:455:2: ( expression | -> Expression )
			int alt43=2;
			try { DebugEnterDecision(43, decisionCanBacktrack[43]);
			int LA43_0 = input.LA(1);

			if ((LA43_0==SELF||(LA43_0>=TRUE && LA43_0<=FALSE)||LA43_0==MINUS||LA43_0==NOT||(LA43_0>=ID && LA43_0<=QUOTED_CHAR)||LA43_0==102))
			{
				alt43=1;
			}
			else if ((LA43_0==EOF))
			{
				alt43=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 43, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(43); }
			switch (alt43)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:455:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(455, 4);
				PushFollow(Follow._expression_in_expressionOrEmpty2525);
				expression213=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression213.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:456:4: 
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
				// 456:4: -> Expression
				{
					DebugLocation(456, 7);
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
			TraceOut("expressionOrEmpty", 56);
			LeaveRule("expressionOrEmpty", 56);
			Leave_expressionOrEmpty();
		}
		DebugLocation(457, 1);
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
	// Plsql.g:459:1: methodCall : '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) ;
	[GrammarRule("methodCall")]
	private PlsqlParser.methodCall_return methodCall()
	{
		Enter_methodCall();
		EnterRule("methodCall", 57);
		TraceIn("methodCall", 57);
		PlsqlParser.methodCall_return retval = new PlsqlParser.methodCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal214=null;
		IToken ID215=null;
		IToken char_literal216=null;
		IToken char_literal218=null;
		PlsqlParser.expressionList_return expressionList217 = default(PlsqlParser.expressionList_return);

		object char_literal214_tree=null;
		object ID215_tree=null;
		object char_literal216_tree=null;
		object char_literal218_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "methodCall");
		DebugLocation(459, 1);
		try
		{
			// Plsql.g:460:2: ( '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:460:4: '.' ID '(' expressionList ')'
			{
			DebugLocation(460, 4);
			char_literal214=(IToken)Match(input,100,Follow._100_in_methodCall2543); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal214);

			DebugLocation(460, 8);
			ID215=(IToken)Match(input,ID,Follow._ID_in_methodCall2545); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID215);

			DebugLocation(460, 11);
			char_literal216=(IToken)Match(input,102,Follow._102_in_methodCall2547); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal216);

			DebugLocation(460, 15);
			PushFollow(Follow._expressionList_in_methodCall2549);
			expressionList217=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList217.Tree);
			DebugLocation(460, 30);
			char_literal218=(IToken)Match(input,103,Follow._103_in_methodCall2551); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal218);



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
			// 461:2: -> ^( MethodCall ID expressionList )
			{
				DebugLocation(461, 5);
				// Plsql.g:461:5: ^( MethodCall ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(461, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodCallNode(MethodCall), root_1);

				DebugLocation(461, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(461, 37);
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
			TraceOut("methodCall", 57);
			LeaveRule("methodCall", 57);
			Leave_methodCall();
		}
		DebugLocation(462, 1);
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
	// Plsql.g:464:1: createInstance : ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) ;
	[GrammarRule("createInstance")]
	private PlsqlParser.createInstance_return createInstance()
	{
		Enter_createInstance();
		EnterRule("createInstance", 58);
		TraceIn("createInstance", 58);
		PlsqlParser.createInstance_return retval = new PlsqlParser.createInstance_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID219=null;
		IToken char_literal220=null;
		IToken char_literal222=null;
		PlsqlParser.expressionList_return expressionList221 = default(PlsqlParser.expressionList_return);

		object ID219_tree=null;
		object char_literal220_tree=null;
		object char_literal222_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "createInstance");
		DebugLocation(464, 1);
		try
		{
			// Plsql.g:465:2: ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:465:4: ID '(' expressionList ')'
			{
			DebugLocation(465, 4);
			ID219=(IToken)Match(input,ID,Follow._ID_in_createInstance2576); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID219);

			DebugLocation(465, 7);
			char_literal220=(IToken)Match(input,102,Follow._102_in_createInstance2578); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal220);

			DebugLocation(465, 11);
			PushFollow(Follow._expressionList_in_createInstance2580);
			expressionList221=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList221.Tree);
			DebugLocation(465, 26);
			char_literal222=(IToken)Match(input,103,Follow._103_in_createInstance2582); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal222);



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
			// 466:2: -> ^( CreateInstance ID expressionList )
			{
				DebugLocation(466, 5);
				// Plsql.g:466:5: ^( CreateInstance ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(466, 7);
				root_1 = (object)adaptor.BecomeRoot(new CreateInstanceNode(CreateInstance), root_1);

				DebugLocation(466, 42);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(466, 45);
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
			TraceOut("createInstance", 58);
			LeaveRule("createInstance", 58);
			Leave_createInstance();
		}
		DebugLocation(467, 1);
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
	// Plsql.g:469:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );
	[GrammarRule("quant")]
	private PlsqlParser.quant_return quant()
	{
		Enter_quant();
		EnterRule("quant", 59);
		TraceIn("quant", 59);
		PlsqlParser.quant_return retval = new PlsqlParser.quant_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal228=null;
		IToken char_literal230=null;
		IToken SELF232=null;
		PlsqlParser.number_return number223 = default(PlsqlParser.number_return);
		PlsqlParser.bool__return bool_224 = default(PlsqlParser.bool__return);
		PlsqlParser.string__return string_225 = default(PlsqlParser.string__return);
		PlsqlParser.char__return char_226 = default(PlsqlParser.char__return);
		PlsqlParser.createInstance_return createInstance227 = default(PlsqlParser.createInstance_return);
		PlsqlParser.expr__return expr_229 = default(PlsqlParser.expr__return);
		PlsqlParser.var_return var231 = default(PlsqlParser.var_return);

		object char_literal228_tree=null;
		object char_literal230_tree=null;
		object SELF232_tree=null;

		try { DebugEnterRule(GrammarFileName, "quant");
		DebugLocation(469, 1);
		try
		{
			// Plsql.g:470:2: ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF )
			int alt44=8;
			try { DebugEnterDecision(44, decisionCanBacktrack[44]);
			try
			{
				alt44 = dfa44.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(44); }
			switch (alt44)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:470:4: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(470, 4);
				PushFollow(Follow._number_in_quant2607);
				number223=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number223.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:471:6: bool_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(471, 6);
				PushFollow(Follow._bool__in_quant2614);
				bool_224=bool_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bool_224.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:472:6: string_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(472, 6);
				PushFollow(Follow._string__in_quant2621);
				string_225=string_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_225.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:473:4: char_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(473, 4);
				PushFollow(Follow._char__in_quant2626);
				char_226=char_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_226.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:474:6: createInstance
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(474, 6);
				PushFollow(Follow._createInstance_in_quant2633);
				createInstance227=createInstance();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, createInstance227.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:475:6: '(' expr_ ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(475, 9);
				char_literal228=(IToken)Match(input,102,Follow._102_in_quant2640); if (state.failed) return retval;
				DebugLocation(475, 11);
				PushFollow(Follow._expr__in_quant2643);
				expr_229=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_229.Tree);
				DebugLocation(475, 20);
				char_literal230=(IToken)Match(input,103,Follow._103_in_quant2645); if (state.failed) return retval;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:476:6: var
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(476, 6);
				PushFollow(Follow._var_in_quant2653);
				var231=var();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var231.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Plsql.g:477:6: SELF
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(477, 6);
				SELF232=(IToken)Match(input,SELF,Follow._SELF_in_quant2660); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				SELF232_tree = new SelfNode(SELF232) ;
				adaptor.AddChild(root_0, SELF232_tree);
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
			TraceOut("quant", 59);
			LeaveRule("quant", 59);
			Leave_quant();
		}
		DebugLocation(478, 1);
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
	// Plsql.g:480:1: var : ID -> ^( ID ) ;
	[GrammarRule("var")]
	private PlsqlParser.var_return var()
	{
		Enter_var();
		EnterRule("var", 60);
		TraceIn("var", 60);
		PlsqlParser.var_return retval = new PlsqlParser.var_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID233=null;

		object ID233_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "var");
		DebugLocation(480, 1);
		try
		{
			// Plsql.g:480:5: ( ID -> ^( ID ) )
			DebugEnterAlt(1);
			// Plsql.g:480:7: ID
			{
			DebugLocation(480, 7);
			ID233=(IToken)Match(input,ID,Follow._ID_in_var2673); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID233);



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
			// 481:2: -> ^( ID )
			{
				DebugLocation(481, 5);
				// Plsql.g:481:5: ^( ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(481, 7);
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
			TraceOut("var", 60);
			LeaveRule("var", 60);
			Leave_var();
		}
		DebugLocation(482, 1);
		} finally { DebugExitRule(GrammarFileName, "var"); }
		return retval;

	}
	// $ANTLR end "var"

	partial void Enter_synpred42_Plsql_fragment();
	partial void Leave_synpred42_Plsql_fragment();

	// $ANTLR start synpred42_Plsql
	public void synpred42_Plsql_fragment()
	{
		Enter_synpred42_Plsql_fragment();
		EnterRule("synpred42_Plsql_fragment", 102);
		TraceIn("synpred42_Plsql_fragment", 102);
		try
		{
			// Plsql.g:361:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:361:4: assign
			{
			DebugLocation(361, 4);
			PushFollow(Follow._assign_in_synpred42_Plsql1995);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred42_Plsql_fragment", 102);
			LeaveRule("synpred42_Plsql_fragment", 102);
			Leave_synpred42_Plsql_fragment();
		}
	}
	// $ANTLR end synpred42_Plsql

	partial void Enter_synpred45_Plsql_fragment();
	partial void Leave_synpred45_Plsql_fragment();

	// $ANTLR start synpred45_Plsql
	public void synpred45_Plsql_fragment()
	{
		Enter_synpred45_Plsql_fragment();
		EnterRule("synpred45_Plsql_fragment", 105);
		TraceIn("synpred45_Plsql_fragment", 105);
		try
		{
			// Plsql.g:364:4: ( expression )
			DebugEnterAlt(1);
			// Plsql.g:364:4: expression
			{
			DebugLocation(364, 4);
			PushFollow(Follow._expression_in_synpred45_Plsql2010);
			expression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred45_Plsql_fragment", 105);
			LeaveRule("synpred45_Plsql_fragment", 105);
			Leave_synpred45_Plsql_fragment();
		}
	}
	// $ANTLR end synpred45_Plsql

	partial void Enter_synpred56_Plsql_fragment();
	partial void Leave_synpred56_Plsql_fragment();

	// $ANTLR start synpred56_Plsql
	public void synpred56_Plsql_fragment()
	{
		Enter_synpred56_Plsql_fragment();
		EnterRule("synpred56_Plsql_fragment", 116);
		TraceIn("synpred56_Plsql_fragment", 116);
		try
		{
			// Plsql.g:417:16: ( addOperator mult )
			DebugEnterAlt(1);
			// Plsql.g:417:16: addOperator mult
			{
			DebugLocation(417, 16);
			PushFollow(Follow._addOperator_in_synpred56_Plsql2338);
			addOperator();
			PopFollow();
			if (state.failed) return;
			DebugLocation(417, 29);
			PushFollow(Follow._mult_in_synpred56_Plsql2341);
			mult();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred56_Plsql_fragment", 116);
			LeaveRule("synpred56_Plsql_fragment", 116);
			Leave_synpred56_Plsql_fragment();
		}
	}
	// $ANTLR end synpred56_Plsql

	partial void Enter_synpred58_Plsql_fragment();
	partial void Leave_synpred58_Plsql_fragment();

	// $ANTLR start synpred58_Plsql
	public void synpred58_Plsql_fragment()
	{
		Enter_synpred58_Plsql_fragment();
		EnterRule("synpred58_Plsql_fragment", 118);
		TraceIn("synpred58_Plsql_fragment", 118);
		try
		{
			// Plsql.g:423:7: ( '(' type ')' unary )
			DebugEnterAlt(1);
			// Plsql.g:423:7: '(' type ')' unary
			{
			DebugLocation(423, 7);
			Match(input,102,Follow._102_in_synpred58_Plsql2376); if (state.failed) return;
			DebugLocation(423, 11);
			PushFollow(Follow._type_in_synpred58_Plsql2378);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(423, 16);
			Match(input,103,Follow._103_in_synpred58_Plsql2380); if (state.failed) return;
			DebugLocation(423, 20);
			PushFollow(Follow._unary_in_synpred58_Plsql2382);
			unary();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred58_Plsql_fragment", 118);
			LeaveRule("synpred58_Plsql_fragment", 118);
			Leave_synpred58_Plsql_fragment();
		}
	}
	// $ANTLR end synpred58_Plsql

	partial void Enter_synpred62_Plsql_fragment();
	partial void Leave_synpred62_Plsql_fragment();

	// $ANTLR start synpred62_Plsql
	public void synpred62_Plsql_fragment()
	{
		Enter_synpred62_Plsql_fragment();
		EnterRule("synpred62_Plsql_fragment", 122);
		TraceIn("synpred62_Plsql_fragment", 122);
		try
		{
			// Plsql.g:440:4: ( methodCall )
			DebugEnterAlt(1);
			// Plsql.g:440:4: methodCall
			{
			DebugLocation(440, 4);
			PushFollow(Follow._methodCall_in_synpred62_Plsql2457);
			methodCall();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred62_Plsql_fragment", 122);
			LeaveRule("synpred62_Plsql_fragment", 122);
			Leave_synpred62_Plsql_fragment();
		}
	}
	// $ANTLR end synpred62_Plsql

	partial void Enter_synpred68_Plsql_fragment();
	partial void Leave_synpred68_Plsql_fragment();

	// $ANTLR start synpred68_Plsql
	public void synpred68_Plsql_fragment()
	{
		Enter_synpred68_Plsql_fragment();
		EnterRule("synpred68_Plsql_fragment", 128);
		TraceIn("synpred68_Plsql_fragment", 128);
		try
		{
			// Plsql.g:474:6: ( createInstance )
			DebugEnterAlt(1);
			// Plsql.g:474:6: createInstance
			{
			DebugLocation(474, 6);
			PushFollow(Follow._createInstance_in_synpred68_Plsql2633);
			createInstance();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred68_Plsql_fragment", 128);
			LeaveRule("synpred68_Plsql_fragment", 128);
			Leave_synpred68_Plsql_fragment();
		}
	}
	// $ANTLR end synpred68_Plsql

	partial void Enter_synpred70_Plsql_fragment();
	partial void Leave_synpred70_Plsql_fragment();

	// $ANTLR start synpred70_Plsql
	public void synpred70_Plsql_fragment()
	{
		Enter_synpred70_Plsql_fragment();
		EnterRule("synpred70_Plsql_fragment", 130);
		TraceIn("synpred70_Plsql_fragment", 130);
		try
		{
			// Plsql.g:476:6: ( var )
			DebugEnterAlt(1);
			// Plsql.g:476:6: var
			{
			DebugLocation(476, 6);
			PushFollow(Follow._var_in_synpred70_Plsql2653);
			var();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred70_Plsql_fragment", 130);
			LeaveRule("synpred70_Plsql_fragment", 130);
			Leave_synpred70_Plsql_fragment();
		}
	}
	// $ANTLR end synpred70_Plsql
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
	DFA39 dfa39;
	DFA44 dfa44;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa26 = new DFA26( this, SpecialStateTransition26 );
		dfa37 = new DFA37( this, SpecialStateTransition37 );
		dfa39 = new DFA39( this, SpecialStateTransition39 );
		dfa44 = new DFA44( this, SpecialStateTransition44 );
	}

	private class DFA26 : DFA
	{
		private const string DFA26_eotS =
			"\x12\xFFFF";
		private const string DFA26_eofS =
			"\x12\xFFFF";
		private const string DFA26_minS =
			"\x1\x2A\xB\x0\x6\xFFFF";
		private const string DFA26_maxS =
			"\x1\x66\xB\x0\x6\xFFFF";
		private const string DFA26_acceptS =
			"\xC\xFFFF\x1\x2\x1\x3\x1\xFFFF\x1\x5\x1\x1\x1\x4";
		private const string DFA26_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x6\xFFFF}>";
		private static readonly string[] DFA26_transitionS =
			{
				"\x1\xC\x3\xFFFF\x2\xD\x15\xFFFF\x1\xB\x2\xFFFF\x1\x6\x1\x7\x1\xF\x1"+
				"\xFFFF\x1\x2\xB\xFFFF\x1\x3\x5\xFFFF\x1\xA\x1\x4\x1\x5\x1\x8\x1\x9\x3"+
				"\xFFFF\x1\x1",
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

		public override string Description { get { return "360:1: command : ( assign | if_ | cycle | expression | RETURN expression );"; } }

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
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA26_2 = input.LA(1);


				int index26_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA26_3 = input.LA(1);


				int index26_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA26_4 = input.LA(1);


				int index26_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA26_5 = input.LA(1);


				int index26_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA26_6 = input.LA(1);


				int index26_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA26_7 = input.LA(1);


				int index26_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA26_8 = input.LA(1);


				int index26_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA26_9 = input.LA(1);


				int index26_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA26_10 = input.LA(1);


				int index26_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


				input.Seek(index26_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA26_11 = input.LA(1);


				int index26_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred42_Plsql_fragment)) ) {s = 16;}

				else if ( (EvaluatePredicate(synpred45_Plsql_fragment)) ) {s = 17;}


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
			"\x1\x2B\x12\xFFFF\x1\x0\xA\xFFFF";
		private const string DFA37_maxS =
			"\x1\x6A\x12\xFFFF\x1\x0\xA\xFFFF";
		private const string DFA37_acceptS =
			"\x1\xFFFF\x1\x2\x1B\xFFFF\x1\x1";
		private const string DFA37_specialS =
			"\x13\xFFFF\x1\x0\xA\xFFFF}>";
		private static readonly string[] DFA37_transitionS =
			{
				"\x1\x1\x3\xFFFF\x1\x1\x12\xFFFF\x1\x1\x2\xFFFF\x1\x1\x2\xFFFF\x2\x1"+
				"\x1\xFFFF\x1\x1D\x1\x13\x3\xFFFF\xA\x1\x4\xFFFF\x5\x1\x2\xFFFF\x4\x1"+
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

		public override string Description { get { return "()* loopback of 417:14: ( addOperator mult )*"; } }

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
				int LA37_19 = input.LA(1);


				int index37_19 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred56_Plsql_fragment)) ) {s = 29;}

				else if ( (true) ) {s = 1;}


				input.Seek(index37_19);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 37, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA39 : DFA
	{
		private const string DFA39_eotS =
			"\xD\xFFFF";
		private const string DFA39_eofS =
			"\xD\xFFFF";
		private const string DFA39_minS =
			"\x1\x45\x1\x0\xB\xFFFF";
		private const string DFA39_maxS =
			"\x1\x66\x1\x0\xB\xFFFF";
		private const string DFA39_acceptS =
			"\x2\xFFFF\x1\x2\x9\xFFFF\x1\x1";
		private const string DFA39_specialS =
			"\x1\xFFFF\x1\x0\xB\xFFFF}>";
		private static readonly string[] DFA39_transitionS =
			{
				"\x1\x2\x2\xFFFF\x2\x2\x2\xFFFF\x1\x2\xB\xFFFF\x1\x2\x5\xFFFF\x5\x2"+
				"\x3\xFFFF\x1\x1",
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

		public override string Description { get { return "423:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );"; } }

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
				int LA39_1 = input.LA(1);


				int index39_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred58_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 2;}


				input.Seek(index39_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 39, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA44 : DFA
	{
		private const string DFA44_eotS =
			"\xC\xFFFF";
		private const string DFA44_eofS =
			"\xC\xFFFF";
		private const string DFA44_minS =
			"\x1\x45\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA44_maxS =
			"\x1\x66\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA44_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x2\x1\xFFFF\x1\x3\x1\x4\x1\xFFFF\x1\x6\x1"+
			"\x8\x1\x5\x1\x7";
		private const string DFA44_specialS =
			"\x7\xFFFF\x1\x0\x4\xFFFF}>";
		private static readonly string[] DFA44_transitionS =
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

		private static readonly short[] DFA44_eot = DFA.UnpackEncodedString(DFA44_eotS);
		private static readonly short[] DFA44_eof = DFA.UnpackEncodedString(DFA44_eofS);
		private static readonly char[] DFA44_min = DFA.UnpackEncodedStringToUnsignedChars(DFA44_minS);
		private static readonly char[] DFA44_max = DFA.UnpackEncodedStringToUnsignedChars(DFA44_maxS);
		private static readonly short[] DFA44_accept = DFA.UnpackEncodedString(DFA44_acceptS);
		private static readonly short[] DFA44_special = DFA.UnpackEncodedString(DFA44_specialS);
		private static readonly short[][] DFA44_transition;

		static DFA44()
		{
			int numStates = DFA44_transitionS.Length;
			DFA44_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA44_transition[i] = DFA.UnpackEncodedString(DFA44_transitionS[i]);
			}
		}

		public DFA44( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 44;
			this.eot = DFA44_eot;
			this.eof = DFA44_eof;
			this.min = DFA44_min;
			this.max = DFA44_max;
			this.accept = DFA44_accept;
			this.special = DFA44_special;
			this.transition = DFA44_transition;
		}

		public override string Description { get { return "469:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition44(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA44_7 = input.LA(1);


				int index44_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred68_Plsql_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred70_Plsql_fragment)) ) {s = 11;}


				input.Seek(index44_7);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 44, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _REAL_in_float_757 = new BitSet(new ulong[]{0x0UL,0x800000000UL});
		public static readonly BitSet _99_in_float_759 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_bool_778 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_bool_790 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTED_STRING_in_string_867 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTED_CHAR_in_char_881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INTEGER_in_number895 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REAL_in_number907 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _float__in_number919 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_type930 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BYTE_in_type942 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_type954 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DOUBLE_in_type966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BOOL_in_type980 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type994 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_type996 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_type998 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1020 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objOrPack_in_program1040 = new BitSet(new ulong[]{0x8000000000000UL,0x10UL});
		public static readonly BitSet _entryPoint_in_program1043 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _object__in_objOrPack1066 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _package__in_objOrPack1072 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_isOrAs0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_in_equalityOperator1102 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEQUAL_in_equalityOperator1114 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MORE_in_ineqOperator1132 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_in_ineqOperator1144 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOREEQ_in_ineqOperator1156 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESSEQ_in_ineqOperator1168 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PLUS_in_addOperator1186 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_addOperator1198 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MULT_in_multOperator1216 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DIVIDE_in_multOperator1228 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOD_in_multOperator1240 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_assignOperator0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_unaryOperator1289 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_unaryOperator1301 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varDef1322 = new BitSet(new ulong[]{0x7C00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_varDef1324 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_varList1352 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _101_in_varList1356 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _varDef_in_varList1358 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _procDecl_in_methodDecl1384 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcDecl_in_methodDecl1389 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MEMBER_in_methodModifier1400 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STATIC_in_methodModifier1405 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_procDecl1423 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _PROCEDURE_in_procDecl1425 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_procDecl1427 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_procDecl1429 = new BitSet(new ulong[]{0x0UL,0x8040000000UL});
		public static readonly BitSet _varList_in_procDecl1431 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_procDecl1433 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_funcDecl1465 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _FUNCTION_in_funcDecl1467 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_funcDecl1469 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_funcDecl1471 = new BitSet(new ulong[]{0x0UL,0x8040000000UL});
		public static readonly BitSet _varList_in_funcDecl1473 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_funcDecl1475 = new BitSet(new ulong[]{0x0UL,0x400UL});
		public static readonly BitSet _RETURN_in_funcDecl1477 = new BitSet(new ulong[]{0x7C00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_funcDecl1479 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_methodDef1508 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_methodDef1510 = new BitSet(new ulong[]{0x0UL,0x40000002UL});
		public static readonly BitSet _declareBlock_in_methodDef1512 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _BEGIN_in_methodDef1514 = new BitSet(new ulong[]{0xC40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_methodDef1516 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_methodDef1518 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1545 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_typeDecl1547 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1549 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _TABLE_in_typeDecl1551 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _OF_in_typeDecl1553 = new BitSet(new ulong[]{0x7C00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_typeDecl1555 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1574 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_typeDecl1576 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1578 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _RECORD_in_typeDecl1580 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_typeDecl1582 = new BitSet(new ulong[]{0x0UL,0x8040000000UL});
		public static readonly BitSet _varList_in_typeDecl1584 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_typeDecl1586 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectDecl_in_object_1613 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectBody_in_object_1618 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectDecl1629 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectDecl1631 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_objectDecl1633 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectDecl1635 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectDecl1637 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectDecl1639 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _objectDeclItem_in_objectDecl1641 = new BitSet(new ulong[]{0x8060000000000000UL,0x8040000001UL});
		public static readonly BitSet _103_in_objectDecl1644 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDecl1646 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectBody1672 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectBody1674 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_objectBody1676 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_objectBody1678 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectBody1680 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectBody1682 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _methodDef_in_objectBody1686 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectBody1688 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_objectBody1693 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectBody1695 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_objectDeclItem1721 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDeclItem1723 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_objectDeclItem1729 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDeclItem1731 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDecl_in_package_1746 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDef_in_package_1751 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDecl1762 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _PACKAGE_in_packageDecl1764 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_packageDecl1766 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDecl1768 = new BitSet(new ulong[]{0x8060020000000000UL,0x40000001UL});
		public static readonly BitSet _packageDeclItem_in_packageDecl1770 = new BitSet(new ulong[]{0x8060020000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_packageDecl1773 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDecl1775 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDef1802 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _PACKAGE_in_packageDef1804 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_packageDef1806 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_packageDef1808 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDef1810 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _packageBodyItem_in_packageDef1812 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_packageDef1815 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDef1817 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_packageDeclItem1843 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1845 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_packageDeclItem1851 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1853 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_packageDeclItem1859 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1861 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDef_in_packageBodyItem1873 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageBodyItem1875 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DECLARE_in_entryPoint1890 = new BitSet(new ulong[]{0x0UL,0x40000002UL});
		public static readonly BitSet _declareBlock_in_entryPoint1892 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _BEGIN_in_entryPoint1894 = new BitSet(new ulong[]{0xC40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_entryPoint1896 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_entryPoint1898 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_entryPoint1900 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declareItem_in_declareBlock1926 = new BitSet(new ulong[]{0x2UL,0x40000000UL});
		public static readonly BitSet _varDef_in_declareItem1951 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_declareItem1953 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _command_in_codeBlock1967 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_codeBlock1969 = new BitSet(new ulong[]{0xC40000000002UL,0x47C1001720UL});
		public static readonly BitSet _assign_in_command1995 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if__in_command2000 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cycle_in_command2005 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_command2010 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_command2015 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_command2021 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2032 = new BitSet(new ulong[]{0x0UL,0x2000000UL});
		public static readonly BitSet _ASSIGN_in_assign2034 = new BitSet(new ulong[]{0x0UL,0x47C1001360UL});
		public static readonly BitSet _NULL_in_assign2042 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2049 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_if_2060 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_if_2062 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _THEN_in_if_2064 = new BitSet(new ulong[]{0xD40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_if_2066 = new BitSet(new ulong[]{0x100000000000UL,0x4UL});
		public static readonly BitSet _ELSE_in_if_2069 = new BitSet(new ulong[]{0xC40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_if_2071 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_if_2075 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _IF_in_if_2077 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_cycle2108 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_cycle2110 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2112 = new BitSet(new ulong[]{0xC40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_cycle2114 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2116 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2118 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LOOP_in_cycle2137 = new BitSet(new ulong[]{0x1C40000000000UL,0x47C1001720UL});
		public static readonly BitSet _codeBlock_in_cycle2139 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _EXIT_in_cycle2141 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _WHEN_in_cycle2143 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_cycle2145 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2147 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2149 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr__in_expressionList2177 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _101_in_expressionList2181 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expr__in_expressionList2183 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _expr__in_expression2212 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicOr_in_expr_2235 = new BitSet(new ulong[]{0x2UL,0x47C1001320UL});
		public static readonly BitSet _logicAnd_in_logicOr2247 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _OR_in_logicOr2251 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _logicAnd_in_logicOr2257 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _equality_in_logicAnd2270 = new BitSet(new ulong[]{0x2UL,0x10000UL});
		public static readonly BitSet _AND_in_logicAnd2274 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _equality_in_logicAnd2280 = new BitSet(new ulong[]{0x2UL,0x10000UL});
		public static readonly BitSet _inequality_in_equality2293 = new BitSet(new ulong[]{0x2UL,0xC0000UL});
		public static readonly BitSet _equalityOperator_in_equality2297 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _inequality_in_equality2300 = new BitSet(new ulong[]{0x2UL,0xC0000UL});
		public static readonly BitSet _add_in_inequality2313 = new BitSet(new ulong[]{0x2UL,0xF00000UL});
		public static readonly BitSet _ineqOperator_in_inequality2317 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _add_in_inequality2320 = new BitSet(new ulong[]{0x2UL,0xF00000UL});
		public static readonly BitSet _mult_in_add2334 = new BitSet(new ulong[]{0x2UL,0x1800UL});
		public static readonly BitSet _addOperator_in_add2338 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _mult_in_add2341 = new BitSet(new ulong[]{0x2UL,0x1800UL});
		public static readonly BitSet _cast_in_mult2357 = new BitSet(new ulong[]{0x2UL,0xE000UL});
		public static readonly BitSet _multOperator_in_mult2361 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _cast_in_mult2364 = new BitSet(new ulong[]{0x2UL,0xE000UL});
		public static readonly BitSet _102_in_cast2376 = new BitSet(new ulong[]{0x7C00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_cast2378 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_cast2380 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _unary_in_cast2382 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unary_in_cast2401 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryOperator_in_unary2413 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _unary_in_unary2416 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _postfix_in_unary2423 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quant_in_postfix2438 = new BitSet(new ulong[]{0x2UL,0x21000000000UL});
		public static readonly BitSet _tmp_in_postfix2440 = new BitSet(new ulong[]{0x2UL,0x21000000000UL});
		public static readonly BitSet _index_in_tmp2452 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_tmp2457 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberCall_in_tmp2462 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _105_in_index2473 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_index2475 = new BitSet(new ulong[]{0x0UL,0x40000000000UL});
		public static readonly BitSet _106_in_index2477 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _100_in_memberCall2500 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_memberCall2502 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressionOrEmpty2525 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _100_in_methodCall2543 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_methodCall2545 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_methodCall2547 = new BitSet(new ulong[]{0x0UL,0xC7C1001320UL});
		public static readonly BitSet _expressionList_in_methodCall2549 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_methodCall2551 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_createInstance2576 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2578 = new BitSet(new ulong[]{0x0UL,0xC7C1001320UL});
		public static readonly BitSet _expressionList_in_createInstance2580 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2582 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_quant2607 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bool__in_quant2614 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _string__in_quant2621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _char__in_quant2626 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_quant2633 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_quant2640 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expr__in_quant2643 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_quant2645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_quant2653 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SELF_in_quant2660 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_var2673 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred42_Plsql1995 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_synpred45_Plsql2010 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _addOperator_in_synpred56_Plsql2338 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _mult_in_synpred56_Plsql2341 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_synpred58_Plsql2376 = new BitSet(new ulong[]{0x7C00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_synpred58_Plsql2378 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_synpred58_Plsql2380 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _unary_in_synpred58_Plsql2382 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_synpred62_Plsql2457 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_synpred68_Plsql2633 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_synpred70_Plsql2653 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  plsql_msil 
