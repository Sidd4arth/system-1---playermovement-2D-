using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    private bool facingRight = true; // Default facing right

    void Update()
    {
        float move = 0f;

        // Check for A (left) and D (right)
        if (Input.GetKey(KeyCode.A))
        {
            move = -1f; // Move left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = 1f; // Move right
        }

        // Apply movement (frame-rate independent)
        transform.Translate(move * moveSpeed * Time.deltaTime, 0f, 0f);

        // Flip sprite if direction changes
        if (move > 0f && !facingRight)
        {
            Flip();
        }
        else if (move < 0f && facingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        // Invert x-scale to flip sprite horizontally
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;

        // Update facing direction
        facingRight = !facingRight;
    }
}
