using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] GameObject gameObject;

    [SerializeField] float speed = 5;
    [SerializeField] float jumpStrenght = 2;

    float horizontalMove;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(horizontalMove * speed * Time.deltaTime, 0, 0);
        Debug.Log(horizontalMove);

        if(horizontalMove < 0)
        {
            transform.Rotate(0, 180, 0);
        }
    }
}
