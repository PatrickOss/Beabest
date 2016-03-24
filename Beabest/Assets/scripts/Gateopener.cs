using UnityEngine;
using System.Collections;

public class Gateopener : MonoBehaviour {

    public GameObject Side1;
    public GameObject Side2;
    public DayNightController controller;
    public float time;
    public float nighttime;
    public float daytime;
    void Start()
    {
        controller = controller.GetComponent<DayNightController>();
    }

    void Update ()
    {
        if (controller.currentTime <= daytime && controller.currentTime >= nighttime)
        {
            Side1.transform.localPosition = Vector3.Lerp(Side1.transform.localPosition, new Vector3(-4.45f, 15.98f, 0f), Time.deltaTime * time);
            Side2.transform.localPosition = Vector3.Lerp(Side2.transform.localPosition, new Vector3(-4.45f, -5.55f, 0f), Time.deltaTime * time);
        }
        else
        {
            Side1.transform.localPosition = Vector3.Lerp(Side1.transform.localPosition, new Vector3(-4.446415f, 9.230254f, -0.004535357f), Time.deltaTime * time);
            Side2.transform.localPosition = Vector3.Lerp(Side2.transform.localPosition, new Vector3(-4.448011f, 0.668125f, -0.004535531f), Time.deltaTime * time);
        }
	}
}
