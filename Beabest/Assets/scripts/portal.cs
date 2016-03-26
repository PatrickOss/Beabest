using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class portal : MonoBehaviour {
	
	void OnTriggerEnter ()
    {
        SceneManager.LoadScene(1);      
	}
}
