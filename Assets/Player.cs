using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpSpeed = 10;
    public float jumpHeight = 3;
    public LayerMask layerMask;
    
    public bool onGround;
    Rigidbody2D rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var hit = Physics2D.Raycast(transform.position, Vector2.down,0.7f,layerMask);
        onGround = hit.collider != null;
        
        
        if (onGround && Input.GetKeyDown(KeyCode.Space))
        {
            var speed = Mathf.Sqrt(jumpHeight * -rb.gravityScale * Physics2D.gravity.y * 2f);
            rb.velocity = Vector2.up * speed;
            onGround = false;
        }


        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed,rb.velocity.y);
    }
}
