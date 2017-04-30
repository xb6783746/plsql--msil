
declare
	i int;
	j int;
	img MNISTReader.MNISTImageList;
	test MNISTReader.MNISTImageList;
	net Net;
	positive int;
	vec1 array(double);
	vec2 array(double);
	vec3 array(double);
begin
	
	net := Net(
				Layer(
					Matrix(array(double, 10*28*28), 10, 28*28), 
					array(double, 10), 
					array(double, 10), 
					array(double, 10)));
	net.Init();
	
	img := MNISTReader.ReadImages("trainImages.idx3-ubyte", "trainLabels.idx1-ubyte", 30000);
	test := MNISTReader.ReadImages("testImages.idx3-ubyte", "testLabels.idx1-ubyte", 5000);
	
	vec1 := array(double, 10);
	
	
	for(i := 0; i < 30000; i := i + 1)
		j := img[i].ans;
	
		vec1[j] := (double)1;
		net.Train(img[i].img, vec1);
		vec1[j] := (double)0;
	end for;
	
	
	for(i := 0; i < 5000; i := i + 1)
		vec2 := net.Calc(test[i].img);
	
		if MatrixUtils.MaxIndex(vec2) == test[i].ans then
			positive := positive + 1;
		end if;
	end for;
	
	
	Con.WriteLine((double)positive / (double)5000);
	
	Con.Geti();
end;