using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LoopingBackground : MonoBehaviour
{
    public float BackgroundSpeed;
    public Renderer BackgroundRenderer;
    public float gameDuration = 120f; 
    private float timeRemaining;
    public GameObject GameOverPanelWin;

    void Start()
    {
        timeRemaining = gameDuration;
    }

    void Update()
    {
        // Atualiza o movimento do fundo
        BackgroundRenderer.material.mainTextureOffset += new Vector2(BackgroundSpeed * Time.deltaTime, 0f);

        // Atualiza a contagem regressiva
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        
        Debug.Log("Você conseguiu entregar todas as mercadorias.");
        
        GameOverPanelWin.SetActive(true);
    }
}
