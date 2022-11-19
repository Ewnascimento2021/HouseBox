using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ewerton.Housebox.Menu
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField]
        private Button startButton;


        private void Awake()
        {
            Time.timeScale = 1;
            startButton.onClick.AddListener(Fase1);
        }

        private void Fase1()
        {
            SceneManager.LoadScene("PrototypeScene");
        }
    }
}
