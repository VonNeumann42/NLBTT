using UnityEngine;

public class RockCard : TerrainCard
{
    public RockCard()
    {
        title = "Felsen";
        canMoveOnto = false;
        staminaCost = 0; 
    }

    public override void OnPlayerEnter()
    {
    }
}