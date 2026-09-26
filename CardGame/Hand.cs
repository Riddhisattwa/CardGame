using System;

namespace CardGame;

public class Hand
{
    private List<Card> _cards = new();
    public void FetchACard()
    {
        throw new NotImplementedException();
    }

    public List<Card> GetCards()
    {
        return _cards;
    }
    public void Add(Card card)
    {
        if(card!=null && !_cards.Contains(card))
        {
            _cards.Add(card);
        }
    }
    public void Clear()
    {
        if(_cards.Count>0)
        {
            _cards.Clear();
        }
    }
}
