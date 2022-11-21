using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour

{
    public GameObject[] quantBox;
    private int boxCount;

    [SerializeField]
    private AudioSource Music;

    [SerializeField]
    private int faseNumber;


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
                    
                    faseNumber++;
                    
                    
                    switch (faseNumber)
                    {

                        case 2:
                            SceneManager.LoadScene("Fase2");
                            break;

                        case 3:
                            SceneManager.LoadScene("Fase3");
                            break;

                        case 4:
                            SceneManager.LoadScene("Fase4");
                            break;

                        case 5:
                            SceneManager.LoadScene("Fase5");
                            break;

                        case 6:
                            SceneManager.LoadScene("GameOver");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}


