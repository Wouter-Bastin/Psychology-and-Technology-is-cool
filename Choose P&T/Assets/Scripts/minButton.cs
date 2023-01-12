using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class minButton : MonoBehaviour
{
    public static int Morality;

    public void IWasClicked()
    {
        Debug.Log("-1");
        DialogueSystem.Morality -= 1;
        Debug.Log(DialogueSystem.Morality);
    }
}
