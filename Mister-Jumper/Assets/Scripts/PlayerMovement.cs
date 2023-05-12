using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float jumpForce = 10f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public LayerMask groundLayers;
    public Transform groundCheck;
    public float groundCheckRadius;
    public float speed = 10f;
    private bool isGrounded;
    public bool StayRotation;
    public float speedincrease;

    public void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayers);
        //Speed for the Player
        speed += speedincrease * Time.deltaTime;
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        //Checking if Player is on the ground
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jumpForce;
        }

        if (rb2d.velocity.y < -2.79f)
        {
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb2d.velocity.y > -2.79f && !Input.GetKey(KeyCode.Space))
        {
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
    public void Start()
    {
        if (StayRotation == true) {
            rb2d.freezeRotation = true;
        }
        else
        {
            rb2d.freezeRotation = false;
        }
    }
}