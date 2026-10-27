using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyObject;
    public float spawnCooldown = 2;

    public float minPosition;
    public float maxPosition;

    private float timer;

    private void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnCooldown)
        {
            timer = 0;
            SpawnEnemy();
        }
    }


    private void SpawnEnemy()
    {
        Vector3 randomPosition = transform.position;
        randomPosition.y = Random.Range(minPosition, maxPosition);
        Object.Instantiate(enemyObject, randomPosition, transform.rotation);
    }
}
