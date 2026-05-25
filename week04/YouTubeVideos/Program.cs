class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Video> videos =
        [
            new Video("The Gentle Dragon", "John Eastmond", 212),
            new Video("Guardians of Fate Trailer", "Trevin Bergin", 134),
            new Video("Heritage - The Misty Age", "Elbon Eastmage", 90)
        ];

        videos[0].AddComment(new Comment("Dol Ribble", "First"));
        videos[0].AddComment(
            new Comment("Libert Mathiel", "I love how there is no model clipping!"));
        videos[0].AddComment(
            new Comment("Nadali Oner", "Now there's a dragon you don't see everyday!"));
        
        videos[1].AddComment(
            new Comment("Ember Imilon", "I can't wait to set spiders on fire!!!"));
        videos[1].AddComment(new Comment("Indira Kenit", "Oh, this takes me way back."));
        videos[1].AddComment(new Comment("Delfin Orian", "Childhood++"));

        videos[2].AddComment(new Comment(
            "Elbon Eastmage",
            "Please keep the comments family-friendly! In return, I won't ask for subscribers."));
        videos[2].AddComment(new Comment(
            "Rena Seneth",
            "A game that combines puzzles and horror? Color me interested."));
        videos[2].AddComment(
            new Comment("Tarod Varun", "This is either genius or insanity. I'm not sure which."));
        videos[2].AddComment(
            new Comment("Vant Zilen", "Not too often you see a family-friendly horror game."));
        
        foreach (Video video in videos)
        {
            video.Print();
        }
    }
}