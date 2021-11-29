using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaPit : MonoBehaviour
{
    private GameMaster gm;
    public Transform player;


    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        player.position = gm.lastCheckpointPos;
    }
}
