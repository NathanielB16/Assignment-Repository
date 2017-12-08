using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Player Players;

    private Vector3 PlayerToBallVector;

    private bool Started = false;

    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        randomX = Random.Range(0f, 0.5f);
        randomY = Random.Range(0f, 0.5f);

        Vector2 adjust = new Vector2(randomX, randomY);

        this.GetComponent<Rigidbody2D>().velocity += adjust;

    }

    // Use this for initialization
    void Start () {

        Players = GameObject.FindObjectOfType<Player>();

        PlayerToBallVector = this.transform.position - Players.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Started == false)
        {

        }

    }
}
