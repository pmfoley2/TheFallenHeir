using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int playerDamage = 20;
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
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(Vector3.right * 270);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Character>().TakeDamage(playerDamage);
    }
}
