using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using VRM;

namespace selector { 
    public class SetValueBlendShape : MonoBehaviour {
    
        public void SetValueBlendShapeToSurprised()
        {
            var proxy = GetComponent<VRMBlendShapeProxy>();

            proxy.SetValue(BlendShapePreset.Blink, 1.0f);

            Task.Delay(1000);

            proxy.SetValue(BlendShapePreset.Blink, 0);

        }
    }
}