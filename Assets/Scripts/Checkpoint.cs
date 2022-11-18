using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int index;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
            if (player.checkpointIndex == index - 1)
           {
                Debug.Log("Checkpoint Passed");
                player.checkpointIndex = index;
           }
        }
    }
}
