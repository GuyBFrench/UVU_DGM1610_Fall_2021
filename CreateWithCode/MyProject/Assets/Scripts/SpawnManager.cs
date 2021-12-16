using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int count;
    private Vector3 spawnPos;
    private Transform[] spawnPoints;
    private int spawnIndex;

    [SerializeField] private float enemySpawnTime = 3.0f;
    [SerializeField] private float startDelay = 2.0f;
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI enemiesKilled;
    [SerializeField] TextMeshProUGUI gameOverText;

    public GameObject titleScreen;
    public Button restartButton;
    public Button startButton;
    public bool gameActive;

    // Start is called before the first frame update
    void Start()
    {
        count = transform.childCount;
        spawnPoints = new Transform[count];
        for (int i = 0; i < count; i++)
        {
            spawnPoints[i] = transform.GetChild(i);

        }

        StartGame();


        //Froze Unity?
        // startButton.onClick.AddListener(StartGame);

    }

    public void StartGame()
    {
        gameActive = true;
        score = 0;
        KilledScore(0);
        titleScreen.SetActive(false);
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
    }

    public void SpawnRandomEnemy()
    {

        while (gameActive)
        {
            spawnIndex = Random.Range(0, count);
            int randomIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomIndex], spawnPoints[spawnIndex].position, enemies[randomIndex].gameObject.transform.rotation);
        }
        
    }

    public void KilledScore(int scoreToAdd)
    {
        score += scoreToAdd;
        enemiesKilled.text = "Enemies killed: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        gameActive = false;
    }
}
