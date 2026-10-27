using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
    }
}
