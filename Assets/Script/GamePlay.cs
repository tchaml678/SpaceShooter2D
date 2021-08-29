using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public PlayerController playerHealth;
    public GameObject gameOverPanel;
    public GameObject bgSound;
    private void Start()
    {
        playerHealth.OnPlayerDied += OnPlayerDied;
    }

    private void OnPlayerDied()
    {
        Time.timeScale = 1f;
        gameOverPanel.SetActive(true);
        bgSound.SetActive(false);
    }
    public  void OnBtnPlayAgain()
    {
        SceneManager.LoadScene("MainPlayScene");
    }
}
