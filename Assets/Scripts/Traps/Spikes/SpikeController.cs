using System.Collections;
using UnityEngine;
using DataScripts;

public class SpikeController : MonoBehaviour
{
    [SerializeField] private SpikeData _spikeData;

    private Coroutine _coroutine;

    private void Awake()
    {
        if (_spikeData == null)
        {
            if (gameObject.GetComponent<SpikeData>())
            {
                _spikeData = gameObject.GetComponent<SpikeData>();
            }
            else
            {
                gameObject.AddComponent<SpikeData>();
                _spikeData = gameObject.GetComponent<SpikeData>();
            }
        }
    }

    private void OnEnable()
    {
        _coroutine = StartCoroutine(RestartSpikes(_spikeData.RestarTime, _spikeData.TimeOfStartingTrap, _spikeData.Animator));
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

    private IEnumerator RestartSpikes(float restartTime, float timeOfStartingTrap, Animator animator)
    {
        yield return new WaitForSeconds(timeOfStartingTrap);

        while (true)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            animator.Play("SpikeMoveDown", 0, 0.0f);

            yield return new WaitForSeconds(restartTime);

            gameObject.GetComponent<BoxCollider>().enabled = true;
            animator.Play("SpikeMoveUp", 0, 0.0f);

            yield return new WaitForSeconds(restartTime);
        }
    }
}
