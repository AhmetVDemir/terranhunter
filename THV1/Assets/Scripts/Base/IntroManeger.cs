using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManeger : MonoBehaviour
{

    [SerializeField]
    AudioSource audio;

    private void Start()
    {
        Invoke("PlayMusic", 0.5f);
        Invoke("LoadScreen", 5.0f);
    }

    public void PlayMusic()
    {
        audio.Play
            ();
    }
  
    public void LoadScreen()
    {
        SceneManager.LoadScene("2-) Menu");
    }
}
