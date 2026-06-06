// I added two classes named Option and Options. They store prompts/questions and ensure that one
// already selected is not selected again until all the prompts/questions have been displayed. I
// also added input validation so the user can't enter nonsensical values like a negative duration.
class Program
{
    static void Main(string[] args)
    {
        BreatheActivity breatheActivity = new(
            "Breathe",
            """
            This activity can help you release your worries and ground yourself.
            Let your breathing provide a path to peace.
            """);
        
        ReflectActivity reflectActivity = new(
            "Reflect",
            """
            This activity will help you remember times in your life when you did
            wonderful things. Remembering such times can give you confidence for
            the future.
            """);
        
        ListActivity listActivity = new(
            "List",
            """
            This activity helps you make a list of the blessings in your life.
            Counting your blessings is a good way to feel gratitude, resulting
            in more happiness!
            """);
        
        int userChoice = -1;

        while (userChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1: Breathe");
            Console.WriteLine("2: Reflect");
            Console.WriteLine("3: List");
            Console.WriteLine("4: Exit");

            Console.Write("What do you want to do? ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out userChoice) || userChoice < 1 || userChoice > 4)
            {
                Console.Write("That is not a valid choice. Please enter another one. ");
                Console.Write("(Press enter to continue.)");
                Console.ReadLine();
            }
            else
            {
                switch (userChoice)
                {
                    case 1:
                        breatheActivity.Start();
                        breatheActivity.Run();
                        breatheActivity.End();
                        break;
                    case 2:
                        reflectActivity.Start();
                        reflectActivity.Run();
                        reflectActivity.End();
                        break;
                    case 3:
                        listActivity.Start();
                        listActivity.Run();
                        listActivity.End();
                        break;
                }
            }
        }
    }
}