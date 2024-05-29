using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // List of videos
        List<Video> videos = new List<Video>();

        // Creating the video instances and adding them to the list
        Video video1 = new Video("Everything you should know before programming", "Frank Robinson", 2000);
        Video video2 = new Video("How to draw", "Rob Boss", 1500);
        Video video3 = new Video("Introduction to Databases 02", "Mark Trejo", 4000);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Adding comments to the firs video
        video1.AddComment(new Comment("Jose", "Great Video!"));
        video1.AddComment(new Comment("Jhon", "Love it!"));
        video1.AddComment(new Comment("Alan", "Keep the good work!"));

        // Adding comments to the second video
        video2.AddComment(new Comment("Carl", "Thank you now I know how to draw"));
        video2.AddComment(new Comment("Jonathan", "I learned a LOT!"));
        video2.AddComment(new Comment("Rose","Amazing, the technique is amazing"));

        // Adding comments to the third video
        video3.AddComment(new Comment("Francis","So, should we always work with PHP?"));
        video3.AddComment(new Comment("Erika","Everything is clear now, thanks"));
        video3.AddComment(new Comment("Marco","Part one was great, but part two makes Databases look easy"));

        // Display details of each video and its comments
        foreach (Video video in videos){
            video.DisplayVideo();
        }
    }
}