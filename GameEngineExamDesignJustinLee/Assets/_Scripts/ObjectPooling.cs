using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling
{
    private static Dictionary<string, ObjectPoolStats> pools = new Dictionary<string, ObjectPoolStats>();

    public static void Spawn(GameObject go, Vector3 pos, Quaternion rot)
    {
        GameObject obj;
        string key = go.name.Replace("(Clone)", "");

        if (pools.ContainsKey(key))
        {
            if (pools[key].inactive.Count == 0)
            {
                Object.Instantiate(go, pos, rot, pools[key].Duck.transform);
            }
            else
            {
                obj = pools[key].inactive.Pop();
                obj.transform.position = pos;
                obj.transform.rotation = rot;
                obj.SetActive(true);
            }
        }
        else
        {
            GameObject newEnemy = new GameObject($"{key}_POOL");
            Object.Instantiate(go, pos, rot, newEnemy.transform);
            ObjectPoolStats newPools = new ObjectPoolStats(newEnemy);
            pools.Add(key, newPools);
        }
    }

    public static void Despawn(GameObject go)
    {
        string key = go.name.Replace("(Clone)", "");

        if (pools.ContainsKey(key))
        {
            pools[key].inactive.Push(go);
            go.transform.position = pools[key].Duck.transform.position;
            go.SetActive(false);
        }
        else
        {
            GameObject newEnemy = new GameObject($"{key}_POOL");
            ObjectPoolStats newPool = new ObjectPoolStats(newEnemy);

            go.transform.SetParent(newEnemy.transform);

            pools.Add(key, newPool);
            pools[key].inactive.Push(go);
            go.SetActive(false);
        }
    }
}
