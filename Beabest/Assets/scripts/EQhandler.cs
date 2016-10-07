using UnityEngine;
using System.Collections;

public class EQhandler : MonoBehaviour {

     
    public GameObject shieldsystem;
    public GameObject EQsystem;

    public string ShieldTag;
    public string EQTag;


    public bool changed = false;

    void Awake()
    {
        loader();
    }

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
    void loader()
    {
        shieldsystem = GameObject.FindWithTag(ShieldTag);
        EQsystem = GameObject.FindWithTag(EQTag);
    }
}
