using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class POrtal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            GameObject[] number = new GameObject[100];
            number = GameObject.FindGameObjectsWithTag("Enemy");
            if (number.Length <= 0)
            {
                Destroy(col.gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                
            }

            Debug.Log(number.Length);
        }
    }
}
