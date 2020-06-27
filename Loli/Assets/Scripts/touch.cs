using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    public player script;
    public bool isGame;

    // Start is called before the first frame update
    void Start()
    {
        print("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)&&isGame==true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "Loli")
                {
                    print("Hit loli");
                    script.GetScore(10);
                    Destroy(hit.transform.gameObject);
                }
            }

        }
    }
}
