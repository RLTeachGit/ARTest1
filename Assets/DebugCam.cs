using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugCam : MonoBehaviour {

    public Text DebugText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        DebugText.text = string.Format("{0}\n{1}", transform.position, transform.rotation.eulerAngles);
	}
}
