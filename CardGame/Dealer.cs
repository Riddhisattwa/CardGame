using System;

namespace CardGame;

public class Dealer
{
    private Deck _deck;
    private IShuffleStrategy _shuffleStrategy;

    public Dealer(Deck deck, IShuffleStrategy shuffleStrategy)
    {
        _shuffleStrategy = shuffleStrategy;
        _deck = deck;
    }
    public void ShuffleCards()
    {
        _shuffleStrategy.Shuffle();
    }

    public Card FetchTopCardFromDeck()
    {
        return _deck.FetchTopCardFromDeck();
    }

    public void DealCard(Card card, Person currentPlayer)
    {
        Hand currentHand = currentPlayer.GetHand();
        currentHand.Add(card);
    }
}
