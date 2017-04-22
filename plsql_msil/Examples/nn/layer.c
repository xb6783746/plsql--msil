create type Layer as object (
	
	matrix Matrix;
	bias Vector;
	
	input Vector;
	inputM Vector;
	
	member procedure Init();
	member function Calc(inpt Vector) return Vector;
	member procedure ChangeWeights(arr Vector);
	
);

create type body Layer as object

	member procedure Init() is
	
	begin
		self.matrix.Init();
		self.bias.Init();
	end;
	
	member function Calc(inpt Vector) return Vector is
	
	begin
		self.input := inpt;
		self.inputM := MatrixUtils.Sum(MatrixUtils.Mul(self.matrix, inpt), self.bias);

		return MatrixUtils.Softmax(self.inputM);
	
	end;
	
	member procedure ChangeWeights(arr Vector) is
		i int;
		j int;
		delta double;
	begin
		for (i := 0; i < self.matrix.i; i := i + 1)
		
			for(j := 0; j < self.matrix.j; j := j + 1)
			
				delta := self.input.vec[j] * arr.vec[i];

				self.matrix.matrix[i][j] := self.matrix.matrix[i][j] + delta;

			end for;

			self.bias.vec[i] := self.bias.vec[i] + arr.vec[i];
		end for;
	
	end;
end;