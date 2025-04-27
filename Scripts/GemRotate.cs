using UnityEngine;

public class GemRotate : MonoBehaviour
{
    //vites de rotasion
    public int rotateSpeed = 1;

    void Update()
    {
        // y axe, ,le mode
        transform.Rotate(0, rotateSpeed*Time.timeScale, 0, Space.World);
    }
}
