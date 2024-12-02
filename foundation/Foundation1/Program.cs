using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create sample videos
        Video video1 = new Video("How to Cook Pasta", "John Doe", 300);
        Video video2 = new Video("Learn C# in 10 Minutes", "Jane Smith", 600);
        Video video3 = new Video("Travel Vlog: Paris", "Alex Johnson", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great video, very helpful!"));
        video1.AddComment(new Comment("Bob", "I love pasta!"));
        video1.AddComment(new Comment("Charlie", "Thanks for the tips!"));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Awesome tutorial!"));
        video2.AddComment(new Comment("Eve", "Really easy to follow."));
        video2.AddComment(new Comment("Frank", "Learned a lot, thanks!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Beautiful shots!"));
        video3.AddComment(new Comment("Heidi", "I want to visit Paris now."));
        video3.AddComment(new Comment("Ivan", "Thanks for sharing your experience."));

        // Create a list of videos
        List<Video> videos = new List<Video>() { video1, video2, video3 };

        // Display details for each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
