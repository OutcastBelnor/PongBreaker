using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public Player playerOne;
    public Player playerTwo;

    private Vector3 ballPos;
    private bool gameStarted = false;
    private string activePlayer = "one";

	// Use this for initialization
	void Start ()
    {
        ballPos = playerOne.transform.position - this.transform.position; // calculating starting position
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (!gameStarted)
        {
            if (activePlayer == "one") // ball starting position depends on the starting player
            {
                this.transform.position = playerOne.transform.position - ballPos;
            }
            else if (activePlayer == "two")
            {
                this.transform.position = playerTwo.transform.position - ballPos;
            }

            if (Input.GetKeyDown(KeyCode.Space)) // pressing space will start the game
            {
                gameStarted = true;

                Rigidbody2D rigidbody2D = this.GetComponent<Rigidbody2D>();
                rigidbody2D.velocity = new Vector2(-6f, 1f); // assigning starting velocity
            }
        }
	}

    // Detect collision with objects
    // and bounce off of them
    private void OnCollision2D (Collision2D collision)
    {
        Vector2 correction = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));

        Rigidbody2D rigidbody2D = this.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity += correction;
    }

    // Set the ball position at the losing player board
    // after each point lost
    public void setBallPos(Vector3 playerPos)
    {
        print("Setting ballPos...");

        if (playerPos.Equals(playerOne.transform.position))
        {
            activePlayer = "one";
        }
        else
        {
            activePlayer = "two";
        }

        Vector3 pos = playerPos;
        if (pos.x < 8)
        {
            pos.x += 0.4f;
        }
        else
        {
            pos.x -= 0.4f;
        }

        ballPos = playerPos - pos;
        gameStarted = false;
    }
}
