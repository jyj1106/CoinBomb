using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    Vector3[] positions = new Vector3[4];

    public GameObject Bomb;
    public bool isSpawn = false;
    public float spawnDelay = 1.5f;
    float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        CreatePositions();
    }

    void CreatePositions() 
    {
        float viewPosX = 10f;
        float gapY = 1f;

        float viewPosY = 0f;
        for(int i = 0; i < positions.Length; i++)
        {
            viewPosY = gapY + gapY * i;
            Vector3 worldPos = new Vector3(viewPosX, viewPosY, 0);
            worldPos.z = 0f;
            positions[i] = worldPos;
            print(worldPos);
        }
    }

    void SpawnEnemy()
    {
        if(isSpawn == true)
        {
            if(spawnTimer > spawnDelay)
            {
                
                for(int i = 0; i < positions.Length; i++)
                {
                    Instantiate(Bomb, positions[i], Quaternion.identity);
                }
                spawnTimer = 0f;
                /*
                int rand = Random.Range(0, positions.Length);
                Instantiate(Bomb, positions[rand], Quaternion.identity);
                spawnTimer = 0f;
                */
            }
            spawnTimer += Time.deltaTime;
        }
    }
    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }
}
