using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/Player Movement")]

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;
    public float dashDistance = 15f;
    private CharacterController _charController;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;
        
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);


        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.W))
        {
            player.position += player.TransformDirection(Vector3.forward) * dashDistance;

        }
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.A))
        {
            player.position += player.TransformDirection(Vector3.left) * dashDistance;


        }
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.D))
        {
            player.position += player.TransformDirection(Vector3.right) * dashDistance;


        }
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.S))
        {
            player.position += player.TransformDirection(Vector3.back) * dashDistance;


        }
    }

    


}
