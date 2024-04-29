
namespace H3_CardPickerGame.Classes;

public class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + "of" + RandomSuit();
        }

        return pickedCards;
    }

    private static string RandomSuit()
    {
        throw new NotImplementedException();
    }

    private static string RandomValue()
    {
        throw new NotImplementedException();
    }
}