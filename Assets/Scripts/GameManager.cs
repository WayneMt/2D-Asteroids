using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HealthText;

    
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int num1)
    { 
        Score += num1;
        ScoreText.text = "Score: " + Score.ToString();
    }

    public void UpdatePlayerHealthUI(int health)
    {
        HealthText.text = "Health: " + health.ToString();
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
        }
    }*/
}
