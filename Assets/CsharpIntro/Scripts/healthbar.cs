using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Scrollbar HealthBar;

    [SerializeField] int Health = 10;
    [SerializeField] int Damage = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //healthbar.
    }

    // Update is called once per frame
    void Update()
    {
        int currenthealth = Damage/Health;

    }
}
