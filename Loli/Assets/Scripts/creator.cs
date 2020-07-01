using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creator : MonoBehaviour
{
    public GameObject loli;
    public float countdown;  //計時器
    public bool isGame;   //是否正在進行遊戲

    // Start is called before the first frame update
    void Start()
    {
     
    }

    public void StartCreator()  //開始顯示蘿莉
    {
        countdown = Random.Range(2, 10); //隨機2到10內產生蘿莉
        Invoke("CreateLolis", countdown); //某一秒產生後,調用CreateLolis()
        isGame = true;//現在正在遊戲中
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateLolis()
    {
        if (isGame == true)
        { //如果現在正在遊戲中
            Instantiate(loli, transform.position, transform.rotation); //讓蘿莉跟著地洞
            //print(transform.name.ToString());
            countdown = Random.Range(2, 10);
            Invoke("CreateLolis", countdown);
        }


    }

}
