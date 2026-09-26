using System;

namespace CardGame;

public class FisherYatesShuffleStrategy : IShuffleStrategy
{
    private List<Card> _cards;
    public FisherYatesShuffleStrategy(List<Card> cards)
    {
        _cards = cards;
    }
    public void Shuffle()
    {
        int i=_cards.Count-1;
        while(i>=0)
        {
            int val = Random.Shared.Next(0,i);
            Card card = _cards[val];
            _cards[val] = _cards[i];
            _cards[i] = card;
            i--;
        }
    }
}
