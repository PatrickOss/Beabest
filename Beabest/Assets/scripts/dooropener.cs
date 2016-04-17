using UnityEngine;
using System.Collections;

public class dooropener : MonoBehaviour
{

    public GameObject startingPosition;
    public GameObject endPosition;
    public GameObject startPositionSecond;
    public GameObject endPositionSecond;

    public GameObject door1;
    public GameObject door2;

    public float time = 2; 
      void OnTriggerEnter(Collider other)
    {
        door1.transform.localPosition = Vector3.Lerp(door1.transform.localPosition, endPosition.transform.localPosition, time * Time.deltaTime);
        door2.transform.localPosition = Vector3.Lerp(door2.transform.localPosition, endPositionSecond.transform.localPosition, time * Time.deltaTime);

    }
    void OnTriggerExit(Collider other)
    {
        door1.transform.localPosition = Vector3.Lerp(door1.transform.localPosition, startingPosition.transform.localPosition, time * Time.deltaTime);
        door1.transform.localPosition = Vector3.Lerp(door1.transform.localPosition, startPositionSecond.transform.localPosition, time * Time.deltaTime);
    }
}
