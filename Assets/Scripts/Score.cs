using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(Data.score);
        GetComponent<Text>().text = Data.score.ToString();
    }
}
