using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageSpawn : MonoBehaviour
{
    public int EnemyCounter = 0;
    public int ENemyEnd = 10;
    public GameObject DUck;
    private void Update()
    {
        if (EnemyCounter <= ENemyEnd)
        {
            ObjectPooling.Spawn(DUck, new Vector2(Random.Range(-100, 100), Random.Range(1, 10)), Quaternion.identity);
            EnemyCounter++;
            Debug.Log("EnemyAdded");
        }
    }
}
