using KESCHA.Enums;
namespace KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int AgeDifference { get; set; }
        public DateTimeOffset CreatedDay { get; set; }
        public TypePet Type { get;set; }
        public Animal(int age,string name)
        {
            Age = age;
            Name = name;
            CreatedDay = DateTimeOffset.Now;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            CreatedDay = DateTimeOffset.Now;
        }

        public void CalculateAndPrintAgeDifferenceWithoutReturn(int userAge)
        {
            AgeDifference = userAge - Age;
            System.Console.WriteLine(AgeDifference);
        }
        public void CompareAge(int userAge)
        {
            if(Age > userAge)
            {
                System.Console.WriteLine("You are older!");
            }
            else if(Age == userAge)
            {
                System.Console.WriteLine("You are equal!");
            }
            else
            {
                System.Console.WriteLine("You are younger!");
            }
        }

        public virtual void Greet(string userName)
        {
            if(userName == "")
            {
                System.Console.WriteLine("Hello Unknown");
            }
            else
            {
                System.Console.WriteLine($"Hello {userName}");
            }
        }
        public abstract void Greet2(string userName);


        public void TelAboutFriends(int userAge,string userName)
        {
            string[] friends = new string[3];
            friends[0] = "Kasee";
            friends[1] = "Vase";
            friends[2] = userName;

            int[] friendsAges = new int[3];
            friendsAges[0] = 4;
            friendsAges[1] = 2;
            friendsAges[2] = userAge;

            for(int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"{friends[i]} is {friendsAges[i]} years old");
            }
        }
    }
}