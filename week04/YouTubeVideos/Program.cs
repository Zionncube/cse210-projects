using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("MindWink Academy Tips", "Happiness Ncube", 450);
        video1.AddComment(new Comment("Lerato", "Love this perspective!"));
        video1.AddComment(new Comment("Sam", "So motivating, thank you."));
        video1.AddComment(new Comment("Zanele", "I’m going to try this out today."));

        Video video2 = new Video("C# Abstraction Tutorial", "Code Explained", 360);
        video2.AddComment(new Comment("Thabo", "Great explanation!"));
        video2.AddComment(new Comment("Amanda", "Helped me understand classes."));
        video2.AddComment(new Comment("Peter", "Finally got it, thanks!"));

        Video video3 = new Video("BYU-Idaho Campus Life", "BYU-Idaho Media", 480);
        video3.AddComment(new Comment("Jane", "Looks like a peaceful place."));
        video3.AddComment(new Comment("Neo", "I’m applying next semester."));
        video3.AddComment(new Comment("Chris", "Beautiful campus!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}
