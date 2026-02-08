using UnityEngine;
using UnityEngine.UI;

namespace GJAM4.Player
{
    /// <summary>
    /// This class handles swapping between different views of the game world
    /// depending on wheree player is and where they're looking at
    /// </summary>
    public class ScreenSwapper : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Image _playerScreen;

        #endregion

        #region Methods

        public void SwapScreens(Sprite screenToSwapTo)
        {
            _playerScreen.sprite = screenToSwapTo;
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