using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gacki : MonoBehaviour
{
    public Sprite snare;
    public Sprite bass;
    public Sprite synbal;
    public Sprite tom;
    // Start is called before the first frame update
    void Start()
    {
        Gacki();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gacki(){
        speedup.thinking = Random.Range(0,4);
        if (speedup.thinking == 0){
            gameObject.GetComponent<SpriteRenderer> ().sprite = snare;
        }else if (speedup.thinking == 1){
            gameObject.GetComponent<SpriteRenderer> ().sprite = bass;
        }else if (speedup.thinking == 2){
            gameObject.GetComponent<SpriteRenderer> ().sprite = synbal;
        }else if (speedup.thinking == 3){
            gameObject.GetComponent<SpriteRenderer> ().sprite = tom;
        }
    }
}
