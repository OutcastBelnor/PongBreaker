using UnityEngine;
using System.Collections;

public class LeftCollider : MonoBehaviour
{
    public LevelManager levelManager;

    public void OnTriggerEnter2D (Collider2D trigger)
    {
        levelManager.LoadLevel("Win");
    }
}
