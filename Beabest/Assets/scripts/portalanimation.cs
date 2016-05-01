using UnityEngine;
using System.Collections;

public class portalanimation : MonoBehaviour
{

    bool enter = false;

    public int speed = 20;
    public GameObject firstRing;
    public GameObject secondRing;

    public GameObject firstRingPosition;
    public GameObject secondRingPosition;

    void Start ()
    {
        loader();
    }
	void Update ()
    {
        if (enter)
        {
            firstRing.transform.localPosition = Vector3.Lerp(firstRing.transform.localPosition, firstRingPosition.transform.localPosition, Time.deltaTime * speed);
            secondRing.transform.localPosition = Vector3.Lerp(secondRing.transform.localPosition, secondRingPosition.transform.localPosition, Time.deltaTime * speed);
        }
        else
        {

        }
    }
    void OnTriggerEnter(Collider other)
    {
        enter = true;
    }
    void OnTriggerLeave(Collider other)
    {
        enter = false;
    }
    void loader()
    {

    }
}
