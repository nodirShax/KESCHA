using System;
System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
string ageString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageString);
System.Console.WriteLine($"Succesfully converted {ageString}");
int keschaAge = 3;
int ageDifference = age - keschaAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}");