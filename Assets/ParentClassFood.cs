using UnityEngine;

public class ParentClassFood : MonoBehaviour // Sets the characteristics of the parent class to be inherited by the food child classes
{
    public string Name; // Name of the food
    public int HealthImpact; // Food's impact on health
    public int WeightImpact; // Food's impact on weight
    public int HappinessImpact; // Food's impact on happiness

    public virtual void Eat() // Defailt eat function that can be overriden by child classes to display unique messages
    {
        Debug.Log($"You eat {Name}, and it you gain {WeightImpact} weight, it impacts your health by {HealthImpact} and your happiness by {HappinessImpact}."); 
        // Prints the default message after eating food in the console, displaying it's impact on health, happiness, and weight.
        Destroy(gameObject); // Destroys the food object after consumption
    }
}
