using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
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
            //スコア処理を追加
            FindObjectOfType<Score>().AddPoint(10);
        }

        if (collision.gameObject.tag == "LargeStarTag")
        {
            //スコア処理を追加
            FindObjectOfType<Score>().AddPoint(20);
        }

        if (collision.gameObject.tag == "SmallCloudTag")
        {
            //スコア処理を追加
            FindObjectOfType<Score>().AddPoint(30);
        }

        if (collision.gameObject.tag == "LargeCloudTag")
        {
            //スコア処理を追加
            FindObjectOfType<Score>().AddPoint(40);
        }
    }
}

