using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float FireForce = 100f;

    public int damageValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * FireForce);
        // After 2 seconds, destroy the bullet (just in case)
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            collision.gameObject.GetComponent<Asteroid>().RecieveDamage(damageValue);
            // Deal damage to the asteroid
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            // Deal damage to the enemy
        }

        // Always destroy the bullet last
        Destroy(gameObject);
    }


}
