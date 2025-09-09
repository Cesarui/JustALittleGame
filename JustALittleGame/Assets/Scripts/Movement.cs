using System;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] GameObject gameObject;

    [SerializeField] float speed = 5;
    [SerializeField] float jumpStrenght = 2;
    [SerializeField] float jumpCooldown = 0.5f;

    Rigidbody2D rb;

    float horizontalMove;

    float jumpInput;
    float jumpTimer = 0.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        jumpTimer -= Time.deltaTime;

        horizontalMove = Input.GetAxisRaw("Horizontal");
        jumpInput = Input.GetAxisRaw("Jump");

        Debug.Log(horizontalMove);

        if(horizontalMove == -1)
        {
            rb.transform.Translate(Vector2.left * speed * horizontalMove);
            rb.transform.eulerAngles = new Vector2(0, 180);
            
        }
        else if(horizontalMove == 1)
        {
            rb.transform.Translate(Vector2.right * speed * horizontalMove);
            rb.transform.eulerAngles = new Vector2(0, 0);
        }

        Debug.Log(jumpTimer);
        Debug.Log(jumpInput);

        if (jumpInput > 0 && jumpTimer <= 0)
        {
            Jump();
        }
        
    }

    void Jump()
    {
        
        rb.AddForceY(jumpStrenght, ForceMode2D.Impulse);
        jumpTimer = jumpCooldown;

    }

}
