using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace selector
{
    public class BlendShapePresenter : MonoBehaviour {

        [SerializeField] private Button SurprisedButton;

        void Start () {
            var blendShapeConfig = BlendShapeConponemts.Instance;

            var SurprisedStream = SurprisedButton.OnClickAsObservable();

            GameObject obj = new GameObject("GameObject");

            SetValueBlendShape setValueBlendShape = obj.AddComponent<SetValueBlendShape>();

            //Model - View
            blendShapeConfig.blendShape
                .SkipLatestValueOnSubscribe()
                .Subscribe(_ =>
            {
                setValueBlendShape.SetValueBlendShapeToSurprised();
            });

            //View - Model
            SurprisedStream.Subscribe(_ => 
            {
                blendShapeConfig.blendShape.Value = "surprise";
            });


        }
    }
}