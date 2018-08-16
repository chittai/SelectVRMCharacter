using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace selector { 
    public class BlendShapeConponemts : MonoBehaviour {

        public ReactiveProperty<string> blendShape = new ReactiveProperty<string>();

        private BlendShapeConponemts() { }
    
        private static BlendShapeConponemts instance = new BlendShapeConponemts();
    
    	// Use this for initialization
    
        public static BlendShapeConponemts Instance
        {
            get {return instance;}
        }
    }
}