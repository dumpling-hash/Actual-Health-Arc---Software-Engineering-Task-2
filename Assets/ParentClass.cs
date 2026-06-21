
// Import the Unity game engine library so we can use Unity features

using UnityEngine;

// GameCharacter class inherits from MonoBehaviour,
// allowing it to be attached to a GameObject in Unity
public class GameCharacter : MonoBehaviour
{
  
//Variable List
public string characterName= "test";
public int health = 100; // Player's current health
public int happiness = 100; // Player's current happiness
public int weight = 50; // Player's current weight
public float speed = 5f; // How fast the player moves
public bool isJumping = false; // Tracks if the player is currently jumping
// Jump settings (simple non‑physics jump)
public float jumpHeight = 2f; // How high the jump moves the player
public float jumpTime = 0.25f; // How long the jump lasts
private float jumpTimer = 0f; // Tracks jump progress

// Update runs once every frame (constantly repeating)
// =========================
// Update() runs once every frame while the game is playing

protected virtual void Update()
{
    // Call the Move method every frame so the character can respond to player input
    Move();
    Debug.Log(Input.GetAxis("Vertical"));
    // Check if the space key is pressed THIS frame
    if (Input.GetKeyDown(KeyCode.Space))
    {
    // Call the Jump method when space is pressed
        StartJump();
    }
        if(isJumping)
    {
        PerformJump();
    }
}
  
// Method responsible for moving the character
    protected virtual void Move()
    {
    // Read horizontal input from the keyboard (A = -1, D = +1)
    float moveX = Input.GetAxis("Horizontal"); // A / D
  
    // Read vertical input from the keyboard (W = +1, S = -1)
    float moveY = Input.GetAxis("Vertical"); // W / S
  
    // Combine the X and Z input values into a single movement direction
    Vector2 movement = new Vector2(moveX, moveY);
  
    // Move the player in world space so rotation does not affect movement direction
    // Multiply by speed and Time.deltaTime to make movement smooth and frame‑rate independent
    transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
  
// BEHAVIOUR METHOD: JUMP
// This makes the player jump (simple version)
    void StartJump()
    {
    // Only allow jumping if the player is NOT already jumping
        if (!isJumping)
        {
        isJumping = true; // change state to jumping
        jumpTimer=0f; //reset timer
  
        // Print message in the Unity Console
        Debug.Log("Player Jumped!");
  
        // NOTE: In a full game, you'd add physics force here
        }
    }
  
// BEHAVIOUR METHOD: TAKE DAMAGE
// This reduces the player's health when called
    public virtual void TakeDamage(int damage)
    {
    // Reduce health by damage amount
    health -= damage;
  
    // Print updated health to console
    Debug.Log("Player health: " + health);
  
    // Check if player is dead
        if (health <= 0)
        {
            Debug.Log("Player is dead!");
        }
    }
  

    // PERFORM JUMP — simple upward motion
    protected virtual void PerformJump()
    {
    // Increase timer
    jumpTimer += Time.deltaTime;
  
    // Move the player upward at a constant speed
    // No physics just simple translation
    float upwardSpeed = jumpHeight / jumpTime;

    if(jumpTimer <jumpTime /2)
        {
            transform.Translate(Vector2.up * upwardSpeed * Time.deltaTime);
        }
    else
        {
            transform.Translate(Vector2.down * upwardSpeed * Time.deltaTime);
    }
    // Stop the jump when time is up
    if (jumpTimer >= jumpTime)
        {
            isJumping = false;
            Debug.Log("Jump ended!");
        }
    }
  
    //Attack Function - Display attacks!
    public virtual void Attack()
    {
        Debug.Log(characterName + " attacks!");
    }
  
}
