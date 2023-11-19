using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hooks : MonoBehaviour
{

    bool addColour = false;
    //public GameObject flashing_Label;
    private float interval;
    private int health;
    public int healValue = 3;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Enter");
        gameObject.GetComponent<Renderer>().material.color = Color.green;

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().HealPlayer(healValue);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exit");
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Trigger Stay");
        if (gameObject.GetComponent<Renderer>().material.color.a >= 1f)
        {
            addColour = false;
        }

        if (gameObject.GetComponent<Renderer>().material.color.a <= 0f) 
        {
            addColour = true;
        }

        if (addColour == true)
        {
            gameObject.GetComponent<Renderer>().material.color += new Color(0, 0, 0, 0.05f);
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.05f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Enter: " + collision.gameObject.CompareTag("Player"));
    }

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.1f);
       // InvokeRepeating("FlashLabel", 0, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FlashLabel()
    {
        /*if (flashing_Label.activeSelf)
            flashing_Label.SetActive(false);
        else
            flashing_Label.SetActive(true);*/
    }

}
