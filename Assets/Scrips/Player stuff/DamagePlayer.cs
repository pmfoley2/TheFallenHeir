using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int damage = 25;
    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
}
