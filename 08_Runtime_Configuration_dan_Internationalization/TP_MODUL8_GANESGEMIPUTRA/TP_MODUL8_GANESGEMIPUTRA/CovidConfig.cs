using System.Text.Json;
using System.IO;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public static string configFile = "covid_config.json";

    public CovidConfig()
    {
        if (File.Exists(configFile))
        {
            var json = File.ReadAllText(configFile);
            var config = JsonSerializer.Deserialize<CovidConfig>(json);
            this.satuan_suhu = config.satuan_suhu;
            this.batas_hari_deman = config.batas_hari_deman;
            this.pesan_ditolak = config.pesan_ditolak;
            this.pesan_diterima = config.pesan_diterima;
        }
        else
        {
            this.satuan_suhu = "celcius";
            this.batas_hari_deman = 14;
            this.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            this.pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            SaveConfig();
        }
    }

    public void SaveConfig()
    {
        var json = JsonSerializer.Serialize(this);
        File.WriteAllText(configFile, json);
    }

    public void UbahSatuan()
    {
        this.satuan_suhu = this.satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
        SaveConfig();
    }
}
