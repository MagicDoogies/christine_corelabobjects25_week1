using UnityEngine;
using System.Collections.Generic;

public class AudioDemo : MonoBehaviour
{
    //THIS IS AN EXAMPLE SCRIPT ON THE VARIOUS WAYS YOU CAN ASSIGN AND PLAY SPECIFIC AUDIO THROUGH THE AUDIOSOURCE. 

    //For this script I created a reference to two audiosources- One for background music, the other sound effects. 
    public AudioSource bgMusic;
    public AudioSource funnySounds;

    //For the sound effects Audio Source, I create a list of audioclips I want to be able to assign. 
    public List<AudioClip> soundEffects;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayTheMusic() 
    {
        //NOTE: This 
        bgMusic.Play();
    }
    public void PlaySoundEffects() 
    {
        funnySounds.clip = soundEffects[Random.Range(0, soundEffects.Count)];
        funnySounds.Play();
    }
}
