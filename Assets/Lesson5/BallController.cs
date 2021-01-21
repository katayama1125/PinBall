using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
            this.scoreText.GetComponent<Text>().text = this.score + "p";
        }

        if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
            this.scoreText.GetComponent<Text>().text = this.score + "p";
        }

        if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 30;
            this.scoreText.GetComponent<Text>().text = this.score + "p";
        }

        if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 40;
            this.scoreText.GetComponent<Text>().text = this.score + "p";
        }
    }
}

