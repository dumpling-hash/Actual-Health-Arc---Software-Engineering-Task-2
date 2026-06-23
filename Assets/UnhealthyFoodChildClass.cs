using UnityEngine;

public class UnhealthyFoodChildClass : ParentClassFood
{
        void Start()
        {
            Name = "UnhealthyFood";
            HealthImpact = -10;
            WeightImpact = 10;
            HappinessImpact = 15;
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player1 player = collision.GetComponent<Player1>();
            if (player != null)
            {
                player.health += HealthImpact;
                player.weight += WeightImpact;
                player.happiness += HappinessImpact;
            }
            Eat();
        }
    }
    public override void Eat()
    {
        Debug.Log($"You eat unhealthy food, your health is now {HealthImpact}, your happiness is {HappinessImpact}, and you gained {WeightImpact} weight.");
        base.Eat();
    }
}

