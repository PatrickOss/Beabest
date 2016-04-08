using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainmenuHandler : MonoBehaviour
{
    public GameObject Options;
    public GameObject Credits;
    public float speed;
    public bool options  = false;
    public bool credits = false;
    void Update()
    {
        if (options)
        {
            Options.transform.localPosition = Vector3.Lerp(Options.transform.localPosition, new Vector3(-21f, -4f, 0f), speed * Time.deltaTime);
        }
       if (options == false)
        {
            Options.transform.localPosition = Vector3.Lerp(Options.transform.localPosition, new Vector3(-21f, 1957f, 0f), speed * Time.deltaTime);
        }
       if(credits)
        {
           Credits.transform.localPosition = Vector3.Lerp(Credits.transform.localPosition, new Vector3(3f,1f,0f), speed * Time.deltaTime);
        }
        if (credits == false)
        {
            Credits.transform.localPosition = Vector3.Lerp(Credits.transform.localPosition, new Vector3(3f, 1957f,0f), speed * Time.deltaTime);
        }
    }
	public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void moveDownOptions ()
    {
        options = true;
    }
    public void moveUpOptions()
    {
        options = false;
    }
    public void moveDownCredits ()
    {
        credits = true;
    }
    public void moveUpCredits ()
    {
        credits = false;
    }
}
