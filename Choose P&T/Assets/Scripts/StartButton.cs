using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject Startbutton;
    public GameObject Dialoguebox;

    void Start()
    {
        Dialoguebox.SetActive(false);
        Startbutton.SetActive(true);
    }

    public void IwasClicked()
    {
        Startbutton.SetActive(false);
        Dialoguebox.SetActive(true);
    }

}
