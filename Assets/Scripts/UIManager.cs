using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
using TMPro;
#endif

public class UIManager : MonoBehaviour
{
    
    
    public TextMeshProUGUI HighscoreText;
    public TextMeshProUGUI playerName;

    public Slider difSlider;
    public TextMeshProUGUI difficultyText;

    // Start is called before the first frame update
    void Start()
    {
        HighscoreText.text = "Best Score : " + MenuManager.Instance.names[0] + " : " + MenuManager.Instance.points[0];
    }

    public void StartNew()
    {
        MenuManager.Instance.currentName = playerName.text;
        MenuManager.Instance.difficulty = difSlider.value;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // GameManager.Instance.SaveName();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SetDifficulty()
    {
        switch (difSlider.value)
        {
            case 3:
                difficultyText.text = "Difficult";
                break;
            case 2:
                difficultyText.text = "Normal";
                break;
            case 1:
                difficultyText.text = "Easy";
                break;
        }
    }

    public void BtnClassific()
    {
        SceneManager.LoadScene(2);
    }
}

