using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildOfConstruct : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameObject player = collision.collider.gameObject;
            player.transform.parent = gameObject.transform;
            player.GetComponent<Movement>().enabled = false;
          
            Animator animator = player.GetComponentInChildren<Animator>();
            animator.SetBool("isWalking", false);
            animator.SetBool("Jump", false);
            collision.collider.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
