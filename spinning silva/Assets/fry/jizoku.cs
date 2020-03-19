using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class jizoku : MonoBehaviour {
    public bool DontDestroyEnabled = true;
    public static bool killing;

    // Use this for initialization
    void Start () {
        killing = false;
        if (DontDestroyEnabled) {
            DontDestroyOnLoad (this);
        }
    }

    // Update is called once per frame
    void Update () {
        if(killing){
            SceneManager.MoveGameObjectToScene(gameObject, SceneManager.GetActiveScene());
            Destroy(this.gameObject);
        }
    }
}