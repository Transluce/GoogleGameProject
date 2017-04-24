using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnims : MonoBehaviour {

    // Use this for initialization
    static Animator attackAnim;
    void Start () {
        attackAnim = GetComponent<Animator>();
    }
	void Update()
    {
        if (BattleManager.attackTrigger == "1")
        {
            attackAnim.SetInteger("True",1);
        }
    }
        	
}
