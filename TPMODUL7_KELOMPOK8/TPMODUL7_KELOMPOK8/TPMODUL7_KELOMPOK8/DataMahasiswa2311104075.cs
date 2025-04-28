using System;
using System.IO;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_8
{
    class DataMahasiswa2311104075
    {
        public string? Nama { get; set; }
        public string? Nim { get; set; }
        public string? Fakultas { get; set; }

        public static void ReadJSON()
        {
            string path = "tp7_1_2311104075.json";

            try
            {
                string json = File.ReadAllText(path);
                DataMahasiswa2311104075? data = JsonConvert.DeserializeObject<DataMahasiswa2311104075>(json);

                if (data != null)
                {
                    Console.WriteLine($"Nama {data.Nama} dengan nim {data.Nim} dari fakultas {data.Fakultas}");
                }
                else
                {
                    Console.WriteLine("Data JSON tidak berhasil di-deserialize (data null).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}
