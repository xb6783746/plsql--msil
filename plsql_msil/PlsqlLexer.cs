// $ANTLR 3.3 Nov 30, 2010 12:50:56 Plsql.g 2017-02-19 17:05:31

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
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

 
	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    protected virtual void Enter_INT() {}
    protected virtual void Leave_INT() {}

    // $ANTLR start "INT"
    [GrammarRule("INT")]
    private void mINT()
    {

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
        }
    }
    // $ANTLR end "INT"

    protected virtual void Enter_CHAR() {}
    protected virtual void Leave_CHAR() {}

    // $ANTLR start "CHAR"
    [GrammarRule("CHAR")]
    private void mCHAR()
    {

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
        }
    }
    // $ANTLR end "CHAR"

    protected virtual void Enter_BOOL() {}
    protected virtual void Leave_BOOL() {}

    // $ANTLR start "BOOL"
    [GrammarRule("BOOL")]
    private void mBOOL()
    {

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
        }
    }
    // $ANTLR end "BOOL"

    protected virtual void Enter_DOUBLE() {}
    protected virtual void Leave_DOUBLE() {}

    // $ANTLR start "DOUBLE"
    [GrammarRule("DOUBLE")]
    private void mDOUBLE()
    {

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
        }
    }
    // $ANTLR end "DOUBLE"

    protected virtual void Enter_STRING() {}
    protected virtual void Leave_STRING() {}

    // $ANTLR start "STRING"
    [GrammarRule("STRING")]
    private void mSTRING()
    {

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
        }
    }
    // $ANTLR end "STRING"

    protected virtual void Enter_VOID() {}
    protected virtual void Leave_VOID() {}

    // $ANTLR start "VOID"
    [GrammarRule("VOID")]
    private void mVOID()
    {

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
        }
    }
    // $ANTLR end "VOID"

    protected virtual void Enter_TYPE() {}
    protected virtual void Leave_TYPE() {}

    // $ANTLR start "TYPE"
    [GrammarRule("TYPE")]
    private void mTYPE()
    {

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
        }
    }
    // $ANTLR end "TYPE"

    protected virtual void Enter_IF() {}
    protected virtual void Leave_IF() {}

    // $ANTLR start "IF"
    [GrammarRule("IF")]
    private void mIF()
    {

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
        }
    }
    // $ANTLR end "IF"

    protected virtual void Enter_THEN() {}
    protected virtual void Leave_THEN() {}

    // $ANTLR start "THEN"
    [GrammarRule("THEN")]
    private void mTHEN()
    {

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
        }
    }
    // $ANTLR end "THEN"

    protected virtual void Enter_ELSE() {}
    protected virtual void Leave_ELSE() {}

    // $ANTLR start "ELSE"
    [GrammarRule("ELSE")]
    private void mELSE()
    {

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
        }
    }
    // $ANTLR end "ELSE"

    protected virtual void Enter_DO() {}
    protected virtual void Leave_DO() {}

    // $ANTLR start "DO"
    [GrammarRule("DO")]
    private void mDO()
    {

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
        }
    }
    // $ANTLR end "DO"

    protected virtual void Enter_WHILE() {}
    protected virtual void Leave_WHILE() {}

    // $ANTLR start "WHILE"
    [GrammarRule("WHILE")]
    private void mWHILE()
    {

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
        }
    }
    // $ANTLR end "WHILE"

    protected virtual void Enter_LOOP() {}
    protected virtual void Leave_LOOP() {}

    // $ANTLR start "LOOP"
    [GrammarRule("LOOP")]
    private void mLOOP()
    {

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
        }
    }
    // $ANTLR end "LOOP"

    protected virtual void Enter_EXIT() {}
    protected virtual void Leave_EXIT() {}

    // $ANTLR start "EXIT"
    [GrammarRule("EXIT")]
    private void mEXIT()
    {

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
        }
    }
    // $ANTLR end "EXIT"

    protected virtual void Enter_WHEN() {}
    protected virtual void Leave_WHEN() {}

    // $ANTLR start "WHEN"
    [GrammarRule("WHEN")]
    private void mWHEN()
    {

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
        }
    }
    // $ANTLR end "WHEN"

    protected virtual void Enter_FOR() {}
    protected virtual void Leave_FOR() {}

    // $ANTLR start "FOR"
    [GrammarRule("FOR")]
    private void mFOR()
    {

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
        }
    }
    // $ANTLR end "FOR"

    protected virtual void Enter_CREATE() {}
    protected virtual void Leave_CREATE() {}

    // $ANTLR start "CREATE"
    [GrammarRule("CREATE")]
    private void mCREATE()
    {

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
        }
    }
    // $ANTLR end "CREATE"

    protected virtual void Enter_BODY() {}
    protected virtual void Leave_BODY() {}

    // $ANTLR start "BODY"
    [GrammarRule("BODY")]
    private void mBODY()
    {

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
        }
    }
    // $ANTLR end "BODY"

    protected virtual void Enter_PROCEDURE() {}
    protected virtual void Leave_PROCEDURE() {}

    // $ANTLR start "PROCEDURE"
    [GrammarRule("PROCEDURE")]
    private void mPROCEDURE()
    {

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
        }
    }
    // $ANTLR end "PROCEDURE"

    protected virtual void Enter_FUNCTION() {}
    protected virtual void Leave_FUNCTION() {}

    // $ANTLR start "FUNCTION"
    [GrammarRule("FUNCTION")]
    private void mFUNCTION()
    {

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
        }
    }
    // $ANTLR end "FUNCTION"

    protected virtual void Enter_IS() {}
    protected virtual void Leave_IS() {}

    // $ANTLR start "IS"
    [GrammarRule("IS")]
    private void mIS()
    {

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
        }
    }
    // $ANTLR end "IS"

    protected virtual void Enter_AS() {}
    protected virtual void Leave_AS() {}

    // $ANTLR start "AS"
    [GrammarRule("AS")]
    private void mAS()
    {

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
        }
    }
    // $ANTLR end "AS"

    protected virtual void Enter_TABLE() {}
    protected virtual void Leave_TABLE() {}

    // $ANTLR start "TABLE"
    [GrammarRule("TABLE")]
    private void mTABLE()
    {

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
        }
    }
    // $ANTLR end "TABLE"

    protected virtual void Enter_OF() {}
    protected virtual void Leave_OF() {}

    // $ANTLR start "OF"
    [GrammarRule("OF")]
    private void mOF()
    {

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
        }
    }
    // $ANTLR end "OF"

    protected virtual void Enter_INDEX() {}
    protected virtual void Leave_INDEX() {}

    // $ANTLR start "INDEX"
    [GrammarRule("INDEX")]
    private void mINDEX()
    {

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
        }
    }
    // $ANTLR end "INDEX"

    protected virtual void Enter_BY() {}
    protected virtual void Leave_BY() {}

    // $ANTLR start "BY"
    [GrammarRule("BY")]
    private void mBY()
    {

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
        }
    }
    // $ANTLR end "BY"

    protected virtual void Enter_RECORD() {}
    protected virtual void Leave_RECORD() {}

    // $ANTLR start "RECORD"
    [GrammarRule("RECORD")]
    private void mRECORD()
    {

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
        }
    }
    // $ANTLR end "RECORD"

    protected virtual void Enter_OBJECT() {}
    protected virtual void Leave_OBJECT() {}

    // $ANTLR start "OBJECT"
    [GrammarRule("OBJECT")]
    private void mOBJECT()
    {

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
        }
    }
    // $ANTLR end "OBJECT"

    protected virtual void Enter_MEMBER() {}
    protected virtual void Leave_MEMBER() {}

    // $ANTLR start "MEMBER"
    [GrammarRule("MEMBER")]
    private void mMEMBER()
    {

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
        }
    }
    // $ANTLR end "MEMBER"

    protected virtual void Enter_STATIC() {}
    protected virtual void Leave_STATIC() {}

    // $ANTLR start "STATIC"
    [GrammarRule("STATIC")]
    private void mSTATIC()
    {

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
        }
    }
    // $ANTLR end "STATIC"

    protected virtual void Enter_BEGIN() {}
    protected virtual void Leave_BEGIN() {}

    // $ANTLR start "BEGIN"
    [GrammarRule("BEGIN")]
    private void mBEGIN()
    {

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
        }
    }
    // $ANTLR end "BEGIN"

    protected virtual void Enter_END() {}
    protected virtual void Leave_END() {}

    // $ANTLR start "END"
    [GrammarRule("END")]
    private void mEND()
    {

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
        }
    }
    // $ANTLR end "END"

    protected virtual void Enter_PACKAGE() {}
    protected virtual void Leave_PACKAGE() {}

    // $ANTLR start "PACKAGE"
    [GrammarRule("PACKAGE")]
    private void mPACKAGE()
    {

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
        }
    }
    // $ANTLR end "PACKAGE"

    protected virtual void Enter_DECLARE() {}
    protected virtual void Leave_DECLARE() {}

    // $ANTLR start "DECLARE"
    [GrammarRule("DECLARE")]
    private void mDECLARE()
    {

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
        }
    }
    // $ANTLR end "DECLARE"

    protected virtual void Enter_SELF() {}
    protected virtual void Leave_SELF() {}

    // $ANTLR start "SELF"
    [GrammarRule("SELF")]
    private void mSELF()
    {

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
        }
    }
    // $ANTLR end "SELF"

    protected virtual void Enter_NULL() {}
    protected virtual void Leave_NULL() {}

    // $ANTLR start "NULL"
    [GrammarRule("NULL")]
    private void mNULL()
    {

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
        }
    }
    // $ANTLR end "NULL"

    protected virtual void Enter_IN() {}
    protected virtual void Leave_IN() {}

    // $ANTLR start "IN"
    [GrammarRule("IN")]
    private void mIN()
    {

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
        }
    }
    // $ANTLR end "IN"

    protected virtual void Enter_TRUE() {}
    protected virtual void Leave_TRUE() {}

    // $ANTLR start "TRUE"
    [GrammarRule("TRUE")]
    private void mTRUE()
    {

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
        }
    }
    // $ANTLR end "TRUE"

    protected virtual void Enter_FALSE() {}
    protected virtual void Leave_FALSE() {}

    // $ANTLR start "FALSE"
    [GrammarRule("FALSE")]
    private void mFALSE()
    {

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
        }
    }
    // $ANTLR end "FALSE"

    protected virtual void Enter_RETURN() {}
    protected virtual void Leave_RETURN() {}

    // $ANTLR start "RETURN"
    [GrammarRule("RETURN")]
    private void mRETURN()
    {

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
        }
    }
    // $ANTLR end "RETURN"

    protected virtual void Enter_PLUS() {}
    protected virtual void Leave_PLUS() {}

    // $ANTLR start "PLUS"
    [GrammarRule("PLUS")]
    private void mPLUS()
    {

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
        }
    }
    // $ANTLR end "PLUS"

    protected virtual void Enter_MINUS() {}
    protected virtual void Leave_MINUS() {}

    // $ANTLR start "MINUS"
    [GrammarRule("MINUS")]
    private void mMINUS()
    {

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
        }
    }
    // $ANTLR end "MINUS"

    protected virtual void Enter_MULT() {}
    protected virtual void Leave_MULT() {}

    // $ANTLR start "MULT"
    [GrammarRule("MULT")]
    private void mMULT()
    {

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
        }
    }
    // $ANTLR end "MULT"

    protected virtual void Enter_DIVIDE() {}
    protected virtual void Leave_DIVIDE() {}

    // $ANTLR start "DIVIDE"
    [GrammarRule("DIVIDE")]
    private void mDIVIDE()
    {

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
        }
    }
    // $ANTLR end "DIVIDE"

    protected virtual void Enter_MOD() {}
    protected virtual void Leave_MOD() {}

    // $ANTLR start "MOD"
    [GrammarRule("MOD")]
    private void mMOD()
    {

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
        }
    }
    // $ANTLR end "MOD"

    protected virtual void Enter_AND() {}
    protected virtual void Leave_AND() {}

    // $ANTLR start "AND"
    [GrammarRule("AND")]
    private void mAND()
    {

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
        }
    }
    // $ANTLR end "AND"

    protected virtual void Enter_OR() {}
    protected virtual void Leave_OR() {}

    // $ANTLR start "OR"
    [GrammarRule("OR")]
    private void mOR()
    {

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
        }
    }
    // $ANTLR end "OR"

    protected virtual void Enter_EQUAL() {}
    protected virtual void Leave_EQUAL() {}

    // $ANTLR start "EQUAL"
    [GrammarRule("EQUAL")]
    private void mEQUAL()
    {

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
        }
    }
    // $ANTLR end "EQUAL"

    protected virtual void Enter_NEQUAL() {}
    protected virtual void Leave_NEQUAL() {}

    // $ANTLR start "NEQUAL"
    [GrammarRule("NEQUAL")]
    private void mNEQUAL()
    {

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
        }
    }
    // $ANTLR end "NEQUAL"

    protected virtual void Enter_MORE() {}
    protected virtual void Leave_MORE() {}

    // $ANTLR start "MORE"
    [GrammarRule("MORE")]
    private void mMORE()
    {

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
        }
    }
    // $ANTLR end "MORE"

    protected virtual void Enter_LESS() {}
    protected virtual void Leave_LESS() {}

    // $ANTLR start "LESS"
    [GrammarRule("LESS")]
    private void mLESS()
    {

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
        }
    }
    // $ANTLR end "LESS"

    protected virtual void Enter_MOREEQ() {}
    protected virtual void Leave_MOREEQ() {}

    // $ANTLR start "MOREEQ"
    [GrammarRule("MOREEQ")]
    private void mMOREEQ()
    {

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
        }
    }
    // $ANTLR end "MOREEQ"

    protected virtual void Enter_LESSEQ() {}
    protected virtual void Leave_LESSEQ() {}

    // $ANTLR start "LESSEQ"
    [GrammarRule("LESSEQ")]
    private void mLESSEQ()
    {

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
        }
    }
    // $ANTLR end "LESSEQ"

    protected virtual void Enter_NOT() {}
    protected virtual void Leave_NOT() {}

    // $ANTLR start "NOT"
    [GrammarRule("NOT")]
    private void mNOT()
    {

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
        }
    }
    // $ANTLR end "NOT"

    protected virtual void Enter_ASSIGN() {}
    protected virtual void Leave_ASSIGN() {}

    // $ANTLR start "ASSIGN"
    [GrammarRule("ASSIGN")]
    private void mASSIGN()
    {

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
        }
    }
    // $ANTLR end "ASSIGN"

    protected virtual void Enter_PLUSASSIGN() {}
    protected virtual void Leave_PLUSASSIGN() {}

    // $ANTLR start "PLUSASSIGN"
    [GrammarRule("PLUSASSIGN")]
    private void mPLUSASSIGN()
    {

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
        }
    }
    // $ANTLR end "PLUSASSIGN"

    protected virtual void Enter_MINUSASSIGN() {}
    protected virtual void Leave_MINUSASSIGN() {}

    // $ANTLR start "MINUSASSIGN"
    [GrammarRule("MINUSASSIGN")]
    private void mMINUSASSIGN()
    {

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
        }
    }
    // $ANTLR end "MINUSASSIGN"

    protected virtual void Enter_MULTASSIGN() {}
    protected virtual void Leave_MULTASSIGN() {}

    // $ANTLR start "MULTASSIGN"
    [GrammarRule("MULTASSIGN")]
    private void mMULTASSIGN()
    {

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
        }
    }
    // $ANTLR end "MULTASSIGN"

    protected virtual void Enter_DIVASSIGN() {}
    protected virtual void Leave_DIVASSIGN() {}

    // $ANTLR start "DIVASSIGN"
    [GrammarRule("DIVASSIGN")]
    private void mDIVASSIGN()
    {

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
        }
    }
    // $ANTLR end "DIVASSIGN"

    protected virtual void Enter_T__97() {}
    protected virtual void Leave_T__97() {}

    // $ANTLR start "T__97"
    [GrammarRule("T__97")]
    private void mT__97()
    {

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
        }
    }
    // $ANTLR end "T__97"

    protected virtual void Enter_T__98() {}
    protected virtual void Leave_T__98() {}

    // $ANTLR start "T__98"
    [GrammarRule("T__98")]
    private void mT__98()
    {

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
        }
    }
    // $ANTLR end "T__98"

    protected virtual void Enter_T__99() {}
    protected virtual void Leave_T__99() {}

    // $ANTLR start "T__99"
    [GrammarRule("T__99")]
    private void mT__99()
    {

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
        }
    }
    // $ANTLR end "T__99"

    protected virtual void Enter_T__100() {}
    protected virtual void Leave_T__100() {}

    // $ANTLR start "T__100"
    [GrammarRule("T__100")]
    private void mT__100()
    {

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
        }
    }
    // $ANTLR end "T__100"

    protected virtual void Enter_T__101() {}
    protected virtual void Leave_T__101() {}

    // $ANTLR start "T__101"
    [GrammarRule("T__101")]
    private void mT__101()
    {

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
        }
    }
    // $ANTLR end "T__101"

    protected virtual void Enter_T__102() {}
    protected virtual void Leave_T__102() {}

    // $ANTLR start "T__102"
    [GrammarRule("T__102")]
    private void mT__102()
    {

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
        }
    }
    // $ANTLR end "T__102"

    protected virtual void Enter_T__103() {}
    protected virtual void Leave_T__103() {}

    // $ANTLR start "T__103"
    [GrammarRule("T__103")]
    private void mT__103()
    {

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
        }
    }
    // $ANTLR end "T__103"

    protected virtual void Enter_T__104() {}
    protected virtual void Leave_T__104() {}

    // $ANTLR start "T__104"
    [GrammarRule("T__104")]
    private void mT__104()
    {

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
        }
    }
    // $ANTLR end "T__104"

    protected virtual void Enter_ID() {}
    protected virtual void Leave_ID() {}

    // $ANTLR start "ID"
    [GrammarRule("ID")]
    private void mID()
    {

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
        }
    }
    // $ANTLR end "ID"

    protected virtual void Enter_INTEGER() {}
    protected virtual void Leave_INTEGER() {}

    // $ANTLR start "INTEGER"
    [GrammarRule("INTEGER")]
    private void mINTEGER()
    {

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
        }
    }
    // $ANTLR end "INTEGER"

    protected virtual void Enter_REAL() {}
    protected virtual void Leave_REAL() {}

    // $ANTLR start "REAL"
    [GrammarRule("REAL")]
    private void mREAL()
    {

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
        }
    }
    // $ANTLR end "REAL"

    protected virtual void Enter_QUOTED_STRING() {}
    protected virtual void Leave_QUOTED_STRING() {}

    // $ANTLR start "QUOTED_STRING"
    [GrammarRule("QUOTED_STRING")]
    private void mQUOTED_STRING()
    {

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
        }
    }
    // $ANTLR end "QUOTED_STRING"

    protected virtual void Enter_QUOTED_CHAR() {}
    protected virtual void Leave_QUOTED_CHAR() {}

    // $ANTLR start "QUOTED_CHAR"
    [GrammarRule("QUOTED_CHAR")]
    private void mQUOTED_CHAR()
    {

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
			"\x01\uffff\x0a\x25\x01\x42\x06\x25\x01\x4c\x01\x4e\x01\x50\x01\x52\x04"+
			"\uffff\x01\x54\x01\x56\x01\x58\x09\uffff\x01\x59\x02\uffff\x01\x5d\x01"+
			"\x5e\x01\x5f\x03\x25\x01\x64\x01\x25\x01\x67\x10\x25\x01\uffff\x02\x25"+
			"\x01\x7c\x01\x7d\x04\x25\x10\uffff\x01\u0083\x01\x25\x03\uffff\x04\x25"+
			"\x01\uffff\x02\x25\x01\uffff\x0b\x25\x01\u0096\x03\x25\x01\u009a\x04"+
			"\x25\x02\uffff\x05\x25\x01\uffff\x01\x25\x01\u00a5\x01\x25\x01\u00a7"+
			"\x01\u00a8\x05\x25\x01\u00ae\x01\u00af\x01\u00b0\x01\u00b1\x01\x25\x01"+
			"\u00b3\x01\u00b4\x01\u00b5\x01\uffff\x01\x25\x01\u00b7\x01\u00b8\x01"+
			"\uffff\x08\x25\x01\u00c1\x01\u00c2\x01\uffff\x01\x25\x02\uffff\x01\u00c4"+
			"\x04\x25\x04\uffff\x01\u00c9\x03\uffff\x01\u00ca\x02\uffff\x01\x25\x01"+
			"\u00cc\x06\x25\x02\uffff\x01\u00d3\x01\uffff\x01\u00d4\x01\x25\x01\u00d6"+
			"\x01\u00d7\x02\uffff\x01\x25\x01\uffff\x02\x25\x01\u00db\x01\u00dc\x01"+
			"\u00dd\x01\u00de\x02\uffff\x01\u00df\x02\uffff\x02\x25\x01\u00e2\x05"+
			"\uffff\x01\u00e3\x01\x25\x02\uffff\x01\u00e5\x01\uffff";
		private const string DFA4_eofS =
			"\u00e6\uffff";
		private const string DFA4_minS =
			"\x01\x21\x01\x66\x01\x68\x03\x65\x01\x6f\x01\x61\x01\x6c\x01\x68\x01"+
			"\x6f\x01\x30\x01\x61\x01\x73\x01\x62\x02\x65\x01\x75\x04\x3d\x04\uffff"+
			"\x03\x3d\x09\uffff\x01\x2e\x02\uffff\x03\x30\x01\x61\x01\x65\x01\x64"+
			"\x01\x30\x01\x67\x01\x30\x01\x63\x01\x61\x01\x6c\x01\x69\x01\x70\x01"+
			"\x65\x01\x62\x01\x75\x01\x73\x01\x69\x01\x64\x01\x65\x01\x6f\x01\x72"+
			"\x01\x6e\x01\x6c\x01\uffff\x01\x6f\x01\x63\x02\x30\x01\x6a\x01\x63\x01"+
			"\x6d\x01\x6c\x10\uffff\x01\x30\x01\x65\x03\uffff\x01\x72\x01\x61\x01"+
			"\x6c\x01\x79\x01\uffff\x01\x69\x01\x62\x01\uffff\x01\x6c\x01\x69\x01"+
			"\x74\x01\x66\x01\x64\x01\x65\x01\x6e\x01\x6c\x02\x65\x01\x74\x01\x30"+
			"\x01\x6c\x01\x6e\x01\x70\x01\x30\x01\x63\x01\x73\x01\x63\x01\x6b\x02"+
			"\uffff\x01\x65\x01\x6f\x01\x75\x01\x62\x01\x6c\x01\uffff\x01\x78\x01"+
			"\x30\x01\x74\x02\x30\x01\x6e\x01\x6c\x01\x61\x01\x6e\x01\x69\x04\x30"+
			"\x01\x65\x03\x30\x01\uffff\x01\x65\x02\x30\x01\uffff\x01\x74\x02\x65"+
			"\x01\x61\x01\x63\x02\x72\x01\x65\x02\x30\x01\uffff\x01\x65\x02\uffff"+
			"\x01\x30\x01\x65\x01\x72\x01\x67\x01\x63\x04\uffff\x01\x30\x03\uffff"+
			"\x01\x30\x02\uffff\x01\x69\x01\x30\x01\x64\x01\x67\x01\x74\x01\x64\x01"+
			"\x6e\x01\x72\x02\uffff\x01\x30\x01\uffff\x01\x30\x01\x65\x02\x30\x02"+
			"\uffff\x01\x6f\x01\uffff\x01\x75\x01\x65\x04\x30\x02\uffff\x01\x30\x02"+
			"\uffff\x01\x6e\x01\x72\x01\x30\x05\uffff\x01\x30\x01\x65\x02\uffff\x01"+
			"\x30\x01\uffff";
		private const string DFA4_maxS =
			"\x01\x7c\x01\x73\x01\x72\x01\x79\x01\x6f\x01\x74\x01\x6f\x01\x79\x01"+
			"\x78\x01\x68\x01\x6f\x01\x7a\x01\x72\x01\x73\x01\x66\x02\x65\x01\x75"+
			"\x04\x3d\x04\uffff\x03\x3d\x09\uffff\x01\x39\x02\uffff\x03\x7a\x01\x61"+
			"\x01\x65\x01\x6f\x01\x7a\x01\x67\x01\x7a\x01\x63\x01\x72\x01\x6c\x01"+
			"\x69\x01\x70\x01\x65\x01\x62\x01\x75\x01\x73\x01\x69\x01\x64\x01\x69"+
			"\x01\x6f\x01\x72\x01\x6e\x01\x6c\x01\uffff\x01\x6f\x01\x63\x02\x7a\x01"+
			"\x6a\x01\x74\x01\x6d\x01\x6c\x10\uffff\x01\x7a\x01\x65\x03\uffff\x01"+
			"\x72\x01\x61\x01\x6c\x01\x79\x01\uffff\x01\x69\x01\x62\x01\uffff\x01"+
			"\x6c\x01\x69\x01\x74\x01\x66\x01\x64\x01\x65\x01\x6e\x01\x6c\x02\x65"+
			"\x01\x74\x01\x7a\x01\x6c\x01\x6e\x01\x70\x01\x7a\x01\x63\x01\x73\x01"+
			"\x63\x01\x6b\x02\uffff\x01\x65\x01\x6f\x01\x75\x01\x62\x01\x6c\x01\uffff"+
			"\x01\x78\x01\x7a\x01\x74\x02\x7a\x01\x6e\x01\x6c\x01\x61\x01\x6e\x01"+
			"\x69\x04\x7a\x01\x65\x03\x7a\x01\uffff\x01\x65\x02\x7a\x01\uffff\x01"+
			"\x74\x02\x65\x01\x61\x01\x63\x02\x72\x01\x65\x02\x7a\x01\uffff\x01\x65"+
			"\x02\uffff\x01\x7a\x01\x65\x01\x72\x01\x67\x01\x63\x04\uffff\x01\x7a"+
			"\x03\uffff\x01\x7a\x02\uffff\x01\x69\x01\x7a\x01\x64\x01\x67\x01\x74"+
			"\x01\x64\x01\x6e\x01\x72\x02\uffff\x01\x7a\x01\uffff\x01\x7a\x01\x65"+
			"\x02\x7a\x02\uffff\x01\x6f\x01\uffff\x01\x75\x01\x65\x04\x7a\x02\uffff"+
			"\x01\x7a\x02\uffff\x01\x6e\x01\x72\x01\x7a\x05\uffff\x01\x7a\x01\x65"+
			"\x02\uffff\x01\x7a\x01\uffff";
		private const string DFA4_acceptS =
			"\x16\uffff\x01\x2d\x01\x2e\x01\x2f\x01\x30\x03\uffff\x01\x37\x01\x3d"+
			"\x01\x3e\x01\x3f\x01\x40\x01\x41\x01\x42\x01\x43\x01\x44\x01\uffff\x01"+
			"\x47\x01\x48\x19\uffff\x01\x3c\x08\uffff\x01\x38\x01\x29\x01\x39\x01"+
			"\x2a\x01\x3a\x01\x2b\x01\x3b\x01\x2c\x01\x31\x01\x36\x01\x34\x01\x32"+
			"\x01\x35\x01\x33\x01\x45\x01\x46\x02\uffff\x01\x25\x01\x08\x01\x15\x04"+
			"\uffff\x01\x1a\x02\uffff\x01\x0b\x14\uffff\x01\x16\x01\x18\x05\uffff"+
			"\x01\x01\x12\uffff\x01\x20\x03\uffff\x01\x10\x0a\uffff\x01\x02\x01\uffff"+
			"\x01\x03\x01\x12\x05\uffff\x01\x23\x01\x06\x01\x07\x01\x09\x01\uffff"+
			"\x01\x26\x01\x0a\x01\x0e\x01\uffff\x01\x0f\x01\x0d\x08\uffff\x01\x24"+
			"\x01\x19\x01\uffff\x01\x1f\x04\uffff\x01\x17\x01\x0c\x01\uffff\x01\x27"+
			"\x06\uffff\x01\x11\x01\x04\x01\uffff\x01\x05\x01\x1e\x03\uffff\x01\x1c"+
			"\x01\x1b\x01\x28\x01\x1d\x01\x22\x02\uffff\x01\x21\x01\x14\x01\uffff"+
			"\x01\x13";
		private const string DFA4_specialS =
			"\u00e6\uffff}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x01\x1a\x01\x27\x02\uffff\x01\x16\x01\x17\x01\x28\x01\x20\x01\x21"+
				"\x01\x14\x01\x12\x01\x1f\x01\x13\x01\x1e\x01\x15\x0a\x26\x01\x1d\x01"+
				"\x22\x01\x1c\x01\x19\x01\x1b\x02\uffff\x1a\x25\x01\x23\x01\uffff\x01"+
				"\x24\x01\uffff\x01\x25\x01\uffff\x01\x0d\x01\x03\x01\x02\x01\x04\x01"+
				"\x08\x01\x0b\x02\x25\x01\x01\x02\x25\x01\x0a\x01\x10\x01\x11\x01\x0e"+
				"\x01\x0c\x01\x25\x01\x0f\x01\x05\x01\x07\x01\x25\x01\x06\x01\x09\x03"+
				"\x25\x01\uffff\x01\x18",
				"\x01\x2a\x07\uffff\x01\x29\x04\uffff\x01\x2b",
				"\x01\x2c\x09\uffff\x01\x2d",
				"\x01\x30\x09\uffff\x01\x2e\x09\uffff\x01\x2f",
				"\x01\x32\x09\uffff\x01\x31",
				"\x01\x34\x0e\uffff\x01\x33",
				"\x01\x35",
				"\x01\x38\x06\uffff\x01\x37\x09\uffff\x01\x39\x06\uffff\x01\x36",
				"\x01\x3a\x01\uffff\x01\x3c\x09\uffff\x01\x3b",
				"\x01\x3d",
				"\x01\x3e",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x01\x41\x0d"+
				"\x25\x01\x3f\x05\x25\x01\x40\x05\x25",
				"\x01\x44\x10\uffff\x01\x43",
				"\x01\x45",
				"\x01\x47\x03\uffff\x01\x46",
				"\x01\x48",
				"\x01\x49",
				"\x01\x4a",
				"\x01\x4b",
				"\x01\x4d",
				"\x01\x4f",
				"\x01\x51",
				"",
				"",
				"",
				"",
				"\x01\x53",
				"\x01\x55",
				"\x01\x57",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x5a\x01\uffff\x0a\x26",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x03\x25\x01"+
				"\x5c\x0f\x25\x01\x5b\x06\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\x60",
				"\x01\x61",
				"\x01\x63\x0a\uffff\x01\x62",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\x65",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x14\x25\x01"+
				"\x66\x05\x25",
				"\x01\x68",
				"\x01\x6a\x10\uffff\x01\x69",
				"\x01\x6b",
				"\x01\x6c",
				"\x01\x6d",
				"\x01\x6e",
				"\x01\x6f",
				"\x01\x70",
				"\x01\x71",
				"\x01\x72",
				"\x01\x73",
				"\x01\x75\x03\uffff\x01\x74",
				"\x01\x76",
				"\x01\x77",
				"\x01\x78",
				"\x01\x79",
				"",
				"\x01\x7a",
				"\x01\x7b",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\x7e",
				"\x01\x7f\x10\uffff\x01\u0080",
				"\x01\u0081",
				"\x01\u0082",
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
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u0084",
				"",
				"",
				"",
				"\x01\u0085",
				"\x01\u0086",
				"\x01\u0087",
				"\x01\u0088",
				"",
				"\x01\u0089",
				"\x01\u008a",
				"",
				"\x01\u008b",
				"\x01\u008c",
				"\x01\u008d",
				"\x01\u008e",
				"\x01\u008f",
				"\x01\u0090",
				"\x01\u0091",
				"\x01\u0092",
				"\x01\u0093",
				"\x01\u0094",
				"\x01\u0095",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u0097",
				"\x01\u0098",
				"\x01\u0099",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u009b",
				"\x01\u009c",
				"\x01\u009d",
				"\x01\u009e",
				"",
				"",
				"\x01\u009f",
				"\x01\u00a0",
				"\x01\u00a1",
				"\x01\u00a2",
				"\x01\u00a3",
				"",
				"\x01\u00a4",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u00a6",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u00a9",
				"\x01\u00aa",
				"\x01\u00ab",
				"\x01\u00ac",
				"\x01\u00ad",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u00b2",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"\x01\u00b6",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"\x01\u00b9",
				"\x01\u00ba",
				"\x01\u00bb",
				"\x01\u00bc",
				"\x01\u00bd",
				"\x01\u00be",
				"\x01\u00bf",
				"\x01\u00c0",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"\x01\u00c3",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u00c5",
				"\x01\u00c6",
				"\x01\u00c7",
				"\x01\u00c8",
				"",
				"",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"",
				"\x01\u00cb",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u00cd",
				"\x01\u00ce",
				"\x01\u00cf",
				"\x01\u00d0",
				"\x01\u00d1",
				"\x01\u00d2",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u00d5",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"",
				"\x01\u00d8",
				"",
				"\x01\u00d9",
				"\x01\u00da",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"",
				"\x01\u00e0",
				"\x01\u00e1",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"",
				"",
				"",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
				"\x01\u00e4",
				"",
				"",
				"\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a\x25",
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
}