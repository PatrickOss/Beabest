using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bedsystem : MonoBehaviour {

    public GameObject[] BedCanvases;
    public GameObject DAYNIGHT;
    public DayNightController daynight;
    public GameObject sleeperObjec;
    public Image sleeper;
    RaycastHit hit;
    bool sleeps;
    float timemultipler = 0.1f;
    public  float time;

    void Start()
    {
        sleeperObjec = GameObject.Find("Sleeper");
        sleeper = sleeperObjec.GetComponent<Image>();
        DAYNIGHT = GameObject.FindWithTag("Daynight");
        daynight = DAYNIGHT.GetComponent<DayNightController>();
    }
    	
	void Update ()
    {
        time += Time.deltaTime * timemultipler;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (time >= .4f)
        {
            antisleeping();
        }

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
                    for (int i = 0; i <= 3; i++)
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
            if (Input.GetKeyDown(KeyCode.Q))
            {
                sleepAndBuff();
                sleeps = true;
                sleeping();                
                time = 0f;
            }
        }
        else
        {
            BedCanvases[0].SetActive(false);
        }
        if (hit.collider.name == "betterBed2")
        {
            BedCanvases[1].SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {               
                sleepAndBuff();
                sleeps = true;
                sleeping();               
                time = 0f;
            }
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
            if (Input.GetKeyDown(KeyCode.Q))
            {               
                sleep();
                sleeps = true;
                sleeping();
                time = 0f;                
            }
        }
        else
        {
            BedCanvases[2].SetActive(false);
        }
        if (hit.collider.name == "worseBed2")
        {
            BedCanvases[3].SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                
                sleep();
                sleeps = true;
                sleeping();
                time = 0f;               
            }
        }
        else
        {
            BedCanvases[3].SetActive(false);
        }
    }
    void sleepAndBuff()
    {
        daynight.currentTime = 8.00f;
        //buff code here
    }
    void sleep()
    {
        daynight.currentTime = 8.00f;      
    }
    void sleeping()
    {
        if (sleeps)
        {           
            sleeper.color = Color.Lerp(Color.black, Color.clear, Time.deltaTime * .00001f);
            sleeps = false;
        }                          
    }
    void antisleeping()
    {
        sleeper.color = Color.Lerp(Color.clear, Color.black, Time.deltaTime * .00001f);
        sleeps = true;
    }  
}
