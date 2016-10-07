using UnityEngine;
using System.Collections;

public class layerDetectorForBuilder : MonoBehaviour {

    public Builder build;
    public RaycastHit hit;
    public string bannedlayer;// this will chech if hited object is on banned layer
    public string actualLayer;
    public float distance = 10;
    public float radius = 2;

    void Start()
    {
        build = GameObject.FindGameObjectWithTag("Player").GetComponent<Builder>();
    }
    void Update()
    {
        if(Physics.SphereCast(transform.position, radius, Vector3.down, out hit, distance)) // 1` - layer do ignorowania
        {
            actualLayer = hit.collider.tag;
            if(hit.collider.tag == bannedlayer)
            {
                build.canOrNot = false;
            }
            else
            {
                build.canOrNot = true;
            }
            if(hit.collider.tag != "island")
            {
                build.inSomething = true;
            }
            else
            {
                build.inSomething = false;
            }
        }
    }    
}
