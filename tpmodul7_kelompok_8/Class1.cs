using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

public class kelas
{
    public string code { get; set;}
    public string name { get; set;}
}
public class KuliahMahasiswa1302220053
{
    public List<kelas> courses { get; set;}


    public static void ReadJson()
    {
        string isiJson2 = File.ReadAllText("D:\\C#\\tpmodul7_kelompok_8\\tp7_2_1302220053.json");

        KuliahMahasiswa1302220053 jadwal = JsonSerializer.Deserialize<KuliahMahasiswa1302220053>(isiJson2);
        Console.WriteLine("Daftar mata kuliah yang diambil: ");
        int i = 1;    
        foreach (kelas j in jadwal.courses) {

            Console.WriteLine("MK " + i +" "+ j.code + " - " + j.name);
            i++;
        }

    }
}
