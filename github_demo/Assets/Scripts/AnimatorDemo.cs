using TMPro;
using UnityEngine;

public class AnimatorDemo : MonoBehaviour
{
    public Animator redDog;
    public TMP_Text counterText;
    public int counter = 0;
    public bool genericBool = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScaleUpDog() 
    {
        if(redDog.GetBool("Upscale") == false) 
        {
            redDog.SetBool("Upscale", true);
        }
        else if (redDog.GetBool("Upscale") == true) 
        {
            redDog.SetBool("Upscale", false);
        }
       
    }
    public void CountUpEvent() 
    {
        counter += 1;
        counterText.text = counter.ToString("N0");
    }

}
