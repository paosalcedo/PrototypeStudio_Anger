using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{

	private Rewired.Player _player;
	[SerializeField]private Vector3 _moveVec3;
	[SerializeField]private Vector3 _lookVec3;
	private int _playerId = 0;
	private float _moveSpeed = 5;
	private CharacterController cc;
	private bool _fire;
	private float _verticalLookAngle = 0;
	private Camera _cam;
	private float _sensitivity = 0.2f;
	
	void Awake()
	{
		_player = ReInput.players.GetPlayer(_playerId);
		cc = GetComponent<CharacterController>();
		_cam = GetComponentInChildren<Camera>();
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Use this for initialization
	void Start () {
 	}
	
	// Update is called once per frame
	void Update () {
		GetInput();
		ProcessInput();
	}

	void GetInput()
	{
		_moveVec3.x = _player.GetAxis("MoveX");
		_moveVec3.z = _player.GetAxis("MoveZ");
		_lookVec3.x = _player.GetAxis("Look Horizontal");
		_lookVec3.y = _player.GetAxis("Look Vertical");
		_fire = _player.GetButtonDown("Fire");
	}

	void ProcessInput()
	{
		
		#region movement 
		//which direction you'll move in
		Vector3 moveDir = new Vector3 (_moveVec3.x, 0, _moveVec3.z);

		//Speed is directed towards where you're facing.
		moveDir = transform.rotation * moveDir;

		cc.Move (moveDir * _moveSpeed * Time.deltaTime);
		#endregion
		
		#region mouselook

		_verticalLookAngle -= _lookVec3.y * _sensitivity;
		_verticalLookAngle = Mathf.Clamp(_verticalLookAngle, -90f, 90f);
		_cam.transform.localRotation = Quaternion.Euler(_verticalLookAngle, 0, 0);
		cc.transform.Rotate(0, _lookVec3.x * _sensitivity, 0);
		
		#endregion
		
		if (_fire)
		{
			//fire logic
		}
	}
	
	
}
