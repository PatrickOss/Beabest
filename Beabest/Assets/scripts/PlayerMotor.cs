using UnityEngine;
using System.Collections;
using  UnityStandardAssets.Characters.FirstPerson;

public class PlayerMotor : MonoBehaviour {

    private Vector3 velocity = Vector3.zero;
    public MouseLook mouseLook = new MouseLook();
    public Camera cam;
    Rigidbody rb;



    [SerializeField]
    private float jumpForce = 3f;
    [SerializeField]
    private float DistanceToGround = 0.2f;
    public float distance;
    public float gravity = 2;
    	
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        mouseLook.Init(transform, cam.transform);
    }
	void Update ()
    {
        rotateWiev();          
	}
    void rotateWiev ()
    {
        mouseLook.LookRotation(transform, cam.transform);
    }
    public void Move (Vector3 _velocity)
    {
        // takes velocity
        velocity = _velocity;
    }
    void performMovement()
    {
        // moves player
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }
 
    void FixedUpdate ()
    {
        // starts to move the player
        performMovement();
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            distance = hit.distance;
        } 
        if (Input.GetKeyDown(KeyCode.Space))
             {
                if (distance <= DistanceToGround)
                {
                // użyj matematyki do obliczania velocity, 
                //nastepnie aplikuj te velocity do rigidbody i mnóż to razy dela time      
                    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                }      
            }
    }
}
