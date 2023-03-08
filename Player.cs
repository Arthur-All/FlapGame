using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpForce;
    public logicManager logic;
    public bool playerALive = true;  

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Player";
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerALive == true)
        {
            rb.velocity = Vector2.up * JumpForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        logic.gameOver();   
        playerALive = false; 
    }
}
