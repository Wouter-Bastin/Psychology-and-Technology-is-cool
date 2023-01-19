using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public static int Morality;
    public int index;
    public GameObject Dialogue_1;
    public GameObject Dialogue_1Camera;
    public GameObject player;
    public GameObject trigger1;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
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
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            Dialogue_1.SetActive(false);
            Debug.Log("End triggered1");
            trigger1.SetActive(false);
            player.SetActive(true);
            Dialogue_1Camera.SetActive(false);
        }
    }
}
