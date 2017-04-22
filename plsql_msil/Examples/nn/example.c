
declare
	i int;
	img MNISTReader.MNISTImageList;
	test MNISTReader.MNISTImageList;
	net Net;
	positive int;
	vec1 Vector;
	vec2 Vector;
begin	
	
	net := Net(Layer(Matrix(table(table(double)), 10, 28*28), Vector(table(double), 10), Vector(table(double), 10), Vector(table(double), 10)));
	net.Init();
	
	img := MNISTReader.ReadImages("trainImages.idx3-ubyte", "trainLabels.idx1-ubyte", 30000);
	test := MNISTReader.ReadImages("testImages.idx3-ubyte", "testLabels.idx1-ubyte", 5000);
	
	vec1 := Vector(table(double), 10);
	
	for(i := 0; i < 10; i := i + 1)
		vec1.vec[i] := (double)0;
	end for;
	
	for(i := 0; i < 30000; i := i + 1)
		vec1.vec[img[i].ans] := (double)1;
		net.Train(img[i].img, vec1);
		vec1.vec[img[i].ans] := (double)0;
	end for;
	
	for(i := 0; i < 5000; i := i + 1)
		vec2 := net.Calc(img[i].img);
	
		if MatrixUtils.MaxIndex(vec2) == img[i].ans then
			positive := positive + 1;
		end if;
	end for;
	
	Con.WriteLine((double)positive / (double)5000);
	
	Con.Geti();
end;