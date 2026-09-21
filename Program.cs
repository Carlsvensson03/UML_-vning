using System;
public class program 
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Name = "Carl";
        myDog.Size = "stora";

        Cat mycat = new Cat();
        mycat.Name = "Calle";
        mycat.Size = "lilla";

        mycat.Makesound();
        myDog.Makesound();


    }



}
