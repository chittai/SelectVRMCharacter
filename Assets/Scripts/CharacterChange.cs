using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace selector { 
    public class CharacterChange : MonoBehaviour {
    
        public IObservable<string> CharacterChangeObservable(string name)
        {
            return Observable.Create<string>(observer =>
            {
                var rl = new RuntimeLoader();
    
                rl.LoadVrm(name);
    
                observer.OnNext(name);
                observer.OnCompleted();
                
                return Disposable.Empty;
            });
        }
    }
}