using UnityEngine;

public class PlayerShootingSimple : MonoBehaviour
{
    [Header("Bullet Settings")]
    public GameObject bulletPrefabs;
    public float shootingInterval = 0.3f;
    public Vector3 bulletOffset;

    [Header("Sound Settings")]
    public AudioClip shootSound;   // File âm thanh bắn
    private AudioSource audioSource;

    private float lastBulletTime;

    void Start()
    {
        // Lấy AudioSource gắn trên Player
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        // Tạo đạn
        Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);

        // Phát âm thanh bắn
        if (shootSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(shootSound);
        }
    }
}