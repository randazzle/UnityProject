using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public RotationSphere target;
    public Text scoreText;
    public Text gameOverText;

    float score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Knife")
        {
            if (target.angularVelocity == target.angularVelocity1)
                score = score + 5;
            else if (target.angularVelocity == target.angularVelocity2)
                score = score + 10;
            else if (target.angularVelocity == target.angularVelocity3)
                score = score + 20;
        }
        scoreText.text = score.ToString();
        gameOverText.text = scoreText.text;
    }

}
