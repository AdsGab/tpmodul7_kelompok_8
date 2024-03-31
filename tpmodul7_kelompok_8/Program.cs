using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

public class KuliahMahasiswa_1302220001
{
    public List<Matkul> courses { get; set; }

    public static void ReadJSON()
    {
        string text = File.ReadAllText("C:\\Users\\SWIFT\\Documents\\tpmod7\\tpmodul7_kelompok_8\\tpmodul7_kelompok_8\\tp7_2_1302220001.json");

        KuliahMahasiswa_1302220001 jadwal = JsonSerializer.Deserialize<KuliahMahasiswa_1302220001>(text);
        Console.WriteLine("Daftar mata kuliah yang diambil: ");
        int i = 1;
        foreach (Matkul j in jadwal.courses)
        {
            Console.WriteLine($"Mata Kuliah - {i} {j.kode} - {j.nama}");
            i++;
        }
    }
}

public class Matkul
{
    public string kode { get; set; }
    public string nama { get; set; }
}

public class Program
{
    public static void Main()
    {
        KuliahMahasiswa_1302220001.ReadJSON();
    }
}