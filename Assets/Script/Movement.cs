using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; 

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3( 0f, verticalInput) * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}