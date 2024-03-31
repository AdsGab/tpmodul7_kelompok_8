using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

public class DataMahasiswa_1302220001
{
    public Nama nama { get; set; }
    public long nim {  get; set; }
    public string fakultas {  get; set; }

    public static void ReadJSON()
    {
        string text = File.ReadAllText("C:\\Users\\SWIFT\\Documents\\tpmod7\\tpmodul7_kelompok_8\\tpmodul7_kelompok_8\\tp7_1_1302220001.json");
        DataMahasiswa_1302220001 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302220001>(text);

        Console.WriteLine($"Nama: {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
        Console.WriteLine($"NIM: {mahasiswa.nim}");
        Console.WriteLine($"Fakultas: {mahasiswa.fakultas}");
    }
}

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class Program
{
    public static void Main()
    {
        DataMahasiswa_1302220001.ReadJSON();
    }
}