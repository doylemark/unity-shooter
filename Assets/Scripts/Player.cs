using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    private PlayerController controller;
    private GunController gunController;
    private Camera viewCamera;
    void Start()
    {
        this.viewCamera = Camera.main;
        this.controller = GetComponent<PlayerController>();
        this.gunController = GetComponent<GunController>();
    }

    // Update is called once per frame
    void Update()
    {
        var moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        var moveVelocity = moveInput.normalized * this.moveSpeed;
        controller.Move(moveVelocity);

        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, transform.position);
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance))
        {
            Vector3 point = ray.GetPoint(rayDistance);
            // Debug.DrawLine(ray.origin, point, Color.red);
            controller.LookAt(point);
        }

        if (Input.GetMouseButton(0))
        {
            this.gunController.Shoot();
        }
    }
}
