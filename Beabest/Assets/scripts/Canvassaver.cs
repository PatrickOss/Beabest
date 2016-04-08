using UnityEngine;
using System.Collections;

public class Canvassaver : MonoBehaviour {

    private static Canvassaver instance;

    public static Canvassaver Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        // If no Player ever existed, we are it.
        if (instance == null)
            instance = this;
        // If one already exist, it's because it came from another level.
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }
}
