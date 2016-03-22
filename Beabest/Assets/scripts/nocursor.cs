using UnityEngine;
using System.Collections;

public class nocursor : MonoBehaviour {

   public bool changed = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            changed = !changed;
        }
        if (changed == false)
        {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (changed == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;          
        }
       
    }
}

