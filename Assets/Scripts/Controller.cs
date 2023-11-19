using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody2D rb2d;
    Vector2 direction = Vector2.zero;
    public float thrustSpeed = 20.0f;
    public float turnSpeed = 35.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb2d.AddTorque(float torqueValue);
        //rb2d.AddRelativeForce(Vector2 forceValue);

        //Retrive the horizontal and vertical inputs
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Calculate the thrust value, using the Y input and thrustSpeed
        Vector2 thrust = new Vector2(0, inputY * thrustSpeed);
        //Calculate the rotate value, using the X input and turnSpeed
        float rotate = -inputX * turnSpeed;

        //Add torque (steering) using the rigidbody
        rb2d.AddTorque(rotate);
        //Add relative force (thurst) using the rigidbody
        rb2d.AddRelativeForce(thrust);
    }
}
