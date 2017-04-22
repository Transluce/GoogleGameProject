using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
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
}
