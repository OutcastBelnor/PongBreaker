﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public bool playerOne = false;
    public bool playerTwo = false;

    private float moveSpeed;
    private float axis;
    private float movementValue;

    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOne)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                axis = Input.GetAxisRaw("Vertical");
                PlayerMovement();
            }
        }
        else if (playerTwo)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                axis = Input.GetAxisRaw("Vertical");
                PlayerMovement();
            }
        }
    }

    private void PlayerMovement ()
    {
        movementValue = moveSpeed * axis * Time.deltaTime;

        this.transform.Translate(0f, movementValue, 0f);
        this.transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(this.transform.position.y, 0.6f, 9.4f), 0f);
    }
}