using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text characterNameText;
    public Text dialogueText;
    public RawImage characterImage;

    private Queue<Dialogue> dialogueQueue = new Queue<Dialogue>();

    public void StartDialogue(Dialogue[] dialogues)
    {
        dialogueQueue.Clear();
        foreach (Dialogue dialogue in dialogues)
        {
            dialogueQueue.Enqueue(dialogue);
        }
        DisplayNextDialogue();
    }

    public void DisplayNextDialogue()
    {
        if (dialogueQueue.Count == 0)
        {
            EndDialogue();
            return;
        }
        Dialogue dialogue = dialogueQueue.Dequeue();
        characterNameText.text = dialogue.characterName;
        dialogueText.text = dialogue.message;
        characterImage.texture = dialogue.characterImage;
    }

    public void EndDialogue()
    {
        characterNameText.enabled = false;
        dialogueText.enabled = false;
        characterImage.enabled = false;
    }
}
