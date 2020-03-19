using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class renda : MonoBehaviour
{
    int time;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if(time == 30)
            GetComponent<Text>().color += new Color(0,0,0,1f);
        if(time >= 30)
            transform.position = pos + new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f),0);

    }
}
