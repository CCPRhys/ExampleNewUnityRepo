using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    #region Variables

    public int[] STATS = new int[] { 8, 10, 12, 13, 14, 16};

    public int currentHealth;
    [SerializeField] int maxHealth = 12;

    #endregion

    enum CharacterClass
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Waarlock,
        Wizard,
        Artificer
    }


    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }

    public virtual void Die()
    {

    }
}
