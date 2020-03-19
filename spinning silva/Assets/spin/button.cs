using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    GameObject comon;
    //public AudioSource se;
    public static string key;
    // Start is called before the first frame update
    void Start()
    {
        comon = GameObject.Find("Comon");
        
    }

    public void OnClick(){
        key = gameObject.name;
        comon.SendMessage("Receive");
        GetComponent<AudioSource>().PlayOneShot (GetComponent<AudioSource> ().clip);
        //se.Play();
    }
}
