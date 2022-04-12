using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPosition : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    [SerializeField] Vector3 diff;

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.transform.position + diff;
    }
}
