using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerSpriteHandler : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator playerAnimator;
    private SpriteRenderer spriteRenderer;

    private float horizontalSpeed = 5f;
    private float horizontalInput;
    private bool isFacingRight = true;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput < 0 && isFacingRight)
        {
            spriteRenderer.flipX = true;
            isFacingRight = false;
        }
        else if (horizontalInput > 0 && !isFacingRight)
        {
            spriteRenderer.flipX = false;
            isFacingRight = true;
        }

        playerAnimator.SetFloat("Speed", Mathf.Abs(body.velocity.x));
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontalInput * horizontalSpeed, body.velocity.y);
    }
}

