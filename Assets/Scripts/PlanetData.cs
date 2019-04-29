using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlanetData", menuName = "PlanetData")]
public class PlanetData : ScriptableObject
{
    public Color skyColor;
    public float gravityScale;
}
