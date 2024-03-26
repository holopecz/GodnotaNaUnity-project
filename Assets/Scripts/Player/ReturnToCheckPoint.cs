using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToCheckPoint : MonoBehaviour
{
    public Vector3 last_checkpoint;
    [SerializeField] private GameObject particles;

    private void Start()
    {
        last_checkpoint = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GoToCheckpoint();
        }
    }

    public void GoToCheckpoint()
    {
        Instantiate(particles, transform.position, transform.rotation);
        transform.position = last_checkpoint;
        Instantiate(particles, transform.position, transform.rotation);
    }
}
