using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private Animator anim;
    [SerializeField] private Collider2D coll;
    [SerializeField] private float horisontalForce, speedJump;
    [SerializeField] private bool b = false;





    [SerializeField] private bool isGround;
    public Transform groundCheck;
    public LayerMask whatIsGround;//collide with this layer.
    private float jumpheigt = 2f;
    void FixedUpdate()
    {
        //isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, whatIsGround);
        //Physics2D.IgnoreCollision

        isGround = coll.IsTouchingLayers(whatIsGround);

        moveHorizontal(Input.GetAxisRaw("Horizontal"));
        //if (Input.GetKey(KeyCode.Space) && b) player.AddForce(verticalForce * Time.deltaTime);
        //if (b)
        //{
        //    player.velocity = player.transform.up * speedJump;
        //    b = false;
        //}
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            player.AddForce(transform.up * jumpheigt, ForceMode2D.Impulse);
        }

    }
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim.GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            player.velocity = Vector2.up * speedJump * Input.GetAxis("Jump");
            if (Input.mousePosition.x > Screen.width / 2)
            {
                //Move Player Left

                
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
