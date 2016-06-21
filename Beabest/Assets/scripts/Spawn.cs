using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    public GameObject group;

    void Awake ()
    {     
        loader();
    }
    void loader()
    {
        player = GameObject.FindWithTag("Player");
        player.transform.localPosition = gameObject.transform.localPosition;
    }	
}
