using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UISceneManager : MonoBehaviour {

    // Use this for initialization
    public string LevelToLoad;
    
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadThis()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
