using UnityEngine;

public class Teleporter : MonoBehaviour // Sets teleporter class and allows it to be assigned to objects
{
    public Transform destination;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensures the object collides with player
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
            Debug.Log("Welcome to a new Continent!");
        }
    }
}
