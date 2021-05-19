using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    float speed = 8.0f;

    private void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    void Update()
    {
        float move = speed * Time.deltaTime;

        gameObject.transform.Translate(-move, 0f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            SoundManager.instance.PlayerDieSound();

            print("player");
        }
        else if (other.tag == "Bullet")
        {
            SoundManager.instance.EnemyDieSound();

            Destroy(gameObject);

            print("bullet");
        }
        Destroy(other.gameObject);
    }
}
