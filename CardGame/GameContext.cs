using System;

namespace CardGame;

public class GameContext
{
    private Dealer _dealer;
    private Game _game;
    private List<Person> _players;

    public GameContext(Dealer dealer, Game game, List<Person> players)
    {
        _dealer = dealer;
        _game = game;
        _players = players;
    }
    public void ChangeGame(Game game)
    {
        _game = game;
    }
    public void StartRound()
    {
        //Printing player names
        Console.WriteLine("Players in the game------------");
        foreach(Person player in _players)
        {
            Console.WriteLine(player.GetName());
        }
        Console.WriteLine("Game starting-------------");
        _game.RunHands(_players,_dealer);
        Person? winner = _game.EvaulateWinner(_players);
        if(winner!=null)
        {
            Console.WriteLine("Winner is {0}",winner.GetName());
        }
        else
        {
            Console.WriteLine("No winner");
        }
    }
}
