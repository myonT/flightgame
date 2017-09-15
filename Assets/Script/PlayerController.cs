using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    float speed = 10f;
    int strength = 5;

	// Use this for initialization
	void Start () {
        Debug.Log(strength);
		
	}
	
	// Update is called once per frame
	void Update () {
		//if( Input.GetKey("left") ) {   // 「←」が押されている場合がとれる

		transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //transform.position += Vector3.forward * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position += new Vector3(-speed * Time.deltaTime, 0,0);
        }
        if (Input.GetKey(KeyCode.UpArrow)){
			transform.position += new Vector3(0, speed * Time.deltaTime, 0);
		}
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }

        if(transform.position.z >= 150){
            SceneManager.LoadScene("Goal");
        }
	}


    //Triggerで判定、親からとってるせいで中のColliderの数だけ反応する→二つまとめる解決策探したい
    void OnTriggerExit(Collider other){
        if(other.transform.parent.CompareTag("Enemy")){
            Debug.Log("ok");
            strength--;
            Debug.Log(strength);
            if(strength <= 0){
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
