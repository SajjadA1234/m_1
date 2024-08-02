using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePor : MonoBehaviour
{

public static ScorePor instance;

[SerializeField] private TextMeshProUGUI _ScoreNumbText;
[SerializeField] private TextMeshProUGUI _HighScoreText;
private int _Score;


private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
////////////////////////
    void Start()
    {
        _ScoreNumbText.text = _Score.ToString();
        _HighScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }
///////////////////////
    private void UpdateHighScore()
    {
        if (_Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _Score);
            _HighScoreText.text = _Score.ToString();
        }
    }
//////////////////////
    public void UpdateScore()
    {
        _Score++;
        _ScoreNumbText.text = _Score.ToString();
        UpdateHighScore();
    }
}
