using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float maxSpeed = 5;
    public float maxRotationSpeed = 5;
    private int health;
    //public AudioSource audioSource;
    public GameObject prefabs;

    public int damageValue = 1;

    private Rigidbody2D rb2d;
    private Vector2 initialVelocity;

    // Start is called before the first frame update
    void Start()
    {
        float speedX, speedY, rotate;

        rb2d = GetComponent<Rigidbody2D>();

        speedX = Random.Range(-maxSpeed, maxSpeed);
        speedY = Random.Range(-maxSpeed, maxSpeed);
        rotate = Random.Range(-maxRotationSpeed, maxRotationSpeed);

        initialVelocity = new Vector2(speedX, speedY);

        rb2d.AddForce(initialVelocity, ForceMode2D.Impulse);
        rb2d.AddTorque(rotate);
        
        //audioSource = GetComponent<AudioSource>();
    }

    //The Asteroids's RecieveDamage method
    public void RecieveDamage(int damage)
    {
        health -= damage;
            Debug.Log("Explosion");
        if (health <= 0)
        {
            Destroy(gameObject);
            //audioSource.PlayOneShot(audioSource.clip);
            Instantiate(prefabs, gameObject.transform.position, Quaternion.identity);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damageValue);
        }
    }

}