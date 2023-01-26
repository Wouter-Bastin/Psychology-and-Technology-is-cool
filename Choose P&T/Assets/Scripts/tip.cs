using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class tip : MonoBehaviour
{
    public GameObject Dialogue;
    public GameObject DialogueCamera;
    public GameObject player;
    private bool active;

    void Start()
    {
        active = true;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && active == true)
        {
            Debug.Log("End tip");
            player.SetActive(true);
            DialogueCamera.SetActive(false);
            Dialogue.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }
    }
}