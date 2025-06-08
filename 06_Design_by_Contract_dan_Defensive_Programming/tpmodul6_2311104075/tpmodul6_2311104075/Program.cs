using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [GANES GEMI PUTRA]");

        // Testing IncreasePlayCount with loop for overflow
        for (int i = 0; i < 215; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();
    }
}
