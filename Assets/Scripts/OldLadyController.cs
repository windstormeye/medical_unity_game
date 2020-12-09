using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLadyController : MonoBehaviour
{
    private Rigidbody2D rb;
    private FixedJoystick joystick;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<FixedJoystick>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        // 按钮操作
        float horizontalInput = joystick.Horizontal;
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);


        if (horizontalInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (horizontalInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
