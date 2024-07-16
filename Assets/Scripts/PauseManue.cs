using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManue : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMeneUI;
    // Update is called once per frame
    void Update()
    {   if(Input.GetKeyDown(KeyCode.Escape)){

        if(GameIsPaused){
            Resume();
        }
        else{
            Paused();
        }
    }
        
    }

 public void  Resume(){
    Time.timeScale = 1;
    GameIsPaused = false;
     pauseMeneUI.SetActive(false);
    }

 public void  Paused(){
    pauseMeneUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
    }
}
