using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour
{
    public LevelManager levelManager;
    public Ball ball;

    private bool gameStarted = true;
	
	// Update is called once per frame
	void Update ()
    {
        if (gameStarted)
        {
            Movement();
        }
	}

    public void StartGame ()
    {

    } 

    public void Movement ()
    {

    }
}
