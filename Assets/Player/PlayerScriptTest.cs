using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScriptTest : MonoBehaviour
{
    public bool recIsMove;
    public int slant;
    public float speedPlayer; // для движения
    private Vector2 moveInput;

    public static float koefficient;  //для масштабирования
    private float yPos, diff;

    private bool facingRight; //для отражения

    private Rigidbody2D rb;

    [SerializeField] AudioSource walkSound;

    private void Start()
    {
        recIsMove = false;
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
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            recIsMove = true;
            if (walkSound.isPlaying) return;
            walkSound.Play();
        }
        else
        {
            walkSound.Stop();
            recIsMove = false;
        }
        if (moveInput.x > 0 && !facingRight)
        {
            slant = -1;
            Flip();
        }
        if (moveInput.x < 0 && facingRight)
        {
            slant = 1;
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
