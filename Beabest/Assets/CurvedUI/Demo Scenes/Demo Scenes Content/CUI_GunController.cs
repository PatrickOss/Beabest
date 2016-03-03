using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CUI_GunController : MonoBehaviour {

	[SerializeField] CurvedUISettings ControlledCanvas;
	[SerializeField] Transform LaserBeamTransform;

	
	// Update is called once per frame
	void Update () {
	

		//tell canvas to use the direction of the gun as a ray controller
		Ray myRay = new Ray (this.transform.position, this.transform.forward);

		if(ControlledCanvas)
			ControlledCanvas.CustomControllerRay = myRay;


		//change the laser's length depending on where it hits
		float length = 1000;

      	RaycastHit hit;

		if (Physics.Raycast (myRay, out hit, length)) {
			length = Vector3.Distance (hit.point, this.transform.position);
		}

		LaserBeamTransform.localScale = LaserBeamTransform.localScale.ModifyZ (length);


		//make laser beam thicker if mose is pressed
		if (Input.GetMouseButton (0)) {

			LaserBeamTransform.localScale = LaserBeamTransform.localScale.ModifyX (1).ModifyY (1);

		} else {
			LaserBeamTransform.localScale = LaserBeamTransform.localScale.ModifyX (0.2f).ModifyY (0.2f);

		}
	}
}
