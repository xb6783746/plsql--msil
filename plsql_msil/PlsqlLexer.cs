// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-19 19:12:52

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  plsql_msil 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class PlsqlLexer : Antlr.Runtime.Lexer
{
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

	public PlsqlLexer()
	{
		OnCreated();
	}

	public PlsqlLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public PlsqlLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "Plsql.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 1);
		TraceIn("INT", 1);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:9:5: ( 'int' )
			DebugEnterAlt(1);
			// Plsql.g:9:7: 'int'
			{
			DebugLocation(9, 7);
			Match("int"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 1);
			LeaveRule("INT", 1);
			Leave_INT();
		}
	}
	// $ANTLR end "INT"

	partial void Enter_CHAR();
	partial void Leave_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		Enter_CHAR();
		EnterRule("CHAR", 2);
		TraceIn("CHAR", 2);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:10:6: ( 'char' )
			DebugEnterAlt(1);
			// Plsql.g:10:8: 'char'
			{
			DebugLocation(10, 8);
			Match("char"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 2);
			LeaveRule("CHAR", 2);
			Leave_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	partial void Enter_BOOL();
	partial void Leave_BOOL();

	// $ANTLR start "BOOL"
	[GrammarRule("BOOL")]
	private void mBOOL()
	{
		Enter_BOOL();
		EnterRule("BOOL", 3);
		TraceIn("BOOL", 3);
		try
		{
			int _type = BOOL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:11:6: ( 'bool' )
			DebugEnterAlt(1);
			// Plsql.g:11:8: 'bool'
			{
			DebugLocation(11, 8);
			Match("bool"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BOOL", 3);
			LeaveRule("BOOL", 3);
			Leave_BOOL();
		}
	}
	// $ANTLR end "BOOL"

	partial void Enter_DOUBLE();
	partial void Leave_DOUBLE();

	// $ANTLR start "DOUBLE"
	[GrammarRule("DOUBLE")]
	private void mDOUBLE()
	{
		Enter_DOUBLE();
		EnterRule("DOUBLE", 4);
		TraceIn("DOUBLE", 4);
		try
		{
			int _type = DOUBLE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:12:8: ( 'double' )
			DebugEnterAlt(1);
			// Plsql.g:12:10: 'double'
			{
			DebugLocation(12, 10);
			Match("double"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOUBLE", 4);
			LeaveRule("DOUBLE", 4);
			Leave_DOUBLE();
		}
	}
	// $ANTLR end "DOUBLE"

	partial void Enter_STRING();
	partial void Leave_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		Enter_STRING();
		EnterRule("STRING", 5);
		TraceIn("STRING", 5);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// Plsql.g:13:8: ( 'string' )
			DebugEnterAlt(1);
			// Plsql.g:13:10: 'string'
			{
			DebugLocation(13, 10);
			Match("string"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 5);
			LeaveRule("STRING", 5);
			Leave_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void Enter_VOID();
	partial void Leave_VOID();

	// $ANTLR start "VOID"
	[GrammarRule("VOID")]
	private void mVOID()
	{
		Enter_VOID();
		EnterRule("VOID", 6);
		TraceIn("VOID", 6);
		try
		{
			int _type = VOID;
			int _channel = DefaultTokenChannel;
			// Plsql.g:14:6: ( 'void' )
			DebugEnterAlt(1);
			// Plsql.g:14:8: 'void'
			{
			DebugLocation(14, 8);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VOID", 6);
			LeaveRule("VOID", 6);
			Leave_VOID();
		}
	}
	// $ANTLR end "VOID"

	partial void Enter_TYPE();
	partial void Leave_TYPE();

	// $ANTLR start "TYPE"
	[GrammarRule("TYPE")]
	private void mTYPE()
	{
		Enter_TYPE();
		EnterRule("TYPE", 7);
		TraceIn("TYPE", 7);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:15:6: ( 'type' )
			DebugEnterAlt(1);
			// Plsql.g:15:8: 'type'
			{
			DebugLocation(15, 8);
			Match("type"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 7);
			LeaveRule("TYPE", 7);
			Leave_TYPE();
		}
	}
	// $ANTLR end "TYPE"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 8);
		TraceIn("IF", 8);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// Plsql.g:16:4: ( 'if' )
			DebugEnterAlt(1);
			// Plsql.g:16:6: 'if'
			{
			DebugLocation(16, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 8);
			LeaveRule("IF", 8);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_THEN();
	partial void Leave_THEN();

	// $ANTLR start "THEN"
	[GrammarRule("THEN")]
	private void mTHEN()
	{
		Enter_THEN();
		EnterRule("THEN", 9);
		TraceIn("THEN", 9);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:17:6: ( 'then' )
			DebugEnterAlt(1);
			// Plsql.g:17:8: 'then'
			{
			DebugLocation(17, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 9);
			LeaveRule("THEN", 9);
			Leave_THEN();
		}
	}
	// $ANTLR end "THEN"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 10);
		TraceIn("ELSE", 10);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:18:6: ( 'else' )
			DebugEnterAlt(1);
			// Plsql.g:18:8: 'else'
			{
			DebugLocation(18, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 10);
			LeaveRule("ELSE", 10);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 11);
		TraceIn("DO", 11);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// Plsql.g:19:4: ( 'do' )
			DebugEnterAlt(1);
			// Plsql.g:19:6: 'do'
			{
			DebugLocation(19, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 11);
			LeaveRule("DO", 11);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 12);
		TraceIn("WHILE", 12);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:20:7: ( 'while' )
			DebugEnterAlt(1);
			// Plsql.g:20:9: 'while'
			{
			DebugLocation(20, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 12);
			LeaveRule("WHILE", 12);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_LOOP();
	partial void Leave_LOOP();

	// $ANTLR start "LOOP"
	[GrammarRule("LOOP")]
	private void mLOOP()
	{
		Enter_LOOP();
		EnterRule("LOOP", 13);
		TraceIn("LOOP", 13);
		try
		{
			int _type = LOOP;
			int _channel = DefaultTokenChannel;
			// Plsql.g:21:6: ( 'loop' )
			DebugEnterAlt(1);
			// Plsql.g:21:8: 'loop'
			{
			DebugLocation(21, 8);
			Match("loop"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LOOP", 13);
			LeaveRule("LOOP", 13);
			Leave_LOOP();
		}
	}
	// $ANTLR end "LOOP"

	partial void Enter_EXIT();
	partial void Leave_EXIT();

	// $ANTLR start "EXIT"
	[GrammarRule("EXIT")]
	private void mEXIT()
	{
		Enter_EXIT();
		EnterRule("EXIT", 14);
		TraceIn("EXIT", 14);
		try
		{
			int _type = EXIT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:22:6: ( 'exit' )
			DebugEnterAlt(1);
			// Plsql.g:22:8: 'exit'
			{
			DebugLocation(22, 8);
			Match("exit"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EXIT", 14);
			LeaveRule("EXIT", 14);
			Leave_EXIT();
		}
	}
	// $ANTLR end "EXIT"

	partial void Enter_WHEN();
	partial void Leave_WHEN();

	// $ANTLR start "WHEN"
	[GrammarRule("WHEN")]
	private void mWHEN()
	{
		Enter_WHEN();
		EnterRule("WHEN", 15);
		TraceIn("WHEN", 15);
		try
		{
			int _type = WHEN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:23:6: ( 'when' )
			DebugEnterAlt(1);
			// Plsql.g:23:8: 'when'
			{
			DebugLocation(23, 8);
			Match("when"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHEN", 15);
			LeaveRule("WHEN", 15);
			Leave_WHEN();
		}
	}
	// $ANTLR end "WHEN"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 16);
		TraceIn("FOR", 16);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:24:5: ( 'for' )
			DebugEnterAlt(1);
			// Plsql.g:24:7: 'for'
			{
			DebugLocation(24, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 16);
			LeaveRule("FOR", 16);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_CREATE();
	partial void Leave_CREATE();

	// $ANTLR start "CREATE"
	[GrammarRule("CREATE")]
	private void mCREATE()
	{
		Enter_CREATE();
		EnterRule("CREATE", 17);
		TraceIn("CREATE", 17);
		try
		{
			int _type = CREATE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:25:8: ( 'create' )
			DebugEnterAlt(1);
			// Plsql.g:25:10: 'create'
			{
			DebugLocation(25, 10);
			Match("create"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CREATE", 17);
			LeaveRule("CREATE", 17);
			Leave_CREATE();
		}
	}
	// $ANTLR end "CREATE"

	partial void Enter_BODY();
	partial void Leave_BODY();

	// $ANTLR start "BODY"
	[GrammarRule("BODY")]
	private void mBODY()
	{
		Enter_BODY();
		EnterRule("BODY", 18);
		TraceIn("BODY", 18);
		try
		{
			int _type = BODY;
			int _channel = DefaultTokenChannel;
			// Plsql.g:26:6: ( 'body' )
			DebugEnterAlt(1);
			// Plsql.g:26:8: 'body'
			{
			DebugLocation(26, 8);
			Match("body"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BODY", 18);
			LeaveRule("BODY", 18);
			Leave_BODY();
		}
	}
	// $ANTLR end "BODY"

	partial void Enter_PROCEDURE();
	partial void Leave_PROCEDURE();

	// $ANTLR start "PROCEDURE"
	[GrammarRule("PROCEDURE")]
	private void mPROCEDURE()
	{
		Enter_PROCEDURE();
		EnterRule("PROCEDURE", 19);
		TraceIn("PROCEDURE", 19);
		try
		{
			int _type = PROCEDURE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:27:11: ( 'procedure' )
			DebugEnterAlt(1);
			// Plsql.g:27:13: 'procedure'
			{
			DebugLocation(27, 13);
			Match("procedure"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROCEDURE", 19);
			LeaveRule("PROCEDURE", 19);
			Leave_PROCEDURE();
		}
	}
	// $ANTLR end "PROCEDURE"

	partial void Enter_FUNCTION();
	partial void Leave_FUNCTION();

	// $ANTLR start "FUNCTION"
	[GrammarRule("FUNCTION")]
	private void mFUNCTION()
	{
		Enter_FUNCTION();
		EnterRule("FUNCTION", 20);
		TraceIn("FUNCTION", 20);
		try
		{
			int _type = FUNCTION;
			int _channel = DefaultTokenChannel;
			// Plsql.g:28:10: ( 'function' )
			DebugEnterAlt(1);
			// Plsql.g:28:12: 'function'
			{
			DebugLocation(28, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCTION", 20);
			LeaveRule("FUNCTION", 20);
			Leave_FUNCTION();
		}
	}
	// $ANTLR end "FUNCTION"

	partial void Enter_IS();
	partial void Leave_IS();

	// $ANTLR start "IS"
	[GrammarRule("IS")]
	private void mIS()
	{
		Enter_IS();
		EnterRule("IS", 21);
		TraceIn("IS", 21);
		try
		{
			int _type = IS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:29:4: ( 'is' )
			DebugEnterAlt(1);
			// Plsql.g:29:6: 'is'
			{
			DebugLocation(29, 6);
			Match("is"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS", 21);
			LeaveRule("IS", 21);
			Leave_IS();
		}
	}
	// $ANTLR end "IS"

	partial void Enter_AS();
	partial void Leave_AS();

	// $ANTLR start "AS"
	[GrammarRule("AS")]
	private void mAS()
	{
		Enter_AS();
		EnterRule("AS", 22);
		TraceIn("AS", 22);
		try
		{
			int _type = AS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:30:4: ( 'as' )
			DebugEnterAlt(1);
			// Plsql.g:30:6: 'as'
			{
			DebugLocation(30, 6);
			Match("as"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AS", 22);
			LeaveRule("AS", 22);
			Leave_AS();
		}
	}
	// $ANTLR end "AS"

	partial void Enter_TABLE();
	partial void Leave_TABLE();

	// $ANTLR start "TABLE"
	[GrammarRule("TABLE")]
	private void mTABLE()
	{
		Enter_TABLE();
		EnterRule("TABLE", 23);
		TraceIn("TABLE", 23);
		try
		{
			int _type = TABLE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:31:7: ( 'table' )
			DebugEnterAlt(1);
			// Plsql.g:31:9: 'table'
			{
			DebugLocation(31, 9);
			Match("table"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TABLE", 23);
			LeaveRule("TABLE", 23);
			Leave_TABLE();
		}
	}
	// $ANTLR end "TABLE"

	partial void Enter_OF();
	partial void Leave_OF();

	// $ANTLR start "OF"
	[GrammarRule("OF")]
	private void mOF()
	{
		Enter_OF();
		EnterRule("OF", 24);
		TraceIn("OF", 24);
		try
		{
			int _type = OF;
			int _channel = DefaultTokenChannel;
			// Plsql.g:32:4: ( 'of' )
			DebugEnterAlt(1);
			// Plsql.g:32:6: 'of'
			{
			DebugLocation(32, 6);
			Match("of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OF", 24);
			LeaveRule("OF", 24);
			Leave_OF();
		}
	}
	// $ANTLR end "OF"

	partial void Enter_INDEX();
	partial void Leave_INDEX();

	// $ANTLR start "INDEX"
	[GrammarRule("INDEX")]
	private void mINDEX()
	{
		Enter_INDEX();
		EnterRule("INDEX", 25);
		TraceIn("INDEX", 25);
		try
		{
			int _type = INDEX;
			int _channel = DefaultTokenChannel;
			// Plsql.g:33:7: ( 'index' )
			DebugEnterAlt(1);
			// Plsql.g:33:9: 'index'
			{
			DebugLocation(33, 9);
			Match("index"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INDEX", 25);
			LeaveRule("INDEX", 25);
			Leave_INDEX();
		}
	}
	// $ANTLR end "INDEX"

	partial void Enter_BY();
	partial void Leave_BY();

	// $ANTLR start "BY"
	[GrammarRule("BY")]
	private void mBY()
	{
		Enter_BY();
		EnterRule("BY", 26);
		TraceIn("BY", 26);
		try
		{
			int _type = BY;
			int _channel = DefaultTokenChannel;
			// Plsql.g:34:4: ( 'by' )
			DebugEnterAlt(1);
			// Plsql.g:34:6: 'by'
			{
			DebugLocation(34, 6);
			Match("by"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BY", 26);
			LeaveRule("BY", 26);
			Leave_BY();
		}
	}
	// $ANTLR end "BY"

	partial void Enter_RECORD();
	partial void Leave_RECORD();

	// $ANTLR start "RECORD"
	[GrammarRule("RECORD")]
	private void mRECORD()
	{
		Enter_RECORD();
		EnterRule("RECORD", 27);
		TraceIn("RECORD", 27);
		try
		{
			int _type = RECORD;
			int _channel = DefaultTokenChannel;
			// Plsql.g:35:8: ( 'record' )
			DebugEnterAlt(1);
			// Plsql.g:35:10: 'record'
			{
			DebugLocation(35, 10);
			Match("record"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RECORD", 27);
			LeaveRule("RECORD", 27);
			Leave_RECORD();
		}
	}
	// $ANTLR end "RECORD"

	partial void Enter_OBJECT();
	partial void Leave_OBJECT();

	// $ANTLR start "OBJECT"
	[GrammarRule("OBJECT")]
	private void mOBJECT()
	{
		Enter_OBJECT();
		EnterRule("OBJECT", 28);
		TraceIn("OBJECT", 28);
		try
		{
			int _type = OBJECT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:36:8: ( 'object' )
			DebugEnterAlt(1);
			// Plsql.g:36:10: 'object'
			{
			DebugLocation(36, 10);
			Match("object"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OBJECT", 28);
			LeaveRule("OBJECT", 28);
			Leave_OBJECT();
		}
	}
	// $ANTLR end "OBJECT"

	partial void Enter_MEMBER();
	partial void Leave_MEMBER();

	// $ANTLR start "MEMBER"
	[GrammarRule("MEMBER")]
	private void mMEMBER()
	{
		Enter_MEMBER();
		EnterRule("MEMBER", 29);
		TraceIn("MEMBER", 29);
		try
		{
			int _type = MEMBER;
			int _channel = DefaultTokenChannel;
			// Plsql.g:37:8: ( 'member' )
			DebugEnterAlt(1);
			// Plsql.g:37:10: 'member'
			{
			DebugLocation(37, 10);
			Match("member"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MEMBER", 29);
			LeaveRule("MEMBER", 29);
			Leave_MEMBER();
		}
	}
	// $ANTLR end "MEMBER"

	partial void Enter_STATIC();
	partial void Leave_STATIC();

	// $ANTLR start "STATIC"
	[GrammarRule("STATIC")]
	private void mSTATIC()
	{
		Enter_STATIC();
		EnterRule("STATIC", 30);
		TraceIn("STATIC", 30);
		try
		{
			int _type = STATIC;
			int _channel = DefaultTokenChannel;
			// Plsql.g:38:8: ( 'static' )
			DebugEnterAlt(1);
			// Plsql.g:38:10: 'static'
			{
			DebugLocation(38, 10);
			Match("static"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STATIC", 30);
			LeaveRule("STATIC", 30);
			Leave_STATIC();
		}
	}
	// $ANTLR end "STATIC"

	partial void Enter_BEGIN();
	partial void Leave_BEGIN();

	// $ANTLR start "BEGIN"
	[GrammarRule("BEGIN")]
	private void mBEGIN()
	{
		Enter_BEGIN();
		EnterRule("BEGIN", 31);
		TraceIn("BEGIN", 31);
		try
		{
			int _type = BEGIN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:39:7: ( 'begin' )
			DebugEnterAlt(1);
			// Plsql.g:39:9: 'begin'
			{
			DebugLocation(39, 9);
			Match("begin"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BEGIN", 31);
			LeaveRule("BEGIN", 31);
			Leave_BEGIN();
		}
	}
	// $ANTLR end "BEGIN"

	partial void Enter_END();
	partial void Leave_END();

	// $ANTLR start "END"
	[GrammarRule("END")]
	private void mEND()
	{
		Enter_END();
		EnterRule("END", 32);
		TraceIn("END", 32);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// Plsql.g:40:5: ( 'end' )
			DebugEnterAlt(1);
			// Plsql.g:40:7: 'end'
			{
			DebugLocation(40, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 32);
			LeaveRule("END", 32);
			Leave_END();
		}
	}
	// $ANTLR end "END"

	partial void Enter_PACKAGE();
	partial void Leave_PACKAGE();

	// $ANTLR start "PACKAGE"
	[GrammarRule("PACKAGE")]
	private void mPACKAGE()
	{
		Enter_PACKAGE();
		EnterRule("PACKAGE", 33);
		TraceIn("PACKAGE", 33);
		try
		{
			int _type = PACKAGE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:41:9: ( 'package' )
			DebugEnterAlt(1);
			// Plsql.g:41:11: 'package'
			{
			DebugLocation(41, 11);
			Match("package"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PACKAGE", 33);
			LeaveRule("PACKAGE", 33);
			Leave_PACKAGE();
		}
	}
	// $ANTLR end "PACKAGE"

	partial void Enter_DECLARE();
	partial void Leave_DECLARE();

	// $ANTLR start "DECLARE"
	[GrammarRule("DECLARE")]
	private void mDECLARE()
	{
		Enter_DECLARE();
		EnterRule("DECLARE", 34);
		TraceIn("DECLARE", 34);
		try
		{
			int _type = DECLARE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:42:9: ( 'declare' )
			DebugEnterAlt(1);
			// Plsql.g:42:11: 'declare'
			{
			DebugLocation(42, 11);
			Match("declare"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DECLARE", 34);
			LeaveRule("DECLARE", 34);
			Leave_DECLARE();
		}
	}
	// $ANTLR end "DECLARE"

	partial void Enter_SELF();
	partial void Leave_SELF();

	// $ANTLR start "SELF"
	[GrammarRule("SELF")]
	private void mSELF()
	{
		Enter_SELF();
		EnterRule("SELF", 35);
		TraceIn("SELF", 35);
		try
		{
			int _type = SELF;
			int _channel = DefaultTokenChannel;
			// Plsql.g:43:6: ( 'self' )
			DebugEnterAlt(1);
			// Plsql.g:43:8: 'self'
			{
			DebugLocation(43, 8);
			Match("self"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SELF", 35);
			LeaveRule("SELF", 35);
			Leave_SELF();
		}
	}
	// $ANTLR end "SELF"

	partial void Enter_NULL();
	partial void Leave_NULL();

	// $ANTLR start "NULL"
	[GrammarRule("NULL")]
	private void mNULL()
	{
		Enter_NULL();
		EnterRule("NULL", 36);
		TraceIn("NULL", 36);
		try
		{
			int _type = NULL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:44:6: ( 'null' )
			DebugEnterAlt(1);
			// Plsql.g:44:8: 'null'
			{
			DebugLocation(44, 8);
			Match("null"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NULL", 36);
			LeaveRule("NULL", 36);
			Leave_NULL();
		}
	}
	// $ANTLR end "NULL"

	partial void Enter_IN();
	partial void Leave_IN();

	// $ANTLR start "IN"
	[GrammarRule("IN")]
	private void mIN()
	{
		Enter_IN();
		EnterRule("IN", 37);
		TraceIn("IN", 37);
		try
		{
			int _type = IN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:45:4: ( 'in' )
			DebugEnterAlt(1);
			// Plsql.g:45:6: 'in'
			{
			DebugLocation(45, 6);
			Match("in"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IN", 37);
			LeaveRule("IN", 37);
			Leave_IN();
		}
	}
	// $ANTLR end "IN"

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 38);
		TraceIn("TRUE", 38);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:46:6: ( 'true' )
			DebugEnterAlt(1);
			// Plsql.g:46:8: 'true'
			{
			DebugLocation(46, 8);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 38);
			LeaveRule("TRUE", 38);
			Leave_TRUE();
		}
	}
	// $ANTLR end "TRUE"

	partial void Enter_FALSE();
	partial void Leave_FALSE();

	// $ANTLR start "FALSE"
	[GrammarRule("FALSE")]
	private void mFALSE()
	{
		Enter_FALSE();
		EnterRule("FALSE", 39);
		TraceIn("FALSE", 39);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:47:7: ( 'false' )
			DebugEnterAlt(1);
			// Plsql.g:47:9: 'false'
			{
			DebugLocation(47, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 39);
			LeaveRule("FALSE", 39);
			Leave_FALSE();
		}
	}
	// $ANTLR end "FALSE"

	partial void Enter_RETURN();
	partial void Leave_RETURN();

	// $ANTLR start "RETURN"
	[GrammarRule("RETURN")]
	private void mRETURN()
	{
		Enter_RETURN();
		EnterRule("RETURN", 40);
		TraceIn("RETURN", 40);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:48:8: ( 'return' )
			DebugEnterAlt(1);
			// Plsql.g:48:10: 'return'
			{
			DebugLocation(48, 10);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 40);
			LeaveRule("RETURN", 40);
			Leave_RETURN();
		}
	}
	// $ANTLR end "RETURN"

	partial void Enter_PLUS();
	partial void Leave_PLUS();

	// $ANTLR start "PLUS"
	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		Enter_PLUS();
		EnterRule("PLUS", 41);
		TraceIn("PLUS", 41);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:49:6: ( '+' )
			DebugEnterAlt(1);
			// Plsql.g:49:8: '+'
			{
			DebugLocation(49, 8);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 41);
			LeaveRule("PLUS", 41);
			Leave_PLUS();
		}
	}
	// $ANTLR end "PLUS"

	partial void Enter_MINUS();
	partial void Leave_MINUS();

	// $ANTLR start "MINUS"
	[GrammarRule("MINUS")]
	private void mMINUS()
	{
		Enter_MINUS();
		EnterRule("MINUS", 42);
		TraceIn("MINUS", 42);
		try
		{
			int _type = MINUS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:50:7: ( '-' )
			DebugEnterAlt(1);
			// Plsql.g:50:9: '-'
			{
			DebugLocation(50, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUS", 42);
			LeaveRule("MINUS", 42);
			Leave_MINUS();
		}
	}
	// $ANTLR end "MINUS"

	partial void Enter_MULT();
	partial void Leave_MULT();

	// $ANTLR start "MULT"
	[GrammarRule("MULT")]
	private void mMULT()
	{
		Enter_MULT();
		EnterRule("MULT", 43);
		TraceIn("MULT", 43);
		try
		{
			int _type = MULT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:51:6: ( '*' )
			DebugEnterAlt(1);
			// Plsql.g:51:8: '*'
			{
			DebugLocation(51, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULT", 43);
			LeaveRule("MULT", 43);
			Leave_MULT();
		}
	}
	// $ANTLR end "MULT"

	partial void Enter_DIVIDE();
	partial void Leave_DIVIDE();

	// $ANTLR start "DIVIDE"
	[GrammarRule("DIVIDE")]
	private void mDIVIDE()
	{
		Enter_DIVIDE();
		EnterRule("DIVIDE", 44);
		TraceIn("DIVIDE", 44);
		try
		{
			int _type = DIVIDE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:52:8: ( '/' )
			DebugEnterAlt(1);
			// Plsql.g:52:10: '/'
			{
			DebugLocation(52, 10);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIVIDE", 44);
			LeaveRule("DIVIDE", 44);
			Leave_DIVIDE();
		}
	}
	// $ANTLR end "DIVIDE"

	partial void Enter_MOD();
	partial void Leave_MOD();

	// $ANTLR start "MOD"
	[GrammarRule("MOD")]
	private void mMOD()
	{
		Enter_MOD();
		EnterRule("MOD", 45);
		TraceIn("MOD", 45);
		try
		{
			int _type = MOD;
			int _channel = DefaultTokenChannel;
			// Plsql.g:53:5: ( '%' )
			DebugEnterAlt(1);
			// Plsql.g:53:7: '%'
			{
			DebugLocation(53, 7);
			Match('%'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MOD", 45);
			LeaveRule("MOD", 45);
			Leave_MOD();
		}
	}
	// $ANTLR end "MOD"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 46);
		TraceIn("AND", 46);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// Plsql.g:54:5: ( '&&' )
			DebugEnterAlt(1);
			// Plsql.g:54:7: '&&'
			{
			DebugLocation(54, 7);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 46);
			LeaveRule("AND", 46);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 47);
		TraceIn("OR", 47);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:55:4: ( '||' )
			DebugEnterAlt(1);
			// Plsql.g:55:6: '||'
			{
			DebugLocation(55, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 47);
			LeaveRule("OR", 47);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_EQUAL();
	partial void Leave_EQUAL();

	// $ANTLR start "EQUAL"
	[GrammarRule("EQUAL")]
	private void mEQUAL()
	{
		Enter_EQUAL();
		EnterRule("EQUAL", 48);
		TraceIn("EQUAL", 48);
		try
		{
			int _type = EQUAL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:56:7: ( '==' )
			DebugEnterAlt(1);
			// Plsql.g:56:9: '=='
			{
			DebugLocation(56, 9);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUAL", 48);
			LeaveRule("EQUAL", 48);
			Leave_EQUAL();
		}
	}
	// $ANTLR end "EQUAL"

	partial void Enter_NEQUAL();
	partial void Leave_NEQUAL();

	// $ANTLR start "NEQUAL"
	[GrammarRule("NEQUAL")]
	private void mNEQUAL()
	{
		Enter_NEQUAL();
		EnterRule("NEQUAL", 49);
		TraceIn("NEQUAL", 49);
		try
		{
			int _type = NEQUAL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:57:8: ( '!=' )
			DebugEnterAlt(1);
			// Plsql.g:57:10: '!='
			{
			DebugLocation(57, 10);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQUAL", 49);
			LeaveRule("NEQUAL", 49);
			Leave_NEQUAL();
		}
	}
	// $ANTLR end "NEQUAL"

	partial void Enter_MORE();
	partial void Leave_MORE();

	// $ANTLR start "MORE"
	[GrammarRule("MORE")]
	private void mMORE()
	{
		Enter_MORE();
		EnterRule("MORE", 50);
		TraceIn("MORE", 50);
		try
		{
			int _type = MORE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:58:6: ( '>' )
			DebugEnterAlt(1);
			// Plsql.g:58:8: '>'
			{
			DebugLocation(58, 8);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MORE", 50);
			LeaveRule("MORE", 50);
			Leave_MORE();
		}
	}
	// $ANTLR end "MORE"

	partial void Enter_LESS();
	partial void Leave_LESS();

	// $ANTLR start "LESS"
	[GrammarRule("LESS")]
	private void mLESS()
	{
		Enter_LESS();
		EnterRule("LESS", 51);
		TraceIn("LESS", 51);
		try
		{
			int _type = LESS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:59:6: ( '<' )
			DebugEnterAlt(1);
			// Plsql.g:59:8: '<'
			{
			DebugLocation(59, 8);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS", 51);
			LeaveRule("LESS", 51);
			Leave_LESS();
		}
	}
	// $ANTLR end "LESS"

	partial void Enter_MOREEQ();
	partial void Leave_MOREEQ();

	// $ANTLR start "MOREEQ"
	[GrammarRule("MOREEQ")]
	private void mMOREEQ()
	{
		Enter_MOREEQ();
		EnterRule("MOREEQ", 52);
		TraceIn("MOREEQ", 52);
		try
		{
			int _type = MOREEQ;
			int _channel = DefaultTokenChannel;
			// Plsql.g:60:8: ( '>=' )
			DebugEnterAlt(1);
			// Plsql.g:60:10: '>='
			{
			DebugLocation(60, 10);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MOREEQ", 52);
			LeaveRule("MOREEQ", 52);
			Leave_MOREEQ();
		}
	}
	// $ANTLR end "MOREEQ"

	partial void Enter_LESSEQ();
	partial void Leave_LESSEQ();

	// $ANTLR start "LESSEQ"
	[GrammarRule("LESSEQ")]
	private void mLESSEQ()
	{
		Enter_LESSEQ();
		EnterRule("LESSEQ", 53);
		TraceIn("LESSEQ", 53);
		try
		{
			int _type = LESSEQ;
			int _channel = DefaultTokenChannel;
			// Plsql.g:61:8: ( '<=' )
			DebugEnterAlt(1);
			// Plsql.g:61:10: '<='
			{
			DebugLocation(61, 10);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESSEQ", 53);
			LeaveRule("LESSEQ", 53);
			Leave_LESSEQ();
		}
	}
	// $ANTLR end "LESSEQ"

	partial void Enter_NOT();
	partial void Leave_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		Enter_NOT();
		EnterRule("NOT", 54);
		TraceIn("NOT", 54);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:62:5: ( '!' )
			DebugEnterAlt(1);
			// Plsql.g:62:7: '!'
			{
			DebugLocation(62, 7);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 54);
			LeaveRule("NOT", 54);
			Leave_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 55);
		TraceIn("ASSIGN", 55);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:63:8: ( ':=' )
			DebugEnterAlt(1);
			// Plsql.g:63:10: ':='
			{
			DebugLocation(63, 10);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 55);
			LeaveRule("ASSIGN", 55);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_PLUSASSIGN();
	partial void Leave_PLUSASSIGN();

	// $ANTLR start "PLUSASSIGN"
	[GrammarRule("PLUSASSIGN")]
	private void mPLUSASSIGN()
	{
		Enter_PLUSASSIGN();
		EnterRule("PLUSASSIGN", 56);
		TraceIn("PLUSASSIGN", 56);
		try
		{
			int _type = PLUSASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:64:12: ( '+=' )
			DebugEnterAlt(1);
			// Plsql.g:64:14: '+='
			{
			DebugLocation(64, 14);
			Match("+="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUSASSIGN", 56);
			LeaveRule("PLUSASSIGN", 56);
			Leave_PLUSASSIGN();
		}
	}
	// $ANTLR end "PLUSASSIGN"

	partial void Enter_MINUSASSIGN();
	partial void Leave_MINUSASSIGN();

	// $ANTLR start "MINUSASSIGN"
	[GrammarRule("MINUSASSIGN")]
	private void mMINUSASSIGN()
	{
		Enter_MINUSASSIGN();
		EnterRule("MINUSASSIGN", 57);
		TraceIn("MINUSASSIGN", 57);
		try
		{
			int _type = MINUSASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:65:13: ( '-=' )
			DebugEnterAlt(1);
			// Plsql.g:65:15: '-='
			{
			DebugLocation(65, 15);
			Match("-="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUSASSIGN", 57);
			LeaveRule("MINUSASSIGN", 57);
			Leave_MINUSASSIGN();
		}
	}
	// $ANTLR end "MINUSASSIGN"

	partial void Enter_MULTASSIGN();
	partial void Leave_MULTASSIGN();

	// $ANTLR start "MULTASSIGN"
	[GrammarRule("MULTASSIGN")]
	private void mMULTASSIGN()
	{
		Enter_MULTASSIGN();
		EnterRule("MULTASSIGN", 58);
		TraceIn("MULTASSIGN", 58);
		try
		{
			int _type = MULTASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:66:12: ( '*=' )
			DebugEnterAlt(1);
			// Plsql.g:66:14: '*='
			{
			DebugLocation(66, 14);
			Match("*="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULTASSIGN", 58);
			LeaveRule("MULTASSIGN", 58);
			Leave_MULTASSIGN();
		}
	}
	// $ANTLR end "MULTASSIGN"

	partial void Enter_DIVASSIGN();
	partial void Leave_DIVASSIGN();

	// $ANTLR start "DIVASSIGN"
	[GrammarRule("DIVASSIGN")]
	private void mDIVASSIGN()
	{
		Enter_DIVASSIGN();
		EnterRule("DIVASSIGN", 59);
		TraceIn("DIVASSIGN", 59);
		try
		{
			int _type = DIVASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:67:11: ( '/=' )
			DebugEnterAlt(1);
			// Plsql.g:67:13: '/='
			{
			DebugLocation(67, 13);
			Match("/="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIVASSIGN", 59);
			LeaveRule("DIVASSIGN", 59);
			Leave_DIVASSIGN();
		}
	}
	// $ANTLR end "DIVASSIGN"

	partial void Enter_T__97();
	partial void Leave_T__97();

	// $ANTLR start "T__97"
	[GrammarRule("T__97")]
	private void mT__97()
	{
		Enter_T__97();
		EnterRule("T__97", 60);
		TraceIn("T__97", 60);
		try
		{
			int _type = T__97;
			int _channel = DefaultTokenChannel;
			// Plsql.g:68:7: ( 'f' )
			DebugEnterAlt(1);
			// Plsql.g:68:9: 'f'
			{
			DebugLocation(68, 9);
			Match('f'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__97", 60);
			LeaveRule("T__97", 60);
			Leave_T__97();
		}
	}
	// $ANTLR end "T__97"

	partial void Enter_T__98();
	partial void Leave_T__98();

	// $ANTLR start "T__98"
	[GrammarRule("T__98")]
	private void mT__98()
	{
		Enter_T__98();
		EnterRule("T__98", 61);
		TraceIn("T__98", 61);
		try
		{
			int _type = T__98;
			int _channel = DefaultTokenChannel;
			// Plsql.g:69:7: ( '.' )
			DebugEnterAlt(1);
			// Plsql.g:69:9: '.'
			{
			DebugLocation(69, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__98", 61);
			LeaveRule("T__98", 61);
			Leave_T__98();
		}
	}
	// $ANTLR end "T__98"

	partial void Enter_T__99();
	partial void Leave_T__99();

	// $ANTLR start "T__99"
	[GrammarRule("T__99")]
	private void mT__99()
	{
		Enter_T__99();
		EnterRule("T__99", 62);
		TraceIn("T__99", 62);
		try
		{
			int _type = T__99;
			int _channel = DefaultTokenChannel;
			// Plsql.g:70:7: ( ',' )
			DebugEnterAlt(1);
			// Plsql.g:70:9: ','
			{
			DebugLocation(70, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__99", 62);
			LeaveRule("T__99", 62);
			Leave_T__99();
		}
	}
	// $ANTLR end "T__99"

	partial void Enter_T__100();
	partial void Leave_T__100();

	// $ANTLR start "T__100"
	[GrammarRule("T__100")]
	private void mT__100()
	{
		Enter_T__100();
		EnterRule("T__100", 63);
		TraceIn("T__100", 63);
		try
		{
			int _type = T__100;
			int _channel = DefaultTokenChannel;
			// Plsql.g:71:8: ( '(' )
			DebugEnterAlt(1);
			// Plsql.g:71:10: '('
			{
			DebugLocation(71, 10);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__100", 63);
			LeaveRule("T__100", 63);
			Leave_T__100();
		}
	}
	// $ANTLR end "T__100"

	partial void Enter_T__101();
	partial void Leave_T__101();

	// $ANTLR start "T__101"
	[GrammarRule("T__101")]
	private void mT__101()
	{
		Enter_T__101();
		EnterRule("T__101", 64);
		TraceIn("T__101", 64);
		try
		{
			int _type = T__101;
			int _channel = DefaultTokenChannel;
			// Plsql.g:72:8: ( ')' )
			DebugEnterAlt(1);
			// Plsql.g:72:10: ')'
			{
			DebugLocation(72, 10);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__101", 64);
			LeaveRule("T__101", 64);
			Leave_T__101();
		}
	}
	// $ANTLR end "T__101"

	partial void Enter_T__102();
	partial void Leave_T__102();

	// $ANTLR start "T__102"
	[GrammarRule("T__102")]
	private void mT__102()
	{
		Enter_T__102();
		EnterRule("T__102", 65);
		TraceIn("T__102", 65);
		try
		{
			int _type = T__102;
			int _channel = DefaultTokenChannel;
			// Plsql.g:73:8: ( ';' )
			DebugEnterAlt(1);
			// Plsql.g:73:10: ';'
			{
			DebugLocation(73, 10);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__102", 65);
			LeaveRule("T__102", 65);
			Leave_T__102();
		}
	}
	// $ANTLR end "T__102"

	partial void Enter_T__103();
	partial void Leave_T__103();

	// $ANTLR start "T__103"
	[GrammarRule("T__103")]
	private void mT__103()
	{
		Enter_T__103();
		EnterRule("T__103", 66);
		TraceIn("T__103", 66);
		try
		{
			int _type = T__103;
			int _channel = DefaultTokenChannel;
			// Plsql.g:74:8: ( '[' )
			DebugEnterAlt(1);
			// Plsql.g:74:10: '['
			{
			DebugLocation(74, 10);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__103", 66);
			LeaveRule("T__103", 66);
			Leave_T__103();
		}
	}
	// $ANTLR end "T__103"

	partial void Enter_T__104();
	partial void Leave_T__104();

	// $ANTLR start "T__104"
	[GrammarRule("T__104")]
	private void mT__104()
	{
		Enter_T__104();
		EnterRule("T__104", 67);
		TraceIn("T__104", 67);
		try
		{
			int _type = T__104;
			int _channel = DefaultTokenChannel;
			// Plsql.g:75:8: ( ']' )
			DebugEnterAlt(1);
			// Plsql.g:75:10: ']'
			{
			DebugLocation(75, 10);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__104", 67);
			LeaveRule("T__104", 67);
			Leave_T__104();
		}
	}
	// $ANTLR end "T__104"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 68);
		TraceIn("ID", 68);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// Plsql.g:132:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
			DebugEnterAlt(1);
			// Plsql.g:132:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
			{
			DebugLocation(132, 7);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(132, 31);
			// Plsql.g:132:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||LA1_0=='_'||(LA1_0>='a' && LA1_0<='z')))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:
					{
					DebugLocation(132, 31);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 68);
			LeaveRule("ID", 68);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

	partial void Enter_INTEGER();
	partial void Leave_INTEGER();

	// $ANTLR start "INTEGER"
	[GrammarRule("INTEGER")]
	private void mINTEGER()
	{
		Enter_INTEGER();
		EnterRule("INTEGER", 69);
		TraceIn("INTEGER", 69);
		try
		{
			int _type = INTEGER;
			int _channel = DefaultTokenChannel;
			// Plsql.g:136:2: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// Plsql.g:136:4: ( '0' .. '9' )+
			{
			DebugLocation(136, 4);
			// Plsql.g:136:4: ( '0' .. '9' )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='0' && LA2_0<='9')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:136:5: '0' .. '9'
					{
					DebugLocation(136, 5);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INTEGER", 69);
			LeaveRule("INTEGER", 69);
			Leave_INTEGER();
		}
	}
	// $ANTLR end "INTEGER"

	partial void Enter_REAL();
	partial void Leave_REAL();

	// $ANTLR start "REAL"
	[GrammarRule("REAL")]
	private void mREAL()
	{
		Enter_REAL();
		EnterRule("REAL", 70);
		TraceIn("REAL", 70);
		try
		{
			int _type = REAL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:140:2: ( INTEGER '.' INTEGER )
			DebugEnterAlt(1);
			// Plsql.g:140:4: INTEGER '.' INTEGER
			{
			DebugLocation(140, 4);
			mINTEGER(); 
			DebugLocation(140, 12);
			Match('.'); 
			DebugLocation(140, 16);
			mINTEGER(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REAL", 70);
			LeaveRule("REAL", 70);
			Leave_REAL();
		}
	}
	// $ANTLR end "REAL"

	partial void Enter_QUOTED_STRING();
	partial void Leave_QUOTED_STRING();

	// $ANTLR start "QUOTED_STRING"
	[GrammarRule("QUOTED_STRING")]
	private void mQUOTED_STRING()
	{
		Enter_QUOTED_STRING();
		EnterRule("QUOTED_STRING", 71);
		TraceIn("QUOTED_STRING", 71);
		try
		{
			int _type = QUOTED_STRING;
			int _channel = DefaultTokenChannel;
			// Plsql.g:154:2: ( '\"' (~ ( '\\n' | '\\r' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// Plsql.g:154:4: '\"' (~ ( '\\n' | '\\r' | '\"' ) )* '\"'
			{
			DebugLocation(154, 4);
			Match('\"'); 
			DebugLocation(154, 8);
			// Plsql.g:154:8: (~ ( '\\n' | '\\r' | '\"' ) )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='\u0000' && LA3_0<='\t')||(LA3_0>='\u000B' && LA3_0<='\f')||(LA3_0>='\u000E' && LA3_0<='!')||(LA3_0>='#' && LA3_0<='\uFFFF')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// Plsql.g:154:10: ~ ( '\\n' | '\\r' | '\"' )
					{
					DebugLocation(154, 10);
					if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='\uFFFF'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(154, 30);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUOTED_STRING", 71);
			LeaveRule("QUOTED_STRING", 71);
			Leave_QUOTED_STRING();
		}
	}
	// $ANTLR end "QUOTED_STRING"

	partial void Enter_QUOTED_CHAR();
	partial void Leave_QUOTED_CHAR();

	// $ANTLR start "QUOTED_CHAR"
	[GrammarRule("QUOTED_CHAR")]
	private void mQUOTED_CHAR()
	{
		Enter_QUOTED_CHAR();
		EnterRule("QUOTED_CHAR", 72);
		TraceIn("QUOTED_CHAR", 72);
		try
		{
			int _type = QUOTED_CHAR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:158:2: ( '\\'' (~ ( '\\n' | '\\r' | '\\'' ) ) '\\'' )
			DebugEnterAlt(1);
			// Plsql.g:158:4: '\\'' (~ ( '\\n' | '\\r' | '\\'' ) ) '\\''
			{
			DebugLocation(158, 4);
			Match('\''); 
			DebugLocation(158, 9);
			// Plsql.g:158:9: (~ ( '\\n' | '\\r' | '\\'' ) )
			DebugEnterAlt(1);
			// Plsql.g:158:11: ~ ( '\\n' | '\\r' | '\\'' )
			{
			DebugLocation(158, 11);
			if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='&')||(input.LA(1)>='(' && input.LA(1)<='\uFFFF'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

			DebugLocation(158, 31);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUOTED_CHAR", 72);
			LeaveRule("QUOTED_CHAR", 72);
			Leave_QUOTED_CHAR();
		}
	}
	// $ANTLR end "QUOTED_CHAR"

	public override void mTokens()
	{
		// Plsql.g:1:8: ( INT | CHAR | BOOL | DOUBLE | STRING | VOID | TYPE | IF | THEN | ELSE | DO | WHILE | LOOP | EXIT | WHEN | FOR | CREATE | BODY | PROCEDURE | FUNCTION | IS | AS | TABLE | OF | INDEX | BY | RECORD | OBJECT | MEMBER | STATIC | BEGIN | END | PACKAGE | DECLARE | SELF | NULL | IN | TRUE | FALSE | RETURN | PLUS | MINUS | MULT | DIVIDE | MOD | AND | OR | EQUAL | NEQUAL | MORE | LESS | MOREEQ | LESSEQ | NOT | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN | T__97 | T__98 | T__99 | T__100 | T__101 | T__102 | T__103 | T__104 | ID | INTEGER | REAL | QUOTED_STRING | QUOTED_CHAR )
		int alt4=72;
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
			// Plsql.g:1:10: INT
			{
			DebugLocation(1, 10);
			mINT(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Plsql.g:1:14: CHAR
			{
			DebugLocation(1, 14);
			mCHAR(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Plsql.g:1:19: BOOL
			{
			DebugLocation(1, 19);
			mBOOL(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Plsql.g:1:24: DOUBLE
			{
			DebugLocation(1, 24);
			mDOUBLE(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Plsql.g:1:31: STRING
			{
			DebugLocation(1, 31);
			mSTRING(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Plsql.g:1:38: VOID
			{
			DebugLocation(1, 38);
			mVOID(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Plsql.g:1:43: TYPE
			{
			DebugLocation(1, 43);
			mTYPE(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Plsql.g:1:48: IF
			{
			DebugLocation(1, 48);
			mIF(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// Plsql.g:1:51: THEN
			{
			DebugLocation(1, 51);
			mTHEN(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// Plsql.g:1:56: ELSE
			{
			DebugLocation(1, 56);
			mELSE(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// Plsql.g:1:61: DO
			{
			DebugLocation(1, 61);
			mDO(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// Plsql.g:1:64: WHILE
			{
			DebugLocation(1, 64);
			mWHILE(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// Plsql.g:1:70: LOOP
			{
			DebugLocation(1, 70);
			mLOOP(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// Plsql.g:1:75: EXIT
			{
			DebugLocation(1, 75);
			mEXIT(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// Plsql.g:1:80: WHEN
			{
			DebugLocation(1, 80);
			mWHEN(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// Plsql.g:1:85: FOR
			{
			DebugLocation(1, 85);
			mFOR(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// Plsql.g:1:89: CREATE
			{
			DebugLocation(1, 89);
			mCREATE(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// Plsql.g:1:96: BODY
			{
			DebugLocation(1, 96);
			mBODY(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// Plsql.g:1:101: PROCEDURE
			{
			DebugLocation(1, 101);
			mPROCEDURE(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// Plsql.g:1:111: FUNCTION
			{
			DebugLocation(1, 111);
			mFUNCTION(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// Plsql.g:1:120: IS
			{
			DebugLocation(1, 120);
			mIS(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// Plsql.g:1:123: AS
			{
			DebugLocation(1, 123);
			mAS(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// Plsql.g:1:126: TABLE
			{
			DebugLocation(1, 126);
			mTABLE(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// Plsql.g:1:132: OF
			{
			DebugLocation(1, 132);
			mOF(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// Plsql.g:1:135: INDEX
			{
			DebugLocation(1, 135);
			mINDEX(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// Plsql.g:1:141: BY
			{
			DebugLocation(1, 141);
			mBY(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// Plsql.g:1:144: RECORD
			{
			DebugLocation(1, 144);
			mRECORD(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// Plsql.g:1:151: OBJECT
			{
			DebugLocation(1, 151);
			mOBJECT(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// Plsql.g:1:158: MEMBER
			{
			DebugLocation(1, 158);
			mMEMBER(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// Plsql.g:1:165: STATIC
			{
			DebugLocation(1, 165);
			mSTATIC(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// Plsql.g:1:172: BEGIN
			{
			DebugLocation(1, 172);
			mBEGIN(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// Plsql.g:1:178: END
			{
			DebugLocation(1, 178);
			mEND(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// Plsql.g:1:182: PACKAGE
			{
			DebugLocation(1, 182);
			mPACKAGE(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// Plsql.g:1:190: DECLARE
			{
			DebugLocation(1, 190);
			mDECLARE(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// Plsql.g:1:198: SELF
			{
			DebugLocation(1, 198);
			mSELF(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// Plsql.g:1:203: NULL
			{
			DebugLocation(1, 203);
			mNULL(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// Plsql.g:1:208: IN
			{
			DebugLocation(1, 208);
			mIN(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// Plsql.g:1:211: TRUE
			{
			DebugLocation(1, 211);
			mTRUE(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// Plsql.g:1:216: FALSE
			{
			DebugLocation(1, 216);
			mFALSE(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// Plsql.g:1:222: RETURN
			{
			DebugLocation(1, 222);
			mRETURN(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// Plsql.g:1:229: PLUS
			{
			DebugLocation(1, 229);
			mPLUS(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// Plsql.g:1:234: MINUS
			{
			DebugLocation(1, 234);
			mMINUS(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// Plsql.g:1:240: MULT
			{
			DebugLocation(1, 240);
			mMULT(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// Plsql.g:1:245: DIVIDE
			{
			DebugLocation(1, 245);
			mDIVIDE(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// Plsql.g:1:252: MOD
			{
			DebugLocation(1, 252);
			mMOD(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// Plsql.g:1:256: AND
			{
			DebugLocation(1, 256);
			mAND(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// Plsql.g:1:260: OR
			{
			DebugLocation(1, 260);
			mOR(); 

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// Plsql.g:1:263: EQUAL
			{
			DebugLocation(1, 263);
			mEQUAL(); 

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// Plsql.g:1:269: NEQUAL
			{
			DebugLocation(1, 269);
			mNEQUAL(); 

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// Plsql.g:1:276: MORE
			{
			DebugLocation(1, 276);
			mMORE(); 

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// Plsql.g:1:281: LESS
			{
			DebugLocation(1, 281);
			mLESS(); 

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// Plsql.g:1:286: MOREEQ
			{
			DebugLocation(1, 286);
			mMOREEQ(); 

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// Plsql.g:1:293: LESSEQ
			{
			DebugLocation(1, 293);
			mLESSEQ(); 

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// Plsql.g:1:300: NOT
			{
			DebugLocation(1, 300);
			mNOT(); 

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// Plsql.g:1:304: ASSIGN
			{
			DebugLocation(1, 304);
			mASSIGN(); 

			}
			break;
		case 56:
			DebugEnterAlt(56);
			// Plsql.g:1:311: PLUSASSIGN
			{
			DebugLocation(1, 311);
			mPLUSASSIGN(); 

			}
			break;
		case 57:
			DebugEnterAlt(57);
			// Plsql.g:1:322: MINUSASSIGN
			{
			DebugLocation(1, 322);
			mMINUSASSIGN(); 

			}
			break;
		case 58:
			DebugEnterAlt(58);
			// Plsql.g:1:334: MULTASSIGN
			{
			DebugLocation(1, 334);
			mMULTASSIGN(); 

			}
			break;
		case 59:
			DebugEnterAlt(59);
			// Plsql.g:1:345: DIVASSIGN
			{
			DebugLocation(1, 345);
			mDIVASSIGN(); 

			}
			break;
		case 60:
			DebugEnterAlt(60);
			// Plsql.g:1:355: T__97
			{
			DebugLocation(1, 355);
			mT__97(); 

			}
			break;
		case 61:
			DebugEnterAlt(61);
			// Plsql.g:1:361: T__98
			{
			DebugLocation(1, 361);
			mT__98(); 

			}
			break;
		case 62:
			DebugEnterAlt(62);
			// Plsql.g:1:367: T__99
			{
			DebugLocation(1, 367);
			mT__99(); 

			}
			break;
		case 63:
			DebugEnterAlt(63);
			// Plsql.g:1:373: T__100
			{
			DebugLocation(1, 373);
			mT__100(); 

			}
			break;
		case 64:
			DebugEnterAlt(64);
			// Plsql.g:1:380: T__101
			{
			DebugLocation(1, 380);
			mT__101(); 

			}
			break;
		case 65:
			DebugEnterAlt(65);
			// Plsql.g:1:387: T__102
			{
			DebugLocation(1, 387);
			mT__102(); 

			}
			break;
		case 66:
			DebugEnterAlt(66);
			// Plsql.g:1:394: T__103
			{
			DebugLocation(1, 394);
			mT__103(); 

			}
			break;
		case 67:
			DebugEnterAlt(67);
			// Plsql.g:1:401: T__104
			{
			DebugLocation(1, 401);
			mT__104(); 

			}
			break;
		case 68:
			DebugEnterAlt(68);
			// Plsql.g:1:408: ID
			{
			DebugLocation(1, 408);
			mID(); 

			}
			break;
		case 69:
			DebugEnterAlt(69);
			// Plsql.g:1:411: INTEGER
			{
			DebugLocation(1, 411);
			mINTEGER(); 

			}
			break;
		case 70:
			DebugEnterAlt(70);
			// Plsql.g:1:419: REAL
			{
			DebugLocation(1, 419);
			mREAL(); 

			}
			break;
		case 71:
			DebugEnterAlt(71);
			// Plsql.g:1:424: QUOTED_STRING
			{
			DebugLocation(1, 424);
			mQUOTED_STRING(); 

			}
			break;
		case 72:
			DebugEnterAlt(72);
			// Plsql.g:1:438: QUOTED_CHAR
			{
			DebugLocation(1, 438);
			mQUOTED_CHAR(); 

			}
			break;

		}

	}


	#region DFA
	DFA4 dfa4;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa4 = new DFA4(this);
	}

	private class DFA4 : DFA
	{
		private const string DFA4_eotS =
			"\x1\xFFFF\xA\x25\x1\x42\x6\x25\x1\x4C\x1\x4E\x1\x50\x1\x52\x4\xFFFF"+
			"\x1\x54\x1\x56\x1\x58\x9\xFFFF\x1\x59\x2\xFFFF\x1\x5D\x1\x5E\x1\x5F\x3"+
			"\x25\x1\x64\x1\x25\x1\x67\x10\x25\x1\xFFFF\x2\x25\x1\x7C\x1\x7D\x4\x25"+
			"\x10\xFFFF\x1\x83\x1\x25\x3\xFFFF\x4\x25\x1\xFFFF\x2\x25\x1\xFFFF\xB"+
			"\x25\x1\x96\x3\x25\x1\x9A\x4\x25\x2\xFFFF\x5\x25\x1\xFFFF\x1\x25\x1\xA5"+
			"\x1\x25\x1\xA7\x1\xA8\x5\x25\x1\xAE\x1\xAF\x1\xB0\x1\xB1\x1\x25\x1\xB3"+
			"\x1\xB4\x1\xB5\x1\xFFFF\x1\x25\x1\xB7\x1\xB8\x1\xFFFF\x8\x25\x1\xC1\x1"+
			"\xC2\x1\xFFFF\x1\x25\x2\xFFFF\x1\xC4\x4\x25\x4\xFFFF\x1\xC9\x3\xFFFF"+
			"\x1\xCA\x2\xFFFF\x1\x25\x1\xCC\x6\x25\x2\xFFFF\x1\xD3\x1\xFFFF\x1\xD4"+
			"\x1\x25\x1\xD6\x1\xD7\x2\xFFFF\x1\x25\x1\xFFFF\x2\x25\x1\xDB\x1\xDC\x1"+
			"\xDD\x1\xDE\x2\xFFFF\x1\xDF\x2\xFFFF\x2\x25\x1\xE2\x5\xFFFF\x1\xE3\x1"+
			"\x25\x2\xFFFF\x1\xE5\x1\xFFFF";
		private const string DFA4_eofS =
			"\xE6\xFFFF";
		private const string DFA4_minS =
			"\x1\x21\x1\x66\x1\x68\x3\x65\x1\x6F\x1\x61\x1\x6C\x1\x68\x1\x6F\x1\x30"+
			"\x1\x61\x1\x73\x1\x62\x2\x65\x1\x75\x4\x3D\x4\xFFFF\x3\x3D\x9\xFFFF\x1"+
			"\x2E\x2\xFFFF\x3\x30\x1\x61\x1\x65\x1\x64\x1\x30\x1\x67\x1\x30\x1\x63"+
			"\x1\x61\x1\x6C\x1\x69\x1\x70\x1\x65\x1\x62\x1\x75\x1\x73\x1\x69\x1\x64"+
			"\x1\x65\x1\x6F\x1\x72\x1\x6E\x1\x6C\x1\xFFFF\x1\x6F\x1\x63\x2\x30\x1"+
			"\x6A\x1\x63\x1\x6D\x1\x6C\x10\xFFFF\x1\x30\x1\x65\x3\xFFFF\x1\x72\x1"+
			"\x61\x1\x6C\x1\x79\x1\xFFFF\x1\x69\x1\x62\x1\xFFFF\x1\x6C\x1\x69\x1\x74"+
			"\x1\x66\x1\x64\x1\x65\x1\x6E\x1\x6C\x2\x65\x1\x74\x1\x30\x1\x6C\x1\x6E"+
			"\x1\x70\x1\x30\x1\x63\x1\x73\x1\x63\x1\x6B\x2\xFFFF\x1\x65\x1\x6F\x1"+
			"\x75\x1\x62\x1\x6C\x1\xFFFF\x1\x78\x1\x30\x1\x74\x2\x30\x1\x6E\x1\x6C"+
			"\x1\x61\x1\x6E\x1\x69\x4\x30\x1\x65\x3\x30\x1\xFFFF\x1\x65\x2\x30\x1"+
			"\xFFFF\x1\x74\x2\x65\x1\x61\x1\x63\x2\x72\x1\x65\x2\x30\x1\xFFFF\x1\x65"+
			"\x2\xFFFF\x1\x30\x1\x65\x1\x72\x1\x67\x1\x63\x4\xFFFF\x1\x30\x3\xFFFF"+
			"\x1\x30\x2\xFFFF\x1\x69\x1\x30\x1\x64\x1\x67\x1\x74\x1\x64\x1\x6E\x1"+
			"\x72\x2\xFFFF\x1\x30\x1\xFFFF\x1\x30\x1\x65\x2\x30\x2\xFFFF\x1\x6F\x1"+
			"\xFFFF\x1\x75\x1\x65\x4\x30\x2\xFFFF\x1\x30\x2\xFFFF\x1\x6E\x1\x72\x1"+
			"\x30\x5\xFFFF\x1\x30\x1\x65\x2\xFFFF\x1\x30\x1\xFFFF";
		private const string DFA4_maxS =
			"\x1\x7C\x1\x73\x1\x72\x1\x79\x1\x6F\x1\x74\x1\x6F\x1\x79\x1\x78\x1\x68"+
			"\x1\x6F\x1\x7A\x1\x72\x1\x73\x1\x66\x2\x65\x1\x75\x4\x3D\x4\xFFFF\x3"+
			"\x3D\x9\xFFFF\x1\x39\x2\xFFFF\x3\x7A\x1\x61\x1\x65\x1\x6F\x1\x7A\x1\x67"+
			"\x1\x7A\x1\x63\x1\x72\x1\x6C\x1\x69\x1\x70\x1\x65\x1\x62\x1\x75\x1\x73"+
			"\x1\x69\x1\x64\x1\x69\x1\x6F\x1\x72\x1\x6E\x1\x6C\x1\xFFFF\x1\x6F\x1"+
			"\x63\x2\x7A\x1\x6A\x1\x74\x1\x6D\x1\x6C\x10\xFFFF\x1\x7A\x1\x65\x3\xFFFF"+
			"\x1\x72\x1\x61\x1\x6C\x1\x79\x1\xFFFF\x1\x69\x1\x62\x1\xFFFF\x1\x6C\x1"+
			"\x69\x1\x74\x1\x66\x1\x64\x1\x65\x1\x6E\x1\x6C\x2\x65\x1\x74\x1\x7A\x1"+
			"\x6C\x1\x6E\x1\x70\x1\x7A\x1\x63\x1\x73\x1\x63\x1\x6B\x2\xFFFF\x1\x65"+
			"\x1\x6F\x1\x75\x1\x62\x1\x6C\x1\xFFFF\x1\x78\x1\x7A\x1\x74\x2\x7A\x1"+
			"\x6E\x1\x6C\x1\x61\x1\x6E\x1\x69\x4\x7A\x1\x65\x3\x7A\x1\xFFFF\x1\x65"+
			"\x2\x7A\x1\xFFFF\x1\x74\x2\x65\x1\x61\x1\x63\x2\x72\x1\x65\x2\x7A\x1"+
			"\xFFFF\x1\x65\x2\xFFFF\x1\x7A\x1\x65\x1\x72\x1\x67\x1\x63\x4\xFFFF\x1"+
			"\x7A\x3\xFFFF\x1\x7A\x2\xFFFF\x1\x69\x1\x7A\x1\x64\x1\x67\x1\x74\x1\x64"+
			"\x1\x6E\x1\x72\x2\xFFFF\x1\x7A\x1\xFFFF\x1\x7A\x1\x65\x2\x7A\x2\xFFFF"+
			"\x1\x6F\x1\xFFFF\x1\x75\x1\x65\x4\x7A\x2\xFFFF\x1\x7A\x2\xFFFF\x1\x6E"+
			"\x1\x72\x1\x7A\x5\xFFFF\x1\x7A\x1\x65\x2\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA4_acceptS =
			"\x16\xFFFF\x1\x2D\x1\x2E\x1\x2F\x1\x30\x3\xFFFF\x1\x37\x1\x3D\x1\x3E"+
			"\x1\x3F\x1\x40\x1\x41\x1\x42\x1\x43\x1\x44\x1\xFFFF\x1\x47\x1\x48\x19"+
			"\xFFFF\x1\x3C\x8\xFFFF\x1\x38\x1\x29\x1\x39\x1\x2A\x1\x3A\x1\x2B\x1\x3B"+
			"\x1\x2C\x1\x31\x1\x36\x1\x34\x1\x32\x1\x35\x1\x33\x1\x45\x1\x46\x2\xFFFF"+
			"\x1\x25\x1\x8\x1\x15\x4\xFFFF\x1\x1A\x2\xFFFF\x1\xB\x14\xFFFF\x1\x16"+
			"\x1\x18\x5\xFFFF\x1\x1\x12\xFFFF\x1\x20\x3\xFFFF\x1\x10\xA\xFFFF\x1\x2"+
			"\x1\xFFFF\x1\x3\x1\x12\x5\xFFFF\x1\x23\x1\x6\x1\x7\x1\x9\x1\xFFFF\x1"+
			"\x26\x1\xA\x1\xE\x1\xFFFF\x1\xF\x1\xD\x8\xFFFF\x1\x24\x1\x19\x1\xFFFF"+
			"\x1\x1F\x4\xFFFF\x1\x17\x1\xC\x1\xFFFF\x1\x27\x6\xFFFF\x1\x11\x1\x4\x1"+
			"\xFFFF\x1\x5\x1\x1E\x3\xFFFF\x1\x1C\x1\x1B\x1\x28\x1\x1D\x1\x22\x2\xFFFF"+
			"\x1\x21\x1\x14\x1\xFFFF\x1\x13";
		private const string DFA4_specialS =
			"\xE6\xFFFF}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x1\x1A\x1\x27\x2\xFFFF\x1\x16\x1\x17\x1\x28\x1\x20\x1\x21\x1\x14\x1"+
				"\x12\x1\x1F\x1\x13\x1\x1E\x1\x15\xA\x26\x1\x1D\x1\x22\x1\x1C\x1\x19"+
				"\x1\x1B\x2\xFFFF\x1A\x25\x1\x23\x1\xFFFF\x1\x24\x1\xFFFF\x1\x25\x1\xFFFF"+
				"\x1\xD\x1\x3\x1\x2\x1\x4\x1\x8\x1\xB\x2\x25\x1\x1\x2\x25\x1\xA\x1\x10"+
				"\x1\x11\x1\xE\x1\xC\x1\x25\x1\xF\x1\x5\x1\x7\x1\x25\x1\x6\x1\x9\x3\x25"+
				"\x1\xFFFF\x1\x18",
				"\x1\x2A\x7\xFFFF\x1\x29\x4\xFFFF\x1\x2B",
				"\x1\x2C\x9\xFFFF\x1\x2D",
				"\x1\x30\x9\xFFFF\x1\x2E\x9\xFFFF\x1\x2F",
				"\x1\x32\x9\xFFFF\x1\x31",
				"\x1\x34\xE\xFFFF\x1\x33",
				"\x1\x35",
				"\x1\x38\x6\xFFFF\x1\x37\x9\xFFFF\x1\x39\x6\xFFFF\x1\x36",
				"\x1\x3A\x1\xFFFF\x1\x3C\x9\xFFFF\x1\x3B",
				"\x1\x3D",
				"\x1\x3E",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1\x41\xD\x25\x1"+
				"\x3F\x5\x25\x1\x40\x5\x25",
				"\x1\x44\x10\xFFFF\x1\x43",
				"\x1\x45",
				"\x1\x47\x3\xFFFF\x1\x46",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4D",
				"\x1\x4F",
				"\x1\x51",
				"",
				"",
				"",
				"",
				"\x1\x53",
				"\x1\x55",
				"\x1\x57",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x5A\x1\xFFFF\xA\x26",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x3\x25\x1\x5C\xF"+
				"\x25\x1\x5B\x6\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x60",
				"\x1\x61",
				"\x1\x63\xA\xFFFF\x1\x62",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x65",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x14\x25\x1\x66\x5"+
				"\x25",
				"\x1\x68",
				"\x1\x6A\x10\xFFFF\x1\x69",
				"\x1\x6B",
				"\x1\x6C",
				"\x1\x6D",
				"\x1\x6E",
				"\x1\x6F",
				"\x1\x70",
				"\x1\x71",
				"\x1\x72",
				"\x1\x73",
				"\x1\x75\x3\xFFFF\x1\x74",
				"\x1\x76",
				"\x1\x77",
				"\x1\x78",
				"\x1\x79",
				"",
				"\x1\x7A",
				"\x1\x7B",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x7E",
				"\x1\x7F\x10\xFFFF\x1\x80",
				"\x1\x81",
				"\x1\x82",
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
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x84",
				"",
				"",
				"",
				"\x1\x85",
				"\x1\x86",
				"\x1\x87",
				"\x1\x88",
				"",
				"\x1\x89",
				"\x1\x8A",
				"",
				"\x1\x8B",
				"\x1\x8C",
				"\x1\x8D",
				"\x1\x8E",
				"\x1\x8F",
				"\x1\x90",
				"\x1\x91",
				"\x1\x92",
				"\x1\x93",
				"\x1\x94",
				"\x1\x95",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x97",
				"\x1\x98",
				"\x1\x99",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x9B",
				"\x1\x9C",
				"\x1\x9D",
				"\x1\x9E",
				"",
				"",
				"\x1\x9F",
				"\x1\xA0",
				"\x1\xA1",
				"\x1\xA2",
				"\x1\xA3",
				"",
				"\x1\xA4",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xA6",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xA9",
				"\x1\xAA",
				"\x1\xAB",
				"\x1\xAC",
				"\x1\xAD",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xB2",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\xB6",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\xB9",
				"\x1\xBA",
				"\x1\xBB",
				"\x1\xBC",
				"\x1\xBD",
				"\x1\xBE",
				"\x1\xBF",
				"\x1\xC0",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\xC3",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xC5",
				"\x1\xC6",
				"\x1\xC7",
				"\x1\xC8",
				"",
				"",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\x1\xCB",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xCD",
				"\x1\xCE",
				"\x1\xCF",
				"\x1\xD0",
				"\x1\xD1",
				"\x1\xD2",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xD5",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\x1\xD8",
				"",
				"\x1\xD9",
				"\x1\xDA",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\x1\xE0",
				"\x1\xE1",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xE4",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
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

		public DFA4( BaseRecognizer recognizer )
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

		public override string Description { get { return "1:1: Tokens : ( INT | CHAR | BOOL | DOUBLE | STRING | VOID | TYPE | IF | THEN | ELSE | DO | WHILE | LOOP | EXIT | WHEN | FOR | CREATE | BODY | PROCEDURE | FUNCTION | IS | AS | TABLE | OF | INDEX | BY | RECORD | OBJECT | MEMBER | STATIC | BEGIN | END | PACKAGE | DECLARE | SELF | NULL | IN | TRUE | FALSE | RETURN | PLUS | MINUS | MULT | DIVIDE | MOD | AND | OR | EQUAL | NEQUAL | MORE | LESS | MOREEQ | LESSEQ | NOT | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN | T__97 | T__98 | T__99 | T__100 | T__101 | T__102 | T__103 | T__104 | ID | INTEGER | REAL | QUOTED_STRING | QUOTED_CHAR );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  plsql_msil 
