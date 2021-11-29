using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int EnemyDamage = 20;
    

    // Update is called once per frame
    

    void OnCollisionEnter(Collision other)
    {
       
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(EnemyDamage);
       
    }
}