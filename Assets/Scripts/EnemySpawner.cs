using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyObjects;
    public float spawnCooldown = 2;

    public float minPosition;
    public float maxPosition;

    public float minEnemySpeed;
    public float maxEnemySpeed;

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
        // get random position to spawn at
        Vector3 randomPosition = transform.position;
        randomPosition.y = Random.Range(minPosition, maxPosition);

        // get random enemy prefab from list
        int targetEnemyIndex = Random.Range(0, enemyObjects.Length);
        GameObject enemyPrefab = enemyObjects[targetEnemyIndex];

        // spawn the enemy
        GameObject enemy = Object.Instantiate(enemyPrefab, randomPosition, transform.rotation);

        float randomSpeed = Random.Range(minEnemySpeed, maxEnemySpeed);
        EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
        enemyMovement.moveSpeed = randomSpeed; 
    }
}
