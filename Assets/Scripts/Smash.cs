using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smash : MonoBehaviour
{   
    public AudioSource smash;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision){
      smash.Play();
    
    }
}
