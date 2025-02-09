using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
        private Rigidbody rb;

        public float speed = 8;

         private float movementX;
         private float movementY;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }
private void OnMove(InputValue movementValue)
{
    Vector2 movementVector = movementValue.Get<Vector2>();

    movementX = movementVector.x;
    movementY = movementVector.y;
}

private void FixedUpdate()
{
    Vector3 movement = new Vector3(movementX, 0.0f, movementY);

    rb.AddForce(movement * speed);
}
}
