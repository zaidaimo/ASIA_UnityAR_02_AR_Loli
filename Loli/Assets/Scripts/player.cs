using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int score;
    public creator[] Hole;  //地鼠洞 陣列
    public GameObject[] canvas_ui;  //UI
    public Text time_text;
    public Text score_text;
    public touch camera_touch;  //遊戲結束時無法再點擊蘿莉
    public int nowtime;  //顯示時間剩幾秒

    //public AudioClip soundButton;
    //private AudioSource aud;


    // Start is called before the first frame update
    void Start()
    {
        score = 0; //遊戲初始分數為0
        canvas_control(0);
        
    }

    public void StartGame()  //地洞功能開啟
    {
        for (int a = 0; a < Hole.Length; a++)
        {
            Hole[a].StartCreator();  //呼叫StartCreator功能
            
        }
        canvas_control(1);  //Start Game 按鈕影藏顯示
        nowtime = 10;  //開始時間定義為60秒
        time_text.text = nowtime.ToString();  //顯示時間剩幾秒
        Invoke("GameCountDown", 1.0f);  //每一秒呼叫一次 GameCountDown()
        camera_touch.isGame = true;
    }
    
        
    
    public void canvas_control(int a)  //控制器控制canvas
    {
        for (int b = 0; b < canvas_ui.Length; b++)
        {
            canvas_ui[b].SetActive(false);  //所有物件關閉
        }
        canvas_ui[a].SetActive(true);  //將指定物件打開
    }

    public void GameCountDown()  //開始倒數計時
    {
        nowtime--;  //從60秒開始遞減
        time_text.text = nowtime.ToString();  //顯示時間剩幾秒
        if (nowtime == 0)  //時間到0秒時,遊戲結束
        {
            print("End Game");
            EndGame();
        }
        else
        {   //時間不為0秒時,跳下一次的遞減
            Invoke("GameCountDown", 1.0f);
        }
    }

    public void EndGame()  //遊戲結束
    {
        for (int a = 0; a < Hole.Length; a++)  //結束遊戲時將蘿莉取消顯示
        {
            Hole[a].isGame = false;
        }
        camera_touch.isGame = false;
        canvas_control(2);
    }
    public void GetScore(int getscore) //接收分數
    {
        score += getscore;
        score_text.text = score.ToString();  //將數字轉為字串顯示
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
