using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class saveManager : MonoBehaviour
{
    public GameObject health;
    public GameObject player;
    public GameObject playerhealth;
    public Text healtex;
    playerhealth test;
    void Awake()
    {
        playerhealth = GameObject.Find("Health");
        health = GameObject.FindWithTag("Health");
        player = GameObject.FindWithTag("Player");              
        DontDestroyOnLoad(health);
        DontDestroyOnLoad(player);
        loader();       
    }
    void loader()
    {

      test = playerhealth.GetComponent<playerhealth>();
      test.healtbar = GameObject.Find("hpp");
      test.texthealth = GameObject.Find("hpptext");
      healtex = test.texthealth.GetComponent<Text>(); ;

    }
}
