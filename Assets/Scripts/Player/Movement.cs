using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed , jump_height;
    [HideInInspector] public bool isGrounded;
    void Start()
    {
        
    }

  
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        //if(horizontal != 0)
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, horizontal * speed);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jump_height, 0), ForceMode.Impulse);
            isGrounded = false;
        }
        rb.AddForce(new Vector3(0, -10, 0), ForceMode.Force);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up * -1, out hit, 1f)) isGrounded = true;
    }

}
