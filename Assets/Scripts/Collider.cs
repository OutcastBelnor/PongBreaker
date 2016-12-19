using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour
{
    public LevelManager levelManager;
    public Player player;
    public Player loser;
    public Ball ball;

    private void OnTriggerEnter2D (Collider2D trigger)
    {
        if (player.Score >= 3)
        {
            levelManager.LoadLevel("Win");
        }
        else
        {
            player.addPoints(1);
            ball.setBallPos(loser.transform.position);
        }
    }
}
