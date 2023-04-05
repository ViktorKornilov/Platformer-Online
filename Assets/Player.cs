using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpSpeed = 10;
    public float jumpHeight = 3;
    
    public bool onGround;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (onGround && Input.GetKeyDown(KeyCode.Space))
        {
            var speed = Mathf.Sqrt(jumpHeight * -rb.gravityScale * Physics2D.gravity.y * 2f);
            rb.velocity = Vector2.up * speed;
            onGround = false;
        }


        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed,rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        onGround = true;
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        onGround = false;
    }
}
