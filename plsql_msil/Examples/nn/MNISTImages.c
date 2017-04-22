create package MNISTReader as

	type MNISTImage is record ( img Vector, ans int)
	type MNISTImageList is table of MNISTReader.MNISTImage;
	function ReadImages ( path string, labelPath string, count int) return MNISTReader.MNISTImageList;
	function ReadImage ( reader BinaryReader, labelReader BinaryReader) return MNISTReader.MNISTImage;
end;

create package body MNISTReader is

	function ReadImages ( path string, labelPath string, count int) return MNISTReader.MNISTImageList is
		reader BinaryReader;
		labelReader BinaryReader;
		imgList MNISTReader.MNISTImageList;	
		tmp int;
		j int;
	begin
		reader := BinaryReader(path);
		labelReader := BinaryReader(labelPath);
		
		tmp := reader.ReadInt();
        tmp := reader.ReadInt();
        tmp := reader.ReadInt();
        tmp := reader.ReadInt();

        tmp := labelReader.ReadInt();
        tmp := labelReader.ReadInt();

		for (tmp := 0; tmp < count; tmp := tmp + 1)
			imgList[tmp] := MNISTReader.ReadImage(reader, labelReader);
				
		end for;
		
		return imgList;
	end;
	
	function ReadImage ( reader BinaryReader, labelReader BinaryReader) return MNISTReader.MNISTImage
	
		img MNISTReader.MNISTImage;
		j int;
	begin
	
		img.img := Vector(table(double), 28*28);
		
		for(j := 0; j < 28*28; j := j + 1)
				
			img.img.vec[j] := (double)(reader.ReadByte()) / (double) 255;
			
		end for;
			
		img.ans := (int)(labelReader.ReadByte());
		
		return img;
	end;
end;