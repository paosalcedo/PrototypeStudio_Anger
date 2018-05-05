using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{

	private Camera _cam;
	// Use this for initialization
	void Start ()
	{
		_cam = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public virtual void Attack()
	{
		GameObject projectile = Instantiate(Services.Prefabs.Projectile, _cam.transform.position + (transform.forward * 2), Quaternion.identity);
//		projectile.transform.rotation = transform.rotation;
//		GameObject reflectoid = Instantiate(Services.Prefabs.Reflectoid, transform.position + (transform.forward * 2), Quaternion.identity) as GameObject;
//		reflectoid.transform.rotation = transform.rotation;
	}
}
