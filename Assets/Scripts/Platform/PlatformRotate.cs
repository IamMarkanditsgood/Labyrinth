using System;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    [Range(0f, 300f)]
    [SerializeField] private float RtD = 0;

    [SerializeField] private SoundsController _soundsController;

    public event Action ActionPlatformRotation;

    private Gyroscope gyro;

    private bool gyroSupported;

    private void Start()
    {
        gyroSupported = SystemInfo.supportsGyroscope;

        if (gyroSupported)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
        RtD = 57.324f;// 57.324f
    }
    private void FixedUpdate()
    {
        if (gyro != null)
        {
            RotatePlatform();
        }
    }

    private void RotatePlatform()
    {
        if (gyro.rotationRate.magnitude > 0.1f)
        {
            ActionPlatformRotation?.Invoke();
            transform.Rotate(-gyro.rotationRate.x * Time.deltaTime * RtD, gyro.rotationRate.z * Time.deltaTime * RtD * 0f, -gyro.rotationRate.y * Time.deltaTime * RtD);
        }
        else
        {
            _soundsController.PlatformRotationSoundOff();
        }
    }
}
