using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_stats : MonoBehaviour {

    // Use this for initialization
    public int hp;
    public Sprite heart;
    void Start () {
                
	}
	
	// Update is called once per frame
	void Update () {
		if(hp==0)
        {
            
            Destroy(this.gameObject);
        }
	}
    public void DrawLife()
    {
        for (int i = 0; i < hp; i++)
        {
            GameObject.Find("Enemy_life" + i).GetComponent<Image>().sprite = heart;
            GameObject.Find("Enemy_life" + i).GetComponent<Image>().enabled = true;
        }
    }
    public void takeDamage(string name)
    {
        GameObject.Find(name).GetComponent<Image>().enabled = false;
    }
    public void save()
    {
        PlayerPrefs.SetString("enemytoDestroy", this.gameObject.name);
    }
    public string load()
    {
        return PlayerPrefs.GetString("enemytoDestroy");
        //Destroy(GameObject.Find(PlayerPrefs.GetString("enemytoDestroy")));
    }
}
