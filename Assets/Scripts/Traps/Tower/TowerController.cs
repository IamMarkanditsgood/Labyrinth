using DataScripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralScripts;

public class TowerController : MonoBehaviour
{
    [SerializeField] private TowerData _towerData;

    private Coroutine _coroutine;

    private void Awake()
    {
        if (_towerData == null)
        {
            if (gameObject.GetComponent<TowerData>())
            {
                _towerData = gameObject.GetComponent<TowerData>();
            }
            else
            {
                gameObject.AddComponent<TowerData>();
                _towerData = gameObject.GetComponent<TowerData>();
            }
        }
    }

    private void OnEnable()
    {
        _coroutine = StartCoroutine(TowerShot(_towerData.TimeOfStartingTrap, _towerData.RechargeTime, _towerData.StartShootPosition));
    }
    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }
    private void OnDestroy()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator TowerShot(float timeOfStartingTrap, float rechargeTime, Transform startShootPosition)
    {
        yield return new WaitForSeconds(timeOfStartingTrap);

        while (true)
        {
            Shoot(startShootPosition);
            yield return new WaitForSeconds(rechargeTime);
        }
    }

    private void Shoot(Transform startShootPosition)
    {
        ObjectStorage objectStorage = ObjectStorage.instance;
        GameObject bullet = objectStorage.GetValidBullet();
        bullet.transform.position = startShootPosition.position;
        bullet.transform.rotation = startShootPosition.rotation;
        bullet.SetActive(true);
        bullet.AddComponent<Cleaner>();
    }
}
