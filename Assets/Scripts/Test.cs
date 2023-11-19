using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Adjust the speed for the application
    public float movementSpeed = 20.0f;
    public float rotationSpeed = 40.0f;
    public Color colour = Color.white;
    Vector3 direction = Vector3.left;
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Wayne");
        Debug.Log("123.321");
        Debug.Log(gameObject.name);

        gameObject.GetComponent<Renderer>().material.color = colour;
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position += Vector3.up * Time.deltaTime;
        ////gameObject.transform.position += Vector3.down * Time.deltaTime;
        //gameObject.transform.position += Vector3.left * Time.deltaTime;
        ////gameObject.transform.position += Vector3.right * Time.deltaTime;

        //gameObject.transform.Translate((direction * speed) * Time.deltaTime);

        //gameObject.transform.Translate((Vector3.up * movementSpeed)
        //    * Time.deltaTime);
        
        //gameObject.transform.Rotate((new Vector3(0, 0, 10) * rotationSpeed)
        //    * Time.deltaTime);

        //gameObject.transform.Rotate((new Vector3(0, 0, 10f) * rotationSpeed)
        //    * Time.deltaTime);

        /*transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        Debug.Log(gameObject.transform.position);*/

        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * movementSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);



        // Get the mouse delta. This is not in the range -1...1
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        //transform.Rotate(v, h, 0);


        //// Returns true while the key is held down
        //Input.GetKey(KeyCode.A);
        //// Returns true during the frame the key is pressed
        //Input.GetKeyDown(KeyCode.A);
        //// Returns true during the frame the key is released
        //Input.GetKeyUp(KeyCode.A);

        //if (Input.GetKey(KeyCode.A))
        //{
        //    // Handle user input
        //}

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = -Input.GetAxis("Horizontal");

        gameObject.transform.Translate(
            (
                (Vector3.left * verticalInput)
                * movementSpeed)
                * Time.deltaTime            
            );

        gameObject.transform.Rotate(
            (
                (new Vector3(0, 0, 10) * rotationSpeed)
                * horizontalInput)
                * Time.deltaTime
            );

    }
}