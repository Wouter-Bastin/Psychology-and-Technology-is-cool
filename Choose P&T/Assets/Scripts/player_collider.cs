using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collider : MonoBehaviour
{
    public GameObject player;
    public GameObject Dialogue;
    public GameObject DialogueCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("triggered");
            player.SetActive(false);
            Dialogue.SetActive(true);
            DialogueCamera.SetActive(true);
            
        }
    }
}
