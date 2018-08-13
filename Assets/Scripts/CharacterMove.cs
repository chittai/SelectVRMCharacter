using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

namespace selector { 
public class CharacterMove : MonoBehaviour {
        void Start () {
    
            Animator animator = GetComponent<Animator>();
    
            this.UpdateAsObservable()
                .Where(_ => Input.GetKeyDown("up"))
                .Subscribe(_ =>
                {
                    animator.SetBool("isRunning", true);
                });
    
            this.UpdateAsObservable()
                .Where(_ => Input.GetKeyUp("up"))
                .Subscribe(_ =>
                {
                    animator.SetBool("isRunning", false);
                });
        }
    }
}