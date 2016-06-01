using UnityEngine;
using System.Collections;

public class camerachanger : MonoBehaviour {

    bool przelaczona = true;
    public GameObject camera1;
    public GameObject camera2;

    void Awake()
    {
        camera1.GetComponent<Camera>();
        camera2.GetComponent<Camera>();
        camera2.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            przelaczona = !przelaczona;
        }
        if (przelaczona == false)
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
        if (przelaczona == true)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }
}
