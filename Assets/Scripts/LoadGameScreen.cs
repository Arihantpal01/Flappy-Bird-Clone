using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScreen : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayScreen(){
    SceneManager.LoadScene(1);
   }
}
