using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class dynamicWeatherScript : MonoBehaviour {

    public GameObject StartPoint; // starting point for clouds
    public GameObject[] clouds; // the models for creating clouds

    public List<GameObject> CloudsList; //list where created clouds will be stored

    public int randomcloud; // lets take random model
    public int i = 0; // variable for loop
    public int howManyClouds; // how many clouds we should create?
    public int HowBigSquare = 1000; //how big the square should be?
    int rando = 0; // it's random number which will be used for making fade in and out effect later in the script

    public float timer = 0;

    public Vector3 randomposition; //position of cloud
    public Vector3 randomrotation; // rotation of cloud for calculating

    public Quaternion RandomRotation; // actuall rotation of cloud

    void Awake()
    {
        SechForStartPoint();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (i < howManyClouds)
        {
            Generate();
        }
        if (timer >= 4)
        {
            rando = Random.Range(0, CloudsList.ToArray().Length);

            RandomizePosition();

            timer = 0;
        }
    }
    void Generate()
    {
        RandomizeClouds();
        CalculatePosition();
        CalculateRotation();
        ToQuaternion();
        GameObject cloudClone = Instantiate(clouds[randomcloud], randomposition, RandomRotation) as GameObject;
        CloudsList.Add(cloudClone);
        i++;
    }

    void CalculatePosition()
    {
        randomposition.x = Random.Range(StartPoint.transform.position.x - HowBigSquare, StartPoint.transform.position.x + HowBigSquare);
        randomposition.y = Random.Range(StartPoint.transform.position.y - 20, StartPoint.transform.position.y + 20);
        randomposition.z = Random.Range(StartPoint.transform.position.z - HowBigSquare, StartPoint.transform.position.z + HowBigSquare);

        randomposition.x += 50;
        randomposition.z += 50;
    }
    void CalculateRotation()
    {
        randomrotation.x = Random.Range(0, 360);
        randomrotation.y = Random.Range(0, 360);
        randomrotation.z = Random.Range(0, 360);
    }
    void RandomizeClouds()
    {
        randomcloud = Random.Range(0, clouds.Length);
    }
    void RandomizePosition()
    {

        CalculatePosition();
        CloudsList[rando].transform.position = randomposition;
    }
    void ToQuaternion()
    {
        RandomRotation = Quaternion.Euler(randomrotation.x, randomrotation.y, randomrotation.z);
    }
    void SechForStartPoint()
    {
        if (StartPoint == null)
        {
            StartPoint = GameObject.Find("cloud1");
        }
        else
        {
            return;
        }
    }
}

