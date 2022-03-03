using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public Button button;
    private GameManager gameManager;

    public int difficulty;
    void Start()
    {
        button.GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void SetDifficulty ()
    {
        gameManager.StartGame(difficulty);
    }
    
    void Update()
    {
        
    }
}
