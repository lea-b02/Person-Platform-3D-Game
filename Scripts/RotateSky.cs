using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RotateSky : MonoBehaviour
{
    public float rotateSpeed = 1.2f;


    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation" , Time.time * rotateSpeed);

    }
}
