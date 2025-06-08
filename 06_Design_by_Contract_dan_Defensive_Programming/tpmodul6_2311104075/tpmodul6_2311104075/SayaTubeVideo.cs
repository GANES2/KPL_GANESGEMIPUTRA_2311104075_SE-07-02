using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul tidak boleh null dan maksimal 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 10000000)
            throw new ArgumentOutOfRangeException("count", "Maksimal 10.000.000 per panggilan.");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Terjadi overflow: " + e.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("=== Video Details ===");
        Console.WriteLine("ID        : " + this.id);
        Console.WriteLine("Title     : " + this.title);
        Console.WriteLine("PlayCount : " + this.playCount);
    }
}
