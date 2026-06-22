using UnityEngine;

public class MediumFood : ParentClassFood
{
    void Start()
    {
        Name = "MediumFood";
        HealthImpact = 5;
        WeightImpact = 0;
        HappinessImpact = 5;
    }
    
    private void OnTriggerEnter2D(Collider2D collision) // When 2d objects collides with the food object, it will check if object is the player and apply effects
    {
        if (collision.CompareTag("Player")) // Check if the colliding object has the tag "Player"
        {
            Player1 player = collision.GetComponent<Player1>();

            if (player != null) // If the player component is found, apply the health, weight, and happiness impacts
            {
                player.health += HealthImpact;
                player.weight += WeightImpact;
                player.happiness += HappinessImpact;
            }
            Eat();
        }
    }
}
