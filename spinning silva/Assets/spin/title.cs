using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class title : MonoBehaviour
{
    public GameObject panel;
    public GameObject image;
    public GameObject count;
    public AudioSource five;
    float timer;
    int start;
    public static int counttime;
    RectTransform rect;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = image.GetComponent<RectTransform>().localPosition;
        timer = 0f;
        start = 50;
        counttime = 30;
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(""+timer);
        if(counttime > 0){
            timer+=Time.deltaTime*60f;
            if((int)timer > start + 150){
                counttime--;
                if(counttime == 6)
                    five.GetComponent<AudioSource>().Play();
                count.GetComponent<Text>().text = ""+counttime;
                timer = start + 100;
            }
            if((int)timer >= start && (int)timer < 100+start){
                if (GameObject.Find("Panel") != null)
                    panel.GetComponent<Image>().color = new Color(255, 255, 255, 1.0f-(float)(timer-start)/100);
                pos.x += Time.deltaTime*420f;
                pos.y += Time.deltaTime*180f;
                image.GetComponent<RectTransform>().localPosition = pos;
                image.GetComponent<RectTransform>().localScale += new Vector3(Time.deltaTime*-0.3f, Time.deltaTime*-0.3f, 0);
            }
            if((int)timer >= 100+start)
                Destroy(panel.gameObject);
        }
    }
}
