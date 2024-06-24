using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource backgroundMusic; 
    [SerializeField] private Button muteButton; 

    private bool isMuted = false;

    void Start()
    {
        UpdateMuteState();
    }

    public void PauseMenu()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        backgroundMusic.Pause(); 
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        backgroundMusic.UnPause(); 
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        UpdateMuteState();
    }

    private void UpdateMuteState()
    {
        backgroundMusic.mute = isMuted;
    }
}
