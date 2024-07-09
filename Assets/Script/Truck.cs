using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TruckController : MonoBehaviour
{
    public int lives = 10;
    private int collisions = 0;
    public int maxCollisions = 5;
    private int score = 0;
    public Text livesText; 

    public void TakeDamage()
    {
        collisions++;
        UpdateLivesUI();

        if (collisions >= maxCollisions)
        {
            GameOver();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }

    private void UpdateLivesUI()
    {
        if (livesText != null)
        {
            livesText.text = "" + (lives - collisions);
        }
    }

    private void Start()
    {
        UpdateLivesUI(); 
    }

    private void GameOver()
    {
        Debug.Log("Game Over!");
        Destroy(this.gameObject);
    }
}

