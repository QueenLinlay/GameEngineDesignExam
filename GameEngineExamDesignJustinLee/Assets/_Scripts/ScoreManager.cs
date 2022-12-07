using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshPro holder;

    public int counter = 0;
    private void Awake()
    {
      if(instance == null)
        {
            instance = this;
        }
    }

    public void AddCounter(int value)
    {
        counter += value;
        //holder.
        Debug.Log("Score: " + counter);
        if (counter >= 10)
        {
            Debug.Log("You Win!!");
        }
    }


}
