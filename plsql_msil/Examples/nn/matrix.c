create type Matrix as object (
	
	matrix table(table(double));
	i int;
	j int;
	
	member procedure Init();
	
);

create type body Matrix as object

	member procedure Init() is
		i int;
		j int;
	begin
		for (i := 0; i < self.i; i := i + 1)
			self.matrix[i] := table(double);
		
			for (j := 0; j < self.j; j := j + 1)
				self.matrix[i][j] := Utils.RandDouble();
			end for;
		end for;
	end;
end;

create type Vector as object (
	
	vec table(double);
	len int;
	
	member procedure Init();
	
);

create type body Vector as object

	member procedure Init() is
		i int;
	begin
		for (i := 0; i < self.len; i := i + 1)
			self.vec[i] := Utils.RandDouble();
		end for;
	end;
end;

create package MatrixUtils as
		
	function Sum(vec1 Vector, vec2 Vector) return Vector;
	function Minus(vec1 Vector, vec2 Vector) return Vector;
	function Mul(m Matrix, vec Vector) return Vector;
	function Mul(vec1 Vector, vec2 Vector) return Vector;
	function Mul(vec1 Vector, d double) return Vector;
	
	function Softmax(arr Vector) return Vector;
	function DSoftmax(arr Vector) return Vector;
	
	function MaxIndex(arr Vector) return int;
	
end;

create package body MatrixUtils is

	function Sum(vec1 Vector, vec2 Vector) return Vector is
		res Vector;
		i int;
	begin
		res := Vector(table(double), vec1.len);

		for (i := 0; i < vec1.len; i := i + 1)
		
			res.vec[i] := vec1.vec[i] + vec2.vec[i];
		end for;

		return res;
	end;
	
	
	function Minus(vec1 Vector, vec2 Vector) return Vector is
		res Vector;
		i int;
	begin
		res := Vector(table(double), vec1.len);

		for (i := 0; i < vec1.len; i := i + 1)
		
			res.vec[i] := vec1.vec[i] - vec2.vec[i];
		end for;

		return res;
	end;
	
	
	function Mul(m Matrix, vec Vector) return Vector is
		res Vector;
		i int;
		j int;
	begin
		res := Vector(table(double), m.i);
		res.Init();
		
		for(i := 0; i < m.i; i := i + 1)
			
			for(j := 0; j < m.j; j := j + 1)
				res.vec[i] := res.vec[i] + m.matrix[i][j] * vec.vec[j];
				
			end for;
		end for;

		return res;
	end;
	function Mul(vec1 Vector, vec2 Vector) return Vector is
		res Vector;
		i int;
	begin
		res := Vector(table(double), vec1.len);
		res.Init();
		
		for (i := 0; i < vec1.len; i := i + 1)
		
			res.vec[i] := vec1.vec[i] * vec2.vec[i];
		end for;

		return res;
	end;
	
	
	function Mul(vec1 Vector, d double) return Vector is 
		res Vector;
		i int;
	begin
		res := Vector(table(double), vec1.len);
		
		for (i := 0; i < vec1.len; i := i + 1)
		
			res.vec[i] := vec1.vec[i] * d;
		end for;

		return res;
	
	end;
	
	function Softmax(arr Vector) return Vector is
		res Vector;
		i int;
		sum double;
	begin
		res := Vector(table(double), arr.len);

		sum := (double)0;

		for(i := 0; i < arr.len; i := i + 1)
		
			sum := sum + Math.Exp(arr.vec[i]);
		end for;

		for(i := 0; i < arr.len; i := i + 1)
		
			res.vec[i] := Math.Exp(arr.vec[i]) / sum;
		end for;

		return res;
	
	end;
	
	
	function DSoftmax(arr Vector) return Vector is
		res Vector;
		i int;
	begin
		res := MatrixUtils.Softmax(arr);
		res.Init();
		
		for(i := 0; i < arr.len; i := i + 1)
		
			res.vec[i] := res.vec[i] * (1 - res.vec[i]);
		end for;

		return res;
	
	end;
	
	function MaxIndex(arr Vector) return int is
		max double;
		i int;
		ind int;
	begin
	
		max := arr.vec[0];
		ind := 0;
		
		for(i := 1; i < arr.len; i := i + 1)
		
			if max < arr.vec[i] then
				max := arr.vec[i];
				ind := i;
			end if;
		end for;
	
		return ind;
	end;
end;