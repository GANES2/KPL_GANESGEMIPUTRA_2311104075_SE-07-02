using System;
using System.IO;
using System.Text.Json;

public class BankTransferConfig
{
    public string Lang { get; set; }
    public TransferConfig Transfer { get; set; }
    public string[] Methods { get; set; }
    public ConfirmationConfig Confirmation { get; set; }

    public static BankTransferConfig LoadConfig(string filePath)
    {
        if (!File.Exists(filePath))
        {
            // Nilai default jika file konfigurasi tidak ditemukan
            return new BankTransferConfig
            {
                Lang = "en",
                Transfer = new TransferConfig
                {
                    Threshold = 25000000,
                    LowFee = 6500,
                    HighFee = 15000
                },
                Methods = new[] { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                Confirmation = new ConfirmationConfig
                {
                    En = "yes",
                    Id = "ya"
                }
            };
        }

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<BankTransferConfig>(json);
    }
}

public class TransferConfig
{
    public int Threshold { get; set; }
    public int LowFee { get; set; }
    public int HighFee { get; set; }
}

public class ConfirmationConfig
{
    public string En { get; set; }
    public string Id { get; set; }
}
