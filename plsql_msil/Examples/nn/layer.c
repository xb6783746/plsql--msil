create type Layer as object (
	
	matrix Matrix;
	bias array(double);
	
	input array(double);
	inputM array(double);
	
	member procedure Init();
	member function Calc(inpt array(double)) return array(double);
	member procedure ChangeWeights(arr array(double));
	
);

create type body Layer as object

	member procedure Init() is
	
	begin
		self.matrix.Init();
		MatrixUtils.Init(self.bias);
	end;
	
	member function Calc(inpt array(double)) return array(double) is
	
	begin
		self.input := inpt;
		self.inputM := MatrixUtils.Sum(MatrixUtils.Mul(self.matrix, inpt), self.bias);

		return MatrixUtils.Softmax(self.inputM);
	
	end;
	
	member procedure ChangeWeights(arr array(double)) is
		i int;
		j int;
		delta double;
	begin
		for (i := 0; i < self.matrix.i; i := i + 1)
		
			for(j := 0; j < self.matrix.j; j := j + 1)
			
				delta := self.input[j] * arr[i];

				self.matrix.Set(i, j, self.matrix.Get(i, j) + delta);

			end for;

			self.bias.Set(i, self.bias.Get(i) + arr.Get(i)));
		end for;
	
	end;
end;