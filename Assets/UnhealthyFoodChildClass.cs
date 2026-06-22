using UnityEngine;

public class UnhealthyFoodChildClass : ParentClassFood
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Eat();
        }
    }
    public override void Eat()
    {
        HealthImpact = -10;
        HappinessImpact = 15;
        WeightImpact = 10;

        Debug.Log($"You eat unhealthy food, your health is now {HealthImpact}, your happiness is {HappinessImpact}, and you gained {WeightImpact} weight.");
        base.Eat();
    }
}

