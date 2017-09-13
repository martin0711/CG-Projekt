using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MausScript : MonoBehaviour {

    public Texture2D cursortexture;

    //public GameObject mousePoint;

    private CursorMode mode = CursorMode.ForceSoftware;
    private Vector2 hotspot = Vector2.zero;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Cursor.SetCursor(cursortexture, hotspot, mode);
	}
}
