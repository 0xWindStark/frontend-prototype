using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;
using System.ComponentModel.Design;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score = 0;
    private int levelNumber = 1;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI levelNumberText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        AddScore(1);
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "SCORE : " + score.ToString();
        }
    }
    public void IncLevelNumber(int points)
    {
        levelNumber += points;
        UpdateLevelNumberText();
    }
    public void UpdateLevelNumberText()
    {
        levelNumberText.text = "LEVEL : " + levelNumber.ToString();
    }
}
