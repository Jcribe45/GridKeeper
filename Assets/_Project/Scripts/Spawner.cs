using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public EnemyFactory factory;
    public Path path;
    public EnemyData fastRunnerData;
    public EnemyData basicWalkerData;
    public float spawnInterval = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnWave()
    {
        factory.Create(basicWalkerData, path.Waypoints[0]);
        yield return new WaitForSeconds(spawnInterval);
        factory.Create(fastRunnerData, path.Waypoints[0]);
    }

}
