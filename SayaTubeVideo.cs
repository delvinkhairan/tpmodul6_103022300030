using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title.Length <= 100, "Title length must be less than or equal to 100 characters.");
        this.title = title;
        Random random = new Random();
        this.id = random.Next(10000, 99999); 
        this.playCount = 0; 
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count >= 0, "Play count must be non-negative.");
        Debug.Assert(this.playCount + count <= 10000000, "Play count cannot exceed 10,000,000.");
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {this.id}, Title: {this.title}, Play Count: {this.playCount}");
    }
}
