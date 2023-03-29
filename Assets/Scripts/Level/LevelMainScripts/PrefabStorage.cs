using UnityEngine;

public class PrefabStorage : MonoBehaviour
{
    public static PrefabStorage instance;

    [SerializeField] private GameObject _bullet;

    public GameObject Bullet
    {
        get { return _bullet; }
        set { _bullet = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
