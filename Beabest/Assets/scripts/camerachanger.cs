using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class camerachanger : MonoBehaviour {

    public bool przelaczona = true;

    public FirstPersonController cont;
    public GameObject camera1;
    public GameObject camera2;
    public Camera eyeCam;

    void Awake()
    {
        loader();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            przelaczona = !przelaczona;
        }
        if (przelaczona)
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            cont.m_Camera = camera1.GetComponent<Camera>();
        }
        if (przelaczona == false)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            cont.m_Camera = eyeCam;  
        }
    }
    void loader ()
    {
        camera1.GetComponent<Camera>();
        camera2.GetComponent<Camera>();
    }
}
