using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue[] dialogues;
    private int dialogueIndex = 0;
    public GameObject dialogueUI;
    public Text nameText;
    public Text dialogueText;
    public Image characterImage;
    public GameObject interactUI;
    public KeyCode dialogueKey = KeyCode.E;
    public KeyCode nextKey = KeyCode.A;

    private bool inRange = false;

    void Start()
    {
        dialogueUI.SetActive(false);
        interactUI.SetActive(false);
        dialogueIndex = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;
            interactUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
            interactUI.SetActive(false);
            dialogueUI.SetActive(false);
            dialogueIndex = 0;
        }
    }

    private void Update()
    {
        if (inRange && Input.GetKeyDown(dialogueKey))
        {
            StartDialogue();
        }

        if (dialogueUI.activeSelf && Input.GetKeyDown(nextKey))
        {
            if (dialogueIndex < dialogues.Length -1)
            {
                dialogueIndex++;
                DisplayNextDialogue();
            }
            else
            {
                EndDialogue();
            }
        }
    }

    public void StartDialogue()
    {
        interactUI.SetActive(false);
        dialogueUI.SetActive(true);
        DisplayNextDialogue();
    }


    public void DisplayNextDialogue()
    {
        Dialogue currentDialogue = dialogues[dialogueIndex];
        nameText.text = currentDialogue.characterName;
        dialogueText.text = currentDialogue.message;
        characterImage.sprite = Sprite.Create(currentDialogue.characterImage, new Rect(0.0f, 0.0f, currentDialogue.characterImage.width, currentDialogue.characterImage.height), new Vector2(0.5f, 0.5f), 100.0f);
    }

    public void EndDialogue()
    {
        dialogueUI.SetActive(false);
        dialogueIndex = 0;
    }
}
