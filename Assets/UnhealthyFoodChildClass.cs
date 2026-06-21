using UnityEngine;

public class UnhealthyFoodChildClass : ParentClassFood
{
    public int healthImpact = -10;
    public int happinessImpact = 15;
    public int calories = 10;

    public void EatUnhealthyFood()
    {
        Debug.Log($"You eat unhealthy food, your health is now {healthImpact}, your happiness is {happinessImpact}, and you ate {calories} calories of food.");
    }
}
a