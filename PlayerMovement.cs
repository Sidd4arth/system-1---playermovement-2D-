using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool facingRight = true;
    void Update()
    {
        float move = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            move = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = 1f;
        }

        transform.Translate(move * moveSpeed * Time.deltaTime, 0f, 0f);
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

        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
        facingRight = !facingRight;
    }
}

