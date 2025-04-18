namespace _320GitPracticeGodHelpMe;

public class Cat : IFeedable
{
    public void Blep()
    {
        Console.WriteLine("blep!");
    }

    public void Feed(string foodName)
    {
        Console.WriteLine("Feeding: Cat picks at " + foodName);
    }
}