using System;

public enum StatePosisi { Berdiri, Terbang, Jongkok, Tengkurap };
public class PosisiKarakterGame
{
	public PosisiKarakterGame()
	{

	}
	public void gantiPosisi(ref StatePosisi posisi, char tombol)
	{
		if (tombol == 's' || tombol == 'S')
		{
			Console.WriteLine("Tombol arah bawah ditekan");
		} 
		if (tombol == 'w' || tombol == 'W')
		{
			Console.WriteLine("Tombol arah atas ditekan");
		}
		switch (posisi)
		{
			case StatePosisi.Berdiri:
				if (tombol == 'w' || tombol == 'W')
				{
					posisi = StatePosisi.Terbang;
				} else if (tombol == 's' || tombol == 'S')
				{
					posisi = StatePosisi.Jongkok;
				}
				break;
			case StatePosisi.Terbang:
				if (tombol == 'x' || tombol == 'X')
				{
					posisi = StatePosisi.Jongkok;
				} else if (tombol == 's' || tombol== 'S')
				{
					posisi = StatePosisi.Berdiri;
				}
				break;
			case StatePosisi.Jongkok:
				if (tombol == 's' || tombol == 'S')
				{
					posisi = StatePosisi.Tengkurap;
				} else if (tombol == 'w' || tombol == 'W')
				{
					posisi = StatePosisi.Berdiri;
				}
				break;
			case StatePosisi.Tengkurap:
				if (tombol == 'w' || tombol == 'W')
				{
					posisi = StatePosisi.Jongkok;
				}
				break;
		}
	}
}
public class Program2
{
	public static void Main(string[] args)
	{
		StatePosisi currentPosition = StatePosisi.Berdiri;
		PosisiKarakterGame posKarakter = new PosisiKarakterGame();
        Console.WriteLine("Kondisi Sekarang " + currentPosition);
        Console.Write("Masukkan Tombol: ");
		char tombol = char.Parse(Console.ReadLine());
		posKarakter.gantiPosisi(ref currentPosition, tombol);
		Console.WriteLine("");
		while (tombol != 'b')
		{
            Console.WriteLine("Kondisi Sekarang " + currentPosition);
            Console.Write("Masukkan Tombol: ");
            tombol = char.Parse(Console.ReadLine());
            posKarakter.gantiPosisi(ref currentPosition, tombol);
            Console.WriteLine("");
        }
	}
}
