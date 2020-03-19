using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bone : MonoBehaviour
{
    public GameObject boom;
    float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(boom, transform.position + new Vector3(Random.Range(-0.1f,0.1f),Random.Range(-0.1f,0.1f),0),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,5f);
    }
}
