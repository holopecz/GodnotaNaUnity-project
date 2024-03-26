using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed, jump_height;
     public bool isGrounded, doubleJump;

    [SerializeField] private GameObject player_model;
    [SerializeField] private Animator animr;
    private bool isFacingForward;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, horizontal * speed);

        if(horizontal == 1 && !isFacingForward)
        {
            player_model.transform.eulerAngles = new Vector3(0, player_model.transform.eulerAngles.y + 180, 0);
            isFacingForward = true;
        }
        else if(horizontal == -1 && isFacingForward)
        {
            player_model.transform.eulerAngles = new Vector3(0, player_model.transform.eulerAngles.y + 180, 0);
            isFacingForward = false;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                animr.SetBool("Jump", true);
                //rb.velocity = new Vector3(rb.velocity.x, 0, 0);
                rb.AddForce(new Vector3(0, jump_height, 0), ForceMode.Impulse);
                isGrounded = false;
            }
            else if (doubleJump)
            {
                //rb.velocity = new Vector3(rb.velocity.x, 0, 0);
                rb.AddForce(new Vector3(0, jump_height, 0), ForceMode.Impulse);
                doubleJump = false;

            }
        }

        rb.AddForce(new Vector3(0, -10, 0), ForceMode.Force);

        if (horizontal != 0) animr.SetBool("isWalking", true);
        else animr.SetBool("isWalking", false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up * -1, out hit, 1f))
        {
            isGrounded = true;
            doubleJump = true; 
            animr.SetBool("Jump", false);
        }
    }
}