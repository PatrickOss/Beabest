using UnityEngine;
using System.Collections;

public class Bedsystem : MonoBehaviour {

    public GameObject[] BedCanvases;

    RaycastHit hit;
    	
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity)) // obliczam punkt trafienia
            {
                Debug.DrawLine(ray.origin, hit.point, Color.red, 100);
                if (hit.collider.tag == "BetterBed")
                {
                    betterBed();
                }
                else if (hit.collider.tag == "WorseBed")
                {
                    worseBed();
                }
                if (hit.collider.tag == "House")
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        BedCanvases[i].SetActive(false);
                    }
                }
            }
        }
        
	}
    void betterBed()
    {
        if (hit.collider.name == "BetterBed1")
        {
            BedCanvases[0].SetActive(true);
        }
        else
        {
            BedCanvases[0].SetActive(false);
        }
        if (hit.collider.name == "betterBed2")
        {
            BedCanvases[1].SetActive(true);
        }
        else
        {
            BedCanvases[1].SetActive(false);
        }
    }
    void worseBed()
    {
        if (hit.collider.name == "worseBed1")
        {
            BedCanvases[2].SetActive(true);
        }
        else
        {
            BedCanvases[2].SetActive(false);
        }
        if (hit.collider.name == "worseBed2")
        {
            BedCanvases[3].SetActive(true);
        }
        else
        {
            BedCanvases[3].SetActive(false);
        }
    }
    
}
