using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 6;
    private PlayerMotor motor;
	
	void Start ()
    {
        motor = GetComponent<PlayerMotor>();	
	}
	
	void Update ()
    {
        // takes the inputs
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        
             
        Vector3 moveHorizontal = motor.cam.transform.right * xMove;
        Vector3 moveVertical = motor.cam.transform.forward * zMove;

        // calculates the velocity
        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        motor.Move(velocity);
	}
}
