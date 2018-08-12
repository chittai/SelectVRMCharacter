using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace selector
{
    public class CharacterSelectPresenter : MonoBehaviour
    {

        [SerializeField] private Button AliciaButton;
        [SerializeField] private Button MaguronaButton;
        [SerializeField] private Button UnitychanButton;

        // Use this for initialization  
        void Start()
        {

            var characterConfig = CharacterConfigComponent.Instance;
            var characterChange = new CharacterChange();

            var AliciaStream = AliciaButton.OnClickAsObservable().Select(_ => "AliciaSolid");
            var MaguronaStream = MaguronaButton.OnClickAsObservable().Select(_ => "Magurona");
            var UnitychanStream = UnitychanButton.OnClickAsObservable().Select(_ => "Unitychan");


            ///<summary>
            ///Model -> View　新しいキャラを表示させる
            ///</summary>
            characterConfig.charaName.Subscribe(name =>
            {
                characterChange.CharacterChangeObservable(name).Subscribe(x =>
           {
                    Debug.Log(x);
                });
            });

            ///<summary>
            ///Model -> View　今表示しているキャラを消す
            ///</summary>
            characterConfig.beforeCharaName.Subscribe(name =>
            {
                var gameObject = GameObject.Find(name);
                Destroy(gameObject);
            });


            ///<summary>
            ///View -> Model
            ///</summary>
            AliciaStream.Subscribe(name =>
           {
               if (characterConfig.charaName.Value != null && characterConfig.charaName.Value != name)
               {
                   characterConfig.beforeCharaName.Value = characterConfig.charaName.Value;
               }
               characterConfig.charaName.Value = name;
           });

            MaguronaStream.Subscribe(name =>
            {
                if (characterConfig.charaName.Value != null && characterConfig.charaName.Value != name)
                {
                    characterConfig.beforeCharaName.Value = characterConfig.charaName.Value;
                }
                characterConfig.charaName.Value = name;
            });

            UnitychanStream.Subscribe(name =>
            {
                if (characterConfig.charaName.Value != null && characterConfig.charaName.Value != name)
                {
                    characterConfig.beforeCharaName.Value = characterConfig.charaName.Value;
                }
                characterConfig.charaName.Value = name;
            });
        }
    }
}
