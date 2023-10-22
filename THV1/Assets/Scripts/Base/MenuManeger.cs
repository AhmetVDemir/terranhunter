using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManeger : MonoBehaviour
{



   public void ExitGame()
   {
        Application.Quit();
   }

    public void Start()
    {
        //Level kontrolü yap
        SceneManager.LoadScene("Level1");
    }

}
