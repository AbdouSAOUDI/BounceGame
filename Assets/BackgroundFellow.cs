using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFellow : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] private Vector3 v3;
    void Update()
    {
        v3.x = camera.transform.position.x;
        v3.y = 0f;
        v3.z = 0f;
        transform.position = v3;
    }
}
