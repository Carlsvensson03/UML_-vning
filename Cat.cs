using System;
public class Cat : Animal
{
    public string Size;
    public override void Makesound()
    {
        Console.WriteLine($"Den {Size} katten {Name} säger meow!!");
    }


}