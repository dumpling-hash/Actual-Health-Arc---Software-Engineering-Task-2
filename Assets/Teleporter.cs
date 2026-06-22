using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform destination;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
            Debug.Log("Welcome to a new Continent!");
        }
    }
}
