namespace _320GitPracticeGodHelpMe;

public class Bird : IFeedable
{ 
    public void Chirp() 
    { 
        Console.WriteLine("squawk!"); 
    } 
 
    public void Feed(string foodName) 
    { 
        Console.WriteLine("Feeding: Bird pecks at " + foodName); 
    } 
}
