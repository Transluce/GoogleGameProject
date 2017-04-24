using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour {


    public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {

            //collision.gameObject.GetComponent<Player_Stats>().save();
           // this.GetComponent<Enemy_stats>().save();
           // Debug.Log(collision.gameObject.GetComponent<Player_Stats>().currentPos);
            SceneManager.LoadScene(levelToLoad);
            this.gameObject.AddComponent<DoNotDestroyScript>();
            collision.gameObject.GetComponent<playerController_buttons>().direction = "stop";
            collision.gameObject.GetComponent<playerController_buttons>().noMovement();
            
        }
        if(this.gameObject.name=="Portal")
        {
            Destroy(collision.gameObject);
        }
    }
}
