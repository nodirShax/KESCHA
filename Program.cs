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
if(age > keschaAge)
{
    System.Console.WriteLine("You are older!");
}
else if(age == keschaAge)
{
    System.Console.WriteLine("You are equal!");
}
else
{
    System.Console.WriteLine("You are younger!");
}
System.Console.WriteLine("Let me tell you about my friends?");
string[] friends = new string[3];
friends[0] = "Kasee";
friends[1] = "Vase";
friends[2] = name;

int[] friendsAges = new int[3];
friendsAges[0] = 4;
friendsAges[1] = 2;
friendsAges[2] = age;

for(int i = 0; i < 3; i++)
{
    System.Console.WriteLine($"{friends[i]} is {friendsAges[i]} years old");
}




















