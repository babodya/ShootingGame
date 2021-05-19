using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Enemy Prefab
    [SerializeField]
    GameObject enemyPrefab;

    // ���� �ִ� �ð�
    [SerializeField]
    int maxTime = 3;

    // ���� �ּ� �ð�
    [SerializeField]
    int minTime = 1;

    // ���� �ð�
    int ranTime = 0;

    // ���� �ð�
    float startTime = 0;

    void Start()
    {
        //1�� �� 1�ʸ��� CreateEnemy ȣ��
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
