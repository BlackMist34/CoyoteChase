using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private GameObject player;
    private PlayerStats stats;

    private void Awake()
    {
        player = this.gameObject;
        stats = player.GetComponent<PlayerStats>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            stats.ReduceHealth();
    }
}
