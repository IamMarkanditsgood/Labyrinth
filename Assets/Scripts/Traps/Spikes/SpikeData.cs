using UnityEngine;

namespace DataScripts
{
    public class SpikeData : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private float _restarTime;
        [SerializeField] private float _timeOfStartingTrap;

        public Animator Animator
        {
            get { return _animator; }
        }

        public float RestarTime
        {
            get { return _timeOfStartingTrap; }
            set { _timeOfStartingTrap = value; }
        }
        public float TimeOfStartingTrap
        {
            get { return _timeOfStartingTrap; }
            set { _timeOfStartingTrap = value; }
        }
    }
}
