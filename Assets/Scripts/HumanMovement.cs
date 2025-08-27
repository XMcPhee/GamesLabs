using System.Security.Cryptography;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class HumanMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public bool isGrounded = false;
    public float lastDirection = 1f;
    private Rigidbody2D rigidBody;
    private Transform playerTransform;
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigidBody.linearVelocityY, 0f);

        float currentDirection = Input.GetAxisRaw("Horizontal");
        playerTransform.localScale = new Vector2(lastDirection = currentDirection != 0 ? currentDirection : lastDirection, playerTransform.localScale.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            spriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            rigidBody.linearVelocityY += jumpForce;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
