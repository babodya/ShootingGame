using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerBulletPrefabs;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundManager.instance.PlayerBulletSound();

            GameObject bullet = Instantiate(PlayerBulletPrefabs, transform.position, Quaternion.identity);
        }
    }
}
