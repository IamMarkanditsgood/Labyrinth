using System.Collections;
using UnityEngine;

namespace GeneralScripts
{
    public class Cleaner : MonoBehaviour
    {
        private ICleaner cleaner;

        private Coroutine _coroutine;

        private void OnEnable()
        {
            cleaner = GetComponent<ICleaner>();
            float timeForClean = cleaner.GetTimeForCleane();
            _coroutine = StartCoroutine(Clean(timeForClean));
        }
        private void OnDisable()
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
        }
        private void OnDestroy()
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
        }

        private IEnumerator Clean(float timeForClean)
        {
            yield return new WaitForSeconds(timeForClean);
            RestartObject();
        }

        public void RestartObject()
        {
            gameObject.SetActive(false);
            cleaner.RestartObject();
            Destroy(gameObject.GetComponent<Cleaner>());
        }

    }
}
