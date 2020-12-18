using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLadyController : MonoBehaviour
{
    private Rigidbody2D rb;
    private FixedJoystick joystick;
    private Transform targetPoint;

    [Header("Movement")]
    public float speed;
    public Transform sofa;

    private bool canMove = false;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<FixedJoystick>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        CanMoveNextLevel();
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

        if (canMove)
        {
            MoveToSofa();
        }
    }


    public void MoveToSofa()
    {
        canMove = true;
        targetPoint = sofa;
        transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        
    }

    public void CanMoveNextLevel()
    {
        if (transform.position.x == targetPoint.transform.position.x)
        {
            UIManager.instance.NextLevel();
        }
    }
}
