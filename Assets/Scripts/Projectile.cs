using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float speed = 10;

    public void SetSpeed(float newSpeed)
    {
        this.speed = newSpeed;
    }

    public void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
