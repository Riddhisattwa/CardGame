# Card Game Requirements

## Confirmed Requirements

- The game uses a standard deck of 52 playing cards.
- The deck contains four suits: hearts, diamonds, clubs, and spades.
- Each suit contains 13 ranks: ace, 2 through 10, jack, queen, and king.
- Jokers are not included.

## Game Rules To Define

- Number of players
- Objective of the game
- Starting setup and how cards are dealt
- Player turn sequence and available actions
- How card ranks and suits affect play
- Scoring and winning conditions
- What happens when the deck runs out

## Example Rules By Game Type

These are separate rule templates. A game should select one type and define its options; the templates are not intended to be combined automatically.

### Trick-Taking

- Deal cards to each player. A player leads one card to begin a trick.
- Each other player plays one card, following the led suit when able. Define whether players who cannot follow suit may play any card or must play a trump card.
- The trick is won by the highest card in the led suit, unless a trump card is played; if so, the highest trump wins. Define rank order and whether a trump suit is used.
- The trick winner collects the cards and leads the next trick.
- End the round when all hands are empty. Score tricks or fulfill a declared contract, then determine the game winner using the selected scoring target.

### Shedding

- Deal a hand to each player and place the remaining cards in a draw pile. Start a discard pile with a legal opening card.
- On a turn, play a card that matches the required suit, rank, or other active condition. Define whether special cards change the condition or affect the next player.
- If a player has no legal play, they draw according to the game's draw rule; define whether a drawn legal card may be played immediately. Allow passing only if the rules permit it.
- The first player to empty their hand wins the round. Define any penalty or score based on cards left in opponents' hands.
- Define what happens when the draw pile is empty and no player can make a legal play.

### Set-Collection / Matching

- Deal starting hands and make a draw pile. Define which combinations count as a set, such as cards of equal rank or a sequence in one suit.
- On a turn, draw from the permitted source, then optionally reveal or lay down a qualifying set. Define whether cards may be taken from a shared display or requested from another player.
- Award points or collected cards for completed sets using the chosen scoring table.
- End the round when the draw pile is empty, a player has no cards, or a target score is reached; choose one condition and define how unfinished hands are scored.

### Hand-Comparison

- Deal the same number of cards to each player. Define whether players compare a single card or a multi-card hand.
- Reveal hands at the same time or in turn, then rank them using an explicit comparison order. Define tie-breaking rules.
- Award the round's pot or points to the highest-ranked hand. Define what happens to the pot on a tie.
- Repeat rounds until the deck or a fixed round count is exhausted, or until a player reaches the target score.

### Capture

- Deal hands and place a defined number of face-up cards in a shared table area.
- On a turn, play a card from hand. Define the exact condition for capturing table cards, such as matching rank or matching a card-value total.
- Move captured cards to the player's scoring pile. If no capture is possible, define whether the played card remains on the table.
- Refill hands from the draw pile when required. End when the draw pile and all hands are empty, then score captured cards or completed combinations.

### Solitaire

- Use one player. Define the layout, including tableau piles, stock, waste, and any foundations.
- Define legal moves explicitly, such as building a tableau sequence by descending rank and alternating color, or building a foundation by ascending rank within one suit.
- Define how cards are drawn from the stock and whether empty tableau spaces may be filled.
- Win when all cards reach the foundations. Define a loss or blocked state for when no legal moves remain and no further draw is available.

## Rule-Engine Details To Specify

- Rank ordering, including whether ace can be high, low, or both
- Turn order, legal actions, and any forced actions
- Card zones and movement rules, such as deck, hand, table, discard, and scoring pile
- Conditions that resolve a play, trick, set, capture, or tie
- Round-end conditions, scoring, and match-end conditions
- Whether each rule is fixed or configurable for a specific game variant
