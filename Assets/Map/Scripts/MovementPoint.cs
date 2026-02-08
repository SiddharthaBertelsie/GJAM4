using UnityEngine;
using GJAM4.Player;
using GJAM4.Player.PlayerUI;

namespace GJAM4.Map
{
    public class MovementPoint : MonoBehaviour
    {
        #region Variables

        [SerializeField] private bool _startingPoint;

        [Header("Data")]

        [SerializeField] private bool _canMoveForward;

        [SerializeField] private bool _canTurnLeft;

        [SerializeField] private bool _canTurnRight;

        [SerializeField] private Transform _transform;

        [Header("Movement Points")]

        [SerializeField] private MovementPoint _movementPointAhead;

        [SerializeField] private MovementPoint _movementPointToLeft;

        [SerializeField] private MovementPoint _movementPointToRight;

        [Header("Screens")]

        [SerializeField] private Sprite _screenForward;

        [SerializeField] private Sprite _screenLeft;

        [SerializeField] private Sprite _screenRight;

        [Tooltip("This is the screen the starting point will set the screen to when the game starts")]

        [SerializeField] private Sprite _startingScreen;

        [Header("Scripts")]

        [SerializeField] private ScreenSwapper _screenSwapper;

        #endregion

        #region Methods

        public bool GetCanMoveForwardValue()
        {
            return _canMoveForward;
        }

        public bool GetCanTurnLeftValue()
        {
            return _canTurnLeft;
        }

        public bool GetCanTurnRightValue()
        {
            return _canTurnRight;
        }

        public Transform GetTransformComponent()
        {
            return _transform;
        }

        public Sprite GetSpriteToChangeForForward()
        {
            return _screenForward;
        }

        public Sprite GetSpriteToChangeForLeft()
        {
            return _screenLeft;
        }

        public Sprite GetSpriteToChangeForRight()
        {
            return _screenLeft;
        }

        // NOTE: Use Getters/Setters next time!

        public MovementPoint GetMovementPointAhead()
        {
            return _movementPointAhead;
        }

        public MovementPoint GetMovementPointToLeft()
        {
            return _movementPointToLeft;
        }

        public MovementPoint GetMovementPointToRight()
        {
            return _movementPointToRight;
        }

        private void CheckIfStartingPoint()
        {
            if (_startingPoint)
            {
                _screenSwapper.SwapScreens(_startingScreen);
            }
        }

        private void InitializeScripts()
        {
            MoveButtonManager.instance.ToggleButtons(_canMoveForward, _canTurnLeft, _canTurnRight);
        }

        #endregion

        #region Unity Methods

        private void Start()
        {
            CheckIfStartingPoint();
            InitializeScripts();
        }

        #endregion
    }
}