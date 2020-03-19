using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class camera : MonoBehaviour
{
    GameObject silva;
    public GameObject panel;
    int time;
    int lb;
    // Start is called before the first frame update
    void Start()
    {
        silva = GameObject.Find("Silva");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time++;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        if(time == 50){
            GetComponent<AudioSource>().Play();
            Time.timeScale = 0.07f;
            panel.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            Camera.main.backgroundColor = Color.HSVToRGB(217f/360f, 60f/100f, 27f/100f);
        }else if(time > 50){
            panel.GetComponent<Image>().color = new Color(255, 255, 255, 1f-(float)(time-50)/10);
        }
        if(time == 100){
            Time.timeScale = 1.0f;
        }else if(time > 100 && time <= 120){
            Camera.main.backgroundColor = Color.HSVToRGB(217f/360f, 60f/100f, (float)(27+(time-100))/100f);
        }            
        if(time >= 60 && time <= 100){
            transform.Rotate(Vector3.up);
        }else if(time >= 100 && time <= 115){
            transform.Rotate(Vector3.up*3f);
        }
        if(time == 150)
            SceneManager.LoadScene ("fry2");
    }
}
