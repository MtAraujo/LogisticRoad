using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit(){
        Application.Quit();
        Debug.Log("Quit");
    }
}
