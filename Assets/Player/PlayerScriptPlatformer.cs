using UnityEngine;

public class PlayerScriptPlatformer : MonoBehaviour
{
    public bool recIsMovePlatformer;
    public int slantPlatformer;

    private float speedPlayer = 2.5f; //движение
    private Vector2 moveInput;
    private bool facingRight;
    private float jumpForce = 200f; // прыжок 
    private bool isGround;
    private float rayDistance = 0.6f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput.x * speedPlayer, rb.velocity.y);
        if (Input.GetKey(KeyCode.A))
        {
            recIsMovePlatformer = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            recIsMovePlatformer = true;
        }
        else
        {
            recIsMovePlatformer = false;
        }
        if (moveInput.x > 0 && !facingRight)
        {
            slantPlatformer = -1;
            Flip();
        }
        if (moveInput.x < 0 && facingRight)
        {
            slantPlatformer = 1;
            Flip();
        }
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(rb.position, Vector2.down, rayDistance, LayerMask.GetMask("Ground"));
        if (hit.collider != null)
        {
            isGround = true;

        }
        else
        {
            isGround = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            Jump();
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
}
