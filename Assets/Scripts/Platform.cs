using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public int id;
    public bool changeColor;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (changeColor)
        {
            if (Data.platformColors.ContainsKey(id))
                spriteRenderer.color = Data.platformColors[id];
            else
                spriteRenderer.color = Color.black;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ball")
        {
            Data.score++;
            if (changeColor)
            {
                Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                spriteRenderer.color = color;
                Data.platformColors[id] = color;
            }
        }
    }
}
