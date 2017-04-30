create type Net as object (
	
	layer Layer;
	
	member procedure Init();
	
	member function Calc(input array(double)) return array(double);
	member function Train(input array(double), ans array(double)) return array(double);
);

create type body Net as object

	member procedure Init() is
	
	begin
		self.layer.Init();
	end;
	
	member function Calc(input array(double)) return array(double) is
		inp array(double);
	begin
		inp := self.layer.Calc(input);
		
		return inp;
	
	end;
	
	
	member function Train(input array(double), ans array(double)) return array(double) is
	
		res array(double);
		err array(double);
		tmp array(double);
	begin
		res := self.Calc(input);

		err := MatrixUtils.DSoftmax(self.layer.inputM);

		tmp := MatrixUtils.Minus(ans, res);

		err := MatrixUtils.Mul(MatrixUtils.Mul(err, tmp), 0.1);

		self.layer.ChangeWeights(err);

		return res;
	
	end;
	
	
end;