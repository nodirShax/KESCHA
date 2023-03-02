using KESCHA.Classes;
using KESCHA.Enums;
internal class Program
{
    public static TypePet Cat { get; private set; }

    private static void Main(string[] args)
    {
        try
        {
            Animal kescha = new Pet("Kescha", 3);
            Animal kasee = new Bird("Kasee", 2);
            System.Console.WriteLine(kescha.CreatedDay);
            System.Console.WriteLine(kasee.CreatedDay);
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            kescha.Greet(userName);
            kasee.Greet(userName);

            kescha.Type = Cat;
            System.Console.WriteLine(kescha.Type);
            Console.Write("Enter yor age : ");
            string ageAsString = Console.ReadLine();

            Console.WriteLine("Converting...");
            int userAge = Convert.ToInt32(ageAsString);
            Console.WriteLine("Convert Succesfully!");

            kescha.CalculateAndPrintAgeDifferenceWithoutReturn(userAge);
            kescha.CompareAge(userAge);
            kescha.TelAboutFriends(userAge, userName);
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine($"Error was thrown: Message:  {ex.Message}");            
        }
        System.Console.WriteLine("Programm ended...");
        
    }
}