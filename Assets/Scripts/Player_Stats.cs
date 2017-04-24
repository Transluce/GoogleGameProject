using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Stats : MonoBehaviour {

    // Use this for initialization
    public int hp;
    public Sprite heart;
    public Vector3 currentPos;
    public Scene prevScene;
   
	void Start () {
        hp = 5;
        DrawLife();
        //load();
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    public void DrawLife()
    {
        for(int i=0;i< hp;i++)
        {
            GameObject.Find("Life" + i).GetComponent<Image>().sprite = heart;
        }
    }
    public void DecreaseLife(string name)
    {
        GameObject.Find(name).GetComponent<Image>().enabled = false;
    }
    public void save()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
    }
    public void load()
    {
        float x = PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");
        float z = PlayerPrefs.GetFloat("PlayerZ");
        transform.position = new Vector3(x, y, z);
    }
}
