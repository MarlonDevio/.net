namespace CHAPTER3_objects;

class Program
{
    static void Main(string[] args)
    {
        var joe = CreateGuy(500, "Joe");
        string guyToGiveMoney = WhoGivesToWho();
        Console.WriteLine(guyToGiveMoney);
    }

    private static Guy CreateGuy(int amount, string name)
    {
        return new Guy { Cash = amount, Name = name };
    }

    private static string WhoGivesToWho()
    {
        Console.Write("Who should give the cash: ");
        string input;
        try
        {
            input = Console.ReadLine();
            if (input == string.Empty)
            {
                throw new ArgumentNullException();
            }
        }
        catch (ArgumentNullException e)
        {
            return e.Message;
        }
        return input;
    }
}
