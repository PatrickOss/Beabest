using UnityEngine;
using System.Collections;

public class nocursor : MonoBehaviour {

   public bool changed = false;
    public GameObject pauseGameobject;
    public PauseMenuMy pausemenu;
   
    void Start()
    {      
      //  pauseGameobject = GameObject.Find("PauseMenuHandler");
       // pausemenu = GetComponent<PauseMenuMy>();       
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
       // pausemenu.changer = changed;
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

