/* TODO:
 * 1. spraw by model pojawial się przy wskaźniku                               |  done
 * 2. wykradnij jego render i zmień jego A na 0.5                              |  done
 * 3.sprawdzaj czy :                                                           |  half done
 *   A. Nie celujesz w niedozwolony material -                                 |  done
 *   B. Nie wchodzisz w kogos ( ͡° ͜ʖ ͡°)                                         |  done
 * 4. rozwiąż to tak by nie mogżna było budować w nieskończoność - materiały   |  
 * 5. popraw te pierdolone modele bo nie strzymię .-.                          |  
 * ustaw klon = clone                                                          |  done
 * ustaw jego A na przeźroczyste                                               |  po co? ;-;
 * ustaw go jako dziecko pintera                                               |  done
 * gdy go zbudujesz, usuń go z pointera                                        |  done
 * wyczysc clone                                                               |  done
 * sprawdz czy klone jest pusty: -                                             |  done
 *  Tak:                                                                       |  done
 *   Instantiate madafaka!                                                     |  done
 *  Nie:                                                                       |  done
 *   Pobaw się nim!                                                            |  done
*/

using UnityEngine;
public class Builder : MonoBehaviour {

    public Camera cam;
    
    public GameObject player;
    public GameObject model; // this motherfucker will be placed at pointers position
    public GameObject pointer; // at this point models will be placed

    public GameObject clone;
    public Renderer clondRend; // just for some odd reasons

    private RaycastHit hit;
    private Ray ray;

    public float distance; // how far the ray will go?
    public float offset; // just to make it look cool
   

    public bool canOrNot;
    public bool inSomething;// this will tell the script if he is in something

    public Color colorMain;
    public Color colorRed = Color.red;

	// here comes the magic... black magic!

	void Update ()
    {
        // direction where the ray will go
        ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        // did we hit something?
        if (Physics.Raycast(ray, out hit, distance))
        {
            // sets pointer at hits position
            pointer.transform.position = hit.point;
            if (clone == null)
            {
                // let's create him
                create(); 
                // let's build him 
                build();                 
            }
            else
            {
                // just build him
                build();
            }
        }           
            // let's see if this works
         //   Debug.DrawLine(ray.origin, hit.point, Color.red);      	
	}
    void build ()
    {
        if (canOrNot)
        {
            SetColor(colorMain);
            //yea, we can, so just check if we arent in something
            if (inSomething)
            {
                // set gameobject to red
                SetColor(colorRed);
            }
            else
            {
                SetColor(colorMain);
                // we can build here
                if (Input.GetMouseButtonDown(0))
                {
                    SetColor(1);
                    clone.transform.parent = null;
                    clone.GetComponent<Collider>().isTrigger = false;
                    Destroy(clone.GetComponent<layerDetectorForBuilder>());
                    clone.layer = 0;
                    clone = null;
                    
                }            
            }
        }
        else
        { 
            // we can't build here so let's color it red!      
            SetColor(colorRed);                                 
        }
    }
    void create()
    {
        //position with litlle offset
        Vector3 position = new Vector3(pointer.transform.position.x, pointer.transform.position.y + offset, pointer.transform.position.z);
        clone = Instantiate(model, position , pointer.transform.rotation, pointer.transform) as GameObject;
        clone.layer = 2;
        getColor();
    }
    void getColor ()
    {
        //let's grab his renderer;
        clondRend = clone.gameObject.GetComponent<Renderer>();
        SetColor(0.5f);       
    }
    void SetColor(float value)
    {
        colorMain = clondRend.material.color;
        colorMain.a = value;
        clondRend.material.color = colorMain;
    }
    void SetColor (Color col)
    {
        clondRend.material.color = col;
    }
}
