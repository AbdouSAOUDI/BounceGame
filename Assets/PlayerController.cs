using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private Animator anim;
    [SerializeField] private Vector2 horisontalForce, verticalForce;
    [SerializeField] private bool b = true;
    void FixedUpdate()
    {
        //player.AddForce(horisontalForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            player.AddForce(horisontalForce * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
            player.AddForce(- horisontalForce * Time.deltaTime);
        }
        else if (Input.GetKey("w") && b)
        {
            player.AddForce(- verticalForce * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground") b = true;
        //if (collision.tag == "Enemy") anim.SetBool("Death", true);
        //anim.SetBool("Death", false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground") b = false;
    }
}
