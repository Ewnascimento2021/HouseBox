using Ewerton.Housebox.Menu;
using UnityEngine;

namespace Ewerton.Housebox.Box
{
    public class CheckBox : MonoBehaviour
    {
        [SerializeField]
        private Sprite[] box = new Sprite[2];
        public Sprite[] Box => box;

        public bool IsBoxChecked { get; set; }

        private Rigidbody2D rb;
        private Sprite currentSprite;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            currentSprite = GetComponent<SpriteRenderer>().sprite;
            SetSprite(Box[0]);
        }

        private void SetSprite(Sprite newSprite)
        {
            currentSprite = newSprite;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Base"))
            {
                SetSprite(Box[1]);
                IsBoxChecked = true;
                HUDController.Instance.gameScore += 1;
            }
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Base"))
            {
                SetSprite(Box[0]);
                IsBoxChecked = false;
                HUDController.Instance.gameScore -= 1;
            }
        }
    }
}
