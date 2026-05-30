using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Learn C# in 20 Minutes",
            "CodeMaster",
            1200);

        video1.AddComment(
            new Comment("John", "Great tutorial!"));

        video1.AddComment(
            new Comment("Maria", "Very easy to understand."));

        video1.AddComment(
            new Comment("Alex", "Thanks for sharing."));

        videos.Add(video1);

        Video video2 = new Video(
            "Top 10 Gaming Tips",
            "GamingPro",
            900);

        video2.AddComment(
            new Comment("Lucas", "Awesome tips!"));

        video2.AddComment(
            new Comment("Emma", "Helped me a lot."));

        video2.AddComment(
            new Comment("Noah", "Nice video."));

        videos.Add(video2);

        Video video3 = new Video(
            "Healthy Breakfast Ideas",
            "FitLife",
            600);

        video3.AddComment(
            new Comment("Sophia", "Looks delicious!"));

        video3.AddComment(
            new Comment("Daniel", "I'll try this tomorrow."));

        video3.AddComment(
            new Comment("Olivia", "Very healthy recipes."));

        videos.Add(video3);

        Video video4 = new Video(
            "Travel Guide Peru",
            "AdventureTV",
            1500);

        video4.AddComment(
            new Comment("Carlos", "Peru is beautiful!"));

        video4.AddComment(
            new Comment("Laura", "Adding this to my list."));

        video4.AddComment(
            new Comment("Miguel", "Great recommendations."));

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComment List:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}