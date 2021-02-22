using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class GenerateObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstaclesSpawnPoint;

    private float time = 0;
    private float timeMax = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timeMax)
        {
            time = 0;
            spawnObstacle();
        }
    }

    private void spawnObstacle()
    {
        float rand = Random.Range(-25f, 25f);
        Vector3 pos = new Vector3(
            obstaclesSpawnPoint.transform.position.x,
            obstaclesSpawnPoint.transform.position.y + rand,
            obstaclesSpawnPoint.transform.position.z);
        Instantiate(
            obstaclePrefab,
            pos,
            obstaclesSpawnPoint.transform.rotation,
            transform);
    }
}