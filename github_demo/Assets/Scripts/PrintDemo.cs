using TMPro;
using UnityEngine;

public class PrintDemo : MonoBehaviour
{
    public GameObject cubeObj;
    public Camera camRef;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubeObj = GameObject.Find("Cube");
        camRef = GetComponent<Camera>();    
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
