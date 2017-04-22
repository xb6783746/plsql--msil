create type Net as object (
	
	layer Layer;
	
	member procedure Init();
	
	member function Calc(input Vector) return Vector;
	member function Train(input Vector, ans Vector) return Vector;
);

create type body Net as object

	member procedure Init() is
	
	begin
		self.layer.Init();
	end;
	
	member function Calc(input Vector) return Vector is
		inp Vector;
	begin
		inp := self.layer.Calc(input);
		
		return inp;
	
	end;
	
	
	member function Train(input Vector, ans Vector) return Vector is
	
		res Vector;
		err Vector;
		tmp Vector;
	begin
		res := self.Calc(input);

		err := MatrixUtils.DSoftmax(self.layer.inputM);

		tmp := MatrixUtils.Minus(ans, res);

		err := MatrixUtils.Mul(MatrixUtils.Mul(err, tmp), 0.1);

		self.layer.ChangeWeights(err);

		return res;
	
	end;
	
	
end;