using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    private Vector3 velocity;
    private Rigidbody body;

    void Start()
    {
        this.body = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 v)
    {
        this.velocity = v;
    }

    public void LookAt(Vector3 lookPoint)
    {
        transform.LookAt(lookPoint);
    }

    public void FixedUpdate()
    {
        this.body.MovePosition(body.position + velocity * Time.fixedDeltaTime);
    }
}
