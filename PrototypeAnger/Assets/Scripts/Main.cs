using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	void Awake()
	{
//		Services.Prefabs = Re

		Services.Prefabs = Resources.Load<PrefabDB>("Prefabs/PrefabDB");
		Services.Events = new EventManager();
		Services.Scenes = new SceneManager<TransitionData>(gameObject, Services.Prefabs.Levels);
		
		Services.Scenes.PushScene<GameScene>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
