using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    // public AudioSource pipSound;

    private void Start(){
        score = 0;
    }
    private void Update(){
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        // pipSound.Play();
    }
}
