using UnityEngine;

namespace DataScripts
{
    public class BulletData : MonoBehaviour, ICleaner
    {
        [SerializeField] private float _speedOfBullet;
        [SerializeField] private float _timeForClean;

        private int _indexInActiveList;

        public float SpeedOfBullet
        {
            get { return _speedOfBullet; }
            set { _speedOfBullet = value; }
        }

        public int IndexInActiveList
        {
            get { return _indexInActiveList; }
            set { _indexInActiveList = value;}
        }

        public float GetTimeForCleane()
        {
            return _timeForClean;
        }
        public void RestartObject()
        {
            ObjectStorage objectStorage = ObjectStorage.instance;
            objectStorage.PoolOfBullets.Add(gameObject);
            objectStorage.ActiveBullets.RemoveAt(_indexInActiveList);
        }
    }
}
