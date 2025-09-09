using System;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] GameObject gameObject;

    [SerializeField] float speed = 5;
    [SerializeField] float jumpStrenght = 2;

    Rigidbody2D rb;

    float horizontalMove;
    bool facingRight;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");

        

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
        
    }

}
