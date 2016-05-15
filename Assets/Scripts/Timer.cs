using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public float timeLeft;
    public Text timerText;

    public int score;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        timeLeft = 30;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if ( (timeLeft-Time.deltaTime) > 0 )
        {
            timeLeft -= Time.deltaTime;

            int intTime = Mathf.FloorToInt(timeLeft);
            timerText.text = "Time Left: " + intTime.ToString();
        }

        // Time's up!
        else
        {
            timeLeft = 0;
            int intTime = Mathf.FloorToInt(timeLeft);
            timerText.text = "Time Left: " + intTime.ToString();
        }
        
	}

    public void UpdateScore(int newScore)
    {
        score = newScore;
        scoreText.text = "Score: " + score.ToString();
    }
}
