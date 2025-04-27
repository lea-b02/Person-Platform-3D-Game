using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsGripper : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;
    private Rigidbody playerRb;
    private bool isOnPlatform = false;
    private Vector3 lastLedgePosition;

    void Start()
    {
        playerRb = thePlayer.GetComponent<Rigidbody>();
        lastLedgePosition = theLedge.transform.position;
    }

    void FixedUpdate()
    {
        if (isOnPlatform)
        {
            Vector3 ledgeMovement = theLedge.transform.position - lastLedgePosition;
            playerRb.MovePosition(playerRb.position + ledgeMovement);
        }

        lastLedgePosition = theLedge.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOnPlatform = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOnPlatform = false;
        }
    }
}
