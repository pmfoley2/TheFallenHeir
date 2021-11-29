using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public Healthbar healthbar;
    public int currHealth;
    private GameMaster gm;
    public Transform player;
    private bool alive;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = Mathf.Clamp(currHealth, 0, 100);
        currHealth = maxHealth;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckpointPos;
        alive = true;
    }

    void Update()
    {
        CheckAlive(alive);
    }

    public void TakeDamage(int damage)
    {
        currHealth -= damage;
        healthbar.UpdateHealth((float)currHealth / (float)maxHealth);
        Debug.Log("current health left " + currHealth);
        if (currHealth <= 0)
        {
            alive = false;

            
           
        }
    }
    public void CheckAlive(bool alive)
    {
        if (alive == false)
        {
            player.position = gm.lastCheckpointPos;
            currHealth = maxHealth;
            alive = true;

        }
    }
    public void ChangeHealth(int value)
    {
        currHealth += value;
        if (currHealth > maxHealth)
        {
            currHealth = maxHealth;
        }
        else if (currHealth < 0)
        {
            currHealth = 0;
        }
        healthbar.UpdateHealth((float)currHealth / (float)maxHealth);

        Debug.Log("Health: " + currHealth + "/" + maxHealth);
    }
}

