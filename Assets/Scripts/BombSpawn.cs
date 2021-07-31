using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    Vector3[] positions = new Vector3[7];

    public GameObject Bomb;
    public bool isSpawn = false;
    public static float spawnDelay = 2.5f;
    float spawnTimer = 0f;
    // Start is called before the first frame update

    void Start()
    {
        CreatePositions();
    }
    void CreatePositions()
    {
        float viewPosX = 11f;

        float viewPosY = 0f;
        for (int i = 0; i < positions.Length; i++)
        {
            float rand = Random.Range(-2, 4);
            viewPosY = rand;
            Vector3 worldPos = new Vector3(viewPosX, viewPosY, 0);
            worldPos.z = 0f;
            positions[i] = worldPos;
            print(worldPos);
        }
    }

    void SpawnBomb()
    {
        if (spawnTimer > spawnDelay)
        {
            int rand = Random.Range(0, positions.Length);
            Instantiate(Bomb, positions[rand], Quaternion.identity);
            spawnTimer = 0f;
        }
        spawnTimer += Time.deltaTime;

    }
    // Update is called once per frame
    void Update()
    {
        SpawnBomb();
    }
}
