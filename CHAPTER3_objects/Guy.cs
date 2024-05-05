using System.Threading.Channels;

namespace CHAPTER3_objects;

public class Guy
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    private int _cash;
    public int Cash
    {
        get => _cash;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Cash cannot be negative!");
            _cash = value;
        }
    }

    public void WriteMyInfo() => Console.WriteLine($"{Name} has {Cash} bucks");

    public string AnswerTransaction(int amount) =>
        IsValidAmount(amount) ? $"{Name} gave cash." : $"{Name} says this isn't a valid number";

    private bool IsValidAmount(int amount) => amount > 0 && amount <= Cash;

    public bool GiveCash(int amount)
    {
        if (IsValidAmount(amount))
        {
            Cash -= amount;
            return true;
        }

        return false;
    }
}