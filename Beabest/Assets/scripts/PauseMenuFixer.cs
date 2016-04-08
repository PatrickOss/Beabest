using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenuFixer : MonoBehaviour {
    public GameObject menuObject;
    public PauseMenuMy menu;
    public nocursor backer;

    public GameObject backerObject;
    public GameObject pausemenu;
    public GameObject whitebackground;
    public GameObject optionss;

    public GameObject BackButtonObject;
    public GameObject OptionsButtonObject;
    public GameObject MainMenuButtonObject;
    public GameObject ExitButtonObject;
    public GameObject SeconBackButtonObject;

    public Button BackButton;
    public Button SeconBackButton;
    public Button OptionsButton;
    public Button MainMenuButton;
    public Button ExitButton;

    CanvasGroup fade;

    void Awake()
    {
        //finding aobjects
        menuObject = GameObject.Find("FPSController");
        optionss = GameObject.Find("options");
        backerObject = GameObject.FindWithTag("Player");
        pausemenu = GameObject.Find("Menu");
        whitebackground = GameObject.Find("WhiteBlur");

        BackButtonObject = GameObject.Find("Back");
        SeconBackButtonObject = GameObject.Find("BackSecond");
        OptionsButtonObject = GameObject.Find("Options");
        MainMenuButtonObject = GameObject.Find("MainMenu");
        ExitButtonObject = GameObject.Find("Exit");
        //finding components
        menu = menuObject.GetComponent<PauseMenuMy>();
        backer = backerObject.GetComponent<nocursor>();
        fade = whitebackground.GetComponent<CanvasGroup>();

        BackButton = BackButtonObject.GetComponent<Button>();
        SeconBackButton = SeconBackButtonObject.GetComponent<Button>();
        OptionsButton = OptionsButtonObject.GetComponent<Button>();
        MainMenuButton = MainMenuButtonObject.GetComponent<Button>();
        ExitButton = ExitButtonObject.GetComponent<Button>();

        loadbuttons();
        loader();
        }

        // Update is called once per frame
      
        void loader ()
       {
        menu.optionss = optionss;
        menu.backerObject = backerObject;
        menu.backer = backer;
        menu.pausemenu = pausemenu;
        menu.whitebackground = whitebackground;
       
       }
    void loadbuttons()
    {
        BackButton.onClick.AddListener(delegate { menu.Back(); });
        SeconBackButton.onClick.AddListener(delegate { menu.Options(); });
        OptionsButton.onClick.AddListener(delegate { menu.Options(); });
        MainMenuButton.onClick.AddListener(delegate { menu.MainMenu(); });
        ExitButton.onClick.AddListener(delegate { menu.Exit(); });

    }
   
}
