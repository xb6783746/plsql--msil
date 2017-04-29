// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-04-29 16:10:24

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

	partial void Enter_BYTE();
	partial void Leave_BYTE();

	// $ANTLR start "BYTE"
	[GrammarRule("BYTE")]
	private void mBYTE()
	{
		Enter_BYTE();
		EnterRule("BYTE", 1);
		TraceIn("BYTE", 1);
		try
		{
			int _type = BYTE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:9:6: ( 'byte' )
			DebugEnterAlt(1);
			// Plsql.g:9:8: 'byte'
			{
			DebugLocation(9, 8);
			Match("byte"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BYTE", 1);
			LeaveRule("BYTE", 1);
			Leave_BYTE();
		}
	}
	// $ANTLR end "BYTE"

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 2);
		TraceIn("INT", 2);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:10:5: ( 'int' )
			DebugEnterAlt(1);
			// Plsql.g:10:7: 'int'
			{
			DebugLocation(10, 7);
			Match("int"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 2);
			LeaveRule("INT", 2);
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
		EnterRule("CHAR", 3);
		TraceIn("CHAR", 3);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:11:6: ( 'char' )
			DebugEnterAlt(1);
			// Plsql.g:11:8: 'char'
			{
			DebugLocation(11, 8);
			Match("char"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 3);
			LeaveRule("CHAR", 3);
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
		EnterRule("BOOL", 4);
		TraceIn("BOOL", 4);
		try
		{
			int _type = BOOL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:12:6: ( 'bool' )
			DebugEnterAlt(1);
			// Plsql.g:12:8: 'bool'
			{
			DebugLocation(12, 8);
			Match("bool"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BOOL", 4);
			LeaveRule("BOOL", 4);
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
		EnterRule("DOUBLE", 5);
		TraceIn("DOUBLE", 5);
		try
		{
			int _type = DOUBLE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:13:8: ( 'double' )
			DebugEnterAlt(1);
			// Plsql.g:13:10: 'double'
			{
			DebugLocation(13, 10);
			Match("double"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOUBLE", 5);
			LeaveRule("DOUBLE", 5);
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
		EnterRule("STRING", 6);
		TraceIn("STRING", 6);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// Plsql.g:14:8: ( 'string' )
			DebugEnterAlt(1);
			// Plsql.g:14:10: 'string'
			{
			DebugLocation(14, 10);
			Match("string"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 6);
			LeaveRule("STRING", 6);
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
		EnterRule("VOID", 7);
		TraceIn("VOID", 7);
		try
		{
			int _type = VOID;
			int _channel = DefaultTokenChannel;
			// Plsql.g:15:6: ( 'void' )
			DebugEnterAlt(1);
			// Plsql.g:15:8: 'void'
			{
			DebugLocation(15, 8);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VOID", 7);
			LeaveRule("VOID", 7);
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
		EnterRule("TYPE", 8);
		TraceIn("TYPE", 8);
		try
		{
			int _type = TYPE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:16:6: ( 'type' )
			DebugEnterAlt(1);
			// Plsql.g:16:8: 'type'
			{
			DebugLocation(16, 8);
			Match("type"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TYPE", 8);
			LeaveRule("TYPE", 8);
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
		EnterRule("IF", 9);
		TraceIn("IF", 9);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// Plsql.g:17:4: ( 'if' )
			DebugEnterAlt(1);
			// Plsql.g:17:6: 'if'
			{
			DebugLocation(17, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 9);
			LeaveRule("IF", 9);
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
		EnterRule("THEN", 10);
		TraceIn("THEN", 10);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:18:6: ( 'then' )
			DebugEnterAlt(1);
			// Plsql.g:18:8: 'then'
			{
			DebugLocation(18, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 10);
			LeaveRule("THEN", 10);
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
		EnterRule("ELSE", 11);
		TraceIn("ELSE", 11);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:19:6: ( 'else' )
			DebugEnterAlt(1);
			// Plsql.g:19:8: 'else'
			{
			DebugLocation(19, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 11);
			LeaveRule("ELSE", 11);
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
		EnterRule("DO", 12);
		TraceIn("DO", 12);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// Plsql.g:20:4: ( 'do' )
			DebugEnterAlt(1);
			// Plsql.g:20:6: 'do'
			{
			DebugLocation(20, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 12);
			LeaveRule("DO", 12);
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
		EnterRule("WHILE", 13);
		TraceIn("WHILE", 13);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:21:7: ( 'while' )
			DebugEnterAlt(1);
			// Plsql.g:21:9: 'while'
			{
			DebugLocation(21, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 13);
			LeaveRule("WHILE", 13);
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
		EnterRule("LOOP", 14);
		TraceIn("LOOP", 14);
		try
		{
			int _type = LOOP;
			int _channel = DefaultTokenChannel;
			// Plsql.g:22:6: ( 'loop' )
			DebugEnterAlt(1);
			// Plsql.g:22:8: 'loop'
			{
			DebugLocation(22, 8);
			Match("loop"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LOOP", 14);
			LeaveRule("LOOP", 14);
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
		EnterRule("EXIT", 15);
		TraceIn("EXIT", 15);
		try
		{
			int _type = EXIT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:23:6: ( 'exit' )
			DebugEnterAlt(1);
			// Plsql.g:23:8: 'exit'
			{
			DebugLocation(23, 8);
			Match("exit"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EXIT", 15);
			LeaveRule("EXIT", 15);
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
		EnterRule("WHEN", 16);
		TraceIn("WHEN", 16);
		try
		{
			int _type = WHEN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:24:6: ( 'when' )
			DebugEnterAlt(1);
			// Plsql.g:24:8: 'when'
			{
			DebugLocation(24, 8);
			Match("when"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHEN", 16);
			LeaveRule("WHEN", 16);
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
		EnterRule("FOR", 17);
		TraceIn("FOR", 17);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:25:5: ( 'for' )
			DebugEnterAlt(1);
			// Plsql.g:25:7: 'for'
			{
			DebugLocation(25, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 17);
			LeaveRule("FOR", 17);
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
		EnterRule("CREATE", 18);
		TraceIn("CREATE", 18);
		try
		{
			int _type = CREATE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:26:8: ( 'create' )
			DebugEnterAlt(1);
			// Plsql.g:26:10: 'create'
			{
			DebugLocation(26, 10);
			Match("create"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CREATE", 18);
			LeaveRule("CREATE", 18);
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
		EnterRule("BODY", 19);
		TraceIn("BODY", 19);
		try
		{
			int _type = BODY;
			int _channel = DefaultTokenChannel;
			// Plsql.g:27:6: ( 'body' )
			DebugEnterAlt(1);
			// Plsql.g:27:8: 'body'
			{
			DebugLocation(27, 8);
			Match("body"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BODY", 19);
			LeaveRule("BODY", 19);
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
		EnterRule("PROCEDURE", 20);
		TraceIn("PROCEDURE", 20);
		try
		{
			int _type = PROCEDURE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:28:11: ( 'procedure' )
			DebugEnterAlt(1);
			// Plsql.g:28:13: 'procedure'
			{
			DebugLocation(28, 13);
			Match("procedure"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROCEDURE", 20);
			LeaveRule("PROCEDURE", 20);
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
		EnterRule("FUNCTION", 21);
		TraceIn("FUNCTION", 21);
		try
		{
			int _type = FUNCTION;
			int _channel = DefaultTokenChannel;
			// Plsql.g:29:10: ( 'function' )
			DebugEnterAlt(1);
			// Plsql.g:29:12: 'function'
			{
			DebugLocation(29, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNCTION", 21);
			LeaveRule("FUNCTION", 21);
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
		EnterRule("IS", 22);
		TraceIn("IS", 22);
		try
		{
			int _type = IS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:30:4: ( 'is' )
			DebugEnterAlt(1);
			// Plsql.g:30:6: 'is'
			{
			DebugLocation(30, 6);
			Match("is"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS", 22);
			LeaveRule("IS", 22);
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
		EnterRule("AS", 23);
		TraceIn("AS", 23);
		try
		{
			int _type = AS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:31:4: ( 'as' )
			DebugEnterAlt(1);
			// Plsql.g:31:6: 'as'
			{
			DebugLocation(31, 6);
			Match("as"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AS", 23);
			LeaveRule("AS", 23);
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
		EnterRule("TABLE", 24);
		TraceIn("TABLE", 24);
		try
		{
			int _type = TABLE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:32:7: ( 'table' )
			DebugEnterAlt(1);
			// Plsql.g:32:9: 'table'
			{
			DebugLocation(32, 9);
			Match("table"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TABLE", 24);
			LeaveRule("TABLE", 24);
			Leave_TABLE();
		}
	}
	// $ANTLR end "TABLE"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 25);
		TraceIn("ARRAY", 25);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// Plsql.g:33:7: ( 'array' )
			DebugEnterAlt(1);
			// Plsql.g:33:9: 'array'
			{
			DebugLocation(33, 9);
			Match("array"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 25);
			LeaveRule("ARRAY", 25);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void Enter_INDEX();
	partial void Leave_INDEX();

	// $ANTLR start "INDEX"
	[GrammarRule("INDEX")]
	private void mINDEX()
	{
		Enter_INDEX();
		EnterRule("INDEX", 26);
		TraceIn("INDEX", 26);
		try
		{
			int _type = INDEX;
			int _channel = DefaultTokenChannel;
			// Plsql.g:34:7: ( 'index' )
			DebugEnterAlt(1);
			// Plsql.g:34:9: 'index'
			{
			DebugLocation(34, 9);
			Match("index"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INDEX", 26);
			LeaveRule("INDEX", 26);
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
		EnterRule("BY", 27);
		TraceIn("BY", 27);
		try
		{
			int _type = BY;
			int _channel = DefaultTokenChannel;
			// Plsql.g:35:4: ( 'by' )
			DebugEnterAlt(1);
			// Plsql.g:35:6: 'by'
			{
			DebugLocation(35, 6);
			Match("by"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BY", 27);
			LeaveRule("BY", 27);
			Leave_BY();
		}
	}
	// $ANTLR end "BY"

	partial void Enter_OF();
	partial void Leave_OF();

	// $ANTLR start "OF"
	[GrammarRule("OF")]
	private void mOF()
	{
		Enter_OF();
		EnterRule("OF", 28);
		TraceIn("OF", 28);
		try
		{
			int _type = OF;
			int _channel = DefaultTokenChannel;
			// Plsql.g:36:4: ( 'of' )
			DebugEnterAlt(1);
			// Plsql.g:36:6: 'of'
			{
			DebugLocation(36, 6);
			Match("of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OF", 28);
			LeaveRule("OF", 28);
			Leave_OF();
		}
	}
	// $ANTLR end "OF"

	partial void Enter_RECORD();
	partial void Leave_RECORD();

	// $ANTLR start "RECORD"
	[GrammarRule("RECORD")]
	private void mRECORD()
	{
		Enter_RECORD();
		EnterRule("RECORD", 29);
		TraceIn("RECORD", 29);
		try
		{
			int _type = RECORD;
			int _channel = DefaultTokenChannel;
			// Plsql.g:37:8: ( 'record' )
			DebugEnterAlt(1);
			// Plsql.g:37:10: 'record'
			{
			DebugLocation(37, 10);
			Match("record"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RECORD", 29);
			LeaveRule("RECORD", 29);
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
		EnterRule("OBJECT", 30);
		TraceIn("OBJECT", 30);
		try
		{
			int _type = OBJECT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:38:8: ( 'object' )
			DebugEnterAlt(1);
			// Plsql.g:38:10: 'object'
			{
			DebugLocation(38, 10);
			Match("object"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OBJECT", 30);
			LeaveRule("OBJECT", 30);
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
		EnterRule("MEMBER", 31);
		TraceIn("MEMBER", 31);
		try
		{
			int _type = MEMBER;
			int _channel = DefaultTokenChannel;
			// Plsql.g:39:8: ( 'member' )
			DebugEnterAlt(1);
			// Plsql.g:39:10: 'member'
			{
			DebugLocation(39, 10);
			Match("member"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MEMBER", 31);
			LeaveRule("MEMBER", 31);
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
		EnterRule("STATIC", 32);
		TraceIn("STATIC", 32);
		try
		{
			int _type = STATIC;
			int _channel = DefaultTokenChannel;
			// Plsql.g:40:8: ( 'static' )
			DebugEnterAlt(1);
			// Plsql.g:40:10: 'static'
			{
			DebugLocation(40, 10);
			Match("static"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STATIC", 32);
			LeaveRule("STATIC", 32);
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
		EnterRule("BEGIN", 33);
		TraceIn("BEGIN", 33);
		try
		{
			int _type = BEGIN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:41:7: ( 'begin' )
			DebugEnterAlt(1);
			// Plsql.g:41:9: 'begin'
			{
			DebugLocation(41, 9);
			Match("begin"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BEGIN", 33);
			LeaveRule("BEGIN", 33);
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
		EnterRule("END", 34);
		TraceIn("END", 34);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// Plsql.g:42:5: ( 'end' )
			DebugEnterAlt(1);
			// Plsql.g:42:7: 'end'
			{
			DebugLocation(42, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 34);
			LeaveRule("END", 34);
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
		EnterRule("PACKAGE", 35);
		TraceIn("PACKAGE", 35);
		try
		{
			int _type = PACKAGE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:43:9: ( 'package' )
			DebugEnterAlt(1);
			// Plsql.g:43:11: 'package'
			{
			DebugLocation(43, 11);
			Match("package"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PACKAGE", 35);
			LeaveRule("PACKAGE", 35);
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
		EnterRule("DECLARE", 36);
		TraceIn("DECLARE", 36);
		try
		{
			int _type = DECLARE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:44:9: ( 'declare' )
			DebugEnterAlt(1);
			// Plsql.g:44:11: 'declare'
			{
			DebugLocation(44, 11);
			Match("declare"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DECLARE", 36);
			LeaveRule("DECLARE", 36);
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
		EnterRule("SELF", 37);
		TraceIn("SELF", 37);
		try
		{
			int _type = SELF;
			int _channel = DefaultTokenChannel;
			// Plsql.g:45:6: ( 'self' )
			DebugEnterAlt(1);
			// Plsql.g:45:8: 'self'
			{
			DebugLocation(45, 8);
			Match("self"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SELF", 37);
			LeaveRule("SELF", 37);
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
		EnterRule("NULL", 38);
		TraceIn("NULL", 38);
		try
		{
			int _type = NULL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:46:6: ( 'null' )
			DebugEnterAlt(1);
			// Plsql.g:46:8: 'null'
			{
			DebugLocation(46, 8);
			Match("null"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NULL", 38);
			LeaveRule("NULL", 38);
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
		EnterRule("IN", 39);
		TraceIn("IN", 39);
		try
		{
			int _type = IN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:47:4: ( 'in' )
			DebugEnterAlt(1);
			// Plsql.g:47:6: 'in'
			{
			DebugLocation(47, 6);
			Match("in"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IN", 39);
			LeaveRule("IN", 39);
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
		EnterRule("TRUE", 40);
		TraceIn("TRUE", 40);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:48:6: ( 'true' )
			DebugEnterAlt(1);
			// Plsql.g:48:8: 'true'
			{
			DebugLocation(48, 8);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 40);
			LeaveRule("TRUE", 40);
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
		EnterRule("FALSE", 41);
		TraceIn("FALSE", 41);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:49:7: ( 'false' )
			DebugEnterAlt(1);
			// Plsql.g:49:9: 'false'
			{
			DebugLocation(49, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 41);
			LeaveRule("FALSE", 41);
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
		EnterRule("RETURN", 42);
		TraceIn("RETURN", 42);
		try
		{
			int _type = RETURN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:50:8: ( 'return' )
			DebugEnterAlt(1);
			// Plsql.g:50:10: 'return'
			{
			DebugLocation(50, 10);
			Match("return"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RETURN", 42);
			LeaveRule("RETURN", 42);
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
		EnterRule("PLUS", 43);
		TraceIn("PLUS", 43);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:51:6: ( '+' )
			DebugEnterAlt(1);
			// Plsql.g:51:8: '+'
			{
			DebugLocation(51, 8);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 43);
			LeaveRule("PLUS", 43);
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
		EnterRule("MINUS", 44);
		TraceIn("MINUS", 44);
		try
		{
			int _type = MINUS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:52:7: ( '-' )
			DebugEnterAlt(1);
			// Plsql.g:52:9: '-'
			{
			DebugLocation(52, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUS", 44);
			LeaveRule("MINUS", 44);
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
		EnterRule("MULT", 45);
		TraceIn("MULT", 45);
		try
		{
			int _type = MULT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:53:6: ( '*' )
			DebugEnterAlt(1);
			// Plsql.g:53:8: '*'
			{
			DebugLocation(53, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULT", 45);
			LeaveRule("MULT", 45);
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
		EnterRule("DIVIDE", 46);
		TraceIn("DIVIDE", 46);
		try
		{
			int _type = DIVIDE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:54:8: ( '/' )
			DebugEnterAlt(1);
			// Plsql.g:54:10: '/'
			{
			DebugLocation(54, 10);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIVIDE", 46);
			LeaveRule("DIVIDE", 46);
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
		EnterRule("MOD", 47);
		TraceIn("MOD", 47);
		try
		{
			int _type = MOD;
			int _channel = DefaultTokenChannel;
			// Plsql.g:55:5: ( '%' )
			DebugEnterAlt(1);
			// Plsql.g:55:7: '%'
			{
			DebugLocation(55, 7);
			Match('%'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MOD", 47);
			LeaveRule("MOD", 47);
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
		EnterRule("AND", 48);
		TraceIn("AND", 48);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// Plsql.g:56:5: ( '&&' )
			DebugEnterAlt(1);
			// Plsql.g:56:7: '&&'
			{
			DebugLocation(56, 7);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 48);
			LeaveRule("AND", 48);
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
		EnterRule("OR", 49);
		TraceIn("OR", 49);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:57:4: ( '||' )
			DebugEnterAlt(1);
			// Plsql.g:57:6: '||'
			{
			DebugLocation(57, 6);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 49);
			LeaveRule("OR", 49);
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
		EnterRule("EQUAL", 50);
		TraceIn("EQUAL", 50);
		try
		{
			int _type = EQUAL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:58:7: ( '==' )
			DebugEnterAlt(1);
			// Plsql.g:58:9: '=='
			{
			DebugLocation(58, 9);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUAL", 50);
			LeaveRule("EQUAL", 50);
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
		EnterRule("NEQUAL", 51);
		TraceIn("NEQUAL", 51);
		try
		{
			int _type = NEQUAL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:59:8: ( '!=' )
			DebugEnterAlt(1);
			// Plsql.g:59:10: '!='
			{
			DebugLocation(59, 10);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQUAL", 51);
			LeaveRule("NEQUAL", 51);
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
		EnterRule("MORE", 52);
		TraceIn("MORE", 52);
		try
		{
			int _type = MORE;
			int _channel = DefaultTokenChannel;
			// Plsql.g:60:6: ( '>' )
			DebugEnterAlt(1);
			// Plsql.g:60:8: '>'
			{
			DebugLocation(60, 8);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MORE", 52);
			LeaveRule("MORE", 52);
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
		EnterRule("LESS", 53);
		TraceIn("LESS", 53);
		try
		{
			int _type = LESS;
			int _channel = DefaultTokenChannel;
			// Plsql.g:61:6: ( '<' )
			DebugEnterAlt(1);
			// Plsql.g:61:8: '<'
			{
			DebugLocation(61, 8);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESS", 53);
			LeaveRule("LESS", 53);
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
		EnterRule("MOREEQ", 54);
		TraceIn("MOREEQ", 54);
		try
		{
			int _type = MOREEQ;
			int _channel = DefaultTokenChannel;
			// Plsql.g:62:8: ( '>=' )
			DebugEnterAlt(1);
			// Plsql.g:62:10: '>='
			{
			DebugLocation(62, 10);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MOREEQ", 54);
			LeaveRule("MOREEQ", 54);
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
		EnterRule("LESSEQ", 55);
		TraceIn("LESSEQ", 55);
		try
		{
			int _type = LESSEQ;
			int _channel = DefaultTokenChannel;
			// Plsql.g:63:8: ( '<=' )
			DebugEnterAlt(1);
			// Plsql.g:63:10: '<='
			{
			DebugLocation(63, 10);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LESSEQ", 55);
			LeaveRule("LESSEQ", 55);
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
		EnterRule("NOT", 56);
		TraceIn("NOT", 56);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// Plsql.g:64:5: ( '!' )
			DebugEnterAlt(1);
			// Plsql.g:64:7: '!'
			{
			DebugLocation(64, 7);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 56);
			LeaveRule("NOT", 56);
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
		EnterRule("ASSIGN", 57);
		TraceIn("ASSIGN", 57);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:65:8: ( ':=' )
			DebugEnterAlt(1);
			// Plsql.g:65:10: ':='
			{
			DebugLocation(65, 10);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 57);
			LeaveRule("ASSIGN", 57);
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
		EnterRule("PLUSASSIGN", 58);
		TraceIn("PLUSASSIGN", 58);
		try
		{
			int _type = PLUSASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:66:12: ( '+=' )
			DebugEnterAlt(1);
			// Plsql.g:66:14: '+='
			{
			DebugLocation(66, 14);
			Match("+="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUSASSIGN", 58);
			LeaveRule("PLUSASSIGN", 58);
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
		EnterRule("MINUSASSIGN", 59);
		TraceIn("MINUSASSIGN", 59);
		try
		{
			int _type = MINUSASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:67:13: ( '-=' )
			DebugEnterAlt(1);
			// Plsql.g:67:15: '-='
			{
			DebugLocation(67, 15);
			Match("-="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MINUSASSIGN", 59);
			LeaveRule("MINUSASSIGN", 59);
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
		EnterRule("MULTASSIGN", 60);
		TraceIn("MULTASSIGN", 60);
		try
		{
			int _type = MULTASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:68:12: ( '*=' )
			DebugEnterAlt(1);
			// Plsql.g:68:14: '*='
			{
			DebugLocation(68, 14);
			Match("*="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULTASSIGN", 60);
			LeaveRule("MULTASSIGN", 60);
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
		EnterRule("DIVASSIGN", 61);
		TraceIn("DIVASSIGN", 61);
		try
		{
			int _type = DIVASSIGN;
			int _channel = DefaultTokenChannel;
			// Plsql.g:69:11: ( '/=' )
			DebugEnterAlt(1);
			// Plsql.g:69:13: '/='
			{
			DebugLocation(69, 13);
			Match("/="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIVASSIGN", 61);
			LeaveRule("DIVASSIGN", 61);
			Leave_DIVASSIGN();
		}
	}
	// $ANTLR end "DIVASSIGN"

	partial void Enter_T__100();
	partial void Leave_T__100();

	// $ANTLR start "T__100"
	[GrammarRule("T__100")]
	private void mT__100()
	{
		Enter_T__100();
		EnterRule("T__100", 62);
		TraceIn("T__100", 62);
		try
		{
			int _type = T__100;
			int _channel = DefaultTokenChannel;
			// Plsql.g:70:8: ( 'f' )
			DebugEnterAlt(1);
			// Plsql.g:70:10: 'f'
			{
			DebugLocation(70, 10);
			Match('f'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__100", 62);
			LeaveRule("T__100", 62);
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
		EnterRule("T__101", 63);
		TraceIn("T__101", 63);
		try
		{
			int _type = T__101;
			int _channel = DefaultTokenChannel;
			// Plsql.g:71:8: ( '.' )
			DebugEnterAlt(1);
			// Plsql.g:71:10: '.'
			{
			DebugLocation(71, 10);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__101", 63);
			LeaveRule("T__101", 63);
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
		EnterRule("T__102", 64);
		TraceIn("T__102", 64);
		try
		{
			int _type = T__102;
			int _channel = DefaultTokenChannel;
			// Plsql.g:72:8: ( '(' )
			DebugEnterAlt(1);
			// Plsql.g:72:10: '('
			{
			DebugLocation(72, 10);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__102", 64);
			LeaveRule("T__102", 64);
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
		EnterRule("T__103", 65);
		TraceIn("T__103", 65);
		try
		{
			int _type = T__103;
			int _channel = DefaultTokenChannel;
			// Plsql.g:73:8: ( ')' )
			DebugEnterAlt(1);
			// Plsql.g:73:10: ')'
			{
			DebugLocation(73, 10);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__103", 65);
			LeaveRule("T__103", 65);
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
		EnterRule("T__104", 66);
		TraceIn("T__104", 66);
		try
		{
			int _type = T__104;
			int _channel = DefaultTokenChannel;
			// Plsql.g:74:8: ( ',' )
			DebugEnterAlt(1);
			// Plsql.g:74:10: ','
			{
			DebugLocation(74, 10);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__104", 66);
			LeaveRule("T__104", 66);
			Leave_T__104();
		}
	}
	// $ANTLR end "T__104"

	partial void Enter_T__105();
	partial void Leave_T__105();

	// $ANTLR start "T__105"
	[GrammarRule("T__105")]
	private void mT__105()
	{
		Enter_T__105();
		EnterRule("T__105", 67);
		TraceIn("T__105", 67);
		try
		{
			int _type = T__105;
			int _channel = DefaultTokenChannel;
			// Plsql.g:75:8: ( ';' )
			DebugEnterAlt(1);
			// Plsql.g:75:10: ';'
			{
			DebugLocation(75, 10);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__105", 67);
			LeaveRule("T__105", 67);
			Leave_T__105();
		}
	}
	// $ANTLR end "T__105"

	partial void Enter_T__106();
	partial void Leave_T__106();

	// $ANTLR start "T__106"
	[GrammarRule("T__106")]
	private void mT__106()
	{
		Enter_T__106();
		EnterRule("T__106", 68);
		TraceIn("T__106", 68);
		try
		{
			int _type = T__106;
			int _channel = DefaultTokenChannel;
			// Plsql.g:76:8: ( '[' )
			DebugEnterAlt(1);
			// Plsql.g:76:10: '['
			{
			DebugLocation(76, 10);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__106", 68);
			LeaveRule("T__106", 68);
			Leave_T__106();
		}
	}
	// $ANTLR end "T__106"

	partial void Enter_T__107();
	partial void Leave_T__107();

	// $ANTLR start "T__107"
	[GrammarRule("T__107")]
	private void mT__107()
	{
		Enter_T__107();
		EnterRule("T__107", 69);
		TraceIn("T__107", 69);
		try
		{
			int _type = T__107;
			int _channel = DefaultTokenChannel;
			// Plsql.g:77:8: ( ']' )
			DebugEnterAlt(1);
			// Plsql.g:77:10: ']'
			{
			DebugLocation(77, 10);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__107", 69);
			LeaveRule("T__107", 69);
			Leave_T__107();
		}
	}
	// $ANTLR end "T__107"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 70);
		TraceIn("ID", 70);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// Plsql.g:137:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
			DebugEnterAlt(1);
			// Plsql.g:137:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
			{
			DebugLocation(137, 7);
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

			DebugLocation(137, 31);
			// Plsql.g:137:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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
					DebugLocation(137, 31);
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
			TraceOut("ID", 70);
			LeaveRule("ID", 70);
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
		EnterRule("INTEGER", 71);
		TraceIn("INTEGER", 71);
		try
		{
			int _type = INTEGER;
			int _channel = DefaultTokenChannel;
			// Plsql.g:141:2: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// Plsql.g:141:4: ( '0' .. '9' )+
			{
			DebugLocation(141, 4);
			// Plsql.g:141:4: ( '0' .. '9' )+
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
					// Plsql.g:141:5: '0' .. '9'
					{
					DebugLocation(141, 5);
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
			TraceOut("INTEGER", 71);
			LeaveRule("INTEGER", 71);
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
		EnterRule("REAL", 72);
		TraceIn("REAL", 72);
		try
		{
			int _type = REAL;
			int _channel = DefaultTokenChannel;
			// Plsql.g:145:2: ( INTEGER '.' INTEGER )
			DebugEnterAlt(1);
			// Plsql.g:145:4: INTEGER '.' INTEGER
			{
			DebugLocation(145, 4);
			mINTEGER(); 
			DebugLocation(145, 12);
			Match('.'); 
			DebugLocation(145, 16);
			mINTEGER(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REAL", 72);
			LeaveRule("REAL", 72);
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
		EnterRule("QUOTED_STRING", 73);
		TraceIn("QUOTED_STRING", 73);
		try
		{
			int _type = QUOTED_STRING;
			int _channel = DefaultTokenChannel;
			// Plsql.g:159:2: ( '\"' (~ ( '\\n' | '\\r' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// Plsql.g:159:4: '\"' (~ ( '\\n' | '\\r' | '\"' ) )* '\"'
			{
			DebugLocation(159, 4);
			Match('\"'); 
			DebugLocation(159, 8);
			// Plsql.g:159:8: (~ ( '\\n' | '\\r' | '\"' ) )*
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
					// Plsql.g:159:10: ~ ( '\\n' | '\\r' | '\"' )
					{
					DebugLocation(159, 10);
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

			DebugLocation(159, 30);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUOTED_STRING", 73);
			LeaveRule("QUOTED_STRING", 73);
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
		EnterRule("QUOTED_CHAR", 74);
		TraceIn("QUOTED_CHAR", 74);
		try
		{
			int _type = QUOTED_CHAR;
			int _channel = DefaultTokenChannel;
			// Plsql.g:163:2: ( '\\'' (~ ( '\\n' | '\\r' | '\\'' ) ) '\\'' )
			DebugEnterAlt(1);
			// Plsql.g:163:4: '\\'' (~ ( '\\n' | '\\r' | '\\'' ) ) '\\''
			{
			DebugLocation(163, 4);
			Match('\''); 
			DebugLocation(163, 9);
			// Plsql.g:163:9: (~ ( '\\n' | '\\r' | '\\'' ) )
			DebugEnterAlt(1);
			// Plsql.g:163:11: ~ ( '\\n' | '\\r' | '\\'' )
			{
			DebugLocation(163, 11);
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

			DebugLocation(163, 31);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUOTED_CHAR", 74);
			LeaveRule("QUOTED_CHAR", 74);
			Leave_QUOTED_CHAR();
		}
	}
	// $ANTLR end "QUOTED_CHAR"

	public override void mTokens()
	{
		// Plsql.g:1:8: ( BYTE | INT | CHAR | BOOL | DOUBLE | STRING | VOID | TYPE | IF | THEN | ELSE | DO | WHILE | LOOP | EXIT | WHEN | FOR | CREATE | BODY | PROCEDURE | FUNCTION | IS | AS | TABLE | ARRAY | INDEX | BY | OF | RECORD | OBJECT | MEMBER | STATIC | BEGIN | END | PACKAGE | DECLARE | SELF | NULL | IN | TRUE | FALSE | RETURN | PLUS | MINUS | MULT | DIVIDE | MOD | AND | OR | EQUAL | NEQUAL | MORE | LESS | MOREEQ | LESSEQ | NOT | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN | T__100 | T__101 | T__102 | T__103 | T__104 | T__105 | T__106 | T__107 | ID | INTEGER | REAL | QUOTED_STRING | QUOTED_CHAR )
		int alt4=74;
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
			// Plsql.g:1:10: BYTE
			{
			DebugLocation(1, 10);
			mBYTE(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Plsql.g:1:15: INT
			{
			DebugLocation(1, 15);
			mINT(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Plsql.g:1:19: CHAR
			{
			DebugLocation(1, 19);
			mCHAR(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Plsql.g:1:24: BOOL
			{
			DebugLocation(1, 24);
			mBOOL(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Plsql.g:1:29: DOUBLE
			{
			DebugLocation(1, 29);
			mDOUBLE(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Plsql.g:1:36: STRING
			{
			DebugLocation(1, 36);
			mSTRING(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Plsql.g:1:43: VOID
			{
			DebugLocation(1, 43);
			mVOID(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Plsql.g:1:48: TYPE
			{
			DebugLocation(1, 48);
			mTYPE(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// Plsql.g:1:53: IF
			{
			DebugLocation(1, 53);
			mIF(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// Plsql.g:1:56: THEN
			{
			DebugLocation(1, 56);
			mTHEN(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// Plsql.g:1:61: ELSE
			{
			DebugLocation(1, 61);
			mELSE(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// Plsql.g:1:66: DO
			{
			DebugLocation(1, 66);
			mDO(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// Plsql.g:1:69: WHILE
			{
			DebugLocation(1, 69);
			mWHILE(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// Plsql.g:1:75: LOOP
			{
			DebugLocation(1, 75);
			mLOOP(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// Plsql.g:1:80: EXIT
			{
			DebugLocation(1, 80);
			mEXIT(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// Plsql.g:1:85: WHEN
			{
			DebugLocation(1, 85);
			mWHEN(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// Plsql.g:1:90: FOR
			{
			DebugLocation(1, 90);
			mFOR(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// Plsql.g:1:94: CREATE
			{
			DebugLocation(1, 94);
			mCREATE(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// Plsql.g:1:101: BODY
			{
			DebugLocation(1, 101);
			mBODY(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// Plsql.g:1:106: PROCEDURE
			{
			DebugLocation(1, 106);
			mPROCEDURE(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// Plsql.g:1:116: FUNCTION
			{
			DebugLocation(1, 116);
			mFUNCTION(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// Plsql.g:1:125: IS
			{
			DebugLocation(1, 125);
			mIS(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// Plsql.g:1:128: AS
			{
			DebugLocation(1, 128);
			mAS(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// Plsql.g:1:131: TABLE
			{
			DebugLocation(1, 131);
			mTABLE(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// Plsql.g:1:137: ARRAY
			{
			DebugLocation(1, 137);
			mARRAY(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// Plsql.g:1:143: INDEX
			{
			DebugLocation(1, 143);
			mINDEX(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// Plsql.g:1:149: BY
			{
			DebugLocation(1, 149);
			mBY(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// Plsql.g:1:152: OF
			{
			DebugLocation(1, 152);
			mOF(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// Plsql.g:1:155: RECORD
			{
			DebugLocation(1, 155);
			mRECORD(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// Plsql.g:1:162: OBJECT
			{
			DebugLocation(1, 162);
			mOBJECT(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// Plsql.g:1:169: MEMBER
			{
			DebugLocation(1, 169);
			mMEMBER(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// Plsql.g:1:176: STATIC
			{
			DebugLocation(1, 176);
			mSTATIC(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// Plsql.g:1:183: BEGIN
			{
			DebugLocation(1, 183);
			mBEGIN(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// Plsql.g:1:189: END
			{
			DebugLocation(1, 189);
			mEND(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// Plsql.g:1:193: PACKAGE
			{
			DebugLocation(1, 193);
			mPACKAGE(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// Plsql.g:1:201: DECLARE
			{
			DebugLocation(1, 201);
			mDECLARE(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// Plsql.g:1:209: SELF
			{
			DebugLocation(1, 209);
			mSELF(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// Plsql.g:1:214: NULL
			{
			DebugLocation(1, 214);
			mNULL(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// Plsql.g:1:219: IN
			{
			DebugLocation(1, 219);
			mIN(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// Plsql.g:1:222: TRUE
			{
			DebugLocation(1, 222);
			mTRUE(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// Plsql.g:1:227: FALSE
			{
			DebugLocation(1, 227);
			mFALSE(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// Plsql.g:1:233: RETURN
			{
			DebugLocation(1, 233);
			mRETURN(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// Plsql.g:1:240: PLUS
			{
			DebugLocation(1, 240);
			mPLUS(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// Plsql.g:1:245: MINUS
			{
			DebugLocation(1, 245);
			mMINUS(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// Plsql.g:1:251: MULT
			{
			DebugLocation(1, 251);
			mMULT(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// Plsql.g:1:256: DIVIDE
			{
			DebugLocation(1, 256);
			mDIVIDE(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// Plsql.g:1:263: MOD
			{
			DebugLocation(1, 263);
			mMOD(); 

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// Plsql.g:1:267: AND
			{
			DebugLocation(1, 267);
			mAND(); 

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// Plsql.g:1:271: OR
			{
			DebugLocation(1, 271);
			mOR(); 

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// Plsql.g:1:274: EQUAL
			{
			DebugLocation(1, 274);
			mEQUAL(); 

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// Plsql.g:1:280: NEQUAL
			{
			DebugLocation(1, 280);
			mNEQUAL(); 

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// Plsql.g:1:287: MORE
			{
			DebugLocation(1, 287);
			mMORE(); 

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// Plsql.g:1:292: LESS
			{
			DebugLocation(1, 292);
			mLESS(); 

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// Plsql.g:1:297: MOREEQ
			{
			DebugLocation(1, 297);
			mMOREEQ(); 

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// Plsql.g:1:304: LESSEQ
			{
			DebugLocation(1, 304);
			mLESSEQ(); 

			}
			break;
		case 56:
			DebugEnterAlt(56);
			// Plsql.g:1:311: NOT
			{
			DebugLocation(1, 311);
			mNOT(); 

			}
			break;
		case 57:
			DebugEnterAlt(57);
			// Plsql.g:1:315: ASSIGN
			{
			DebugLocation(1, 315);
			mASSIGN(); 

			}
			break;
		case 58:
			DebugEnterAlt(58);
			// Plsql.g:1:322: PLUSASSIGN
			{
			DebugLocation(1, 322);
			mPLUSASSIGN(); 

			}
			break;
		case 59:
			DebugEnterAlt(59);
			// Plsql.g:1:333: MINUSASSIGN
			{
			DebugLocation(1, 333);
			mMINUSASSIGN(); 

			}
			break;
		case 60:
			DebugEnterAlt(60);
			// Plsql.g:1:345: MULTASSIGN
			{
			DebugLocation(1, 345);
			mMULTASSIGN(); 

			}
			break;
		case 61:
			DebugEnterAlt(61);
			// Plsql.g:1:356: DIVASSIGN
			{
			DebugLocation(1, 356);
			mDIVASSIGN(); 

			}
			break;
		case 62:
			DebugEnterAlt(62);
			// Plsql.g:1:366: T__100
			{
			DebugLocation(1, 366);
			mT__100(); 

			}
			break;
		case 63:
			DebugEnterAlt(63);
			// Plsql.g:1:373: T__101
			{
			DebugLocation(1, 373);
			mT__101(); 

			}
			break;
		case 64:
			DebugEnterAlt(64);
			// Plsql.g:1:380: T__102
			{
			DebugLocation(1, 380);
			mT__102(); 

			}
			break;
		case 65:
			DebugEnterAlt(65);
			// Plsql.g:1:387: T__103
			{
			DebugLocation(1, 387);
			mT__103(); 

			}
			break;
		case 66:
			DebugEnterAlt(66);
			// Plsql.g:1:394: T__104
			{
			DebugLocation(1, 394);
			mT__104(); 

			}
			break;
		case 67:
			DebugEnterAlt(67);
			// Plsql.g:1:401: T__105
			{
			DebugLocation(1, 401);
			mT__105(); 

			}
			break;
		case 68:
			DebugEnterAlt(68);
			// Plsql.g:1:408: T__106
			{
			DebugLocation(1, 408);
			mT__106(); 

			}
			break;
		case 69:
			DebugEnterAlt(69);
			// Plsql.g:1:415: T__107
			{
			DebugLocation(1, 415);
			mT__107(); 

			}
			break;
		case 70:
			DebugEnterAlt(70);
			// Plsql.g:1:422: ID
			{
			DebugLocation(1, 422);
			mID(); 

			}
			break;
		case 71:
			DebugEnterAlt(71);
			// Plsql.g:1:425: INTEGER
			{
			DebugLocation(1, 425);
			mINTEGER(); 

			}
			break;
		case 72:
			DebugEnterAlt(72);
			// Plsql.g:1:433: REAL
			{
			DebugLocation(1, 433);
			mREAL(); 

			}
			break;
		case 73:
			DebugEnterAlt(73);
			// Plsql.g:1:438: QUOTED_STRING
			{
			DebugLocation(1, 438);
			mQUOTED_STRING(); 

			}
			break;
		case 74:
			DebugEnterAlt(74);
			// Plsql.g:1:452: QUOTED_CHAR
			{
			DebugLocation(1, 452);
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
			"\x1\xFFFF\xA\x25\x1\x42\x6\x25\x1\x4D\x1\x4F\x1\x51\x1\x53\x4\xFFFF"+
			"\x1\x55\x1\x57\x1\x59\x9\xFFFF\x1\x5A\x2\xFFFF\x1\x5D\x2\x25\x1\x63\x1"+
			"\x64\x1\x65\x2\x25\x1\x69\x10\x25\x1\xFFFF\x2\x25\x1\x7E\x1\x25\x1\x80"+
			"\x4\x25\x10\xFFFF\x1\x25\x1\xFFFF\x3\x25\x1\x8A\x1\x25\x3\xFFFF\x3\x25"+
			"\x1\xFFFF\xB\x25\x1\x9A\x3\x25\x1\x9E\x4\x25\x1\xFFFF\x1\x25\x1\xFFFF"+
			"\x5\x25\x1\xA9\x1\xAA\x1\xAB\x1\x25\x1\xFFFF\x1\x25\x1\xAE\x5\x25\x1"+
			"\xB4\x1\xB5\x1\xB6\x1\xB7\x1\x25\x1\xB9\x1\xBA\x1\xBB\x1\xFFFF\x1\x25"+
			"\x1\xBD\x1\xBE\x1\xFFFF\x9\x25\x1\xC8\x3\xFFFF\x1\xC9\x1\xCA\x1\xFFFF"+
			"\x5\x25\x4\xFFFF\x1\xD0\x3\xFFFF\x1\xD1\x2\xFFFF\x1\x25\x1\xD3\x2\x25"+
			"\x1\xD6\x4\x25\x3\xFFFF\x1\xDB\x1\xDC\x1\x25\x1\xDE\x1\xDF\x2\xFFFF\x1"+
			"\x25\x1\xFFFF\x2\x25\x1\xFFFF\x1\xE3\x1\xE4\x1\xE5\x1\xE6\x2\xFFFF\x1"+
			"\xE7\x2\xFFFF\x2\x25\x1\xEA\x5\xFFFF\x1\xEB\x1\x25\x2\xFFFF\x1\xED\x1"+
			"\xFFFF";
		private const string DFA4_eofS =
			"\xEE\xFFFF";
		private const string DFA4_minS =
			"\x1\x21\x1\x65\x1\x66\x1\x68\x2\x65\x1\x6F\x1\x61\x1\x6C\x1\x68\x1\x6F"+
			"\x1\x30\x1\x61\x1\x72\x1\x62\x2\x65\x1\x75\x4\x3D\x4\xFFFF\x3\x3D\x9"+
			"\xFFFF\x1\x2E\x2\xFFFF\x1\x30\x1\x64\x1\x67\x3\x30\x1\x61\x1\x65\x1\x30"+
			"\x1\x63\x1\x61\x1\x6C\x1\x69\x1\x70\x1\x65\x1\x62\x1\x75\x1\x73\x1\x69"+
			"\x1\x64\x1\x65\x1\x6F\x1\x72\x1\x6E\x1\x6C\x1\xFFFF\x1\x6F\x1\x63\x1"+
			"\x30\x1\x72\x1\x30\x1\x6A\x1\x63\x1\x6D\x1\x6C\x10\xFFFF\x1\x65\x1\xFFFF"+
			"\x1\x6C\x1\x79\x1\x69\x1\x30\x1\x65\x3\xFFFF\x1\x72\x1\x61\x1\x62\x1"+
			"\xFFFF\x1\x6C\x1\x69\x1\x74\x1\x66\x1\x64\x1\x65\x1\x6E\x1\x6C\x2\x65"+
			"\x1\x74\x1\x30\x1\x6C\x1\x6E\x1\x70\x1\x30\x1\x63\x1\x73\x1\x63\x1\x6B"+
			"\x1\xFFFF\x1\x61\x1\xFFFF\x1\x65\x1\x6F\x1\x75\x1\x62\x1\x6C\x3\x30\x1"+
			"\x6E\x1\xFFFF\x1\x78\x1\x30\x1\x74\x1\x6C\x1\x61\x1\x6E\x1\x69\x4\x30"+
			"\x1\x65\x3\x30\x1\xFFFF\x1\x65\x2\x30\x1\xFFFF\x1\x74\x2\x65\x1\x61\x1"+
			"\x79\x1\x63\x2\x72\x1\x65\x1\x30\x3\xFFFF\x2\x30\x1\xFFFF\x2\x65\x1\x72"+
			"\x1\x67\x1\x63\x4\xFFFF\x1\x30\x3\xFFFF\x1\x30\x2\xFFFF\x1\x69\x1\x30"+
			"\x1\x64\x1\x67\x1\x30\x1\x74\x1\x64\x1\x6E\x1\x72\x3\xFFFF\x2\x30\x1"+
			"\x65\x2\x30\x2\xFFFF\x1\x6F\x1\xFFFF\x1\x75\x1\x65\x1\xFFFF\x4\x30\x2"+
			"\xFFFF\x1\x30\x2\xFFFF\x1\x6E\x1\x72\x1\x30\x5\xFFFF\x1\x30\x1\x65\x2"+
			"\xFFFF\x1\x30\x1\xFFFF";
		private const string DFA4_maxS =
			"\x1\x7C\x1\x79\x1\x73\x1\x72\x1\x6F\x1\x74\x1\x6F\x1\x79\x1\x78\x1\x68"+
			"\x1\x6F\x1\x7A\x1\x72\x1\x73\x1\x66\x2\x65\x1\x75\x4\x3D\x4\xFFFF\x3"+
			"\x3D\x9\xFFFF\x1\x39\x2\xFFFF\x1\x7A\x1\x6F\x1\x67\x3\x7A\x1\x61\x1\x65"+
			"\x1\x7A\x1\x63\x1\x72\x1\x6C\x1\x69\x1\x70\x1\x65\x1\x62\x1\x75\x1\x73"+
			"\x1\x69\x1\x64\x1\x69\x1\x6F\x1\x72\x1\x6E\x1\x6C\x1\xFFFF\x1\x6F\x1"+
			"\x63\x1\x7A\x1\x72\x1\x7A\x1\x6A\x1\x74\x1\x6D\x1\x6C\x10\xFFFF\x1\x65"+
			"\x1\xFFFF\x1\x6C\x1\x79\x1\x69\x1\x7A\x1\x65\x3\xFFFF\x1\x72\x1\x61\x1"+
			"\x62\x1\xFFFF\x1\x6C\x1\x69\x1\x74\x1\x66\x1\x64\x1\x65\x1\x6E\x1\x6C"+
			"\x2\x65\x1\x74\x1\x7A\x1\x6C\x1\x6E\x1\x70\x1\x7A\x1\x63\x1\x73\x1\x63"+
			"\x1\x6B\x1\xFFFF\x1\x61\x1\xFFFF\x1\x65\x1\x6F\x1\x75\x1\x62\x1\x6C\x3"+
			"\x7A\x1\x6E\x1\xFFFF\x1\x78\x1\x7A\x1\x74\x1\x6C\x1\x61\x1\x6E\x1\x69"+
			"\x4\x7A\x1\x65\x3\x7A\x1\xFFFF\x1\x65\x2\x7A\x1\xFFFF\x1\x74\x2\x65\x1"+
			"\x61\x1\x79\x1\x63\x2\x72\x1\x65\x1\x7A\x3\xFFFF\x2\x7A\x1\xFFFF\x2\x65"+
			"\x1\x72\x1\x67\x1\x63\x4\xFFFF\x1\x7A\x3\xFFFF\x1\x7A\x2\xFFFF\x1\x69"+
			"\x1\x7A\x1\x64\x1\x67\x1\x7A\x1\x74\x1\x64\x1\x6E\x1\x72\x3\xFFFF\x2"+
			"\x7A\x1\x65\x2\x7A\x2\xFFFF\x1\x6F\x1\xFFFF\x1\x75\x1\x65\x1\xFFFF\x4"+
			"\x7A\x2\xFFFF\x1\x7A\x2\xFFFF\x1\x6E\x1\x72\x1\x7A\x5\xFFFF\x1\x7A\x1"+
			"\x65\x2\xFFFF\x1\x7A\x1\xFFFF";
		private const string DFA4_acceptS =
			"\x16\xFFFF\x1\x2F\x1\x30\x1\x31\x1\x32\x3\xFFFF\x1\x39\x1\x3F\x1\x40"+
			"\x1\x41\x1\x42\x1\x43\x1\x44\x1\x45\x1\x46\x1\xFFFF\x1\x49\x1\x4A\x19"+
			"\xFFFF\x1\x3E\x9\xFFFF\x1\x3A\x1\x2B\x1\x3B\x1\x2C\x1\x3C\x1\x2D\x1\x3D"+
			"\x1\x2E\x1\x33\x1\x38\x1\x36\x1\x34\x1\x37\x1\x35\x1\x47\x1\x48\x1\xFFFF"+
			"\x1\x1B\x5\xFFFF\x1\x27\x1\x9\x1\x16\x3\xFFFF\x1\xC\x14\xFFFF\x1\x17"+
			"\x1\xFFFF\x1\x1C\x9\xFFFF\x1\x2\xF\xFFFF\x1\x22\x3\xFFFF\x1\x11\xA\xFFFF"+
			"\x1\x1\x1\x4\x1\x13\x2\xFFFF\x1\x3\x5\xFFFF\x1\x25\x1\x7\x1\x8\x1\xA"+
			"\x1\xFFFF\x1\x28\x1\xB\x1\xF\x1\xFFFF\x1\x10\x1\xE\x9\xFFFF\x1\x26\x1"+
			"\x21\x1\x1A\x5\xFFFF\x1\x18\x1\xD\x1\xFFFF\x1\x29\x2\xFFFF\x1\x19\x4"+
			"\xFFFF\x1\x12\x1\x5\x1\xFFFF\x1\x6\x1\x20\x3\xFFFF\x1\x1E\x1\x1D\x1\x2A"+
			"\x1\x1F\x1\x24\x2\xFFFF\x1\x23\x1\x15\x1\xFFFF\x1\x14";
		private const string DFA4_specialS =
			"\xEE\xFFFF}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x1\x1A\x1\x27\x2\xFFFF\x1\x16\x1\x17\x1\x28\x1\x1F\x1\x20\x1\x14\x1"+
				"\x12\x1\x21\x1\x13\x1\x1E\x1\x15\xA\x26\x1\x1D\x1\x22\x1\x1C\x1\x19"+
				"\x1\x1B\x2\xFFFF\x1A\x25\x1\x23\x1\xFFFF\x1\x24\x1\xFFFF\x1\x25\x1\xFFFF"+
				"\x1\xD\x1\x1\x1\x3\x1\x4\x1\x8\x1\xB\x2\x25\x1\x2\x2\x25\x1\xA\x1\x10"+
				"\x1\x11\x1\xE\x1\xC\x1\x25\x1\xF\x1\x5\x1\x7\x1\x25\x1\x6\x1\x9\x3\x25"+
				"\x1\xFFFF\x1\x18",
				"\x1\x2B\x9\xFFFF\x1\x2A\x9\xFFFF\x1\x29",
				"\x1\x2D\x7\xFFFF\x1\x2C\x4\xFFFF\x1\x2E",
				"\x1\x2F\x9\xFFFF\x1\x30",
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
				"\x1\x46\x1\x45",
				"\x1\x48\x3\xFFFF\x1\x47",
				"\x1\x49",
				"\x1\x4A",
				"\x1\x4B",
				"\x1\x4C",
				"\x1\x4E",
				"\x1\x50",
				"\x1\x52",
				"",
				"",
				"",
				"",
				"\x1\x54",
				"\x1\x56",
				"\x1\x58",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x5B\x1\xFFFF\xA\x26",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x13\x25\x1\x5C\x6"+
				"\x25",
				"\x1\x5F\xA\xFFFF\x1\x5E",
				"\x1\x60",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x3\x25\x1\x62\xF"+
				"\x25\x1\x61\x6\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x66",
				"\x1\x67",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x14\x25\x1\x68\x5"+
				"\x25",
				"\x1\x6A",
				"\x1\x6C\x10\xFFFF\x1\x6B",
				"\x1\x6D",
				"\x1\x6E",
				"\x1\x6F",
				"\x1\x70",
				"\x1\x71",
				"\x1\x72",
				"\x1\x73",
				"\x1\x74",
				"\x1\x75",
				"\x1\x77\x3\xFFFF\x1\x76",
				"\x1\x78",
				"\x1\x79",
				"\x1\x7A",
				"\x1\x7B",
				"",
				"\x1\x7C",
				"\x1\x7D",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x7F",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x81",
				"\x1\x82\x10\xFFFF\x1\x83",
				"\x1\x84",
				"\x1\x85",
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
				"\x1\x86",
				"",
				"\x1\x87",
				"\x1\x88",
				"\x1\x89",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x8B",
				"",
				"",
				"",
				"\x1\x8C",
				"\x1\x8D",
				"\x1\x8E",
				"",
				"\x1\x8F",
				"\x1\x90",
				"\x1\x91",
				"\x1\x92",
				"\x1\x93",
				"\x1\x94",
				"\x1\x95",
				"\x1\x96",
				"\x1\x97",
				"\x1\x98",
				"\x1\x99",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x9B",
				"\x1\x9C",
				"\x1\x9D",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\x9F",
				"\x1\xA0",
				"\x1\xA1",
				"\x1\xA2",
				"",
				"\x1\xA3",
				"",
				"\x1\xA4",
				"\x1\xA5",
				"\x1\xA6",
				"\x1\xA7",
				"\x1\xA8",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xAC",
				"",
				"\x1\xAD",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xAF",
				"\x1\xB0",
				"\x1\xB1",
				"\x1\xB2",
				"\x1\xB3",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xB8",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\xBC",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\xBF",
				"\x1\xC0",
				"\x1\xC1",
				"\x1\xC2",
				"\x1\xC3",
				"\x1\xC4",
				"\x1\xC5",
				"\x1\xC6",
				"\x1\xC7",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"\x1\xCB",
				"\x1\xCC",
				"\x1\xCD",
				"\x1\xCE",
				"\x1\xCF",
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
				"\x1\xD2",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xD4",
				"\x1\xD5",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xD7",
				"\x1\xD8",
				"\x1\xD9",
				"\x1\xDA",
				"",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xDD",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\x1\xE0",
				"",
				"\x1\xE1",
				"\x1\xE2",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"\x1\xE8",
				"\x1\xE9",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"",
				"",
				"",
				"",
				"",
				"\xA\x25\x7\xFFFF\x1A\x25\x4\xFFFF\x1\x25\x1\xFFFF\x1A\x25",
				"\x1\xEC",
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

		public override string Description { get { return "1:1: Tokens : ( BYTE | INT | CHAR | BOOL | DOUBLE | STRING | VOID | TYPE | IF | THEN | ELSE | DO | WHILE | LOOP | EXIT | WHEN | FOR | CREATE | BODY | PROCEDURE | FUNCTION | IS | AS | TABLE | ARRAY | INDEX | BY | OF | RECORD | OBJECT | MEMBER | STATIC | BEGIN | END | PACKAGE | DECLARE | SELF | NULL | IN | TRUE | FALSE | RETURN | PLUS | MINUS | MULT | DIVIDE | MOD | AND | OR | EQUAL | NEQUAL | MORE | LESS | MOREEQ | LESSEQ | NOT | ASSIGN | PLUSASSIGN | MINUSASSIGN | MULTASSIGN | DIVASSIGN | T__100 | T__101 | T__102 | T__103 | T__104 | T__105 | T__106 | T__107 | ID | INTEGER | REAL | QUOTED_STRING | QUOTED_CHAR );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  plsql_msil 
