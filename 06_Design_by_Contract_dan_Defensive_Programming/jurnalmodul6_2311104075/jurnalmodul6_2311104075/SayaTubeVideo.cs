using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
            throw new ArgumentException("Judul video tidak valid.");

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 25000000 || count < 0)
            throw new ArgumentOutOfRangeException("count", "Jumlah play count tidak valid.");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Overflow! " + e.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public int GetPlayCount() => playCount;
    public string GetTitle() => title;
}
