using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class timeup : MonoBehaviour
{
    GameObject silva;
    public AudioClip bobobo;
    public AudioClip bom;
    Vector3 silpos;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        silva = GameObject.Find("Silva");
        silpos = silva.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(title.counttime == 0){
            //silva.transform.LookAt(Camera.main.transform.position);
            if(time == 0){
                GetComponent<AudioSource>().clip = bobobo;
                GetComponent<AudioSource>().Play();
            }
            time+=Time.deltaTime*60f;
            silva.GetComponent<UnityEngine.Video.VideoPlayer>().playbackSpeed = 0;
            if(time < 200){
                Debug.Log("timeup");
                silva.transform.position = silpos + new Vector3(Random.Range(-Time.deltaTime*60f,Time.deltaTime*60f), Random.Range(-Time.deltaTime*60f,Time.deltaTime*60f), 0);
            }else if(time >= 200 && time < 210){
                transform.rotation = Quaternion.Euler(0,0,10*Time.deltaTime*60f);
            }else if(time >= 210 && time < 300 && silva.GetComponent<Rigidbody>().useGravity == false){
                silva.GetComponent<Rigidbody>().useGravity = true;
                silva.GetComponent<Rigidbody>().AddForce(new Vector3(1000f,1500f,0));
                GetComponent<AudioSource>().clip = bom;
                GetComponent<AudioSource>().Play();
            }else if(time >= 300)
                SceneManager.LoadScene ("fry1");
        }
    }
}
