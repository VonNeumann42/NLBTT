using UnityEngine;

/// <summary>
/// Base class for complex event cards with choices and multiple outcomes
/// </summary>
public abstract class ComplexEventCard : Card
{
    protected bool hasTriggered = false;

    // Event text
    protected string eventTitle;
    protected string eventDescription;
    
    // Choice texts
    protected string choiceAText;
    protected string choiceBText;
    
    // Outcome texts
    protected string outcomeASuccessText;
    protected string outcomeAFailureText;
    protected string outcomeBSuccessText;
    protected string outcomeBFailureText;
    
    // Probabilities (0.0 to 1.0)
    protected float choiceASuccessProbability = 0.5f;
    protected float choiceBSuccessProbability = 0.5f;

    public override void OnPlayerEnter()
    {
        if (!hasTriggered)
        {
            // TODO: Show choice UI to player
            // For now, this would be called by UI system
            hasTriggered = true;
        }
    }

    // Called by UI when player selects Choice A
    public void SelectChoiceA()
    {
        float roll = Random.value;
        if (roll <= choiceASuccessProbability)
        {
            OnChoiceASuccess();
        }
        else
        {
            OnChoiceAFailure();
        }
    }

    // Called by UI when player selects Choice B
    public void SelectChoiceB()
    {
        float roll = Random.value;
        if (roll <= choiceBSuccessProbability)
        {
            OnChoiceBSuccess();
        }
        else
        {
            OnChoiceBFailure();
        }
    }

    // Getters for UI
    public string GetEventTitle() => eventTitle;
    public string GetEventDescription() => eventDescription;
    public string GetChoiceAText() => choiceAText;
    public string GetChoiceBText() => choiceBText;

    // Override these in specific card implementations
    protected abstract void OnChoiceASuccess();
    protected abstract void OnChoiceAFailure();
    protected abstract void OnChoiceBSuccess();
    protected abstract void OnChoiceBFailure();

    // Helper method to get outcome text for UI display
    public string GetOutcomeText(bool isChoiceA, bool isSuccess)
    {
        if (isChoiceA)
            return isSuccess ? outcomeASuccessText : outcomeAFailureText;
        else
            return isSuccess ? outcomeBSuccessText : outcomeBFailureText;
    }
}