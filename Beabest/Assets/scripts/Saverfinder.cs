using UnityEngine;
using System.Collections;

public class Saverfinder : MonoBehaviour {

    public GameObject saver;
    public GameObject Health;
    playerhealth testing;
    saveManager savemanager;

    void Awake ()
    {
        Health = GameObject.Find("Health");
        saver = GameObject.Find("saver");
        savemanager = saver.GetComponent<saveManager>();
        testing = Health.GetComponent<playerhealth>();
    }	
}
