using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour
{
    public LevelManager levelManager;

    private void OnTriggerEnter2D (Collider2D trigger)
    {
        levelManager.LoadLevel("Win");
    }
}
