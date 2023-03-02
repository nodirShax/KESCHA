namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public Bird(string name, int age)
            : base(name,age)
        {
        }

        public override void Greet(string userName)
        {
            if(userName == "")
            {
                System.Console.WriteLine("Kuku Unknown");
            }
            else
            {
                System.Console.WriteLine($"Kuku {userName}");
            }
        }

        public override void Greet2(string userName)
        {
            System.Console.WriteLine("Abstract method implimented by Bird");
        }
    }
}