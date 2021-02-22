﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float rotationSpeed = 100;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical") ;

        // tilt the plane up/down based on up/down arrow keys
        transform.Translate(Vector3.up * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
