using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public RotationSphere target;

    public TextMesh scoreText;
    public TextMesh gameOverText;
    public TextMesh highScoreText;

    public GameObject CongratultionsText;
    public GameObject YouMadeText;

    bool gameover = false;

    float score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Knife")
        {
            /* if (target.angularVelocity == target.angularVelocity1)
                 score = score + 5;
             else if (target.angularVelocity == target.angularVelocity2)
                 score = score + 10;
             else if (target.angularVelocity == target.angularVelocity3)
                 score = score + 20;
             */

            score = score + 5;
        }
        
        else
        {
            gameover = true;
        }
        
        scoreText.text = score.ToString();
        gameOverText.text = scoreText.text;
        if(score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", score);
            highScoreText.text = score.ToString();
            if(gameover)
            {
                CongratultionsText.SetActive(true);
                YouMadeText.SetActive(true);
            }            
        }
        
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }

}
