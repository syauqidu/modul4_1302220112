public class KodeBuah
{
    public string[] namaBuah =
    {
        "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry", "Ceri", "Kelapa",
        "Jagung", "Kurma", "Durian", "Anggur", "Melon", "Semangka"
    };
    public string[] kodeBuah =
    {
        "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00",
        "K00", "L00", "M00", "N00", "O00"
    };
    public string getKodeBuah(int i)
    {
        return kodeBuah[i];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();
        Console.WriteLine("Nama Buah dan Kode Buah");
        for (int i = 0; i < kodeBuah.namaBuah.Length; i++)
        {
            Console.WriteLine(kodeBuah.namaBuah[i] + "   " + kodeBuah.getKodeBuah(i));
        }
    }
}