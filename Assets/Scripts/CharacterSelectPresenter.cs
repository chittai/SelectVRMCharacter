using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class CharacterSelectPresenter : MonoBehaviour {

    [SerializeField] private Button AliciaButton;

	// Use this for initialization
	void Start () {

        var characterConfig = CharacterConfigComponent.Instance;

        var AliciaStream = AliciaButton.OnClickAsObservable().Select(_ => "AliciaSolid");

        ///<Summary>
        ///Model -> View
        ///</Summary>
        characterConfig.charaName.Subscribe(name =>
        {
            RuntimeLoader.LoadVrm(name);
        });


        ///<Summary>
        ///View -> Model
        ///</Summary>
        AliciaStream.Subscribe(name => characterConfig.charaName.Value = name);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
