﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private GameObject gameOverText;
    private GameObject runLengthText;
    private float len = 0;
    private float speed = 5f;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update ()
        {
                if (this.isGameOver == false)
                {
                        // 走った距離を更新する
                        this.len += this.speed * Time.deltaTime;

                        // 走った距離を表示する
                        this.runLengthText.GetComponent<Text> ().text = "Distance:  "  + len.ToString ("F2") + "m";
                }
                if(this.isGameOver == true)
                {
                    if(Input.GetMouseButtonDown(0))
                    {
                        SceneManager.LoadScene("SampleScene");
                    }
                }
        }

        public void GameOver()
        {
                // ゲームオーバーになったときに、画面上にゲームオーバを表示する
                this.gameOverText.GetComponent<Text>().text = "Game Over";
                this.isGameOver = true;
        }
}
