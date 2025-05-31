using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        List<Video> videos = new List<Video>();
        
        var video1 = new Video("How to Code in C#", "Anderson", 300);
        video1.AddComment(new Comment("Anderson", "Great Lesson"));
        video1.AddComment(new Comment("Amanda", "I Love this."));
        video1.AddComment(new Comment("Dominion", "C# made easy"));
        video1.AddComment(new Comment("Victory", "The best I have seen."));
        
        var video2 = new Video("Python Made Easy", "Oluchukwu", 550);
        video2.AddComment(new Comment("Gloria", "I love Python"));
        video2.AddComment(new Comment("Tony", "Python is loveable"));
        video2.AddComment(new Comment("Felix", "Great codes here"));
        // video2.AddComment(new Comment("Mike", "Great job"));
        
        var video3 = new Video("JavaScript for web", "Offor", 600);
        video3.AddComment(new Comment("Monday", "JavaScript is way to go"));
        video3.AddComment(new Comment("Paul", "JavaScript is difficult"));
        // video3.AddComment(new Comment("Sunday", "Beautiful"));
        // video3.AddComment(new Comment("Goloria", "JavaScript is fire"));
        
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        
        foreach (var video in videos)
        {
            Console.WriteLine($"\nTitle: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}s");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComment()}");
            Console.WriteLine($"Comments:");
            
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
        
    }
}