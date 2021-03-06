﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Services {
    public static EventManager Events { get; set; }
    public static PrefabDB Prefabs { get; set; }
    public static SceneManager<TransitionData> Scenes { get; set; }
}
