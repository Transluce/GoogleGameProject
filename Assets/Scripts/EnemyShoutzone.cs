using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [System.Serializable]
public class EnemyShoutzone : MonoBehaviour {

    public static string Hit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="PlayerAttack")
        {

            Debug.Log("HIT");
            Hit = "True";
      

        }
        
    }




}
