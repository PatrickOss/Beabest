using UnityEngine;
using System.Collections;
using Pathfinding;
using Pathfinding.RVO;

public class Teleporter : MonoBehaviour {

    public GameObject player;
    public GameObject slime;
    public AIPath slimeai;
    void Start ()
    {
        player = GameObject.FindWithTag("Player");
        slime = GameObject.Find("slime1");
        player.transform.position = gameObject.transform.localPosition;
        slimeai = slime.GetComponent<AIPath>();
        slimeai.target = player.transform;  
    }
}
