using UnityEngine;
using TMPro;

public class CharacterBase : MonoBehaviour
{
    public enum CharacterClass
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
        Warlock,
        Wizard,
        Artificer
    }
    #region Variables

    public CharacterClass characterClass;
    public int[] STATS = new int[] { 8, 10, 12, 13, 14, 16};

    public int currentHealth;
    [SerializeField] int maxHealth = 12;

    #endregion



    void Start()
    {

        if (characterClass == CharacterClass.Barbarian)
        {
            maxHealth = 12 + STATS[3];
        }
        else if (characterClass == CharacterClass.Fighter || characterClass == CharacterClass.Paladin || characterClass == CharacterClass.Ranger)
        {
            maxHealth = 10 + STATS[3];
        }
        else if (characterClass == CharacterClass.Artificer || characterClass == CharacterClass.Bard || characterClass == CharacterClass.Cleric || characterClass == CharacterClass.Druid || characterClass == CharacterClass.Monk || characterClass == CharacterClass.Rogue || characterClass == CharacterClass.Warlock)
        {
            maxHealth = 8 + STATS[3];
        }
        else if (characterClass == CharacterClass.Sorcerer || characterClass == CharacterClass.Wizard)
        {
            maxHealth = 6 + STATS[3];
        }

            currentHealth = maxHealth;
    }

    void Update()
    {
        
    }

    public virtual void Die()
    {

    }
}
