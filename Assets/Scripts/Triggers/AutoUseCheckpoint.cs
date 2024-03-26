using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoUseCheckpoint : MonoBehaviour
{
    [SerializeField] private ReturnToCheckPoint checkpointUser;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkpointUser.GoToCheckpoint();
        }
    }
}
