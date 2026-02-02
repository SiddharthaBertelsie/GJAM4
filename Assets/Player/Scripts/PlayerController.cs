using UnityEngine;

namespace GJAM4.Player
{
    public class PlayerController : MonoBehaviour
    {
        #region Variables

        [Header("Scripts")]

        [SerializeField] private ScreenSwapper _screenSwapper;

        #endregion

        #region Methods

        public void Interact()
        {
            _screenSwapper.SwapScreens();
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion
    }
}