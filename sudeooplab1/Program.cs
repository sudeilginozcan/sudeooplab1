// 7 / 2 sonuçları:
// double ile: 3.5
// int ile:    3   (ondalık kısım atılır, 7 % 2 = 1 kalan)

string department = "Computer Engineering";
int year = 2;

Console.Write("Your name: ");
string name = Console.ReadLine();
Console.Write("Your city: ");
string city = Console.ReadLine();

Console.WriteLine("=== STUDENT CARD ===");
Console.WriteLine($"Name       : {name}");
Console.WriteLine($"City       : {city}");
Console.WriteLine($"Department : {department}");
Console.WriteLine($"Year       : {year}");
Console.WriteLine("C#\tis fun");
Console.WriteLine($"Hello {name} from {city}, welcome to year {year} of {department}!");

//double
Console.Write("First number: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Second number: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
Console.WriteLine($"{n1} / {n2} = {n1 / n2}");

//int + remainder
Console.Write("First integer: ");
int i1 = int.Parse(Console.ReadLine());
Console.Write("Second integer: ");
int i2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{i1} + {i2} = {i1 + i2}");
Console.WriteLine($"{i1} - {i2} = {i1 - i2}");
Console.WriteLine($"{i1} * {i2} = {i1 * i2}");
Console.WriteLine($"{i1} / {i2} = {i1 / i2}");
Console.WriteLine($"{i1} % {i2} = {i1 % i2}");

//grade
Console.Write("Student name: ");
string studentName = Console.ReadLine();
Console.Write("Midterm score: ");
int midterm = int.Parse(Console.ReadLine());
Console.Write("Final score: ");
int finalScore = int.Parse(Console.ReadLine());

double average = midterm * 0.4 + finalScore * 0.6;
Console.WriteLine($"{studentName}, average = {average:F2}");

if (average >= 50)
{
    Console.WriteLine("PASSED");
}
if (average < 50)
{
    Console.WriteLine("FAILED");
}
if (finalScore == 100)
{
    Console.WriteLine("Perfect final!");
}