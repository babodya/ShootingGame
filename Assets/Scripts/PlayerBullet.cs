using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;

    private void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    void Update()
    {
        float move = speed * Time.deltaTime;

        gameObject.transform.Translate(move, 0f, 0f);
    }
}
