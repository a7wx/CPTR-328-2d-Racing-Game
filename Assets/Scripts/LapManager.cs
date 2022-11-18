using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    public List<Checkpoint> checkpoints;
    public int totalLaps;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
            if(player.checkpointIndex == checkpoints.Count)
            {
                Debug.Log($"Lap {player.lapNumber} of {totalLaps} completed");
                player.checkpointIndex = 0;
                player.lapNumber++;


                if(player.lapNumber > totalLaps)
                {
                    Debug.Log("You Finished");
                }
            }
        }
    }
}
