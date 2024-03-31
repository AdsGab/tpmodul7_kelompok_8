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
    private static void Main(string[] args)
    {
        // Rafli
        DataMahasiswa1302223153.ReadJSON();
    }
}