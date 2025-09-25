using System;
using System.Collections.Generic;

//(finished) program goals: creates 3-4 videos, sets the appropriate values, and for each one, add a list of 3-4 comments (with commenter's name and text) .  Put each video in a list.  (me: so a list of Video instances).
//(not finished) the program then iterates through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments  for that video. Repeat this display for each video in the list.
//
class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        //video1: https://www.youtube.com/watch?v=B3f0o3Sv994
        string title1 = "Weekly Fall Trader Joe's Haul";
        string author1 = "Amanda Turner";
        int length1 = 613;
        //creating a tuple list of name and comment
        List<(string, string)> video1Comments = new List<(string, string)>
        {
            ("ardilane1242", "The crispy garlic sounds interesting. I would try that on a salad or pasta."),
            ("Ele-6800", "The granola looks amazing!"),
            ("brando091121", "I would try the crispy garlic in a soup, pasta salad, or avocado toast.")
        };

        //video2: https://www.youtube.com/watch?v=C6d81sUk6EM&t=1797s
        string title2 = "Ultimate Foodie Guide To Halloween Time At The DISNEYLAND Resort 2025!";
        string author2 = "Magic Journeys";
        int length2 = 2125;
        //creating a tuple list of name and comment
        List<(string, string)> video2Comments = new List<(string, string)>
        {
            ("Mrtfarrugia", "We bumped into you at the park on Friday.  My wife and I wanted to thank you again for stopping for a picture.  We really appreciated it.  Keep up the great work."),
            ("monicaarena1236", "Always a good day when Darth by Chocolate is available! As always, love the witch hat 😍"),
            ("KyAndTheGang", "Love this video! Definitely want to try that flatbread and iced Chai pumpkin 🎃  Oogie and Scar are my favorite villains! Looking forward to your next video😁")
        };

        //video3": https://www.youtube.com/watch?v=BC6Wa27VVz0&t=620s
        string title3 = "Comment apprendre le français dans le bon ordre?";
        string author3 = "innerFrench";
        int length3 = 820;
        //creating a tuple list of name and comment
        List<(string, string)> video3Comments = new List<(string, string)>
        {
            ("lininfrance", "1 year ago, i started to listen to your youtube video, i understood NOTHING. However, your video inspried me a lot to practice my listening skills, so i keep listening to these once/week. I was in Level A1. Today i can be confident to say that I understand most of this video without looking much on subtitles. I’m now in my way to obtain delf B1. Thank you so much for great videos. Everyone, pls keep your learning habits regularly. Embrace the process, embrace the journey 🙌"),
            ("raymondbeauchesne8712", "Your pronunciation is superb.  I haven't used my French in more than 50 years and I can understand a lot of what you say."),
            ("PokhrajRoy", "I've been reviewing my French for a few months now and this video is really helpful for me. Thank you!")
        };

        Video video1 = new Video(title1, author1, length1, video1Comments);
        videoList.Add(video1);
        Console.WriteLine("");
        Video video2 = new Video(title2, author2, length2, video2Comments);
        videoList.Add(video2);
        Console.WriteLine("");
        Video video3 = new Video(title3, author3, length3, video3Comments);
        videoList.Add(video3);

        foreach (Video instance in videoList)
        {
            Console.WriteLine("");
            Console.WriteLine(instance.GetInformation());
            Console.WriteLine($"Number of comments: {instance.GetNumberOfComments()}");
            Console.WriteLine("COMMENTS:");
            Console.WriteLine(instance.GetComments());
        }
    }
}