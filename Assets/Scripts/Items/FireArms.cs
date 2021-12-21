using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "New Fire Arms", menuName = "Fire Arms")]
    class FireArms : Ranget
    {
        [SerializeField] [Range(1, 100)] private int _capacity;
        [SerializeField] [Range(0.1f, 5f)] protected float _secondsBetweenShot;
        [SerializeField] private AnimationClip _attackAnimation;
    }
}
