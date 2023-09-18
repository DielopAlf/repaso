using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour 

{
     
     public int a; public int op_1=1; public int op_2=1;
     //public Rigidbody2D rb; 
     private Rigidbody2D rb;
     public float speed;
     //public float speed=5;
     //bool move;
     float move_x;
     float move_y;
     bool jump;
     
     


    
    void Start()
    {
        a=0;     
        //if (a >=0) Debug.Log("Heyyy");
        
        
        
          }

    
    void Update()
    {
        //if (a > 0) Debug.Log("Hello world!");
        print(op_1+op_2);
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>(); rb.mass = 8; rb.gravityScale = 8;
        
        //jump = Input.GetKeyDown(KeyCode.Space);
        move_x = Input.GetAxis("Horizontal");
        move_y = Input.GetAxis("Vertical");
        if (Mathf.Abs(move_x) > 0) rb.velocity = new Vector2(10*move_x,10*move_x);
        if (Mathf.Abs(move_y) > 0) rb.velocity = new Vector2(10 * move_y,10 * move_y);
        
        //Debug.Log(move_y);
        if (Input.GetKeyDown(KeyCode.Space)) rb.velocity = new Vector2(0,50);
    }



}
