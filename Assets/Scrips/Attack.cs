using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float playerDamage = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(Vector3.right *90 );
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<EnemyAI>().TakeDamage(playerDamage);
    }
}
