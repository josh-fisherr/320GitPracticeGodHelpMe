namespace _320GitPracticeGodHelpMe;
public class Dog : IFeedable
{ 
    public void Bark() 
    { 
        Console.WriteLine("woof"); 
    } 
 
    public void Feed(string foodName) 
    { 
        Console.WriteLine("Feeding: Dog wolfs down " + foodName); 
    } 
}
