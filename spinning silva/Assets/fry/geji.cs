using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class geji : MonoBehaviour
{
    float time;
    float timeb;
    float timec;
    public static float longer;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        timeb = 0f;
        timec = 0f;
        longer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime*60f;
        if((int)time <= 160)
            longer = time*0.04f;
        if(longer >= 0){
            //t>160からバトル
            if((int)time >= 160){
                //相変わらずおかしい
                longer -= (time+500f)/5000f*(Time.deltaTime/0.1f);
                if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
                    Attack();
            }
            if(longer >= 6f)
                longer = 6f;
        }else{
            timeb+=Time.deltaTime*60f;
            if(timeb >= 200f){
                jizoku.killing = true;
                SceneManager.LoadScene("end");
            }
        }
        this.transform.localScale = new Vector3(longer, 1f, 1f);
    }

    public void Attack(){
        longer += 0.03f * speedup.n;
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
    }
}
