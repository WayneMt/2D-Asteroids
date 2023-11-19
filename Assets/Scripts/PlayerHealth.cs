using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 5;
    private int health;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        
        gameManager = FindObjectOfType<GameManager>();
        gameManager.UpdatePlayerHealthUI(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        gameManager.UpdatePlayerHealthUI(health);
            Debug.Log("Bruh");
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public void HealPlayer(int heal)
    {
        Debug.Log("NO");
        if (health < maxHealth)
        {
            health += heal;
            gameManager.UpdatePlayerHealthUI(health);
            Debug.Log("YEAH");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
