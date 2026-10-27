using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float jumpPower;
    public float moveSpeed;
    private Rigidbody2D rb;

    private float jumpStatus;
    private float movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (jumpStatus > float.Epsilon)
        {
            rb.AddForce(Vector2.up * jumpPower * Time.fixedDeltaTime, ForceMode2D.Force);
        }
        else
        {
            // do nothing!
        }
        rb.linearVelocityX = movement * moveSpeed * Time.fixedDeltaTime;

        //rb.MovePosition(transform.position + Vector3.right * Time.fixedDeltaTime);
    }


    // instead of a jump, make it a jetpack

    public void OnJetpack(InputValue input)
    {
        jumpStatus = input.Get<float>();
    }


    public void OnMovement(InputValue input)
    {
        movement = input.Get<float>();
    }
}
