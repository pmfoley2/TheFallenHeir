using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth = 100;
    public Healthbar healthbar;
    private int currHealth;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currHealth -= damage;
        healthbar.UpdateHealth((float)currHealth / (float)maxHealth);

        if (currHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
