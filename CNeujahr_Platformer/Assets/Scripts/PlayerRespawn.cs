using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform respawn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            //Respawn
            transform.position = respawn.transform.position;  
        }
        else if (other.gameObject.CompareTag("Checkpoint"))
        {
            respawn = other.transform;
        }
    }
}
