using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    [SerializeField]
    private GameObject restartButton;
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private GameObject gameOverScore;
    [SerializeField]
    private GameObject Score;


        
	public void Back()
    {

        SceneManager.LoadScene(0);

    }

    public void ShowRestartButton()
    {
        
        gameOver.SetActive(true);
        gameOverScore.SetActive(true);
        restartButton.SetActive(true);

    }

    
}
