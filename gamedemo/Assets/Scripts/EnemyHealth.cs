using UnityEngine;

public class EnemyHealth : Health
{
    [Header("Explosion Sound")]
    public AudioClip explosionSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    protected override void Die()
    {
        // Phát âm thanh nổ trước
        if (explosionSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(explosionSound);
        }

        Debug.Log("Enemy died");

        // Huỷ enemy sau 0.3 giây để kịp phát sound
        Destroy(gameObject, 0.3f);
    }
}