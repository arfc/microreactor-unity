using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    //GroundCheck creates a sphere around a point used here to check for ground
    public Transform GroundCheck; //variables to reset velocity   vvv
    public float groundDistance = 0.4f; //radius of sphere with GroundCheck
    public LayerMask groundMask; //control which objects the sphere checks for
    bool isGrounded; //boolean with state

    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        //check if grounded, complete a physics check
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

        //reset velocity in y direction so it doesn't keep adding up
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //not 0 in case isGrounded registers before player is fully grounded
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //this moves using global coordinates, no direction player is facing
        //Vector3 move = new Vector3(x, 0f, z);

        //create direction to move based on x and z movement and with player face direction
        Vector3 move = transform.right * x + transform.forward * z;

        //move in direction of move vector w/ speed of player; independent of frame rate
        controller.Move(move * speed * Time.deltaTime);

        
        //JUMPING
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //v=sqrt(h*-2*g)
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        

        //free fall: change y = 1/2g*t^2
        velocity.y += gravity * Time.deltaTime; //g*t
        controller.Move(velocity * Time.deltaTime); //*t
    }
}
