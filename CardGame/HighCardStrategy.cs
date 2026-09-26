using System;

namespace CardGame;

public class HighCardStrategy : Game
{
    public override Person? EvaulateWinner(List<Person> players)
    {
        return players.MaxBy(p => p.GetHand().GetCards().First().Rank);
    }

    public override void RunHands(List<Person> players, Dealer dealer )
    {
        dealer.ShuffleCards();
        foreach(Person player in players)
        {
            dealer.DealCard(dealer.FetchTopCardFromDeck(), player);
        }
    }
}
