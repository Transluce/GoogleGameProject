﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore: MonoBehaviour {
    public Text ScoreText;
    // Use this for initialization
    void Start () {
        ScoreText.text = DefeatedEnemies_list.finalscore.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
