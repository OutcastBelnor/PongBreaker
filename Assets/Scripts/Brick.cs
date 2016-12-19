using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
    public int hitPoints;
    //public Player player;

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (this.CompareTag("Breakable"))
        {
            if (hitPoints <= 0)
            {
                //player.addPoints(1);
                GameObject.Destroy(gameObject);
            }
            else
            {
                hitPoints--;
            }
        }
    }	
}
