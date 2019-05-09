using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingChecker : MonoBehaviour
{
    [SerializeField] private Color color;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Player") GetComponent<SpriteRenderer>().color.a = 100;
    }
}
