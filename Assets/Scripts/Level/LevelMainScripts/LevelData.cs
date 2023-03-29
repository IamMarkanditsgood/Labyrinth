using UnityEngine;

namespace DataScripts
{
    public class LevelData : MonoBehaviour
    {
        public static LevelData instance;

        [SerializeField] private LevelController levelController;

        [SerializeField] private Transform _ammunitionContainer;

        [SerializeField] int _score;

        public LevelController LevelController
        {
            get { return levelController; }
        }

        public Transform AmmunitionContainer
        {
            get { return _ammunitionContainer;}
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }
    }
}
