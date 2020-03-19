using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyng : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClick(){
        geji.longer += 0.03f * speedup.n;
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
    }
}
