using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerMovimentScript : MonoBehaviour
{
    private GameObject[] obstacles;
    private GameObject[] objToPush;

    private bool toMove;
    void Start()
    {
        obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        objToPush = GameObject.FindGameObjectsWithTag("ObjToPush");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveinput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveinput.Normalize();

        if (moveinput.sqrMagnitude > 0.5)
        {
            if (toMove)
            {
                toMove = false;
                Move(moveinput);
            }
        }
        else
        {
            toMove = true;
        }
    }

    public bool Move(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) < 0.5)
        {
            direction.x = 0;
        }
        else
        {
            direction.y = 0;
        }
        direction.Normalize();

        if (Blocked(transform.position, direction))
        {
            return false;
        }
        else
        {
            transform.Translate(direction);
            return true;
        }
    }

    public bool Blocked(Vector3 position, Vector2 direction)
    {
        Vector2 newpos = new Vector2(position.x, position.y) + direction;

        foreach (var obj in obstacles)
        {
            if (obj.transform.position.x == newpos.x && obj.transform.position.y == newpos.y)
            {
                return true;
            }
        }
        foreach (var objToPush in objToPush)
        {
            if (objToPush.transform.position.x == newpos.x && objToPush.transform.position.y == newpos.y)
            {
                Push objpush = objToPush.GetComponent<Push>();


                if (objpush && objpush.Move(direction))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        return false;
    }
}
