using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa1302220053
{
    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJson()
    {
        string isiJson1 = File.ReadAllText("D:\\C#\\tpmodul7_kelompok_8\\tp7_1_1302220053.json");

        DataMahasiswa1302220053 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220053>(isiJson1);

        Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
    }
}

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

class Program
{
    static void Main(string[] args)
    {

        DataMahasiswa1302220053.ReadJson();
        KuliahMahasiswa1302220053.ReadJson();
    }
}
