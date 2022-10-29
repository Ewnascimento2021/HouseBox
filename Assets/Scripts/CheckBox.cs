using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{

    public Sprite[] box = new Sprite[2];
    public SpriteRenderer spriteConcha;
    private Rigidbody2D rb;
    public bool checkBox;

    void Start()
    {
        //spriteConcha.sprite = box[0];
        rb = GetComponent<Rigidbody2D>();
        rb.GetComponent<SpriteRenderer>().sprite = box[0];
    }


    void Update()
    {

    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Base"))
        {
            rb.GetComponent<SpriteRenderer>().sprite = box[1];

            checkBox = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Base"))
        {
            rb.GetComponent<SpriteRenderer>().sprite = box[0];

            checkBox = false;
        }
    }

}
