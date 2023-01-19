using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Interact : MonoBehaviour
{
    public TMP_Text InteractText;
    public GameObject otherObject;
    public float distanceThreshold = 2.0f;
    //public InteractText distanceInteractText;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, otherObject.transform.position);
        if (distance < distanceThreshold)
        {
            //distanceInteractText.text = "Distance: " + distance.ToString();
            //distanceInteractText.enabled = true;

            InteractText.text = "Press p to interact";
            InteractText.enabled = true;
        }
        else
        {
            //distanceInteractText.enabled = false;
            InteractText.enabled = false;
        }
    }
}
