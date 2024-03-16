﻿// See https://aka.ms/new-console-template for more information
// asprak MKR

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