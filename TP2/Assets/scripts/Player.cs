
using UnityEngine;
using UnityEngine.UI;
public class DinosaurController : MonoBehaviour
{   
    public float jumpForce = 10f;
    float score;

    bool isAlive = true;
    public bool isGrounded = false;

    private Rigidbody2D rb;

    public Text scoreText;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

        if (isAlive)
        {
            score += Time.deltaTime * 4;
            scoreText.text = ((int)score).ToString();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Cactus"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }
    }

}