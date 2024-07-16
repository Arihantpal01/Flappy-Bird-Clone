using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{   
    public GameObject gameOverCanvas;

   
    public AudioSource stopAudio;

    private void Start(){
        Time.timeScale = 1;
    }

    public void gameOver(){
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        stopAudio.Play();
       
    }

    public void Replay(){

        SceneManager.LoadScene(1);

    }
   
}
