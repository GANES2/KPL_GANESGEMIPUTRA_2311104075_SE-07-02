using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username { get; private set; }

    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length > 100)
            throw new ArgumentException("Username tidak valid");

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
            throw new ArgumentNullException("Video tidak boleh null");
        if (video.GetPlayCount() >= int.MaxValue)
            throw new ArgumentException("Video play count terlalu besar");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < Math.Min(8, uploadedVideos.Count); i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
    }
}
