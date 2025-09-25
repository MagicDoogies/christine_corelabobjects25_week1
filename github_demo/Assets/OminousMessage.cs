using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OminousMessage : MonoBehaviour
{
    //THIS IS AN EXAMPLE SCRIPT THAT USES THE BUTTON 'ON CLICK' FUNCTION TO RANDOMIZE THE TEXT DISPLAYED IN THE SCENE.

    public TMP_Text messageText;//Step 1: Create a text variable that will hold a reference to your display text. 
    public List<string> ominousMessages;//Step 2: Create a list to contain strings. This is where we will put our messages.
    
    //Step 3: At this point you will go into your Unity editor and make up as many messages as you want. 

   //NOTE: Depending on the context, scripts meant to be used on buttons don't need 'void Start()' or 'void Update()' methods. 
    public void ScaryMessages() //Since we are using the Unity button, we can make a custom method to do the randomization.
    { 
        //When we click the button, the script will randomly select one of the messages in our list and replace it-
        //as the text that shows up on the disply. 
        messageText.text = ominousMessages[Random.Range(0, ominousMessages.Count)];
    }
 
}
