using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace Ewerton.Housebox.Menu
{
    public class HUDController : MonoBehaviour
    {

        static HUDController instance;
        public static HUDController Instance
        {
            get
            {
                if (instance == null)
                    instance = FindObjectOfType<HUDController>();
                return instance;
            }
        }

        public int gameScore;
        public int pointsBox;

        [SerializeField]
        private TMP_Text scoreText;

        void Start()
        {
        
        }


        private void FixedUpdate()
        {
            ScoreUp();
        }
        public void ScoreUp()
        {
            scoreText.text = "Boxes: " + gameScore.ToString();
        }
    }
}

