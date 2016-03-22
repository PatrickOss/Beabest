using UnityEngine;
using System.Collections;
using UnityEditor;

public class placer : Editor
{
    public GameObject objectToPlace;
    void OnSceneGUI()
    {
        if (Event.current.type == EventType.MouseDown)
        {
            Ray ray = Camera.current.ScreenPointToRay(Event.current.mousePosition);
            RaycastHit hit = new RaycastHit ();

            if (Physics.Raycast(ray, out hit, 1000f))
            {
                Debug.Log("holy crap, i'm working");
            }

        }
    }
}
