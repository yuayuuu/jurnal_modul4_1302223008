// See https://aka.ms/new-console-template for more information
// asprak MKR

using System.Runtime.CompilerServices;

public class kodebuah
{
    Dictionary<string, string> kodeBuah = new Dictionary<string, string>()
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"},
    };
    public string getkodeBuah(string buah)
    {
        if (kodeBuah.ContainsKey(buah))
        {
            return kodeBuah[buah];
        } 
        else
        {
            return "Buah tidak ditemukan";
        }

    }
}

public class posisiKarakterGame
{
    public enum posisiState{
        terbang,
        jongkok,
        berdiri
    }

    public enum tombol
    {
        tombolW,
        tombolX
    }
    public class perubahanPosisi
    {
        public posisiState
        awal;
        public posisiState
        akhir;
        public tombol
        Tombol;
        
        public perubahanPosisi(posisiState awal, posisiState akhir, tombol Tombol)
        {
            this.awal = awal;
            this.akhir = akhir;
            this.Tombol = Tombol;
        }
        perubahanPosisi[] listperubahanPosisi = {
            new perubahanPosisi(posisiState.terbang, posisiState.jongkok, tombol.tombolX),
            new perubahanPosisi(posisiState.berdiri, posisiState.terbang, tombol.tombolW)

        };
        
    }

   
}


class program
{
    static void Main(string[] args)
    {
        kodebuah kodebuah = new kodebuah();
        string buah;
        string kodeBuah;

        buah = "Apel";
        kodeBuah = kodebuah.getkodeBuah(buah);
        Console.WriteLine($"Buah {buah} kode buah {kodebuah}");


    }
}

