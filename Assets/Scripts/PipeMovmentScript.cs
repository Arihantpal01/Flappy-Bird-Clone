using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovmentScript : MonoBehaviour
{   
    public float MSpeed = 5;
     public LogicManagerScript logic;
    public float deadZone = -40;
    // public float topDeadZone = 35.3f;
    // public float bottomDeadZone = -35.2f;

    // public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
          logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MSpeed ) * Time.deltaTime;
        if(transform.position.x < deadZone){
            Destroy(gameObject);
        }

        
    }
}
