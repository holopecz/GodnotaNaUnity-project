using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChildOfConstruct : MonoBehaviour
{
    [SerializeField] private Animator canvas_animr;
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
            StartCoroutine(fade_the_screen());
        }
    }

    IEnumerator fade_the_screen()
    {
        yield return new WaitForSeconds(5);
        canvas_animr.SetTrigger("roll");
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(6);
    }
}
