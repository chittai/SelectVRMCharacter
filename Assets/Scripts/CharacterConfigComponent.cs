﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CharacterConfigComponent : MonoBehaviour {

    public ReactiveProperty<string> charaName = new ReactiveProperty<string>();

    private static CharacterConfigComponent _instance = new CharacterConfigComponent();

    private CharacterConfigComponent() { }

    public static CharacterConfigComponent Instance
    {
        get { return _instance; }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}