using UnityEngine;
using System.Collections;

public class DamageGiver : MonoBehaviour
{
    public int takeDamage = 10;

    public GameObject player;
    public playerhealth pHP;
    public EnemyHP enHP;
    public AIPath AIpathh;
    public Rigidbody rb;

    public bool canDealDamage = true;

    void Awake()
    {
        loader();
        AIpathh.Awake();
    }
    void Update ()
    {
        if (enHP.currenthealth <= 0)
        {
            canDealDamage = false;
            AIpathh.canMove = false;
            AIpathh.canSearch = false;
            rb.constraints = RigidbodyConstraints.None;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.tag == "Player" && canDealDamage)
        {
            pHP.currenthealth -= takeDamage ;
        }
        if (other.transform.tag == "sword")
        {
            enHP.currenthealth -= 10;
        }
        if (other.transform.tag == "shield")
        {
            pHP.currenthealth -= 0;
        }
    }
    void loader()
    {
        player = GameObject.FindWithTag("Player");
        pHP = player.GetComponent<playerhealth>();
        enHP = gameObject.GetComponent<EnemyHP>();
        rb = gameObject.GetComponentInParent<Rigidbody>();
        AIpathh = gameObject.GetComponentInParent<AIPath>();
        AIpathh.target = player.transform;
    }
}
