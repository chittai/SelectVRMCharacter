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

            //Task.Delay(1000);

            StartCoroutine("BlinkCoroutine",proxy);
        }


        IEnumerator BlinkCoroutine(VRMBlendShapeProxy proxy)
        {
            float blinkParameter = 0;
            blinkParameter = Mathf.Clamp01(blinkParameter);

            while (blinkParameter <= 1)
            {
                proxy.SetValue(BlendShapePreset.Blink, Mathf.Lerp(0,1.0f,blinkParameter));
                yield return null;

                blinkParameter += Time.deltaTime;

            }
        }
    }
}