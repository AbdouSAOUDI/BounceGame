using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    [SerializeField] private Collider2D Player_coll;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private bool isTouchingGround;

    [SerializeField] private Rigidbody2D Player_rb;
    [SerializeField] private float jumpSpeed, speed;
    private void Start()
    {
        Player_coll = GetComponent<Collider2D>();
        Player_rb =   GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        isTouchingGround = Player_coll.IsTouchingLayers(groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            Player_rb.AddForce (transform.up * jumpSpeed);
        }
        Player_rb.AddForce(transform.forward * speed * Input.GetAxisRaw ("Horizontal"));
    }
    private void Update()
    {
        
    }
}
