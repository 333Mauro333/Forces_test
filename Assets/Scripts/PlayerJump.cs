using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerJump : MonoBehaviour
{
    [SerializeField] KeyCode jump = KeyCode.None;
    [SerializeField] float force = 0.0f;
    [SerializeField] bool canJump = true;

    Rigidbody rb = null;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (canJump && Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {

    }
}
