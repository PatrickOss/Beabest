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
            Side1.transform.localPosition = Vector3.Lerp(Side1.transform.localPosition, new Vector3(-400.56f, 26.59f, -66.86f), Time.deltaTime * time);
            Side2.transform.localPosition = Vector3.Lerp(Side2.transform.localPosition, new Vector3(-0.639f, 0.954f, 0f), Time.deltaTime * time);
        }
        else
        {
            Side1.transform.localPosition = Vector3.Lerp(Side1.transform.localPosition, new Vector3(-407.29f, 26.59f, -65.35f), Time.deltaTime * time);
            Side2.transform.localPosition = Vector3.Lerp(Side2.transform.localPosition, new Vector3(-0.6385074f, 0.5526038f, 0), Time.deltaTime * time);
        }
	}
}
