using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    private GameObject[] obstacles;
    private GameObject[] objToPush;

    void Start()
    {
        obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        objToPush = GameObject.FindGameObjectsWithTag("ObjToPush");
    }

    public bool Move(Vector2 direction)
    {
        if (objToBlocked(transform.position, direction))
        {
            return false;
        }
        else
        {
            transform.Translate(direction);
            return true;
        }
    }

    public bool objToBlocked(Vector3 position, Vector2 direction)
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
                return true;
            }
        }
        return false;
    }
  
}
