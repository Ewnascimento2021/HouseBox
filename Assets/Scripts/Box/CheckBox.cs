using Ewerton.Housebox.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ewerton.Housebox.Box
{
    public class CheckBox : MonoBehaviour
    {
        private Sprite[] box = new Sprite[2];
        public Sprite[] Box => box;

        public bool IsBoxCheckd { get; }

        private Rigidbody2D rb;

        void Start()
        {
            //spriteConcha.sprite = box[0];
            rb = GetComponent<Rigidbody2D>();
            rb.GetComponent<SpriteRenderer>().sprite = Box[0];
        }


        void Update()
        {

        }



        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Base"))
            {
                rb.GetComponent<SpriteRenderer>().sprite = Box[1];

                IsBoxCheckd = true;

                HUDController.Instance.gameScore += 1;
            }
        }
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Base"))
            {
                rb.GetComponent<SpriteRenderer>().sprite = Box[0];

                IsBoxCheckd = false;

                HUDController.Instance.gameScore -= 1;
            }
        }

    }
}


