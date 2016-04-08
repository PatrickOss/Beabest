using UnityEngine;
using System.Collections;

public class itingcameraOrb : MonoBehaviour {

    public GameObject target;
    float speed = 12f;
    
	void Update ()
    {
        transform.LookAt(target.transform);
        transform.RotateAround(target.transform.position, Vector3.right, speed * Time.deltaTime);
    }
}
