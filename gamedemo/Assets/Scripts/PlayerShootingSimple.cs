using UnityEngine;

public class PlayerShootingSim : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval;
    private float lastBulletTime;

    void Update()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}