using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public Player player;

    private Vector3 ballPos;
    private bool gameStarted = false;
    private string playerName;

	// Use this for initialization
	void Start ()
    {
        //playerName = player.name;
        ballPos = player.transform.position - this.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (!gameStarted)
        {
            this.transform.position = player.transform.position - ballPos;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameStarted = true;

                Rigidbody2D rigidbody2D = this.GetComponent<Rigidbody2D>();
                rigidbody2D.velocity = new Vector2(-10f, 2f);
            }
        }
	}

    private void OnCollision2D (Collision2D collision)
    {
        Vector2 correction = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));

        Rigidbody2D rigidbody2D = this.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity += correction;
    }
}
