using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construct_raise : MonoBehaviour
{
    [SerializeField] private Animator animr;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animr.SetInteger("Action", animr.GetInteger("Action") + 1);
            Destroy(gameObject);
        }
    }
}
