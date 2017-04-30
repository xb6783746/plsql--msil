create type Matrix as object (
	
	matrix array(double);
	i int;
	j int;
	
	member procedure Init();
	member function Get(i int, j int) return double;
	member procedure Set(i int, j int, val double);
	
);

create type body Matrix as object

	member procedure Init() is
		i int;
	begin
		for (i := 0; i < self.i * self.j; i := i + 1)
			self.matrix[i] := Utils.RandDouble();
		end for;
	end;
	
	member function Get(i int, j int) return double is
	
	begin
		return self.matrix[self.j*i + j];
	end;
	
	
	member procedure Set(i int, j int, val double) is
	
	begin
		self.matrix[self.j*i + j] := val;
	end;
end;

create package MatrixUtils as
		
	
	function Sum(vec1 array(double), vec2 array(double)) return array(double);
	function Minus(vec1 array(double), vec2 array(double)) return array(double);
	function Mul(m Matrix, vec array(double)) return array(double);
	function Mul(vec1 array(double), vec2 array(double)) return array(double);
	function Mul(vec1 array(double), d double) return array(double);
	
	function Softmax(arr array(double)) return array(double);
	function DSoftmax(arr array(double)) return array(double);
	
	function MaxIndex(arr array(double)) return int;
	
	procedure Init(arr array(double));
	
end;

create package body MatrixUtils is

	function Sum(vec1 array(double), vec2 array(double)) return array(double) is
		res array(double);
		i int;
	begin
		res := array(double, vec1.Count());

		for (i := 0; i < vec1.Count(); i := i + 1)
		
			res[i] := vec1[i] + vec2[i];
		end for;

		return res;
	end;
	
	
	function Minus(vec1 array(double), vec2 array(double)) return array(double) is
		res array(double);
		i int;
	begin
		res := array(double, vec1.Count());

		for (i := 0; i < vec1.Count(); i := i + 1)
		
			res[i] := vec1[i] - vec2[i];
		end for;

		return res;
	end;
	
	
	function Mul(m Matrix, vec array(double)) return array(double) is
		res array(double);
		i int;
		j int;
	begin
		res := array(double, m.i);
		
		for(i := 0; i < m.i; i := i + 1)
			
			for(j := 0; j < m.j; j := j + 1)
				res[i] := res[i] + m.Get(i,j) * vec[j];
				
			end for;
		end for;

		return res;
	end;
	function Mul(vec1 array(double), vec2 array(double)) return array(double) is
		res array(double);
		i int;
	begin
		res := array(double, vec1.Count());
		
		for (i := 0; i < vec1.Count(); i := i + 1)
		
			res[i] := vec1[i] * vec2[i];
		end for;

		return res;
	end;
	
	
	function Mul(vec1 array(double), d double) return array(double) is 
		res array(double);
		i int;
	begin
		res := array(double, vec1.Count());
		
		for (i := 0; i < vec1.Count(); i := i + 1)
		
			res[i] := vec1[i] * d;
		end for;

		return res;
	
	end;
	
	function Softmax(arr array(double)) return array(double) is
		res array(double);
		i int;
		sum double;
	begin
		res := array(double, arr.Count());

		sum := (double)0;

		for(i := 0; i < arr.Count(); i := i + 1)
		
			sum := sum + Math.Exp(arr[i]);
		end for;

		for(i := 0; i < arr.Count(); i := i + 1)
		
			res[i] := Math.Exp(arr[i]) / sum;
		end for;

		return res;
	
	end;
	
	
	function DSoftmax(arr array(double)) return array(double) is
		res array(double);
		i int;
	begin
		res := MatrixUtils.Softmax(arr);
		
		for(i := 0; i < arr.Count(); i := i + 1)
		
			res[i] := res[i] * (1 - res[i]);
		end for;

		return res;
	
	end;
	
	function MaxIndex(arr array(double)) return int is
		max double;
		i int;
		ind int;
	begin
	
		max := arr[0];
		ind := 0;
		
		for(i := 1; i < arr.Count(); i := i + 1)
		
			if max < arr[i] then
				max := arr[i];
				ind := i;
			end if;
		end for;
	
		return ind;
	end;
	
	procedure Init(arr array(double)) is
		i int;
	begin
		for( i := 0; i < arr.Count(); i := i + 1)
			
			arr[i] := Utils.RandDouble();
		end for;
	end;
end;