using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        Video vid1 = new Video("Horror","Shark Cage",12);
        Video vid2 = new Video("Music fest","Show Man",3);
        Video vid3 = new Video("Dance again","Ellie Fred",4);
        Video vid4 = new Video("Move Up","Sandel Williams",5);
        
        List<Video> youtube = new List<Video>();
        youtube.Add(vid1);
        vid1._comments=["Excellent","Great","Nice Movie","how can i get that!"];
        Comment vidOne = new Comment();
        vidOne._name=["Andrew","Shark","Cage","John"];
        vidOne._text=["Excellent","Great","Nice Movie","how can i get that!"];
       
        youtube.Add(vid2);
        vid2._comments=["Aweosome","Great","Nice Movie"];
        Comment vidtwo = new Comment();
        vidtwo._name=["Andrew","Shark","John"];
        vidtwo._text=["Aweosome","Great","Nice Movie"];

        //youtube.Add(vid3);
        //youtube.Add(vid4);
        


        foreach(var vid in youtube)
        {
            vid.Display();
            Console.WriteLine();
        }

        Console.WriteLine("Video One Comments");
        vidOne.displayComment();
        Console.WriteLine();

        Console.WriteLine("Video Two Comments");
        vidtwo.displayComment();

       
       
    }
}