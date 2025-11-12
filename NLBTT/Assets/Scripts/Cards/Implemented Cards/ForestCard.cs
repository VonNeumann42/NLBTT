using UnityEngine;

public class ForestCard : TerrainCard
{
    public ForestCard()
    {
        title = "Wald";
        canMoveOnto = true;
        staminaCost = 1; 
    }

    public override void OnPlayerEnter()
    {
    }
}