using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour {

    public float maxhealth = 100;
    public int currenthealth = 100;

    public GameObject healtbar;  
  
	void Update ()
    {
        decraser();
        if (currenthealth <= 0)
        {          
            currenthealth = 0;
        }
        if (currenthealth == 0)
        {
            Destroy(transform.parent.gameObject);
        }
        if (currenthealth >= 100)
        {          
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
