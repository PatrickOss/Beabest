using UnityEngine;
using System.Collections;

public class bedsystemhelper : MonoBehaviour
{
    public GameObject player;
    public Bedsystem beds;

    void Start ()
    {
        player = GameObject.Find("FPSController");
        beds = player.GetComponent<Bedsystem>();
    }
    void OnTriggerEnter ()
    {
        beds.enterder = true;
    }
    void OnTriggerLeave()
    {
        beds.enterder = false;
    }
}
