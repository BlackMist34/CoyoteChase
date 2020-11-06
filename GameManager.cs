using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deathScreen;

    public void InitiatePlayerDeath()
    {
        deathScreen.SetActive(true);
    }
}
