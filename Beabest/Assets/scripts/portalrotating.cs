using UnityEngine;
using System.Collections;

public class portalrotating : MonoBehaviour {

    public bool Rotateleft = false;
    public int speed = 15;
   
	void Update ()
    {
        if (Rotateleft)
        {
            transform.Rotate(Vector3.left, Time.deltaTime * speed);
        }
        else
        {
            transform.Rotate(Vector3.right, Time.deltaTime * speed);
        }
	}
}
