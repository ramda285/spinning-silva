using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedup : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject music;
    GameObject silva;
    GameObject bar;
    GameObject gacki;
    GameObject result;
    public GameObject result0;
    public GameObject result1;
    public GameObject result2;
    public AudioClip a;
    public AudioClip b;
    public AudioClip c;
    public AudioClip d;
    int correct;
    int judge;
    float posy;
    float plus;
    public static float n;
    public static int thinking;

    void Start()
    {
        music = GameObject.Find("Bgm");
        silva = GameObject.Find("Silva");
        bar = GameObject.Find("Bar");
        gacki = GameObject.Find("Thinking");
        n = 2;
        esc.killing2 = true;
        jizoku.killing = true;
    }

    // Update is called once per frame
    void Update()
    {
        bar.transform.position += Vector3.up * Time.deltaTime * 5.6f * n;
        posy = bar.transform.position.y;
        if (posy >= 4f){
            bar.transform.position = new Vector3(bar.transform.position.x,-4f,bar.transform.position.z);
        }
        if (title.counttime == 0)
            Destroy(this);
        if (Input.GetKeyUp(KeyCode.UpArrow)){
            button.key = "Up";
            GetComponent<AudioSource>().PlayOneShot(a);
            Receive();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)){
            button.key = "Down";
            GetComponent<AudioSource>().PlayOneShot(b);
            Receive();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)){
            button.key = "Right";
            GetComponent<AudioSource>().PlayOneShot(c);
            Receive();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)){
            button.key = "Left";
            GetComponent<AudioSource>().PlayOneShot(d);
            Receive();
        }

    }

    public void Receive(){
        if (posy > -0.5f && posy < 0.5f){
            judge = 2;
            Debug.Log("Just");
        }else if (posy > -1.5f && posy < 1.5f){
            judge = 1;
            Debug.Log("Good");
        }else{
            judge = 0;
            Debug.Log("Bad");
        }
        switch (thinking)
        {    
            case 0:
            if (button.key != "Up"){
                judge = 0;
                Debug.Log("Incorrect");
            }
            break;
            case 1:
            if (button.key != "Down"){
                judge = 0;
                Debug.Log("Incorrect");
            }
            break;
            case 2:
            if (button.key != "Left"){
                judge = 0;
                Debug.Log("Incorrect");
            }
            break;
            case 3:
            if (button.key != "Right"){
                judge = 0;
                Debug.Log("Incorrect");
            }
            break;
        }
        Judge();
        gacki.SendMessage("Gacki");
    }

    void Judge(){
        if(judge == 0){
            plus = -0.5f;
            result = result0;
        }else if(judge == 1){
            plus = 0.5f;
            result = result1;
        }else if(judge == 2){
            plus = 1f; 
            result = result2;
        }
        music.GetComponent<AudioSource>().pitch += (0.05f * plus*Time.deltaTime*60f);
        silva.GetComponent<UnityEngine.Video.VideoPlayer>().playbackSpeed += (0.074f * plus*Time.deltaTime*60f);
        n += (0.1f * plus);
        Instantiate(result, new Vector3(-6f,3f,0), Quaternion.identity);
    }
}
