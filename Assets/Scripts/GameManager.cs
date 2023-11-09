using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform pipeSpawnLocation;

    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public Action OnGameEnd;
    public bool isGameOver = false;

    public Action<int> OnScoreGained;
    private int score = 0;
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver && Input.GetMouseButtonDown(0))
        {
            Restart();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        StartCoroutine(GameOverCoroutine());
    }

    public void GainScore()
    {
        score++;
        OnScoreGained?.Invoke(score);
    }

    IEnumerator GameOverCoroutine()
    {
        yield return new WaitForSeconds(1f);
        OnGameEnd?.Invoke();
    }

    private void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
