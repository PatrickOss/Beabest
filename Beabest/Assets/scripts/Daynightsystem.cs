using UnityEngine;
using System.Collections;

public class Daynightsystem : MonoBehaviour {

    public float speed;
	void Update ()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.fixedDeltaTime);
        transform.LookAt(Vector3.zero);
	}
}
