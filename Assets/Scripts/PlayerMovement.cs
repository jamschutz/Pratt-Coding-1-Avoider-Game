using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // make a script for the enemy that moves right at a constant speed
    public float moveSpeed;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy")) {
            gameObject.SetActive(false);
        }
        else if (other.CompareTag("Treat"))
        {
            Debug.Log("yay!!!");
        }
    }


    public void OnMove(InputValue input)
    {
        rb.linearVelocity = input.Get<Vector2>() * moveSpeed;
    }
}
