
create type A as object (
	a int;
	b char;
	member procedure Print ( a int);
	member procedure IncA ();
	member procedure Test ();
);

create type body A as object

	member procedure Print ( a int) is
	begin
		Con.WriteLine(a);
	end;
	
	member procedure IncA () is
	begin
		self.a := self.a + 1;
	end;
	
	member procedure Test () is
	begin
		Con.WriteLine("from A.Test()");
	end;
end;

create package B as

	a int;
	type IntArr is table of int;
	type IntRecord is record (a int, b int);
	function Max (a int, b int) return int;
end;

create package body B is

	function Max (a int, b int) return int is
		res int;
	begin
		if a < b then
			res := b;
		else 
			res := a;
		end if;
		
		return res;
	end;
end;

declare
	a int;
	b bool;
	c char;
	obj A;
	rec B.IntRecord;
	arr B.IntArr;
begin

	obj := A(5, 'c');	
	
	Con.WriteLine(obj.a);
	obj.IncA();
	Con.WriteLine(obj.a);
	
	obj.Print(8);
	
	obj.Test();
	
	rec.a := 7;	
	Con.WriteLine(rec.a);
	
	arr[5] := 9;
	Con.WriteLine(arr[5]);
	
	Con.WriteLine(B.Max(3728, 5342));
	
	Con.Geti();
end;