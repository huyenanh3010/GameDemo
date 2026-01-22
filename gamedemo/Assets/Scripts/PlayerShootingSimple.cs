using UnityEngine;

public class PlayerShootingSim : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, transform.position,
            transform.rotation);
        }
    }
}