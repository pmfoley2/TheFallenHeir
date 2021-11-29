using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public GameObject Merchant;
    public NPC npc;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Merchant.GetComponent<DialogueManager>().curResponseTracker == 1)
        {
           
            
            if (Managers.Inventory.ConsumeItem("Money") == true)
            {
                Managers.Inventory.AddItem("health");
            }
        }

    }
   
}
