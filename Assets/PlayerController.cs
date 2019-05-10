using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private Animator anim;
    [SerializeField] private Vector2 horisontalForce, verticalForce;
    [SerializeField] private bool b = true;
    void FixedUpdate()
    {
        moveHorizontal (Input.GetAxisRaw("Horizontal"));
        moveVertical (Input.GetAxisRaw("Vertical"));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") b = true;
        if (collision.gameObject.tag == "Enemy") anim.SetBool("Death", true);
        anim.SetBool("Death", false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") b = false;
    }
    public void moveHorizontal(float value)
    {
        player.AddForce(value * horisontalForce * Time.deltaTime);
    }
    public void moveVertical(float value)
    {
        player.AddForce(value * verticalForce * Time.deltaTime);
    }
}
