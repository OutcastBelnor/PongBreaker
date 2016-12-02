using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
    public int hitPoints;

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (hitPoints <= 0)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            hitPoints--;
        }
    }	
}
