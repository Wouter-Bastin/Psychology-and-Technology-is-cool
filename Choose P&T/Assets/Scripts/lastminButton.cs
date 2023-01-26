using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class lastminButton : MonoBehaviour
{
    public static int ansindex;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject Dialogue;
    public GameObject DialogueCamera;
    public GameObject player;
    public GameObject trigger;
    public Button button;
    public GameObject AddButton;
    public GameObject varGameObject;
    private bool active;
    public GameObject interact;
    public GameObject midaddbutton;
    public GameObject tip;

    void Start()
    {
        textComponent.text = string.Empty;
        ansindex = 0;
        button = GetComponent<Button>();
    }
    void Update()
    {
          if (Input.GetMouseButtonDown(0) && active == true)
         {
            if (textComponent.text == lines[ansindex])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[ansindex];
             }
          }
    }
    public void IWasClicked()
    {
        Debug.Log("NO");
        active = true;
        StopAllCoroutines();
        textComponent.text = string.Empty;
        StartCoroutine(TypeLine());
        button.enabled = !button.enabled;
        AddButton.SetActive(false);
        midaddbutton.SetActive(false);
        varGameObject.GetComponent<DiaSystemWithButtons>().enabled = false;
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
    public void NextLine()
    {
        if (ansindex < lines.Length - 1)
        {
            ansindex++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            varGameObject.SetActive(false);
            Debug.Log("End triggered");
            trigger.SetActive(false);
            interact.SetActive(false);
            tip.SetActive(true);
        }
    }
}
