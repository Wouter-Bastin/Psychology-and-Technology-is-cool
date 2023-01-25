using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact_press_button : MonoBehaviour
{
    public GameObject player;
    public GameObject Dialogue;
    public GameObject DialogueCamera;
    public GameObject interact;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F))
        {          
            Debug.Log("triggered");
            player.SetActive(false);
            Dialogue.SetActive(true);
            DialogueCamera.SetActive(true);
            interact.SetActive(false);
        }
    }
}
