using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public float timeLeft;
    public Text timerText;

    public int cutiesPerPoint;
    public int numCutiesInCup;
    public int score;
    public Text scoreText;

    public static Timer instance;
    public GameObject GameOver;

	// Use this for initialization
	void Start () {
        instance = this;
        timeLeft = 30;
        score = 0;
        numCutiesInCup = 0;
        scoreText.text = "Score: " + score.ToString();

        GameOver.gameObject.SetActive(false);
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

            Time.timeScale = 0;
            GameOver.gameObject.SetActive(true);
        }
        
	}

    public void IncrementScore()
    {
        numCutiesInCup++;
        Debug.Log("Num Cuties in Cup: " + numCutiesInCup.ToString());

        if (numCutiesInCup == cutiesPerPoint)
        {
            score++;
            // Debug.Log(score.ToString());
            scoreText.text = "Score: " + score.ToString();
        }

    }

    public void DecrementScore()
    {
        numCutiesInCup--;
        Debug.Log("Num Cuties in Cup: " + numCutiesInCup.ToString());

        /*
            score--;
            Debug.Log(score.ToString());
            scoreText.text = "Score: " + score.ToString();
        */
    }
}
