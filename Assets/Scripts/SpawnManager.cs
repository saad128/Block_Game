using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    //public GameObject[] obstacleArray;
    private float spawnPosZ = 2.5f;
    public float x0,x1,x2,x3,x4;
    private DetectCollisions detectCollisionsScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SecondSpawnObstacle", 1f, 2.0f);
        detectCollisionsScript = GameObject.Find("Player").GetComponent<DetectCollisions>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SecondSpawnObstacle()
    {
        if (detectCollisionsScript.isGameOver == false)
        {
            int arrayIndex;
            arrayIndex = Random.Range(0, 5);
            if (arrayIndex < 1)
            {
                Vector3 spawnPos = new Vector3(x1, 0, spawnPosZ);
                Instantiate(obstaclePrefab[1], spawnPos, obstaclePrefab[1].transform.rotation);
                Vector3 spawnPos1 = new Vector3(x2, 0, spawnPosZ);
                Instantiate(obstaclePrefab[2], spawnPos1, obstaclePrefab[2].transform.rotation);
                Vector3 spawnPos2 = new Vector3(x3, 0, spawnPosZ);
                Instantiate(obstaclePrefab[3], spawnPos2, obstaclePrefab[3].transform.rotation);
                Vector3 spawnPos3 = new Vector3(x4, 0, spawnPosZ);
                Instantiate(obstaclePrefab[4], spawnPos3, obstaclePrefab[4].transform.rotation);
            }
            else if (arrayIndex < 2)
            {
                Vector3 spawnPos = new Vector3(x0, 0, spawnPosZ);
                Instantiate(obstaclePrefab[0], spawnPos, obstaclePrefab[0].transform.rotation);
                Vector3 spawnPos1 = new Vector3(x2, 0, spawnPosZ);
                Instantiate(obstaclePrefab[2], spawnPos1, obstaclePrefab[2].transform.rotation);
                Vector3 spawnPos2 = new Vector3(x3, 0, spawnPosZ);
                Instantiate(obstaclePrefab[3], spawnPos2, obstaclePrefab[3].transform.rotation);
                Vector3 spawnPos3 = new Vector3(x4, 0, spawnPosZ);
                Instantiate(obstaclePrefab[4], spawnPos3, obstaclePrefab[4].transform.rotation);

            }
            else if (arrayIndex < 3)
            {
                Vector3 spawnPos = new Vector3(x0, 0, spawnPosZ);
                Instantiate(obstaclePrefab[0], spawnPos, obstaclePrefab[0].transform.rotation);
                Vector3 spawnPos1 = new Vector3(x1, 0, spawnPosZ);
                Instantiate(obstaclePrefab[1], spawnPos1, obstaclePrefab[1].transform.rotation);
                Vector3 spawnPos2 = new Vector3(x3, 0, spawnPosZ);
                Instantiate(obstaclePrefab[3], spawnPos2, obstaclePrefab[3].transform.rotation);
                Vector3 spawnPos3 = new Vector3(x4, 0, spawnPosZ);
                Instantiate(obstaclePrefab[4], spawnPos3, obstaclePrefab[4].transform.rotation);

            }
            else if (arrayIndex < 4)
            {
                Vector3 spawnPos = new Vector3(x0, 0, spawnPosZ);
                Instantiate(obstaclePrefab[0], spawnPos, obstaclePrefab[0].transform.rotation);
                Vector3 spawnPos1 = new Vector3(x1, 0, spawnPosZ);
                Instantiate(obstaclePrefab[1], spawnPos1, obstaclePrefab[1].transform.rotation);
                Vector3 spawnPos2 = new Vector3(x2, 0, spawnPosZ);
                Instantiate(obstaclePrefab[2], spawnPos2, obstaclePrefab[2].transform.rotation);
                Vector3 spawnPos3 = new Vector3(x4, 0, spawnPosZ);
                Instantiate(obstaclePrefab[4], spawnPos3, obstaclePrefab[4].transform.rotation);

            }
            else if (arrayIndex < 5)
            {
                Vector3 spawnPos = new Vector3(x0, 0, spawnPosZ);
                Instantiate(obstaclePrefab[0], spawnPos, obstaclePrefab[0].transform.rotation);
                Vector3 spawnPos1 = new Vector3(x1, 0, spawnPosZ);
                Instantiate(obstaclePrefab[1], spawnPos1, obstaclePrefab[1].transform.rotation);
                Vector3 spawnPos2 = new Vector3(x2, 0, spawnPosZ);
                Instantiate(obstaclePrefab[2], spawnPos2, obstaclePrefab[2].transform.rotation);
                Vector3 spawnPos3 = new Vector3(x3, 0, spawnPosZ);
                Instantiate(obstaclePrefab[3], spawnPos3, obstaclePrefab[3].transform.rotation);

            }
        }
    }
}
