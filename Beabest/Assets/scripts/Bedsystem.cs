using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bedsystem : MonoBehaviour {

    public GameObject[] BedCanvases;
    public GameObject DAYNIGHT;
    public DayNightController daynight;
    public GameObject sleeperObjec;  
    RaycastHit hit;
    bool sleeps;
    public CanvasGroup group;
    public float time;
    private float timespeeder = .1f;
    void Start()
    {
        group = group.GetComponent<CanvasGroup>();
        sleeperObjec = GameObject.Find("Sleeper");       
        DAYNIGHT = GameObject.FindWithTag("Daynight");
        daynight = DAYNIGHT.GetComponent<DayNightController>();
    }   	
	void Update ()
    {      
        if (sleeps == true)
        {
            time += Time.deltaTime * timespeeder;
            group.alpha += Mathf.Lerp(0, 1, Time.deltaTime * 1f);           
        }
        if (time > .4)
        {
            sleeps = false;
            time = 0;
        }
        if (sleeps == false)
        {
            group.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);            
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);     
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
    void betterBed()
    {
        if (hit.collider.name == "BetterBed1")
        {
            BedCanvases[0].SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                sleepAndBuff();
                sleeps = true;
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
}
