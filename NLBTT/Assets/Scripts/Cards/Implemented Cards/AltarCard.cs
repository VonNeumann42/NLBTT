using UnityEngine;

/// <summary>
/// Altar card where players can store bloodpoints for safekeeping
/// The actual bloodpoint transfer logic is handled by the Player class
/// This class exists primarily as a type marker for position checking
/// </summary>
public class AltarCard : Card
{
    public AltarCard()
    {
        title = "Altar";
        canMoveOnto = true;
        turnedAround = true;
    }

    public override void OnPlayerEnter()
    {
        // No special trigger logic needed here
        // The Player class checks if they're standing on an AltarCard
        // and handles the bloodpoint storage UI/interaction
        
        Debug.Log("Player entered Altar card - bloodpoint storage available");
        
        // TODO: Optional - Show UI hint that bloodpoints can be stored here
        // Example: UIManager.Instance.ShowHint("Click bloodpoint tokens to store them at the altar");
    }
}