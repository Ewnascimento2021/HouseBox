using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private Button startButton;
    [SerializeField]
    private AudioSource audioClick;
    [SerializeField]
    private Button quitButton;



    private void Awake()
    {
        Time.timeScale = 1;
        startButton.onClick.AddListener(Fase1);
        quitButton.onClick.AddListener(QuitGame);
    }

    private void Fase1()
    {
        audioClick.Play();
        SceneManager.LoadScene("Fase1");
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
