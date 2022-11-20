using Ewerton.Housebox.Box;
using UnityEngine;

namespace Ewerton.Housebox.GameCore
{
    public class GameController : MonoBehaviour
    {
        // TODO: Converter para property ou deixar como private já que vc faz o FindGameObjectsWithTag no Start
        // Se já sabe os objetos eu recomendo já adicionar no array via inspector, se não é OK deixar assim.
        // Também notei que você faz um GetComponent, recomendo fazer um array de CheckBox:
        // public CheckBox[] quantBox;

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
            // TODO: Acho que dá para deixar esse loop um pouco mais fácil de ler e trocar a variavel boxCount pelo i do for.
            // Por exemplo:
            /*
            for (int i = 0; i < quantBox.Length; i++)
            {
                if (quantBox[i].GetComponent<CheckBox>().IsBoxChecked)
                {
                    continue;
                }

                if (i == quantBox.Length)
                {
                    //TODO: Chamar Proxima Fase;
                }
            }
            */

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
