using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour {
    string answer;
    GameObject player;
    GameObject enemy;
    GameObject enemy_list;
    public string enemy_name;
    public string stage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
            enemystats.hp--;
            enemystats.takeDamage("Enemy_life"+enemystats.hp);
            GameObject.Find("Question").GetComponent<Question_Generator>().putquestion();
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

        }
    }
}
