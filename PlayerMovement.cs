using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameObject player;
    private Transform pos;
    private PlayerStats stats;

    private int xPos = 0;

    void Awake()
    {
        player = this.gameObject;
        pos = player.GetComponent<Transform>();
        stats = player.GetComponent<PlayerStats>();
    }

    void Update()
    {
        pos.Translate(0, 0, stats.GetSpeed() * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.D) && xPos < 2)
        {
            pos.Translate(1, 0, 0);
            xPos++;
        }
        else if (Input.GetKeyDown(KeyCode.A) && xPos > -2)
        {
            pos.Translate(-1, 0, 0);
            xPos--;
        }
    }
}
