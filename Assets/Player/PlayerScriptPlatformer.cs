using UnityEngine;

public class PlayerScriptPlatformer : MonoBehaviour
{
    private float speedPlayer = 2.5f; //движение
    private Vector2 moveInput;

    private bool facingRight;

    private float jumpForce = 400f; // прыжок 
    private bool isGround;
    [SerializeField] private Transform groundCheker;
    [SerializeField] private Vector2 checkRadius;
    [SerializeField] private LayerMask itGround;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGround = Physics2D.OverlapBox(groundCheker.position, checkRadius, 0f, itGround);

        moveInput.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput.x * speedPlayer, rb.velocity.y);
        if (moveInput.x > 0 && !facingRight)
        {
            Flip();
        }
        if (moveInput.x < 0 && facingRight)
        {
            Flip();
        }
    }

    void Update()
    {
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
