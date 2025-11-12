using UnityEngine;

/// <summary>
/// Base class for blood point event cards
/// </summary>
public abstract class BloodPointEventCard : Card
{
    protected bool hasTriggered = false;

    public override void OnPlayerEnter()
    {
        if (!hasTriggered)
        {
            TriggerBloodPointEvent();
            hasTriggered = true;
        }
    }

    // Override this in specific card implementations
    protected abstract void TriggerBloodPointEvent();
}