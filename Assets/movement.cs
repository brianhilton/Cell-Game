using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    public Rigidbody2D characterController;
    public float movementSpeed = 12f;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 initialPos = new Vector3(0, 0, 0);
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Keyboard.current.wKey.isPressed)
            y = 1;

        if (Keyboard.current.sKey.isPressed)
            y = -1;

        if (Keyboard.current.dKey.isPressed)
            x = 1;

        if (Keyboard.current.aKey.isPressed)
            x = -1;

        Vector3 moveDirection = (transform.right * x) + (transform.up * y);
        characterController.velocity = (moveDirection * movementSpeed * Time.deltaTime ) * 100;


    }
}
