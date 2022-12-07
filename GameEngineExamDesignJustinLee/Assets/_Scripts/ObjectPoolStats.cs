using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolStats
{
    public Stack<GameObject> inactive = new Stack<GameObject>();

    public GameObject Duck;
    public ObjectPoolStats(GameObject Duck)
    {
        this.Duck = Duck;
    }
}
