using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerenemy : MonoBehaviour {


	[SerializeField] GameObject Enemy;
	// Use this for initialization
	void Start () {
		
			for (int i = -4; i < 5; i++)
				{
				for (int e = 0; e < 4 ;e++) {
					Instantiate (Enemy, new Vector3 (i, e, 0), Quaternion.identity);
			}
	}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
