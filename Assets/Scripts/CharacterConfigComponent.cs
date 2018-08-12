using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CharacterConfigComponent : MonoBehaviour {

    /// <summary>
    /// 変更後のキャラクター名
    /// </summary>
    public ReactiveProperty<string> charaName = new ReactiveProperty<string>();

    /// <summary>
    /// 変更前のキャラクター名
    /// </summary>
    public ReactiveProperty<string> beforeCharaName = new ReactiveProperty<string>();

    private static CharacterConfigComponent instance = new CharacterConfigComponent();
    
    private CharacterConfigComponent() { }

    public static CharacterConfigComponent Instance
    {
        get { return instance; }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
