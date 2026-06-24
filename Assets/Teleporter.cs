using UnityEngine;

public class Teleporter : MonoBehaviour 
{
    public Transform destination; // Sets the location the player will be teleported to

    private void OnTriggerEnter2D(Collider2D other) // It activates the teleporter, once the player collides with the hitbox
    {
        if (other.CompareTag("Player")) // Ensures the player collides with the teleporter
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
            // Sets the player's position to the coordinates of the destination, being the other side of the teleporter
            Debug.Log("Welcome to a new Continent!"); // Prints the welcome message in the console after the player is teleported to a different continent level
        }
    }
}
