using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCheckpoint : MonoBehaviour
{
    [SerializeField] private ReturnToCheckPoint chekcpointUser;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) chekcpointUser.last_checkpoint = transform.position;
        Destroy(gameObject);
    }
}
