﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("GameOver");
        }//体力でゲームオーバーに変更 壁のみ
    }
}
