using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f; // prędkość przemieszczania
    private Vector3 direction; // kierunek ruchu

    private void Start()
    {
        // losujemy kierunek ruchu
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    }

    private void Update()
    {
        // przesuwamy obiekt z prędkością i kierunkiem
        transform.position += direction * speed * Time.deltaTime;
    }
}
