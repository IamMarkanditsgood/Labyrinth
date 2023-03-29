using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataScripts
{
    public class TowerData : MonoBehaviour
    {
        [SerializeField] Transform _startShootPosition;

        [SerializeField] private float _rechargeTime;
        [SerializeField] private float _timeOfStartingTrap;

        public Transform StartShootPosition
        {
            get { return _startShootPosition; }
        }

        public float RechargeTime
        {
            get { return _rechargeTime; }
            set { _rechargeTime = value; }
        }
        public float TimeOfStartingTrap
        {
            get { return _timeOfStartingTrap;}
            set { _timeOfStartingTrap = value;}
        }
    }
}
