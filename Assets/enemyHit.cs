using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Enemy")
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<BattleManager>().moveAttack = "0";
            gameObject.transform.position = GameObject.Find("fireballpos").transform.position;
            Debug.Log("HitnaHit");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
