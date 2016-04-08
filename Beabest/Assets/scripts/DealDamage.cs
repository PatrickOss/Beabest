using UnityEngine;
using System.Collections;

public class DealDamage : MonoBehaviour {

    [SerializeField]
    private string enemyTag;
    [SerializeField]
    private int Damage;	
	void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == enemyTag)
        {
            Debug.Log("trafiłem : ");
            //damage code
        }
    }
}
