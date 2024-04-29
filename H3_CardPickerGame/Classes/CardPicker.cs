
namespace H3_CardPickerGame.Classes;

public class CardPicker
{
    private static Random _random = new Random();
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + " of " + RandomSuit();
        }

        return pickedCards;
    }

    private static string RandomSuit()
    {
        int value = _random.Next(1, 5);
        return value switch
        {
            1 => "spades",
            2 => "hearts",
            3 => "clubs",
            _ => "diamonds"
        };
    }

    private static string RandomValue()
    {
        int value = _random.Next(1, 14);
        return value switch
        {
            1 => "Ace",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => value.ToString()
        };
    }
}