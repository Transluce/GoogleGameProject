using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class BattleManager : MonoBehaviour {

    public static string attackTrigger;
    string answer;
    public string moveAttack; // para magalaw ko ung attack Object
    string Hit; //pang bawas sa buhay ng monster pag tumama ung haduken;
    float firespeed = 0.05f;
    GameObject player;
    GameObject enemy;
    GameObject enemy_list;
  
    public GameObject playerAttack;
    
    public string enemy_name;
    public string stage;
    public static int playerscore = 0;
	// Use this for initialization
	void Start () {
         

    }
	
	// Update is called once per frame
	void Update () {

        if (moveAttack == "1")
        {
            playerAttack.transform.Translate(firespeed, 0, 0);
           
        }
    }
    public void checkans(string text)
    {
       
        player = GameObject.Find("Player");
        enemy_list = GameObject.Find("Defeated_enemies");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemy_name = enemy.name;
   
        Enemy_stats enemystats=enemy.GetComponent<Enemy_stats>();
        Player_Stats playerstats = player.GetComponent<Player_Stats>();
        string correct_answer = (GameObject.Find("Question").GetComponent<Question_Generator>().c).ToString();
        answer = text;

        if(answer==correct_answer&&enemystats.hp!=0)
        {
            playerscore =playerscore+100;
            playerAttack.GetComponent<SpriteRenderer>().enabled = true;
            playerController_buttons.anim.SetInteger("Attack", 1);

            attackTrigger = "1";
            moveAttack = "1";

          
            
            /* *eto sana ung if statement na pag tumama ung fireball saka lang
         mababawasan hp nung monster 

            if(EnemyShoutzone.Hit=="True") */
           
            //{
                // playerController_buttons.anim.SetInteger("Attack", 0);
                //Destroy(playerAttack);
                enemystats.hp--;
                enemystats.takeDamage("Enemy_life" + enemystats.hp);
                playerAttack.transform.position = GameObject.Find("fireballpos").transform.position;
            
            GameObject.Find("Question").GetComponent<Question_Generator>().putquestion();
                
            //}
        }
        else
        { 
            playerstats.hp--;
            playerstats.DecreaseLife("Life" + playerstats.hp);
        }
        if(enemystats.hp==0)
        {
            enemy_list.GetComponent<DefeatedEnemies_list>().enemies[enemy_list.GetComponent<DefeatedEnemies_list>().numberotenemies] = enemy.name;
            enemy_list.GetComponent<DefeatedEnemies_list>().numberotenemies++;
            Vector3 position = playerstats.currentPos;
            player.transform.position = playerstats.currentPos - (new Vector3(1, 1, 0));
            enemy.GetComponent<BoxCollider2D>().enabled = false;
            enemy.GetComponent<ChangeSceneManager>().enabled = false;
            SceneManager.LoadScene(stage);
            //Destroy(enemy);
            Destroy(player);
            
        }
        if(playerstats.hp==0)
        {

            Destroy(player);
            Destroy(enemy);
            SceneManager.LoadScene("PlayerDefeated");
            playerstats.hp = 5;
            
        }
       
    }
  
}
