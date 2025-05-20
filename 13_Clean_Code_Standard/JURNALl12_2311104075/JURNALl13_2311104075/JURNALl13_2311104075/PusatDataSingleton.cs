using System;
using System.Collections.Generic;

public sealed class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    public List<string> DataTersimpan { get; private set; }

    // Konstruktor private
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Method untuk mendapatkan instance Singleton
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    // Method tambah data
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    // Method hapus data berdasarkan index
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }

    // Method cetak semua data
    public void PrintSemuaData()
    {
        foreach (var data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    // Method get jumlah data
    public int GetSemuaData()
    {
        return DataTersimpan.Count;
    }
}