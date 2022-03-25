using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CarController : MonoBehaviour
{
    public float speed = 1500;
    public float rotation = 10f;
    public float rotationSpeed = 15f;
    private float movement = 0f;
    public float fuel = 100f;
    public float fuelConsumption = 10f;

    public Rigidbody2D rb;
    public WheelJoint2D backTire;
    public WheelJoint2D frontTire;

    // Update is called once per frame
    void Update()
    {
        movement = -Input.GetAxis("Horizontal") * speed;
        Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        if (fuel == 0)
        {
            backTire.useMotor = false;
            frontTire.useMotor = false;
        }
        else if (fuel > 0 && movement != 0)
        {
            backTire.useMotor = true;
            frontTire.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backTire.motor = motor;
            frontTire.motor = motor;
        }

        rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
        fuel -= fuelConsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }
}