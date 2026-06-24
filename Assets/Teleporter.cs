using UnityEngine;

public class Teleporter : MonoBehaviour // Sets teleporter class and allows it to be assigned to objects
{
    public Transform destination; // Sets the location the player will be teleported to

    private void OnTriggerEnter2D(Collider2D other) // Triggers the teleportation function when the player collides with object 
    {
        if (other.CompareTag("Player")) // Ensures the object collides with player
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
            // Teleports the player to set destination, throough x and y coodinates
            Debug.Log("Welcome to a new Continent!"); // Prints the welcome message in the console after the player is teleported to a different continent level
        }
    }
}
