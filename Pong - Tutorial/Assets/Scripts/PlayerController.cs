using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    Gamepad game = Gamepad.current;
    private Vector3 startPosition;



    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        

    }

    public void Start()
    {
        startPosition = transform.position;
    }

    public void Update()
    {
        
         
    }


    public void OnMovement(InputAction.CallbackContext context)
    {
        
        // Read the movement value
        float movementInput = context.ReadValue<float>();
        //Move the Player
        rb.velocity = new Vector2(rb.velocity.x, movementInput * speed);
        
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
