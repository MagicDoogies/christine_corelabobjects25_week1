using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class CharacterDiaDemo : MonoBehaviour
{
    public List<string> dialogueLines;
    public TMP_Text visibleCharaText;


    public Animator dialogueAnim;

    public int dialoguePosition = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        visibleCharaText.text = dialogueLines[dialoguePosition];
        dialogueAnim.SetBool("Open", true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {

            print("You are clicking the mouse");
            PlayDialogue();
        }
    }
    public void PlayDialogue() 
    {
        if (dialoguePosition <= dialogueLines.Count -1) 
        {
            print(visibleCharaText.text);
            dialoguePosition += 1;
            visibleCharaText.text = dialogueLines[dialoguePosition];

        }
        else if (dialoguePosition >= dialogueLines.Count - 1)
        {
            dialoguePosition = 0;
            dialogueAnim.SetBool("Open", false);
        }
    }
}
