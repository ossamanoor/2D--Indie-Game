using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
   
   public void ExitButton()
    {
     Application.Quit();
     Debug.Log("Game closed");   
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
