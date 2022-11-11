using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_object : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    float speed=1;
    void FixedUpdate()
    {
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
