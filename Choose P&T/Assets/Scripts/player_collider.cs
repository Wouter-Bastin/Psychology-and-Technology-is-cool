using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collider : MonoBehaviour
{
    public GameObject player;
    public GameObject Dialogue_1;
    public GameObject Dialogue_1Camera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("triggered1");
            player.SetActive(false);
            Dialogue_1.SetActive(true);
            Dialogue_1Camera.SetActive(true);
            
        }
    }
}
