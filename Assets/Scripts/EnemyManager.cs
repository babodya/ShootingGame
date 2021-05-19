using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Enemy Prefab
    [SerializeField]
    GameObject enemyPrefab;

    // 생성 최대 시간
    [SerializeField]
    int maxTime = 3;

    // 생성 최소 시간
    [SerializeField]
    int minTime = 1;

    // 생성 시간
    int ranTime = 0;

    // 현재 시간
    float startTime = 0;

    void Start()
    {
        //1초 후 1초마다 CreateEnemy 호출
        //InvokeRepeating("CreateEnemy", 1, 1);
        
    }

    void Update()
    {
        startTime += Time.deltaTime;

        if (startTime > ranTime)
        {
            CreateEnemy();
        }
    }

    void CreateEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        startTime = 0;

        ranTime = Random.Range(minTime, maxTime);
    }
}
