namespace CardGame;

public class Person
{
    private readonly string _name;
    private Hand _hand=new();
    public Person(string name)
    {
        _name = name;
    }
    public void SetHand(Hand hand)
    {
        _hand = hand;
    }
    public Hand GetHand()
    {
        return _hand;
    }
    public string GetName()
    {
        return _name;
    }
}
