using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{   

    public Rigidbody2D rb;
    public float upForce;

    public LogicManagerScript logic;

     public float topDeadZone = 35.3f;
    public float bottomDeadZone = -35.2f;

    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
         logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetMouseButtonDown(0) == true  && birdIsAlive){

        rb.velocity = Vector2.up * upForce;
        }

          if((transform.position.y < bottomDeadZone) || transform.position.y > topDeadZone){
            logic.gameOver();
             birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;

    }
}
