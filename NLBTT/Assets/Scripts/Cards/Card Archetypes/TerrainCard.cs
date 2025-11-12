using UnityEngine;

/// <summary>
/// Base class for terrain cards that affect stamina
/// </summary>
public abstract class TerrainCard : Card
{
    protected int staminaCost = 1;

    public int StaminaCost => staminaCost;

    public override void OnPlayerEnter()
    {
        ApplyStaminaCost();
    }

    protected virtual void ApplyStaminaCost()
    {
        // TODO: Access player/game manager to reduce stamina
        Debug.Log($"Terrain card reduces stamina by {staminaCost}");
    }
}