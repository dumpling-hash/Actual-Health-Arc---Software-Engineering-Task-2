using UnityEngine;

public class ParentClassFood
{
    public string Name { get; set; }
    public int HealthImpact { get; set; }
    public int Calories { get; set; }
    public int HappinessImpact { get; set; }

    public ParentClassFood(string name, int healthImpact, int calories, int happinessImpact)
    {
        Name = name;
        HealthImpact = healthImpact;
        Calories = calories;
        HappinessImpact = happinessImpact;
    }

    public virtual void Eat()
    {
        Debug.Log($"You eat {Name}, and it contains {Calories} calories, it impacts your health by {HealthImpact} and your happiness by {HappinessImpact}.");
    }
}
