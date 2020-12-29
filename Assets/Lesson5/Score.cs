using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    // スコアを表示する
    public Text scoreText;


    // スコア
    private int score;



    void Start()
    {
        Initialize();
    }

    void Update()
    {
        scoreText.text = score.ToString();

    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;
    }

    // ポイントの追加
    public void AddPoint(int point)
    {
        score = score + point;
    }

}