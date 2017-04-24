using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 enemy_position = GameObject.Find("Enemy").transform.position;
        enemy.transform.position = enemy_position;
        player.GetComponent<Player_Stats>().DrawLife();
        enemy.GetComponent<Enemy_stats>().DrawLife();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
