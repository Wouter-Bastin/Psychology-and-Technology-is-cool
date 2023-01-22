using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class addButton : MonoBehaviour
{
    public static int Morality;
    public static int ansindex;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject Dialogue;
    public GameObject DialogueCamera;
    public GameObject player;
    public GameObject trigger;
    public Button button;
    public GameObject MinButton;
    public GameObject varGameObject;
    private bool active;

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
        Debug.Log("YES");
        active = true;
        StopAllCoroutines();
        textComponent.text = string.Empty;
        StartCoroutine(TypeLine());
        button.enabled = !button.enabled;
        MinButton.SetActive(false);
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
            Dialogue.SetActive(false);
            Debug.Log("End triggered");
            trigger.SetActive(false);
            player.SetActive(true);
            DialogueCamera.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }
    }
}