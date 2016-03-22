using UnityEngine;
using System.Collections;

public class shieldhandler : MonoBehaviour {

    public GameObject shield;
    public GameObject startshield;
    public GameObject endshield;

    bool clicked = false;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            clicked = !clicked;
        }
        if (clicked == true)
        {
            shield.transform.position = Vector3.Lerp(shield.transform.position, endshield.transform.position, Time.deltaTime * 12);
        }

        if (clicked == false)
        {
            shield.transform.position = Vector3.Lerp(shield.transform.position, startshield.transform.position, Time.deltaTime * 12);
        }
    }
}
