using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed, jump_height;
     public bool isGrounded, doubleJump;


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, horizontal * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0, 0);
                rb.AddForce(new Vector3(0, jump_height, 0), ForceMode.Impulse);
                isGrounded = false;
            }
            else if (doubleJump)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0, 0);
                rb.AddForce(new Vector3(0, jump_height, 0), ForceMode.Impulse);
                doubleJump = false;

            }
        }

        rb.AddForce(new Vector3(0, -10, 0), ForceMode.Force);

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up * -1, out hit, 1f))
        {
            isGrounded = true;
            doubleJump = true; // —бросить возможность двойного прыжка при касании земли
        }
    }
}