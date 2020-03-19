using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result : MonoBehaviour
{
    float t;
    Color clr;
    // Start is called before the first frame update
    void Start()
    {
        clr = GetComponent<TextMesh>().color;
    }

    // Update is called once per frame
    void Update()
    {
        t++;
        transform.position += Vector3.up * 0.03f;
        clr.a = 1.0f - t / 100f;
        GetComponent<TextMesh>().color = clr;
        if(t == 100)
            Destroy(this.gameObject);
    }
}
