using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour
{
    public void DuckBroken()
    {
        ScoreManager.instance.AddCounter(1);
        gameObject.SetActive(false);
       // ScoreManager.instance.AddCounter(1);
    }
}
