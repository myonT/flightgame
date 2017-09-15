using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, -8 * Time.deltaTime);
        //if(transform.position.z <= 0){
        //    transform.position = new Vector3(0, 0, 150);
        //}
		
	}
}
