using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.0f;

    Rigidbody rb = null;
    Vector3 v3;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        v3 = Vector3.zero;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement();
    }


    void Movement()
    {
        float f = Input.GetAxis("P1VerticalAxis");
        float r = Input.GetAxis("P1HorizontalAxis");

        Vector3 movement = new Vector3();

        movement.z = f * speed;
        movement.x = r * speed;

        rb.AddForce(movement);
    }
}