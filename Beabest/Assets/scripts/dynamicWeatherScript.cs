using UnityEngine;
using System.Collections;

public class dynamicWeatherScript : MonoBehaviour {


 public GameObject clouds; // starting point for clouds
    public GameObject island; // for calculating something which i will probably never use

    public int i = 0; // variable for loop
    public float time = 0; // it's timer
    float rotation; 
    float scale;
    public float minDistance;

    public float differenceX;
    public float differenceY;
    public float differenceZ;

    public Vector3 randomposition; //position of cloud
    public Vector3 randomrotation; // rotation of cloud for calculating

    public Quaternion RandomRotation; // actuall rotation of cloud

    Vector3 difference;

	void Update ()
    {
        time += Time.deltaTime;
        difference = clouds.transform.position - island.transform.position;
        differenceX = Mathf.Abs(difference.x);
        differenceY = Mathf.Abs(difference.y);
        differenceZ = Mathf.Abs(difference.z);

        if (time >= 2 && i<36) 
        {             
               CalculatePosition();
               CalculateRotation();
               ToQuaternion();
               GameObject cloudClone = Instantiate(clouds, randomposition, RandomRotation) as GameObject;
               i++;         
               time = 0;          
        }
    }
    void CalculatePosition ()
    {
        randomposition.x = Random.Range(clouds.transform.position.x - 300, clouds.transform.position.x + 300);
        randomposition.y = Random.Range(clouds.transform.position.y - 20, clouds.transform.position.y + 20);
        randomposition.z = Random.Range(clouds.transform.position.z - 300, clouds.transform.position.z + 300);
    }
    void CalculateRotation ()
    {
        randomrotation.x = Random.Range(0, 360);
        randomrotation.y = Random.Range(0, 360);
        randomrotation.z = Random.Range(0, 360);
    }
    void ToQuaternion ()
    {
        RandomRotation = Quaternion.Euler(randomrotation.x, randomrotation.y, randomrotation.z);
    }

}

