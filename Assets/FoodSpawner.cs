using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject[] foodPrefabs; // Array of food prefabs to spawn
    private GameObject currentFood; // Remembers the current food on the ground (making sure the food doesnt change)
    public float timer = 0f;
    public float timeBetweenSpawns = 3f;

    void Update()
    {
        if (currentFood == null) // If there is no food on the ground, spawn a new one
        {
            timer = timer + Time.deltaTime; // Increment the timer by the time since the last frame
            
            if (timer >= timeBetweenSpawns) // If the timer has reached the time between spawns, spawn a new food
            {

            int randomNum = Random.Range(0, foodPrefabs.Length); // Picks random food
            currentFood = Instantiate(foodPrefabs[randomNum], transform.position, transform.rotation); // Spawn new random food and saves it to the current food  as shown in line 7
            timer = 0f; // Reset the timer
        }
    }
}
}
