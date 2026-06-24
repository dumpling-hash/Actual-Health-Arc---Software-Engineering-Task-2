using UnityEngine;

public class UnhealthyFoodChildClass : ParentClassFood // Inheriting characteristics from ParentClassFood
{
        void Start() // Starts the function
        {
            Name = "UnhealthyFood"; // Name of the child class
            HealthImpact = -10; // How the child class impact health
            WeightImpact = 10; // How the child class impacts weight
            HappinessImpact = 15; // How the child class impacts happiness
        }
    private void OnTriggerEnter2D(Collider2D collision) // Triggers function when player collides with object
    {
        if (collision.CompareTag("Player")) // Ensures the object collides with player
        {
            Player1 player = collision.GetComponent<Player1>(); // Retrieves the Player1 component from object
            if (player != null) // Checks if the player component exists
            {
                player.health += HealthImpact; // Impacts player's health stats by the child class's value
                player.weight += WeightImpact; // Impacts player's weight stats by the child class's value
                player.happiness += HappinessImpact; // Impacts player's happiness stats by the child class's value
            }
            Eat(); // Eats the object and removes it
        }
    }
    public override void Eat() // Overrides the parent class's eat function to display a unique message
    {
        Debug.Log($"You eat unhealthy food, your health is now {HealthImpact}, your happiness is {HappinessImpact}, and you gained {WeightImpact} weight."); 
        // Displays the child class's unique consumption message
        base.Eat(); // Uses the parent class's script to destroy objec after consumption
    }
}

