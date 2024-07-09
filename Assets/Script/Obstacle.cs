using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject Player;
    private AudioSource audioSource;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogWarning("AudioSource component is missing from the obstacle.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            if (audioSource != null)
            {
                PlaySoundAndDestroy();
            }
            else
            {
                Destroy(this.gameObject);
            }
            Player.GetComponent<TruckController>().TakeDamage();
        }
    }

    private void PlaySoundAndDestroy()
    {
        GameObject soundGameObject = new GameObject("ObstacleSound");
        AudioSource newAudioSource = soundGameObject.AddComponent<AudioSource>();
        newAudioSource.clip = audioSource.clip;
        newAudioSource.Play();
        
        Destroy(soundGameObject, newAudioSource.clip.length);
        
        Destroy(this.gameObject);
    }
}
