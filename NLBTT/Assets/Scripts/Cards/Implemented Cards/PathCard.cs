using UnityEngine;

public class PathCard : TerrainCard
{
    public PathCard()
    {
        title = "Pfad";
        canMoveOnto = true;
        staminaCost = 0; 
    }

    public override void OnPlayerEnter()
    {
    }
}