using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public virtual void Attack()
	{
		Debug.Log("Attacking!");
//		GameObject reflectoid = Instantiate(Services.Prefabs.Reflectoid, transform.position + (transform.forward * 2), Quaternion.identity) as GameObject;
//		reflectoid.transform.rotation = transform.rotation;
	}
}
