using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour {

    public GameObject ball;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter2D(Collision2D col) 
    {

        // Hit the LeftRacket or RightRacket by checking from the tag of that gameobject
        //Adjust the ball collision angle
        if (col.gameObject.tag == "LeftRacket" || col.gameObject.tag == "RightRacket") 
        {
            Vector2 vel;
            vel.x = GetComponent<Rigidbody2D>().velocity.x;
            vel.y = (GetComponent<Rigidbody2D>().velocity.y / 2.0f) + (col.collider.attachedRigidbody.velocity.y / 3.0f);
            GetComponent<Rigidbody2D>().velocity = vel;
        }

        if(col.gameObject.tag == "LeftWall" || col.gameObject.tag == "RightWall")
        {
            //TODO add your Destroy code here-destroy the ball
            //Destroy(ball);
            
            //TODO Get the active scene's build index and reload it
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}
