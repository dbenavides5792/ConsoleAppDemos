﻿// Variable Declarations and Types

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;

// Prompt the user for input
Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"You are employed: {working}");
Console.WriteLine($"Workikng years remaining: {workingYearsRemaining}");

