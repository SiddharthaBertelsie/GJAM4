using UnityEngine;
using UnityEngine.InputSystem;

namespace GJAM4.Player
{
    public class PlayerInputManager : MonoBehaviour
    {
        #region Variables

        [Header("Input System")]

        [SerializeField] private InputActionAsset _inputActionAsset;

        private InputActionMap _playerActionMap;

        private InputAction _interact;

        [Header("Scripts")]

        [SerializeField] private PlayerController _playerController;

        #endregion

        #region Methods

        private void CheckForInteractPerformed()
        {
            if (_interact.WasPerformedThisFrame())
            {

            }
        }

        private void InitializeVariables()
        {
            _playerActionMap = _inputActionAsset.FindActionMap("Player (GJAM4)");

            _interact = _playerActionMap.FindAction("Interact");
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            InitializeVariables();
        }

        // Update is called once per frame
        void Update()
        {
            CheckForInteractPerformed();
        }

        #endregion
    }
}