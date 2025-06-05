using System;

public class Employee : IQuitable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the company.");
    }
}