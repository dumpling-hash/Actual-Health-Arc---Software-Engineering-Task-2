using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform destination; // Where the player will be teleported to

    private void OnTriggerEnter2D(Collider2D other) // When player touches teleporter, this will run:
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = destination.position; // Move the player to destination
            Debug.Log("Welcome to a new Continent!"); // Print message to console when player teleports
        }
    }
}
