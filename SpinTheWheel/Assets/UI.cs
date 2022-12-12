using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public static bool IsGameOver;
    [SerializeField] GameObject spinButton;
    [SerializeField] GameObject gameOverTextObject;
    [SerializeField] GameObject restartGameButton;
    [SerializeField] ObjectTransporterAndUI objectTransporterAndUI;
    void Start()
    {
        IsGameOver = false;
    }
    // Start is called before the first frame update
    public void GameOver()
    {
        IsGameOver = true;
        spinButton.SetActive(false);
        gameOverTextObject.SetActive(true);
        objectTransporterAndUI.DestroyObjects();
        restartGameButton.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
