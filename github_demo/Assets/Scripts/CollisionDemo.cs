using UnityEngine;

public class CollisionDemo : MonoBehaviour
{
    public gameManagement gameManageScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
            //gameObject.SetActive(false);//Allows you to toggle the visibility.
            //Destroy(gameObject);
            gameManageScript.CreateSphere();
            Destroy(gameObject, 1);
        }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
}
