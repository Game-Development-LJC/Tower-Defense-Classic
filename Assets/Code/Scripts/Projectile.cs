using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform target;
    public float speed = 5f;
    private Vector2 direction;

    // Set the direction for the projectile to move
    public void SetDirection(Vector2 dir)
    {
        direction = dir;
    }

    private void Update()
    {
        // create a bullet script without a impact effect
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        // create a bullet script without a impact effect
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        
        if (dir.magnitude <= distanceThisFrame)
        {
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("collision");
            Destroy(gameObject);
        }

    }

    public void Seek(Transform _target)
    {
        target = _target;
    }
}
