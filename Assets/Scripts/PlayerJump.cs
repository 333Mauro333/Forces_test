using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerJump : MonoBehaviour
{
    [SerializeField] KeyCode jump = KeyCode.None;
    [SerializeField] float force = 0.0f;

    Rigidbody rb = null;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
