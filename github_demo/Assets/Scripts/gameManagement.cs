using UnityEngine;

public class gameManagement : MonoBehaviour
{
    public GameObject preFabSphere;
    public GameObject[] cameraList;
    private int randomX;
    public int randomY;
    public int randomZ;

    public int cameraAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomX = Random.Range(-5, 10);
        randomY = Random.Range(-5, 10);
        randomZ = Random.Range(-5, 10);

        cameraList = GameObject.FindGameObjectsWithTag("MainCamera");

        //foreach(GameObject camera in cameraList) 
        //{
        //    Instantiate(preFabSphere, new Vector3(randomX, randomY, randomZ), Quaternion.identity);
        //    cameraAmount += 1;
        //    print(cameraAmount);
        //    //Random.Range(0, 10);
        //}
        for(int i = 0; i < cameraList.Length; i++) 
        {
            print(cameraAmount);
            cameraAmount += 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateSphere() 
    {
        print("I am creating another sphere.");
        Instantiate(preFabSphere, new Vector3(20,40,5), Quaternion.identity);
    }
    public void SwitchCamera(int currentCam, int switchCam) 
    {
        cameraList[currentCam].GetComponent<Camera>().enabled = false;
        cameraList[switchCam].GetComponent<Camera>().enabled = true;

    }
   
}
