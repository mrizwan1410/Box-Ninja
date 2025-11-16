using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLevel : MonoBehaviour
{
    private GameManager gameManager;
    private Button button;

    public int difficulty;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDiificulty);
    }

    void SetDiificulty()
    {
        gameManager.StartGame(difficulty);
        Debug.Log(button.gameObject.name + "was clicked");
    }
}
