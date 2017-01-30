using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour
{
    public Player player;
    public Player loser;
    public Ball ball;

    private void OnTriggerEnter2D (Collider2D trigger) // called when the ball touches the collider
    {
        if (player.Score >= 2) // when player accumulates 3 points (2 cause starting from zero) wins
        {
            player.loadWinScreen(); // call to the player's method
        }
        else
        {
            player.addPoints(1); // adds points to the right player
            ball.setBallPos(loser.transform.position); // the losing player gets the ball
        }
    }
}
