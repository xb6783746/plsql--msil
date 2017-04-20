// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-20 16:38:50

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
				false, false, false, false, false, true, false, false, false, true, 
				false, false, false, false, false, false, false, true, false, true, 
				false, false, true, false, true, , 
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
	// Plsql.g:177:1: type : ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | ID -> ID );
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
		IToken ID19=null;

		object INT10_tree=null;
		object BYTE11_tree=null;
		object CHAR12_tree=null;
		object DOUBLE13_tree=null;
		object STRING14_tree=null;
		object BOOL15_tree=null;
		object ID16_tree=null;
		object char_literal17_tree=null;
		object ID18_tree=null;
		object ID19_tree=null;
		RewriteRuleITokenStream stream_CHAR=new RewriteRuleITokenStream(adaptor,"token CHAR");
		RewriteRuleITokenStream stream_DOUBLE=new RewriteRuleITokenStream(adaptor,"token DOUBLE");
		RewriteRuleITokenStream stream_BYTE=new RewriteRuleITokenStream(adaptor,"token BYTE");
		RewriteRuleITokenStream stream_INT=new RewriteRuleITokenStream(adaptor,"token INT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleITokenStream stream_STRING=new RewriteRuleITokenStream(adaptor,"token STRING");
		RewriteRuleITokenStream stream_BOOL=new RewriteRuleITokenStream(adaptor,"token BOOL");

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(177, 1);
		try
		{
			// Plsql.g:178:2: ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | ID -> ID )
			int alt3=8;
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			try
			{
				alt3 = dfa3.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
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
				// Plsql.g:182:4: STRING
				{
				DebugLocation(182, 4);
				STRING14=(IToken)Match(input,STRING,Follow._STRING_in_type978); if (state.failed) return retval; 
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
				// 182:11: -> STRING
				{
					DebugLocation(182, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_STRING.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:183:6: BOOL
				{
				DebugLocation(183, 6);
				BOOL15=(IToken)Match(input,BOOL,Follow._BOOL_in_type992); if (state.failed) return retval; 
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
				// 183:11: -> BOOL
				{
					DebugLocation(183, 14);
					adaptor.AddChild(root_0, new TypeNode(stream_BOOL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:184:6: ID '.' ID
				{
				DebugLocation(184, 6);
				ID16=(IToken)Match(input,ID,Follow._ID_in_type1006); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID16);

				DebugLocation(184, 9);
				char_literal17=(IToken)Match(input,100,Follow._100_in_type1008); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_100.Add(char_literal17);

				DebugLocation(184, 13);
				ID18=(IToken)Match(input,ID,Follow._ID_in_type1010); if (state.failed) return retval; 
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
				// 185:2: -> ^( TypeName ID ID )
				{
					DebugLocation(185, 6);
					// Plsql.g:185:6: ^( TypeName ID ID )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(185, 8);
					root_1 = (object)adaptor.BecomeRoot(new TypeNode(TypeName), root_1);

					DebugLocation(185, 27);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(185, 30);
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
				// Plsql.g:186:6: ID
				{
				DebugLocation(186, 6);
				ID19=(IToken)Match(input,ID,Follow._ID_in_type1032); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID19);



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
				// 186:9: -> ID
				{
					DebugLocation(186, 12);
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
		DebugLocation(187, 1);
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
	// Plsql.g:189:8: public program : ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) ;
	[GrammarRule("program")]
	public PlsqlParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 7);
		TraceIn("program", 7);
		PlsqlParser.program_return retval = new PlsqlParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objOrPack_return objOrPack20 = default(PlsqlParser.objOrPack_return);
		PlsqlParser.entryPoint_return entryPoint21 = default(PlsqlParser.entryPoint_return);

		RewriteRuleSubtreeStream stream_objOrPack=new RewriteRuleSubtreeStream(adaptor,"rule objOrPack");
		RewriteRuleSubtreeStream stream_entryPoint=new RewriteRuleSubtreeStream(adaptor,"rule entryPoint");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(189, 1);
		try
		{
			// Plsql.g:190:2: ( ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) )
			DebugEnterAlt(1);
			// Plsql.g:190:4: ( objOrPack )* entryPoint
			{
			DebugLocation(190, 4);
			// Plsql.g:190:4: ( objOrPack )*
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
					DebugLocation(190, 4);
					PushFollow(Follow._objOrPack_in_program1052);
					objOrPack20=objOrPack();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objOrPack.Add(objOrPack20.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(190, 15);
			PushFollow(Follow._entryPoint_in_program1055);
			entryPoint21=entryPoint();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_entryPoint.Add(entryPoint21.Tree);


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
			// 191:2: -> ^( Program ( objOrPack )* entryPoint )
			{
				DebugLocation(191, 5);
				// Plsql.g:191:5: ^( Program ( objOrPack )* entryPoint )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(191, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(Program, "Program"), root_1);

				DebugLocation(191, 15);
				// Plsql.g:191:15: ( objOrPack )*
				while ( stream_objOrPack.HasNext )
				{
					DebugLocation(191, 15);
					adaptor.AddChild(root_1, stream_objOrPack.NextTree());

				}
				stream_objOrPack.Reset();
				DebugLocation(191, 26);
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
		DebugLocation(192, 1);
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
	// Plsql.g:194:1: objOrPack : ( object_ | package_ );
	[GrammarRule("objOrPack")]
	private PlsqlParser.objOrPack_return objOrPack()
	{
		Enter_objOrPack();
		EnterRule("objOrPack", 8);
		TraceIn("objOrPack", 8);
		PlsqlParser.objOrPack_return retval = new PlsqlParser.objOrPack_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.object__return object_22 = default(PlsqlParser.object__return);
		PlsqlParser.package__return package_23 = default(PlsqlParser.package__return);


		try { DebugEnterRule(GrammarFileName, "objOrPack");
		DebugLocation(194, 1);
		try
		{
			// Plsql.g:195:2: ( object_ | package_ )
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
				// Plsql.g:195:4: object_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(195, 4);
				PushFollow(Follow._object__in_objOrPack1078);
				object_22=object_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_22.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:196:4: package_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(196, 4);
				PushFollow(Follow._package__in_objOrPack1084);
				package_23=package_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, package_23.Tree);

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
		DebugLocation(197, 1);
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
	// Plsql.g:199:1: isOrAs : ( IS | AS );
	[GrammarRule("isOrAs")]
	private PlsqlParser.isOrAs_return isOrAs()
	{
		Enter_isOrAs();
		EnterRule("isOrAs", 9);
		TraceIn("isOrAs", 9);
		PlsqlParser.isOrAs_return retval = new PlsqlParser.isOrAs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set24=null;

		object set24_tree=null;

		try { DebugEnterRule(GrammarFileName, "isOrAs");
		DebugLocation(199, 1);
		try
		{
			// Plsql.g:200:2: ( IS | AS )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(200, 2);
			set24=(IToken)input.LT(1);
			if ((input.LA(1)>=IS && input.LA(1)<=AS))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set24));
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
		DebugLocation(202, 1);
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
	// Plsql.g:206:1: equalityOperator : ( EQUAL -> EQUAL | NEQUAL -> NEQUAL );
	[GrammarRule("equalityOperator")]
	private PlsqlParser.equalityOperator_return equalityOperator()
	{
		Enter_equalityOperator();
		EnterRule("equalityOperator", 10);
		TraceIn("equalityOperator", 10);
		PlsqlParser.equalityOperator_return retval = new PlsqlParser.equalityOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EQUAL25=null;
		IToken NEQUAL26=null;

		object EQUAL25_tree=null;
		object NEQUAL26_tree=null;
		RewriteRuleITokenStream stream_NEQUAL=new RewriteRuleITokenStream(adaptor,"token NEQUAL");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");

		try { DebugEnterRule(GrammarFileName, "equalityOperator");
		DebugLocation(206, 1);
		try
		{
			// Plsql.g:207:2: ( EQUAL -> EQUAL | NEQUAL -> NEQUAL )
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
				// Plsql.g:207:4: EQUAL
				{
				DebugLocation(207, 4);
				EQUAL25=(IToken)Match(input,EQUAL,Follow._EQUAL_in_equalityOperator1114); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL25);



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
				// 207:10: -> EQUAL
				{
					DebugLocation(207, 13);
					adaptor.AddChild(root_0, new EqualNode(stream_EQUAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:208:4: NEQUAL
				{
				DebugLocation(208, 4);
				NEQUAL26=(IToken)Match(input,NEQUAL,Follow._NEQUAL_in_equalityOperator1126); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NEQUAL.Add(NEQUAL26);



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
				// 208:11: -> NEQUAL
				{
					DebugLocation(208, 14);
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
		DebugLocation(209, 1);
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
	// Plsql.g:211:1: ineqOperator : ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ );
	[GrammarRule("ineqOperator")]
	private PlsqlParser.ineqOperator_return ineqOperator()
	{
		Enter_ineqOperator();
		EnterRule("ineqOperator", 11);
		TraceIn("ineqOperator", 11);
		PlsqlParser.ineqOperator_return retval = new PlsqlParser.ineqOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MORE27=null;
		IToken LESS28=null;
		IToken MOREEQ29=null;
		IToken LESSEQ30=null;

		object MORE27_tree=null;
		object LESS28_tree=null;
		object MOREEQ29_tree=null;
		object LESSEQ30_tree=null;
		RewriteRuleITokenStream stream_MOREEQ=new RewriteRuleITokenStream(adaptor,"token MOREEQ");
		RewriteRuleITokenStream stream_LESSEQ=new RewriteRuleITokenStream(adaptor,"token LESSEQ");
		RewriteRuleITokenStream stream_MORE=new RewriteRuleITokenStream(adaptor,"token MORE");
		RewriteRuleITokenStream stream_LESS=new RewriteRuleITokenStream(adaptor,"token LESS");

		try { DebugEnterRule(GrammarFileName, "ineqOperator");
		DebugLocation(211, 1);
		try
		{
			// Plsql.g:212:2: ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ )
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
				// Plsql.g:212:4: MORE
				{
				DebugLocation(212, 4);
				MORE27=(IToken)Match(input,MORE,Follow._MORE_in_ineqOperator1144); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MORE.Add(MORE27);



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
				// 212:9: -> MORE
				{
					DebugLocation(212, 12);
					adaptor.AddChild(root_0, new GreaterNode(stream_MORE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:213:4: LESS
				{
				DebugLocation(213, 4);
				LESS28=(IToken)Match(input,LESS,Follow._LESS_in_ineqOperator1156); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESS.Add(LESS28);



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
				// 213:9: -> LESS
				{
					DebugLocation(213, 12);
					adaptor.AddChild(root_0, new LessNode(stream_LESS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:214:4: MOREEQ
				{
				DebugLocation(214, 4);
				MOREEQ29=(IToken)Match(input,MOREEQ,Follow._MOREEQ_in_ineqOperator1168); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOREEQ.Add(MOREEQ29);



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
				// 214:11: -> MOREEQ
				{
					DebugLocation(214, 14);
					adaptor.AddChild(root_0, new GreaterOrEqualNode(stream_MOREEQ.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:215:4: LESSEQ
				{
				DebugLocation(215, 4);
				LESSEQ30=(IToken)Match(input,LESSEQ,Follow._LESSEQ_in_ineqOperator1180); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESSEQ.Add(LESSEQ30);



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
				// 215:11: -> LESSEQ
				{
					DebugLocation(215, 14);
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
		DebugLocation(216, 1);
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
	// Plsql.g:218:1: addOperator : ( PLUS -> PLUS | MINUS -> MINUS );
	[GrammarRule("addOperator")]
	private PlsqlParser.addOperator_return addOperator()
	{
		Enter_addOperator();
		EnterRule("addOperator", 12);
		TraceIn("addOperator", 12);
		PlsqlParser.addOperator_return retval = new PlsqlParser.addOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PLUS31=null;
		IToken MINUS32=null;

		object PLUS31_tree=null;
		object MINUS32_tree=null;
		RewriteRuleITokenStream stream_PLUS=new RewriteRuleITokenStream(adaptor,"token PLUS");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "addOperator");
		DebugLocation(218, 1);
		try
		{
			// Plsql.g:219:2: ( PLUS -> PLUS | MINUS -> MINUS )
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
				// Plsql.g:219:4: PLUS
				{
				DebugLocation(219, 4);
				PLUS31=(IToken)Match(input,PLUS,Follow._PLUS_in_addOperator1198); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_PLUS.Add(PLUS31);



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
				// 219:9: -> PLUS
				{
					DebugLocation(219, 12);
					adaptor.AddChild(root_0, new PlusNode(stream_PLUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:220:4: MINUS
				{
				DebugLocation(220, 4);
				MINUS32=(IToken)Match(input,MINUS,Follow._MINUS_in_addOperator1210); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS32);



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
				// 220:10: -> MINUS
				{
					DebugLocation(220, 13);
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
		DebugLocation(221, 1);
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
	// Plsql.g:223:1: multOperator : ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD );
	[GrammarRule("multOperator")]
	private PlsqlParser.multOperator_return multOperator()
	{
		Enter_multOperator();
		EnterRule("multOperator", 13);
		TraceIn("multOperator", 13);
		PlsqlParser.multOperator_return retval = new PlsqlParser.multOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MULT33=null;
		IToken DIVIDE34=null;
		IToken MOD35=null;

		object MULT33_tree=null;
		object DIVIDE34_tree=null;
		object MOD35_tree=null;
		RewriteRuleITokenStream stream_MULT=new RewriteRuleITokenStream(adaptor,"token MULT");
		RewriteRuleITokenStream stream_MOD=new RewriteRuleITokenStream(adaptor,"token MOD");
		RewriteRuleITokenStream stream_DIVIDE=new RewriteRuleITokenStream(adaptor,"token DIVIDE");

		try { DebugEnterRule(GrammarFileName, "multOperator");
		DebugLocation(223, 1);
		try
		{
			// Plsql.g:224:2: ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD )
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
				// Plsql.g:224:4: MULT
				{
				DebugLocation(224, 4);
				MULT33=(IToken)Match(input,MULT,Follow._MULT_in_multOperator1228); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MULT.Add(MULT33);



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
				// 224:9: -> MULT
				{
					DebugLocation(224, 12);
					adaptor.AddChild(root_0, new MultNode(stream_MULT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:225:4: DIVIDE
				{
				DebugLocation(225, 4);
				DIVIDE34=(IToken)Match(input,DIVIDE,Follow._DIVIDE_in_multOperator1240); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DIVIDE.Add(DIVIDE34);



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
				// 225:11: -> DIVIDE
				{
					DebugLocation(225, 14);
					adaptor.AddChild(root_0, new DivNode(stream_DIVIDE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:226:4: MOD
				{
				DebugLocation(226, 4);
				MOD35=(IToken)Match(input,MOD,Follow._MOD_in_multOperator1252); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOD.Add(MOD35);



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
				// 226:8: -> MOD
				{
					DebugLocation(226, 11);
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
		DebugLocation(227, 1);
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
	// Plsql.g:229:1: assignOperator : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN );
	[GrammarRule("assignOperator")]
	private PlsqlParser.assignOperator_return assignOperator()
	{
		Enter_assignOperator();
		EnterRule("assignOperator", 14);
		TraceIn("assignOperator", 14);
		PlsqlParser.assignOperator_return retval = new PlsqlParser.assignOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set36=null;

		object set36_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignOperator");
		DebugLocation(229, 1);
		try
		{
			// Plsql.g:230:2: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(230, 2);
			set36=(IToken)input.LT(1);
			if ((input.LA(1)>=ASSIGN && input.LA(1)<=DIVASSIGN))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set36));
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
		DebugLocation(235, 1);
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
	// Plsql.g:237:1: unaryOperator : ( MINUS -> MINUS | NOT -> NOT );
	[GrammarRule("unaryOperator")]
	private PlsqlParser.unaryOperator_return unaryOperator()
	{
		Enter_unaryOperator();
		EnterRule("unaryOperator", 15);
		TraceIn("unaryOperator", 15);
		PlsqlParser.unaryOperator_return retval = new PlsqlParser.unaryOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS37=null;
		IToken NOT38=null;

		object MINUS37_tree=null;
		object NOT38_tree=null;
		RewriteRuleITokenStream stream_NOT=new RewriteRuleITokenStream(adaptor,"token NOT");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "unaryOperator");
		DebugLocation(237, 1);
		try
		{
			// Plsql.g:238:2: ( MINUS -> MINUS | NOT -> NOT )
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
				// Plsql.g:238:4: MINUS
				{
				DebugLocation(238, 4);
				MINUS37=(IToken)Match(input,MINUS,Follow._MINUS_in_unaryOperator1301); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS37);



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
				// 238:10: -> MINUS
				{
					DebugLocation(238, 13);
					adaptor.AddChild(root_0, new MinusNode(stream_MINUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:239:4: NOT
				{
				DebugLocation(239, 4);
				NOT38=(IToken)Match(input,NOT,Follow._NOT_in_unaryOperator1313); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NOT.Add(NOT38);



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
				// 239:8: -> NOT
				{
					DebugLocation(239, 11);
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
		DebugLocation(240, 1);
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
	// Plsql.g:245:1: varDef : ID type -> ^( VarDef ID type ) ;
	[GrammarRule("varDef")]
	private PlsqlParser.varDef_return varDef()
	{
		Enter_varDef();
		EnterRule("varDef", 16);
		TraceIn("varDef", 16);
		PlsqlParser.varDef_return retval = new PlsqlParser.varDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID39=null;
		PlsqlParser.type_return type40 = default(PlsqlParser.type_return);

		object ID39_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varDef");
		DebugLocation(245, 1);
		try
		{
			// Plsql.g:246:2: ( ID type -> ^( VarDef ID type ) )
			DebugEnterAlt(1);
			// Plsql.g:246:4: ID type
			{
			DebugLocation(246, 4);
			ID39=(IToken)Match(input,ID,Follow._ID_in_varDef1334); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID39);

			DebugLocation(246, 7);
			PushFollow(Follow._type_in_varDef1336);
			type40=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type40.Tree);


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
			// 247:2: -> ^( VarDef ID type )
			{
				DebugLocation(247, 5);
				// Plsql.g:247:5: ^( VarDef ID type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(247, 7);
				root_1 = (object)adaptor.BecomeRoot(new VarDefNode(VarDef), root_1);

				DebugLocation(247, 26);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(247, 29);
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
		DebugLocation(248, 1);
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
	// Plsql.g:250:1: varList : ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) ;
	[GrammarRule("varList")]
	private PlsqlParser.varList_return varList()
	{
		Enter_varList();
		EnterRule("varList", 17);
		TraceIn("varList", 17);
		PlsqlParser.varList_return retval = new PlsqlParser.varList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal42=null;
		PlsqlParser.varDef_return varDef41 = default(PlsqlParser.varDef_return);
		PlsqlParser.varDef_return varDef43 = default(PlsqlParser.varDef_return);

		object char_literal42_tree=null;
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_varDef=new RewriteRuleSubtreeStream(adaptor,"rule varDef");
		try { DebugEnterRule(GrammarFileName, "varList");
		DebugLocation(250, 1);
		try
		{
			// Plsql.g:251:2: ( ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) )
			DebugEnterAlt(1);
			// Plsql.g:251:4: ( varDef ( ',' varDef )* )?
			{
			DebugLocation(251, 4);
			// Plsql.g:251:4: ( varDef ( ',' varDef )* )?
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
				// Plsql.g:251:6: varDef ( ',' varDef )*
				{
				DebugLocation(251, 6);
				PushFollow(Follow._varDef_in_varList1364);
				varDef41=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varDef.Add(varDef41.Tree);
				DebugLocation(251, 13);
				// Plsql.g:251:13: ( ',' varDef )*
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
						// Plsql.g:251:15: ',' varDef
						{
						DebugLocation(251, 15);
						char_literal42=(IToken)Match(input,101,Follow._101_in_varList1368); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_101.Add(char_literal42);

						DebugLocation(251, 19);
						PushFollow(Follow._varDef_in_varList1370);
						varDef43=varDef();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_varDef.Add(varDef43.Tree);

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
			// 252:2: -> ^( VarList ( varDef )* )
			{
				DebugLocation(252, 5);
				// Plsql.g:252:5: ^( VarList ( varDef )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(252, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VarList, "VarList"), root_1);

				DebugLocation(252, 15);
				// Plsql.g:252:15: ( varDef )*
				while ( stream_varDef.HasNext )
				{
					DebugLocation(252, 15);
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
		DebugLocation(253, 1);
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
	// Plsql.g:255:1: methodDecl : ( procDecl | funcDecl );
	[GrammarRule("methodDecl")]
	private PlsqlParser.methodDecl_return methodDecl()
	{
		Enter_methodDecl();
		EnterRule("methodDecl", 18);
		TraceIn("methodDecl", 18);
		PlsqlParser.methodDecl_return retval = new PlsqlParser.methodDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.procDecl_return procDecl44 = default(PlsqlParser.procDecl_return);
		PlsqlParser.funcDecl_return funcDecl45 = default(PlsqlParser.funcDecl_return);


		try { DebugEnterRule(GrammarFileName, "methodDecl");
		DebugLocation(255, 1);
		try
		{
			// Plsql.g:256:2: ( procDecl | funcDecl )
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
				// Plsql.g:256:4: procDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(256, 4);
				PushFollow(Follow._procDecl_in_methodDecl1396);
				procDecl44=procDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, procDecl44.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:257:4: funcDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(257, 4);
				PushFollow(Follow._funcDecl_in_methodDecl1401);
				funcDecl45=funcDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcDecl45.Tree);

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
		DebugLocation(258, 1);
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
	// Plsql.g:260:1: methodModifier : ( MEMBER | STATIC | -> STATIC );
	[GrammarRule("methodModifier")]
	private PlsqlParser.methodModifier_return methodModifier()
	{
		Enter_methodModifier();
		EnterRule("methodModifier", 19);
		TraceIn("methodModifier", 19);
		PlsqlParser.methodModifier_return retval = new PlsqlParser.methodModifier_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MEMBER46=null;
		IToken STATIC47=null;

		object MEMBER46_tree=null;
		object STATIC47_tree=null;

		try { DebugEnterRule(GrammarFileName, "methodModifier");
		DebugLocation(260, 1);
		try
		{
			// Plsql.g:261:2: ( MEMBER | STATIC | -> STATIC )
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
				// Plsql.g:261:4: MEMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(261, 4);
				MEMBER46=(IToken)Match(input,MEMBER,Follow._MEMBER_in_methodModifier1412); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				MEMBER46_tree = (object)adaptor.Create(MEMBER46);
				adaptor.AddChild(root_0, MEMBER46_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:262:4: STATIC
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(262, 4);
				STATIC47=(IToken)Match(input,STATIC,Follow._STATIC_in_methodModifier1417); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				STATIC47_tree = (object)adaptor.Create(STATIC47);
				adaptor.AddChild(root_0, STATIC47_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:263:4: 
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
				// 263:4: -> STATIC
				{
					DebugLocation(263, 7);
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
		DebugLocation(264, 1);
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
	// Plsql.g:266:1: procDecl : methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) ;
	[GrammarRule("procDecl")]
	private PlsqlParser.procDecl_return procDecl()
	{
		Enter_procDecl();
		EnterRule("procDecl", 20);
		TraceIn("procDecl", 20);
		PlsqlParser.procDecl_return retval = new PlsqlParser.procDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROCEDURE49=null;
		IToken ID50=null;
		IToken char_literal51=null;
		IToken char_literal53=null;
		PlsqlParser.methodModifier_return methodModifier48 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList52 = default(PlsqlParser.varList_return);

		object PROCEDURE49_tree=null;
		object ID50_tree=null;
		object char_literal51_tree=null;
		object char_literal53_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "procDecl");
		DebugLocation(266, 1);
		try
		{
			// Plsql.g:267:2: ( methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:267:4: methodModifier PROCEDURE ID '(' varList ')'
			{
			DebugLocation(267, 4);
			PushFollow(Follow._methodModifier_in_procDecl1435);
			methodModifier48=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier48.Tree);
			DebugLocation(267, 19);
			PROCEDURE49=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procDecl1437); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROCEDURE.Add(PROCEDURE49);

			DebugLocation(267, 29);
			ID50=(IToken)Match(input,ID,Follow._ID_in_procDecl1439); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID50);

			DebugLocation(267, 32);
			char_literal51=(IToken)Match(input,102,Follow._102_in_procDecl1441); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal51);

			DebugLocation(267, 36);
			PushFollow(Follow._varList_in_procDecl1443);
			varList52=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList52.Tree);
			DebugLocation(267, 44);
			char_literal53=(IToken)Match(input,103,Follow._103_in_procDecl1445); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal53);



			{
			// AST REWRITE
			// elements: varList, ID, methodModifier
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 268:2: -> ^( MethodDecl ID varList Void methodModifier )
			{
				DebugLocation(268, 5);
				// Plsql.g:268:5: ^( MethodDecl ID varList Void methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(268, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(268, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(268, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(268, 45);
				adaptor.AddChild(root_1, new VoidNode(Void));
				DebugLocation(268, 60);
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
		DebugLocation(269, 1);
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
	// Plsql.g:271:1: funcDecl : methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) ;
	[GrammarRule("funcDecl")]
	private PlsqlParser.funcDecl_return funcDecl()
	{
		Enter_funcDecl();
		EnterRule("funcDecl", 21);
		TraceIn("funcDecl", 21);
		PlsqlParser.funcDecl_return retval = new PlsqlParser.funcDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNCTION55=null;
		IToken ID56=null;
		IToken char_literal57=null;
		IToken char_literal59=null;
		IToken RETURN60=null;
		PlsqlParser.methodModifier_return methodModifier54 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList58 = default(PlsqlParser.varList_return);
		PlsqlParser.type_return type61 = default(PlsqlParser.type_return);

		object FUNCTION55_tree=null;
		object ID56_tree=null;
		object char_literal57_tree=null;
		object char_literal59_tree=null;
		object RETURN60_tree=null;
		RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_RETURN=new RewriteRuleITokenStream(adaptor,"token RETURN");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "funcDecl");
		DebugLocation(271, 1);
		try
		{
			// Plsql.g:272:2: ( methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:272:4: methodModifier FUNCTION ID '(' varList ')' RETURN type
			{
			DebugLocation(272, 4);
			PushFollow(Follow._methodModifier_in_funcDecl1477);
			methodModifier54=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier54.Tree);
			DebugLocation(272, 19);
			FUNCTION55=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDecl1479); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNCTION.Add(FUNCTION55);

			DebugLocation(272, 28);
			ID56=(IToken)Match(input,ID,Follow._ID_in_funcDecl1481); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID56);

			DebugLocation(272, 31);
			char_literal57=(IToken)Match(input,102,Follow._102_in_funcDecl1483); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal57);

			DebugLocation(272, 35);
			PushFollow(Follow._varList_in_funcDecl1485);
			varList58=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList58.Tree);
			DebugLocation(272, 43);
			char_literal59=(IToken)Match(input,103,Follow._103_in_funcDecl1487); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal59);

			DebugLocation(272, 47);
			RETURN60=(IToken)Match(input,RETURN,Follow._RETURN_in_funcDecl1489); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RETURN.Add(RETURN60);

			DebugLocation(272, 54);
			PushFollow(Follow._type_in_funcDecl1491);
			type61=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type61.Tree);


			{
			// AST REWRITE
			// elements: varList, type, methodModifier, ID
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 273:2: -> ^( MethodDecl ID varList type methodModifier )
			{
				DebugLocation(273, 5);
				// Plsql.g:273:5: ^( MethodDecl ID varList type methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(273, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(273, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(273, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(273, 45);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(273, 50);
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
		DebugLocation(274, 1);
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
	// Plsql.g:276:1: methodDef : methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) ;
	[GrammarRule("methodDef")]
	private PlsqlParser.methodDef_return methodDef()
	{
		Enter_methodDef();
		EnterRule("methodDef", 22);
		TraceIn("methodDef", 22);
		PlsqlParser.methodDef_return retval = new PlsqlParser.methodDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IS63=null;
		IToken BEGIN65=null;
		IToken END67=null;
		PlsqlParser.methodDecl_return methodDecl62 = default(PlsqlParser.methodDecl_return);
		PlsqlParser.declareBlock_return declareBlock64 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock66 = default(PlsqlParser.codeBlock_return);

		object IS63_tree=null;
		object BEGIN65_tree=null;
		object END67_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_methodDecl=new RewriteRuleSubtreeStream(adaptor,"rule methodDecl");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "methodDef");
		DebugLocation(276, 1);
		try
		{
			// Plsql.g:277:2: ( methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:277:4: methodDecl IS declareBlock BEGIN codeBlock END
			{
			DebugLocation(277, 4);
			PushFollow(Follow._methodDecl_in_methodDef1520);
			methodDecl62=methodDecl();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodDecl.Add(methodDecl62.Tree);
			DebugLocation(277, 15);
			IS63=(IToken)Match(input,IS,Follow._IS_in_methodDef1522); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IS.Add(IS63);

			DebugLocation(277, 18);
			PushFollow(Follow._declareBlock_in_methodDef1524);
			declareBlock64=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock64.Tree);
			DebugLocation(277, 31);
			BEGIN65=(IToken)Match(input,BEGIN,Follow._BEGIN_in_methodDef1526); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN65);

			DebugLocation(277, 37);
			PushFollow(Follow._codeBlock_in_methodDef1528);
			codeBlock66=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock66.Tree);
			DebugLocation(277, 47);
			END67=(IToken)Match(input,END,Follow._END_in_methodDef1530); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END67);



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
			// 278:2: -> ^( MethodDef declareBlock methodDecl codeBlock )
			{
				DebugLocation(278, 5);
				// Plsql.g:278:5: ^( MethodDef declareBlock methodDecl codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(278, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(MethodDef), root_1);

				DebugLocation(278, 32);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(278, 45);
				adaptor.AddChild(root_1, stream_methodDecl.NextTree());
				DebugLocation(278, 56);
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
		DebugLocation(279, 1);
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
	// Plsql.g:281:1: typeDecl : ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) );
	[GrammarRule("typeDecl")]
	private PlsqlParser.typeDecl_return typeDecl()
	{
		Enter_typeDecl();
		EnterRule("typeDecl", 23);
		TraceIn("typeDecl", 23);
		PlsqlParser.typeDecl_return retval = new PlsqlParser.typeDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken TYPE68=null;
		IToken ID69=null;
		IToken IS70=null;
		IToken TABLE71=null;
		IToken OF72=null;
		IToken TYPE74=null;
		IToken ID75=null;
		IToken IS76=null;
		IToken RECORD77=null;
		IToken char_literal78=null;
		IToken char_literal80=null;
		PlsqlParser.type_return type73 = default(PlsqlParser.type_return);
		PlsqlParser.varList_return varList79 = default(PlsqlParser.varList_return);

		object TYPE68_tree=null;
		object ID69_tree=null;
		object IS70_tree=null;
		object TABLE71_tree=null;
		object OF72_tree=null;
		object TYPE74_tree=null;
		object ID75_tree=null;
		object IS76_tree=null;
		object RECORD77_tree=null;
		object char_literal78_tree=null;
		object char_literal80_tree=null;
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
		DebugLocation(281, 1);
		try
		{
			// Plsql.g:282:2: ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) )
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
				// Plsql.g:282:4: TYPE ID IS TABLE OF type
				{
				DebugLocation(282, 4);
				TYPE68=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1557); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE68);

				DebugLocation(282, 9);
				ID69=(IToken)Match(input,ID,Follow._ID_in_typeDecl1559); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID69);

				DebugLocation(282, 12);
				IS70=(IToken)Match(input,IS,Follow._IS_in_typeDecl1561); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS70);

				DebugLocation(282, 15);
				TABLE71=(IToken)Match(input,TABLE,Follow._TABLE_in_typeDecl1563); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE71);

				DebugLocation(282, 21);
				OF72=(IToken)Match(input,OF,Follow._OF_in_typeDecl1565); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF72);

				DebugLocation(282, 24);
				PushFollow(Follow._type_in_typeDecl1567);
				type73=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type73.Tree);


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
				// 283:2: -> ^( Table ID type )
				{
					DebugLocation(283, 5);
					// Plsql.g:283:5: ^( Table ID type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(283, 7);
					root_1 = (object)adaptor.BecomeRoot(new TableNode(Table), root_1);

					DebugLocation(283, 24);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(283, 27);
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
				// Plsql.g:284:4: TYPE ID IS RECORD '(' varList ')'
				{
				DebugLocation(284, 4);
				TYPE74=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1586); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE74);

				DebugLocation(284, 9);
				ID75=(IToken)Match(input,ID,Follow._ID_in_typeDecl1588); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID75);

				DebugLocation(284, 12);
				IS76=(IToken)Match(input,IS,Follow._IS_in_typeDecl1590); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS76);

				DebugLocation(284, 15);
				RECORD77=(IToken)Match(input,RECORD,Follow._RECORD_in_typeDecl1592); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_RECORD.Add(RECORD77);

				DebugLocation(284, 22);
				char_literal78=(IToken)Match(input,102,Follow._102_in_typeDecl1594); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal78);

				DebugLocation(284, 26);
				PushFollow(Follow._varList_in_typeDecl1596);
				varList79=varList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varList.Add(varList79.Tree);
				DebugLocation(284, 34);
				char_literal80=(IToken)Match(input,103,Follow._103_in_typeDecl1598); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal80);



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
				// 285:2: -> ^( Record ID varList )
				{
					DebugLocation(285, 5);
					// Plsql.g:285:5: ^( Record ID varList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(285, 7);
					root_1 = (object)adaptor.BecomeRoot(new RecordNode(Record), root_1);

					DebugLocation(285, 26);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(285, 29);
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
		DebugLocation(286, 1);
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
	// Plsql.g:290:1: object_ : ( objectDecl | objectBody );
	[GrammarRule("object_")]
	private PlsqlParser.object__return object_()
	{
		Enter_object_();
		EnterRule("object_", 24);
		TraceIn("object_", 24);
		PlsqlParser.object__return retval = new PlsqlParser.object__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objectDecl_return objectDecl81 = default(PlsqlParser.objectDecl_return);
		PlsqlParser.objectBody_return objectBody82 = default(PlsqlParser.objectBody_return);


		try { DebugEnterRule(GrammarFileName, "object_");
		DebugLocation(290, 1);
		try
		{
			// Plsql.g:291:2: ( objectDecl | objectBody )
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
				// Plsql.g:291:4: objectDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(291, 4);
				PushFollow(Follow._objectDecl_in_object_1625);
				objectDecl81=objectDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectDecl81.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:292:4: objectBody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(292, 4);
				PushFollow(Follow._objectBody_in_object_1630);
				objectBody82=objectBody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectBody82.Tree);

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
		DebugLocation(293, 1);
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
	// Plsql.g:295:1: objectDecl : CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) ;
	[GrammarRule("objectDecl")]
	private PlsqlParser.objectDecl_return objectDecl()
	{
		Enter_objectDecl();
		EnterRule("objectDecl", 25);
		TraceIn("objectDecl", 25);
		PlsqlParser.objectDecl_return retval = new PlsqlParser.objectDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE83=null;
		IToken TYPE84=null;
		IToken ID85=null;
		IToken OBJECT87=null;
		IToken char_literal88=null;
		IToken char_literal90=null;
		IToken char_literal91=null;
		PlsqlParser.isOrAs_return isOrAs86 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.objectDeclItem_return objectDeclItem89 = default(PlsqlParser.objectDeclItem_return);

		object CREATE83_tree=null;
		object TYPE84_tree=null;
		object ID85_tree=null;
		object OBJECT87_tree=null;
		object char_literal88_tree=null;
		object char_literal90_tree=null;
		object char_literal91_tree=null;
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
		DebugLocation(295, 1);
		try
		{
			// Plsql.g:296:2: ( CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:296:4: CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';'
			{
			DebugLocation(296, 4);
			CREATE83=(IToken)Match(input,CREATE,Follow._CREATE_in_objectDecl1641); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE83);

			DebugLocation(296, 11);
			TYPE84=(IToken)Match(input,TYPE,Follow._TYPE_in_objectDecl1643); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE84);

			DebugLocation(296, 16);
			ID85=(IToken)Match(input,ID,Follow._ID_in_objectDecl1645); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID85);

			DebugLocation(296, 19);
			PushFollow(Follow._isOrAs_in_objectDecl1647);
			isOrAs86=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs86.Tree);
			DebugLocation(296, 26);
			OBJECT87=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectDecl1649); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT87);

			DebugLocation(296, 33);
			char_literal88=(IToken)Match(input,102,Follow._102_in_objectDecl1651); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal88);

			DebugLocation(296, 37);
			// Plsql.g:296:37: ( objectDeclItem )+
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
					DebugLocation(296, 37);
					PushFollow(Follow._objectDeclItem_in_objectDecl1653);
					objectDeclItem89=objectDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objectDeclItem.Add(objectDeclItem89.Tree);

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

			DebugLocation(296, 53);
			char_literal90=(IToken)Match(input,103,Follow._103_in_objectDecl1656); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal90);

			DebugLocation(296, 57);
			char_literal91=(IToken)Match(input,104,Follow._104_in_objectDecl1658); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal91);



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
			// 297:2: -> ^( ClassDecl ID ( objectDeclItem )+ )
			{
				DebugLocation(297, 5);
				// Plsql.g:297:5: ^( ClassDecl ID ( objectDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(297, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDeclNode(ClassDecl), root_1);

				DebugLocation(297, 32);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(297, 35);
				if ( !(stream_objectDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_objectDeclItem.HasNext )
				{
					DebugLocation(297, 35);
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
		DebugLocation(298, 1);
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
	// Plsql.g:300:1: objectBody : CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) ;
	[GrammarRule("objectBody")]
	private PlsqlParser.objectBody_return objectBody()
	{
		Enter_objectBody();
		EnterRule("objectBody", 26);
		TraceIn("objectBody", 26);
		PlsqlParser.objectBody_return retval = new PlsqlParser.objectBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE92=null;
		IToken TYPE93=null;
		IToken BODY94=null;
		IToken ID95=null;
		IToken OBJECT97=null;
		IToken char_literal99=null;
		IToken END100=null;
		IToken char_literal101=null;
		PlsqlParser.isOrAs_return isOrAs96 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.methodDef_return methodDef98 = default(PlsqlParser.methodDef_return);

		object CREATE92_tree=null;
		object TYPE93_tree=null;
		object BODY94_tree=null;
		object ID95_tree=null;
		object OBJECT97_tree=null;
		object char_literal99_tree=null;
		object END100_tree=null;
		object char_literal101_tree=null;
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
		DebugLocation(300, 1);
		try
		{
			// Plsql.g:301:2: ( CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:301:4: CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';'
			{
			DebugLocation(301, 4);
			CREATE92=(IToken)Match(input,CREATE,Follow._CREATE_in_objectBody1684); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE92);

			DebugLocation(301, 11);
			TYPE93=(IToken)Match(input,TYPE,Follow._TYPE_in_objectBody1686); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE93);

			DebugLocation(301, 16);
			BODY94=(IToken)Match(input,BODY,Follow._BODY_in_objectBody1688); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY94);

			DebugLocation(301, 21);
			ID95=(IToken)Match(input,ID,Follow._ID_in_objectBody1690); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID95);

			DebugLocation(301, 24);
			PushFollow(Follow._isOrAs_in_objectBody1692);
			isOrAs96=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs96.Tree);
			DebugLocation(301, 31);
			OBJECT97=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectBody1694); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT97);

			DebugLocation(301, 38);
			// Plsql.g:301:38: ( methodDef ';' )+
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
					// Plsql.g:301:40: methodDef ';'
					{
					DebugLocation(301, 40);
					PushFollow(Follow._methodDef_in_objectBody1698);
					methodDef98=methodDef();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_methodDef.Add(methodDef98.Tree);
					DebugLocation(301, 50);
					char_literal99=(IToken)Match(input,104,Follow._104_in_objectBody1700); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal99);


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

			DebugLocation(301, 57);
			END100=(IToken)Match(input,END,Follow._END_in_objectBody1705); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END100);

			DebugLocation(301, 61);
			char_literal101=(IToken)Match(input,104,Follow._104_in_objectBody1707); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal101);



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
			// 302:2: -> ^( ClassDef ID ( methodDef )+ )
			{
				DebugLocation(302, 5);
				// Plsql.g:302:5: ^( ClassDef ID ( methodDef )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(302, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDefNode(ClassDef), root_1);

				DebugLocation(302, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(302, 33);
				if ( !(stream_methodDef.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_methodDef.HasNext )
				{
					DebugLocation(302, 33);
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
		DebugLocation(303, 1);
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
	// Plsql.g:305:1: objectDeclItem : ( varDef ';' | methodDecl ';' );
	[GrammarRule("objectDeclItem")]
	private PlsqlParser.objectDeclItem_return objectDeclItem()
	{
		Enter_objectDeclItem();
		EnterRule("objectDeclItem", 27);
		TraceIn("objectDeclItem", 27);
		PlsqlParser.objectDeclItem_return retval = new PlsqlParser.objectDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal103=null;
		IToken char_literal105=null;
		PlsqlParser.varDef_return varDef102 = default(PlsqlParser.varDef_return);
		PlsqlParser.methodDecl_return methodDecl104 = default(PlsqlParser.methodDecl_return);

		object char_literal103_tree=null;
		object char_literal105_tree=null;

		try { DebugEnterRule(GrammarFileName, "objectDeclItem");
		DebugLocation(305, 1);
		try
		{
			// Plsql.g:306:2: ( varDef ';' | methodDecl ';' )
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
				// Plsql.g:306:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(306, 4);
				PushFollow(Follow._varDef_in_objectDeclItem1733);
				varDef102=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef102.Tree);
				DebugLocation(306, 14);
				char_literal103=(IToken)Match(input,104,Follow._104_in_objectDeclItem1735); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:307:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(307, 4);
				PushFollow(Follow._methodDecl_in_objectDeclItem1741);
				methodDecl104=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl104.Tree);
				DebugLocation(307, 18);
				char_literal105=(IToken)Match(input,104,Follow._104_in_objectDeclItem1743); if (state.failed) return retval;

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
		DebugLocation(308, 1);
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
	// Plsql.g:313:1: package_ : ( packageDecl | packageDef );
	[GrammarRule("package_")]
	private PlsqlParser.package__return package_()
	{
		Enter_package_();
		EnterRule("package_", 28);
		TraceIn("package_", 28);
		PlsqlParser.package__return retval = new PlsqlParser.package__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.packageDecl_return packageDecl106 = default(PlsqlParser.packageDecl_return);
		PlsqlParser.packageDef_return packageDef107 = default(PlsqlParser.packageDef_return);


		try { DebugEnterRule(GrammarFileName, "package_");
		DebugLocation(313, 1);
		try
		{
			// Plsql.g:314:2: ( packageDecl | packageDef )
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
				// Plsql.g:314:4: packageDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(314, 4);
				PushFollow(Follow._packageDecl_in_package_1758);
				packageDecl106=packageDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDecl106.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:315:4: packageDef
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(315, 4);
				PushFollow(Follow._packageDef_in_package_1763);
				packageDef107=packageDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDef107.Tree);

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
		DebugLocation(316, 1);
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
	// Plsql.g:318:1: packageDecl : CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) ;
	[GrammarRule("packageDecl")]
	private PlsqlParser.packageDecl_return packageDecl()
	{
		Enter_packageDecl();
		EnterRule("packageDecl", 29);
		TraceIn("packageDecl", 29);
		PlsqlParser.packageDecl_return retval = new PlsqlParser.packageDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE108=null;
		IToken PACKAGE109=null;
		IToken ID110=null;
		IToken END113=null;
		IToken char_literal114=null;
		PlsqlParser.isOrAs_return isOrAs111 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageDeclItem_return packageDeclItem112 = default(PlsqlParser.packageDeclItem_return);

		object CREATE108_tree=null;
		object PACKAGE109_tree=null;
		object ID110_tree=null;
		object END113_tree=null;
		object char_literal114_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_packageDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule packageDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDecl");
		DebugLocation(318, 1);
		try
		{
			// Plsql.g:319:2: ( CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:319:4: CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';'
			{
			DebugLocation(319, 4);
			CREATE108=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDecl1774); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE108);

			DebugLocation(319, 11);
			PACKAGE109=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDecl1776); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE109);

			DebugLocation(319, 19);
			ID110=(IToken)Match(input,ID,Follow._ID_in_packageDecl1778); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID110);

			DebugLocation(319, 22);
			PushFollow(Follow._isOrAs_in_packageDecl1780);
			isOrAs111=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs111.Tree);
			DebugLocation(319, 29);
			// Plsql.g:319:29: ( packageDeclItem )+
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
					DebugLocation(319, 29);
					PushFollow(Follow._packageDeclItem_in_packageDecl1782);
					packageDeclItem112=packageDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageDeclItem.Add(packageDeclItem112.Tree);

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

			DebugLocation(319, 46);
			END113=(IToken)Match(input,END,Follow._END_in_packageDecl1785); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END113);

			DebugLocation(319, 50);
			char_literal114=(IToken)Match(input,104,Follow._104_in_packageDecl1787); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal114);



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
			// 320:2: -> ^( PackageDecl ID ( packageDeclItem )+ )
			{
				DebugLocation(320, 5);
				// Plsql.g:320:5: ^( PackageDecl ID ( packageDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(320, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDeclNode(PackageDecl), root_1);

				DebugLocation(320, 36);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(320, 39);
				if ( !(stream_packageDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageDeclItem.HasNext )
				{
					DebugLocation(320, 39);
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
		DebugLocation(321, 1);
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
	// Plsql.g:323:1: packageDef : CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) ;
	[GrammarRule("packageDef")]
	private PlsqlParser.packageDef_return packageDef()
	{
		Enter_packageDef();
		EnterRule("packageDef", 30);
		TraceIn("packageDef", 30);
		PlsqlParser.packageDef_return retval = new PlsqlParser.packageDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE115=null;
		IToken PACKAGE116=null;
		IToken BODY117=null;
		IToken ID118=null;
		IToken END121=null;
		IToken char_literal122=null;
		PlsqlParser.isOrAs_return isOrAs119 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageBodyItem_return packageBodyItem120 = default(PlsqlParser.packageBodyItem_return);

		object CREATE115_tree=null;
		object PACKAGE116_tree=null;
		object BODY117_tree=null;
		object ID118_tree=null;
		object END121_tree=null;
		object char_literal122_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_packageBodyItem=new RewriteRuleSubtreeStream(adaptor,"rule packageBodyItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDef");
		DebugLocation(323, 1);
		try
		{
			// Plsql.g:324:2: ( CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:324:4: CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';'
			{
			DebugLocation(324, 4);
			CREATE115=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDef1814); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE115);

			DebugLocation(324, 11);
			PACKAGE116=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDef1816); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE116);

			DebugLocation(324, 19);
			BODY117=(IToken)Match(input,BODY,Follow._BODY_in_packageDef1818); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY117);

			DebugLocation(324, 24);
			ID118=(IToken)Match(input,ID,Follow._ID_in_packageDef1820); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID118);

			DebugLocation(324, 27);
			PushFollow(Follow._isOrAs_in_packageDef1822);
			isOrAs119=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs119.Tree);
			DebugLocation(324, 34);
			// Plsql.g:324:34: ( packageBodyItem )+
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
					DebugLocation(324, 34);
					PushFollow(Follow._packageBodyItem_in_packageDef1824);
					packageBodyItem120=packageBodyItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageBodyItem.Add(packageBodyItem120.Tree);

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

			DebugLocation(324, 51);
			END121=(IToken)Match(input,END,Follow._END_in_packageDef1827); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END121);

			DebugLocation(324, 55);
			char_literal122=(IToken)Match(input,104,Follow._104_in_packageDef1829); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal122);



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
			// 325:2: -> ^( PackageDef ID ( packageBodyItem )+ )
			{
				DebugLocation(325, 5);
				// Plsql.g:325:5: ^( PackageDef ID ( packageBodyItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(325, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDefNode(PackageDef), root_1);

				DebugLocation(325, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(325, 37);
				if ( !(stream_packageBodyItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageBodyItem.HasNext )
				{
					DebugLocation(325, 37);
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
		DebugLocation(326, 1);
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
	// Plsql.g:328:1: packageDeclItem : ( varDef ';' | typeDecl ';' | methodDecl ';' );
	[GrammarRule("packageDeclItem")]
	private PlsqlParser.packageDeclItem_return packageDeclItem()
	{
		Enter_packageDeclItem();
		EnterRule("packageDeclItem", 31);
		TraceIn("packageDeclItem", 31);
		PlsqlParser.packageDeclItem_return retval = new PlsqlParser.packageDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal124=null;
		IToken char_literal126=null;
		IToken char_literal128=null;
		PlsqlParser.varDef_return varDef123 = default(PlsqlParser.varDef_return);
		PlsqlParser.typeDecl_return typeDecl125 = default(PlsqlParser.typeDecl_return);
		PlsqlParser.methodDecl_return methodDecl127 = default(PlsqlParser.methodDecl_return);

		object char_literal124_tree=null;
		object char_literal126_tree=null;
		object char_literal128_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageDeclItem");
		DebugLocation(328, 1);
		try
		{
			// Plsql.g:329:2: ( varDef ';' | typeDecl ';' | methodDecl ';' )
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
				// Plsql.g:329:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(329, 4);
				PushFollow(Follow._varDef_in_packageDeclItem1855);
				varDef123=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef123.Tree);
				DebugLocation(329, 14);
				char_literal124=(IToken)Match(input,104,Follow._104_in_packageDeclItem1857); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:330:4: typeDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(330, 4);
				PushFollow(Follow._typeDecl_in_packageDeclItem1863);
				typeDecl125=typeDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeDecl125.Tree);
				DebugLocation(330, 16);
				char_literal126=(IToken)Match(input,104,Follow._104_in_packageDeclItem1865); if (state.failed) return retval;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:331:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(331, 4);
				PushFollow(Follow._methodDecl_in_packageDeclItem1871);
				methodDecl127=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl127.Tree);
				DebugLocation(331, 18);
				char_literal128=(IToken)Match(input,104,Follow._104_in_packageDeclItem1873); if (state.failed) return retval;

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
		DebugLocation(332, 1);
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
	// Plsql.g:334:1: packageBodyItem : methodDef ';' ;
	[GrammarRule("packageBodyItem")]
	private PlsqlParser.packageBodyItem_return packageBodyItem()
	{
		Enter_packageBodyItem();
		EnterRule("packageBodyItem", 32);
		TraceIn("packageBodyItem", 32);
		PlsqlParser.packageBodyItem_return retval = new PlsqlParser.packageBodyItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal130=null;
		PlsqlParser.methodDef_return methodDef129 = default(PlsqlParser.methodDef_return);

		object char_literal130_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageBodyItem");
		DebugLocation(334, 1);
		try
		{
			// Plsql.g:335:2: ( methodDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:335:4: methodDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(335, 4);
			PushFollow(Follow._methodDef_in_packageBodyItem1885);
			methodDef129=methodDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef129.Tree);
			DebugLocation(335, 17);
			char_literal130=(IToken)Match(input,104,Follow._104_in_packageBodyItem1887); if (state.failed) return retval;

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
		DebugLocation(336, 1);
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
	// Plsql.g:341:1: entryPoint : DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) ;
	[GrammarRule("entryPoint")]
	private PlsqlParser.entryPoint_return entryPoint()
	{
		Enter_entryPoint();
		EnterRule("entryPoint", 33);
		TraceIn("entryPoint", 33);
		PlsqlParser.entryPoint_return retval = new PlsqlParser.entryPoint_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DECLARE131=null;
		IToken BEGIN133=null;
		IToken END135=null;
		IToken char_literal136=null;
		PlsqlParser.declareBlock_return declareBlock132 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock134 = default(PlsqlParser.codeBlock_return);

		object DECLARE131_tree=null;
		object BEGIN133_tree=null;
		object END135_tree=null;
		object char_literal136_tree=null;
		RewriteRuleITokenStream stream_DECLARE=new RewriteRuleITokenStream(adaptor,"token DECLARE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "entryPoint");
		DebugLocation(341, 1);
		try
		{
			// Plsql.g:342:2: ( DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:342:4: DECLARE declareBlock BEGIN codeBlock END ';'
			{
			DebugLocation(342, 4);
			DECLARE131=(IToken)Match(input,DECLARE,Follow._DECLARE_in_entryPoint1902); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DECLARE.Add(DECLARE131);

			DebugLocation(342, 12);
			PushFollow(Follow._declareBlock_in_entryPoint1904);
			declareBlock132=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock132.Tree);
			DebugLocation(342, 25);
			BEGIN133=(IToken)Match(input,BEGIN,Follow._BEGIN_in_entryPoint1906); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN133);

			DebugLocation(342, 31);
			PushFollow(Follow._codeBlock_in_entryPoint1908);
			codeBlock134=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock134.Tree);
			DebugLocation(342, 41);
			END135=(IToken)Match(input,END,Follow._END_in_entryPoint1910); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END135);

			DebugLocation(342, 45);
			char_literal136=(IToken)Match(input,104,Follow._104_in_entryPoint1912); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal136);



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
			// 343:2: -> ^( EntryPoint declareBlock codeBlock )
			{
				DebugLocation(343, 5);
				// Plsql.g:343:5: ^( EntryPoint declareBlock codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(343, 7);
				root_1 = (object)adaptor.BecomeRoot(new EntryPointNode(EntryPoint), root_1);

				DebugLocation(343, 34);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(343, 47);
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
		DebugLocation(344, 1);
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
	// Plsql.g:347:1: declareBlock : ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) ;
	[GrammarRule("declareBlock")]
	private PlsqlParser.declareBlock_return declareBlock()
	{
		Enter_declareBlock();
		EnterRule("declareBlock", 34);
		TraceIn("declareBlock", 34);
		PlsqlParser.declareBlock_return retval = new PlsqlParser.declareBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.declareItem_return declareItem137 = default(PlsqlParser.declareItem_return);

		RewriteRuleSubtreeStream stream_declareItem=new RewriteRuleSubtreeStream(adaptor,"rule declareItem");
		try { DebugEnterRule(GrammarFileName, "declareBlock");
		DebugLocation(347, 1);
		try
		{
			// Plsql.g:348:2: ( ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) )
			DebugEnterAlt(1);
			// Plsql.g:348:4: ( declareItem )*
			{
			DebugLocation(348, 4);
			// Plsql.g:348:4: ( declareItem )*
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
					DebugLocation(348, 4);
					PushFollow(Follow._declareItem_in_declareBlock1938);
					declareItem137=declareItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declareItem.Add(declareItem137.Tree);

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
			// 349:2: -> ^( DeclareBlock ( declareItem )* )
			{
				DebugLocation(349, 5);
				// Plsql.g:349:5: ^( DeclareBlock ( declareItem )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(349, 7);
				root_1 = (object)adaptor.BecomeRoot(new DeclareBlockNode(DeclareBlock), root_1);

				DebugLocation(349, 38);
				// Plsql.g:349:38: ( declareItem )*
				while ( stream_declareItem.HasNext )
				{
					DebugLocation(349, 38);
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
		DebugLocation(350, 1);
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
	// Plsql.g:352:1: declareItem : varDef ';' ;
	[GrammarRule("declareItem")]
	private PlsqlParser.declareItem_return declareItem()
	{
		Enter_declareItem();
		EnterRule("declareItem", 35);
		TraceIn("declareItem", 35);
		PlsqlParser.declareItem_return retval = new PlsqlParser.declareItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal139=null;
		PlsqlParser.varDef_return varDef138 = default(PlsqlParser.varDef_return);

		object char_literal139_tree=null;

		try { DebugEnterRule(GrammarFileName, "declareItem");
		DebugLocation(352, 1);
		try
		{
			// Plsql.g:353:2: ( varDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:353:4: varDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(353, 4);
			PushFollow(Follow._varDef_in_declareItem1963);
			varDef138=varDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef138.Tree);
			DebugLocation(353, 14);
			char_literal139=(IToken)Match(input,104,Follow._104_in_declareItem1965); if (state.failed) return retval;

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
		DebugLocation(354, 1);
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
	// Plsql.g:356:1: codeBlock : ( command ';' )* -> ^( CodeBlock ( command )* ) ;
	[GrammarRule("codeBlock")]
	private PlsqlParser.codeBlock_return codeBlock()
	{
		Enter_codeBlock();
		EnterRule("codeBlock", 36);
		TraceIn("codeBlock", 36);
		PlsqlParser.codeBlock_return retval = new PlsqlParser.codeBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal141=null;
		PlsqlParser.command_return command140 = default(PlsqlParser.command_return);

		object char_literal141_tree=null;
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_command=new RewriteRuleSubtreeStream(adaptor,"rule command");
		try { DebugEnterRule(GrammarFileName, "codeBlock");
		DebugLocation(356, 1);
		try
		{
			// Plsql.g:357:2: ( ( command ';' )* -> ^( CodeBlock ( command )* ) )
			DebugEnterAlt(1);
			// Plsql.g:357:4: ( command ';' )*
			{
			DebugLocation(357, 4);
			// Plsql.g:357:4: ( command ';' )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==IF||(LA25_0>=WHILE && LA25_0<=LOOP)||LA25_0==FOR||LA25_0==SELF||(LA25_0>=TRUE && LA25_0<=RETURN)||LA25_0==MINUS||LA25_0==NOT||(LA25_0>=ID && LA25_0<=QUOTED_CHAR)||LA25_0==102))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:357:6: command ';'
					{
					DebugLocation(357, 6);
					PushFollow(Follow._command_in_codeBlock1979);
					command140=command();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_command.Add(command140.Tree);
					DebugLocation(357, 14);
					char_literal141=(IToken)Match(input,104,Follow._104_in_codeBlock1981); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal141);


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
			// 358:2: -> ^( CodeBlock ( command )* )
			{
				DebugLocation(358, 5);
				// Plsql.g:358:5: ^( CodeBlock ( command )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(358, 7);
				root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(CodeBlock), root_1);

				DebugLocation(358, 32);
				// Plsql.g:358:32: ( command )*
				while ( stream_command.HasNext )
				{
					DebugLocation(358, 32);
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
		DebugLocation(359, 1);
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
	// Plsql.g:361:1: command : ( assign | if_ | cycle | expression | RETURN expression );
	[GrammarRule("command")]
	private PlsqlParser.command_return command()
	{
		Enter_command();
		EnterRule("command", 37);
		TraceIn("command", 37);
		PlsqlParser.command_return retval = new PlsqlParser.command_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken RETURN146=null;
		PlsqlParser.assign_return assign142 = default(PlsqlParser.assign_return);
		PlsqlParser.if__return if_143 = default(PlsqlParser.if__return);
		PlsqlParser.cycle_return cycle144 = default(PlsqlParser.cycle_return);
		PlsqlParser.expression_return expression145 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression147 = default(PlsqlParser.expression_return);

		object RETURN146_tree=null;

		try { DebugEnterRule(GrammarFileName, "command");
		DebugLocation(361, 1);
		try
		{
			// Plsql.g:362:2: ( assign | if_ | cycle | expression | RETURN expression )
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
				// Plsql.g:362:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(362, 4);
				PushFollow(Follow._assign_in_command2007);
				assign142=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign142.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:363:4: if_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(363, 4);
				PushFollow(Follow._if__in_command2012);
				if_143=if_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_143.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:364:4: cycle
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(364, 4);
				PushFollow(Follow._cycle_in_command2017);
				cycle144=cycle();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle144.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:365:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(365, 4);
				PushFollow(Follow._expression_in_command2022);
				expression145=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression145.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:366:4: RETURN expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(366, 22);
				RETURN146=(IToken)Match(input,RETURN,Follow._RETURN_in_command2027); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				RETURN146_tree = new ReturnNode(RETURN146) ;
				root_0 = (object)adaptor.BecomeRoot(RETURN146_tree, root_0);
				}
				DebugLocation(366, 24);
				PushFollow(Follow._expression_in_command2033);
				expression147=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression147.Tree);

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
		DebugLocation(367, 1);
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
	// Plsql.g:369:1: assign : expression ASSIGN ( NULL | expression ) ;
	[GrammarRule("assign")]
	private PlsqlParser.assign_return assign()
	{
		Enter_assign();
		EnterRule("assign", 38);
		TraceIn("assign", 38);
		PlsqlParser.assign_return retval = new PlsqlParser.assign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGN149=null;
		IToken NULL150=null;
		PlsqlParser.expression_return expression148 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression151 = default(PlsqlParser.expression_return);

		object ASSIGN149_tree=null;
		object NULL150_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign");
		DebugLocation(369, 1);
		try
		{
			// Plsql.g:370:2: ( expression ASSIGN ( NULL | expression ) )
			DebugEnterAlt(1);
			// Plsql.g:370:4: expression ASSIGN ( NULL | expression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(370, 4);
			PushFollow(Follow._expression_in_assign2044);
			expression148=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression148.Tree);
			DebugLocation(370, 33);
			ASSIGN149=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign2046); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN149_tree = new AssignNode(ASSIGN149) ;
			root_0 = (object)adaptor.BecomeRoot(ASSIGN149_tree, root_0);
			}
			DebugLocation(370, 35);
			// Plsql.g:370:35: ( NULL | expression )
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
				// Plsql.g:370:37: NULL
				{
				DebugLocation(370, 37);
				NULL150=(IToken)Match(input,NULL,Follow._NULL_in_assign2054); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NULL150_tree = new TypeNode(NULL150) ;
				adaptor.AddChild(root_0, NULL150_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:370:54: expression
				{
				DebugLocation(370, 54);
				PushFollow(Follow._expression_in_assign2061);
				expression151=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression151.Tree);

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
		DebugLocation(371, 1);
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
	// Plsql.g:373:1: if_ : IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) ;
	[GrammarRule("if_")]
	private PlsqlParser.if__return if_()
	{
		Enter_if_();
		EnterRule("if_", 39);
		TraceIn("if_", 39);
		PlsqlParser.if__return retval = new PlsqlParser.if__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF152=null;
		IToken THEN154=null;
		IToken ELSE156=null;
		IToken END158=null;
		IToken IF159=null;
		PlsqlParser.expression_return expression153 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock155 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock157 = default(PlsqlParser.codeBlock_return);

		object IF152_tree=null;
		object THEN154_tree=null;
		object ELSE156_tree=null;
		object END158_tree=null;
		object IF159_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "if_");
		DebugLocation(373, 1);
		try
		{
			// Plsql.g:373:5: ( IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) )
			DebugEnterAlt(1);
			// Plsql.g:373:7: IF expression THEN codeBlock ( ELSE codeBlock )? END IF
			{
			DebugLocation(373, 7);
			IF152=(IToken)Match(input,IF,Follow._IF_in_if_2072); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF152);

			DebugLocation(373, 10);
			PushFollow(Follow._expression_in_if_2074);
			expression153=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression153.Tree);
			DebugLocation(373, 21);
			THEN154=(IToken)Match(input,THEN,Follow._THEN_in_if_2076); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_THEN.Add(THEN154);

			DebugLocation(373, 26);
			PushFollow(Follow._codeBlock_in_if_2078);
			codeBlock155=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock155.Tree);
			DebugLocation(373, 36);
			// Plsql.g:373:36: ( ELSE codeBlock )?
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
				// Plsql.g:373:37: ELSE codeBlock
				{
				DebugLocation(373, 37);
				ELSE156=(IToken)Match(input,ELSE,Follow._ELSE_in_if_2081); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE156);

				DebugLocation(373, 42);
				PushFollow(Follow._codeBlock_in_if_2083);
				codeBlock157=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock157.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(373, 54);
			END158=(IToken)Match(input,END,Follow._END_in_if_2087); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END158);

			DebugLocation(373, 58);
			IF159=(IToken)Match(input,IF,Follow._IF_in_if_2089); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF159);



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
			// 374:2: -> ^( IF expression codeBlock ( codeBlock )? )
			{
				DebugLocation(374, 5);
				// Plsql.g:374:5: ^( IF expression codeBlock ( codeBlock )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(374, 7);
				root_1 = (object)adaptor.BecomeRoot(new IfNode(stream_IF.NextToken()), root_1);

				DebugLocation(374, 18);
				adaptor.AddChild(root_1, stream_expression.NextTree());
				DebugLocation(374, 29);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());
				DebugLocation(374, 39);
				// Plsql.g:374:39: ( codeBlock )?
				if ( stream_codeBlock.HasNext )
				{
					DebugLocation(374, 39);
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
		DebugLocation(375, 1);
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
	// Plsql.g:377:1: cycle : ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) );
	[GrammarRule("cycle")]
	private PlsqlParser.cycle_return cycle()
	{
		Enter_cycle();
		EnterRule("cycle", 40);
		TraceIn("cycle", 40);
		PlsqlParser.cycle_return retval = new PlsqlParser.cycle_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE160=null;
		IToken LOOP162=null;
		IToken END164=null;
		IToken LOOP165=null;
		IToken LOOP166=null;
		IToken EXIT168=null;
		IToken WHEN169=null;
		IToken END171=null;
		IToken LOOP172=null;
		IToken FOR173=null;
		IToken char_literal174=null;
		IToken char_literal176=null;
		IToken char_literal178=null;
		IToken char_literal180=null;
		IToken END182=null;
		IToken FOR183=null;
		PlsqlParser.expression_return expression161 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock163 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock167 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.expression_return expression170 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression175 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.expression_return expression177 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression179 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.codeBlock_return codeBlock181 = default(PlsqlParser.codeBlock_return);

		object WHILE160_tree=null;
		object LOOP162_tree=null;
		object END164_tree=null;
		object LOOP165_tree=null;
		object LOOP166_tree=null;
		object EXIT168_tree=null;
		object WHEN169_tree=null;
		object END171_tree=null;
		object LOOP172_tree=null;
		object FOR173_tree=null;
		object char_literal174_tree=null;
		object char_literal176_tree=null;
		object char_literal178_tree=null;
		object char_literal180_tree=null;
		object END182_tree=null;
		object FOR183_tree=null;
		RewriteRuleITokenStream stream_EXIT=new RewriteRuleITokenStream(adaptor,"token EXIT");
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_WHEN=new RewriteRuleITokenStream(adaptor,"token WHEN");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_LOOP=new RewriteRuleITokenStream(adaptor,"token LOOP");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_assignOrExpression=new RewriteRuleSubtreeStream(adaptor,"rule assignOrExpression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "cycle");
		DebugLocation(377, 1);
		try
		{
			// Plsql.g:378:2: ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) )
			int alt29=3;
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			switch (input.LA(1))
			{
			case WHILE:
				{
				alt29=1;
				}
				break;
			case LOOP:
				{
				alt29=2;
				}
				break;
			case FOR:
				{
				alt29=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:378:4: WHILE expression LOOP codeBlock END LOOP
				{
				DebugLocation(378, 4);
				WHILE160=(IToken)Match(input,WHILE,Follow._WHILE_in_cycle2120); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE160);

				DebugLocation(378, 10);
				PushFollow(Follow._expression_in_cycle2122);
				expression161=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression161.Tree);
				DebugLocation(378, 21);
				LOOP162=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2124); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP162);

				DebugLocation(378, 26);
				PushFollow(Follow._codeBlock_in_cycle2126);
				codeBlock163=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock163.Tree);
				DebugLocation(378, 36);
				END164=(IToken)Match(input,END,Follow._END_in_cycle2128); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END164);

				DebugLocation(378, 40);
				LOOP165=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2130); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP165);



				{
				// AST REWRITE
				// elements: WHILE, codeBlock, expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 379:2: -> ^( WHILE expression codeBlock )
				{
					DebugLocation(379, 5);
					// Plsql.g:379:5: ^( WHILE expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(379, 7);
					root_1 = (object)adaptor.BecomeRoot(new WhileNode(stream_WHILE.NextToken()), root_1);

					DebugLocation(379, 24);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(379, 35);
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
				// Plsql.g:380:4: LOOP codeBlock EXIT WHEN expression END LOOP
				{
				DebugLocation(380, 4);
				LOOP166=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2149); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP166);

				DebugLocation(380, 9);
				PushFollow(Follow._codeBlock_in_cycle2151);
				codeBlock167=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock167.Tree);
				DebugLocation(380, 19);
				EXIT168=(IToken)Match(input,EXIT,Follow._EXIT_in_cycle2153); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EXIT.Add(EXIT168);

				DebugLocation(380, 24);
				WHEN169=(IToken)Match(input,WHEN,Follow._WHEN_in_cycle2155); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHEN.Add(WHEN169);

				DebugLocation(380, 29);
				PushFollow(Follow._expression_in_cycle2157);
				expression170=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression170.Tree);
				DebugLocation(380, 40);
				END171=(IToken)Match(input,END,Follow._END_in_cycle2159); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END171);

				DebugLocation(380, 44);
				LOOP172=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2161); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP172);



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
				// 381:2: -> ^( DO expression codeBlock )
				{
					DebugLocation(381, 5);
					// Plsql.g:381:5: ^( DO expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(381, 7);
					root_1 = (object)adaptor.BecomeRoot(new DoWhileNode(DO), root_1);

					DebugLocation(381, 23);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(381, 34);
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
				// Plsql.g:382:4: FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR
				{
				DebugLocation(382, 4);
				FOR173=(IToken)Match(input,FOR,Follow._FOR_in_cycle2180); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR173);

				DebugLocation(382, 8);
				char_literal174=(IToken)Match(input,102,Follow._102_in_cycle2182); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal174);

				DebugLocation(382, 12);
				PushFollow(Follow._assignOrExpression_in_cycle2184);
				assignOrExpression175=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression175.Tree);
				DebugLocation(382, 31);
				char_literal176=(IToken)Match(input,104,Follow._104_in_cycle2186); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_104.Add(char_literal176);

				DebugLocation(382, 35);
				PushFollow(Follow._expression_in_cycle2188);
				expression177=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression177.Tree);
				DebugLocation(382, 46);
				char_literal178=(IToken)Match(input,104,Follow._104_in_cycle2190); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_104.Add(char_literal178);

				DebugLocation(382, 50);
				PushFollow(Follow._assignOrExpression_in_cycle2192);
				assignOrExpression179=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression179.Tree);
				DebugLocation(382, 69);
				char_literal180=(IToken)Match(input,103,Follow._103_in_cycle2194); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal180);

				DebugLocation(382, 73);
				PushFollow(Follow._codeBlock_in_cycle2196);
				codeBlock181=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock181.Tree);
				DebugLocation(382, 83);
				END182=(IToken)Match(input,END,Follow._END_in_cycle2198); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END182);

				DebugLocation(382, 87);
				FOR183=(IToken)Match(input,FOR,Follow._FOR_in_cycle2200); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR183);



				{
				// AST REWRITE
				// elements: FOR, assignOrExpression, assignOrExpression, expression, codeBlock
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 383:2: -> ^( FOR assignOrExpression expression assignOrExpression codeBlock )
				{
					DebugLocation(383, 5);
					// Plsql.g:383:5: ^( FOR assignOrExpression expression assignOrExpression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(383, 7);
					root_1 = (object)adaptor.BecomeRoot(new ForNode(stream_FOR.NextToken()), root_1);

					DebugLocation(383, 20);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(383, 39);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(383, 50);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(383, 69);
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
		DebugLocation(384, 1);
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
	// Plsql.g:386:1: assignOrExpression : ( assign | expression );
	[GrammarRule("assignOrExpression")]
	private PlsqlParser.assignOrExpression_return assignOrExpression()
	{
		Enter_assignOrExpression();
		EnterRule("assignOrExpression", 41);
		TraceIn("assignOrExpression", 41);
		PlsqlParser.assignOrExpression_return retval = new PlsqlParser.assignOrExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.assign_return assign184 = default(PlsqlParser.assign_return);
		PlsqlParser.expression_return expression185 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "assignOrExpression");
		DebugLocation(386, 1);
		try
		{
			// Plsql.g:387:2: ( assign | expression )
			int alt30=2;
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			try
			{
				alt30 = dfa30.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:387:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(387, 4);
				PushFollow(Follow._assign_in_assignOrExpression2229);
				assign184=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign184.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:388:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(388, 4);
				PushFollow(Follow._expression_in_assignOrExpression2234);
				expression185=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression185.Tree);

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
		DebugLocation(389, 1);
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
	// Plsql.g:391:1: expressionList : ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) ;
	[GrammarRule("expressionList")]
	private PlsqlParser.expressionList_return expressionList()
	{
		Enter_expressionList();
		EnterRule("expressionList", 42);
		TraceIn("expressionList", 42);
		PlsqlParser.expressionList_return retval = new PlsqlParser.expressionList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal187=null;
		PlsqlParser.expr__return expr_186 = default(PlsqlParser.expr__return);
		PlsqlParser.expr__return expr_188 = default(PlsqlParser.expr__return);

		object char_literal187_tree=null;
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(391, 1);
		try
		{
			// Plsql.g:392:2: ( ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) )
			DebugEnterAlt(1);
			// Plsql.g:392:4: ( expr_ ( ',' expr_ )* )?
			{
			DebugLocation(392, 4);
			// Plsql.g:392:4: ( expr_ ( ',' expr_ )* )?
			int alt32=2;
			try { DebugEnterSubRule(32);
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
				// Plsql.g:392:6: expr_ ( ',' expr_ )*
				{
				DebugLocation(392, 6);
				PushFollow(Follow._expr__in_expressionList2247);
				expr_186=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_.Add(expr_186.Tree);
				DebugLocation(392, 12);
				// Plsql.g:392:12: ( ',' expr_ )*
				try { DebugEnterSubRule(31);
				while (true)
				{
					int alt31=2;
					try { DebugEnterDecision(31, decisionCanBacktrack[31]);
					int LA31_0 = input.LA(1);

					if ((LA31_0==101))
					{
						alt31=1;
					}


					} finally { DebugExitDecision(31); }
					switch ( alt31 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:392:14: ',' expr_
						{
						DebugLocation(392, 14);
						char_literal187=(IToken)Match(input,101,Follow._101_in_expressionList2251); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_101.Add(char_literal187);

						DebugLocation(392, 18);
						PushFollow(Follow._expr__in_expressionList2253);
						expr_188=expr_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_expr_.Add(expr_188.Tree);

						}
						break;

					default:
						goto loop31;
					}
				}

				loop31:
					;

				} finally { DebugExitSubRule(31); }


				}
				break;

			}
			} finally { DebugExitSubRule(32); }



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
			// 393:2: -> ^( ExpressionList ( expr_ )* )
			{
				DebugLocation(393, 5);
				// Plsql.g:393:5: ^( ExpressionList ( expr_ )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(393, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ExpressionList, "ExpressionList"), root_1);

				DebugLocation(393, 22);
				// Plsql.g:393:22: ( expr_ )*
				while ( stream_expr_.HasNext )
				{
					DebugLocation(393, 22);
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
		DebugLocation(394, 1);
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
	// Plsql.g:399:1: expression : expr_ -> ^( Expression expr_ ) ;
	[GrammarRule("expression")]
	private PlsqlParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 43);
		TraceIn("expression", 43);
		PlsqlParser.expression_return retval = new PlsqlParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expr__return expr_189 = default(PlsqlParser.expr__return);

		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(399, 1);
		try
		{
			// Plsql.g:400:2: ( expr_ -> ^( Expression expr_ ) )
			DebugEnterAlt(1);
			// Plsql.g:400:4: expr_
			{
			DebugLocation(400, 4);
			PushFollow(Follow._expr__in_expression2282);
			expr_189=expr_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr_.Add(expr_189.Tree);


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
			// 401:2: -> ^( Expression expr_ )
			{
				DebugLocation(401, 5);
				// Plsql.g:401:5: ^( Expression expr_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(401, 7);
				root_1 = (object)adaptor.BecomeRoot(new ExpressionNode(Expression), root_1);

				DebugLocation(401, 34);
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
		DebugLocation(402, 1);
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
	// Plsql.g:404:1: expr_ : ( logicOr )+ ;
	[GrammarRule("expr_")]
	private PlsqlParser.expr__return expr_()
	{
		Enter_expr_();
		EnterRule("expr_", 44);
		TraceIn("expr_", 44);
		PlsqlParser.expr__return retval = new PlsqlParser.expr__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.logicOr_return logicOr190 = default(PlsqlParser.logicOr_return);


		try { DebugEnterRule(GrammarFileName, "expr_");
		DebugLocation(404, 1);
		try
		{
			// Plsql.g:405:2: ( ( logicOr )+ )
			DebugEnterAlt(1);
			// Plsql.g:405:4: ( logicOr )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(405, 4);
			// Plsql.g:405:4: ( logicOr )+
			int cnt33=0;
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==SELF||(LA33_0>=TRUE && LA33_0<=FALSE)||LA33_0==MINUS||LA33_0==NOT||(LA33_0>=ID && LA33_0<=QUOTED_CHAR)||LA33_0==102))
				{
					alt33=1;
				}


				} finally { DebugExitDecision(33); }
				switch (alt33)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: logicOr
					{
					DebugLocation(405, 4);
					PushFollow(Follow._logicOr_in_expr_2305);
					logicOr190=logicOr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicOr190.Tree);

					}
					break;

				default:
					if (cnt33 >= 1)
						goto loop33;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee33 = new EarlyExitException( 33, input );
					DebugRecognitionException(eee33);
					throw eee33;
				}
				cnt33++;
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
			TraceOut("expr_", 44);
			LeaveRule("expr_", 44);
			Leave_expr_();
		}
		DebugLocation(406, 1);
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
	// Plsql.g:408:1: logicOr : logicAnd ( OR logicAnd )* ;
	[GrammarRule("logicOr")]
	private PlsqlParser.logicOr_return logicOr()
	{
		Enter_logicOr();
		EnterRule("logicOr", 45);
		TraceIn("logicOr", 45);
		PlsqlParser.logicOr_return retval = new PlsqlParser.logicOr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR192=null;
		PlsqlParser.logicAnd_return logicAnd191 = default(PlsqlParser.logicAnd_return);
		PlsqlParser.logicAnd_return logicAnd193 = default(PlsqlParser.logicAnd_return);

		object OR192_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicOr");
		DebugLocation(408, 1);
		try
		{
			// Plsql.g:409:2: ( logicAnd ( OR logicAnd )* )
			DebugEnterAlt(1);
			// Plsql.g:409:4: logicAnd ( OR logicAnd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(409, 4);
			PushFollow(Follow._logicAnd_in_logicOr2317);
			logicAnd191=logicAnd();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd191.Tree);
			DebugLocation(409, 13);
			// Plsql.g:409:13: ( OR logicAnd )*
			try { DebugEnterSubRule(34);
			while (true)
			{
				int alt34=2;
				try { DebugEnterDecision(34, decisionCanBacktrack[34]);
				int LA34_0 = input.LA(1);

				if ((LA34_0==OR))
				{
					alt34=1;
				}


				} finally { DebugExitDecision(34); }
				switch ( alt34 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:409:15: OR logicAnd
					{
					DebugLocation(409, 25);
					OR192=(IToken)Match(input,OR,Follow._OR_in_logicOr2321); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR192_tree = new OrNode(OR192) ;
					root_0 = (object)adaptor.BecomeRoot(OR192_tree, root_0);
					}
					DebugLocation(409, 27);
					PushFollow(Follow._logicAnd_in_logicOr2327);
					logicAnd193=logicAnd();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd193.Tree);

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
			TraceOut("logicOr", 45);
			LeaveRule("logicOr", 45);
			Leave_logicOr();
		}
		DebugLocation(410, 1);
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
	// Plsql.g:412:1: logicAnd : equality ( AND equality )* ;
	[GrammarRule("logicAnd")]
	private PlsqlParser.logicAnd_return logicAnd()
	{
		Enter_logicAnd();
		EnterRule("logicAnd", 46);
		TraceIn("logicAnd", 46);
		PlsqlParser.logicAnd_return retval = new PlsqlParser.logicAnd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND195=null;
		PlsqlParser.equality_return equality194 = default(PlsqlParser.equality_return);
		PlsqlParser.equality_return equality196 = default(PlsqlParser.equality_return);

		object AND195_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicAnd");
		DebugLocation(412, 1);
		try
		{
			// Plsql.g:413:2: ( equality ( AND equality )* )
			DebugEnterAlt(1);
			// Plsql.g:413:4: equality ( AND equality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(413, 4);
			PushFollow(Follow._equality_in_logicAnd2340);
			equality194=equality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality194.Tree);
			DebugLocation(413, 13);
			// Plsql.g:413:13: ( AND equality )*
			try { DebugEnterSubRule(35);
			while (true)
			{
				int alt35=2;
				try { DebugEnterDecision(35, decisionCanBacktrack[35]);
				int LA35_0 = input.LA(1);

				if ((LA35_0==AND))
				{
					alt35=1;
				}


				} finally { DebugExitDecision(35); }
				switch ( alt35 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:413:15: AND equality
					{
					DebugLocation(413, 27);
					AND195=(IToken)Match(input,AND,Follow._AND_in_logicAnd2344); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND195_tree = new AndNode(AND195) ;
					root_0 = (object)adaptor.BecomeRoot(AND195_tree, root_0);
					}
					DebugLocation(413, 29);
					PushFollow(Follow._equality_in_logicAnd2350);
					equality196=equality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality196.Tree);

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
			TraceOut("logicAnd", 46);
			LeaveRule("logicAnd", 46);
			Leave_logicAnd();
		}
		DebugLocation(414, 1);
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
	// Plsql.g:416:1: equality : inequality ( equalityOperator inequality )* ;
	[GrammarRule("equality")]
	private PlsqlParser.equality_return equality()
	{
		Enter_equality();
		EnterRule("equality", 47);
		TraceIn("equality", 47);
		PlsqlParser.equality_return retval = new PlsqlParser.equality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.inequality_return inequality197 = default(PlsqlParser.inequality_return);
		PlsqlParser.equalityOperator_return equalityOperator198 = default(PlsqlParser.equalityOperator_return);
		PlsqlParser.inequality_return inequality199 = default(PlsqlParser.inequality_return);


		try { DebugEnterRule(GrammarFileName, "equality");
		DebugLocation(416, 1);
		try
		{
			// Plsql.g:417:2: ( inequality ( equalityOperator inequality )* )
			DebugEnterAlt(1);
			// Plsql.g:417:4: inequality ( equalityOperator inequality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(417, 4);
			PushFollow(Follow._inequality_in_equality2363);
			inequality197=inequality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality197.Tree);
			DebugLocation(417, 15);
			// Plsql.g:417:15: ( equalityOperator inequality )*
			try { DebugEnterSubRule(36);
			while (true)
			{
				int alt36=2;
				try { DebugEnterDecision(36, decisionCanBacktrack[36]);
				int LA36_0 = input.LA(1);

				if (((LA36_0>=EQUAL && LA36_0<=NEQUAL)))
				{
					alt36=1;
				}


				} finally { DebugExitDecision(36); }
				switch ( alt36 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:417:17: equalityOperator inequality
					{
					DebugLocation(417, 33);
					PushFollow(Follow._equalityOperator_in_equality2367);
					equalityOperator198=equalityOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(equalityOperator198.Tree, root_0);
					DebugLocation(417, 35);
					PushFollow(Follow._inequality_in_equality2370);
					inequality199=inequality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality199.Tree);

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
			TraceOut("equality", 47);
			LeaveRule("equality", 47);
			Leave_equality();
		}
		DebugLocation(418, 1);
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
	// Plsql.g:420:1: inequality : add ( ineqOperator add )* ;
	[GrammarRule("inequality")]
	private PlsqlParser.inequality_return inequality()
	{
		Enter_inequality();
		EnterRule("inequality", 48);
		TraceIn("inequality", 48);
		PlsqlParser.inequality_return retval = new PlsqlParser.inequality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.add_return add200 = default(PlsqlParser.add_return);
		PlsqlParser.ineqOperator_return ineqOperator201 = default(PlsqlParser.ineqOperator_return);
		PlsqlParser.add_return add202 = default(PlsqlParser.add_return);


		try { DebugEnterRule(GrammarFileName, "inequality");
		DebugLocation(420, 1);
		try
		{
			// Plsql.g:421:2: ( add ( ineqOperator add )* )
			DebugEnterAlt(1);
			// Plsql.g:421:4: add ( ineqOperator add )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(421, 4);
			PushFollow(Follow._add_in_inequality2383);
			add200=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add200.Tree);
			DebugLocation(421, 8);
			// Plsql.g:421:8: ( ineqOperator add )*
			try { DebugEnterSubRule(37);
			while (true)
			{
				int alt37=2;
				try { DebugEnterDecision(37, decisionCanBacktrack[37]);
				int LA37_0 = input.LA(1);

				if (((LA37_0>=MORE && LA37_0<=LESSEQ)))
				{
					alt37=1;
				}


				} finally { DebugExitDecision(37); }
				switch ( alt37 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:421:10: ineqOperator add
					{
					DebugLocation(421, 22);
					PushFollow(Follow._ineqOperator_in_inequality2387);
					ineqOperator201=ineqOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(ineqOperator201.Tree, root_0);
					DebugLocation(421, 24);
					PushFollow(Follow._add_in_inequality2390);
					add202=add();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add202.Tree);

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
			TraceOut("inequality", 48);
			LeaveRule("inequality", 48);
			Leave_inequality();
		}
		DebugLocation(422, 1);
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
	// Plsql.g:424:1: add : mult ( addOperator mult )* ;
	[GrammarRule("add")]
	private PlsqlParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 49);
		TraceIn("add", 49);
		PlsqlParser.add_return retval = new PlsqlParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.mult_return mult203 = default(PlsqlParser.mult_return);
		PlsqlParser.addOperator_return addOperator204 = default(PlsqlParser.addOperator_return);
		PlsqlParser.mult_return mult205 = default(PlsqlParser.mult_return);


		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(424, 4);
		try
		{
			// Plsql.g:424:5: ( mult ( addOperator mult )* )
			DebugEnterAlt(1);
			// Plsql.g:424:9: mult ( addOperator mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(424, 9);
			PushFollow(Follow._mult_in_add2404);
			mult203=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult203.Tree);
			DebugLocation(424, 14);
			// Plsql.g:424:14: ( addOperator mult )*
			try { DebugEnterSubRule(38);
			while (true)
			{
				int alt38=2;
				try { DebugEnterDecision(38, decisionCanBacktrack[38]);
				try
				{
					alt38 = dfa38.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(38); }
				switch ( alt38 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:424:16: addOperator mult
					{
					DebugLocation(424, 27);
					PushFollow(Follow._addOperator_in_add2408);
					addOperator204=addOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperator204.Tree, root_0);
					DebugLocation(424, 29);
					PushFollow(Follow._mult_in_add2411);
					mult205=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult205.Tree);

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
			TraceOut("add", 49);
			LeaveRule("add", 49);
			Leave_add();
		}
		DebugLocation(425, 4);
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
	// Plsql.g:427:1: mult : cast ( multOperator cast )* ;
	[GrammarRule("mult")]
	private PlsqlParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 50);
		TraceIn("mult", 50);
		PlsqlParser.mult_return retval = new PlsqlParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.cast_return cast206 = default(PlsqlParser.cast_return);
		PlsqlParser.multOperator_return multOperator207 = default(PlsqlParser.multOperator_return);
		PlsqlParser.cast_return cast208 = default(PlsqlParser.cast_return);


		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(427, 1);
		try
		{
			// Plsql.g:427:5: ( cast ( multOperator cast )* )
			DebugEnterAlt(1);
			// Plsql.g:427:9: cast ( multOperator cast )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(427, 9);
			PushFollow(Follow._cast_in_mult2427);
			cast206=cast();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast206.Tree);
			DebugLocation(427, 14);
			// Plsql.g:427:14: ( multOperator cast )*
			try { DebugEnterSubRule(39);
			while (true)
			{
				int alt39=2;
				try { DebugEnterDecision(39, decisionCanBacktrack[39]);
				int LA39_0 = input.LA(1);

				if (((LA39_0>=MULT && LA39_0<=MOD)))
				{
					alt39=1;
				}


				} finally { DebugExitDecision(39); }
				switch ( alt39 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:427:16: multOperator cast
					{
					DebugLocation(427, 28);
					PushFollow(Follow._multOperator_in_mult2431);
					multOperator207=multOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperator207.Tree, root_0);
					DebugLocation(427, 30);
					PushFollow(Follow._cast_in_mult2434);
					cast208=cast();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast208.Tree);

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
			TraceOut("mult", 50);
			LeaveRule("mult", 50);
			Leave_mult();
		}
		DebugLocation(428, 1);
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
	// Plsql.g:430:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );
	[GrammarRule("cast")]
	private PlsqlParser.cast_return cast()
	{
		Enter_cast();
		EnterRule("cast", 51);
		TraceIn("cast", 51);
		PlsqlParser.cast_return retval = new PlsqlParser.cast_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal209=null;
		IToken char_literal211=null;
		PlsqlParser.type_return type210 = default(PlsqlParser.type_return);
		PlsqlParser.unary_return unary212 = default(PlsqlParser.unary_return);
		PlsqlParser.unary_return unary213 = default(PlsqlParser.unary_return);

		object char_literal209_tree=null;
		object char_literal211_tree=null;
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_unary=new RewriteRuleSubtreeStream(adaptor,"rule unary");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "cast");
		DebugLocation(430, 1);
		try
		{
			// Plsql.g:430:5: ( '(' type ')' unary -> ^( Cast unary type ) | unary )
			int alt40=2;
			try { DebugEnterDecision(40, decisionCanBacktrack[40]);
			try
			{
				alt40 = dfa40.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(40); }
			switch (alt40)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:430:7: '(' type ')' unary
				{
				DebugLocation(430, 7);
				char_literal209=(IToken)Match(input,102,Follow._102_in_cast2446); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal209);

				DebugLocation(430, 11);
				PushFollow(Follow._type_in_cast2448);
				type210=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type210.Tree);
				DebugLocation(430, 16);
				char_literal211=(IToken)Match(input,103,Follow._103_in_cast2450); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_103.Add(char_literal211);

				DebugLocation(430, 20);
				PushFollow(Follow._unary_in_cast2452);
				unary212=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_unary.Add(unary212.Tree);


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
				// 431:2: -> ^( Cast unary type )
				{
					DebugLocation(431, 5);
					// Plsql.g:431:5: ^( Cast unary type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(431, 7);
					root_1 = (object)adaptor.BecomeRoot(new CastNode(Cast), root_1);

					DebugLocation(431, 22);
					adaptor.AddChild(root_1, stream_unary.NextTree());
					DebugLocation(431, 28);
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
				// Plsql.g:432:4: unary
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(432, 4);
				PushFollow(Follow._unary_in_cast2471);
				unary213=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary213.Tree);

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
		DebugLocation(433, 1);
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
	// Plsql.g:435:1: unary : ( ( unaryOperator unary ) | postfix );
	[GrammarRule("unary")]
	private PlsqlParser.unary_return unary()
	{
		Enter_unary();
		EnterRule("unary", 52);
		TraceIn("unary", 52);
		PlsqlParser.unary_return retval = new PlsqlParser.unary_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.unaryOperator_return unaryOperator214 = default(PlsqlParser.unaryOperator_return);
		PlsqlParser.unary_return unary215 = default(PlsqlParser.unary_return);
		PlsqlParser.postfix_return postfix216 = default(PlsqlParser.postfix_return);


		try { DebugEnterRule(GrammarFileName, "unary");
		DebugLocation(435, 1);
		try
		{
			// Plsql.g:436:2: ( ( unaryOperator unary ) | postfix )
			int alt41=2;
			try { DebugEnterDecision(41, decisionCanBacktrack[41]);
			int LA41_0 = input.LA(1);

			if ((LA41_0==MINUS||LA41_0==NOT))
			{
				alt41=1;
			}
			else if ((LA41_0==SELF||(LA41_0>=TRUE && LA41_0<=FALSE)||(LA41_0>=ID && LA41_0<=QUOTED_CHAR)||LA41_0==102))
			{
				alt41=2;
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
				// Plsql.g:436:4: ( unaryOperator unary )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(436, 4);
				// Plsql.g:436:4: ( unaryOperator unary )
				DebugEnterAlt(1);
				// Plsql.g:436:5: unaryOperator unary
				{
				DebugLocation(436, 18);
				PushFollow(Follow._unaryOperator_in_unary2483);
				unaryOperator214=unaryOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(unaryOperator214.Tree, root_0);
				DebugLocation(436, 20);
				PushFollow(Follow._unary_in_unary2486);
				unary215=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary215.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:437:4: postfix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(437, 4);
				PushFollow(Follow._postfix_in_unary2493);
				postfix216=postfix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfix216.Tree);

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
		DebugLocation(438, 1);
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
	// Plsql.g:442:1: postfix : quant ( tmp )* ;
	[GrammarRule("postfix")]
	private PlsqlParser.postfix_return postfix()
	{
		Enter_postfix();
		EnterRule("postfix", 53);
		TraceIn("postfix", 53);
		PlsqlParser.postfix_return retval = new PlsqlParser.postfix_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.quant_return quant217 = default(PlsqlParser.quant_return);
		PlsqlParser.tmp_return tmp218 = default(PlsqlParser.tmp_return);


		try { DebugEnterRule(GrammarFileName, "postfix");
		DebugLocation(442, 1);
		try
		{
			// Plsql.g:443:2: ( quant ( tmp )* )
			DebugEnterAlt(1);
			// Plsql.g:443:4: quant ( tmp )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(443, 4);
			PushFollow(Follow._quant_in_postfix2508);
			quant217=quant();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quant217.Tree);
			DebugLocation(443, 13);
			// Plsql.g:443:13: ( tmp )*
			try { DebugEnterSubRule(42);
			while (true)
			{
				int alt42=2;
				try { DebugEnterDecision(42, decisionCanBacktrack[42]);
				int LA42_0 = input.LA(1);

				if ((LA42_0==100||LA42_0==105))
				{
					alt42=1;
				}


				} finally { DebugExitDecision(42); }
				switch ( alt42 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:0:0: tmp
					{
					DebugLocation(443, 13);
					PushFollow(Follow._tmp_in_postfix2510);
					tmp218=tmp();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(tmp218.Tree, root_0);

					}
					break;

				default:
					goto loop42;
				}
			}

			loop42:
				;

			} finally { DebugExitSubRule(42); }


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
		DebugLocation(444, 1);
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
	// Plsql.g:446:1: tmp : ( index | methodCall | memberCall );
	[GrammarRule("tmp")]
	private PlsqlParser.tmp_return tmp()
	{
		Enter_tmp();
		EnterRule("tmp", 54);
		TraceIn("tmp", 54);
		PlsqlParser.tmp_return retval = new PlsqlParser.tmp_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.index_return index219 = default(PlsqlParser.index_return);
		PlsqlParser.methodCall_return methodCall220 = default(PlsqlParser.methodCall_return);
		PlsqlParser.memberCall_return memberCall221 = default(PlsqlParser.memberCall_return);


		try { DebugEnterRule(GrammarFileName, "tmp");
		DebugLocation(446, 1);
		try
		{
			// Plsql.g:446:5: ( index | methodCall | memberCall )
			int alt43=3;
			try { DebugEnterDecision(43, decisionCanBacktrack[43]);
			int LA43_0 = input.LA(1);

			if ((LA43_0==105))
			{
				alt43=1;
			}
			else if ((LA43_0==100))
			{
				int LA43_2 = input.LA(2);

				if ((EvaluatePredicate(synpred65_Plsql_fragment)))
				{
					alt43=2;
				}
				else if ((true))
				{
					alt43=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 43, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
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
				// Plsql.g:446:7: index
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(446, 7);
				PushFollow(Follow._index_in_tmp2522);
				index219=index();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, index219.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:447:4: methodCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(447, 4);
				PushFollow(Follow._methodCall_in_tmp2527);
				methodCall220=methodCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall220.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:448:4: memberCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(448, 4);
				PushFollow(Follow._memberCall_in_tmp2532);
				memberCall221=memberCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberCall221.Tree);

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
		DebugLocation(449, 1);
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
	// Plsql.g:451:1: index : '[' expression ']' -> ^( Index expression ) ;
	[GrammarRule("index")]
	private PlsqlParser.index_return index()
	{
		Enter_index();
		EnterRule("index", 55);
		TraceIn("index", 55);
		PlsqlParser.index_return retval = new PlsqlParser.index_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal222=null;
		IToken char_literal224=null;
		PlsqlParser.expression_return expression223 = default(PlsqlParser.expression_return);

		object char_literal222_tree=null;
		object char_literal224_tree=null;
		RewriteRuleITokenStream stream_106=new RewriteRuleITokenStream(adaptor,"token 106");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "index");
		DebugLocation(451, 1);
		try
		{
			// Plsql.g:452:2: ( '[' expression ']' -> ^( Index expression ) )
			DebugEnterAlt(1);
			// Plsql.g:452:4: '[' expression ']'
			{
			DebugLocation(452, 4);
			char_literal222=(IToken)Match(input,105,Follow._105_in_index2543); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal222);

			DebugLocation(452, 8);
			PushFollow(Follow._expression_in_index2545);
			expression223=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression223.Tree);
			DebugLocation(452, 19);
			char_literal224=(IToken)Match(input,106,Follow._106_in_index2547); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_106.Add(char_literal224);



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
			// 453:2: -> ^( Index expression )
			{
				DebugLocation(453, 5);
				// Plsql.g:453:5: ^( Index expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(453, 7);
				root_1 = (object)adaptor.BecomeRoot(new IndexNode(Index), root_1);

				DebugLocation(453, 24);
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
		DebugLocation(454, 1);
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
	// Plsql.g:456:1: memberCall : '.' ID -> ^( MemberCall ID ) ;
	[GrammarRule("memberCall")]
	private PlsqlParser.memberCall_return memberCall()
	{
		Enter_memberCall();
		EnterRule("memberCall", 56);
		TraceIn("memberCall", 56);
		PlsqlParser.memberCall_return retval = new PlsqlParser.memberCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal225=null;
		IToken ID226=null;

		object char_literal225_tree=null;
		object ID226_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");

		try { DebugEnterRule(GrammarFileName, "memberCall");
		DebugLocation(456, 1);
		try
		{
			// Plsql.g:457:2: ( '.' ID -> ^( MemberCall ID ) )
			DebugEnterAlt(1);
			// Plsql.g:457:4: '.' ID
			{
			DebugLocation(457, 4);
			char_literal225=(IToken)Match(input,100,Follow._100_in_memberCall2570); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal225);

			DebugLocation(457, 8);
			ID226=(IToken)Match(input,ID,Follow._ID_in_memberCall2572); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID226);



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
			// 458:2: -> ^( MemberCall ID )
			{
				DebugLocation(458, 5);
				// Plsql.g:458:5: ^( MemberCall ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(458, 7);
				root_1 = (object)adaptor.BecomeRoot(new MemberCallNode(MemberCall), root_1);

				DebugLocation(458, 34);
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
		DebugLocation(459, 1);
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
	// Plsql.g:461:1: expressionOrEmpty : ( expression | -> Expression );
	[GrammarRule("expressionOrEmpty")]
	private PlsqlParser.expressionOrEmpty_return expressionOrEmpty()
	{
		Enter_expressionOrEmpty();
		EnterRule("expressionOrEmpty", 57);
		TraceIn("expressionOrEmpty", 57);
		PlsqlParser.expressionOrEmpty_return retval = new PlsqlParser.expressionOrEmpty_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expression_return expression227 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "expressionOrEmpty");
		DebugLocation(461, 1);
		try
		{
			// Plsql.g:462:2: ( expression | -> Expression )
			int alt44=2;
			try { DebugEnterDecision(44, decisionCanBacktrack[44]);
			int LA44_0 = input.LA(1);

			if ((LA44_0==SELF||(LA44_0>=TRUE && LA44_0<=FALSE)||LA44_0==MINUS||LA44_0==NOT||(LA44_0>=ID && LA44_0<=QUOTED_CHAR)||LA44_0==102))
			{
				alt44=1;
			}
			else if ((LA44_0==EOF))
			{
				alt44=2;
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
				// Plsql.g:462:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(462, 4);
				PushFollow(Follow._expression_in_expressionOrEmpty2595);
				expression227=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression227.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:463:4: 
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
				// 463:4: -> Expression
				{
					DebugLocation(463, 7);
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
		DebugLocation(464, 1);
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
	// Plsql.g:466:1: methodCall : '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) ;
	[GrammarRule("methodCall")]
	private PlsqlParser.methodCall_return methodCall()
	{
		Enter_methodCall();
		EnterRule("methodCall", 58);
		TraceIn("methodCall", 58);
		PlsqlParser.methodCall_return retval = new PlsqlParser.methodCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal228=null;
		IToken ID229=null;
		IToken char_literal230=null;
		IToken char_literal232=null;
		PlsqlParser.expressionList_return expressionList231 = default(PlsqlParser.expressionList_return);

		object char_literal228_tree=null;
		object ID229_tree=null;
		object char_literal230_tree=null;
		object char_literal232_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "methodCall");
		DebugLocation(466, 1);
		try
		{
			// Plsql.g:467:2: ( '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:467:4: '.' ID '(' expressionList ')'
			{
			DebugLocation(467, 4);
			char_literal228=(IToken)Match(input,100,Follow._100_in_methodCall2613); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal228);

			DebugLocation(467, 8);
			ID229=(IToken)Match(input,ID,Follow._ID_in_methodCall2615); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID229);

			DebugLocation(467, 11);
			char_literal230=(IToken)Match(input,102,Follow._102_in_methodCall2617); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal230);

			DebugLocation(467, 15);
			PushFollow(Follow._expressionList_in_methodCall2619);
			expressionList231=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList231.Tree);
			DebugLocation(467, 30);
			char_literal232=(IToken)Match(input,103,Follow._103_in_methodCall2621); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal232);



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
			// 468:2: -> ^( MethodCall ID expressionList )
			{
				DebugLocation(468, 5);
				// Plsql.g:468:5: ^( MethodCall ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(468, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodCallNode(MethodCall), root_1);

				DebugLocation(468, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(468, 37);
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
		DebugLocation(469, 1);
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
	// Plsql.g:471:1: createInstance : ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) ;
	[GrammarRule("createInstance")]
	private PlsqlParser.createInstance_return createInstance()
	{
		Enter_createInstance();
		EnterRule("createInstance", 59);
		TraceIn("createInstance", 59);
		PlsqlParser.createInstance_return retval = new PlsqlParser.createInstance_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID233=null;
		IToken char_literal234=null;
		IToken char_literal236=null;
		PlsqlParser.expressionList_return expressionList235 = default(PlsqlParser.expressionList_return);

		object ID233_tree=null;
		object char_literal234_tree=null;
		object char_literal236_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "createInstance");
		DebugLocation(471, 1);
		try
		{
			// Plsql.g:472:2: ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:472:4: ID '(' expressionList ')'
			{
			DebugLocation(472, 4);
			ID233=(IToken)Match(input,ID,Follow._ID_in_createInstance2646); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID233);

			DebugLocation(472, 7);
			char_literal234=(IToken)Match(input,102,Follow._102_in_createInstance2648); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal234);

			DebugLocation(472, 11);
			PushFollow(Follow._expressionList_in_createInstance2650);
			expressionList235=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList235.Tree);
			DebugLocation(472, 26);
			char_literal236=(IToken)Match(input,103,Follow._103_in_createInstance2652); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_103.Add(char_literal236);



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
			// 473:2: -> ^( CreateInstance ID expressionList )
			{
				DebugLocation(473, 5);
				// Plsql.g:473:5: ^( CreateInstance ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(473, 7);
				root_1 = (object)adaptor.BecomeRoot(new CreateInstanceNode(CreateInstance), root_1);

				DebugLocation(473, 42);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(473, 45);
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
			TraceOut("createInstance", 59);
			LeaveRule("createInstance", 59);
			Leave_createInstance();
		}
		DebugLocation(474, 1);
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
	// Plsql.g:476:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );
	[GrammarRule("quant")]
	private PlsqlParser.quant_return quant()
	{
		Enter_quant();
		EnterRule("quant", 60);
		TraceIn("quant", 60);
		PlsqlParser.quant_return retval = new PlsqlParser.quant_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal242=null;
		IToken char_literal244=null;
		IToken SELF246=null;
		PlsqlParser.number_return number237 = default(PlsqlParser.number_return);
		PlsqlParser.bool__return bool_238 = default(PlsqlParser.bool__return);
		PlsqlParser.string__return string_239 = default(PlsqlParser.string__return);
		PlsqlParser.char__return char_240 = default(PlsqlParser.char__return);
		PlsqlParser.createInstance_return createInstance241 = default(PlsqlParser.createInstance_return);
		PlsqlParser.expr__return expr_243 = default(PlsqlParser.expr__return);
		PlsqlParser.var_return var245 = default(PlsqlParser.var_return);

		object char_literal242_tree=null;
		object char_literal244_tree=null;
		object SELF246_tree=null;

		try { DebugEnterRule(GrammarFileName, "quant");
		DebugLocation(476, 1);
		try
		{
			// Plsql.g:477:2: ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF )
			int alt45=8;
			try { DebugEnterDecision(45, decisionCanBacktrack[45]);
			try
			{
				alt45 = dfa45.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(45); }
			switch (alt45)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:477:4: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(477, 4);
				PushFollow(Follow._number_in_quant2677);
				number237=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number237.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:478:6: bool_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(478, 6);
				PushFollow(Follow._bool__in_quant2684);
				bool_238=bool_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bool_238.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:479:6: string_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(479, 6);
				PushFollow(Follow._string__in_quant2691);
				string_239=string_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_239.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:480:4: char_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(480, 4);
				PushFollow(Follow._char__in_quant2696);
				char_240=char_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_240.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:481:6: createInstance
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(481, 6);
				PushFollow(Follow._createInstance_in_quant2703);
				createInstance241=createInstance();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, createInstance241.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:482:6: '(' expr_ ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(482, 9);
				char_literal242=(IToken)Match(input,102,Follow._102_in_quant2710); if (state.failed) return retval;
				DebugLocation(482, 11);
				PushFollow(Follow._expr__in_quant2713);
				expr_243=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_243.Tree);
				DebugLocation(482, 20);
				char_literal244=(IToken)Match(input,103,Follow._103_in_quant2715); if (state.failed) return retval;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:483:6: var
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(483, 6);
				PushFollow(Follow._var_in_quant2723);
				var245=var();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var245.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Plsql.g:484:6: SELF
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(484, 6);
				SELF246=(IToken)Match(input,SELF,Follow._SELF_in_quant2730); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				SELF246_tree = new SelfNode(SELF246) ;
				adaptor.AddChild(root_0, SELF246_tree);
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
		DebugLocation(485, 1);
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
	// Plsql.g:487:1: var : ID -> ^( ID ) ;
	[GrammarRule("var")]
	private PlsqlParser.var_return var()
	{
		Enter_var();
		EnterRule("var", 61);
		TraceIn("var", 61);
		PlsqlParser.var_return retval = new PlsqlParser.var_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID247=null;

		object ID247_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "var");
		DebugLocation(487, 1);
		try
		{
			// Plsql.g:487:5: ( ID -> ^( ID ) )
			DebugEnterAlt(1);
			// Plsql.g:487:7: ID
			{
			DebugLocation(487, 7);
			ID247=(IToken)Match(input,ID,Follow._ID_in_var2743); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID247);



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
			// 488:2: -> ^( ID )
			{
				DebugLocation(488, 5);
				// Plsql.g:488:5: ^( ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(488, 7);
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
		DebugLocation(489, 1);
		} finally { DebugExitRule(GrammarFileName, "var"); }
		return retval;

	}
	// $ANTLR end "var"

	partial void Enter_synpred43_Plsql_fragment();
	partial void Leave_synpred43_Plsql_fragment();

	// $ANTLR start synpred43_Plsql
	public void synpred43_Plsql_fragment()
	{
		Enter_synpred43_Plsql_fragment();
		EnterRule("synpred43_Plsql_fragment", 104);
		TraceIn("synpred43_Plsql_fragment", 104);
		try
		{
			// Plsql.g:362:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:362:4: assign
			{
			DebugLocation(362, 4);
			PushFollow(Follow._assign_in_synpred43_Plsql2007);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred43_Plsql_fragment", 104);
			LeaveRule("synpred43_Plsql_fragment", 104);
			Leave_synpred43_Plsql_fragment();
		}
	}
	// $ANTLR end synpred43_Plsql

	partial void Enter_synpred46_Plsql_fragment();
	partial void Leave_synpred46_Plsql_fragment();

	// $ANTLR start synpred46_Plsql
	public void synpred46_Plsql_fragment()
	{
		Enter_synpred46_Plsql_fragment();
		EnterRule("synpred46_Plsql_fragment", 107);
		TraceIn("synpred46_Plsql_fragment", 107);
		try
		{
			// Plsql.g:365:4: ( expression )
			DebugEnterAlt(1);
			// Plsql.g:365:4: expression
			{
			DebugLocation(365, 4);
			PushFollow(Follow._expression_in_synpred46_Plsql2022);
			expression();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred46_Plsql_fragment", 107);
			LeaveRule("synpred46_Plsql_fragment", 107);
			Leave_synpred46_Plsql_fragment();
		}
	}
	// $ANTLR end synpred46_Plsql

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
			// Plsql.g:387:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:387:4: assign
			{
			DebugLocation(387, 4);
			PushFollow(Follow._assign_in_synpred51_Plsql2229);
			assign();
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

	partial void Enter_synpred59_Plsql_fragment();
	partial void Leave_synpred59_Plsql_fragment();

	// $ANTLR start synpred59_Plsql
	public void synpred59_Plsql_fragment()
	{
		Enter_synpred59_Plsql_fragment();
		EnterRule("synpred59_Plsql_fragment", 120);
		TraceIn("synpred59_Plsql_fragment", 120);
		try
		{
			// Plsql.g:424:16: ( addOperator mult )
			DebugEnterAlt(1);
			// Plsql.g:424:16: addOperator mult
			{
			DebugLocation(424, 16);
			PushFollow(Follow._addOperator_in_synpred59_Plsql2408);
			addOperator();
			PopFollow();
			if (state.failed) return;
			DebugLocation(424, 29);
			PushFollow(Follow._mult_in_synpred59_Plsql2411);
			mult();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred59_Plsql_fragment", 120);
			LeaveRule("synpred59_Plsql_fragment", 120);
			Leave_synpred59_Plsql_fragment();
		}
	}
	// $ANTLR end synpred59_Plsql

	partial void Enter_synpred61_Plsql_fragment();
	partial void Leave_synpred61_Plsql_fragment();

	// $ANTLR start synpred61_Plsql
	public void synpred61_Plsql_fragment()
	{
		Enter_synpred61_Plsql_fragment();
		EnterRule("synpred61_Plsql_fragment", 122);
		TraceIn("synpred61_Plsql_fragment", 122);
		try
		{
			// Plsql.g:430:7: ( '(' type ')' unary )
			DebugEnterAlt(1);
			// Plsql.g:430:7: '(' type ')' unary
			{
			DebugLocation(430, 7);
			Match(input,102,Follow._102_in_synpred61_Plsql2446); if (state.failed) return;
			DebugLocation(430, 11);
			PushFollow(Follow._type_in_synpred61_Plsql2448);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(430, 16);
			Match(input,103,Follow._103_in_synpred61_Plsql2450); if (state.failed) return;
			DebugLocation(430, 20);
			PushFollow(Follow._unary_in_synpred61_Plsql2452);
			unary();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred61_Plsql_fragment", 122);
			LeaveRule("synpred61_Plsql_fragment", 122);
			Leave_synpred61_Plsql_fragment();
		}
	}
	// $ANTLR end synpred61_Plsql

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
			// Plsql.g:447:4: ( methodCall )
			DebugEnterAlt(1);
			// Plsql.g:447:4: methodCall
			{
			DebugLocation(447, 4);
			PushFollow(Follow._methodCall_in_synpred65_Plsql2527);
			methodCall();
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

	partial void Enter_synpred71_Plsql_fragment();
	partial void Leave_synpred71_Plsql_fragment();

	// $ANTLR start synpred71_Plsql
	public void synpred71_Plsql_fragment()
	{
		Enter_synpred71_Plsql_fragment();
		EnterRule("synpred71_Plsql_fragment", 132);
		TraceIn("synpred71_Plsql_fragment", 132);
		try
		{
			// Plsql.g:481:6: ( createInstance )
			DebugEnterAlt(1);
			// Plsql.g:481:6: createInstance
			{
			DebugLocation(481, 6);
			PushFollow(Follow._createInstance_in_synpred71_Plsql2703);
			createInstance();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred71_Plsql_fragment", 132);
			LeaveRule("synpred71_Plsql_fragment", 132);
			Leave_synpred71_Plsql_fragment();
		}
	}
	// $ANTLR end synpred71_Plsql

	partial void Enter_synpred73_Plsql_fragment();
	partial void Leave_synpred73_Plsql_fragment();

	// $ANTLR start synpred73_Plsql
	public void synpred73_Plsql_fragment()
	{
		Enter_synpred73_Plsql_fragment();
		EnterRule("synpred73_Plsql_fragment", 134);
		TraceIn("synpred73_Plsql_fragment", 134);
		try
		{
			// Plsql.g:483:6: ( var )
			DebugEnterAlt(1);
			// Plsql.g:483:6: var
			{
			DebugLocation(483, 6);
			PushFollow(Follow._var_in_synpred73_Plsql2723);
			var();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred73_Plsql_fragment", 134);
			LeaveRule("synpred73_Plsql_fragment", 134);
			Leave_synpred73_Plsql_fragment();
		}
	}
	// $ANTLR end synpred73_Plsql
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
	DFA3 dfa3;
	DFA26 dfa26;
	DFA30 dfa30;
	DFA38 dfa38;
	DFA40 dfa40;
	DFA45 dfa45;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa3 = new DFA3( this );
		dfa26 = new DFA26( this, SpecialStateTransition26 );
		dfa30 = new DFA30( this, SpecialStateTransition30 );
		dfa38 = new DFA38( this, SpecialStateTransition38 );
		dfa40 = new DFA40( this, SpecialStateTransition40 );
		dfa45 = new DFA45( this, SpecialStateTransition45 );
	}

	private class DFA3 : DFA
	{
		private const string DFA3_eotS =
			"\xA\xFFFF";
		private const string DFA3_eofS =
			"\x7\xFFFF\x1\x9\x2\xFFFF";
		private const string DFA3_minS =
			"\x1\x22\x6\xFFFF\x1\x37\x2\xFFFF";
		private const string DFA3_maxS =
			"\x1\x5E\x6\xFFFF\x1\x68\x2\xFFFF";
		private const string DFA3_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\xFFFF\x1\x7\x1\x8";
		private const string DFA3_specialS =
			"\xA\xFFFF}>";
		private static readonly string[] DFA3_transitionS =
			{
				"\x1\x2\x1\x1\x1\x3\x1\x6\x1\x4\x1\x5\x36\xFFFF\x1\x7",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x9\x2C\xFFFF\x1\x8\x1\x9\x1\xFFFF\x2\x9",
				"",
				""
			};

		private static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
		private static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
		private static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
		private static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
		private static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
		private static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
		private static readonly short[][] DFA3_transition;

		static DFA3()
		{
			int numStates = DFA3_transitionS.Length;
			DFA3_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA3_transition[i] = DFA.UnpackEncodedString(DFA3_transitionS[i]);
			}
		}

		public DFA3( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 3;
			this.eot = DFA3_eot;
			this.eof = DFA3_eof;
			this.min = DFA3_min;
			this.max = DFA3_max;
			this.accept = DFA3_accept;
			this.special = DFA3_special;
			this.transition = DFA3_transition;
		}

		public override string Description { get { return "177:1: type : ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | ID -> ID );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA26 : DFA
	{
		private const string DFA26_eotS =
			"\x13\xFFFF";
		private const string DFA26_eofS =
			"\x13\xFFFF";
		private const string DFA26_minS =
			"\x1\x2A\xB\x0\x7\xFFFF";
		private const string DFA26_maxS =
			"\x1\x66\xB\x0\x7\xFFFF";
		private const string DFA26_acceptS =
			"\xC\xFFFF\x1\x2\x1\x3\x2\xFFFF\x1\x5\x1\x1\x1\x4";
		private const string DFA26_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x7\xFFFF}>";
		private static readonly string[] DFA26_transitionS =
			{
				"\x1\xC\x3\xFFFF\x2\xD\x2\xFFFF\x1\xD\x12\xFFFF\x1\xB\x2\xFFFF\x1\x6"+
				"\x1\x7\x1\x10\x1\xFFFF\x1\x2\xB\xFFFF\x1\x3\x5\xFFFF\x1\xA\x1\x4\x1"+
				"\x5\x1\x8\x1\x9\x3\xFFFF\x1\x1",
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

		public override string Description { get { return "361:1: command : ( assign | if_ | cycle | expression | RETURN expression );"; } }

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
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA26_2 = input.LA(1);


				int index26_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA26_3 = input.LA(1);


				int index26_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA26_4 = input.LA(1);


				int index26_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA26_5 = input.LA(1);


				int index26_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA26_6 = input.LA(1);


				int index26_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA26_7 = input.LA(1);


				int index26_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA26_8 = input.LA(1);


				int index26_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA26_9 = input.LA(1);


				int index26_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA26_10 = input.LA(1);


				int index26_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA26_11 = input.LA(1);


				int index26_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred43_Plsql_fragment)) ) {s = 17;}

				else if ( (EvaluatePredicate(synpred46_Plsql_fragment)) ) {s = 18;}


				input.Seek(index26_11);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 26, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA30 : DFA
	{
		private const string DFA30_eotS =
			"\xE\xFFFF";
		private const string DFA30_eofS =
			"\xE\xFFFF";
		private const string DFA30_minS =
			"\x1\x45\xB\x0\x2\xFFFF";
		private const string DFA30_maxS =
			"\x1\x66\xB\x0\x2\xFFFF";
		private const string DFA30_acceptS =
			"\xC\xFFFF\x1\x1\x1\x2";
		private const string DFA30_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x2\xFFFF}>";
		private static readonly string[] DFA30_transitionS =
			{
				"\x1\xB\x2\xFFFF\x1\x6\x1\x7\x2\xFFFF\x1\x2\xB\xFFFF\x1\x3\x5\xFFFF"+
				"\x1\xA\x1\x4\x1\x5\x1\x8\x1\x9\x3\xFFFF\x1\x1",
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

		private static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
		private static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
		private static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
		private static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
		private static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
		private static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
		private static readonly short[][] DFA30_transition;

		static DFA30()
		{
			int numStates = DFA30_transitionS.Length;
			DFA30_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA30_transition[i] = DFA.UnpackEncodedString(DFA30_transitionS[i]);
			}
		}

		public DFA30( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 30;
			this.eot = DFA30_eot;
			this.eof = DFA30_eof;
			this.min = DFA30_min;
			this.max = DFA30_max;
			this.accept = DFA30_accept;
			this.special = DFA30_special;
			this.transition = DFA30_transition;
		}

		public override string Description { get { return "386:1: assignOrExpression : ( assign | expression );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition30(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA30_1 = input.LA(1);


				int index30_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA30_2 = input.LA(1);


				int index30_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA30_3 = input.LA(1);


				int index30_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA30_4 = input.LA(1);


				int index30_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA30_5 = input.LA(1);


				int index30_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA30_6 = input.LA(1);


				int index30_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA30_7 = input.LA(1);


				int index30_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA30_8 = input.LA(1);


				int index30_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA30_9 = input.LA(1);


				int index30_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA30_10 = input.LA(1);


				int index30_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA30_11 = input.LA(1);


				int index30_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred51_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index30_11);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 30, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA38 : DFA
	{
		private const string DFA38_eotS =
			"\x1E\xFFFF";
		private const string DFA38_eofS =
			"\x1\x1\x1D\xFFFF";
		private const string DFA38_minS =
			"\x1\x2B\x12\xFFFF\x1\x0\xA\xFFFF";
		private const string DFA38_maxS =
			"\x1\x6A\x12\xFFFF\x1\x0\xA\xFFFF";
		private const string DFA38_acceptS =
			"\x1\xFFFF\x1\x2\x1B\xFFFF\x1\x1";
		private const string DFA38_specialS =
			"\x13\xFFFF\x1\x0\xA\xFFFF}>";
		private static readonly string[] DFA38_transitionS =
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

		private static readonly short[] DFA38_eot = DFA.UnpackEncodedString(DFA38_eotS);
		private static readonly short[] DFA38_eof = DFA.UnpackEncodedString(DFA38_eofS);
		private static readonly char[] DFA38_min = DFA.UnpackEncodedStringToUnsignedChars(DFA38_minS);
		private static readonly char[] DFA38_max = DFA.UnpackEncodedStringToUnsignedChars(DFA38_maxS);
		private static readonly short[] DFA38_accept = DFA.UnpackEncodedString(DFA38_acceptS);
		private static readonly short[] DFA38_special = DFA.UnpackEncodedString(DFA38_specialS);
		private static readonly short[][] DFA38_transition;

		static DFA38()
		{
			int numStates = DFA38_transitionS.Length;
			DFA38_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA38_transition[i] = DFA.UnpackEncodedString(DFA38_transitionS[i]);
			}
		}

		public DFA38( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 38;
			this.eot = DFA38_eot;
			this.eof = DFA38_eof;
			this.min = DFA38_min;
			this.max = DFA38_max;
			this.accept = DFA38_accept;
			this.special = DFA38_special;
			this.transition = DFA38_transition;
		}

		public override string Description { get { return "()* loopback of 424:14: ( addOperator mult )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition38(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA38_19 = input.LA(1);


				int index38_19 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred59_Plsql_fragment)) ) {s = 29;}

				else if ( (true) ) {s = 1;}


				input.Seek(index38_19);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 38, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA40 : DFA
	{
		private const string DFA40_eotS =
			"\xD\xFFFF";
		private const string DFA40_eofS =
			"\xD\xFFFF";
		private const string DFA40_minS =
			"\x1\x45\x1\x0\xB\xFFFF";
		private const string DFA40_maxS =
			"\x1\x66\x1\x0\xB\xFFFF";
		private const string DFA40_acceptS =
			"\x2\xFFFF\x1\x2\x9\xFFFF\x1\x1";
		private const string DFA40_specialS =
			"\x1\xFFFF\x1\x0\xB\xFFFF}>";
		private static readonly string[] DFA40_transitionS =
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

		private static readonly short[] DFA40_eot = DFA.UnpackEncodedString(DFA40_eotS);
		private static readonly short[] DFA40_eof = DFA.UnpackEncodedString(DFA40_eofS);
		private static readonly char[] DFA40_min = DFA.UnpackEncodedStringToUnsignedChars(DFA40_minS);
		private static readonly char[] DFA40_max = DFA.UnpackEncodedStringToUnsignedChars(DFA40_maxS);
		private static readonly short[] DFA40_accept = DFA.UnpackEncodedString(DFA40_acceptS);
		private static readonly short[] DFA40_special = DFA.UnpackEncodedString(DFA40_specialS);
		private static readonly short[][] DFA40_transition;

		static DFA40()
		{
			int numStates = DFA40_transitionS.Length;
			DFA40_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA40_transition[i] = DFA.UnpackEncodedString(DFA40_transitionS[i]);
			}
		}

		public DFA40( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 40;
			this.eot = DFA40_eot;
			this.eof = DFA40_eof;
			this.min = DFA40_min;
			this.max = DFA40_max;
			this.accept = DFA40_accept;
			this.special = DFA40_special;
			this.transition = DFA40_transition;
		}

		public override string Description { get { return "430:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition40(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA40_1 = input.LA(1);


				int index40_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred61_Plsql_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 2;}


				input.Seek(index40_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 40, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA45 : DFA
	{
		private const string DFA45_eotS =
			"\xC\xFFFF";
		private const string DFA45_eofS =
			"\xC\xFFFF";
		private const string DFA45_minS =
			"\x1\x45\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA45_maxS =
			"\x1\x66\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA45_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x2\x1\xFFFF\x1\x3\x1\x4\x1\xFFFF\x1\x6\x1"+
			"\x8\x1\x5\x1\x7";
		private const string DFA45_specialS =
			"\x7\xFFFF\x1\x0\x4\xFFFF}>";
		private static readonly string[] DFA45_transitionS =
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

		private static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
		private static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
		private static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
		private static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
		private static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
		private static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
		private static readonly short[][] DFA45_transition;

		static DFA45()
		{
			int numStates = DFA45_transitionS.Length;
			DFA45_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA45_transition[i] = DFA.UnpackEncodedString(DFA45_transitionS[i]);
			}
		}

		public DFA45( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 45;
			this.eot = DFA45_eot;
			this.eof = DFA45_eof;
			this.min = DFA45_min;
			this.max = DFA45_max;
			this.accept = DFA45_accept;
			this.special = DFA45_special;
			this.transition = DFA45_transition;
		}

		public override string Description { get { return "476:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition45(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA45_7 = input.LA(1);


				int index45_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred71_Plsql_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred73_Plsql_fragment)) ) {s = 11;}


				input.Seek(index45_7);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 45, _s, input);
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
		public static readonly BitSet _STRING_in_type978 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BOOL_in_type992 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1006 = new BitSet(new ulong[]{0x0UL,0x1000000000UL});
		public static readonly BitSet _100_in_type1008 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_type1010 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1032 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objOrPack_in_program1052 = new BitSet(new ulong[]{0x8000000000000UL,0x10UL});
		public static readonly BitSet _entryPoint_in_program1055 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _object__in_objOrPack1078 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _package__in_objOrPack1084 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_isOrAs0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_in_equalityOperator1114 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEQUAL_in_equalityOperator1126 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MORE_in_ineqOperator1144 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_in_ineqOperator1156 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOREEQ_in_ineqOperator1168 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESSEQ_in_ineqOperator1180 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PLUS_in_addOperator1198 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_addOperator1210 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MULT_in_multOperator1228 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DIVIDE_in_multOperator1240 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOD_in_multOperator1252 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_assignOperator0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_unaryOperator1301 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_unaryOperator1313 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varDef1334 = new BitSet(new ulong[]{0xFC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_varDef1336 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_varList1364 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _101_in_varList1368 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _varDef_in_varList1370 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _procDecl_in_methodDecl1396 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcDecl_in_methodDecl1401 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MEMBER_in_methodModifier1412 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STATIC_in_methodModifier1417 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_procDecl1435 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _PROCEDURE_in_procDecl1437 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_procDecl1439 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_procDecl1441 = new BitSet(new ulong[]{0x0UL,0x8040000000UL});
		public static readonly BitSet _varList_in_procDecl1443 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_procDecl1445 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_funcDecl1477 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _FUNCTION_in_funcDecl1479 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_funcDecl1481 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_funcDecl1483 = new BitSet(new ulong[]{0x0UL,0x8040000000UL});
		public static readonly BitSet _varList_in_funcDecl1485 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_funcDecl1487 = new BitSet(new ulong[]{0x0UL,0x400UL});
		public static readonly BitSet _RETURN_in_funcDecl1489 = new BitSet(new ulong[]{0xFC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_funcDecl1491 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_methodDef1520 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_methodDef1522 = new BitSet(new ulong[]{0x0UL,0x40000002UL});
		public static readonly BitSet _declareBlock_in_methodDef1524 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _BEGIN_in_methodDef1526 = new BitSet(new ulong[]{0x4C40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_methodDef1528 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_methodDef1530 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1557 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_typeDecl1559 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1561 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _TABLE_in_typeDecl1563 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _OF_in_typeDecl1565 = new BitSet(new ulong[]{0xFC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_typeDecl1567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1586 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_typeDecl1588 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1590 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _RECORD_in_typeDecl1592 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_typeDecl1594 = new BitSet(new ulong[]{0x0UL,0x8040000000UL});
		public static readonly BitSet _varList_in_typeDecl1596 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_typeDecl1598 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectDecl_in_object_1625 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectBody_in_object_1630 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectDecl1641 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectDecl1643 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_objectDecl1645 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectDecl1647 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectDecl1649 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_objectDecl1651 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _objectDeclItem_in_objectDecl1653 = new BitSet(new ulong[]{0x8060000000000000UL,0x8040000001UL});
		public static readonly BitSet _103_in_objectDecl1656 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDecl1658 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectBody1684 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectBody1686 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_objectBody1688 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_objectBody1690 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectBody1692 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectBody1694 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _methodDef_in_objectBody1698 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectBody1700 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_objectBody1705 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectBody1707 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_objectDeclItem1733 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDeclItem1735 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_objectDeclItem1741 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDeclItem1743 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDecl_in_package_1758 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDef_in_package_1763 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDecl1774 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _PACKAGE_in_packageDecl1776 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_packageDecl1778 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDecl1780 = new BitSet(new ulong[]{0x8060020000000000UL,0x40000001UL});
		public static readonly BitSet _packageDeclItem_in_packageDecl1782 = new BitSet(new ulong[]{0x8060020000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_packageDecl1785 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDecl1787 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDef1814 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _PACKAGE_in_packageDef1816 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_packageDef1818 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_packageDef1820 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDef1822 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _packageBodyItem_in_packageDef1824 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_packageDef1827 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDef1829 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_packageDeclItem1855 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1857 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_packageDeclItem1863 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1865 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_packageDeclItem1871 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1873 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDef_in_packageBodyItem1885 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageBodyItem1887 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DECLARE_in_entryPoint1902 = new BitSet(new ulong[]{0x0UL,0x40000002UL});
		public static readonly BitSet _declareBlock_in_entryPoint1904 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _BEGIN_in_entryPoint1906 = new BitSet(new ulong[]{0x4C40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_entryPoint1908 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_entryPoint1910 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_entryPoint1912 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declareItem_in_declareBlock1938 = new BitSet(new ulong[]{0x2UL,0x40000000UL});
		public static readonly BitSet _varDef_in_declareItem1963 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_declareItem1965 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _command_in_codeBlock1979 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_codeBlock1981 = new BitSet(new ulong[]{0x4C40000000002UL,0x47C1001720UL});
		public static readonly BitSet _assign_in_command2007 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if__in_command2012 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cycle_in_command2017 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_command2022 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_command2027 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_command2033 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2044 = new BitSet(new ulong[]{0x0UL,0x2000000UL});
		public static readonly BitSet _ASSIGN_in_assign2046 = new BitSet(new ulong[]{0x0UL,0x47C1001360UL});
		public static readonly BitSet _NULL_in_assign2054 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2061 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_if_2072 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_if_2074 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _THEN_in_if_2076 = new BitSet(new ulong[]{0x4D40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_if_2078 = new BitSet(new ulong[]{0x100000000000UL,0x4UL});
		public static readonly BitSet _ELSE_in_if_2081 = new BitSet(new ulong[]{0x4C40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_if_2083 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_if_2087 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _IF_in_if_2089 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_cycle2120 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_cycle2122 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2124 = new BitSet(new ulong[]{0x4C40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_cycle2126 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2128 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2130 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LOOP_in_cycle2149 = new BitSet(new ulong[]{0x5C40000000000UL,0x47C1001720UL});
		public static readonly BitSet _codeBlock_in_cycle2151 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _EXIT_in_cycle2153 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _WHEN_in_cycle2155 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_cycle2157 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2159 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2161 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_cycle2180 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_cycle2182 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _assignOrExpression_in_cycle2184 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_cycle2186 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_cycle2188 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_cycle2190 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _assignOrExpression_in_cycle2192 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_cycle2194 = new BitSet(new ulong[]{0x4C40000000000UL,0x47C1001724UL});
		public static readonly BitSet _codeBlock_in_cycle2196 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2198 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _FOR_in_cycle2200 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_assignOrExpression2229 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assignOrExpression2234 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr__in_expressionList2247 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _101_in_expressionList2251 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expr__in_expressionList2253 = new BitSet(new ulong[]{0x2UL,0x2000000000UL});
		public static readonly BitSet _expr__in_expression2282 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicOr_in_expr_2305 = new BitSet(new ulong[]{0x2UL,0x47C1001320UL});
		public static readonly BitSet _logicAnd_in_logicOr2317 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _OR_in_logicOr2321 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _logicAnd_in_logicOr2327 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _equality_in_logicAnd2340 = new BitSet(new ulong[]{0x2UL,0x10000UL});
		public static readonly BitSet _AND_in_logicAnd2344 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _equality_in_logicAnd2350 = new BitSet(new ulong[]{0x2UL,0x10000UL});
		public static readonly BitSet _inequality_in_equality2363 = new BitSet(new ulong[]{0x2UL,0xC0000UL});
		public static readonly BitSet _equalityOperator_in_equality2367 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _inequality_in_equality2370 = new BitSet(new ulong[]{0x2UL,0xC0000UL});
		public static readonly BitSet _add_in_inequality2383 = new BitSet(new ulong[]{0x2UL,0xF00000UL});
		public static readonly BitSet _ineqOperator_in_inequality2387 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _add_in_inequality2390 = new BitSet(new ulong[]{0x2UL,0xF00000UL});
		public static readonly BitSet _mult_in_add2404 = new BitSet(new ulong[]{0x2UL,0x1800UL});
		public static readonly BitSet _addOperator_in_add2408 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _mult_in_add2411 = new BitSet(new ulong[]{0x2UL,0x1800UL});
		public static readonly BitSet _cast_in_mult2427 = new BitSet(new ulong[]{0x2UL,0xE000UL});
		public static readonly BitSet _multOperator_in_mult2431 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _cast_in_mult2434 = new BitSet(new ulong[]{0x2UL,0xE000UL});
		public static readonly BitSet _102_in_cast2446 = new BitSet(new ulong[]{0xFC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_cast2448 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_cast2450 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _unary_in_cast2452 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unary_in_cast2471 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryOperator_in_unary2483 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _unary_in_unary2486 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _postfix_in_unary2493 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quant_in_postfix2508 = new BitSet(new ulong[]{0x2UL,0x21000000000UL});
		public static readonly BitSet _tmp_in_postfix2510 = new BitSet(new ulong[]{0x2UL,0x21000000000UL});
		public static readonly BitSet _index_in_tmp2522 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_tmp2527 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberCall_in_tmp2532 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _105_in_index2543 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expression_in_index2545 = new BitSet(new ulong[]{0x0UL,0x40000000000UL});
		public static readonly BitSet _106_in_index2547 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _100_in_memberCall2570 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_memberCall2572 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressionOrEmpty2595 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _100_in_methodCall2613 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_methodCall2615 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_methodCall2617 = new BitSet(new ulong[]{0x0UL,0xC7C1001320UL});
		public static readonly BitSet _expressionList_in_methodCall2619 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_methodCall2621 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_createInstance2646 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2648 = new BitSet(new ulong[]{0x0UL,0xC7C1001320UL});
		public static readonly BitSet _expressionList_in_createInstance2650 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_createInstance2652 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_quant2677 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bool__in_quant2684 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _string__in_quant2691 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _char__in_quant2696 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_quant2703 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_quant2710 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _expr__in_quant2713 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_quant2715 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_quant2723 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SELF_in_quant2730 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_var2743 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred43_Plsql2007 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_synpred46_Plsql2022 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred51_Plsql2229 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _addOperator_in_synpred59_Plsql2408 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _mult_in_synpred59_Plsql2411 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _102_in_synpred61_Plsql2446 = new BitSet(new ulong[]{0xFC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_synpred61_Plsql2448 = new BitSet(new ulong[]{0x0UL,0x8000000000UL});
		public static readonly BitSet _103_in_synpred61_Plsql2450 = new BitSet(new ulong[]{0x0UL,0x47C1001320UL});
		public static readonly BitSet _unary_in_synpred61_Plsql2452 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_synpred65_Plsql2527 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_synpred71_Plsql2703 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_synpred73_Plsql2723 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  plsql_msil 
