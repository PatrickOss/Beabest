using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    public Bedsystem beds;
    public GameObject group;
    public GameObject daynight;
    public DayNightController controller;
    void Awake ()
    {
        player = GameObject.FindWithTag("Player");
        group = GameObject.FindWithTag("sleepingcanvas");
        daynight = GameObject.FindWithTag("Daynight");
        controller = daynight.GetComponent<DayNightController>();
        beds = player.GetComponent<Bedsystem>();
        loader();
        player.transform.localPosition = gameObject.transform.localPosition;

    }
    void loader()
    {
        //looking for beds
        beds.BedCanvases[0] = GameObject.FindWithTag("pressE2");
        beds.BedCanvases[1] = GameObject.FindWithTag("pressE");
        beds.BedCanvases[2] = GameObject.FindWithTag("pressE3");
        beds.BedCanvases[3] = GameObject.FindWithTag("pressE4");
        // loking for canvas group
        beds.group = group.GetComponent<CanvasGroup>();
        //looking for bed canvases
        beds.presse1 = beds.BedCanvases[0].GetComponent<CanvasGroup>();
        beds.presse2 = beds.BedCanvases[1].GetComponent<CanvasGroup>();
        beds.presse3 = beds.BedCanvases[2].GetComponent<CanvasGroup>();
        beds.presse4 = beds.BedCanvases[3].GetComponent<CanvasGroup>();
        //looking for daynightsystem
        beds.DAYNIGHT = daynight;
        beds.daynight = controller;


    }	
}
