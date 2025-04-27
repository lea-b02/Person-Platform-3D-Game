using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RedirectToLevel.redirectToLevel = 4;
        //si on cree un niveau 3
        //RedirectToLevel.redirectToLevel2 = 6;

        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff() { 
    
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

    
}
