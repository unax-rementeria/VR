using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI scoreText;

    [Header("Settings")]
    [SerializeField] private string prefix = "Score: ";



    public int _score = 0;
    public int MaxScore;

    public void SetMaxScore(int score)
    {
        MaxScore = score;
        UpdateDisplay();
    }

    void Start()
    {
        UpdateDisplay();
    }

    public void AddScore()
    {
        
        _score ++;
        UpdateDisplay();
    }

    public void MinusScore()
    {
        _score --;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (_score < MaxScore)
        {
            scoreText.text = prefix + _score.ToString();
        }
        else
        {
            scoreText.text = "Has Ganado!";
        }
    }
}
