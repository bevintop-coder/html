using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("India's Graduate Skill Index");
        Console.WriteLine("Bridging the Gap Between Education & Employability");

        string[] features =
        {
            "Skill Development",
            "Real Projects",
            "Interview Preparation",
            "Career Guidance"
        };

        Console.WriteLine("\nKey Features:");

        foreach(string feature in features)
        {
            Console.WriteLine("- " + feature);
        }

        Console.WriteLine("\nContact:");
        Console.WriteLine("Email: bevintop@gmail.com");
        Console.WriteLine("Phone: +91-8015208065");
    }
}