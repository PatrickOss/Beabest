using UnityEngine;
using System.Collections;

public class EQhandler : MonoBehaviour {

    public GameObject shieldsystem;
    public GameObject EQsystem;

    bool changed = false;

	void Update ()
    {
	
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            changed = !changed;
        }
        if (changed == false)
        {
            shieldsystem.SetActive(true);
            EQsystem.SetActive(false);
        }
        else
        {
            shieldsystem.SetActive(false);
            EQsystem.SetActive(true);
        }

	}
}
