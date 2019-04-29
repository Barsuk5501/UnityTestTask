using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Dictionary<int, Color> platformColors = new Dictionary<int, Color>();
    public static  int score;
    public static Vector3 ballPosition = new Vector3(-5, 0, 0);
    public static PlanetData planetData;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
