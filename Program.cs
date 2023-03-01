using System;
using KESCHA.Classes;

Animal kescha = new Animal(name : "Kescha", age : 3);
System.Console.Write("Enter your name: ");
string userName = Console.ReadLine();
kescha.Greet(userName);

System.Console.Write("Enter yor age : ");
string ageAsString = Console.ReadLine();

System.Console.WriteLine("Converting...");
int userAge = Convert.ToInt32(ageAsString);
System.Console.WriteLine("Convert Succesfully!");

kescha.CalculateAndPrintAgeDifferenceWithoutReturn(userAge);
kescha.CompareAge(userAge);
kescha.TelAboutFriends(userAge,userName);


