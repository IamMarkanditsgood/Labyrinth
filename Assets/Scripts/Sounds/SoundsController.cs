using UnityEngine;

public class SoundsController : MonoBehaviour
{
    [SerializeField] private ObjectStorage _objectStorage;
    [SerializeField] private PlatformRotate _platformRotate;
    [SerializeField] private BallController _ballController;

    private bool _isPlatformSoundActive = false;

    private void Start()
    {
        if (_objectStorage == null)
        {
            _objectStorage = ObjectStorage.instance;
        }
        _ballController.ActionScorePoint += GetScorePoint;
        _ballController.ActionTouched += TochSound;
        _platformRotate.ActionPlatformRotation += PlatformRotationSound;
    }
    private void OnDestroy()
    {
        _ballController.ActionScorePoint -= GetScorePoint;
        _ballController.ActionTouched -= TochSound;

        _platformRotate.ActionPlatformRotation -= PlatformRotationSound;
    }
    public void PlatformRotationSoundOff()
    {
        
        if (_isPlatformSoundActive == true)
        {
            print("fack");
            _objectStorage.PlatformRotation.Stop();
            _isPlatformSoundActive = false;
        }
    }
    private void PlatformRotationSound()
    {
       
        if (_isPlatformSoundActive == false)
        {
            print("sdsd");
            _objectStorage.PlatformRotation.Play();
            _isPlatformSoundActive = true;
        }
    }

    private void TochSound()
    {
        _objectStorage.TouchingOfBall.Play();
    }
    private void GetScorePoint()
    {
        _objectStorage.GetingOfScorePoint.Play();
    }
}
