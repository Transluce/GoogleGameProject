using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PositionSave : MonoBehaviour {

    public string levelToLoad;
    GameObject player;
    public void savePos()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
    }
    public void loadPos()
    { 

        player = GameObject.Find("Player");
        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");
        float z = PlayerPrefs.GetFloat("PlayerZ");

        transform.position = new Vector3(x, y, z);  
        Destroy(player);
        SceneManager.LoadScene(levelToLoad);
        
    }
    public void saveScore()
    {

    }

}
