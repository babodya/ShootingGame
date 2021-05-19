using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    AudioSource EnemyDie;

    [SerializeField]
    AudioSource PlayerDie;

    [SerializeField]
    AudioSource PlayerBullet;


    void Start()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    public void EnemyDieSound()
    {
        EnemyDie.Play();
    }

    public void PlayerDieSound()
    {
        PlayerDie.Play();
    }

    public void PlayerBulletSound()
    {
        PlayerBullet.Play();
    }
}
