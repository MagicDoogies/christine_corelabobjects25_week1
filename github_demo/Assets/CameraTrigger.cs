using UnityEngine;
using System.Collections.Generic;

public class CameraTrigger : MonoBehaviour
{
    //THIS IS AN EXAMPLE SCRIPT ON HOW TO MAKE A VERY BASIC CAMERA SYSTEM. 

    //Step 1: Create an array that will hold all the cameras in your scene. 
    public gameManagement gameManageScript;

    public List<Camera> cameraList;
    public Camera[] cameraArrays;

    public Camera cameraOn;
    public Camera cameraOff;

    
    void Start()
    {
        //Fills my array with any Gameobjet tagged "MainCamera".   
        gameManageScript = GameObject.Find("GameManager").GetComponent<gameManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            cameraOff.enabled = false;
            cameraOn.enabled = true;
        }
        //if (other.gameObject.tag == "Player") 
        //{
        //    gameManageScript.SwitchCamera(turnOffCamera,switchToCamera);
           
        //}
    }

}
