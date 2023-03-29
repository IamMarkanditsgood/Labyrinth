using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabilisatonButton : MonoBehaviour
{
    [SerializeField] private GameObject _platform;
    public void Stabilization()
    {
        _platform.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
