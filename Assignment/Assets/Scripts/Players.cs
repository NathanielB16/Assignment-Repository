using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour {

    private Ball myBall;

	// Use this for initialization
	void Start () {

        myBall = GameObject.FindObjectOfType<Ball>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float PosMouseInUnits = (Input.mousePosition.x/Screen.width * 13f) - 6.5f;

        float PosOfMouse = Mathf.Clamp(myBall.transform.position.x, -6f, 6f);

        Vector3 PlayerPos = new Vector3(PosOfMouse, this.transform.position.y, 0);

        this.transform.position = PlayerPos;
		
	}
}
