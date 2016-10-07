using UnityEngine;
using System.Collections;

public class MakeItSafe : MonoBehaviour {

    public Vector3 position;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = position;
    }
}
