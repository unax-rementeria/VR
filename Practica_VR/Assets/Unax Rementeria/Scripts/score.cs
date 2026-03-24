using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI scoreText;

    [Header("Settings")]
    [SerializeField] private string prefix = "Score: ";

    public int _score = 0;

    void Start()
    {
        UpdateDisplay();
    }

    public void AddScore()
    {
        
        _score ++;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (_score < 20)
        {
            scoreText.text = prefix + _score.ToString();
        }
        else
        {
            scoreText.text = "Has Ganado!";
        }
    }
}
