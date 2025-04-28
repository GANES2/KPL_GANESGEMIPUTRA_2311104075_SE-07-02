class Program
{
    static void Main(string[] args)
    {
        var config = BankTransferConfig.Load("bank_transfer_config.json");

        string language = config.lang;
        string confirmWord = language == "en" ? config.confirmation.en : config.confirmation.id;

        Console.WriteLine(language == "en" ? "Please insert the amount of money to transfer:" : "Masukkan jumlah uang yang akan di-transfer:");
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (language == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
            Console.WriteLine("Select transfer method:");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
            Console.WriteLine("Pilih metode transfer:");
        }

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // pilih metode (tidak diproses lebih lanjut)

        Console.WriteLine(language == "en"
            ? $"Please type \"{confirmWord}\" to confirm the transaction:"
            : $"Ketik \"{confirmWord}\" untuk mengkonfirmasi transaksi:");

        string confirmation = Console.ReadLine();
        if (confirmation.ToLower() == confirmWord.ToLower())
        {
            Console.WriteLine(language == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(language == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}