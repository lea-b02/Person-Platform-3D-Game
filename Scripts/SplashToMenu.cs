using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    public GameObject thePersonage;
    public GameObject theMessage;

    private void Start()
    {
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash() { 
        yield return new WaitForSeconds(0.5f);
        thePersonage.SetActive(true);
        theMessage.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(1);
    }

}
