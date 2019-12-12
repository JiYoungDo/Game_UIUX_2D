using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

// 7후 부터 카운트-> UI로 구현
// 7초 후 저울 범위 안에 있는 점수가 300점이면 클리어로 씬 전환, 아니면 오버로 전환
public class CountScore : MonoBehaviour
{

    public Text TimeCount;
    float timer;
    float limit_time = 10.0f;
    int score = 0;
   
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 7.0f)
        {
            limit_time -= Time.deltaTime;
            TimeCount.text = "남은시간 : " + Mathf.Round(limit_time);

            if(limit_time <=0.0f)
            {
                limit_time = 0.0f;
                

                Drag_Drop e1 = GameObject.Find("monkey").GetComponent<Drag_Drop>();
                Drag_Drop e2 = GameObject.Find("tree").GetComponent<Drag_Drop>();
                Drag_Drop e3 = GameObject.Find("Butterfly").GetComponent<Drag_Drop>();
                Drag_Drop e4 = GameObject.Find("Magnet").GetComponent<Drag_Drop>();
                Drag_Drop e5 = GameObject.Find("saxophone").GetComponent<Drag_Drop>();
                Drag_Drop e6 = GameObject.Find("Hydra").GetComponent<Drag_Drop>();

                if(445 <= e1.transform.position.x && e1.transform.position.x <= 630 && 250 <= e1.transform.position.y && e1.transform.position.y <= 465)
                {
                    score -= 10;
                }
                if (445 <= e2.transform.position.x && e2.transform.position.x <= 630 && 250 <= e2.transform.position.y && e2.transform.position.y <= 465)
                {
                    score -= 10;
                }
                if (445 <= e3.transform.position.x && e3.transform.position.x <= 630 && 250 <= e3.transform.position.y && e3.transform.position.y <= 465)
                {
                    score += 100;
                }
                if (445 <= e4.transform.position.x && e4.transform.position.x <= 630 && 250 <= e4.transform.position.y && e4.transform.position.y <= 465)
                {
                    score += 100;
                }
                if (445 <= e5.transform.position.x && e5.transform.position.x <= 630 && 250 <= e5.transform.position.y && e5.transform.position.y <= 465)
                {
                    score += 100;
                }
                if (445 <= e6.transform.position.x && e6.transform.position.x <= 630 && 250 <= e6.transform.position.y && e6.transform.position.y <= 465)
                {
                    score -= 10;
                }

                if (score == 300)
                {
                    SceneManager.LoadScene("GameClear");
                }
                else
                {
                    SceneManager.LoadScene("GameFail");
                }

            }
        }
    }
}
