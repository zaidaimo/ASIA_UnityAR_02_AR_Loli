using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creator : MonoBehaviour
{
    public GameObject loli;
    public float countdown;  //內隨機產生蘿莉
    public bool isGame;   //是否正在進行遊戲
        
    public void StartCreator()  //開始顯示蘿莉
    {
        countdown = Random.Range(3, 10); //3到10內隨機產生蘿莉
        Invoke("CreateLolis", countdown); //某一秒產生後,調用CreateLolis()
        isGame = true;//現在正在遊戲中
    }

    public void CreateLolis()
    {
        if (isGame == true) //如果現在正在遊戲中
        {
            Instantiate(loli, transform.position, transform.rotation); //出現蘿莉
            print(transform.name.ToString());
            countdown = Random.Range(3, 10);//隨機3到10內隨機產生蘿莉
            Invoke("CreateLolis", countdown);
        }
        
    }
}
