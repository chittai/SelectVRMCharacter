using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace selector { 
    public class AddAnimation : MonoBehaviour {

        public void AddAnimationController(GameObject gameObject)
        {
            var gameObjectAnimator = gameObject.GetComponent<Animator>();
            gameObjectAnimator.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Animators/VRMAnimatorController");
        }
    }
}