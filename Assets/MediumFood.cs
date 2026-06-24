using UnityEngine;

public class MediumFood : ParentClassFood
{
    void Start()
    {
        Name = "MediumFood"; // Name of the child class (category of food)
        HealthImpact = 5; // The amount of effect the food has on health bar
        WeightImpact = 0; // The amount of effect the food has on weight bar
        HappinessImpact = 5; // The amount of effect the food has on happiness bar
    }
    
    private void OnTriggerEnter2D(Collider2D collision) // When 2d objects collides with the food object, it will check if object is the player and apply effects
    {
        if (collision.CompareTag("Player")) // Check if the colliding object has the tag "Player", which the tag is used for the maincharacter
        {
            Player1 player = collision.GetComponent<Player1>(); // It retrieves the Player1 component which is used to access the player's statistics

            if (player != null) // If the player component is found, apply the health, weight, and happiness impacts
            {
                player.health += HealthImpact; // Impacts player's health by this child class value
                player.weight += WeightImpact; // Impacts player's weight by this child class value
                player.happiness += HappinessImpact; // Impacts player's happiness by this child class value
            }
            Eat();
        }
    }
}
