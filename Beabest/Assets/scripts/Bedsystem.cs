using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bedsystem : MonoBehaviour
{
    public bool enterder;

    public GameObject[] BedCanvases;
    public GameObject DAYNIGHT;
    public GameObject sleeperObjec;
    public DayNightController daynight;

    public GameObject sleeperObject;  
    RaycastHit hit;
    public bool sleeps;
    
    public float time;
    private float timespeeder = .1f;
    public CanvasGroup group;
    public CanvasGroup presse1;
    public CanvasGroup presse2;
    public CanvasGroup presse3;
    public CanvasGroup presse4;

    void Start()
    {
        presse1 = BedCanvases[0].GetComponent<CanvasGroup>();
        presse2 = BedCanvases[1].GetComponent<CanvasGroup>();
        presse3 = BedCanvases[2].GetComponent<CanvasGroup>();
        presse4 = BedCanvases[3].GetComponent<CanvasGroup>();
        group = group.GetComponent<CanvasGroup>();
        sleeperObjec = GameObject.Find("Sleeper");       
        DAYNIGHT = GameObject.FindWithTag("Daynight");
        
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
                presse1.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
                presse2.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
                presse3.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
                presse4.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
                }
            }              
	}
    void betterBed()
    {
        if (hit.collider.name == "BetterBed1" && enterder)
        {
            presse1.alpha += Mathf.Lerp(0, 1, Time.deltaTime * 1f);

            if (Input.GetKeyDown(KeyCode.Q))
            {
                sleepAndBuff();
                sleeps = true;
            }
        }
        else
        {
            presse1.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
        }
        if (hit.collider.name == "BetterBed2" && enterder)
        {
            presse2.alpha += Mathf.Lerp(0, 1, Time.deltaTime * 1f);

            if (Input.GetKeyDown(KeyCode.Q))
            {               
                sleepAndBuff();
                sleeps = true;
            }
        }
        else
        {
            presse2.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
        }
    }
    void worseBed()
    {
        if (hit.collider.name == "worseBed1")
        {
            presse3.alpha += Mathf.Lerp(0, 1, Time.deltaTime * 1f);

            if (Input.GetKeyDown(KeyCode.Q))
            {               
                sleep();
                sleeps = true;       
            }
        }
        else
        {
            presse3.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
        }
        if (hit.collider.name == "worseBed2")
        {
            presse4.alpha += Mathf.Lerp(0, 1, Time.deltaTime * 1f);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                
                sleep();
                sleeps = true;                                      
            }
        }
        else
        {
            presse4.alpha -= Mathf.Lerp(0, 1, Time.deltaTime * 1f);
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
