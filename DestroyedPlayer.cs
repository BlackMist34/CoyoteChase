using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedPlayer : MonoBehaviour, IDestructible
{
    public GameObject gameManager;

    public void OnDestruction()
    {
        gameManager.GetComponent<GameManager>().InitiatePlayerDeath();

        Destroy(this.gameObject);
    }
}
