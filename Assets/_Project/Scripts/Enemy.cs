using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Path path;
    private int currentWaypointIndex = 0;
    public EnemyData enemyData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = path.Waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, enemyData.speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPosition) < 0.05f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= path.Waypoints.Length)
            {
                Debug.Log("Enemy has reached the end of the path.");
                Destroy(gameObject); // Destroy the enemy object when it reaches the end of the path
            }
        }
    }
}
