using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private CharacterController controller;


    public float playerSpeed = 12.0f;
    public float rotationSpeed = 1500.0f;


    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }


    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        move.Normalize();
       

        Vector3 velocity = move * playerSpeed;

        controller.Move(velocity * Time.deltaTime);

        if (move != Vector3.zero)
        {
            Vector3 m = new Vector3(move.x, 0, move.z);
            Quaternion targetRotation = Quaternion.LookRotation(m, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        if (controller.isGrounded == false)
        {
            controller.Move(new Vector3(0, -0.05f, 0));
        }


    }
}
