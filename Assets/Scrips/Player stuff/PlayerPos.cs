using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
    public Transform player;
    
    
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckpointPos;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            player.position = gm.lastCheckpointPos;
        }
    }
}
