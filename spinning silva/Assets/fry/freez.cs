using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freez : MonoBehaviour
{
    float t;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        t+=Time.deltaTime*60f;
        if(t >= 300){
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
}
