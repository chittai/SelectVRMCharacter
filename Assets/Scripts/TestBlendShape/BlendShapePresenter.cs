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

            var setValueBlendShape = new SetValueBlendShape();

            //Model - View
            blendShapeConfig.blendShape.Subscribe(_ =>
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