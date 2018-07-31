using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoTrigger : MonoBehaviour {

    MeshRenderer mMR;
    TextMeshPro mTMesh;

	// Use this for initialization
	void Start () {
        mMR = GetComponent<MeshRenderer>();
        mTMesh = GetComponentInChildren<TextMeshPro>();
	}
	
	// Update is called once per frame
	void Update () {
        mTMesh.text = "Hello";
	}

	private void OnTriggerEnter(Collider other)
	{
        mMR.material.color = Color.green;
        mTMesh.text = "Close";
        mTMesh.ForceMeshUpdate(true);
	}

    private void OnTriggerExit(Collider other)
    {
        mMR.material.color = Color.white;
        mTMesh.text = "Far";
        mTMesh.ForceMeshUpdate(true);
    }
}
