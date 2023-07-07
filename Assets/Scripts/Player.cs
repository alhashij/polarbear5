using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;

    private float activeMoveSpeed; // Dash ability 
    public float dashSpeed;
    public float dashLength = 0.5f;
    public float dashCooldown = 1f;
    private float dashCounter;
    private float dashCoolCounter;

    private bool isDashing = false;
    private float nextDashTime;

    private void Start()
    {
        activeMoveSpeed = moveSpeed;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveDirection = Input.GetAxis("Horizontal");

        // Move left or right
        rb.velocity = new Vector2(moveDirection * activeMoveSpeed, rb.velocity.y);

        // Jump
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }

        // Dash
        if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time >= nextDashTime)
        {
            Dash(moveDirection);
            nextDashTime = Time.time + dashCooldown;
        }

        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;
            if (dashCounter <= 0)
            {
                activeMoveSpeed = moveSpeed;
            }
        }

        if (dashCoolCounter > 0)
        {
            dashCoolCounter -= Time.deltaTime;
        }
    }

    private void Dash(float moveDirection)
    {
        if (!isDashing)
        {
            isDashing = true;
            activeMoveSpeed = dashSpeed;
            dashCounter = dashLength;
            dashCoolCounter = dashCooldown;
            StartCoroutine(StopDashing());
        }
    }

    private IEnumerator StopDashing()
    {
        yield return new WaitForSeconds(dashLength);
        isDashing = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player is no longer touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}