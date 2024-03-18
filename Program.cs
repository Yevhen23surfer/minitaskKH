

//Task 1: Name Input Program

using System;

class NameInput
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine(); // Use a descriptive name

        Console.WriteLine($"Hello, {userName}!");
    }
}
