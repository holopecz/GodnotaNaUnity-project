using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
<<<<<<< Updated upstream
    [SerializeField] float speed , jump_height;
    private bool isGrounded;
=======
    [SerializeField] float speed, jump_height;
    [HideInInspector] public bool isGrounded, doubleJump;

>>>>>>> Stashed changes
    void Start()
    {

    }


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
<<<<<<< Updated upstream

        if(horizontal != 0 )
=======
>>>>>>> Stashed changes
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, horizontal * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
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
<<<<<<< Updated upstream
        Debug.Log(rb.velocity); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
=======

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up * -1, out hit, 1f))
            isGrounded = true;
    }
>>>>>>> Stashed changes
}
