using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public LevelManager levelManager;
    public Ball ball;

    public bool isPlayerOne = false;
    public bool isPlayerTwo = false;

    private float moveSpeed;
    private float axis;
    private float movementValue;
    private int score;

    void Start()
    {
        moveSpeed = 5f;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerOne)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                PlayerMovement();
            }
        }
        else if (isPlayerTwo)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                PlayerMovement();
            }
        }
    }

    // Responsible for players movement
    private void PlayerMovement ()
    {
        axis = Input.GetAxisRaw("Vertical");
        movementValue = moveSpeed * axis * Time.deltaTime; // gets the value of the movement (direction)

        this.transform.Translate(0f, movementValue, 0f); // moves the player
        this.transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(this.transform.position.y, 0.96f, 8.333f), 0f); // clamps the player in the game screen
    }

    private void AIMovement ()
    {
        Vector3 ballPos = ball.transform.position;

        if (ballPos.x >= 8f)
        {
            movementValue = Mathf.Clamp(ballPos.y - this.transform.position.y, 0.5f, 15.5f);
            this.transform.position = new Vector3(this.transform.position.x, movementValue, 0f);
        }
    }

    public int Score
    {
        get { return score; }
    }

    // This method adds points to the score
    public void AddPoints(int points)
    {
        score += points;
    }

    // Loads appropriate win screen
    public void LoadWinScreen()
    {
        if (isPlayerOne)
        {
            levelManager.LoadLevel("PlayerOneWin");
        }
        else if (isPlayerTwo)
        {
            levelManager.LoadLevel("PlayerTwoWin");
        }
    }
}
