using Ewerton.Housebox.Menu;
using UnityEngine;

namespace Ewerton.Housebox.GameCore
{
    public class SavePrefs : MonoBehaviour
    {

        private int score;
        private int scoreAtual;

        // Start is called before the first frame update
        void Start()
        {
            score = HUDController.Instance.gameScore;
        }
        private void Update()
        {

        }

        private void BestPotuation()
        {

        }
    }
}
