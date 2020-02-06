using UnityEngine;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour {

	public void OnePlayer()
    {

        Debug.Log("OnePlayer Scene Loaded");
        SceneManager.LoadScene(1);

    }

    public void TwoPlayer()
    {

        Debug.Log("TwoPlayer Scene Loaded");
        SceneManager.LoadScene(2);

    }

    public void Quit()
    {
        Debug.Log("Quit Application");
        Application.Quit();

    }


}
