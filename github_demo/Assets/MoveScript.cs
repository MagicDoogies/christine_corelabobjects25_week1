using TMPro;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed;
    public TMP_Text messageText;
    
    public float hAxisSpeed;
    public float vAxisSpeed;

    public Rigidbody rb;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Xmove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float Zmove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(Xmove, 0, Zmove);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            rb.linearVelocity += Vector3.forward * moveSpeed * Time.deltaTime;

            /*//print("You have pressed space. Speeding up!" + moveSpeed);
            moveSpeed += 10;
            messageText.text = "Your current speed is " + moveSpeed.ToString("N0");*/
        }

    }
    
}
