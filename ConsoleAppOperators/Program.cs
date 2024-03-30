// See https://aka.ms/new-console-template for more information


Console.WriteLine("Please enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
int num2 = Convert.ToInt32(numberEntered);

// Math Operations

// Add numbers
int sum = num1 + num2;

// multiply
int product = num1 * num2;

// Division
int quotient = num1 / num2;

// Subtraction
int difference = num1 - num2;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");


/*
 Logic Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 <= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal To: {isNotEqual}");


// Assignment Operastions and Operators

// int randomValue = 5;
// int icreaseValue = num1 + 5;

// num1 = num1 + 5;
num1 += 5;
Console.WriteLine($"Num 1 increased by 5: {num1}");

num1 -= 3;
Console.WriteLine($"Num 1 reduced by 5: {num1}");

num1 /= 2;
Console.WriteLine($"Num 1 divided by 5: {num1}");

num1 %= 2;
Console.WriteLine($"Num 1 mod by 5: {num1}");

num1 *= 10;
Console.WriteLine($"Num 1 multiplied by 5: {num1}");

