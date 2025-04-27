using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class RedirectToLevel : MonoBehaviour
{
    public static int redirectToLevel = 3;
    //public static int redirectToLevel2 = 4;
    
    void Update()
    {
        if ((redirectToLevel == 3)|| (redirectToLevel == 4)) {
            SceneManager.LoadScene(redirectToLevel);
        }
        //if (redirectToLevel == 4)
        //{
        //    SceneManager.LoadScene(redirectToLevel);
        //}
    }

}
