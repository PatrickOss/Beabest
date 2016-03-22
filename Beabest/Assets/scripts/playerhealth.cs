using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class playerhealth : MonoBehaviour {

    public float maxhealth = 100;
    public int currenthealth = 100;
    public GameObject healtbar;
    public Text healtex;
    
    void start()
    {
       
       
    }
    void Update()
    {
        decraser();
        healtex.text = "" + currenthealth.ToString();
        if (currenthealth <= 0)
        {
            healtex.text = "0";
            currenthealth = 0;
        }
        if (currenthealth >=100)
        {
            healtex.text = "100";
            currenthealth = maxhealth.ToInt();
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
