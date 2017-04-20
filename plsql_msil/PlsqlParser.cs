// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-20 20:30:21

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "Program", "EntryPoint", "DeclareBlock", "VarList", "VarItem", "ClassDecl", "ClassDef", "ClassItems", "PackageDecl", "PackageDef", "CommandBlock", "TypeName", "VarDef", "MethodDecl", "MethodDef", "ObjectMethodDecl", "ObjectMethodDef", "ObjectItems", "Index", "CodeBlock", "MemberCall", "MethodCall", "Cast", "Expression", "ExpressionList", "StringLiteral", "Table", "Record", "CreateInstance", "Void", "BYTE", "INT", "CHAR", "BOOL", "DOUBLE", "STRING", "VOID", "TYPE", "IF", "THEN", "ELSE", "DO", "WHILE", "LOOP", "EXIT", "WHEN", "FOR", "CREATE", "BODY", "PROCEDURE", "FUNCTION", "IS", "AS", "TABLE", "OF", "INDEX", "BY", "RECORD", "OBJECT", "MEMBER", "STATIC", "BEGIN", "END", "PACKAGE", "DECLARE", "SELF", "NULL", "IN", "TRUE", "FALSE", "RETURN", "PLUS", "MINUS", "MULT", "DIVIDE", "MOD", "AND", "OR", "EQUAL", "NEQUAL", "MORE", "LESS", "MOREEQ", "LESSEQ", "NOT", "ASSIGN", "PLUSASSIGN", "MINUSASSIGN", "MULTASSIGN", "DIVASSIGN", "ID", "INTEGER", "REAL", "QUOTED_STRING", "QUOTED_CHAR", "'f'", "'.'", "'('", "')'", "','", "';'", "'['", "']'"
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
				false, false, true, false, false, true, , 
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
				else if ((LA2_2==EOF||LA2_2==THEN||LA2_2==LOOP||LA2_2==TABLE||LA2_2==END||LA2_2==SELF||(LA2_2>=TRUE && LA2_2<=FALSE)||(LA2_2>=PLUS && LA2_2<=ASSIGN)||(LA2_2>=ID && LA2_2<=QUOTED_CHAR)||(LA2_2>=100 && LA2_2<=106)))
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
	// Plsql.g:177:1: type : ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | TABLE '(' type ')' -> ^( TypeName type ) | ID -> ID );
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
		IToken ID23=null;
		PlsqlParser.type_return type21 = default(PlsqlParser.type_return);

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
		object ID23_tree=null;
		RewriteRuleITokenStream stream_CHAR=new RewriteRuleITokenStream(adaptor,"token CHAR");
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
		RewriteRuleITokenStream stream_DOUBLE=new RewriteRuleITokenStream(adaptor,"token DOUBLE");
		RewriteRuleITokenStream stream_BYTE=new RewriteRuleITokenStream(adaptor,"token BYTE");
		RewriteRuleITokenStream stream_INT=new RewriteRuleITokenStream(adaptor,"token INT");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleITokenStream stream_STRING=new RewriteRuleITokenStream(adaptor,"token STRING");
		RewriteRuleITokenStream stream_BOOL=new RewriteRuleITokenStream(adaptor,"token BOOL");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(177, 1);
		try
		{
			// Plsql.g:178:2: ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | TABLE '(' type ')' -> ^( TypeName type ) | ID -> ID )
			int alt3=9;
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
				// Plsql.g:186:4: TABLE '(' type ')'
				{
				DebugLocation(186, 4);
				TABLE19=(IToken)Match(input,TABLE,Follow._TABLE_in_type1030); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE19);

				DebugLocation(186, 10);
				char_literal20=(IToken)Match(input,101,Follow._101_in_type1032); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal20);

				DebugLocation(186, 14);
				PushFollow(Follow._type_in_type1034);
				type21=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type21.Tree);
				DebugLocation(186, 19);
				char_literal22=(IToken)Match(input,102,Follow._102_in_type1036); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal22);



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
				// 187:2: -> ^( TypeName type )
				{
					DebugLocation(187, 6);
					// Plsql.g:187:6: ^( TypeName type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(187, 8);
					root_1 = (object)adaptor.BecomeRoot(new TableTypeNode(TypeName), root_1);

					DebugLocation(187, 32);
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
				// Plsql.g:188:6: ID
				{
				DebugLocation(188, 6);
				ID23=(IToken)Match(input,ID,Follow._ID_in_type1056); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID23);



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
				// 188:9: -> ID
				{
					DebugLocation(188, 12);
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
		DebugLocation(189, 1);
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
	// Plsql.g:191:8: public program : ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) ;
	[GrammarRule("program")]
	public PlsqlParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 7);
		TraceIn("program", 7);
		PlsqlParser.program_return retval = new PlsqlParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objOrPack_return objOrPack24 = default(PlsqlParser.objOrPack_return);
		PlsqlParser.entryPoint_return entryPoint25 = default(PlsqlParser.entryPoint_return);

		RewriteRuleSubtreeStream stream_objOrPack=new RewriteRuleSubtreeStream(adaptor,"rule objOrPack");
		RewriteRuleSubtreeStream stream_entryPoint=new RewriteRuleSubtreeStream(adaptor,"rule entryPoint");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(191, 1);
		try
		{
			// Plsql.g:192:2: ( ( objOrPack )* entryPoint -> ^( Program ( objOrPack )* entryPoint ) )
			DebugEnterAlt(1);
			// Plsql.g:192:4: ( objOrPack )* entryPoint
			{
			DebugLocation(192, 4);
			// Plsql.g:192:4: ( objOrPack )*
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
					DebugLocation(192, 4);
					PushFollow(Follow._objOrPack_in_program1076);
					objOrPack24=objOrPack();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objOrPack.Add(objOrPack24.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(192, 15);
			PushFollow(Follow._entryPoint_in_program1079);
			entryPoint25=entryPoint();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_entryPoint.Add(entryPoint25.Tree);


			{
			// AST REWRITE
			// elements: objOrPack, entryPoint
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 193:2: -> ^( Program ( objOrPack )* entryPoint )
			{
				DebugLocation(193, 5);
				// Plsql.g:193:5: ^( Program ( objOrPack )* entryPoint )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(193, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(Program, "Program"), root_1);

				DebugLocation(193, 15);
				// Plsql.g:193:15: ( objOrPack )*
				while ( stream_objOrPack.HasNext )
				{
					DebugLocation(193, 15);
					adaptor.AddChild(root_1, stream_objOrPack.NextTree());

				}
				stream_objOrPack.Reset();
				DebugLocation(193, 26);
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
		DebugLocation(194, 1);
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
	// Plsql.g:196:1: objOrPack : ( object_ | package_ );
	[GrammarRule("objOrPack")]
	private PlsqlParser.objOrPack_return objOrPack()
	{
		Enter_objOrPack();
		EnterRule("objOrPack", 8);
		TraceIn("objOrPack", 8);
		PlsqlParser.objOrPack_return retval = new PlsqlParser.objOrPack_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.object__return object_26 = default(PlsqlParser.object__return);
		PlsqlParser.package__return package_27 = default(PlsqlParser.package__return);


		try { DebugEnterRule(GrammarFileName, "objOrPack");
		DebugLocation(196, 1);
		try
		{
			// Plsql.g:197:2: ( object_ | package_ )
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
				// Plsql.g:197:4: object_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(197, 4);
				PushFollow(Follow._object__in_objOrPack1102);
				object_26=object_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_26.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:198:4: package_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(198, 4);
				PushFollow(Follow._package__in_objOrPack1108);
				package_27=package_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, package_27.Tree);

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
		DebugLocation(199, 1);
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
	// Plsql.g:201:1: isOrAs : ( IS | AS );
	[GrammarRule("isOrAs")]
	private PlsqlParser.isOrAs_return isOrAs()
	{
		Enter_isOrAs();
		EnterRule("isOrAs", 9);
		TraceIn("isOrAs", 9);
		PlsqlParser.isOrAs_return retval = new PlsqlParser.isOrAs_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set28=null;

		object set28_tree=null;

		try { DebugEnterRule(GrammarFileName, "isOrAs");
		DebugLocation(201, 1);
		try
		{
			// Plsql.g:202:2: ( IS | AS )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(202, 2);
			set28=(IToken)input.LT(1);
			if ((input.LA(1)>=IS && input.LA(1)<=AS))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set28));
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
		DebugLocation(204, 1);
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
	// Plsql.g:208:1: equalityOperator : ( EQUAL -> EQUAL | NEQUAL -> NEQUAL );
	[GrammarRule("equalityOperator")]
	private PlsqlParser.equalityOperator_return equalityOperator()
	{
		Enter_equalityOperator();
		EnterRule("equalityOperator", 10);
		TraceIn("equalityOperator", 10);
		PlsqlParser.equalityOperator_return retval = new PlsqlParser.equalityOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EQUAL29=null;
		IToken NEQUAL30=null;

		object EQUAL29_tree=null;
		object NEQUAL30_tree=null;
		RewriteRuleITokenStream stream_NEQUAL=new RewriteRuleITokenStream(adaptor,"token NEQUAL");
		RewriteRuleITokenStream stream_EQUAL=new RewriteRuleITokenStream(adaptor,"token EQUAL");

		try { DebugEnterRule(GrammarFileName, "equalityOperator");
		DebugLocation(208, 1);
		try
		{
			// Plsql.g:209:2: ( EQUAL -> EQUAL | NEQUAL -> NEQUAL )
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
				// Plsql.g:209:4: EQUAL
				{
				DebugLocation(209, 4);
				EQUAL29=(IToken)Match(input,EQUAL,Follow._EQUAL_in_equalityOperator1138); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EQUAL.Add(EQUAL29);



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
				// 209:10: -> EQUAL
				{
					DebugLocation(209, 13);
					adaptor.AddChild(root_0, new EqualNode(stream_EQUAL.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:210:4: NEQUAL
				{
				DebugLocation(210, 4);
				NEQUAL30=(IToken)Match(input,NEQUAL,Follow._NEQUAL_in_equalityOperator1150); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NEQUAL.Add(NEQUAL30);



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
				// 210:11: -> NEQUAL
				{
					DebugLocation(210, 14);
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
		DebugLocation(211, 1);
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
	// Plsql.g:213:1: ineqOperator : ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ );
	[GrammarRule("ineqOperator")]
	private PlsqlParser.ineqOperator_return ineqOperator()
	{
		Enter_ineqOperator();
		EnterRule("ineqOperator", 11);
		TraceIn("ineqOperator", 11);
		PlsqlParser.ineqOperator_return retval = new PlsqlParser.ineqOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MORE31=null;
		IToken LESS32=null;
		IToken MOREEQ33=null;
		IToken LESSEQ34=null;

		object MORE31_tree=null;
		object LESS32_tree=null;
		object MOREEQ33_tree=null;
		object LESSEQ34_tree=null;
		RewriteRuleITokenStream stream_MOREEQ=new RewriteRuleITokenStream(adaptor,"token MOREEQ");
		RewriteRuleITokenStream stream_LESSEQ=new RewriteRuleITokenStream(adaptor,"token LESSEQ");
		RewriteRuleITokenStream stream_MORE=new RewriteRuleITokenStream(adaptor,"token MORE");
		RewriteRuleITokenStream stream_LESS=new RewriteRuleITokenStream(adaptor,"token LESS");

		try { DebugEnterRule(GrammarFileName, "ineqOperator");
		DebugLocation(213, 1);
		try
		{
			// Plsql.g:214:2: ( MORE -> MORE | LESS -> LESS | MOREEQ -> MOREEQ | LESSEQ -> LESSEQ )
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
				// Plsql.g:214:4: MORE
				{
				DebugLocation(214, 4);
				MORE31=(IToken)Match(input,MORE,Follow._MORE_in_ineqOperator1168); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MORE.Add(MORE31);



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
				// 214:9: -> MORE
				{
					DebugLocation(214, 12);
					adaptor.AddChild(root_0, new GreaterNode(stream_MORE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:215:4: LESS
				{
				DebugLocation(215, 4);
				LESS32=(IToken)Match(input,LESS,Follow._LESS_in_ineqOperator1180); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESS.Add(LESS32);



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
				// 215:9: -> LESS
				{
					DebugLocation(215, 12);
					adaptor.AddChild(root_0, new LessNode(stream_LESS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:216:4: MOREEQ
				{
				DebugLocation(216, 4);
				MOREEQ33=(IToken)Match(input,MOREEQ,Follow._MOREEQ_in_ineqOperator1192); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOREEQ.Add(MOREEQ33);



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
				// 216:11: -> MOREEQ
				{
					DebugLocation(216, 14);
					adaptor.AddChild(root_0, new GreaterOrEqualNode(stream_MOREEQ.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:217:4: LESSEQ
				{
				DebugLocation(217, 4);
				LESSEQ34=(IToken)Match(input,LESSEQ,Follow._LESSEQ_in_ineqOperator1204); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LESSEQ.Add(LESSEQ34);



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
				// 217:11: -> LESSEQ
				{
					DebugLocation(217, 14);
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
		DebugLocation(218, 1);
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
	// Plsql.g:220:1: addOperator : ( PLUS -> PLUS | MINUS -> MINUS );
	[GrammarRule("addOperator")]
	private PlsqlParser.addOperator_return addOperator()
	{
		Enter_addOperator();
		EnterRule("addOperator", 12);
		TraceIn("addOperator", 12);
		PlsqlParser.addOperator_return retval = new PlsqlParser.addOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PLUS35=null;
		IToken MINUS36=null;

		object PLUS35_tree=null;
		object MINUS36_tree=null;
		RewriteRuleITokenStream stream_PLUS=new RewriteRuleITokenStream(adaptor,"token PLUS");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "addOperator");
		DebugLocation(220, 1);
		try
		{
			// Plsql.g:221:2: ( PLUS -> PLUS | MINUS -> MINUS )
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
				// Plsql.g:221:4: PLUS
				{
				DebugLocation(221, 4);
				PLUS35=(IToken)Match(input,PLUS,Follow._PLUS_in_addOperator1222); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_PLUS.Add(PLUS35);



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
				// 221:9: -> PLUS
				{
					DebugLocation(221, 12);
					adaptor.AddChild(root_0, new PlusNode(stream_PLUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:222:4: MINUS
				{
				DebugLocation(222, 4);
				MINUS36=(IToken)Match(input,MINUS,Follow._MINUS_in_addOperator1234); if (state.failed) return retval; 
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
				// 222:10: -> MINUS
				{
					DebugLocation(222, 13);
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
		DebugLocation(223, 1);
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
	// Plsql.g:225:1: multOperator : ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD );
	[GrammarRule("multOperator")]
	private PlsqlParser.multOperator_return multOperator()
	{
		Enter_multOperator();
		EnterRule("multOperator", 13);
		TraceIn("multOperator", 13);
		PlsqlParser.multOperator_return retval = new PlsqlParser.multOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MULT37=null;
		IToken DIVIDE38=null;
		IToken MOD39=null;

		object MULT37_tree=null;
		object DIVIDE38_tree=null;
		object MOD39_tree=null;
		RewriteRuleITokenStream stream_MULT=new RewriteRuleITokenStream(adaptor,"token MULT");
		RewriteRuleITokenStream stream_MOD=new RewriteRuleITokenStream(adaptor,"token MOD");
		RewriteRuleITokenStream stream_DIVIDE=new RewriteRuleITokenStream(adaptor,"token DIVIDE");

		try { DebugEnterRule(GrammarFileName, "multOperator");
		DebugLocation(225, 1);
		try
		{
			// Plsql.g:226:2: ( MULT -> MULT | DIVIDE -> DIVIDE | MOD -> MOD )
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
				// Plsql.g:226:4: MULT
				{
				DebugLocation(226, 4);
				MULT37=(IToken)Match(input,MULT,Follow._MULT_in_multOperator1252); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MULT.Add(MULT37);



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
				// 226:9: -> MULT
				{
					DebugLocation(226, 12);
					adaptor.AddChild(root_0, new MultNode(stream_MULT.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:227:4: DIVIDE
				{
				DebugLocation(227, 4);
				DIVIDE38=(IToken)Match(input,DIVIDE,Follow._DIVIDE_in_multOperator1264); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DIVIDE.Add(DIVIDE38);



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
				// 227:11: -> DIVIDE
				{
					DebugLocation(227, 14);
					adaptor.AddChild(root_0, new DivNode(stream_DIVIDE.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:228:4: MOD
				{
				DebugLocation(228, 4);
				MOD39=(IToken)Match(input,MOD,Follow._MOD_in_multOperator1276); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MOD.Add(MOD39);



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
				// 228:8: -> MOD
				{
					DebugLocation(228, 11);
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
		DebugLocation(229, 1);
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
	// Plsql.g:231:1: assignOperator : ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN );
	[GrammarRule("assignOperator")]
	private PlsqlParser.assignOperator_return assignOperator()
	{
		Enter_assignOperator();
		EnterRule("assignOperator", 14);
		TraceIn("assignOperator", 14);
		PlsqlParser.assignOperator_return retval = new PlsqlParser.assignOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set40=null;

		object set40_tree=null;

		try { DebugEnterRule(GrammarFileName, "assignOperator");
		DebugLocation(231, 1);
		try
		{
			// Plsql.g:232:2: ( ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN )
			DebugEnterAlt(1);
			// Plsql.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(232, 2);
			set40=(IToken)input.LT(1);
			if ((input.LA(1)>=ASSIGN && input.LA(1)<=DIVASSIGN))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set40));
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
		DebugLocation(237, 1);
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
	// Plsql.g:239:1: unaryOperator : ( MINUS -> MINUS | NOT -> NOT );
	[GrammarRule("unaryOperator")]
	private PlsqlParser.unaryOperator_return unaryOperator()
	{
		Enter_unaryOperator();
		EnterRule("unaryOperator", 15);
		TraceIn("unaryOperator", 15);
		PlsqlParser.unaryOperator_return retval = new PlsqlParser.unaryOperator_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MINUS41=null;
		IToken NOT42=null;

		object MINUS41_tree=null;
		object NOT42_tree=null;
		RewriteRuleITokenStream stream_NOT=new RewriteRuleITokenStream(adaptor,"token NOT");
		RewriteRuleITokenStream stream_MINUS=new RewriteRuleITokenStream(adaptor,"token MINUS");

		try { DebugEnterRule(GrammarFileName, "unaryOperator");
		DebugLocation(239, 1);
		try
		{
			// Plsql.g:240:2: ( MINUS -> MINUS | NOT -> NOT )
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
				// Plsql.g:240:4: MINUS
				{
				DebugLocation(240, 4);
				MINUS41=(IToken)Match(input,MINUS,Follow._MINUS_in_unaryOperator1325); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_MINUS.Add(MINUS41);



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
				// 240:10: -> MINUS
				{
					DebugLocation(240, 13);
					adaptor.AddChild(root_0, new MinusNode(stream_MINUS.NextToken()));

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:241:4: NOT
				{
				DebugLocation(241, 4);
				NOT42=(IToken)Match(input,NOT,Follow._NOT_in_unaryOperator1337); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_NOT.Add(NOT42);



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
				// 241:8: -> NOT
				{
					DebugLocation(241, 11);
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
		DebugLocation(242, 1);
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
	// Plsql.g:247:1: varDef : ID type -> ^( VarDef ID type ) ;
	[GrammarRule("varDef")]
	private PlsqlParser.varDef_return varDef()
	{
		Enter_varDef();
		EnterRule("varDef", 16);
		TraceIn("varDef", 16);
		PlsqlParser.varDef_return retval = new PlsqlParser.varDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID43=null;
		PlsqlParser.type_return type44 = default(PlsqlParser.type_return);

		object ID43_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varDef");
		DebugLocation(247, 1);
		try
		{
			// Plsql.g:248:2: ( ID type -> ^( VarDef ID type ) )
			DebugEnterAlt(1);
			// Plsql.g:248:4: ID type
			{
			DebugLocation(248, 4);
			ID43=(IToken)Match(input,ID,Follow._ID_in_varDef1358); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID43);

			DebugLocation(248, 7);
			PushFollow(Follow._type_in_varDef1360);
			type44=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type44.Tree);


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
			// 249:2: -> ^( VarDef ID type )
			{
				DebugLocation(249, 5);
				// Plsql.g:249:5: ^( VarDef ID type )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(249, 7);
				root_1 = (object)adaptor.BecomeRoot(new VarDefNode(VarDef), root_1);

				DebugLocation(249, 26);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(249, 29);
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
		DebugLocation(250, 1);
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
	// Plsql.g:252:1: varList : ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) ;
	[GrammarRule("varList")]
	private PlsqlParser.varList_return varList()
	{
		Enter_varList();
		EnterRule("varList", 17);
		TraceIn("varList", 17);
		PlsqlParser.varList_return retval = new PlsqlParser.varList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal46=null;
		PlsqlParser.varDef_return varDef45 = default(PlsqlParser.varDef_return);
		PlsqlParser.varDef_return varDef47 = default(PlsqlParser.varDef_return);

		object char_literal46_tree=null;
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleSubtreeStream stream_varDef=new RewriteRuleSubtreeStream(adaptor,"rule varDef");
		try { DebugEnterRule(GrammarFileName, "varList");
		DebugLocation(252, 1);
		try
		{
			// Plsql.g:253:2: ( ( varDef ( ',' varDef )* )? -> ^( VarList ( varDef )* ) )
			DebugEnterAlt(1);
			// Plsql.g:253:4: ( varDef ( ',' varDef )* )?
			{
			DebugLocation(253, 4);
			// Plsql.g:253:4: ( varDef ( ',' varDef )* )?
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
				// Plsql.g:253:6: varDef ( ',' varDef )*
				{
				DebugLocation(253, 6);
				PushFollow(Follow._varDef_in_varList1388);
				varDef45=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varDef.Add(varDef45.Tree);
				DebugLocation(253, 13);
				// Plsql.g:253:13: ( ',' varDef )*
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==103))
					{
						alt11=1;
					}


					} finally { DebugExitDecision(11); }
					switch ( alt11 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:253:15: ',' varDef
						{
						DebugLocation(253, 15);
						char_literal46=(IToken)Match(input,103,Follow._103_in_varList1392); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_103.Add(char_literal46);

						DebugLocation(253, 19);
						PushFollow(Follow._varDef_in_varList1394);
						varDef47=varDef();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_varDef.Add(varDef47.Tree);

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
			// 254:2: -> ^( VarList ( varDef )* )
			{
				DebugLocation(254, 5);
				// Plsql.g:254:5: ^( VarList ( varDef )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(254, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VarList, "VarList"), root_1);

				DebugLocation(254, 15);
				// Plsql.g:254:15: ( varDef )*
				while ( stream_varDef.HasNext )
				{
					DebugLocation(254, 15);
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
		DebugLocation(255, 1);
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
	// Plsql.g:257:1: methodDecl : ( procDecl | funcDecl );
	[GrammarRule("methodDecl")]
	private PlsqlParser.methodDecl_return methodDecl()
	{
		Enter_methodDecl();
		EnterRule("methodDecl", 18);
		TraceIn("methodDecl", 18);
		PlsqlParser.methodDecl_return retval = new PlsqlParser.methodDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.procDecl_return procDecl48 = default(PlsqlParser.procDecl_return);
		PlsqlParser.funcDecl_return funcDecl49 = default(PlsqlParser.funcDecl_return);


		try { DebugEnterRule(GrammarFileName, "methodDecl");
		DebugLocation(257, 1);
		try
		{
			// Plsql.g:258:2: ( procDecl | funcDecl )
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
				// Plsql.g:258:4: procDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(258, 4);
				PushFollow(Follow._procDecl_in_methodDecl1420);
				procDecl48=procDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, procDecl48.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:259:4: funcDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(259, 4);
				PushFollow(Follow._funcDecl_in_methodDecl1425);
				funcDecl49=funcDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcDecl49.Tree);

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
		DebugLocation(260, 1);
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
	// Plsql.g:262:1: methodModifier : ( MEMBER | STATIC | -> STATIC );
	[GrammarRule("methodModifier")]
	private PlsqlParser.methodModifier_return methodModifier()
	{
		Enter_methodModifier();
		EnterRule("methodModifier", 19);
		TraceIn("methodModifier", 19);
		PlsqlParser.methodModifier_return retval = new PlsqlParser.methodModifier_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken MEMBER50=null;
		IToken STATIC51=null;

		object MEMBER50_tree=null;
		object STATIC51_tree=null;

		try { DebugEnterRule(GrammarFileName, "methodModifier");
		DebugLocation(262, 1);
		try
		{
			// Plsql.g:263:2: ( MEMBER | STATIC | -> STATIC )
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
				// Plsql.g:263:4: MEMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(263, 4);
				MEMBER50=(IToken)Match(input,MEMBER,Follow._MEMBER_in_methodModifier1436); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				MEMBER50_tree = (object)adaptor.Create(MEMBER50);
				adaptor.AddChild(root_0, MEMBER50_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:264:4: STATIC
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(264, 4);
				STATIC51=(IToken)Match(input,STATIC,Follow._STATIC_in_methodModifier1441); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				STATIC51_tree = (object)adaptor.Create(STATIC51);
				adaptor.AddChild(root_0, STATIC51_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:265:4: 
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
				// 265:4: -> STATIC
				{
					DebugLocation(265, 7);
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
		DebugLocation(266, 1);
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
	// Plsql.g:268:1: procDecl : methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) ;
	[GrammarRule("procDecl")]
	private PlsqlParser.procDecl_return procDecl()
	{
		Enter_procDecl();
		EnterRule("procDecl", 20);
		TraceIn("procDecl", 20);
		PlsqlParser.procDecl_return retval = new PlsqlParser.procDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROCEDURE53=null;
		IToken ID54=null;
		IToken char_literal55=null;
		IToken char_literal57=null;
		PlsqlParser.methodModifier_return methodModifier52 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList56 = default(PlsqlParser.varList_return);

		object PROCEDURE53_tree=null;
		object ID54_tree=null;
		object char_literal55_tree=null;
		object char_literal57_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "procDecl");
		DebugLocation(268, 1);
		try
		{
			// Plsql.g:269:2: ( methodModifier PROCEDURE ID '(' varList ')' -> ^( MethodDecl ID varList Void methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:269:4: methodModifier PROCEDURE ID '(' varList ')'
			{
			DebugLocation(269, 4);
			PushFollow(Follow._methodModifier_in_procDecl1459);
			methodModifier52=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier52.Tree);
			DebugLocation(269, 19);
			PROCEDURE53=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procDecl1461); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROCEDURE.Add(PROCEDURE53);

			DebugLocation(269, 29);
			ID54=(IToken)Match(input,ID,Follow._ID_in_procDecl1463); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID54);

			DebugLocation(269, 32);
			char_literal55=(IToken)Match(input,101,Follow._101_in_procDecl1465); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal55);

			DebugLocation(269, 36);
			PushFollow(Follow._varList_in_procDecl1467);
			varList56=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList56.Tree);
			DebugLocation(269, 44);
			char_literal57=(IToken)Match(input,102,Follow._102_in_procDecl1469); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal57);



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
			// 270:2: -> ^( MethodDecl ID varList Void methodModifier )
			{
				DebugLocation(270, 5);
				// Plsql.g:270:5: ^( MethodDecl ID varList Void methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(270, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(270, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(270, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(270, 45);
				adaptor.AddChild(root_1, new VoidNode(Void));
				DebugLocation(270, 60);
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
		DebugLocation(271, 1);
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
	// Plsql.g:273:1: funcDecl : methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) ;
	[GrammarRule("funcDecl")]
	private PlsqlParser.funcDecl_return funcDecl()
	{
		Enter_funcDecl();
		EnterRule("funcDecl", 21);
		TraceIn("funcDecl", 21);
		PlsqlParser.funcDecl_return retval = new PlsqlParser.funcDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNCTION59=null;
		IToken ID60=null;
		IToken char_literal61=null;
		IToken char_literal63=null;
		IToken RETURN64=null;
		PlsqlParser.methodModifier_return methodModifier58 = default(PlsqlParser.methodModifier_return);
		PlsqlParser.varList_return varList62 = default(PlsqlParser.varList_return);
		PlsqlParser.type_return type65 = default(PlsqlParser.type_return);

		object FUNCTION59_tree=null;
		object ID60_tree=null;
		object char_literal61_tree=null;
		object char_literal63_tree=null;
		object RETURN64_tree=null;
		RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_RETURN=new RewriteRuleITokenStream(adaptor,"token RETURN");
		RewriteRuleSubtreeStream stream_methodModifier=new RewriteRuleSubtreeStream(adaptor,"rule methodModifier");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "funcDecl");
		DebugLocation(273, 1);
		try
		{
			// Plsql.g:274:2: ( methodModifier FUNCTION ID '(' varList ')' RETURN type -> ^( MethodDecl ID varList type methodModifier ) )
			DebugEnterAlt(1);
			// Plsql.g:274:4: methodModifier FUNCTION ID '(' varList ')' RETURN type
			{
			DebugLocation(274, 4);
			PushFollow(Follow._methodModifier_in_funcDecl1501);
			methodModifier58=methodModifier();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodModifier.Add(methodModifier58.Tree);
			DebugLocation(274, 19);
			FUNCTION59=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDecl1503); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNCTION.Add(FUNCTION59);

			DebugLocation(274, 28);
			ID60=(IToken)Match(input,ID,Follow._ID_in_funcDecl1505); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID60);

			DebugLocation(274, 31);
			char_literal61=(IToken)Match(input,101,Follow._101_in_funcDecl1507); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal61);

			DebugLocation(274, 35);
			PushFollow(Follow._varList_in_funcDecl1509);
			varList62=varList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_varList.Add(varList62.Tree);
			DebugLocation(274, 43);
			char_literal63=(IToken)Match(input,102,Follow._102_in_funcDecl1511); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal63);

			DebugLocation(274, 47);
			RETURN64=(IToken)Match(input,RETURN,Follow._RETURN_in_funcDecl1513); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_RETURN.Add(RETURN64);

			DebugLocation(274, 54);
			PushFollow(Follow._type_in_funcDecl1515);
			type65=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type65.Tree);


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
			// 275:2: -> ^( MethodDecl ID varList type methodModifier )
			{
				DebugLocation(275, 5);
				// Plsql.g:275:5: ^( MethodDecl ID varList type methodModifier )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(275, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDeclNode(MethodDecl), root_1);

				DebugLocation(275, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(275, 37);
				adaptor.AddChild(root_1, stream_varList.NextTree());
				DebugLocation(275, 45);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(275, 50);
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
		DebugLocation(276, 1);
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
	// Plsql.g:278:1: methodDef : methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) ;
	[GrammarRule("methodDef")]
	private PlsqlParser.methodDef_return methodDef()
	{
		Enter_methodDef();
		EnterRule("methodDef", 22);
		TraceIn("methodDef", 22);
		PlsqlParser.methodDef_return retval = new PlsqlParser.methodDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IS67=null;
		IToken BEGIN69=null;
		IToken END71=null;
		PlsqlParser.methodDecl_return methodDecl66 = default(PlsqlParser.methodDecl_return);
		PlsqlParser.declareBlock_return declareBlock68 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock70 = default(PlsqlParser.codeBlock_return);

		object IS67_tree=null;
		object BEGIN69_tree=null;
		object END71_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_methodDecl=new RewriteRuleSubtreeStream(adaptor,"rule methodDecl");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "methodDef");
		DebugLocation(278, 1);
		try
		{
			// Plsql.g:279:2: ( methodDecl IS declareBlock BEGIN codeBlock END -> ^( MethodDef declareBlock methodDecl codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:279:4: methodDecl IS declareBlock BEGIN codeBlock END
			{
			DebugLocation(279, 4);
			PushFollow(Follow._methodDecl_in_methodDef1544);
			methodDecl66=methodDecl();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_methodDecl.Add(methodDecl66.Tree);
			DebugLocation(279, 15);
			IS67=(IToken)Match(input,IS,Follow._IS_in_methodDef1546); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IS.Add(IS67);

			DebugLocation(279, 18);
			PushFollow(Follow._declareBlock_in_methodDef1548);
			declareBlock68=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock68.Tree);
			DebugLocation(279, 31);
			BEGIN69=(IToken)Match(input,BEGIN,Follow._BEGIN_in_methodDef1550); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN69);

			DebugLocation(279, 37);
			PushFollow(Follow._codeBlock_in_methodDef1552);
			codeBlock70=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock70.Tree);
			DebugLocation(279, 47);
			END71=(IToken)Match(input,END,Follow._END_in_methodDef1554); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END71);



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
			// 280:2: -> ^( MethodDef declareBlock methodDecl codeBlock )
			{
				DebugLocation(280, 5);
				// Plsql.g:280:5: ^( MethodDef declareBlock methodDecl codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(280, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodDefNode(MethodDef), root_1);

				DebugLocation(280, 32);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(280, 45);
				adaptor.AddChild(root_1, stream_methodDecl.NextTree());
				DebugLocation(280, 56);
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
		DebugLocation(281, 1);
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
	// Plsql.g:283:1: typeDecl : ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) );
	[GrammarRule("typeDecl")]
	private PlsqlParser.typeDecl_return typeDecl()
	{
		Enter_typeDecl();
		EnterRule("typeDecl", 23);
		TraceIn("typeDecl", 23);
		PlsqlParser.typeDecl_return retval = new PlsqlParser.typeDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken TYPE72=null;
		IToken ID73=null;
		IToken IS74=null;
		IToken TABLE75=null;
		IToken OF76=null;
		IToken TYPE78=null;
		IToken ID79=null;
		IToken IS80=null;
		IToken RECORD81=null;
		IToken char_literal82=null;
		IToken char_literal84=null;
		PlsqlParser.type_return type77 = default(PlsqlParser.type_return);
		PlsqlParser.varList_return varList83 = default(PlsqlParser.varList_return);

		object TYPE72_tree=null;
		object ID73_tree=null;
		object IS74_tree=null;
		object TABLE75_tree=null;
		object OF76_tree=null;
		object TYPE78_tree=null;
		object ID79_tree=null;
		object IS80_tree=null;
		object RECORD81_tree=null;
		object char_literal82_tree=null;
		object char_literal84_tree=null;
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
		RewriteRuleITokenStream stream_RECORD=new RewriteRuleITokenStream(adaptor,"token RECORD");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_IS=new RewriteRuleITokenStream(adaptor,"token IS");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_varList=new RewriteRuleSubtreeStream(adaptor,"rule varList");
		try { DebugEnterRule(GrammarFileName, "typeDecl");
		DebugLocation(283, 1);
		try
		{
			// Plsql.g:284:2: ( TYPE ID IS TABLE OF type -> ^( Table ID type ) | TYPE ID IS RECORD '(' varList ')' -> ^( Record ID varList ) )
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
				// Plsql.g:284:4: TYPE ID IS TABLE OF type
				{
				DebugLocation(284, 4);
				TYPE72=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1581); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE72);

				DebugLocation(284, 9);
				ID73=(IToken)Match(input,ID,Follow._ID_in_typeDecl1583); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID73);

				DebugLocation(284, 12);
				IS74=(IToken)Match(input,IS,Follow._IS_in_typeDecl1585); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS74);

				DebugLocation(284, 15);
				TABLE75=(IToken)Match(input,TABLE,Follow._TABLE_in_typeDecl1587); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE75);

				DebugLocation(284, 21);
				OF76=(IToken)Match(input,OF,Follow._OF_in_typeDecl1589); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF76);

				DebugLocation(284, 24);
				PushFollow(Follow._type_in_typeDecl1591);
				type77=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type77.Tree);


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
				// 285:2: -> ^( Table ID type )
				{
					DebugLocation(285, 5);
					// Plsql.g:285:5: ^( Table ID type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(285, 7);
					root_1 = (object)adaptor.BecomeRoot(new TableNode(Table), root_1);

					DebugLocation(285, 24);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(285, 27);
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
				// Plsql.g:286:4: TYPE ID IS RECORD '(' varList ')'
				{
				DebugLocation(286, 4);
				TYPE78=(IToken)Match(input,TYPE,Follow._TYPE_in_typeDecl1610); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE78);

				DebugLocation(286, 9);
				ID79=(IToken)Match(input,ID,Follow._ID_in_typeDecl1612); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID79);

				DebugLocation(286, 12);
				IS80=(IToken)Match(input,IS,Follow._IS_in_typeDecl1614); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IS.Add(IS80);

				DebugLocation(286, 15);
				RECORD81=(IToken)Match(input,RECORD,Follow._RECORD_in_typeDecl1616); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_RECORD.Add(RECORD81);

				DebugLocation(286, 22);
				char_literal82=(IToken)Match(input,101,Follow._101_in_typeDecl1618); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal82);

				DebugLocation(286, 26);
				PushFollow(Follow._varList_in_typeDecl1620);
				varList83=varList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varList.Add(varList83.Tree);
				DebugLocation(286, 34);
				char_literal84=(IToken)Match(input,102,Follow._102_in_typeDecl1622); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal84);



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
				// 287:2: -> ^( Record ID varList )
				{
					DebugLocation(287, 5);
					// Plsql.g:287:5: ^( Record ID varList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(287, 7);
					root_1 = (object)adaptor.BecomeRoot(new RecordNode(Record), root_1);

					DebugLocation(287, 26);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(287, 29);
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
		DebugLocation(288, 1);
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
	// Plsql.g:292:1: object_ : ( objectDecl | objectBody );
	[GrammarRule("object_")]
	private PlsqlParser.object__return object_()
	{
		Enter_object_();
		EnterRule("object_", 24);
		TraceIn("object_", 24);
		PlsqlParser.object__return retval = new PlsqlParser.object__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.objectDecl_return objectDecl85 = default(PlsqlParser.objectDecl_return);
		PlsqlParser.objectBody_return objectBody86 = default(PlsqlParser.objectBody_return);


		try { DebugEnterRule(GrammarFileName, "object_");
		DebugLocation(292, 1);
		try
		{
			// Plsql.g:293:2: ( objectDecl | objectBody )
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
				// Plsql.g:293:4: objectDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(293, 4);
				PushFollow(Follow._objectDecl_in_object_1649);
				objectDecl85=objectDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectDecl85.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:294:4: objectBody
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(294, 4);
				PushFollow(Follow._objectBody_in_object_1654);
				objectBody86=objectBody();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectBody86.Tree);

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
		DebugLocation(295, 1);
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
	// Plsql.g:297:1: objectDecl : CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) ;
	[GrammarRule("objectDecl")]
	private PlsqlParser.objectDecl_return objectDecl()
	{
		Enter_objectDecl();
		EnterRule("objectDecl", 25);
		TraceIn("objectDecl", 25);
		PlsqlParser.objectDecl_return retval = new PlsqlParser.objectDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE87=null;
		IToken TYPE88=null;
		IToken ID89=null;
		IToken OBJECT91=null;
		IToken char_literal92=null;
		IToken char_literal94=null;
		IToken char_literal95=null;
		PlsqlParser.isOrAs_return isOrAs90 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.objectDeclItem_return objectDeclItem93 = default(PlsqlParser.objectDeclItem_return);

		object CREATE87_tree=null;
		object TYPE88_tree=null;
		object ID89_tree=null;
		object OBJECT91_tree=null;
		object char_literal92_tree=null;
		object char_literal94_tree=null;
		object char_literal95_tree=null;
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_OBJECT=new RewriteRuleITokenStream(adaptor,"token OBJECT");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");
		RewriteRuleSubtreeStream stream_objectDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule objectDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "objectDecl");
		DebugLocation(297, 1);
		try
		{
			// Plsql.g:298:2: ( CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';' -> ^( ClassDecl ID ( objectDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:298:4: CREATE TYPE ID isOrAs OBJECT '(' ( objectDeclItem )+ ')' ';'
			{
			DebugLocation(298, 4);
			CREATE87=(IToken)Match(input,CREATE,Follow._CREATE_in_objectDecl1665); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE87);

			DebugLocation(298, 11);
			TYPE88=(IToken)Match(input,TYPE,Follow._TYPE_in_objectDecl1667); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE88);

			DebugLocation(298, 16);
			ID89=(IToken)Match(input,ID,Follow._ID_in_objectDecl1669); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID89);

			DebugLocation(298, 19);
			PushFollow(Follow._isOrAs_in_objectDecl1671);
			isOrAs90=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs90.Tree);
			DebugLocation(298, 26);
			OBJECT91=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectDecl1673); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT91);

			DebugLocation(298, 33);
			char_literal92=(IToken)Match(input,101,Follow._101_in_objectDecl1675); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal92);

			DebugLocation(298, 37);
			// Plsql.g:298:37: ( objectDeclItem )+
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
					DebugLocation(298, 37);
					PushFollow(Follow._objectDeclItem_in_objectDecl1677);
					objectDeclItem93=objectDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_objectDeclItem.Add(objectDeclItem93.Tree);

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

			DebugLocation(298, 53);
			char_literal94=(IToken)Match(input,102,Follow._102_in_objectDecl1680); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal94);

			DebugLocation(298, 57);
			char_literal95=(IToken)Match(input,104,Follow._104_in_objectDecl1682); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal95);



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
			// 299:2: -> ^( ClassDecl ID ( objectDeclItem )+ )
			{
				DebugLocation(299, 5);
				// Plsql.g:299:5: ^( ClassDecl ID ( objectDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(299, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDeclNode(ClassDecl), root_1);

				DebugLocation(299, 32);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(299, 35);
				if ( !(stream_objectDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_objectDeclItem.HasNext )
				{
					DebugLocation(299, 35);
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
		DebugLocation(300, 1);
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
	// Plsql.g:302:1: objectBody : CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) ;
	[GrammarRule("objectBody")]
	private PlsqlParser.objectBody_return objectBody()
	{
		Enter_objectBody();
		EnterRule("objectBody", 26);
		TraceIn("objectBody", 26);
		PlsqlParser.objectBody_return retval = new PlsqlParser.objectBody_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE96=null;
		IToken TYPE97=null;
		IToken BODY98=null;
		IToken ID99=null;
		IToken OBJECT101=null;
		IToken char_literal103=null;
		IToken END104=null;
		IToken char_literal105=null;
		PlsqlParser.isOrAs_return isOrAs100 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.methodDef_return methodDef102 = default(PlsqlParser.methodDef_return);

		object CREATE96_tree=null;
		object TYPE97_tree=null;
		object BODY98_tree=null;
		object ID99_tree=null;
		object OBJECT101_tree=null;
		object char_literal103_tree=null;
		object END104_tree=null;
		object char_literal105_tree=null;
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
		DebugLocation(302, 1);
		try
		{
			// Plsql.g:303:2: ( CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';' -> ^( ClassDef ID ( methodDef )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:303:4: CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';'
			{
			DebugLocation(303, 4);
			CREATE96=(IToken)Match(input,CREATE,Follow._CREATE_in_objectBody1708); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE96);

			DebugLocation(303, 11);
			TYPE97=(IToken)Match(input,TYPE,Follow._TYPE_in_objectBody1710); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TYPE.Add(TYPE97);

			DebugLocation(303, 16);
			BODY98=(IToken)Match(input,BODY,Follow._BODY_in_objectBody1712); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY98);

			DebugLocation(303, 21);
			ID99=(IToken)Match(input,ID,Follow._ID_in_objectBody1714); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID99);

			DebugLocation(303, 24);
			PushFollow(Follow._isOrAs_in_objectBody1716);
			isOrAs100=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs100.Tree);
			DebugLocation(303, 31);
			OBJECT101=(IToken)Match(input,OBJECT,Follow._OBJECT_in_objectBody1718); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OBJECT.Add(OBJECT101);

			DebugLocation(303, 38);
			// Plsql.g:303:38: ( methodDef ';' )+
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
					// Plsql.g:303:40: methodDef ';'
					{
					DebugLocation(303, 40);
					PushFollow(Follow._methodDef_in_objectBody1722);
					methodDef102=methodDef();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_methodDef.Add(methodDef102.Tree);
					DebugLocation(303, 50);
					char_literal103=(IToken)Match(input,104,Follow._104_in_objectBody1724); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal103);


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

			DebugLocation(303, 57);
			END104=(IToken)Match(input,END,Follow._END_in_objectBody1729); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END104);

			DebugLocation(303, 61);
			char_literal105=(IToken)Match(input,104,Follow._104_in_objectBody1731); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal105);



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
			// 304:2: -> ^( ClassDef ID ( methodDef )+ )
			{
				DebugLocation(304, 5);
				// Plsql.g:304:5: ^( ClassDef ID ( methodDef )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(304, 7);
				root_1 = (object)adaptor.BecomeRoot(new ClassDefNode(ClassDef), root_1);

				DebugLocation(304, 30);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(304, 33);
				if ( !(stream_methodDef.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_methodDef.HasNext )
				{
					DebugLocation(304, 33);
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
		DebugLocation(305, 1);
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
	// Plsql.g:307:1: objectDeclItem : ( varDef ';' | methodDecl ';' );
	[GrammarRule("objectDeclItem")]
	private PlsqlParser.objectDeclItem_return objectDeclItem()
	{
		Enter_objectDeclItem();
		EnterRule("objectDeclItem", 27);
		TraceIn("objectDeclItem", 27);
		PlsqlParser.objectDeclItem_return retval = new PlsqlParser.objectDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal107=null;
		IToken char_literal109=null;
		PlsqlParser.varDef_return varDef106 = default(PlsqlParser.varDef_return);
		PlsqlParser.methodDecl_return methodDecl108 = default(PlsqlParser.methodDecl_return);

		object char_literal107_tree=null;
		object char_literal109_tree=null;

		try { DebugEnterRule(GrammarFileName, "objectDeclItem");
		DebugLocation(307, 1);
		try
		{
			// Plsql.g:308:2: ( varDef ';' | methodDecl ';' )
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
				// Plsql.g:308:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(308, 4);
				PushFollow(Follow._varDef_in_objectDeclItem1757);
				varDef106=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef106.Tree);
				DebugLocation(308, 14);
				char_literal107=(IToken)Match(input,104,Follow._104_in_objectDeclItem1759); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:309:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(309, 4);
				PushFollow(Follow._methodDecl_in_objectDeclItem1765);
				methodDecl108=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl108.Tree);
				DebugLocation(309, 18);
				char_literal109=(IToken)Match(input,104,Follow._104_in_objectDeclItem1767); if (state.failed) return retval;

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
		DebugLocation(310, 1);
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
	// Plsql.g:315:1: package_ : ( packageDecl | packageDef );
	[GrammarRule("package_")]
	private PlsqlParser.package__return package_()
	{
		Enter_package_();
		EnterRule("package_", 28);
		TraceIn("package_", 28);
		PlsqlParser.package__return retval = new PlsqlParser.package__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.packageDecl_return packageDecl110 = default(PlsqlParser.packageDecl_return);
		PlsqlParser.packageDef_return packageDef111 = default(PlsqlParser.packageDef_return);


		try { DebugEnterRule(GrammarFileName, "package_");
		DebugLocation(315, 1);
		try
		{
			// Plsql.g:316:2: ( packageDecl | packageDef )
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
				// Plsql.g:316:4: packageDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(316, 4);
				PushFollow(Follow._packageDecl_in_package_1782);
				packageDecl110=packageDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDecl110.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:317:4: packageDef
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(317, 4);
				PushFollow(Follow._packageDef_in_package_1787);
				packageDef111=packageDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, packageDef111.Tree);

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
		DebugLocation(318, 1);
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
	// Plsql.g:320:1: packageDecl : CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) ;
	[GrammarRule("packageDecl")]
	private PlsqlParser.packageDecl_return packageDecl()
	{
		Enter_packageDecl();
		EnterRule("packageDecl", 29);
		TraceIn("packageDecl", 29);
		PlsqlParser.packageDecl_return retval = new PlsqlParser.packageDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE112=null;
		IToken PACKAGE113=null;
		IToken ID114=null;
		IToken END117=null;
		IToken char_literal118=null;
		PlsqlParser.isOrAs_return isOrAs115 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageDeclItem_return packageDeclItem116 = default(PlsqlParser.packageDeclItem_return);

		object CREATE112_tree=null;
		object PACKAGE113_tree=null;
		object ID114_tree=null;
		object END117_tree=null;
		object char_literal118_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_packageDeclItem=new RewriteRuleSubtreeStream(adaptor,"rule packageDeclItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDecl");
		DebugLocation(320, 1);
		try
		{
			// Plsql.g:321:2: ( CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';' -> ^( PackageDecl ID ( packageDeclItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:321:4: CREATE PACKAGE ID isOrAs ( packageDeclItem )+ END ';'
			{
			DebugLocation(321, 4);
			CREATE112=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDecl1798); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE112);

			DebugLocation(321, 11);
			PACKAGE113=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDecl1800); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE113);

			DebugLocation(321, 19);
			ID114=(IToken)Match(input,ID,Follow._ID_in_packageDecl1802); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID114);

			DebugLocation(321, 22);
			PushFollow(Follow._isOrAs_in_packageDecl1804);
			isOrAs115=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs115.Tree);
			DebugLocation(321, 29);
			// Plsql.g:321:29: ( packageDeclItem )+
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
					DebugLocation(321, 29);
					PushFollow(Follow._packageDeclItem_in_packageDecl1806);
					packageDeclItem116=packageDeclItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageDeclItem.Add(packageDeclItem116.Tree);

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

			DebugLocation(321, 46);
			END117=(IToken)Match(input,END,Follow._END_in_packageDecl1809); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END117);

			DebugLocation(321, 50);
			char_literal118=(IToken)Match(input,104,Follow._104_in_packageDecl1811); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal118);



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
			// 322:2: -> ^( PackageDecl ID ( packageDeclItem )+ )
			{
				DebugLocation(322, 5);
				// Plsql.g:322:5: ^( PackageDecl ID ( packageDeclItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(322, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDeclNode(PackageDecl), root_1);

				DebugLocation(322, 36);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(322, 39);
				if ( !(stream_packageDeclItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageDeclItem.HasNext )
				{
					DebugLocation(322, 39);
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
		DebugLocation(323, 1);
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
	// Plsql.g:325:1: packageDef : CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) ;
	[GrammarRule("packageDef")]
	private PlsqlParser.packageDef_return packageDef()
	{
		Enter_packageDef();
		EnterRule("packageDef", 30);
		TraceIn("packageDef", 30);
		PlsqlParser.packageDef_return retval = new PlsqlParser.packageDef_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CREATE119=null;
		IToken PACKAGE120=null;
		IToken BODY121=null;
		IToken ID122=null;
		IToken END125=null;
		IToken char_literal126=null;
		PlsqlParser.isOrAs_return isOrAs123 = default(PlsqlParser.isOrAs_return);
		PlsqlParser.packageBodyItem_return packageBodyItem124 = default(PlsqlParser.packageBodyItem_return);

		object CREATE119_tree=null;
		object PACKAGE120_tree=null;
		object BODY121_tree=null;
		object ID122_tree=null;
		object END125_tree=null;
		object char_literal126_tree=null;
		RewriteRuleITokenStream stream_PACKAGE=new RewriteRuleITokenStream(adaptor,"token PACKAGE");
		RewriteRuleITokenStream stream_CREATE=new RewriteRuleITokenStream(adaptor,"token CREATE");
		RewriteRuleITokenStream stream_BODY=new RewriteRuleITokenStream(adaptor,"token BODY");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_packageBodyItem=new RewriteRuleSubtreeStream(adaptor,"rule packageBodyItem");
		RewriteRuleSubtreeStream stream_isOrAs=new RewriteRuleSubtreeStream(adaptor,"rule isOrAs");
		try { DebugEnterRule(GrammarFileName, "packageDef");
		DebugLocation(325, 1);
		try
		{
			// Plsql.g:326:2: ( CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';' -> ^( PackageDef ID ( packageBodyItem )+ ) )
			DebugEnterAlt(1);
			// Plsql.g:326:4: CREATE PACKAGE BODY ID isOrAs ( packageBodyItem )+ END ';'
			{
			DebugLocation(326, 4);
			CREATE119=(IToken)Match(input,CREATE,Follow._CREATE_in_packageDef1838); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_CREATE.Add(CREATE119);

			DebugLocation(326, 11);
			PACKAGE120=(IToken)Match(input,PACKAGE,Follow._PACKAGE_in_packageDef1840); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PACKAGE.Add(PACKAGE120);

			DebugLocation(326, 19);
			BODY121=(IToken)Match(input,BODY,Follow._BODY_in_packageDef1842); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BODY.Add(BODY121);

			DebugLocation(326, 24);
			ID122=(IToken)Match(input,ID,Follow._ID_in_packageDef1844); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID122);

			DebugLocation(326, 27);
			PushFollow(Follow._isOrAs_in_packageDef1846);
			isOrAs123=isOrAs();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_isOrAs.Add(isOrAs123.Tree);
			DebugLocation(326, 34);
			// Plsql.g:326:34: ( packageBodyItem )+
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
					DebugLocation(326, 34);
					PushFollow(Follow._packageBodyItem_in_packageDef1848);
					packageBodyItem124=packageBodyItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_packageBodyItem.Add(packageBodyItem124.Tree);

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

			DebugLocation(326, 51);
			END125=(IToken)Match(input,END,Follow._END_in_packageDef1851); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END125);

			DebugLocation(326, 55);
			char_literal126=(IToken)Match(input,104,Follow._104_in_packageDef1853); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal126);



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
			// 327:2: -> ^( PackageDef ID ( packageBodyItem )+ )
			{
				DebugLocation(327, 5);
				// Plsql.g:327:5: ^( PackageDef ID ( packageBodyItem )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(327, 7);
				root_1 = (object)adaptor.BecomeRoot(new PackageDefNode(PackageDef), root_1);

				DebugLocation(327, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(327, 37);
				if ( !(stream_packageBodyItem.HasNext) )
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_packageBodyItem.HasNext )
				{
					DebugLocation(327, 37);
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
		DebugLocation(328, 1);
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
	// Plsql.g:330:1: packageDeclItem : ( varDef ';' | typeDecl ';' | methodDecl ';' );
	[GrammarRule("packageDeclItem")]
	private PlsqlParser.packageDeclItem_return packageDeclItem()
	{
		Enter_packageDeclItem();
		EnterRule("packageDeclItem", 31);
		TraceIn("packageDeclItem", 31);
		PlsqlParser.packageDeclItem_return retval = new PlsqlParser.packageDeclItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal128=null;
		IToken char_literal130=null;
		IToken char_literal132=null;
		PlsqlParser.varDef_return varDef127 = default(PlsqlParser.varDef_return);
		PlsqlParser.typeDecl_return typeDecl129 = default(PlsqlParser.typeDecl_return);
		PlsqlParser.methodDecl_return methodDecl131 = default(PlsqlParser.methodDecl_return);

		object char_literal128_tree=null;
		object char_literal130_tree=null;
		object char_literal132_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageDeclItem");
		DebugLocation(330, 1);
		try
		{
			// Plsql.g:331:2: ( varDef ';' | typeDecl ';' | methodDecl ';' )
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
				// Plsql.g:331:4: varDef ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(331, 4);
				PushFollow(Follow._varDef_in_packageDeclItem1879);
				varDef127=varDef();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef127.Tree);
				DebugLocation(331, 14);
				char_literal128=(IToken)Match(input,104,Follow._104_in_packageDeclItem1881); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:332:4: typeDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(332, 4);
				PushFollow(Follow._typeDecl_in_packageDeclItem1887);
				typeDecl129=typeDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeDecl129.Tree);
				DebugLocation(332, 16);
				char_literal130=(IToken)Match(input,104,Follow._104_in_packageDeclItem1889); if (state.failed) return retval;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:333:4: methodDecl ';'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(333, 4);
				PushFollow(Follow._methodDecl_in_packageDeclItem1895);
				methodDecl131=methodDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDecl131.Tree);
				DebugLocation(333, 18);
				char_literal132=(IToken)Match(input,104,Follow._104_in_packageDeclItem1897); if (state.failed) return retval;

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
		DebugLocation(334, 1);
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
	// Plsql.g:336:1: packageBodyItem : methodDef ';' ;
	[GrammarRule("packageBodyItem")]
	private PlsqlParser.packageBodyItem_return packageBodyItem()
	{
		Enter_packageBodyItem();
		EnterRule("packageBodyItem", 32);
		TraceIn("packageBodyItem", 32);
		PlsqlParser.packageBodyItem_return retval = new PlsqlParser.packageBodyItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal134=null;
		PlsqlParser.methodDef_return methodDef133 = default(PlsqlParser.methodDef_return);

		object char_literal134_tree=null;

		try { DebugEnterRule(GrammarFileName, "packageBodyItem");
		DebugLocation(336, 1);
		try
		{
			// Plsql.g:337:2: ( methodDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:337:4: methodDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(337, 4);
			PushFollow(Follow._methodDef_in_packageBodyItem1909);
			methodDef133=methodDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodDef133.Tree);
			DebugLocation(337, 17);
			char_literal134=(IToken)Match(input,104,Follow._104_in_packageBodyItem1911); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(338, 1);
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
	// Plsql.g:343:1: entryPoint : DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) ;
	[GrammarRule("entryPoint")]
	private PlsqlParser.entryPoint_return entryPoint()
	{
		Enter_entryPoint();
		EnterRule("entryPoint", 33);
		TraceIn("entryPoint", 33);
		PlsqlParser.entryPoint_return retval = new PlsqlParser.entryPoint_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DECLARE135=null;
		IToken BEGIN137=null;
		IToken END139=null;
		IToken char_literal140=null;
		PlsqlParser.declareBlock_return declareBlock136 = default(PlsqlParser.declareBlock_return);
		PlsqlParser.codeBlock_return codeBlock138 = default(PlsqlParser.codeBlock_return);

		object DECLARE135_tree=null;
		object BEGIN137_tree=null;
		object END139_tree=null;
		object char_literal140_tree=null;
		RewriteRuleITokenStream stream_DECLARE=new RewriteRuleITokenStream(adaptor,"token DECLARE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		RewriteRuleSubtreeStream stream_declareBlock=new RewriteRuleSubtreeStream(adaptor,"rule declareBlock");
		try { DebugEnterRule(GrammarFileName, "entryPoint");
		DebugLocation(343, 1);
		try
		{
			// Plsql.g:344:2: ( DECLARE declareBlock BEGIN codeBlock END ';' -> ^( EntryPoint declareBlock codeBlock ) )
			DebugEnterAlt(1);
			// Plsql.g:344:4: DECLARE declareBlock BEGIN codeBlock END ';'
			{
			DebugLocation(344, 4);
			DECLARE135=(IToken)Match(input,DECLARE,Follow._DECLARE_in_entryPoint1926); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DECLARE.Add(DECLARE135);

			DebugLocation(344, 12);
			PushFollow(Follow._declareBlock_in_entryPoint1928);
			declareBlock136=declareBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declareBlock.Add(declareBlock136.Tree);
			DebugLocation(344, 25);
			BEGIN137=(IToken)Match(input,BEGIN,Follow._BEGIN_in_entryPoint1930); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN137);

			DebugLocation(344, 31);
			PushFollow(Follow._codeBlock_in_entryPoint1932);
			codeBlock138=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock138.Tree);
			DebugLocation(344, 41);
			END139=(IToken)Match(input,END,Follow._END_in_entryPoint1934); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END139);

			DebugLocation(344, 45);
			char_literal140=(IToken)Match(input,104,Follow._104_in_entryPoint1936); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_104.Add(char_literal140);



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
			// 345:2: -> ^( EntryPoint declareBlock codeBlock )
			{
				DebugLocation(345, 5);
				// Plsql.g:345:5: ^( EntryPoint declareBlock codeBlock )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(345, 7);
				root_1 = (object)adaptor.BecomeRoot(new EntryPointNode(EntryPoint), root_1);

				DebugLocation(345, 34);
				adaptor.AddChild(root_1, stream_declareBlock.NextTree());
				DebugLocation(345, 47);
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
		DebugLocation(346, 1);
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
	// Plsql.g:349:1: declareBlock : ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) ;
	[GrammarRule("declareBlock")]
	private PlsqlParser.declareBlock_return declareBlock()
	{
		Enter_declareBlock();
		EnterRule("declareBlock", 34);
		TraceIn("declareBlock", 34);
		PlsqlParser.declareBlock_return retval = new PlsqlParser.declareBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.declareItem_return declareItem141 = default(PlsqlParser.declareItem_return);

		RewriteRuleSubtreeStream stream_declareItem=new RewriteRuleSubtreeStream(adaptor,"rule declareItem");
		try { DebugEnterRule(GrammarFileName, "declareBlock");
		DebugLocation(349, 1);
		try
		{
			// Plsql.g:350:2: ( ( declareItem )* -> ^( DeclareBlock ( declareItem )* ) )
			DebugEnterAlt(1);
			// Plsql.g:350:4: ( declareItem )*
			{
			DebugLocation(350, 4);
			// Plsql.g:350:4: ( declareItem )*
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
					DebugLocation(350, 4);
					PushFollow(Follow._declareItem_in_declareBlock1962);
					declareItem141=declareItem();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_declareItem.Add(declareItem141.Tree);

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
			// 351:2: -> ^( DeclareBlock ( declareItem )* )
			{
				DebugLocation(351, 5);
				// Plsql.g:351:5: ^( DeclareBlock ( declareItem )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(351, 7);
				root_1 = (object)adaptor.BecomeRoot(new DeclareBlockNode(DeclareBlock), root_1);

				DebugLocation(351, 38);
				// Plsql.g:351:38: ( declareItem )*
				while ( stream_declareItem.HasNext )
				{
					DebugLocation(351, 38);
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
		DebugLocation(352, 1);
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
	// Plsql.g:354:1: declareItem : varDef ';' ;
	[GrammarRule("declareItem")]
	private PlsqlParser.declareItem_return declareItem()
	{
		Enter_declareItem();
		EnterRule("declareItem", 35);
		TraceIn("declareItem", 35);
		PlsqlParser.declareItem_return retval = new PlsqlParser.declareItem_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal143=null;
		PlsqlParser.varDef_return varDef142 = default(PlsqlParser.varDef_return);

		object char_literal143_tree=null;

		try { DebugEnterRule(GrammarFileName, "declareItem");
		DebugLocation(354, 1);
		try
		{
			// Plsql.g:355:2: ( varDef ';' )
			DebugEnterAlt(1);
			// Plsql.g:355:4: varDef ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(355, 4);
			PushFollow(Follow._varDef_in_declareItem1987);
			varDef142=varDef();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef142.Tree);
			DebugLocation(355, 14);
			char_literal143=(IToken)Match(input,104,Follow._104_in_declareItem1989); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
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
		DebugLocation(356, 1);
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
	// Plsql.g:358:1: codeBlock : ( command ';' )* -> ^( CodeBlock ( command )* ) ;
	[GrammarRule("codeBlock")]
	private PlsqlParser.codeBlock_return codeBlock()
	{
		Enter_codeBlock();
		EnterRule("codeBlock", 36);
		TraceIn("codeBlock", 36);
		PlsqlParser.codeBlock_return retval = new PlsqlParser.codeBlock_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal145=null;
		PlsqlParser.command_return command144 = default(PlsqlParser.command_return);

		object char_literal145_tree=null;
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleSubtreeStream stream_command=new RewriteRuleSubtreeStream(adaptor,"rule command");
		try { DebugEnterRule(GrammarFileName, "codeBlock");
		DebugLocation(358, 1);
		try
		{
			// Plsql.g:359:2: ( ( command ';' )* -> ^( CodeBlock ( command )* ) )
			DebugEnterAlt(1);
			// Plsql.g:359:4: ( command ';' )*
			{
			DebugLocation(359, 4);
			// Plsql.g:359:4: ( command ';' )*
			try { DebugEnterSubRule(25);
			while (true)
			{
				int alt25=2;
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==IF||(LA25_0>=WHILE && LA25_0<=LOOP)||LA25_0==FOR||LA25_0==TABLE||LA25_0==SELF||(LA25_0>=TRUE && LA25_0<=RETURN)||LA25_0==MINUS||LA25_0==NOT||(LA25_0>=ID && LA25_0<=QUOTED_CHAR)||LA25_0==101))
				{
					alt25=1;
				}


				} finally { DebugExitDecision(25); }
				switch ( alt25 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:359:6: command ';'
					{
					DebugLocation(359, 6);
					PushFollow(Follow._command_in_codeBlock2003);
					command144=command();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_command.Add(command144.Tree);
					DebugLocation(359, 14);
					char_literal145=(IToken)Match(input,104,Follow._104_in_codeBlock2005); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_104.Add(char_literal145);


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
			// 360:2: -> ^( CodeBlock ( command )* )
			{
				DebugLocation(360, 5);
				// Plsql.g:360:5: ^( CodeBlock ( command )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(360, 7);
				root_1 = (object)adaptor.BecomeRoot(new CodeBlockNode(CodeBlock), root_1);

				DebugLocation(360, 32);
				// Plsql.g:360:32: ( command )*
				while ( stream_command.HasNext )
				{
					DebugLocation(360, 32);
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
		DebugLocation(361, 1);
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
	// Plsql.g:363:1: command : ( assign | if_ | cycle | expression | RETURN expression );
	[GrammarRule("command")]
	private PlsqlParser.command_return command()
	{
		Enter_command();
		EnterRule("command", 37);
		TraceIn("command", 37);
		PlsqlParser.command_return retval = new PlsqlParser.command_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken RETURN150=null;
		PlsqlParser.assign_return assign146 = default(PlsqlParser.assign_return);
		PlsqlParser.if__return if_147 = default(PlsqlParser.if__return);
		PlsqlParser.cycle_return cycle148 = default(PlsqlParser.cycle_return);
		PlsqlParser.expression_return expression149 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression151 = default(PlsqlParser.expression_return);

		object RETURN150_tree=null;

		try { DebugEnterRule(GrammarFileName, "command");
		DebugLocation(363, 1);
		try
		{
			// Plsql.g:364:2: ( assign | if_ | cycle | expression | RETURN expression )
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
				// Plsql.g:364:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(364, 4);
				PushFollow(Follow._assign_in_command2031);
				assign146=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign146.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:365:4: if_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(365, 4);
				PushFollow(Follow._if__in_command2036);
				if_147=if_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, if_147.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:366:4: cycle
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(366, 4);
				PushFollow(Follow._cycle_in_command2041);
				cycle148=cycle();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cycle148.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:367:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(367, 4);
				PushFollow(Follow._expression_in_command2046);
				expression149=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression149.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:368:4: RETURN expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(368, 22);
				RETURN150=(IToken)Match(input,RETURN,Follow._RETURN_in_command2051); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				RETURN150_tree = new ReturnNode(RETURN150) ;
				root_0 = (object)adaptor.BecomeRoot(RETURN150_tree, root_0);
				}
				DebugLocation(368, 24);
				PushFollow(Follow._expression_in_command2057);
				expression151=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression151.Tree);

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
		DebugLocation(369, 1);
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
	// Plsql.g:371:1: assign : expression ASSIGN ( NULL | expression ) ;
	[GrammarRule("assign")]
	private PlsqlParser.assign_return assign()
	{
		Enter_assign();
		EnterRule("assign", 38);
		TraceIn("assign", 38);
		PlsqlParser.assign_return retval = new PlsqlParser.assign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ASSIGN153=null;
		IToken NULL154=null;
		PlsqlParser.expression_return expression152 = default(PlsqlParser.expression_return);
		PlsqlParser.expression_return expression155 = default(PlsqlParser.expression_return);

		object ASSIGN153_tree=null;
		object NULL154_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign");
		DebugLocation(371, 1);
		try
		{
			// Plsql.g:372:2: ( expression ASSIGN ( NULL | expression ) )
			DebugEnterAlt(1);
			// Plsql.g:372:4: expression ASSIGN ( NULL | expression )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(372, 4);
			PushFollow(Follow._expression_in_assign2068);
			expression152=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression152.Tree);
			DebugLocation(372, 33);
			ASSIGN153=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign2070); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN153_tree = new AssignNode(ASSIGN153) ;
			root_0 = (object)adaptor.BecomeRoot(ASSIGN153_tree, root_0);
			}
			DebugLocation(372, 35);
			// Plsql.g:372:35: ( NULL | expression )
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==NULL))
			{
				alt27=1;
			}
			else if ((LA27_0==TABLE||LA27_0==SELF||(LA27_0>=TRUE && LA27_0<=FALSE)||LA27_0==MINUS||LA27_0==NOT||(LA27_0>=ID && LA27_0<=QUOTED_CHAR)||LA27_0==101))
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
				// Plsql.g:372:37: NULL
				{
				DebugLocation(372, 37);
				NULL154=(IToken)Match(input,NULL,Follow._NULL_in_assign2078); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NULL154_tree = new TypeNode(NULL154) ;
				adaptor.AddChild(root_0, NULL154_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:372:54: expression
				{
				DebugLocation(372, 54);
				PushFollow(Follow._expression_in_assign2085);
				expression155=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression155.Tree);

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
		DebugLocation(373, 1);
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
	// Plsql.g:375:1: if_ : IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) ;
	[GrammarRule("if_")]
	private PlsqlParser.if__return if_()
	{
		Enter_if_();
		EnterRule("if_", 39);
		TraceIn("if_", 39);
		PlsqlParser.if__return retval = new PlsqlParser.if__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF156=null;
		IToken THEN158=null;
		IToken ELSE160=null;
		IToken END162=null;
		IToken IF163=null;
		PlsqlParser.expression_return expression157 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock159 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock161 = default(PlsqlParser.codeBlock_return);

		object IF156_tree=null;
		object THEN158_tree=null;
		object ELSE160_tree=null;
		object END162_tree=null;
		object IF163_tree=null;
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "if_");
		DebugLocation(375, 1);
		try
		{
			// Plsql.g:375:5: ( IF expression THEN codeBlock ( ELSE codeBlock )? END IF -> ^( IF expression codeBlock ( codeBlock )? ) )
			DebugEnterAlt(1);
			// Plsql.g:375:7: IF expression THEN codeBlock ( ELSE codeBlock )? END IF
			{
			DebugLocation(375, 7);
			IF156=(IToken)Match(input,IF,Follow._IF_in_if_2096); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF156);

			DebugLocation(375, 10);
			PushFollow(Follow._expression_in_if_2098);
			expression157=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression157.Tree);
			DebugLocation(375, 21);
			THEN158=(IToken)Match(input,THEN,Follow._THEN_in_if_2100); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_THEN.Add(THEN158);

			DebugLocation(375, 26);
			PushFollow(Follow._codeBlock_in_if_2102);
			codeBlock159=codeBlock();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock159.Tree);
			DebugLocation(375, 36);
			// Plsql.g:375:36: ( ELSE codeBlock )?
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
				// Plsql.g:375:37: ELSE codeBlock
				{
				DebugLocation(375, 37);
				ELSE160=(IToken)Match(input,ELSE,Follow._ELSE_in_if_2105); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE160);

				DebugLocation(375, 42);
				PushFollow(Follow._codeBlock_in_if_2107);
				codeBlock161=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock161.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(375, 54);
			END162=(IToken)Match(input,END,Follow._END_in_if_2111); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END162);

			DebugLocation(375, 58);
			IF163=(IToken)Match(input,IF,Follow._IF_in_if_2113); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IF.Add(IF163);



			{
			// AST REWRITE
			// elements: codeBlock, expression, IF, codeBlock
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 376:2: -> ^( IF expression codeBlock ( codeBlock )? )
			{
				DebugLocation(376, 5);
				// Plsql.g:376:5: ^( IF expression codeBlock ( codeBlock )? )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(376, 7);
				root_1 = (object)adaptor.BecomeRoot(new IfNode(stream_IF.NextToken()), root_1);

				DebugLocation(376, 18);
				adaptor.AddChild(root_1, stream_expression.NextTree());
				DebugLocation(376, 29);
				adaptor.AddChild(root_1, stream_codeBlock.NextTree());
				DebugLocation(376, 39);
				// Plsql.g:376:39: ( codeBlock )?
				if ( stream_codeBlock.HasNext )
				{
					DebugLocation(376, 39);
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
		DebugLocation(377, 1);
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
	// Plsql.g:379:1: cycle : ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) );
	[GrammarRule("cycle")]
	private PlsqlParser.cycle_return cycle()
	{
		Enter_cycle();
		EnterRule("cycle", 40);
		TraceIn("cycle", 40);
		PlsqlParser.cycle_return retval = new PlsqlParser.cycle_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE164=null;
		IToken LOOP166=null;
		IToken END168=null;
		IToken LOOP169=null;
		IToken LOOP170=null;
		IToken EXIT172=null;
		IToken WHEN173=null;
		IToken END175=null;
		IToken LOOP176=null;
		IToken FOR177=null;
		IToken char_literal178=null;
		IToken char_literal180=null;
		IToken char_literal182=null;
		IToken char_literal184=null;
		IToken END186=null;
		IToken FOR187=null;
		PlsqlParser.expression_return expression165 = default(PlsqlParser.expression_return);
		PlsqlParser.codeBlock_return codeBlock167 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.codeBlock_return codeBlock171 = default(PlsqlParser.codeBlock_return);
		PlsqlParser.expression_return expression174 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression179 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.expression_return expression181 = default(PlsqlParser.expression_return);
		PlsqlParser.assignOrExpression_return assignOrExpression183 = default(PlsqlParser.assignOrExpression_return);
		PlsqlParser.codeBlock_return codeBlock185 = default(PlsqlParser.codeBlock_return);

		object WHILE164_tree=null;
		object LOOP166_tree=null;
		object END168_tree=null;
		object LOOP169_tree=null;
		object LOOP170_tree=null;
		object EXIT172_tree=null;
		object WHEN173_tree=null;
		object END175_tree=null;
		object LOOP176_tree=null;
		object FOR177_tree=null;
		object char_literal178_tree=null;
		object char_literal180_tree=null;
		object char_literal182_tree=null;
		object char_literal184_tree=null;
		object END186_tree=null;
		object FOR187_tree=null;
		RewriteRuleITokenStream stream_EXIT=new RewriteRuleITokenStream(adaptor,"token EXIT");
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_104=new RewriteRuleITokenStream(adaptor,"token 104");
		RewriteRuleITokenStream stream_WHEN=new RewriteRuleITokenStream(adaptor,"token WHEN");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_LOOP=new RewriteRuleITokenStream(adaptor,"token LOOP");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		RewriteRuleSubtreeStream stream_assignOrExpression=new RewriteRuleSubtreeStream(adaptor,"rule assignOrExpression");
		RewriteRuleSubtreeStream stream_codeBlock=new RewriteRuleSubtreeStream(adaptor,"rule codeBlock");
		try { DebugEnterRule(GrammarFileName, "cycle");
		DebugLocation(379, 1);
		try
		{
			// Plsql.g:380:2: ( WHILE expression LOOP codeBlock END LOOP -> ^( WHILE expression codeBlock ) | LOOP codeBlock EXIT WHEN expression END LOOP -> ^( DO expression codeBlock ) | FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR -> ^( FOR assignOrExpression expression assignOrExpression codeBlock ) )
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
				// Plsql.g:380:4: WHILE expression LOOP codeBlock END LOOP
				{
				DebugLocation(380, 4);
				WHILE164=(IToken)Match(input,WHILE,Follow._WHILE_in_cycle2144); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE164);

				DebugLocation(380, 10);
				PushFollow(Follow._expression_in_cycle2146);
				expression165=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression165.Tree);
				DebugLocation(380, 21);
				LOOP166=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2148); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP166);

				DebugLocation(380, 26);
				PushFollow(Follow._codeBlock_in_cycle2150);
				codeBlock167=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock167.Tree);
				DebugLocation(380, 36);
				END168=(IToken)Match(input,END,Follow._END_in_cycle2152); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END168);

				DebugLocation(380, 40);
				LOOP169=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2154); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP169);



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
				// 381:2: -> ^( WHILE expression codeBlock )
				{
					DebugLocation(381, 5);
					// Plsql.g:381:5: ^( WHILE expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(381, 7);
					root_1 = (object)adaptor.BecomeRoot(new WhileNode(stream_WHILE.NextToken()), root_1);

					DebugLocation(381, 24);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(381, 35);
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
				// Plsql.g:382:4: LOOP codeBlock EXIT WHEN expression END LOOP
				{
				DebugLocation(382, 4);
				LOOP170=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2173); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP170);

				DebugLocation(382, 9);
				PushFollow(Follow._codeBlock_in_cycle2175);
				codeBlock171=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock171.Tree);
				DebugLocation(382, 19);
				EXIT172=(IToken)Match(input,EXIT,Follow._EXIT_in_cycle2177); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_EXIT.Add(EXIT172);

				DebugLocation(382, 24);
				WHEN173=(IToken)Match(input,WHEN,Follow._WHEN_in_cycle2179); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_WHEN.Add(WHEN173);

				DebugLocation(382, 29);
				PushFollow(Follow._expression_in_cycle2181);
				expression174=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression174.Tree);
				DebugLocation(382, 40);
				END175=(IToken)Match(input,END,Follow._END_in_cycle2183); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END175);

				DebugLocation(382, 44);
				LOOP176=(IToken)Match(input,LOOP,Follow._LOOP_in_cycle2185); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_LOOP.Add(LOOP176);



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
				// 383:2: -> ^( DO expression codeBlock )
				{
					DebugLocation(383, 5);
					// Plsql.g:383:5: ^( DO expression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(383, 7);
					root_1 = (object)adaptor.BecomeRoot(new DoWhileNode(DO), root_1);

					DebugLocation(383, 23);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(383, 34);
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
				// Plsql.g:384:4: FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR
				{
				DebugLocation(384, 4);
				FOR177=(IToken)Match(input,FOR,Follow._FOR_in_cycle2204); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR177);

				DebugLocation(384, 8);
				char_literal178=(IToken)Match(input,101,Follow._101_in_cycle2206); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal178);

				DebugLocation(384, 12);
				PushFollow(Follow._assignOrExpression_in_cycle2208);
				assignOrExpression179=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression179.Tree);
				DebugLocation(384, 31);
				char_literal180=(IToken)Match(input,104,Follow._104_in_cycle2210); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_104.Add(char_literal180);

				DebugLocation(384, 35);
				PushFollow(Follow._expression_in_cycle2212);
				expression181=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expression.Add(expression181.Tree);
				DebugLocation(384, 46);
				char_literal182=(IToken)Match(input,104,Follow._104_in_cycle2214); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_104.Add(char_literal182);

				DebugLocation(384, 50);
				PushFollow(Follow._assignOrExpression_in_cycle2216);
				assignOrExpression183=assignOrExpression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_assignOrExpression.Add(assignOrExpression183.Tree);
				DebugLocation(384, 69);
				char_literal184=(IToken)Match(input,102,Follow._102_in_cycle2218); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal184);

				DebugLocation(384, 73);
				PushFollow(Follow._codeBlock_in_cycle2220);
				codeBlock185=codeBlock();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_codeBlock.Add(codeBlock185.Tree);
				DebugLocation(384, 83);
				END186=(IToken)Match(input,END,Follow._END_in_cycle2222); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END186);

				DebugLocation(384, 87);
				FOR187=(IToken)Match(input,FOR,Follow._FOR_in_cycle2224); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR187);



				{
				// AST REWRITE
				// elements: assignOrExpression, FOR, codeBlock, expression, assignOrExpression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 385:2: -> ^( FOR assignOrExpression expression assignOrExpression codeBlock )
				{
					DebugLocation(385, 5);
					// Plsql.g:385:5: ^( FOR assignOrExpression expression assignOrExpression codeBlock )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(385, 7);
					root_1 = (object)adaptor.BecomeRoot(new ForNode(stream_FOR.NextToken()), root_1);

					DebugLocation(385, 20);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(385, 39);
					adaptor.AddChild(root_1, stream_expression.NextTree());
					DebugLocation(385, 50);
					adaptor.AddChild(root_1, stream_assignOrExpression.NextTree());
					DebugLocation(385, 69);
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
		DebugLocation(386, 1);
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
	// Plsql.g:388:1: assignOrExpression : ( assign | expression );
	[GrammarRule("assignOrExpression")]
	private PlsqlParser.assignOrExpression_return assignOrExpression()
	{
		Enter_assignOrExpression();
		EnterRule("assignOrExpression", 41);
		TraceIn("assignOrExpression", 41);
		PlsqlParser.assignOrExpression_return retval = new PlsqlParser.assignOrExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.assign_return assign188 = default(PlsqlParser.assign_return);
		PlsqlParser.expression_return expression189 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "assignOrExpression");
		DebugLocation(388, 1);
		try
		{
			// Plsql.g:389:2: ( assign | expression )
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
				// Plsql.g:389:4: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(389, 4);
				PushFollow(Follow._assign_in_assignOrExpression2253);
				assign188=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign188.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:390:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(390, 4);
				PushFollow(Follow._expression_in_assignOrExpression2258);
				expression189=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression189.Tree);

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
		DebugLocation(391, 1);
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
	// Plsql.g:393:1: expressionList : ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) ;
	[GrammarRule("expressionList")]
	private PlsqlParser.expressionList_return expressionList()
	{
		Enter_expressionList();
		EnterRule("expressionList", 42);
		TraceIn("expressionList", 42);
		PlsqlParser.expressionList_return retval = new PlsqlParser.expressionList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal191=null;
		PlsqlParser.expr__return expr_190 = default(PlsqlParser.expr__return);
		PlsqlParser.expr__return expr_192 = default(PlsqlParser.expr__return);

		object char_literal191_tree=null;
		RewriteRuleITokenStream stream_103=new RewriteRuleITokenStream(adaptor,"token 103");
		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(393, 1);
		try
		{
			// Plsql.g:394:2: ( ( expr_ ( ',' expr_ )* )? -> ^( ExpressionList ( expr_ )* ) )
			DebugEnterAlt(1);
			// Plsql.g:394:4: ( expr_ ( ',' expr_ )* )?
			{
			DebugLocation(394, 4);
			// Plsql.g:394:4: ( expr_ ( ',' expr_ )* )?
			int alt32=2;
			try { DebugEnterSubRule(32);
			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
			int LA32_0 = input.LA(1);

			if ((LA32_0==TABLE||LA32_0==SELF||(LA32_0>=TRUE && LA32_0<=FALSE)||LA32_0==MINUS||LA32_0==NOT||(LA32_0>=ID && LA32_0<=QUOTED_CHAR)||LA32_0==101))
			{
				alt32=1;
			}
			} finally { DebugExitDecision(32); }
			switch (alt32)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:394:6: expr_ ( ',' expr_ )*
				{
				DebugLocation(394, 6);
				PushFollow(Follow._expr__in_expressionList2271);
				expr_190=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expr_.Add(expr_190.Tree);
				DebugLocation(394, 12);
				// Plsql.g:394:12: ( ',' expr_ )*
				try { DebugEnterSubRule(31);
				while (true)
				{
					int alt31=2;
					try { DebugEnterDecision(31, decisionCanBacktrack[31]);
					int LA31_0 = input.LA(1);

					if ((LA31_0==103))
					{
						alt31=1;
					}


					} finally { DebugExitDecision(31); }
					switch ( alt31 )
					{
					case 1:
						DebugEnterAlt(1);
						// Plsql.g:394:14: ',' expr_
						{
						DebugLocation(394, 14);
						char_literal191=(IToken)Match(input,103,Follow._103_in_expressionList2275); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_103.Add(char_literal191);

						DebugLocation(394, 18);
						PushFollow(Follow._expr__in_expressionList2277);
						expr_192=expr_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_expr_.Add(expr_192.Tree);

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
			// 395:2: -> ^( ExpressionList ( expr_ )* )
			{
				DebugLocation(395, 5);
				// Plsql.g:395:5: ^( ExpressionList ( expr_ )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(395, 7);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ExpressionList, "ExpressionList"), root_1);

				DebugLocation(395, 22);
				// Plsql.g:395:22: ( expr_ )*
				while ( stream_expr_.HasNext )
				{
					DebugLocation(395, 22);
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
		DebugLocation(396, 1);
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
	// Plsql.g:401:1: expression : expr_ -> ^( Expression expr_ ) ;
	[GrammarRule("expression")]
	private PlsqlParser.expression_return expression()
	{
		Enter_expression();
		EnterRule("expression", 43);
		TraceIn("expression", 43);
		PlsqlParser.expression_return retval = new PlsqlParser.expression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expr__return expr_193 = default(PlsqlParser.expr__return);

		RewriteRuleSubtreeStream stream_expr_=new RewriteRuleSubtreeStream(adaptor,"rule expr_");
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(401, 1);
		try
		{
			// Plsql.g:402:2: ( expr_ -> ^( Expression expr_ ) )
			DebugEnterAlt(1);
			// Plsql.g:402:4: expr_
			{
			DebugLocation(402, 4);
			PushFollow(Follow._expr__in_expression2306);
			expr_193=expr_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expr_.Add(expr_193.Tree);


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
			// 403:2: -> ^( Expression expr_ )
			{
				DebugLocation(403, 5);
				// Plsql.g:403:5: ^( Expression expr_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(403, 7);
				root_1 = (object)adaptor.BecomeRoot(new ExpressionNode(Expression), root_1);

				DebugLocation(403, 34);
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
		DebugLocation(404, 1);
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
	// Plsql.g:406:1: expr_ : ( logicOr )+ ;
	[GrammarRule("expr_")]
	private PlsqlParser.expr__return expr_()
	{
		Enter_expr_();
		EnterRule("expr_", 44);
		TraceIn("expr_", 44);
		PlsqlParser.expr__return retval = new PlsqlParser.expr__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.logicOr_return logicOr194 = default(PlsqlParser.logicOr_return);


		try { DebugEnterRule(GrammarFileName, "expr_");
		DebugLocation(406, 1);
		try
		{
			// Plsql.g:407:2: ( ( logicOr )+ )
			DebugEnterAlt(1);
			// Plsql.g:407:4: ( logicOr )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(407, 4);
			// Plsql.g:407:4: ( logicOr )+
			int cnt33=0;
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==TABLE||LA33_0==SELF||(LA33_0>=TRUE && LA33_0<=FALSE)||LA33_0==MINUS||LA33_0==NOT||(LA33_0>=ID && LA33_0<=QUOTED_CHAR)||LA33_0==101))
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
					DebugLocation(407, 4);
					PushFollow(Follow._logicOr_in_expr_2329);
					logicOr194=logicOr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicOr194.Tree);

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
		DebugLocation(408, 1);
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
	// Plsql.g:410:1: logicOr : logicAnd ( OR logicAnd )* ;
	[GrammarRule("logicOr")]
	private PlsqlParser.logicOr_return logicOr()
	{
		Enter_logicOr();
		EnterRule("logicOr", 45);
		TraceIn("logicOr", 45);
		PlsqlParser.logicOr_return retval = new PlsqlParser.logicOr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR196=null;
		PlsqlParser.logicAnd_return logicAnd195 = default(PlsqlParser.logicAnd_return);
		PlsqlParser.logicAnd_return logicAnd197 = default(PlsqlParser.logicAnd_return);

		object OR196_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicOr");
		DebugLocation(410, 1);
		try
		{
			// Plsql.g:411:2: ( logicAnd ( OR logicAnd )* )
			DebugEnterAlt(1);
			// Plsql.g:411:4: logicAnd ( OR logicAnd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(411, 4);
			PushFollow(Follow._logicAnd_in_logicOr2341);
			logicAnd195=logicAnd();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd195.Tree);
			DebugLocation(411, 13);
			// Plsql.g:411:13: ( OR logicAnd )*
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
					// Plsql.g:411:15: OR logicAnd
					{
					DebugLocation(411, 25);
					OR196=(IToken)Match(input,OR,Follow._OR_in_logicOr2345); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR196_tree = new OrNode(OR196) ;
					root_0 = (object)adaptor.BecomeRoot(OR196_tree, root_0);
					}
					DebugLocation(411, 27);
					PushFollow(Follow._logicAnd_in_logicOr2351);
					logicAnd197=logicAnd();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicAnd197.Tree);

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
		DebugLocation(412, 1);
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
	// Plsql.g:414:1: logicAnd : equality ( AND equality )* ;
	[GrammarRule("logicAnd")]
	private PlsqlParser.logicAnd_return logicAnd()
	{
		Enter_logicAnd();
		EnterRule("logicAnd", 46);
		TraceIn("logicAnd", 46);
		PlsqlParser.logicAnd_return retval = new PlsqlParser.logicAnd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND199=null;
		PlsqlParser.equality_return equality198 = default(PlsqlParser.equality_return);
		PlsqlParser.equality_return equality200 = default(PlsqlParser.equality_return);

		object AND199_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicAnd");
		DebugLocation(414, 1);
		try
		{
			// Plsql.g:415:2: ( equality ( AND equality )* )
			DebugEnterAlt(1);
			// Plsql.g:415:4: equality ( AND equality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(415, 4);
			PushFollow(Follow._equality_in_logicAnd2364);
			equality198=equality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality198.Tree);
			DebugLocation(415, 13);
			// Plsql.g:415:13: ( AND equality )*
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
					// Plsql.g:415:15: AND equality
					{
					DebugLocation(415, 27);
					AND199=(IToken)Match(input,AND,Follow._AND_in_logicAnd2368); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND199_tree = new AndNode(AND199) ;
					root_0 = (object)adaptor.BecomeRoot(AND199_tree, root_0);
					}
					DebugLocation(415, 29);
					PushFollow(Follow._equality_in_logicAnd2374);
					equality200=equality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equality200.Tree);

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
		DebugLocation(416, 1);
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
	// Plsql.g:418:1: equality : inequality ( equalityOperator inequality )* ;
	[GrammarRule("equality")]
	private PlsqlParser.equality_return equality()
	{
		Enter_equality();
		EnterRule("equality", 47);
		TraceIn("equality", 47);
		PlsqlParser.equality_return retval = new PlsqlParser.equality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.inequality_return inequality201 = default(PlsqlParser.inequality_return);
		PlsqlParser.equalityOperator_return equalityOperator202 = default(PlsqlParser.equalityOperator_return);
		PlsqlParser.inequality_return inequality203 = default(PlsqlParser.inequality_return);


		try { DebugEnterRule(GrammarFileName, "equality");
		DebugLocation(418, 1);
		try
		{
			// Plsql.g:419:2: ( inequality ( equalityOperator inequality )* )
			DebugEnterAlt(1);
			// Plsql.g:419:4: inequality ( equalityOperator inequality )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(419, 4);
			PushFollow(Follow._inequality_in_equality2387);
			inequality201=inequality();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality201.Tree);
			DebugLocation(419, 15);
			// Plsql.g:419:15: ( equalityOperator inequality )*
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
					// Plsql.g:419:17: equalityOperator inequality
					{
					DebugLocation(419, 33);
					PushFollow(Follow._equalityOperator_in_equality2391);
					equalityOperator202=equalityOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(equalityOperator202.Tree, root_0);
					DebugLocation(419, 35);
					PushFollow(Follow._inequality_in_equality2394);
					inequality203=inequality();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, inequality203.Tree);

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
		DebugLocation(420, 1);
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
	// Plsql.g:422:1: inequality : add ( ineqOperator add )* ;
	[GrammarRule("inequality")]
	private PlsqlParser.inequality_return inequality()
	{
		Enter_inequality();
		EnterRule("inequality", 48);
		TraceIn("inequality", 48);
		PlsqlParser.inequality_return retval = new PlsqlParser.inequality_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.add_return add204 = default(PlsqlParser.add_return);
		PlsqlParser.ineqOperator_return ineqOperator205 = default(PlsqlParser.ineqOperator_return);
		PlsqlParser.add_return add206 = default(PlsqlParser.add_return);


		try { DebugEnterRule(GrammarFileName, "inequality");
		DebugLocation(422, 1);
		try
		{
			// Plsql.g:423:2: ( add ( ineqOperator add )* )
			DebugEnterAlt(1);
			// Plsql.g:423:4: add ( ineqOperator add )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(423, 4);
			PushFollow(Follow._add_in_inequality2407);
			add204=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add204.Tree);
			DebugLocation(423, 8);
			// Plsql.g:423:8: ( ineqOperator add )*
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
					// Plsql.g:423:10: ineqOperator add
					{
					DebugLocation(423, 22);
					PushFollow(Follow._ineqOperator_in_inequality2411);
					ineqOperator205=ineqOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(ineqOperator205.Tree, root_0);
					DebugLocation(423, 24);
					PushFollow(Follow._add_in_inequality2414);
					add206=add();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add206.Tree);

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
		DebugLocation(424, 1);
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
	// Plsql.g:426:1: add : mult ( addOperator mult )* ;
	[GrammarRule("add")]
	private PlsqlParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 49);
		TraceIn("add", 49);
		PlsqlParser.add_return retval = new PlsqlParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.mult_return mult207 = default(PlsqlParser.mult_return);
		PlsqlParser.addOperator_return addOperator208 = default(PlsqlParser.addOperator_return);
		PlsqlParser.mult_return mult209 = default(PlsqlParser.mult_return);


		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(426, 4);
		try
		{
			// Plsql.g:426:5: ( mult ( addOperator mult )* )
			DebugEnterAlt(1);
			// Plsql.g:426:9: mult ( addOperator mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(426, 9);
			PushFollow(Follow._mult_in_add2428);
			mult207=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult207.Tree);
			DebugLocation(426, 14);
			// Plsql.g:426:14: ( addOperator mult )*
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
					// Plsql.g:426:16: addOperator mult
					{
					DebugLocation(426, 27);
					PushFollow(Follow._addOperator_in_add2432);
					addOperator208=addOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(addOperator208.Tree, root_0);
					DebugLocation(426, 29);
					PushFollow(Follow._mult_in_add2435);
					mult209=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult209.Tree);

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
		DebugLocation(427, 4);
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
	// Plsql.g:429:1: mult : cast ( multOperator cast )* ;
	[GrammarRule("mult")]
	private PlsqlParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 50);
		TraceIn("mult", 50);
		PlsqlParser.mult_return retval = new PlsqlParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.cast_return cast210 = default(PlsqlParser.cast_return);
		PlsqlParser.multOperator_return multOperator211 = default(PlsqlParser.multOperator_return);
		PlsqlParser.cast_return cast212 = default(PlsqlParser.cast_return);


		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(429, 1);
		try
		{
			// Plsql.g:429:5: ( cast ( multOperator cast )* )
			DebugEnterAlt(1);
			// Plsql.g:429:9: cast ( multOperator cast )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(429, 9);
			PushFollow(Follow._cast_in_mult2451);
			cast210=cast();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast210.Tree);
			DebugLocation(429, 14);
			// Plsql.g:429:14: ( multOperator cast )*
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
					// Plsql.g:429:16: multOperator cast
					{
					DebugLocation(429, 28);
					PushFollow(Follow._multOperator_in_mult2455);
					multOperator211=multOperator();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(multOperator211.Tree, root_0);
					DebugLocation(429, 30);
					PushFollow(Follow._cast_in_mult2458);
					cast212=cast();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cast212.Tree);

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
		DebugLocation(430, 1);
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
	// Plsql.g:432:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );
	[GrammarRule("cast")]
	private PlsqlParser.cast_return cast()
	{
		Enter_cast();
		EnterRule("cast", 51);
		TraceIn("cast", 51);
		PlsqlParser.cast_return retval = new PlsqlParser.cast_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal213=null;
		IToken char_literal215=null;
		PlsqlParser.type_return type214 = default(PlsqlParser.type_return);
		PlsqlParser.unary_return unary216 = default(PlsqlParser.unary_return);
		PlsqlParser.unary_return unary217 = default(PlsqlParser.unary_return);

		object char_literal213_tree=null;
		object char_literal215_tree=null;
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_unary=new RewriteRuleSubtreeStream(adaptor,"rule unary");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "cast");
		DebugLocation(432, 1);
		try
		{
			// Plsql.g:432:5: ( '(' type ')' unary -> ^( Cast unary type ) | unary )
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
				// Plsql.g:432:7: '(' type ')' unary
				{
				DebugLocation(432, 7);
				char_literal213=(IToken)Match(input,101,Follow._101_in_cast2470); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal213);

				DebugLocation(432, 11);
				PushFollow(Follow._type_in_cast2472);
				type214=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type214.Tree);
				DebugLocation(432, 16);
				char_literal215=(IToken)Match(input,102,Follow._102_in_cast2474); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal215);

				DebugLocation(432, 20);
				PushFollow(Follow._unary_in_cast2476);
				unary216=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_unary.Add(unary216.Tree);


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
				// 433:2: -> ^( Cast unary type )
				{
					DebugLocation(433, 5);
					// Plsql.g:433:5: ^( Cast unary type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(433, 7);
					root_1 = (object)adaptor.BecomeRoot(new CastNode(Cast), root_1);

					DebugLocation(433, 22);
					adaptor.AddChild(root_1, stream_unary.NextTree());
					DebugLocation(433, 28);
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
				// Plsql.g:434:4: unary
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(434, 4);
				PushFollow(Follow._unary_in_cast2495);
				unary217=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary217.Tree);

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
		DebugLocation(435, 1);
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
	// Plsql.g:437:1: unary : ( ( unaryOperator unary ) | postfix );
	[GrammarRule("unary")]
	private PlsqlParser.unary_return unary()
	{
		Enter_unary();
		EnterRule("unary", 52);
		TraceIn("unary", 52);
		PlsqlParser.unary_return retval = new PlsqlParser.unary_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.unaryOperator_return unaryOperator218 = default(PlsqlParser.unaryOperator_return);
		PlsqlParser.unary_return unary219 = default(PlsqlParser.unary_return);
		PlsqlParser.postfix_return postfix220 = default(PlsqlParser.postfix_return);


		try { DebugEnterRule(GrammarFileName, "unary");
		DebugLocation(437, 1);
		try
		{
			// Plsql.g:438:2: ( ( unaryOperator unary ) | postfix )
			int alt41=2;
			try { DebugEnterDecision(41, decisionCanBacktrack[41]);
			int LA41_0 = input.LA(1);

			if ((LA41_0==MINUS||LA41_0==NOT))
			{
				alt41=1;
			}
			else if ((LA41_0==TABLE||LA41_0==SELF||(LA41_0>=TRUE && LA41_0<=FALSE)||(LA41_0>=ID && LA41_0<=QUOTED_CHAR)||LA41_0==101))
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
				// Plsql.g:438:4: ( unaryOperator unary )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(438, 4);
				// Plsql.g:438:4: ( unaryOperator unary )
				DebugEnterAlt(1);
				// Plsql.g:438:5: unaryOperator unary
				{
				DebugLocation(438, 18);
				PushFollow(Follow._unaryOperator_in_unary2507);
				unaryOperator218=unaryOperator();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(unaryOperator218.Tree, root_0);
				DebugLocation(438, 20);
				PushFollow(Follow._unary_in_unary2510);
				unary219=unary();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unary219.Tree);

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:439:4: postfix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(439, 4);
				PushFollow(Follow._postfix_in_unary2517);
				postfix220=postfix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfix220.Tree);

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
		DebugLocation(440, 1);
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
	// Plsql.g:444:1: postfix : quant ( tmp )* ;
	[GrammarRule("postfix")]
	private PlsqlParser.postfix_return postfix()
	{
		Enter_postfix();
		EnterRule("postfix", 53);
		TraceIn("postfix", 53);
		PlsqlParser.postfix_return retval = new PlsqlParser.postfix_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.quant_return quant221 = default(PlsqlParser.quant_return);
		PlsqlParser.tmp_return tmp222 = default(PlsqlParser.tmp_return);


		try { DebugEnterRule(GrammarFileName, "postfix");
		DebugLocation(444, 1);
		try
		{
			// Plsql.g:445:2: ( quant ( tmp )* )
			DebugEnterAlt(1);
			// Plsql.g:445:4: quant ( tmp )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(445, 4);
			PushFollow(Follow._quant_in_postfix2532);
			quant221=quant();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quant221.Tree);
			DebugLocation(445, 13);
			// Plsql.g:445:13: ( tmp )*
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
					DebugLocation(445, 13);
					PushFollow(Follow._tmp_in_postfix2534);
					tmp222=tmp();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(tmp222.Tree, root_0);

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
		DebugLocation(446, 1);
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
	// Plsql.g:448:1: tmp : ( index | methodCall | memberCall );
	[GrammarRule("tmp")]
	private PlsqlParser.tmp_return tmp()
	{
		Enter_tmp();
		EnterRule("tmp", 54);
		TraceIn("tmp", 54);
		PlsqlParser.tmp_return retval = new PlsqlParser.tmp_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.index_return index223 = default(PlsqlParser.index_return);
		PlsqlParser.methodCall_return methodCall224 = default(PlsqlParser.methodCall_return);
		PlsqlParser.memberCall_return memberCall225 = default(PlsqlParser.memberCall_return);


		try { DebugEnterRule(GrammarFileName, "tmp");
		DebugLocation(448, 1);
		try
		{
			// Plsql.g:448:5: ( index | methodCall | memberCall )
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

				if ((EvaluatePredicate(synpred66_Plsql_fragment)))
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
				// Plsql.g:448:7: index
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(448, 7);
				PushFollow(Follow._index_in_tmp2546);
				index223=index();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, index223.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:449:4: methodCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(449, 4);
				PushFollow(Follow._methodCall_in_tmp2551);
				methodCall224=methodCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall224.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:450:4: memberCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(450, 4);
				PushFollow(Follow._memberCall_in_tmp2556);
				memberCall225=memberCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, memberCall225.Tree);

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
		DebugLocation(451, 1);
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
	// Plsql.g:453:1: index : '[' expression ']' -> ^( Index expression ) ;
	[GrammarRule("index")]
	private PlsqlParser.index_return index()
	{
		Enter_index();
		EnterRule("index", 55);
		TraceIn("index", 55);
		PlsqlParser.index_return retval = new PlsqlParser.index_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal226=null;
		IToken char_literal228=null;
		PlsqlParser.expression_return expression227 = default(PlsqlParser.expression_return);

		object char_literal226_tree=null;
		object char_literal228_tree=null;
		RewriteRuleITokenStream stream_106=new RewriteRuleITokenStream(adaptor,"token 106");
		RewriteRuleITokenStream stream_105=new RewriteRuleITokenStream(adaptor,"token 105");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "index");
		DebugLocation(453, 1);
		try
		{
			// Plsql.g:454:2: ( '[' expression ']' -> ^( Index expression ) )
			DebugEnterAlt(1);
			// Plsql.g:454:4: '[' expression ']'
			{
			DebugLocation(454, 4);
			char_literal226=(IToken)Match(input,105,Follow._105_in_index2567); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_105.Add(char_literal226);

			DebugLocation(454, 8);
			PushFollow(Follow._expression_in_index2569);
			expression227=expression();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expression.Add(expression227.Tree);
			DebugLocation(454, 19);
			char_literal228=(IToken)Match(input,106,Follow._106_in_index2571); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_106.Add(char_literal228);



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
			// 455:2: -> ^( Index expression )
			{
				DebugLocation(455, 5);
				// Plsql.g:455:5: ^( Index expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(455, 7);
				root_1 = (object)adaptor.BecomeRoot(new IndexNode(Index), root_1);

				DebugLocation(455, 24);
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
		DebugLocation(456, 1);
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
	// Plsql.g:458:1: memberCall : '.' ID -> ^( MemberCall ID ) ;
	[GrammarRule("memberCall")]
	private PlsqlParser.memberCall_return memberCall()
	{
		Enter_memberCall();
		EnterRule("memberCall", 56);
		TraceIn("memberCall", 56);
		PlsqlParser.memberCall_return retval = new PlsqlParser.memberCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal229=null;
		IToken ID230=null;

		object char_literal229_tree=null;
		object ID230_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");

		try { DebugEnterRule(GrammarFileName, "memberCall");
		DebugLocation(458, 1);
		try
		{
			// Plsql.g:459:2: ( '.' ID -> ^( MemberCall ID ) )
			DebugEnterAlt(1);
			// Plsql.g:459:4: '.' ID
			{
			DebugLocation(459, 4);
			char_literal229=(IToken)Match(input,100,Follow._100_in_memberCall2594); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal229);

			DebugLocation(459, 8);
			ID230=(IToken)Match(input,ID,Follow._ID_in_memberCall2596); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID230);



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
			// 460:2: -> ^( MemberCall ID )
			{
				DebugLocation(460, 5);
				// Plsql.g:460:5: ^( MemberCall ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(460, 7);
				root_1 = (object)adaptor.BecomeRoot(new MemberCallNode(MemberCall), root_1);

				DebugLocation(460, 34);
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
		DebugLocation(461, 1);
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
	// Plsql.g:463:1: expressionOrEmpty : ( expression | -> Expression );
	[GrammarRule("expressionOrEmpty")]
	private PlsqlParser.expressionOrEmpty_return expressionOrEmpty()
	{
		Enter_expressionOrEmpty();
		EnterRule("expressionOrEmpty", 57);
		TraceIn("expressionOrEmpty", 57);
		PlsqlParser.expressionOrEmpty_return retval = new PlsqlParser.expressionOrEmpty_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		PlsqlParser.expression_return expression231 = default(PlsqlParser.expression_return);


		try { DebugEnterRule(GrammarFileName, "expressionOrEmpty");
		DebugLocation(463, 1);
		try
		{
			// Plsql.g:464:2: ( expression | -> Expression )
			int alt44=2;
			try { DebugEnterDecision(44, decisionCanBacktrack[44]);
			int LA44_0 = input.LA(1);

			if ((LA44_0==TABLE||LA44_0==SELF||(LA44_0>=TRUE && LA44_0<=FALSE)||LA44_0==MINUS||LA44_0==NOT||(LA44_0>=ID && LA44_0<=QUOTED_CHAR)||LA44_0==101))
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
				// Plsql.g:464:4: expression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(464, 4);
				PushFollow(Follow._expression_in_expressionOrEmpty2619);
				expression231=expression();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression231.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:465:4: 
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
				// 465:4: -> Expression
				{
					DebugLocation(465, 7);
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
		DebugLocation(466, 1);
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
	// Plsql.g:468:1: methodCall : '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) ;
	[GrammarRule("methodCall")]
	private PlsqlParser.methodCall_return methodCall()
	{
		Enter_methodCall();
		EnterRule("methodCall", 58);
		TraceIn("methodCall", 58);
		PlsqlParser.methodCall_return retval = new PlsqlParser.methodCall_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal232=null;
		IToken ID233=null;
		IToken char_literal234=null;
		IToken char_literal236=null;
		PlsqlParser.expressionList_return expressionList235 = default(PlsqlParser.expressionList_return);

		object char_literal232_tree=null;
		object ID233_tree=null;
		object char_literal234_tree=null;
		object char_literal236_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleITokenStream stream_100=new RewriteRuleITokenStream(adaptor,"token 100");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		try { DebugEnterRule(GrammarFileName, "methodCall");
		DebugLocation(468, 1);
		try
		{
			// Plsql.g:469:2: ( '.' ID '(' expressionList ')' -> ^( MethodCall ID expressionList ) )
			DebugEnterAlt(1);
			// Plsql.g:469:4: '.' ID '(' expressionList ')'
			{
			DebugLocation(469, 4);
			char_literal232=(IToken)Match(input,100,Follow._100_in_methodCall2637); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_100.Add(char_literal232);

			DebugLocation(469, 8);
			ID233=(IToken)Match(input,ID,Follow._ID_in_methodCall2639); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID233);

			DebugLocation(469, 11);
			char_literal234=(IToken)Match(input,101,Follow._101_in_methodCall2641); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_101.Add(char_literal234);

			DebugLocation(469, 15);
			PushFollow(Follow._expressionList_in_methodCall2643);
			expressionList235=expressionList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList235.Tree);
			DebugLocation(469, 30);
			char_literal236=(IToken)Match(input,102,Follow._102_in_methodCall2645); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_102.Add(char_literal236);



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
			// 470:2: -> ^( MethodCall ID expressionList )
			{
				DebugLocation(470, 5);
				// Plsql.g:470:5: ^( MethodCall ID expressionList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(470, 7);
				root_1 = (object)adaptor.BecomeRoot(new MethodCallNode(MethodCall), root_1);

				DebugLocation(470, 34);
				adaptor.AddChild(root_1, stream_ID.NextNode());
				DebugLocation(470, 37);
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
		DebugLocation(471, 1);
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
	// Plsql.g:473:1: createInstance : ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) | TABLE '(' type ')' -> ^( CreateInstance type ) );
	[GrammarRule("createInstance")]
	private PlsqlParser.createInstance_return createInstance()
	{
		Enter_createInstance();
		EnterRule("createInstance", 59);
		TraceIn("createInstance", 59);
		PlsqlParser.createInstance_return retval = new PlsqlParser.createInstance_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID237=null;
		IToken char_literal238=null;
		IToken char_literal240=null;
		IToken TABLE241=null;
		IToken char_literal242=null;
		IToken char_literal244=null;
		PlsqlParser.expressionList_return expressionList239 = default(PlsqlParser.expressionList_return);
		PlsqlParser.type_return type243 = default(PlsqlParser.type_return);

		object ID237_tree=null;
		object char_literal238_tree=null;
		object char_literal240_tree=null;
		object TABLE241_tree=null;
		object char_literal242_tree=null;
		object char_literal244_tree=null;
		RewriteRuleITokenStream stream_TABLE=new RewriteRuleITokenStream(adaptor,"token TABLE");
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
		RewriteRuleITokenStream stream_102=new RewriteRuleITokenStream(adaptor,"token 102");
		RewriteRuleITokenStream stream_101=new RewriteRuleITokenStream(adaptor,"token 101");
		RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "createInstance");
		DebugLocation(473, 1);
		try
		{
			// Plsql.g:474:2: ( ID '(' expressionList ')' -> ^( CreateInstance ID expressionList ) | TABLE '(' type ')' -> ^( CreateInstance type ) )
			int alt45=2;
			try { DebugEnterDecision(45, decisionCanBacktrack[45]);
			int LA45_0 = input.LA(1);

			if ((LA45_0==ID))
			{
				alt45=1;
			}
			else if ((LA45_0==TABLE))
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
				// Plsql.g:474:4: ID '(' expressionList ')'
				{
				DebugLocation(474, 4);
				ID237=(IToken)Match(input,ID,Follow._ID_in_createInstance2670); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ID.Add(ID237);

				DebugLocation(474, 7);
				char_literal238=(IToken)Match(input,101,Follow._101_in_createInstance2672); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal238);

				DebugLocation(474, 11);
				PushFollow(Follow._expressionList_in_createInstance2674);
				expressionList239=expressionList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_expressionList.Add(expressionList239.Tree);
				DebugLocation(474, 26);
				char_literal240=(IToken)Match(input,102,Follow._102_in_createInstance2676); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal240);



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
				// 475:2: -> ^( CreateInstance ID expressionList )
				{
					DebugLocation(475, 5);
					// Plsql.g:475:5: ^( CreateInstance ID expressionList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(475, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateInstanceNode(CreateInstance), root_1);

					DebugLocation(475, 42);
					adaptor.AddChild(root_1, stream_ID.NextNode());
					DebugLocation(475, 45);
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
				// Plsql.g:476:4: TABLE '(' type ')'
				{
				DebugLocation(476, 4);
				TABLE241=(IToken)Match(input,TABLE,Follow._TABLE_in_createInstance2695); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TABLE.Add(TABLE241);

				DebugLocation(476, 10);
				char_literal242=(IToken)Match(input,101,Follow._101_in_createInstance2697); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_101.Add(char_literal242);

				DebugLocation(476, 14);
				PushFollow(Follow._type_in_createInstance2699);
				type243=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type243.Tree);
				DebugLocation(476, 19);
				char_literal244=(IToken)Match(input,102,Follow._102_in_createInstance2701); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_102.Add(char_literal244);



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
				// 477:2: -> ^( CreateInstance type )
				{
					DebugLocation(477, 5);
					// Plsql.g:477:5: ^( CreateInstance type )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(477, 7);
					root_1 = (object)adaptor.BecomeRoot(new CreateTableNode(CreateInstance), root_1);

					DebugLocation(477, 39);
					adaptor.AddChild(root_1, stream_type.NextTree());

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
		DebugLocation(478, 1);
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
	// Plsql.g:480:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );
	[GrammarRule("quant")]
	private PlsqlParser.quant_return quant()
	{
		Enter_quant();
		EnterRule("quant", 60);
		TraceIn("quant", 60);
		PlsqlParser.quant_return retval = new PlsqlParser.quant_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal250=null;
		IToken char_literal252=null;
		IToken SELF254=null;
		PlsqlParser.number_return number245 = default(PlsqlParser.number_return);
		PlsqlParser.bool__return bool_246 = default(PlsqlParser.bool__return);
		PlsqlParser.string__return string_247 = default(PlsqlParser.string__return);
		PlsqlParser.char__return char_248 = default(PlsqlParser.char__return);
		PlsqlParser.createInstance_return createInstance249 = default(PlsqlParser.createInstance_return);
		PlsqlParser.expr__return expr_251 = default(PlsqlParser.expr__return);
		PlsqlParser.var_return var253 = default(PlsqlParser.var_return);

		object char_literal250_tree=null;
		object char_literal252_tree=null;
		object SELF254_tree=null;

		try { DebugEnterRule(GrammarFileName, "quant");
		DebugLocation(480, 1);
		try
		{
			// Plsql.g:481:2: ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF )
			int alt46=8;
			try { DebugEnterDecision(46, decisionCanBacktrack[46]);
			try
			{
				alt46 = dfa46.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(46); }
			switch (alt46)
			{
			case 1:
				DebugEnterAlt(1);
				// Plsql.g:481:4: number
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(481, 4);
				PushFollow(Follow._number_in_quant2724);
				number245=number();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, number245.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Plsql.g:482:6: bool_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(482, 6);
				PushFollow(Follow._bool__in_quant2731);
				bool_246=bool_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bool_246.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Plsql.g:483:6: string_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(483, 6);
				PushFollow(Follow._string__in_quant2738);
				string_247=string_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_247.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Plsql.g:484:4: char_
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(484, 4);
				PushFollow(Follow._char__in_quant2743);
				char_248=char_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_248.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Plsql.g:485:6: createInstance
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(485, 6);
				PushFollow(Follow._createInstance_in_quant2750);
				createInstance249=createInstance();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, createInstance249.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Plsql.g:486:6: '(' expr_ ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(486, 9);
				char_literal250=(IToken)Match(input,101,Follow._101_in_quant2757); if (state.failed) return retval;
				DebugLocation(486, 11);
				PushFollow(Follow._expr__in_quant2760);
				expr_251=expr_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr_251.Tree);
				DebugLocation(486, 20);
				char_literal252=(IToken)Match(input,102,Follow._102_in_quant2762); if (state.failed) return retval;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Plsql.g:487:6: var
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(487, 6);
				PushFollow(Follow._var_in_quant2770);
				var253=var();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var253.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Plsql.g:488:6: SELF
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(488, 6);
				SELF254=(IToken)Match(input,SELF,Follow._SELF_in_quant2777); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				SELF254_tree = new SelfNode(SELF254) ;
				adaptor.AddChild(root_0, SELF254_tree);
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
		DebugLocation(489, 1);
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
	// Plsql.g:491:1: var : ID -> ^( ID ) ;
	[GrammarRule("var")]
	private PlsqlParser.var_return var()
	{
		Enter_var();
		EnterRule("var", 61);
		TraceIn("var", 61);
		PlsqlParser.var_return retval = new PlsqlParser.var_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID255=null;

		object ID255_tree=null;
		RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

		try { DebugEnterRule(GrammarFileName, "var");
		DebugLocation(491, 1);
		try
		{
			// Plsql.g:491:5: ( ID -> ^( ID ) )
			DebugEnterAlt(1);
			// Plsql.g:491:7: ID
			{
			DebugLocation(491, 7);
			ID255=(IToken)Match(input,ID,Follow._ID_in_var2790); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ID.Add(ID255);



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
			// 492:2: -> ^( ID )
			{
				DebugLocation(492, 5);
				// Plsql.g:492:5: ^( ID )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(492, 7);
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
		DebugLocation(493, 1);
		} finally { DebugExitRule(GrammarFileName, "var"); }
		return retval;

	}
	// $ANTLR end "var"

	partial void Enter_synpred44_Plsql_fragment();
	partial void Leave_synpred44_Plsql_fragment();

	// $ANTLR start synpred44_Plsql
	public void synpred44_Plsql_fragment()
	{
		Enter_synpred44_Plsql_fragment();
		EnterRule("synpred44_Plsql_fragment", 105);
		TraceIn("synpred44_Plsql_fragment", 105);
		try
		{
			// Plsql.g:364:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:364:4: assign
			{
			DebugLocation(364, 4);
			PushFollow(Follow._assign_in_synpred44_Plsql2031);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred44_Plsql_fragment", 105);
			LeaveRule("synpred44_Plsql_fragment", 105);
			Leave_synpred44_Plsql_fragment();
		}
	}
	// $ANTLR end synpred44_Plsql

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
			// Plsql.g:367:4: ( expression )
			DebugEnterAlt(1);
			// Plsql.g:367:4: expression
			{
			DebugLocation(367, 4);
			PushFollow(Follow._expression_in_synpred47_Plsql2046);
			expression();
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

	partial void Enter_synpred52_Plsql_fragment();
	partial void Leave_synpred52_Plsql_fragment();

	// $ANTLR start synpred52_Plsql
	public void synpred52_Plsql_fragment()
	{
		Enter_synpred52_Plsql_fragment();
		EnterRule("synpred52_Plsql_fragment", 113);
		TraceIn("synpred52_Plsql_fragment", 113);
		try
		{
			// Plsql.g:389:4: ( assign )
			DebugEnterAlt(1);
			// Plsql.g:389:4: assign
			{
			DebugLocation(389, 4);
			PushFollow(Follow._assign_in_synpred52_Plsql2253);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred52_Plsql_fragment", 113);
			LeaveRule("synpred52_Plsql_fragment", 113);
			Leave_synpred52_Plsql_fragment();
		}
	}
	// $ANTLR end synpred52_Plsql

	partial void Enter_synpred60_Plsql_fragment();
	partial void Leave_synpred60_Plsql_fragment();

	// $ANTLR start synpred60_Plsql
	public void synpred60_Plsql_fragment()
	{
		Enter_synpred60_Plsql_fragment();
		EnterRule("synpred60_Plsql_fragment", 121);
		TraceIn("synpred60_Plsql_fragment", 121);
		try
		{
			// Plsql.g:426:16: ( addOperator mult )
			DebugEnterAlt(1);
			// Plsql.g:426:16: addOperator mult
			{
			DebugLocation(426, 16);
			PushFollow(Follow._addOperator_in_synpred60_Plsql2432);
			addOperator();
			PopFollow();
			if (state.failed) return;
			DebugLocation(426, 29);
			PushFollow(Follow._mult_in_synpred60_Plsql2435);
			mult();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred60_Plsql_fragment", 121);
			LeaveRule("synpred60_Plsql_fragment", 121);
			Leave_synpred60_Plsql_fragment();
		}
	}
	// $ANTLR end synpred60_Plsql

	partial void Enter_synpred62_Plsql_fragment();
	partial void Leave_synpred62_Plsql_fragment();

	// $ANTLR start synpred62_Plsql
	public void synpred62_Plsql_fragment()
	{
		Enter_synpred62_Plsql_fragment();
		EnterRule("synpred62_Plsql_fragment", 123);
		TraceIn("synpred62_Plsql_fragment", 123);
		try
		{
			// Plsql.g:432:7: ( '(' type ')' unary )
			DebugEnterAlt(1);
			// Plsql.g:432:7: '(' type ')' unary
			{
			DebugLocation(432, 7);
			Match(input,101,Follow._101_in_synpred62_Plsql2470); if (state.failed) return;
			DebugLocation(432, 11);
			PushFollow(Follow._type_in_synpred62_Plsql2472);
			type();
			PopFollow();
			if (state.failed) return;
			DebugLocation(432, 16);
			Match(input,102,Follow._102_in_synpred62_Plsql2474); if (state.failed) return;
			DebugLocation(432, 20);
			PushFollow(Follow._unary_in_synpred62_Plsql2476);
			unary();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred62_Plsql_fragment", 123);
			LeaveRule("synpred62_Plsql_fragment", 123);
			Leave_synpred62_Plsql_fragment();
		}
	}
	// $ANTLR end synpred62_Plsql

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
			// Plsql.g:449:4: ( methodCall )
			DebugEnterAlt(1);
			// Plsql.g:449:4: methodCall
			{
			DebugLocation(449, 4);
			PushFollow(Follow._methodCall_in_synpred66_Plsql2551);
			methodCall();
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
			// Plsql.g:485:6: ( createInstance )
			DebugEnterAlt(1);
			// Plsql.g:485:6: createInstance
			{
			DebugLocation(485, 6);
			PushFollow(Follow._createInstance_in_synpred73_Plsql2750);
			createInstance();
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

	partial void Enter_synpred75_Plsql_fragment();
	partial void Leave_synpred75_Plsql_fragment();

	// $ANTLR start synpred75_Plsql
	public void synpred75_Plsql_fragment()
	{
		Enter_synpred75_Plsql_fragment();
		EnterRule("synpred75_Plsql_fragment", 136);
		TraceIn("synpred75_Plsql_fragment", 136);
		try
		{
			// Plsql.g:487:6: ( var )
			DebugEnterAlt(1);
			// Plsql.g:487:6: var
			{
			DebugLocation(487, 6);
			PushFollow(Follow._var_in_synpred75_Plsql2770);
			var();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred75_Plsql_fragment", 136);
			LeaveRule("synpred75_Plsql_fragment", 136);
			Leave_synpred75_Plsql_fragment();
		}
	}
	// $ANTLR end synpred75_Plsql
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
	DFA46 dfa46;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa3 = new DFA3( this );
		dfa26 = new DFA26( this, SpecialStateTransition26 );
		dfa30 = new DFA30( this, SpecialStateTransition30 );
		dfa38 = new DFA38( this, SpecialStateTransition38 );
		dfa40 = new DFA40( this, SpecialStateTransition40 );
		dfa46 = new DFA46( this, SpecialStateTransition46 );
	}

	private class DFA3 : DFA
	{
		private const string DFA3_eotS =
			"\xB\xFFFF";
		private const string DFA3_eofS =
			"\x7\xFFFF\x1\xA\x3\xFFFF";
		private const string DFA3_minS =
			"\x1\x22\x6\xFFFF\x1\x37\x3\xFFFF";
		private const string DFA3_maxS =
			"\x1\x5E\x6\xFFFF\x1\x68\x3\xFFFF";
		private const string DFA3_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\xFFFF\x1\x8\x1\x7\x1"+
			"\x9";
		private const string DFA3_specialS =
			"\xB\xFFFF}>";
		private static readonly string[] DFA3_transitionS =
			{
				"\x1\x2\x1\x1\x1\x3\x1\x6\x1\x4\x1\x5\x11\xFFFF\x1\x8\x24\xFFFF\x1\x7",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xA\x2C\xFFFF\x1\x9\x1\xFFFF\x3\xA",
				"",
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

		public override string Description { get { return "177:1: type : ( INT -> INT | BYTE -> BYTE | CHAR -> CHAR | DOUBLE -> DOUBLE | STRING -> STRING | BOOL -> BOOL | ID '.' ID -> ^( TypeName ID ID ) | TABLE '(' type ')' -> ^( TypeName type ) | ID -> ID );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA26 : DFA
	{
		private const string DFA26_eotS =
			"\x14\xFFFF";
		private const string DFA26_eofS =
			"\x14\xFFFF";
		private const string DFA26_minS =
			"\x1\x2A\xC\x0\x7\xFFFF";
		private const string DFA26_maxS =
			"\x1\x65\xC\x0\x7\xFFFF";
		private const string DFA26_acceptS =
			"\xD\xFFFF\x1\x2\x1\x3\x2\xFFFF\x1\x5\x1\x1\x1\x4";
		private const string DFA26_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x7\xFFFF}>";
		private static readonly string[] DFA26_transitionS =
			{
				"\x1\xD\x3\xFFFF\x2\xE\x2\xFFFF\x1\xE\x6\xFFFF\x1\xB\xB\xFFFF\x1\xC"+
				"\x2\xFFFF\x1\x6\x1\x7\x1\x11\x1\xFFFF\x1\x2\xB\xFFFF\x1\x3\x5\xFFFF"+
				"\x1\xA\x1\x4\x1\x5\x1\x8\x1\x9\x2\xFFFF\x1\x1",
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

		public override string Description { get { return "363:1: command : ( assign | if_ | cycle | expression | RETURN expression );"; } }

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
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA26_2 = input.LA(1);


				int index26_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA26_3 = input.LA(1);


				int index26_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA26_4 = input.LA(1);


				int index26_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA26_5 = input.LA(1);


				int index26_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA26_6 = input.LA(1);


				int index26_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA26_7 = input.LA(1);


				int index26_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA26_8 = input.LA(1);


				int index26_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA26_9 = input.LA(1);


				int index26_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA26_10 = input.LA(1);


				int index26_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA26_11 = input.LA(1);


				int index26_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA26_12 = input.LA(1);


				int index26_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred44_Plsql_fragment)) ) {s = 18;}

				else if ( (EvaluatePredicate(synpred47_Plsql_fragment)) ) {s = 19;}


				input.Seek(index26_12);
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
			"\xF\xFFFF";
		private const string DFA30_eofS =
			"\xF\xFFFF";
		private const string DFA30_minS =
			"\x1\x39\xC\x0\x2\xFFFF";
		private const string DFA30_maxS =
			"\x1\x65\xC\x0\x2\xFFFF";
		private const string DFA30_acceptS =
			"\xD\xFFFF\x1\x1\x1\x2";
		private const string DFA30_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x2\xFFFF}>";
		private static readonly string[] DFA30_transitionS =
			{
				"\x1\xB\xB\xFFFF\x1\xC\x2\xFFFF\x1\x6\x1\x7\x2\xFFFF\x1\x2\xB\xFFFF"+
				"\x1\x3\x5\xFFFF\x1\xA\x1\x4\x1\x5\x1\x8\x1\x9\x2\xFFFF\x1\x1",
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

		public override string Description { get { return "388:1: assignOrExpression : ( assign | expression );"; } }

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
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA30_2 = input.LA(1);


				int index30_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA30_3 = input.LA(1);


				int index30_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA30_4 = input.LA(1);


				int index30_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA30_5 = input.LA(1);


				int index30_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA30_6 = input.LA(1);


				int index30_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA30_7 = input.LA(1);


				int index30_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA30_8 = input.LA(1);


				int index30_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA30_9 = input.LA(1);


				int index30_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA30_10 = input.LA(1);


				int index30_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA30_11 = input.LA(1);


				int index30_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA30_12 = input.LA(1);


				int index30_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred52_Plsql_fragment)) ) {s = 13;}

				else if ( (true) ) {s = 14;}


				input.Seek(index30_12);
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
			"\x1F\xFFFF";
		private const string DFA38_eofS =
			"\x1\x1\x1E\xFFFF";
		private const string DFA38_minS =
			"\x1\x2B\x12\xFFFF\x1\x0\xB\xFFFF";
		private const string DFA38_maxS =
			"\x1\x6A\x12\xFFFF\x1\x0\xB\xFFFF";
		private const string DFA38_acceptS =
			"\x1\xFFFF\x1\x2\x1C\xFFFF\x1\x1";
		private const string DFA38_specialS =
			"\x13\xFFFF\x1\x0\xB\xFFFF}>";
		private static readonly string[] DFA38_transitionS =
			{
				"\x1\x1\x3\xFFFF\x1\x1\x9\xFFFF\x1\x1\x8\xFFFF\x1\x1\x2\xFFFF\x1\x1"+
				"\x2\xFFFF\x2\x1\x1\xFFFF\x1\x1E\x1\x13\x3\xFFFF\xA\x1\x4\xFFFF\x5\x1"+
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

		public override string Description { get { return "()* loopback of 426:14: ( addOperator mult )*"; } }

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
				if ( (EvaluatePredicate(synpred60_Plsql_fragment)) ) {s = 30;}

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
			"\xE\xFFFF";
		private const string DFA40_eofS =
			"\xE\xFFFF";
		private const string DFA40_minS =
			"\x1\x39\x1\x0\xC\xFFFF";
		private const string DFA40_maxS =
			"\x1\x65\x1\x0\xC\xFFFF";
		private const string DFA40_acceptS =
			"\x2\xFFFF\x1\x2\xA\xFFFF\x1\x1";
		private const string DFA40_specialS =
			"\x1\xFFFF\x1\x0\xC\xFFFF}>";
		private static readonly string[] DFA40_transitionS =
			{
				"\x1\x2\xB\xFFFF\x1\x2\x2\xFFFF\x2\x2\x2\xFFFF\x1\x2\xB\xFFFF\x1\x2"+
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

		public override string Description { get { return "432:1: cast : ( '(' type ')' unary -> ^( Cast unary type ) | unary );"; } }

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
				if ( (EvaluatePredicate(synpred62_Plsql_fragment)) ) {s = 13;}

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
	private class DFA46 : DFA
	{
		private const string DFA46_eotS =
			"\xC\xFFFF";
		private const string DFA46_eofS =
			"\xC\xFFFF";
		private const string DFA46_minS =
			"\x1\x39\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA46_maxS =
			"\x1\x65\x6\xFFFF\x1\x0\x4\xFFFF";
		private const string DFA46_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x2\x1\xFFFF\x1\x3\x1\x4\x1\xFFFF\x1\x5\x1"+
			"\x6\x1\x8\x1\x7";
		private const string DFA46_specialS =
			"\x7\xFFFF\x1\x0\x4\xFFFF}>";
		private static readonly string[] DFA46_transitionS =
			{
				"\x1\x8\xB\xFFFF\x1\xA\x2\xFFFF\x2\x3\x14\xFFFF\x1\x7\x2\x1\x1\x5\x1"+
				"\x6\x2\xFFFF\x1\x9",
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

		private static readonly short[] DFA46_eot = DFA.UnpackEncodedString(DFA46_eotS);
		private static readonly short[] DFA46_eof = DFA.UnpackEncodedString(DFA46_eofS);
		private static readonly char[] DFA46_min = DFA.UnpackEncodedStringToUnsignedChars(DFA46_minS);
		private static readonly char[] DFA46_max = DFA.UnpackEncodedStringToUnsignedChars(DFA46_maxS);
		private static readonly short[] DFA46_accept = DFA.UnpackEncodedString(DFA46_acceptS);
		private static readonly short[] DFA46_special = DFA.UnpackEncodedString(DFA46_specialS);
		private static readonly short[][] DFA46_transition;

		static DFA46()
		{
			int numStates = DFA46_transitionS.Length;
			DFA46_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA46_transition[i] = DFA.UnpackEncodedString(DFA46_transitionS[i]);
			}
		}

		public DFA46( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 46;
			this.eot = DFA46_eot;
			this.eof = DFA46_eof;
			this.min = DFA46_min;
			this.max = DFA46_max;
			this.accept = DFA46_accept;
			this.special = DFA46_special;
			this.transition = DFA46_transition;
		}

		public override string Description { get { return "480:1: quant : ( number | bool_ | string_ | char_ | createInstance | '(' expr_ ')' | var | SELF );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition46(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA46_7 = input.LA(1);


				int index46_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred73_Plsql_fragment)) ) {s = 8;}

				else if ( (EvaluatePredicate(synpred75_Plsql_fragment)) ) {s = 11;}


				input.Seek(index46_7);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 46, _s, input);
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
		public static readonly BitSet _TABLE_in_type1030 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_type1032 = new BitSet(new ulong[]{0x20000FC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_type1034 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_type1036 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1056 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objOrPack_in_program1076 = new BitSet(new ulong[]{0x8000000000000UL,0x10UL});
		public static readonly BitSet _entryPoint_in_program1079 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _object__in_objOrPack1102 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _package__in_objOrPack1108 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_isOrAs0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _EQUAL_in_equalityOperator1138 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NEQUAL_in_equalityOperator1150 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MORE_in_ineqOperator1168 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESS_in_ineqOperator1180 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOREEQ_in_ineqOperator1192 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LESSEQ_in_ineqOperator1204 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PLUS_in_addOperator1222 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_addOperator1234 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MULT_in_multOperator1252 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DIVIDE_in_multOperator1264 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MOD_in_multOperator1276 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_assignOperator0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MINUS_in_unaryOperator1325 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_unaryOperator1337 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_varDef1358 = new BitSet(new ulong[]{0x20000FC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_varDef1360 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_varList1388 = new BitSet(new ulong[]{0x2UL,0x8000000000UL});
		public static readonly BitSet _103_in_varList1392 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _varDef_in_varList1394 = new BitSet(new ulong[]{0x2UL,0x8000000000UL});
		public static readonly BitSet _procDecl_in_methodDecl1420 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcDecl_in_methodDecl1425 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _MEMBER_in_methodModifier1436 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STATIC_in_methodModifier1441 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_procDecl1459 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _PROCEDURE_in_procDecl1461 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_procDecl1463 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_procDecl1465 = new BitSet(new ulong[]{0x0UL,0x4040000000UL});
		public static readonly BitSet _varList_in_procDecl1467 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_procDecl1469 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodModifier_in_funcDecl1501 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _FUNCTION_in_funcDecl1503 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_funcDecl1505 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_funcDecl1507 = new BitSet(new ulong[]{0x0UL,0x4040000000UL});
		public static readonly BitSet _varList_in_funcDecl1509 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_funcDecl1511 = new BitSet(new ulong[]{0x0UL,0x400UL});
		public static readonly BitSet _RETURN_in_funcDecl1513 = new BitSet(new ulong[]{0x20000FC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_funcDecl1515 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_methodDef1544 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_methodDef1546 = new BitSet(new ulong[]{0x0UL,0x40000002UL});
		public static readonly BitSet _declareBlock_in_methodDef1548 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _BEGIN_in_methodDef1550 = new BitSet(new ulong[]{0x204C40000000000UL,0x27C1001724UL});
		public static readonly BitSet _codeBlock_in_methodDef1552 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_methodDef1554 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1581 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_typeDecl1583 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1585 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _TABLE_in_typeDecl1587 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _OF_in_typeDecl1589 = new BitSet(new ulong[]{0x20000FC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_typeDecl1591 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TYPE_in_typeDecl1610 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_typeDecl1612 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _IS_in_typeDecl1614 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _RECORD_in_typeDecl1616 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_typeDecl1618 = new BitSet(new ulong[]{0x0UL,0x4040000000UL});
		public static readonly BitSet _varList_in_typeDecl1620 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_typeDecl1622 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectDecl_in_object_1649 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _objectBody_in_object_1654 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectDecl1665 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectDecl1667 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_objectDecl1669 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectDecl1671 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectDecl1673 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_objectDecl1675 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _objectDeclItem_in_objectDecl1677 = new BitSet(new ulong[]{0x8060000000000000UL,0x4040000001UL});
		public static readonly BitSet _102_in_objectDecl1680 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDecl1682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_objectBody1708 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _TYPE_in_objectBody1710 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_objectBody1712 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_objectBody1714 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_objectBody1716 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _OBJECT_in_objectBody1718 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _methodDef_in_objectBody1722 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectBody1724 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_objectBody1729 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectBody1731 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_objectDeclItem1757 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDeclItem1759 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_objectDeclItem1765 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_objectDeclItem1767 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDecl_in_package_1782 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _packageDef_in_package_1787 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDecl1798 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _PACKAGE_in_packageDecl1800 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_packageDecl1802 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDecl1804 = new BitSet(new ulong[]{0x8060020000000000UL,0x40000001UL});
		public static readonly BitSet _packageDeclItem_in_packageDecl1806 = new BitSet(new ulong[]{0x8060020000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_packageDecl1809 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDecl1811 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CREATE_in_packageDef1838 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _PACKAGE_in_packageDef1840 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _BODY_in_packageDef1842 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_packageDef1844 = new BitSet(new ulong[]{0x180000000000000UL});
		public static readonly BitSet _isOrAs_in_packageDef1846 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000001UL});
		public static readonly BitSet _packageBodyItem_in_packageDef1848 = new BitSet(new ulong[]{0x8060000000000000UL,0x40000005UL});
		public static readonly BitSet _END_in_packageDef1851 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDef1853 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDef_in_packageDeclItem1879 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_packageDeclItem1887 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1889 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDecl_in_packageDeclItem1895 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageDeclItem1897 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodDef_in_packageBodyItem1909 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_packageBodyItem1911 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DECLARE_in_entryPoint1926 = new BitSet(new ulong[]{0x0UL,0x40000002UL});
		public static readonly BitSet _declareBlock_in_entryPoint1928 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _BEGIN_in_entryPoint1930 = new BitSet(new ulong[]{0x204C40000000000UL,0x27C1001724UL});
		public static readonly BitSet _codeBlock_in_entryPoint1932 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_entryPoint1934 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_entryPoint1936 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _declareItem_in_declareBlock1962 = new BitSet(new ulong[]{0x2UL,0x40000000UL});
		public static readonly BitSet _varDef_in_declareItem1987 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_declareItem1989 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _command_in_codeBlock2003 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_codeBlock2005 = new BitSet(new ulong[]{0x204C40000000002UL,0x27C1001720UL});
		public static readonly BitSet _assign_in_command2031 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _if__in_command2036 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cycle_in_command2041 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_command2046 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _RETURN_in_command2051 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expression_in_command2057 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2068 = new BitSet(new ulong[]{0x0UL,0x2000000UL});
		public static readonly BitSet _ASSIGN_in_assign2070 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001360UL});
		public static readonly BitSet _NULL_in_assign2078 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assign2085 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_if_2096 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expression_in_if_2098 = new BitSet(new ulong[]{0x80000000000UL});
		public static readonly BitSet _THEN_in_if_2100 = new BitSet(new ulong[]{0x204D40000000000UL,0x27C1001724UL});
		public static readonly BitSet _codeBlock_in_if_2102 = new BitSet(new ulong[]{0x100000000000UL,0x4UL});
		public static readonly BitSet _ELSE_in_if_2105 = new BitSet(new ulong[]{0x204C40000000000UL,0x27C1001724UL});
		public static readonly BitSet _codeBlock_in_if_2107 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_if_2111 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _IF_in_if_2113 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_cycle2144 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expression_in_cycle2146 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2148 = new BitSet(new ulong[]{0x204C40000000000UL,0x27C1001724UL});
		public static readonly BitSet _codeBlock_in_cycle2150 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2152 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2154 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LOOP_in_cycle2173 = new BitSet(new ulong[]{0x205C40000000000UL,0x27C1001720UL});
		public static readonly BitSet _codeBlock_in_cycle2175 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _EXIT_in_cycle2177 = new BitSet(new ulong[]{0x2000000000000UL});
		public static readonly BitSet _WHEN_in_cycle2179 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expression_in_cycle2181 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2183 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _LOOP_in_cycle2185 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_cycle2204 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_cycle2206 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _assignOrExpression_in_cycle2208 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_cycle2210 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expression_in_cycle2212 = new BitSet(new ulong[]{0x0UL,0x10000000000UL});
		public static readonly BitSet _104_in_cycle2214 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _assignOrExpression_in_cycle2216 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_cycle2218 = new BitSet(new ulong[]{0x204C40000000000UL,0x27C1001724UL});
		public static readonly BitSet _codeBlock_in_cycle2220 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _END_in_cycle2222 = new BitSet(new ulong[]{0x4000000000000UL});
		public static readonly BitSet _FOR_in_cycle2224 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_assignOrExpression2253 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_assignOrExpression2258 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr__in_expressionList2271 = new BitSet(new ulong[]{0x2UL,0x8000000000UL});
		public static readonly BitSet _103_in_expressionList2275 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expr__in_expressionList2277 = new BitSet(new ulong[]{0x2UL,0x8000000000UL});
		public static readonly BitSet _expr__in_expression2306 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicOr_in_expr_2329 = new BitSet(new ulong[]{0x200000000000002UL,0x27C1001320UL});
		public static readonly BitSet _logicAnd_in_logicOr2341 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _OR_in_logicOr2345 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _logicAnd_in_logicOr2351 = new BitSet(new ulong[]{0x2UL,0x20000UL});
		public static readonly BitSet _equality_in_logicAnd2364 = new BitSet(new ulong[]{0x2UL,0x10000UL});
		public static readonly BitSet _AND_in_logicAnd2368 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _equality_in_logicAnd2374 = new BitSet(new ulong[]{0x2UL,0x10000UL});
		public static readonly BitSet _inequality_in_equality2387 = new BitSet(new ulong[]{0x2UL,0xC0000UL});
		public static readonly BitSet _equalityOperator_in_equality2391 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _inequality_in_equality2394 = new BitSet(new ulong[]{0x2UL,0xC0000UL});
		public static readonly BitSet _add_in_inequality2407 = new BitSet(new ulong[]{0x2UL,0xF00000UL});
		public static readonly BitSet _ineqOperator_in_inequality2411 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _add_in_inequality2414 = new BitSet(new ulong[]{0x2UL,0xF00000UL});
		public static readonly BitSet _mult_in_add2428 = new BitSet(new ulong[]{0x2UL,0x1800UL});
		public static readonly BitSet _addOperator_in_add2432 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _mult_in_add2435 = new BitSet(new ulong[]{0x2UL,0x1800UL});
		public static readonly BitSet _cast_in_mult2451 = new BitSet(new ulong[]{0x2UL,0xE000UL});
		public static readonly BitSet _multOperator_in_mult2455 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _cast_in_mult2458 = new BitSet(new ulong[]{0x2UL,0xE000UL});
		public static readonly BitSet _101_in_cast2470 = new BitSet(new ulong[]{0x20000FC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_cast2472 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_cast2474 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _unary_in_cast2476 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unary_in_cast2495 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unaryOperator_in_unary2507 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _unary_in_unary2510 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _postfix_in_unary2517 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quant_in_postfix2532 = new BitSet(new ulong[]{0x2UL,0x21000000000UL});
		public static readonly BitSet _tmp_in_postfix2534 = new BitSet(new ulong[]{0x2UL,0x21000000000UL});
		public static readonly BitSet _index_in_tmp2546 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_tmp2551 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _memberCall_in_tmp2556 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _105_in_index2567 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expression_in_index2569 = new BitSet(new ulong[]{0x0UL,0x40000000000UL});
		public static readonly BitSet _106_in_index2571 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _100_in_memberCall2594 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_memberCall2596 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_expressionOrEmpty2619 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _100_in_methodCall2637 = new BitSet(new ulong[]{0x0UL,0x40000000UL});
		public static readonly BitSet _ID_in_methodCall2639 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_methodCall2641 = new BitSet(new ulong[]{0x200000000000000UL,0x67C1001320UL});
		public static readonly BitSet _expressionList_in_methodCall2643 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_methodCall2645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_createInstance2670 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_createInstance2672 = new BitSet(new ulong[]{0x200000000000000UL,0x67C1001320UL});
		public static readonly BitSet _expressionList_in_createInstance2674 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2676 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TABLE_in_createInstance2695 = new BitSet(new ulong[]{0x0UL,0x2000000000UL});
		public static readonly BitSet _101_in_createInstance2697 = new BitSet(new ulong[]{0x20000FC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_createInstance2699 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_createInstance2701 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _number_in_quant2724 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bool__in_quant2731 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _string__in_quant2738 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _char__in_quant2743 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_quant2750 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _101_in_quant2757 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _expr__in_quant2760 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_quant2762 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_quant2770 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _SELF_in_quant2777 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_var2790 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred44_Plsql2031 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expression_in_synpred47_Plsql2046 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred52_Plsql2253 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _addOperator_in_synpred60_Plsql2432 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _mult_in_synpred60_Plsql2435 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _101_in_synpred62_Plsql2470 = new BitSet(new ulong[]{0x20000FC00000000UL,0x40000000UL});
		public static readonly BitSet _type_in_synpred62_Plsql2472 = new BitSet(new ulong[]{0x0UL,0x4000000000UL});
		public static readonly BitSet _102_in_synpred62_Plsql2474 = new BitSet(new ulong[]{0x200000000000000UL,0x27C1001320UL});
		public static readonly BitSet _unary_in_synpred62_Plsql2476 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodCall_in_synpred66_Plsql2551 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _createInstance_in_synpred73_Plsql2750 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _var_in_synpred75_Plsql2770 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  plsql_msil 
