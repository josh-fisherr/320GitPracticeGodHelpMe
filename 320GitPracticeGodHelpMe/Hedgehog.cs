namespace _320GitPracticeGodHelpMe;

public class Hedgehog : IFeedable{
    
    public void Rootle(){
Console.WriteLine("root root");
}
public void Feed(string foodName){
Console.WriteLine("Feeding: Hedgehog snuffles at " + foodName);
}
}