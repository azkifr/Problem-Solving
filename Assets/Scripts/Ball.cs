using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;
    public void start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score:" + ScoreNum;
    }
    public void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spawnable")
        {
            ScoreNum += 1;
            Destroy(collision.gameObject);
            MyscoreText.text = "Score: " + ScoreNum;
        }
        
    }
}
