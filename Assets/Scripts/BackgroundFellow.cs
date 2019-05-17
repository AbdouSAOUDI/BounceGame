using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFellow : MonoBehaviour
{
    [SerializeField] private Vector2 v2;
    [SerializeField] private Camera cam;
    void Update()
    {
        v2.x = cam.transform.position.x;
        v2.y = 0f;
        transform.position = v2;
    }
}
