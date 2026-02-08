using UnityEngine;

namespace GJAM4.Player.PlayerUI
{
    public class MoveButtonManager : MonoBehaviour
    {
        #region Variables

        [Header("Buttons")]

        [Tooltip("The canvas that the buttons are on. We only want to enable this when the player is on the respective point so as not to slow the game down")]

        [SerializeField] private GameObject _buttons;

        [SerializeField] private GameObject _moveForwardButton;

        [SerializeField] private GameObject _turnLeftButton;

        [SerializeField] private GameObject _turnRightButton;

        public static MoveButtonManager instance;

        #endregion

        #region Methods

        /// <summary>
        /// Toggles the move buttons in order of forward, left, and right based on the bool values entered in the parameters
        /// </summary>
        /// <param name="canMoveForward"></param>
        /// <param name="canTurnLeft"></param>
        /// <param name="canTurnRight"></param>
        public void ToggleButtons(bool canMoveForward, bool canTurnLeft, bool canTurnRight)
        {
            _moveForwardButton.SetActive(canMoveForward);
            _turnLeftButton.SetActive(canTurnLeft);
            _turnRightButton.SetActive(canTurnRight);
        }

        #endregion

        #region Unity Methods

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

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