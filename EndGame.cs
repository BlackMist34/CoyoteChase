using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject finishLine;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;

        finishLine.SetActive(true);
    }
}
