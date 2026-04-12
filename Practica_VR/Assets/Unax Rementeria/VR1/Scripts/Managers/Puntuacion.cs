using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    [SerializeField] private score score;
    [SerializeField] private TMP_Dropdown scoreDropdown;

    private readonly List<int> scoreOptions = new List<int> { 5, 10, 20, 40, 60 };

    private void Awake()
    {
        if (score == null)
        {
            score = FindObjectOfType<score>();
        }

        if (scoreDropdown != null)
        {
            scoreDropdown.ClearOptions();
            var optionStrings = new List<string>();
            foreach (var value in scoreOptions)
            {
                optionStrings.Add(value.ToString());
            }

            scoreDropdown.AddOptions(optionStrings);
            scoreDropdown.onValueChanged.AddListener(OnScoreDropdownChanged);
            scoreDropdown.value = 0;
            OnScoreDropdownChanged(0);
        }
    }

    public void OnScoreDropdownChanged(int index)
    {
        if (score == null)
        {
            Debug.LogWarning("Score reference not assigned in Puntuacion.");
            return;
        }

        if (index < 0 || index >= scoreOptions.Count)
        {
            Debug.LogWarning("Dropdown index out of range.");
            return;
        }

        score.SetMaxScore(scoreOptions[index]);
        Debug.Log($"Max Score set to {scoreOptions[index]}");
    }
}
