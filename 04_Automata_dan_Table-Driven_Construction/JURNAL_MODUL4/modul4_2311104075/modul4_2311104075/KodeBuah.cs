public class KodeBuah
{
    private Dictionary<string, string> kodeBuah = new Dictionary<string, string>()
    {
        { "Apel", "A01" },
        { "Durian", "D01" },
        { "Mangga", "M01" }
    };

    public string GetKodeBuah(string namaBuah)
    {
        if (kodeBuah.ContainsKey(namaBuah))
            return kodeBuah[namaBuah];
        else
            return "Tidak Ditemukan";
    }
}
