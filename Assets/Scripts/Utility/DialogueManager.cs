using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public delegate void Dialogue(string[] dialogues);
    public static Dialogue startDialogue;

    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TextMeshProUGUI dialogueText;

    private bool isTalking;
    private int dialogueIndex;
    private string[] currentDialogues;

    private bool isTyping;

    private InputMaster controls;

    // Start is called before the first frame update
    void Awake()
    {
        startDialogue += StartDialogue;
        controls = new InputMaster();
        controls.UI.Accept.performed += _ => NextDialogue();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void OnDestroy()
    {
        startDialogue -= StartDialogue;
    }

    void StartDialogue(string[] dialogues)
    {
        dialogueBox.SetActive(true);
        isTalking = true;
        dialogueIndex = 0;
        currentDialogues = dialogues;
        StartCoroutine(TypeNextDialogue());
    }

    void NextDialogue()
    {
        if (isTalking)
        {
            if (isTyping)
            {
                StopAllCoroutines();
                dialogueText.text = currentDialogues[dialogueIndex];
                isTyping = false;
            }
            else
            {
                if (dialogueIndex >= currentDialogues.Length - 1)
                {
                    isTalking = false;
                    dialogueBox.SetActive(false);
                    Player.instance.canMove = true;
                }
                else
                {
                    dialogueIndex++;
                    StartCoroutine(TypeNextDialogue());
                }
            }
        }
    }

    IEnumerator TypeNextDialogue()
    {
        isTyping = true;
        string dialogue = currentDialogues[dialogueIndex];
        dialogueText.text = "";
        foreach (char letter in dialogue)
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        isTyping = false;
    }
}
