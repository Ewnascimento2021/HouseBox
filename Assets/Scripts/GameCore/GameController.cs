using Ewerton.Housebox.Box;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ewerton.Housebox.GameCore
{
    public class GameController : MonoBehaviour

    {
        public GameObject[] quantBox;
        private int boxCount;

        [SerializeField]
        private AudioSource Music;

        void Start()
        {
            quantBox = GameObject.FindGameObjectsWithTag("ObjToPush");
            Music.Play();
        }

        void Update()
        {
            boxCount = 0;

            for (int i = 0; i < quantBox.Length; i++)
            {
                if (!quantBox[i].GetComponent<CheckBox>().IsBoxChecked)
                {
                    break;
                }
                else
                {
                    boxCount++;
                    if (boxCount == quantBox.Length)
                    {
                        //TODO: Chamar Proxima Fase;
                    }
                }
            }
        }
    }
}
