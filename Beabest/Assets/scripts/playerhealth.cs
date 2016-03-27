using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class playerhealth : MonoBehaviour {

    public float maxhealth = 100;
    public int currenthealth = 100;
    public GameObject healtbar;
    public GameObject texthealth;
    public GameObject saverObject;
    public saveManager Saver;

    void Awake()
    {
        saverObject = GameObject.FindWithTag("Saver");
        Saver = saverObject.GetComponent<saveManager>();    
    }
    void Update()
    {
        decraser();
        Saver.healtex.text = "" + currenthealth.ToString();
        if (currenthealth <= 0)
        {
            Saver.healtex.text = "0";
            currenthealth = 0;
        }
        if (currenthealth >=100)
        {
            Saver.healtex.text = "100";
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
        healtbar.transform.localScale = new Vector3(Mathf.Clamp(healt, 0f, 1f), healtbar.transform.localScale.y, healtbar.transform.localScale.z);
    }
}
