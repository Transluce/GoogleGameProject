using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerController2D : MonoBehaviour {

    public float moveForce = 0.05f, runMultiplier = 2;
    Rigidbody2D playerBody;
    Animator anim;
	void Start () {
        playerBody = this.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	
	void FixedUpdate ()
    {
         Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) *moveForce;
        bool isRunning = CrossPlatformInputManager.GetButton("run");
        //Debug.Log(isRunning ? runMultiplier : 1);
        playerBody.transform.Translate(moveVec * (isRunning ? runMultiplier : 1));
        if(moveVec.y>0)
        {
            anim.SetInteger("Direction", 1);
        }
        else if(moveVec.y==0)
        {
            anim.SetInteger("Direction", 0);
        }
        else if(moveVec.y<0)
        {
            anim.SetInteger("Direction", -1);
        }
    }
}
