using System;

// Abstract class
public abstract class Animal
{
    // Abstract method (no body)
    public abstract void MakeSound();

    // Concrete method (with body)
    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping...");
    }
}

// Derived class 1
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof! Woof!");
    }
}

// Derived class 2
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says: Meow! Meow!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal myDog = new Dog();  // Polymorphism
        Animal myCat = new Cat();  // Polymorphism

        myDog.MakeSound();
        myDog.Sleep();

        myCat.MakeSound();
        myCat.Sleep();
    }
}






