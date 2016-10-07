using UnityEngine;
using System.Collections;

public class lightDayNight : MonoBehaviour {

    public Light sun1; // weak one   
    public Light sun2; // strong one

    public Color DayColor = new Color(136f,183f,255f);
    public Color NightColor = new Color(94f, 108f, 128f);
    public Color color;

    public bool changeTurn = false;
    public  bool Night;

    public float[] intensity;
    public float value;
    public float t;
     
    void Start ()
    {
        color = DayColor;
    }

    // Update is called once per frame
    void Update ()
    {
        //  DynamicGI.UpdateEnvironment();  
        controlSun(sun1, 1f);
        controlSun(sun2, 1.1f);
        controlSkybox();
        //sets color to skybox  
        RenderSettings.skybox.SetColor("_Tint", color);
        t = value;
    }

    // makes light go down and up
    void controlSun(Light sun, float number)
    {
        if (sun.intensity == 0)
        {
            changeTurn = true;
        }
        else if (sun.intensity >= number)
        {
            changeTurn = false;
        }
        if (sun.intensity > number)
        {
            sun.intensity = number;
        }
        if (changeTurn == false)
        {          
            sun.intensity -= Mathf.Lerp(0, number, Time.deltaTime * value);           
        }
        if (changeTurn)
        {                
            sun.intensity += Mathf.Lerp(0, number, Time.deltaTime * value);            
        }        
    }

    void controlSkybox()
    {
    // if intensity is big enought, then we have a day! Else, we have a night
        if (sun1.intensity >= intensity[0] && sun2.intensity >= intensity[1])
        {
            color = Color.Lerp(color, DayColor, Time.time * (value * t));
            Night = false;       
        }
        else
        {
            color = Color.Lerp(color, NightColor, Time.time * (value * t));
            Night = true;
        }
    }

   
}

