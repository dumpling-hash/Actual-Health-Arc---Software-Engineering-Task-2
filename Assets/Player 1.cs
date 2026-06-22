using UnityEngine;
using UnityEngine.UI;

/* Child class inheriting behaviour from GameCharacter (parent class)
------- Player 1 ---------*/
public class Player1 :GameCharacter
{
    // Linking each UI slider to the script
    public Slider healthslider; 
    public Slider happinessslider; 
    public Slider weightslider; 
protected virtual void Start()
{
    // Set the character name - inheriting CharacterName from parent class and changes in player(child) class
    characterName = "Player 1";
  
    // Display starting health
    Debug.Log(characterName + " Health: " + health);
}

protected override void Update()
{
    if (health >= 100 && happiness >=100 && weight <=50)
    {
        Debug.Log("You have completed the game, good job!");
    }
    // Runs parent movement and jumping
    base.Update();
    // Update UI sliders
    if (healthslider != null)
        healthslider.value = health;
    if (happinessslider != null)
        happinessslider.value = happiness;
    if (weightslider != null)
        weightslider.value = weight;

    // Player Attack
    if (Input.GetKeyDown(KeyCode.F))
    {
        Attack();
    }
}

// Attack Funtion run when player 1 touches enmy 
public override void Attack()
    {
        //display message saying player attacked
        Debug.Log(characterName + " attacked!");
    }
  
public override void TakeDamage(int damage)
        {
            // Reduce health by damage amount
            health -= damage;
  
            // Print updated health to console
            Debug.Log("Player health decreased: " + health);
  
            // Check if player is dead
            if (health <= 0)
            {
                Debug.Log("Game Over");
            }
    }
}




