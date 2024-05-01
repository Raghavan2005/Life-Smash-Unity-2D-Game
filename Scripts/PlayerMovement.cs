using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    public Animator an;
    public float normalSpeed = 5f;
    public float stairsSpeed = 2f; // Adjust this value as needed
    public Joystick joystick;

    private bool isOnStairs = false;

    // Update is called once per frame
  
    void Update()
    {
        // Input handling
      //  float moveHorizontal = Input.GetAxisRaw("Horizontal");
      //  float moveVertical = Input.GetAxisRaw("Vertical");
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;
        
        // Animator parameters
        an.SetFloat("Horizontal", moveHorizontal);
        an.SetFloat("Vertical", moveVertical);
        an.SetFloat("Speed", new Vector2(moveHorizontal, moveVertical).sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Movement
        //Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Vector2 movement = new Vector2(joystick.Horizontal, joystick.Vertical).normalized;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
       
       
    }
   
}
