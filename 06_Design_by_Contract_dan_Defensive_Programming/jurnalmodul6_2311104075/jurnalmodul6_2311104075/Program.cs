using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Ganes");

        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Ganes");
            video.IncreasePlayCount(25000000); // Untuk uji batas
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total play count: {user.GetTotalVideoPlayCount()}");
    }
}
