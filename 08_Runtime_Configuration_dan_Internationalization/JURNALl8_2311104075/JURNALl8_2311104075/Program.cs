using System;

class Program
{
    static void Main(string[] args)
    {
        // Path ke file konfigurasi
        string configPath = "bank_transfer_config.json";

        // Load konfigurasi
        BankTransferConfig config = BankTransferConfig.LoadConfig(configPath);

        // Tampilkan pesan berdasarkan bahasa
        Console.WriteLine(config.Lang == "en"
            ? "Please insert the amount of money to transfer:"
            : "Masukkan jumlah uang yang akan di-transfer:");

        // Input jumlah uang yang akan ditransfer
        int transferAmount = int.Parse(Console.ReadLine());

        // Hitung biaya transfer
        int transferFee = transferAmount <= config.Transfer.Threshold
            ? config.Transfer.LowFee
            : config.Transfer.HighFee;

        int totalAmount = transferAmount + transferFee;

        // Tampilkan biaya transfer dan total biaya
        if (config.Lang == "en")
        {
            Console.WriteLine($"Transfer fee = {transferFee}");
            Console.WriteLine($"Total amount = {totalAmount}");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {transferFee}");
            Console.WriteLine($"Total biaya = {totalAmount}");
        }

        // Tampilkan metode transfer
        Console.WriteLine(config.Lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.Methods.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {config.Methods[i]}");
        }

        // Pilih metode transfer
        int selectedMethod = int.Parse(Console.ReadLine());

        // Tampilkan konfirmasi
        Console.WriteLine(config.Lang == "en"
            ? $"Please type \"{config.Confirmation.En}\" to confirm the transaction:"
            : $"Ketik \"{config.Confirmation.Id}\" untuk mengkonfirmasi transaksi:");

        string confirmation = Console.ReadLine();

        // Proses konfirmasi
        if ((config.Lang == "en" && confirmation == config.Confirmation.En) ||
            (config.Lang == "id" && confirmation == config.Confirmation.Id))
        {
            Console.WriteLine(config.Lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(config.Lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}
