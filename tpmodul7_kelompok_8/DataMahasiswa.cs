using System;
using System.IO;
using Newtonsoft.Json;
public class Mahasiswa
{
    public Nama Nama { get; set; }
    public int Nim { get; set; }
    public string Fakultas { get; set; }

    public static Mahasiswa ReadJSON(string filePath)
    {
        if (File.Exists(filePath))
        {
            try
            {
                // Membaca isi file JSON
                string jsonText = File.ReadAllText(filePath);

                // Deserialisasi JSON menjadi objek Mahasiswa
                return JsonConvert.DeserializeObject<Mahasiswa>(jsonText);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan.");
            return null;
        }
    }

    public string GetFullName()
    {
        return $"{Nama.Depan} {Nama.Belakang}";
    }
}

public class Nama
{
    public string Depan { get; set; }
    public string Belakang { get; set; }
}

class DataMahasiswa
{
    static void Main(string[] args)
    {
        // Mendapatkan direktori tempat program berjalan (bin/debug atau bin/release)
        string binFolder = AppDomain.CurrentDomain.BaseDirectory;
        string jsonFilePath = Path.Combine(binFolder, "tp7_1_1302220013.json");

        var dataMahasiswa = Mahasiswa.ReadJSON(jsonFilePath);
        if (dataMahasiswa != null)
        {
            Console.WriteLine($"Nama {dataMahasiswa.GetFullName()} dengan nim {dataMahasiswa.Nim} dari fakultas {dataMahasiswa.Fakultas}");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 62681d2631f1c25c8af97aa7dffa7dd65ef071e6
