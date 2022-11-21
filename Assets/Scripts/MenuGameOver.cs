using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuGameOver : MonoBehaviour
{
    [SerializeField]
    private Button goToMenu;


    private void Awake()
    {
        Time.timeScale = 1;
        goToMenu.onClick.AddListener(ExitToMenu);
    }
    private void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

