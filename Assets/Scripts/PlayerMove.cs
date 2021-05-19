using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float speed = 8.0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(horizontal, vertical, 0f);

        transform.Translate(dir * Time.deltaTime * speed);

    }

}
