using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class saveManager : MonoBehaviour
{
    
    public GameObject player;
    public Text healtex;
    playerhealth test;
    void Awake()
    {
        player = GameObject.FindWithTag("Player");                  
        DontDestroyOnLoad(player); 
        loader();       
    }
   
    void loader()
    {
      test = player.GetComponent<playerhealth>();
      test.healtbar = GameObject.Find("hpp");
      test.texthealth = GameObject.Find("hpptext");
      healtex = test.texthealth.GetComponent<Text>(); 
    }
}
