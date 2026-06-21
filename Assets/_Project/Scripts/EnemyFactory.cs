using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Path path;

    public void Create(EnemyData enemyData, Vector3 position)
    {
        GameObject enemyGO = Instantiate(enemyPrefab, position, Quaternion.identity);
        Enemy enemy = enemyGO.GetComponent<Enemy>();
        enemy.path = path;
        enemy.enemyData = enemyData;
    }
}
