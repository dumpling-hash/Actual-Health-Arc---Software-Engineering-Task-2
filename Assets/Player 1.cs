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
    public GameObject winScreen; // Game object for win screen UI
    public GameObject loseScreen; // Game object for lose screen UI
protected virtual void Start()
{
    // Set the character name - inheriting CharacterName from parent class and changes in player(child) class
    characterName = "Player 1";
  
    // Display starting health
    Debug.Log(characterName + " Health: " + health);
}

protected override void Update()
{
    health = Mathf.Clamp(health, 0, 100); // Ensure health stays between 0 and 100
    happiness = Mathf.Clamp(happiness, 0, 100); // Ensure happiness stays between 0 and 100
    weight = Mathf.Clamp(weight, 0, 100); // Ensure weight stays between 0 and 100

    if (health >= 100 && happiness >=100 && weight <=50)
    {
        WinGame();
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
            if (health <= 0 && happiness <= 0 && weight >= 100 && weight <=0)
            {
                LoseGame();
            }
    }

    void LoseGame()
    {
        Time.timeScale = 0f; // Pause the game
        if (loseScreen != null)
        {
            loseScreen.SetActive(true); // Show lose screen
        }
    }
    void WinGame()
    {
        Time.timeScale = 0f; // Pause the game
        if (winScreen != null)
        {
            winScreen.SetActive(true); // Show win screen
        }
    }


}





