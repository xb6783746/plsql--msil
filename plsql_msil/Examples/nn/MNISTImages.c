create type MNISTImage as object (
	
	img array(double);
	ans int;
	
);

create type body MNISTImage as object

end;

create package MNISTReader as

	type MNISTImageList is table of MNISTImage;
	function ReadImages ( path string, labelPath string, count int) return MNISTReader.MNISTImageList;
	function ReadImage ( reader BinaryReader, labelReader BinaryReader) return MNISTImage;
end;

create package body MNISTReader is

	function ReadImages ( path string, labelPath string, count int) return MNISTReader.MNISTImageList is
		reader BinaryReader;
		labelReader BinaryReader;
		imgList MNISTReader.MNISTImageList;	
		tmp int;
		j int;
	begin
	
		imgList := table(MNISTImage);
		reader := BinaryReader(path);
		labelReader := BinaryReader(labelPath);
		
		tmp := reader.ReadInt();
        tmp := reader.ReadInt();
        tmp := reader.ReadInt();
        tmp := reader.ReadInt();

        tmp := labelReader.ReadInt();
        tmp := labelReader.ReadInt();

		for (tmp := 0; tmp < count; tmp := tmp + 1)
			imgList.Add(MNISTReader.ReadImage(reader, labelReader));
				
		end for;
		
		return imgList;
	end;
	
	function ReadImage ( reader BinaryReader, labelReader BinaryReader) return MNISTImage
	
		img MNISTImage;
		j int;
	begin

		img := MNISTImage(array(double, 28*28), 0);
		
		for(j := 0; j < 28*28; j := j + 1)
				
			img.img[j] := (double)(reader.ReadByte()) / (double) 255;
			
		end for;
			
		img.ans := (int)(labelReader.ReadByte());
		
		return img;
	end;
end;