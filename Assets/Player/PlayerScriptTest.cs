using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScriptTest : MonoBehaviour
{
    public float speedPlayer; // для движения
    private Vector2 moveInput;

    public static float koefficient;  //для масштабирования
    private float yPos, diff;

    private bool facingRight; //для отражения

    private Rigidbody2D rb; 

    private void Start()
    {
        speedPlayer = 2.5f;
        yPos = transform.position.y;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Scale();
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveInput * speedPlayer * Time.deltaTime);

        if (moveInput.x > 0 && !facingRight)
        {
            Flip();
        }
        if (moveInput.x < 0 && facingRight)
        {
            Flip();
        }
    }

    private void Scale()
    {
        diff = yPos - transform.position.y;
        yPos = transform.position.y;

        if (transform.localScale.x < 0)
        {
            transform.localScale += new Vector3(diff * -koefficient, diff * koefficient, 0);
        }
        else if (transform.localScale.x > 0)
        {
            transform.localScale += new Vector3(diff * koefficient, diff * koefficient, 0);
        }
    }

    private void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
