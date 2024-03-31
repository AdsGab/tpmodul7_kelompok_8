using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    public class DataMahasiswa1302223153
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            string json = File.ReadAllText(@"C:\Users\RAFLI\Downloads\Percodingan\C#\tpmodul7_kelompok_8\tp7_1_1302223153.json");
            DataMahasiswa1302223153 deserialized = JsonSerializer.Deserialize<DataMahasiswa1302223153>(json);
            Console.WriteLine("Nama " + deserialized.nama.depan + deserialized.nama.belakang + " dengan nim " + deserialized.nim + " dari fakultas " + deserialized.fakultas);
        }
    }

    public class course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class KuliahMahasiswa1302223153
    {
        public List<course> courses { get; set; }
        public static void ReadJSON()
        {
            string json = File.ReadAllText(@"C:\Users\RAFLI\Downloads\Percodingan\C#\tpmodul7_kelompok_8\tp7_2_1302223153.json");
            KuliahMahasiswa1302223153 deserialized = JsonSerializer.Deserialize<KuliahMahasiswa1302223153>(json);
            int i = 1;
            foreach(var MatKul in deserialized.courses)
            {
                Console.WriteLine("MK " + i + " " + MatKul.code + " - " + MatKul.name);
                i++;
            }
        }
    }
    
    private static void Main(string[] args)
    {
        // Rafli
        DataMahasiswa1302223153.ReadJSON();
        KuliahMahasiswa1302223153.ReadJSON();
    }
}