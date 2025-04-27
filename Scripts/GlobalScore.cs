using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreBox;
    public static int current;

    public int internalScore;

    private void Start()
    {
        current = 0;
        scoreBox.GetComponent<Text>().text = "0";
    }


    private void Update()
    {
        internalScore = current;
        scoreBox.GetComponent<Text>().text ="" + internalScore.ToString();
    }
}
