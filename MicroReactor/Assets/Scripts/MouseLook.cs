using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f; //private variable; keep track of rotation about x axis (look up&down)

    // Start is called before the first frame update
    void Start()
    {
        //hide and lock cursor to center of screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //find position of mouse, take into consideration sensitivity and frame rate of computer
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY; //each frame decrease x axis rotation by mouseY (if += instead, motion is flipped)
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //Clamping creates a boundary for looking up&down

        //quaternion responsible for rotation in Unity and input Euler angles (rotation for (x, y, z) axis)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //apply rotation about x axis (look up&down)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
