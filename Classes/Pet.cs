namespace KESCHA.Classes
{
    public class Pet : Animal
    {
        public Pet(string name,int age)
            : base(name,age)
        {

        }
        public override void Greet(string userName)
        {
            if(userName == "")
            {
                System.Console.WriteLine("Miyav Unknown");
            }
            else
            {
                System.Console.WriteLine($"Miyav {userName}");
            }
        }

        public override void Greet2(string userName)
        {
            System.Console.WriteLine("Abstract method implimented by Pet");
        }
    }
}