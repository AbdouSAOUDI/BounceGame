using UnityEngine;

public class SawController : MonoBehaviour
{
    [SerializeField] private Animator anime;
    [SerializeField] private float speed;
    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        anime.SetBool("Death", true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anime.SetBool("Death", false);
    }
}
