using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DataScripts;

public class ObjectStorage : MonoBehaviour
{
    public static ObjectStorage instance;

    [SerializeField] private List<GameObject> _poolOfBullets = new List<GameObject>();
    [SerializeField] private List<GameObject> _activeBullets = new List<GameObject>();


    [SerializeField] private AudioSource _platformRotation;
    [SerializeField] private AudioSource _GetingOfScorePoint;
    [SerializeField] private AudioSource _touchingOfBall;

    [SerializeField] private int _numberOfFirstBullets = 5;

    private PrefabStorage _prefabStorage;

    public List<GameObject> PoolOfBullets
    {
        get { return _poolOfBullets; }
        set { _poolOfBullets = value; }
    }
    public List<GameObject> ActiveBullets
    {
        get { return _activeBullets; }
        set { _activeBullets = value; }
    }
    public AudioSource PlatformRotation
    {
        get { return _platformRotation; }
    }
    public AudioSource GetingOfScorePoint
    {
        get { return _GetingOfScorePoint; }
    }
    public AudioSource TouchingOfBall
    {
        get { return _touchingOfBall; }
    }
    public int NumberOfFirstBullets
    {
        get { return _numberOfFirstBullets; }
    }

    private void Awake()
    {
        _prefabStorage = GetComponent<PrefabStorage>();
        if (instance == null)
        {
            instance = this;
        }
    }

    public GameObject GetValidBullet()
    {
        if(_poolOfBullets.Any())
        {
            GameObject bullet = _poolOfBullets.Last();
            BulletData bulletData = bullet.GetComponent<BulletData>();
            bulletData.IndexInActiveList = _activeBullets.Count;
            _activeBullets.Add(bullet);
            _poolOfBullets.RemoveAt(_poolOfBullets.Count - 1);
            return bullet;
        }
        else
        {
            PoolObjectCreator poolObjectCreator = new PoolObjectCreator();
            poolObjectCreator.CreateObjectForPool(_prefabStorage.Bullet, _poolOfBullets);

            GameObject bullet = _poolOfBullets.Last();
            BulletData BulletData = bullet.GetComponent<BulletData>();
            BulletData.IndexInActiveList = _activeBullets.Count;
            _activeBullets.Add(bullet);
            _poolOfBullets.RemoveAt(_poolOfBullets.Count - 1);
            return bullet;
        }
    }
}
