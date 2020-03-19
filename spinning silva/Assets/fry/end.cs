using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public GameObject piza;
    public GameObject count;
    public GameObject title;
    public GameObject retry;
    public GameObject ranking;
    float time;
    int gap;
    int number;
    bool sw1;

    // Start is called before the first frame update
    void Start()
    {
        gap = 20;
        sw1 = true;
        //battle.number = 500;
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime*60f;
        if(number < battle.number){
            if((int)time >= gap){
                Instantiate(piza, new Vector2(Random.Range(-4,4),4), Quaternion.Euler(0, 0, Random.Range(-180, 180)));  
                if(gap != 1)
                    gap--;
                time=0;
                number++;
                count.GetComponent<Text>().text = ""+number;
            }
        }else if(number == battle.number){
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
            count.GetComponent<Text>().color = new Color(255,0,0,1);
            title.GetComponent<Text>().color = new Color(255,0,0,1);
            number++;
        }
        if((int)time == 50 && sw1){
            sw1 = false;
            retry.transform.Rotate(Vector3.up * 90f);
            ranking.transform.Rotate(Vector3.up * 90f);
        }
    }

    public void Retry(){
        SceneManager.LoadScene ("spin");
    }

    public void Ranking(){
        if (Application.platform == RuntimePlatform.Android || (Application.platform == RuntimePlatform.IPhonePlayer)) {
            naichilab.RankingLoader.Instance.SendScoreAndShowRanking (battle.number,1);
        }else{
            naichilab.RankingLoader.Instance.SendScoreAndShowRanking (battle.number,0);
        }
    }
}
