using UnityEngine;

public class SwampCard : TerrainCard
{
    public SwampCard()
    {
        title = "Sumpf";
        canMoveOnto = true;
        staminaCost = 2; 
    }

    public override void OnPlayerEnter()
    {
    }
}