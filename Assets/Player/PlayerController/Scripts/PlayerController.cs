using GJAM4.Map;
using GJAM4.Player.PlayerUI;
using UnityEngine;

namespace GJAM4.Player
{
    /// <summary>
    /// This class handles making the player interact with the world
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        #region Variables

        [Header("Scripts")]

        [SerializeField] private ScreenSwapper _screenSwapper;

        [SerializeField] private MovementPoint _currentPointLocatedOn;

        #endregion

        #region Methods

        public void MoveForwardToNextPoint()
        {
            if (_currentPointLocatedOn.GetCanMoveForwardValue())
            {
                transform.position = _currentPointLocatedOn.GetTransformComponent().position;
                _screenSwapper.SwapScreens(_currentPointLocatedOn.GetSpriteToChangeForForward());
                _currentPointLocatedOn = _currentPointLocatedOn.GetMovementPointAhead();

                MoveButtonManager.instance.ToggleButtons(_currentPointLocatedOn.GetCanMoveForwardValue(), _currentPointLocatedOn.GetCanTurnLeftValue(), _currentPointLocatedOn.GetCanTurnRightValue());
            }

        }

        public void TurnLeft()
        {
            if (_currentPointLocatedOn.GetCanTurnLeftValue())
            {
                transform.LookAt(_currentPointLocatedOn.GetTransformComponent().position);
                transform.position = _currentPointLocatedOn.GetTransformComponent().position;
                _screenSwapper.SwapScreens(_currentPointLocatedOn.GetSpriteToChangeForLeft());
                _currentPointLocatedOn = _currentPointLocatedOn.GetMovementPointToLeft();

                MoveButtonManager.instance.ToggleButtons(_currentPointLocatedOn.GetCanMoveForwardValue(), _currentPointLocatedOn.GetCanTurnLeftValue(), _currentPointLocatedOn.GetCanTurnRightValue());
            }
        }

        public void TurnRight()
        {
            if (_currentPointLocatedOn.GetCanTurnRightValue())
            {
                transform.LookAt(_currentPointLocatedOn.GetTransformComponent().position);
                transform.position = _currentPointLocatedOn.GetTransformComponent().position;
                _screenSwapper.SwapScreens(_currentPointLocatedOn.GetSpriteToChangeForRight());
                _currentPointLocatedOn = _currentPointLocatedOn.GetMovementPointToRight();

                MoveButtonManager.instance.ToggleButtons(_currentPointLocatedOn.GetCanMoveForwardValue(), _currentPointLocatedOn.GetCanTurnLeftValue(), _currentPointLocatedOn.GetCanTurnRightValue());
            }
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