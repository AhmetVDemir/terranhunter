using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManeger : MonoBehaviour
{

   

    private void Start()
    {
        Invoke("LoadScreen", 5.0f);
    }


    public void LoadScreen()
    {
        SceneManager.LoadScene("2-) Menu");
    }
}
