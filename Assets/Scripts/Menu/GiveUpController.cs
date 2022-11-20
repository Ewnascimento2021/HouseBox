using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ewerton.Housebox.Menu
{
    public class GiveUpController : MonoBehaviour
    {
        [SerializeField]
        private Button IGiveUpButton;


        private void Awake()
        {
            //TODO: Esse timescale é realmente necessario?
            Time.timeScale = 1;
            IGiveUpButton.onClick.AddListener(ExitToMenu);
        }

        private void ExitToMenu()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}

