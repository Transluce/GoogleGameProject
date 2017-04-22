using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController_buttons : MonoBehaviour {

    private float speed = 0.05f;
    private bool moveLeft;
    private bool moveRight;
    Rigidbody2D playerBody;
    public string direction;
   
    Animator anim;
    public Button thisButton;
   

    void Start()
    {
        playerBody = this.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
         if (direction =="up")
         {
             transform.Translate(0, speed, 0);
             anim.SetInteger("Direction", 1);
         }
         else if(direction =="down")
         {
             transform.Translate(0, -speed, 0);
             anim.SetInteger("Direction", -1);

         }
         else if (direction == "right")
         {
             transform.Translate(speed, 0, 0);
         }
         else if (direction == "left")
         {
             transform.Translate(-speed, 0, 0);
         }
         else if (direction == "stop")
        {
            transform.Translate(0, 0, 0);
        }
         
    }
    
    public void ToUp()
    {
        direction = "up";
        transform.Translate(0, speed, 0);
        anim.SetInteger("Direction", 1);
       
    }
    public void ToDown()
    {
        direction = "down";
        
    }
    public void ToLeft()
    {
        direction = "left";
    }
    public void ToRight()
    {
        direction = "right";
    }
    public void noMovement()
    {
        direction = "stop";
        anim.SetInteger("Direction", 0);
    }
    

}
