using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Transform Me;
    public GameObject Ball;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(SpawnBall());
    }

    public IEnumerator SpawnBall()
    {

        yield return new WaitForSeconds(1f);

        Vector3 spawnPlace = new Vector3(Random.Range(Me.position.x + 1, Me.position.x - 1), Random.Range(Me.position.y + 1, Me.position.y - 1), Random.Range(Me.position.z + 1, Me.position.z - 1));
        Instantiate(Ball, spawnPlace, Quaternion.identity);
    }

}
