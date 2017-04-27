using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatedEnemies_list : MonoBehaviour {

    // Use this for initialization
    public string[] enemies;
    public int numberotenemies;
    public Vector3 enemy_position;
    public bool playerPositioned;
    public static int finalscore;
    
    GameObject player;
	void Start () {
        enemies = new string[100];
        numberotenemies = 0;
        player = GameObject.Find("Player");
        playerPositioned = false;
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(GameObject.Find(enemies[i]));
            
        }
    }
}
