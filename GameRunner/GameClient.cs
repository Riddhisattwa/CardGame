using System;
using CardGame;
namespace GameRunner;

public class GameClient
{
    public static void Main()
    {
        Deck deck = new Deck();
        Dealer dealer = new(deck, new FisherYatesShuffleStrategy(deck.GetCards()));
        List<Person> players = new List<Person>{new("Alice"),new("Bob"),new("Gary")};

        GameContext context = new GameContext(dealer,new HighCardStrategy(),players);
        context.StartRound();


    }
}
