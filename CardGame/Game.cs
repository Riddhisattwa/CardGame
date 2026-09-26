using System;

namespace CardGame;

public abstract class Game
{
    public abstract void RunHands(List<Person> players, Dealer dealer);
    public abstract Person? EvaulateWinner(List<Person> players);
}
