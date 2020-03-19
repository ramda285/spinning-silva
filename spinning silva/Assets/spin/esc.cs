using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    public static bool killing2;
    public static bool smp;
    // Start is called before the first frame update
    void Start()
    {
        killing2 = false;
        if (DontDestroyEnabled) {
            DontDestroyOnLoad (this);
        }
        if (Application.platform == RuntimePlatform.Android || (Application.platform == RuntimePlatform.IPhonePlayer)){
            smp = true;
        }else{
            smp = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
            SceneManager.LoadScene ("spin");
        if (Input.GetKeyUp(KeyCode.Escape))
            UnityEngine.Application.Quit();
        if(killing2){
            SceneManager.MoveGameObjectToScene(gameObject, SceneManager.GetActiveScene());
            Destroy(this.gameObject);
        }
    }
}
