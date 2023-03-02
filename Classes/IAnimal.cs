namespace KESCHA.Classes;

public interface IAnimal
{
    void CalculateAndPrintAgeDifferenceWithoutReturn(int userAge);
    void CompareAge(int userAge);
    void Greet(string userName);
    void Greet2(string userName);
    void TelAboutFriends(int userAge,string userName);
}
