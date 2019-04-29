using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    Rigidbody2D ball;

    private void Awake()
    {
        Camera.main.backgroundColor = Data.planetData.skyColor;
        ball = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
        ball.gravityScale = Data.planetData.gravityScale;
        ball.transform.position = Data.ballPosition;
    }

    private void Update()
    {
        Data.ballPosition = ball.transform.position;
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = (mousePos - ball.transform.position).normalized;
            ball.AddForce(new Vector2(dir.x*10, dir.y*10), ForceMode2D.Force);
        }
    }
}
