using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTest : MonoBehaviour
{

    public ParticleSystem particles;
    private GameManager gameManager;
    public int pointValue;
    //private bool pickedUp = false;
    private AudioSource audioSource;
    public float speed = 20f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            particles.Stop();
            Destroy(gameObject, 3);
            //gameManager.UpdateScore(1);
            gameManager.UpdateScore(pointValue);
            audioSource.Play();
        }
        else { 
            Destroy(gameObject, 7);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
