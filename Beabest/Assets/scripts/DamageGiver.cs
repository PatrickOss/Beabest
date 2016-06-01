using UnityEngine;
using System.Collections;

public class DamageGiver : MonoBehaviour
{
    public int DealDamage = 10;
    public int takeDamage = 10;

    public GameObject player;
    public GameObject playersHP;
    public GameObject ShieldHandlerObject;

    public shieldhandler shield;
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
        
        if (other.transform.tag == "Player" && canDealDamage && shield.clicked == false)
        {
            pHP.currenthealth -= DealDamage ;
        }
        if (other.transform.tag == "sword" && shield.animIsPlaing)
        {
            enHP.currenthealth -= takeDamage;
        }
       
    }
    void loader()
    {
        ShieldHandlerObject = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindWithTag("Player");
        playersHP = GameObject.FindGameObjectWithTag("Health");

        pHP = playersHP.GetComponent<playerhealth>();
        enHP = gameObject.GetComponent<EnemyHP>();
        shield = ShieldHandlerObject.GetComponent<shieldhandler>();
        rb = gameObject.GetComponentInParent<Rigidbody>();
        AIpathh = gameObject.GetComponentInParent<AIPath>();

        AIpathh.target = player.transform;
    }
}
