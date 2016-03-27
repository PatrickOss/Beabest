using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class portal : MonoBehaviour {
    public int SceneID;
	void OnTriggerEnter ()
    {
        SceneManager.LoadScene(SceneID);      
	}
}
