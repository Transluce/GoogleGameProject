using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GetAnswer : MonoBehaviour {

    // Use this for initialization
    //GameObject button;
    string text;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void getAns()
    {
        text = EventSystem.current.currentSelectedGameObject.name;

        string content = GameObject.Find(text).GetComponentInChildren<Text>().text;
        Debug.Log(content);
        GameObject.FindGameObjectWithTag("Manager").GetComponent<BattleManager>().checkans(content);
        
       
    }
}
