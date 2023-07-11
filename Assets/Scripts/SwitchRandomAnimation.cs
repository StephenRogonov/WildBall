using UnityEngine;

namespace WildBall
{
    public class SwitchRandomAnimation : MonoBehaviour
    {
        private Animator _animator;
        private AnimationClip[] _clips;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _clips = _animator.runtimeAnimatorController.animationClips;
        }

        private void AnimationSwitch()
        {
            _animator.SetInteger("AnimationIndex", Random.Range(0, _clips.Length));
        }
    }
}
