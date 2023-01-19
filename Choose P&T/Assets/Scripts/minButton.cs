using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class minButton : MonoBehaviour
{
    public static int Morality;
    public static int ansindex;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject Canvas;

    void Start()
    {
        textComponent.text = string.Empty;
        ansindex = 0;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (ansindex > lines.Length - 1))
        {
            Canvas.SetActive(false);
        }
    }
    public void IWasClicked()
    {
        Debug.Log("-1");
        DialogueSystem.Morality -= 1;
        Debug.Log(DialogueSystem.Morality);
        textComponent.text = string.Empty;
        StartCoroutine(TypeLine());
        ansindex++; 
    }
    void StartDialogue()
    {
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[ansindex].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
