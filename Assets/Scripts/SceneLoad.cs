using UnityEngine;
using System.Collections;

public class SceneLoad : MonoBehaviour {

    public void loadScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
