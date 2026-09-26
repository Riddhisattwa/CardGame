using System;

namespace CardGame;

public sealed class Deck
{
    private List<Card> _cards = new();

    public Deck()
    {
        ResetDeck();
    }

    private void ResetDeck()
    {
        foreach(Suits suit in Enum.GetValues(typeof(Suits)))
        {
            foreach(Rank rank in Enum.GetValues(typeof(Rank)))
            {
                if(suit == Suits.Heart || suit == Suits.Diamond)
                {
                    Card card = new Card(Color.Red, suit, rank);
                    _cards.Add(card);
                }
                else
                {
                    Card card = new Card(Color.Black, suit, rank);
                    _cards.Add(card);
                }
            }
        }
    }

    public void AddCards(List<Card> cards)
    {
        if(cards !=null && cards.Count>0)
        {
            _cards.AddRange(cards);
        }
    }
    public void AddCard(Card card)
    {
        if(card!=null && !_cards.Contains(card))
        {
            _cards.Add(card);
        }
    }
    public void ClearDeck()
    {
        if(_cards.Count > 0)
        {
            _cards.Clear();
        }
    }
    public Card FetchTopCardFromDeck()
    {
        if(_cards.Count>0)
        {
            Card card = _cards.Last();
            _cards.Remove(card);
            return card;
        }
        throw new InvalidOperationException();
    }
    public List<Card> GetCards()
    {
        return _cards;
    }
}
