using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using VRM;

namespace selector { 
    public class SetValueBlendShape : MonoBehaviour {
    
        public void SetValueBlendShapeToSurprised()
        {
            GameObject gameObject = GameObject.Find("AliciaSolid");

            var proxy = gameObject.GetComponent<VRMBlendShapeProxy>();

            Task.Delay(1000);

            proxy.SetValue(BlendShapePreset.Blink, 1.0f);
            
            //proxy.SetValue(BlendShapePreset.Blink, 0);

        }
    }
}