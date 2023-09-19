using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int a;
    public int op_1 = 1;
    public int op_2 = 1;
    private Rigidbody2D rb;
    public float speed;
    float move_x;
    float move_y;

    bool jump;

    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 8;
        rb.gravityScale = 8;
    }

    // Update is called once per frame
    void Update()
    {
        print(op_1 + op_2);

        move_x = Input.GetAxis("Horizontal");
        move_y = Input.GetAxis("Vertical");

        // Ajustar la velocidad vertical basada en la dirección horizontal
        float verticalVelocity = rb.velocity.y;
        if (Mathf.Abs(move_x) > 0)
        {
            verticalVelocity = Mathf.Abs(move_x) * 10; // Ajusta la velocidad vertical aquí
        }

        rb.velocity = new Vector2(10 * move_x, verticalVelocity);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, 50);
        }
    }
}
