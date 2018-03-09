using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public Vector3 angle;
    public float speed;
    private void Start()
    {
        angle = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        speed = Random.Range(2, 8);
    }

    void Update()
    {
        transform.Translate(angle * Time.deltaTime* speed, Space.World);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        angle = Vector3.Reflect(angle.normalized, collisionNormal);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bounce(collision.contacts[0].normal);
    }
}
