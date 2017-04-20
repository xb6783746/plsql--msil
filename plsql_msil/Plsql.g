grammar Plsql;

options
{
	language=CSharp3;
	output=AST;
	backtrack=true;
}

tokens
{
	Program;

	EntryPoint;
	DeclareBlock;
	VarList;
	VarItem;
	ClassDecl;
	ClassDef;
	ClassItems;
	PackageDecl;
	PackageDef;
	CommandBlock;
	TypeName;
	VarDef;
	MethodDecl;
	MethodDef;
	ObjectMethodDecl;
	ObjectMethodDef;
	ObjectItems;
	Index;
	CodeBlock;
	MemberCall;
	MethodCall;
	Cast;
	Expression;
	ExpressionList;
	StringLiteral;
	Table;
	Record;
	CreateInstance;
	Void;

	BYTE = 'byte';
	INT = 'int';
	CHAR = 'char';
	BOOL = 'bool';
	DOUBLE = 'double';
	STRING = 'string';
	VOID = 'void';

	TYPE = 'type';

	IF = 'if';
	THEN = 'then';
	ELSE = 'else';
	DO = 'do';
	WHILE = 'while';
	LOOP = 'loop';
	EXIT = 'exit';
	WHEN = 'when';
	FOR = 'for';

	CREATE = 'create';
	BODY = 'body';

	PROCEDURE = 'procedure';
	FUNCTION = 'function';

	IS = 'is';
	AS = 'as';
	TABLE = 'table';
	OF = 'of';
	INDEX = 'index';
	BY = 'by';
	RECORD = 'record';
	OBJECT = 'object';
	MEMBER = 'member';
	STATIC = 'static';
	BEGIN = 'begin';
	END = 'end';
	PACKAGE = 'package';
	DECLARE = 'declare';

	SELF = 'self';
	NULL = 'null';

	IN = 'in';

	TRUE = 'true';
	FALSE = 'false';

	RETURN = 'return';

	PLUS = '+';
	MINUS = '-';
	MULT = '*';
	DIVIDE = '/';
	MOD = '%';

	AND = '&&';
	OR = '||';
	EQUAL = '==';
	NEQUAL = '!=';
	MORE = '>';
	LESS = '<';
	MOREEQ = '>=';
	LESSEQ = '<=';
	NOT = '!';

	ASSIGN = ':=';
	PLUSASSIGN = '+=';
	MINUSASSIGN = '-=';
	MULTASSIGN = '*=';
	DIVASSIGN = '/=';
	
}

@parser::header
{
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.AstNodes.CommandNodes;
using plsql_msil.AstNodes.MathNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.AstNodes;
using plsql_msil.AstNodes.PackageNodes;
using plsql_msil.AstNodes.ClassNodes;
}

@parser::namespace { plsql_msil }
@lexer::namespace  { plsql_msil }

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

INTEGER 	
	: ('0'..'9')+
	;

REAL 
	: INTEGER '.' INTEGER
	;

float_
	: REAL 'f'
	-> REAL<FloatNode>
	;

bool_
	: TRUE -> TRUE<BoolNode>
	| FALSE -> FALSE<BoolNode>
	;

QUOTED_STRING
	: '"' ( ~('\n'|'\r'|'"') )* '"'
    ;

QUOTED_CHAR
	: '\'' ( ~('\n'|'\r'|'\'') ) '\''
    ;

string_
	: QUOTED_STRING<StringNode>
	;

char_
	: QUOTED_CHAR<CharNode>
	;

number
	: INTEGER -> INTEGER<IntegerNode>
	| REAL -> REAL<RealNode>
	| float_
	;

type
	:	INT -> INT<TypeNode>
	|	BYTE -> BYTE<TypeNode>
	|	CHAR -> CHAR<TypeNode>
	|	DOUBLE -> DOUBLE<TypeNode>
	|	STRING -> STRING<TypeNode>
	|   BOOL -> BOOL<TypeNode>
	|   ID '.' ID
	->  ^(TypeName<TypeNode> ID ID)
	|	TABLE '(' type ')'
	->  ^(TypeName<TableTypeNode> type)
	|   ID -> ID<TypeNode>
	;

public program
	: objOrPack* entryPoint
	-> ^(Program objOrPack* entryPoint)
	;

objOrPack
	: object_ 
	| package_
	;

isOrAs
	: IS 
	| AS
	;

//--------------Operators--------------

equalityOperator
	: EQUAL -> EQUAL<EqualNode>
	| NEQUAL -> NEQUAL<NotEqualNode>
	;

ineqOperator
	: MORE -> MORE<GreaterNode>
	| LESS -> LESS<LessNode>
	| MOREEQ -> MOREEQ<GreaterOrEqualNode>
	| LESSEQ -> LESSEQ<LessOrEqualNode>
	;

addOperator
	: PLUS -> PLUS<PlusNode>
	| MINUS -> MINUS<MinusNode>
	;

multOperator
	: MULT -> MULT<MultNode>
	| DIVIDE -> DIVIDE<DivNode>
	| MOD -> MOD<ModNode>
	;

assignOperator
	:	ASSIGN
	|	PLUSASSIGN
	|	MINUSASSIGN
	|	MULTASSIGN
	|	DIVASSIGN
	;

unaryOperator
	: MINUS -> MINUS<MinusNode>
	| NOT -> NOT<NotNode>
	;


//--------------Vars and methods--------------

varDef
	: ID type
	-> ^(VarDef<VarDefNode> ID type )
	;

varList
	: ( varDef ( ',' varDef)* )?
	-> ^(VarList varDef*)
	;

methodDecl
	: procDecl
	| funcDecl
	;

methodModifier
	: MEMBER
	| STATIC
	| -> STATIC
	;

procDecl
	: methodModifier PROCEDURE ID '(' varList ')'
	-> ^(MethodDecl<MethodDeclNode> ID varList Void<VoidNode> methodModifier)
	;

funcDecl
	: methodModifier FUNCTION ID '(' varList ')' RETURN type
	-> ^(MethodDecl<MethodDeclNode> ID varList type methodModifier)
	;

methodDef
	: methodDecl IS declareBlock BEGIN codeBlock END
	-> ^(MethodDef<MethodDefNode> declareBlock methodDecl codeBlock)
	;

typeDecl
	: TYPE ID IS TABLE OF type
	-> ^(Table<TableNode> ID type)
	| TYPE ID IS RECORD '(' varList ')'
	-> ^(Record<RecordNode> ID varList)
	;

//--------------Classes--------------

object_
	: objectDecl
	| objectBody
	;

objectDecl
	: CREATE TYPE ID isOrAs OBJECT '(' objectDeclItem+ ')' ';'
	-> ^(ClassDecl<ClassDeclNode> ID objectDeclItem+)
	;

objectBody
	: CREATE TYPE BODY ID isOrAs OBJECT ( methodDef ';' )+ END ';'
	-> ^(ClassDef<ClassDefNode> ID methodDef+)
	;

objectDeclItem
	: varDef ';'!
	| methodDecl ';'!
	;


//--------------Packages--------------

package_
	: packageDecl
	| packageDef
	;

packageDecl
	: CREATE PACKAGE ID isOrAs packageDeclItem+ END ';'
	-> ^(PackageDecl<PackageDeclNode> ID packageDeclItem+ )
	;

packageDef
	: CREATE PACKAGE BODY ID isOrAs packageBodyItem+ END ';'
	-> ^(PackageDef<PackageDefNode> ID packageBodyItem+)
	;

packageDeclItem
	: varDef ';'!
	| typeDecl ';'!
	| methodDecl ';'!
	;

packageBodyItem
	: methodDef ';'!
	;


//--------------Main block--------------

entryPoint
	: DECLARE declareBlock BEGIN codeBlock END ';'
	-> ^(EntryPoint<EntryPointNode> declareBlock codeBlock)
	;


declareBlock
	: declareItem*
	-> ^(DeclareBlock<DeclareBlockNode> declareItem*)
	;

declareItem
	: varDef ';'!
	;

codeBlock
	: ( command ';')*
	-> ^(CodeBlock<CodeBlockNode> command*)
	;

command
	: assign
	| if_
	| cycle
	| expression
	| RETURN<ReturnNode>^ expression
	;

assign
	: expression ASSIGN<AssignNode>^ ( NULL<TypeNode> | expression)
	;

if_	: IF expression THEN codeBlock (ELSE codeBlock)? END IF
	-> ^(IF<IfNode> expression codeBlock codeBlock?)
	;  

cycle	
	: WHILE expression LOOP codeBlock END LOOP
	-> ^(WHILE<WhileNode> expression codeBlock)
	| LOOP codeBlock EXIT WHEN expression END LOOP
	-> ^(DO<DoWhileNode> expression codeBlock)
	|	FOR '(' assignOrExpression ';' expression ';' assignOrExpression ')' codeBlock END FOR
	-> ^(FOR<ForNode> assignOrExpression expression assignOrExpression codeBlock)
	;

assignOrExpression
	: assign
	| expression
	;

expressionList
	: ( expr_ ( ',' expr_)* )?
	-> ^(ExpressionList expr_*)
	;


//--------------Expression--------------

expression
	: expr_
	-> ^(Expression<ExpressionNode> expr_)
	;

expr_
	: logicOr+
	;

logicOr
	: logicAnd ( OR<OrNode>^ logicAnd)*
	;

logicAnd
	: equality ( AND<AndNode>^ equality)*
	;

equality
	: inequality ( equalityOperator^ inequality)*
	;

inequality
	: add ( ineqOperator^ add)*
	;

add	:   mult ( addOperator^ mult)*
    ;

mult:   cast ( multOperator^ cast)*
	;
	
cast: '(' type ')' unary
	-> ^(Cast<CastNode> unary type)
	| unary
	;

unary
	: (unaryOperator^ unary) 
	| postfix
	;
	
	

postfix
	: quant tmp^*
	;

tmp : index
	| methodCall
	| memberCall
	;

index
	: '[' expression ']'
	-> ^(Index<IndexNode> expression)
	;

memberCall
	: '.' ID
	-> ^(MemberCall<MemberCallNode> ID)
	;

expressionOrEmpty
	: expression
	| -> Expression
	;

methodCall
	: '.' ID '(' expressionList ')'
	-> ^(MethodCall<MethodCallNode> ID expressionList)
	;

createInstance
	: ID '(' expressionList ')'
	-> ^(CreateInstance<CreateInstanceNode> ID expressionList)
	| TABLE '(' type ')'
	-> ^(CreateInstance<CreateTableNode> type)
	;

quant
	:	number
	|   bool_
	|   string_
	|	char_
	|   createInstance
	|   '('! expr_ ')'!
	|   var
	|   SELF<SelfNode>
	;

var	: ID
	-> ^(ID<VarNode>)
	;

