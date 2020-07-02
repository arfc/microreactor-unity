using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float directedForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("d")) //move right
        {
            rb.AddForce(directedForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) //move left
        {
            rb.AddForce(-directedForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w")) //move forward
        {
            rb.AddForce(0,0,directedForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s")) //move backward
        {
            rb.AddForce(0, 0, -directedForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
