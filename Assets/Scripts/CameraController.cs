using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(-12, 4, 0);
    // private Quaternion rotationOffset = Quaternion.Euler(new Vector3(-50, 30, 0));

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);
        // transform.rotation = player.transform.rotation + rotationOffset;
    }
}
