using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class playerhealth : MonoBehaviour {

    public float maxhealth = 100; //max health value
    public int currenthealth = 100;   // current value of health
    public Text healtex; // text on which will be show the current value of health
    public static playerhealth instance; // TODO
    public GameObject healtbar; // GUI component which visually shows what's the current value of health
    public GameObject texthealth; //gameobject with text property
    public static GameObject player; // just player


    //go take a lot of coffie if you are studing it. No? Well, then you fucek up


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }     
        DontDestroyOnLoad(gameObject);

        loader();      
    }
    void Update()
    {
        decraser();
        healtex.text = "" + currenthealth.ToString(); // converts the int calue and puts it in the string 
        if (currenthealth <= 0)
        {
            healtex.text = "0";
            currenthealth = 0;
        }
        if (currenthealth >=100)
        {
            healtex.text = "100";
            currenthealth = (int)maxhealth;
        }
    }

    void decraser()
    {
        float calc_Health = currenthealth / maxhealth;
        SetHealthBar(calc_Health);        
    }

    public void SetHealthBar(float healt)
    {
        // healt is value between 1 and 0
        healtbar.transform.localScale = new Vector3(Mathf.Clamp(healt, 0f, 1.5f), healtbar.transform.localScale.y, healtbar.transform.localScale.z);
    }
    void loader()
    {
        healtbar = GameObject.Find("hp");
        texthealth = GameObject.Find("hpptext");
        healtex = texthealth.GetComponent<Text>();
    }
}
