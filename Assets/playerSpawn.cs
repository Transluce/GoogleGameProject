using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSpawn : MonoBehaviour {

    // Use this for initialization
    GameObject player;
    GameObject enemylist;
    public string HomeScene;
	void Start () {
        player = GameObject.Find("Player");
        enemylist = GameObject.Find("Defeated_enemies");
        if(enemylist.GetComponent<DefeatedEnemies_list>().playerPositioned==false&& enemylist.GetComponent<DefeatedEnemies_list>().numberotenemies>0)
        {
            //player.GetComponent<BoxCollider2D>().enabled = false;
            player.transform.position = enemylist.GetComponent<DefeatedEnemies_list>().enemy_position;
            Time.timeScale = 1;
        }
        if(enemylist.GetComponent<DefeatedEnemies_list>().playerPositioned==false)
        {
            //player.GetComponent<BoxCollider2D>().enabled = true;
        }
        //SceneManager.LoadScene(HomeScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
