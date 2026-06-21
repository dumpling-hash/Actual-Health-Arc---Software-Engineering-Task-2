using UnityEngine;

public class ParentClassFood : MonoBehaviour
{
    public string Name;
    public int HealthImpact ;    
    public int Calories;
    public int HappinessImpact;

    public virtual void Eat()
    {
        Debug.Log($"You eat {Name}, and it contains {Calories} calories, it impacts your health by {HealthImpact} and your happiness by {HappinessImpact}.");

        Destroy(gameObject);
    }
}
