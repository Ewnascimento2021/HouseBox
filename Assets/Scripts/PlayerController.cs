using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float horizontal;

    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
}
