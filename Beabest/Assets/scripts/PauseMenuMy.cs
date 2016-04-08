using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenuMy : MonoBehaviour {

    public bool changer = false;
    [SerializeField]
    private bool moveOptions = false;
   
    public nocursor backer;

    public GameObject backerObject;
    public GameObject pausemenu;
    public GameObject whitebackground;
    public GameObject optionss;

    CanvasGroup fade;

    public float timeUP = 2f;
    public float timeDOWN = 4f;

    void Awake ()
    {
        optionss = GameObject.Find("options");
        backerObject = GameObject.FindWithTag("Player");
        pausemenu = GameObject.Find("Menu");
        whitebackground = GameObject.Find("WhiteBlur");
        backer = backerObject.GetComponent<nocursor>();
        fade = whitebackground.GetComponent<CanvasGroup>();
    }	
	void Update ()
    {
        if (changer == false && moveOptions == true)
        {
            moveOptions = false;
        }

        if (moveOptions == true && Input.GetKeyDown (KeyCode.Space))
        {
            moveOptions = true;
        }
        if (moveOptions == false && Input.GetKeyDown(KeyCode.Space))
        {
            moveOptions = false;
        }
        OptionsHandler();
	  if (changer)
        {
            pausemenu.transform.localPosition = Vector3.Lerp(pausemenu.transform.localPosition, new Vector3(0f,-3f,0f), Time.deltaTime * timeDOWN); 
        }
      else
        {
            pausemenu.transform.localPosition = Vector3.Lerp(pausemenu.transform.localPosition, new Vector3(0, 1644,0), Time.deltaTime * timeUP);
        }
      if (pausemenu.transform.localPosition.y <= 342f)
        {
            fade.alpha += Mathf.Lerp(0, 1, Time.deltaTime * 1f);
        }
      else
        {
           fade.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
        }
      
     



    }
    public void Back ()
    {
        backer.changed = false;
    }
     public void Options ()
    {
        moveOptions = !moveOptions;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit ()
    {
        Application.Quit();
    }
    void OptionsHandler()
    {
        if (moveOptions == true && changer == true)
        {
            optionss.transform.localPosition = Vector3.Lerp(optionss.transform.localPosition, new Vector3(12.298f,-1f,0f), Time.deltaTime * timeDOWN);
        }
        else
        {
            optionss.transform.localPosition = Vector3.Lerp(optionss.transform.localPosition, new Vector3(12.298f,1642f,0f), Time.deltaTime * timeUP);
        }
    }
}
