using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Player player;

    private Text text;

	// Use this for initialization
	void Start ()
    {
        text = this.GetComponent<Text>();
        DisplayingScore(player.Score);
	}
	
	// Update is called once per frame
	void Update ()
    {
        DisplayingScore(player.Score);
    }

    private void DisplayingScore(int score)
    {
        if (score < 10)
        {
            text.text = "0" + score;
        }
        else
        {
            text.text = "" + score;
        }
    }
}
