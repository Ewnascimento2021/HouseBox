using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            if (!quantBox[i].GetComponent<CheckBox>().checkBox)
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


