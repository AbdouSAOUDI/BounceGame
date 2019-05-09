using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 v3;
    void Update()
    {
        if (player.position.x < 0f) v3.x = 0f;
        else v3.x = player.position.x;
        v3.z = -10f;
        v3.y = 1f;
        transform.position = v3;
    }
}
