using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace selector { 
    public class BlendShapeConponemts : MonoBehaviour {
    
        private BlendShapeConponemts() { }
    
        private BlendShapeConponemts instance = new BlendShapeConponemts();
    
        public ReactiveProperty<string> blendShape = new ReactiveProperty<string>();
        
    	// Use this for initialization
    
        public static BlendShapeConponemts Instance
        {
            get {return Instance;}
        }
    }
}