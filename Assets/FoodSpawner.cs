using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject[] foodPrefabs; // Array of food prefabs to spawn
    private GameObject currentFood; // Remembers the current food on the ground (making sure the food doesnt change)
    public float timer = 0f; // A timer to keep track of when the last food was spawned
    public float timeBetweenSpawns = 3f; // The amount of time between each spawn

    void Update()
    {
        if (currentFood == null) // If there is no food on the ground, spawn a new one
        {
            timer = timer + Time.deltaTime; // Increase the timer by the amount of time that has passed since the last frame
            
            if (timer >= timeBetweenSpawns) // If the timer has reached the time between spawns, spawn a new food
            {

            int randomNum = Random.Range(0, foodPrefabs.Length); // Picks random food
            currentFood = Instantiate(foodPrefabs[randomNum]); // Spawn the food and save it to currentFood
            currentFood.transform.position = transform.position; // Move that food exactly to the spawner's spot
            timer = 0f; // Reset the timer
        }
    }
}
}
