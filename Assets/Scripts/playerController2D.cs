using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playerController2D : MonoBehaviour {

    public float moveForce = 5, runMultiplier = 2;
    Rigidbody2D playerBody;
	
	void Start () {
        playerBody = this.GetComponent<Rigidbody2D>();
	}
	
	
	void FixedUpdate ()
    {
         Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) *moveForce;
        bool isRunning = CrossPlatformInputManager.GetButton("run");
        //Debug.Log(isRunning ? runMultiplier : 1);
        playerBody.AddForce(moveVec * (isRunning ? runMultiplier : 1));
    }
}
