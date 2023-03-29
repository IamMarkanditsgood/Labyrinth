using UnityEngine;
using DataScripts;
using GeneralScripts;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletData _bulletData;

    private void Start()
    {
        if (_bulletData == null)
        {
            _bulletData = gameObject.GetComponent<BulletData>();
        }
    }
    private void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.forward * _bulletData.SpeedOfBullet * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer != LayerMask.NameToLayer("Enemy") && collider.gameObject.layer != LayerMask.NameToLayer("Trap"))
        {
            Cleaner cleaner = gameObject.GetComponent<Cleaner>();
            cleaner.RestartObject();
        }
    }
}
