using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CharacterConfigComponent : MonoBehaviour {

    public ReactiveProperty<string> charaName = new ReactiveProperty<string>();

    private static CharacterConfigComponent _instance_Alicia = new CharacterConfigComponent();
    private static CharacterConfigComponent _instance_Magurona = new CharacterConfigComponent();
    private static CharacterConfigComponent _instance_UnityChan = new CharacterConfigComponent();

    private CharacterConfigComponent() { }

    /// <summary>
    /// 今回はキャラの作成を3つに限定している
    /// </summary>
    public static CharacterConfigComponent InstanceAlicia
    {
        get { return _instance_Alicia; }
    }

    public static CharacterConfigComponent InstanceMagurona
    {
        get { return _instance_Magurona; }
    }

    public static CharacterConfigComponent InstanceUnityChan
    {
        get { return _instance_UnityChan; }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
