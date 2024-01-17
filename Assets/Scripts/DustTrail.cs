using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (dustEffect != null && collision.gameObject.CompareTag("Ground"))
        {
            dustEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        dustEffect.Stop();
    }
}
