using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IGiveUpController : MonoBehaviour
{

    [SerializeField]
    private Button IGiveUpButton;


    private void Awake()
    {
        Time.timeScale = 1;
        IGiveUpButton.onClick.AddListener(ExitToMenu);
    }
    private void ExitToMenu()
    {
        SceneManager.LoadScene("GameOver");
    }
}
