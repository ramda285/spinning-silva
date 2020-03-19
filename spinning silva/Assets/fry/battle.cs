using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battle : MonoBehaviour
{
    public GameObject silva;
    public GameObject panel;
    public GameObject back;
    public GameObject narenohate;
    public UnityEngine.Video.VideoPlayer silvam;
    GameObject hone;
    public AudioClip kan;
    public AudioClip gagaga;
    GameObject piza;
    GameObject piece;
    public static int number;
    public GameObject pizap;
    float time;
    float timed;
    Vector3 campos;
    // Start is called before the first frame update
    void Start()
    {
        piza = GameObject.Find("Piza");
        if (esc.smp == true)
        silvam.playbackSpeed = 2*Time.deltaTime*60f;
        number = 0;
        time = 0f;
        timed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime*60f;
        if(time < 30f){
            Camera.main.transform.position += Vector3.right*0.3f*Time.deltaTime*60f;
            silva.transform.position += Vector3.right*Time.deltaTime*60f;
        }else if((int)time == 30){
            panel.GetComponent<Image>().color = new Color(255, 255, 255, 1);
            GetComponent<AudioSource>().PlayOneShot(kan);
            GetComponent<AudioSource>().clip = gagaga;
            campos = Camera.main.transform.position;
            Instantiate(back,Camera.main.transform.position+Vector3.forward*15f,Quaternion.identity);
        }else if((int)time >= 30 && (int)time <= 50){
            panel.GetComponent<Image>().color = new Color(255, 255, 255, (float)(40-time)/20);
        }else{
            Destroy(panel.gameObject);
        }
        if(time > 30f){
            if(geji.longer >= 0){
                Camera.main.transform.position = campos + new Vector3(Random.Range(-0.3f,0.3f), Random.Range(-0.3f,0.3f),0);
                //Camera.main.transform.RotateAround(silva.transform.position, Vector3.up, 20 * Time.deltaTime);
                //silva.transform.LookAt(Camera.main.transform.position);
                //piza.transform.LookAt(Camera.main.transform.position);
                //％は使わない方針で
                timed += Time.deltaTime*60f;
                if(timed >= 4f){
                    piece = Instantiate(pizap,piza.transform.position + Vector3.forward,Quaternion.identity) as GameObject;
                    piece.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-200f,200f);
                    piece.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(100f,400f),Random.Range(-100f,400f)));
                    //piece.transform.LookAt(Camera.main.transform.position);
                    number++;
                    timed = 0f;
                }
                if((int)time%30 == 0){
                    GetComponent<AudioSource>().Play();
                }
            }else{
                hone = Instantiate(narenohate, silva.transform.position,Quaternion.identity);
                hone.GetComponent<Rigidbody2D>().AddForce(new Vector3(-4000f,8000f,0));
                Destroy(silva.gameObject);
                Destroy(this.gameObject);
            }
            
        }
    }
}
