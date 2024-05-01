using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void Exit(){
     Application.Quit();
     Debug.Log("Game telah keluar");
    }
    
    public void About()
    {
    SceneManager.LoadScene("about");
    }

    public void Play()
    {
    SceneManager.LoadScene("play");
    }
}
