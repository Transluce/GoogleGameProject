using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour {

    public GameObject player;
    public string levelToLoad;
    public static float playerXpos;
    public static float playerYpos;
    public static float playerZpos;
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


            PlayerPrefs.SetFloat("PlayerX", transform.position.x);
            //collision.gameObject.GetComponent<Player_Stats>().save();
            // this.GetComponent<Enemy_stats>().save();
            // Debug.Log(collision.gameObject.GetComponent<Player_Stats>().currentPos);
            //GameObject.Find("Defeated_enemies").GetComponent<DefeatedEnemies_list>().enemy_position = gameObject.transform.position;
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
