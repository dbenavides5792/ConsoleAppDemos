// See https://aka.ms/new-console-template for more information

// Different Data Types
/*
    text - string
    integer - int
    decimal - double, float, decimal
    logical - bool
 */

string name = "Happy Feet";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // Strring concatenation
Console.WriteLine($"They call me {name}"); // String Interpolation
Console.WriteLine("I was given the name {0}", name); // Formatted string

int age = 31;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);
