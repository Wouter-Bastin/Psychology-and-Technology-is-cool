using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiaSystemWithButtons : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public static int Morality;
    public int index;
    public GameObject Dialogue;
    public GameObject DialogueCamera;
    public GameObject player;
    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            Dialogue.SetActive(false);
            Debug.Log("End triggered1");
            trigger.SetActive(false);
            player.SetActive(true);
            DialogueCamera.SetActive(false);
        }
    }
}
