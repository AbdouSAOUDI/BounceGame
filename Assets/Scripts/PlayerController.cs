using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private Animator anim;
    [SerializeField] private float horisontalForce, speedJump;
    [SerializeField] private bool b = false;
    public float SpeedJump = 50f;
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim.GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        moveHorizontal (Input.GetAxisRaw("Horizontal"));
        //if (Input.GetKey(KeyCode.Space) && b) player.AddForce(verticalForce * Time.deltaTime);
        if (b)
        {
            player.velocity = player.transform.up * speedJump;
            b = false;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                //Move Player Left

                player.velocity = Vector2.up * speedJump * Input.GetAxis("Jump");
                //extrajumps--;
                //anim.SetBool("isJumping", true);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") b = true;
        if (collision.gameObject.tag == "Enemy") anim.SetBool("Death", true);
        anim.SetBool("Death", false);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") b = true;
    }
    public void moveHorizontal(float value)
    {
        //player.AddForce(value * horisontalForce * Time.deltaTime, 0f);
        Vector2 v2;
        v2.x = horisontalForce;
        v2.y = 0f;
        player.AddForce(value * v2 * Time.deltaTime);
    }
    public void moveVertical()
    {
        player.velocity = player.transform.up * speedJump * Time.deltaTime;
    }
}
