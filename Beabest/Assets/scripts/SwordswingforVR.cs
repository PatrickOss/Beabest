using UnityEngine;
using System.Collections;

public class SwordswingforVR : MonoBehaviour
{

    public Animator anim;
    public GameObject pauserGameobject;
    public GameObject character;

    public PauseMenuMy pauser;
    public shieldhandler shieldIsOn;

    public bool ifSword = true;
    public bool ifAxe = false;

    public int animnumber; //which animation to play?
    void Start()
    {
        character = GameObject.Find("CenterEyeAnchor");
        pauserGameobject = GameObject.Find("FPSController");

        pauser = pauserGameobject.GetComponent<PauseMenuMy>();
        shieldIsOn = character.GetComponent<shieldhandler>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        animnumber = Random.Range(0, 3); //take random number

        if (Input.GetMouseButtonDown(0))
        {

            if (pauser.changer == false && shieldIsOn.clicked == false)
            {
                if (ifSword && ifAxe == false) //checks if player weights sword
                {
                    //sword animation code
                    if (animnumber == 0)
                    {
                        anim.Play("swingSwordOne", -1, 0f);
                    }
                    if (animnumber == 1)
                    {
                        anim.Play("swingSwordTwo", -1, 0f);
                    }
                    if (animnumber == 2)
                    {
                        anim.Play("swingSwordThree", -1, 0f);
                    }
                }
                if (ifAxe && ifSword == false)//checks if player weights axe
                {
                    //axe animation code
                }
            }
        }
    }
}
