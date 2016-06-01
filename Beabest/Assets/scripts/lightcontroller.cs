using UnityEngine;
using System.Collections;

public class lightcontroller : MonoBehaviour {

    public DayNightController daynight;
    public GameObject[] cityLight;

   public float nighttime;
   public float daytime;

	void Start ()
    {
        daynight = daynight.GetComponent<DayNightController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (daynight.currentTime <= daytime && daynight.currentTime >= nighttime)
        {
           // foreach (GameObject lights in cityLight)
            //{
               // lights.SetActive(false);
            //}
        }
        else
        {
            foreach (GameObject lights in cityLight)
            {
                lights.SetActive(true);
            }
        }
	}
}
