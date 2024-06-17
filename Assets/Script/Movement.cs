using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento do jogador

    void Update()
    {
        // Captura o input do teclado
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula o vetor de movimento
        Vector3 movement = new Vector3( 0f, verticalInput) * speed * Time.deltaTime;

        // Aplica o movimento ao jogador
        transform.Translate(movement);
    }
}