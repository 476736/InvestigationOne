using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Basic movement controls
    public int jumpConst = 0;

    private bool canJump;
    private Rigidbody selfRigidbody;

    public bool isGrounded;
    void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        MovementFunc();
        Jumping();

    }

    private void Jumping()
    {
        if (Input.GetKeyUp(KeyCode.Space) && isGrounded)
        {
            selfRigidbody.AddForce(0,jumpConst, 0, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void MovementFunc()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.back * 3);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.forward * 3);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.left * 3);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.right * 3);
    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
