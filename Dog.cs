using System;
public class Dog : Animal
{
    public string Size;
    public override void Makesound()
    {
        Console.WriteLine($"Den {Size} hunden {Name} säger woof!!");
    }

}