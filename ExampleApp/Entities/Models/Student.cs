using ExampleApp.Entities.Abstractions;

namespace ExampleApp.Entities.Models;

internal class Student(string firstName, string lastName) : IStudent
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public void SayHi()
    {
        Console.WriteLine($"Hi I am {FirstName} {LastName}.");
    }
}