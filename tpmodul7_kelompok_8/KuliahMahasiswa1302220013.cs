using System;
using System.IO;
using Newtonsoft.Json;

public class KuliahMahasiswa
{
    private string _fileName = "tp7_2_nim.json";

    public void ReadJSON()
    {
        string jsonContent = File.ReadAllText(_fileName);
        dynamic jsonObject = JsonConvert.DeserializeObject(jsonContent);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int count = 1;
        foreach (var course in jsonObject.courses)
        {
            Console.WriteLine($"MK {count} {course.code} - {course.name}");
            count++;
        }
    }
}

class KuliahMahasiswa1302220013
{
    static void Main(string[] args)
    {
        KuliahMahasiswa kuliahMahasiswa = new KuliahMahasiswa();
        kuliahMahasiswa.ReadJSON();
    }
}
