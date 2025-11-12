using UnityEngine;

/// <summary>
/// Base class for all cards in the game
/// </summary>
public abstract class Card
{
    protected string title;
    protected bool canMoveOnto = true;
    protected bool turnedAround = true;

    protected bool allowedForShuffle = true;

    public string Title => title;
    public bool CanMoveOnto => canMoveOnto;
    public bool TurnedAround => turnedAround;

    // Called when player moves onto this card
    public abstract void OnPlayerEnter();

    public virtual void TurnOver()
    {
        turnedAround = false;
    }
}

