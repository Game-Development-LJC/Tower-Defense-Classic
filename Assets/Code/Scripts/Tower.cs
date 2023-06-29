using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform targetObject;
    
    public float fireRate = 1f;
    
    private float nextFireTime;

    public void ShootProjectile()
    {
        if (targetObject != null)
        {
            // Calculate direction towards the target object
            Vector2 direction = (targetObject.position - transform.position).normalized;

            // Instantiate the projectile
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // Set the direction for the projectile to move towards the target object
            Projectile projectileComponent = projectile.GetComponent<Projectile>();
            if (projectileComponent != null)
            {
                projectileComponent.SetDirection(direction);
            }
        }
    }

    // Example usage: Call this function from another script or event to trigger the tower to shoot
    void Update()
    {
        // Check if enough time has passed to fire another projectile
        if (Time.time >= nextFireTime)
        {
            // Fire projectile and set the next allowed fire time
            ShootProjectile();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
}
