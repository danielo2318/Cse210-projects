using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to program in C#", "Juan Pérez", 300);
        video1.AddComment(new Comment("Karina", "Very good tutorial, thank you."));
        video1.AddComment(new Comment("Daniel", "¡It helped me a lot!."));
        video1.AddComment(new Comment("Keyla", "Could you do one about classes."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("History of the Internet", "Carlos Tech", 420);
        video2.AddComment(new Comment("Estefy", "Very interesting."));
        video2.AddComment(new Comment("Alfonso", "¡Great explanation."));
        video2.AddComment(new Comment("Mariana", "I didn't know all that."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Lasagna recipe", "Chef Mario", 600);
        video3.AddComment(new Comment("Paty", "It looks delicious."));
        video3.AddComment(new Comment("Miguel", "I will try it this weekend."));
        video3.AddComment(new Comment("Nathalia", "Failure to mention the cooking time."));
        videos.Add(video3);

        // Mostrar todos los videos y sus comentarios
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
