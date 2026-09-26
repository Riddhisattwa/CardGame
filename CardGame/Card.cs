using System;

namespace CardGame;

public class Card
{
    private readonly Color _color;
    private readonly Suits _suits;
    private readonly Rank _rank;

    public Card(Color color, Suits suits, Rank rank)
    {
        _color = color;
        _suits = suits;
        _rank = rank;
    }
    public Rank Rank
    {
        get => _rank;
    }
}
