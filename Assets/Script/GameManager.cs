using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int caixas = 10; 
    public int caixasGameOver = 5; 
    public Text caixasText; 
    public GameObject gameOverPanel; 
    void Start()
    {
        AtualizarUI(); 
    }
    void VerificarGameOver()
    {
        if (caixas <= caixasGameOver)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0; 
        }
    }

    public void AtingirObstaculo()
    {
        caixas--;
        AtualizarUI(); 
        VerificarGameOver(); 
    }

    void AtualizarUI()
    {
        caixasText.text = "Caixas: " + caixas.ToString();
    }
}
