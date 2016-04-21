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

    private bool entered = true;

    void Update ()
    {
        if (entered == false)
        {
            door1.transform.localPosition = Vector3.Lerp(door1.transform.localPosition, endPosition.transform.localPosition, time * Time.deltaTime);
            door2.transform.localPosition = Vector3.Lerp(door2.transform.localPosition, endPositionSecond.transform.localPosition, time * Time.deltaTime);
        }
        else if (entered)
        {
            door1.transform.localPosition = Vector3.Lerp(door1.transform.localPosition, startingPosition.transform.localPosition, time * Time.deltaTime);
            door2.transform.localPosition = Vector3.Lerp(door2.transform.localPosition, startPositionSecond.transform.localPosition, time * Time.deltaTime);
        }

    }

      void OnTriggerEnter(Collider other)
    {
        entered = true;
    }
    void OnTriggerExit(Collider other)
    {
        entered = false;
    }
}
