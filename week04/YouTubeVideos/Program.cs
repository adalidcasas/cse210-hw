using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video("How I Learned to Code - and Got a Job at Google!", "CS DOJO", 298);
        Video video2 = new Video("Is AI Replacing Software Engineering?", "CS DOJO", 969);
        Video video3 = new Video("What is a Computer Network?", "Eli the Computer Guy", 4390);
        Video video4 = new Video("What is a OSI Model?", "Eli the Computer Guy", 3240);

        Comment coment11 = new Comment("Chana Hanna", "Wow, such an inspiring journey! Definitely motivates me to keep pushing through my coding challenges");
        video1.SetComment(coment11);
        Comment coment12 = new Comment("Jeremy Pierce", "Love how honest you are about the ups and downs. This is exactly what I needed to hear today!");
        video1.SetComment(coment12);
        Comment coment13 = new Comment("Zahra Cross", "Your journey is proof that persistence pays off. Thanks for keeping it real!");
        video1.SetComment(coment13);
        Comment coment14 = new Comment("Jaxen Baxter", "This gave me hope! If you made it to Google, maybe I can too someday.");
        video1.SetComment(coment14);

        Comment coment21 = new Comment("Trinity Larson", "Loved your balanced take on this! AI as a tool, not a threat—makes sense");
        video2.SetComment(coment21);
        Comment coment22 = new Comment("Reece Stout", "AI might change the game, but creativity and problem-solving will always need humans!");
        video2.SetComment(coment22);
        Comment coment23 = new Comment("Jovanni Anderson", "Honestly, this made me feel less anxious about the future of coding. Great insights!");
        video2.SetComment(coment23);

        Comment coment31 = new Comment("Forest Casey", "Great explanation! You made a complex topic super easy to understand");
        video3.SetComment(coment31);
        Comment coment32 = new Comment("Reese Valenzuela", "Finally, I understand what happens behind the scenes when I browse the internet");
        video3.SetComment(coment32);
        Comment coment33 = new Comment("Lilah Dillon", "This should be required watching for anyone new to networking!");
        video3.SetComment(coment33);
        Comment coment34 = new Comment("Ermias Middleton", "Clear and concise—perfect for beginners like me. Thanks for this!");
        video3.SetComment(coment34);

        Comment coment41 = new Comment("Kairi Banks", "Hi!. I really appreciate your approach to teaching, it has served me greatly.");
        video4.SetComment(coment41);
        Comment coment42 = new Comment("Whitley Beard", "This was super helpful. Thanks for all you do.");
        video4.SetComment(coment42);
        Comment coment43 = new Comment("Martin Hodges", "The actual OSI model has helped fix more issues as a network/systems engineer than I can care to think about. ");
        video4.SetComment(coment43);


        List<Video> myVideos = new List<Video>();
        myVideos.Add(video1);
        myVideos.Add(video2);
        myVideos.Add(video3);
        myVideos.Add(video4);

        foreach (Video video in myVideos)
        {
            Console.WriteLine(video.GetVideoDescription() + "\n");
        }
    }
}