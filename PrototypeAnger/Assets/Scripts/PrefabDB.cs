﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Prefab Database")]
public class PrefabDB : ScriptableObject
{
    [SerializeField] private GameObject[] _levels;

    public GameObject[] Levels
    {
        get { return _levels; }
    }

    [SerializeField] private GameObject _player;

    public GameObject Player
    {
        get { return _player; }
    }

    [SerializeField] private GameObject _projectile;

    public GameObject Projectile
    {
        get { return _projectile; }
    }
    
}
