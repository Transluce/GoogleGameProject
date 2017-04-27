using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositioning : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
        GameObject.FindWithTag("Player").transform.position = GameObject.Find("PlayerBattlescenePos").transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
