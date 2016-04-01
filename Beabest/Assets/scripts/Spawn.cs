using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    public Bedsystem beds;
    public GameObject group;
    void Awake ()
    {
        player = GameObject.FindWithTag("Player");
        group = GameObject.FindWithTag("sleepingcanvas");
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
        //looking for
        beds.presse1 = beds.BedCanvases[0].GetComponent<CanvasGroup>();
        beds.presse2 = beds.BedCanvases[1].GetComponent<CanvasGroup>();
        beds.presse3 = beds.BedCanvases[2].GetComponent<CanvasGroup>();
        beds.presse4 = beds.BedCanvases[3].GetComponent<CanvasGroup>();

    }	
}
