using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spavner : MonoBehaviour
{
    
    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject Sprits_rectangle;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(Sprits_rectangle, pos, Quaternion.identity);
        Repeat();
    }
    void Repeat()
    {
        StartCoroutine(Spawn());
    }

}
