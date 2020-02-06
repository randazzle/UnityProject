﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Manager))]
public class GameController : MonoBehaviour {

    public static GameController Instance { get; private set; }

    [Header("Knife Spawning")]
    [SerializeField]
    private Vector3 positionOfKnife;    
    [SerializeField]
    private GameObject KnifePrefab;

    public Manager GameUI { get; private set; }


    private void Awake()
    {
        Instance = this;
        GameUI = GetComponent<Manager>();
    }
    private void Start()
    {
        SpawnKnife();
    }

    public void HitTarget()
    {
        SpawnKnife();
        //NOT COMPLETE
    }

    private void SpawnKnife()
    {
        Instantiate(KnifePrefab, positionOfKnife, this.transform.rotation);
    }

    public void GameOver(bool win)
    {
        StartCoroutine("GameOverCoroutine", win);
    }

    private IEnumerator GameOverCoroutine(bool win)
    {
        if(win)
        {
            yield return new WaitForSecondsRealtime(0.5f);
        }
        else
        {
            yield return new WaitForSecondsRealtime(0.5f);
            GameUI.ShowRestartButton();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

}
